using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Xml.Linq;

namespace ChatMulticast
{
    public partial class Form1 : Form
    {
        IPAddress IpAddress { get; set; }
        int Port { get; set; }

        Task? receiveTask;

        private UdpClient udpClient;
        public Form1()
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if(textBoxName.Text.Length == 0)
            {
                MessageBox.Show("Name is empty!");
                return;
            }

            textBoxName.Enabled = false;

            buttonConnect.Enabled = false;
            buttonDisconnect.Enabled = true;

            IpAddress = IPAddress.Parse(textBoxIP.Text);
            Port = Convert.ToInt32(textBoxPort.Text);
            udpClient = new UdpClient();
            udpClient.ExclusiveAddressUse = false;
            udpClient.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            udpClient.Client.Bind(new IPEndPoint(IPAddress.Any, Port));

            udpClient.JoinMulticastGroup(IpAddress);
            receiveTask = Task.Run(ReceiveMessages);
        }

        private async Task ReceiveMessages()
        {
            try
            {
                while (true)
                {
                    var data = await udpClient.ReceiveAsync();
                    string message = Encoding.Default.GetString(data.Buffer);
                    textBoxLog.Invoke(new Action<string>(AddText), message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void AddText(string str)
        {
            StringBuilder stringBuilder = new StringBuilder(textBoxLog.Text);

            stringBuilder.AppendLine(str);

            textBoxLog.Text = stringBuilder.ToString();
        }

        private async void buttonSend_Click(object sender, EventArgs e)
        {
            try
            {
                string message = $"{textBoxName.Text}: {textBoxMessage.Text} ({DateTime.Now})";
                textBoxMessage.Clear();
                byte[] data = Encoding.Default.GetBytes(message);
                await udpClient.SendAsync(data, data.Length, new IPEndPoint(IpAddress, Port));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            receiveTask = null;
            textBoxName.Enabled = true;
            buttonConnect.Enabled = true;
            buttonDisconnect.Enabled = false;
            udpClient?.DropMulticastGroup(IpAddress);
            udpClient?.Close();
            udpClient = null;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (receiveTask != null) buttonDisconnect_Click(null, null);
        }
    }
}

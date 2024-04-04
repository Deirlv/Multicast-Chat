namespace ChatMulticast
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxIP = new TextBox();
            textBoxPort = new TextBox();
            buttonDisconnect = new Button();
            buttonConnect = new Button();
            textBoxName = new TextBox();
            textBoxMessage = new TextBox();
            buttonSend = new Button();
            textBoxLog = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // textBoxIP
            // 
            textBoxIP.Location = new Point(12, 34);
            textBoxIP.Name = "textBoxIP";
            textBoxIP.Size = new Size(146, 23);
            textBoxIP.TabIndex = 0;
            textBoxIP.Text = "239.0.0.1";
            // 
            // textBoxPort
            // 
            textBoxPort.Location = new Point(177, 35);
            textBoxPort.Name = "textBoxPort";
            textBoxPort.Size = new Size(100, 23);
            textBoxPort.TabIndex = 1;
            textBoxPort.Text = "8001";
            // 
            // buttonDisconnect
            // 
            buttonDisconnect.Enabled = false;
            buttonDisconnect.Location = new Point(293, 63);
            buttonDisconnect.Name = "buttonDisconnect";
            buttonDisconnect.Size = new Size(95, 23);
            buttonDisconnect.TabIndex = 2;
            buttonDisconnect.Text = "Disconnect";
            buttonDisconnect.UseVisualStyleBackColor = true;
            buttonDisconnect.Click += buttonDisconnect_Click;
            // 
            // buttonConnect
            // 
            buttonConnect.Location = new Point(293, 34);
            buttonConnect.Name = "buttonConnect";
            buttonConnect.Size = new Size(95, 23);
            buttonConnect.TabIndex = 3;
            buttonConnect.Text = "Connect";
            buttonConnect.UseVisualStyleBackColor = true;
            buttonConnect.Click += buttonConnect_Click;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(12, 426);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(146, 23);
            textBoxName.TabIndex = 4;
            // 
            // textBoxMessage
            // 
            textBoxMessage.Location = new Point(12, 470);
            textBoxMessage.Multiline = true;
            textBoxMessage.Name = "textBoxMessage";
            textBoxMessage.Size = new Size(477, 74);
            textBoxMessage.TabIndex = 5;
            // 
            // buttonSend
            // 
            buttonSend.Location = new Point(404, 552);
            buttonSend.Name = "buttonSend";
            buttonSend.Size = new Size(85, 23);
            buttonSend.TabIndex = 6;
            buttonSend.Text = "Send";
            buttonSend.UseVisualStyleBackColor = true;
            buttonSend.Click += buttonSend_Click;
            // 
            // textBoxLog
            // 
            textBoxLog.Location = new Point(12, 97);
            textBoxLog.Multiline = true;
            textBoxLog.Name = "textBoxLog";
            textBoxLog.Size = new Size(477, 305);
            textBoxLog.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 8;
            label1.Text = "Multicast Group IP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(177, 16);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 9;
            label2.Text = "Port";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 408);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 10;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 452);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 11;
            label4.Text = "Message:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(501, 585);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxLog);
            Controls.Add(buttonSend);
            Controls.Add(textBoxMessage);
            Controls.Add(textBoxName);
            Controls.Add(buttonConnect);
            Controls.Add(buttonDisconnect);
            Controls.Add(textBoxPort);
            Controls.Add(textBoxIP);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxIP;
        private TextBox textBoxPort;
        private Button buttonDisconnect;
        private Button buttonConnect;
        private TextBox textBoxName;
        private TextBox textBoxMessage;
        private Button buttonSend;
        private TextBox textBoxLog;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}

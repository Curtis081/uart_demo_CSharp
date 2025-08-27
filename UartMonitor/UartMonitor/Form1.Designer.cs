namespace UartMonitor
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ReceiveDataRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SendDataRichTextBox = new System.Windows.Forms.RichTextBox();
            this.BaudRateLabel = new System.Windows.Forms.Label();
            this.ReScanButton = new System.Windows.Forms.Button();
            this.SendDataGroupBox = new System.Windows.Forms.GroupBox();
            this.ClearSendButton = new System.Windows.Forms.Button();
            this.SendDataButton = new System.Windows.Forms.Button();
            this.PortComboBox = new System.Windows.Forms.ComboBox();
            this.BuadRateComboBox = new System.Windows.Forms.ComboBox();
            this.StopBitComboBox = new System.Windows.Forms.ComboBox();
            this.StopBitsLabel = new System.Windows.Forms.Label();
            this.DataBitsComboBox = new System.Windows.Forms.ComboBox();
            this.DataBitsLabel = new System.Windows.Forms.Label();
            this.ParityComboBox = new System.Windows.Forms.ComboBox();
            this.ParityLabel = new System.Windows.Forms.Label();
            this.OpenComPortButton = new System.Windows.Forms.Button();
            this.ClearReceivedButton = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.SaveReceivedButton = new System.Windows.Forms.Button();
            this.SendDataGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ReceiveDataRichTextBox
            // 
            this.ReceiveDataRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReceiveDataRichTextBox.Location = new System.Drawing.Point(12, 12);
            this.ReceiveDataRichTextBox.Name = "ReceiveDataRichTextBox";
            this.ReceiveDataRichTextBox.Size = new System.Drawing.Size(212, 174);
            this.ReceiveDataRichTextBox.TabIndex = 1;
            this.ReceiveDataRichTextBox.Text = "";
            // 
            // SendDataRichTextBox
            // 
            this.SendDataRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SendDataRichTextBox.Location = new System.Drawing.Point(12, 192);
            this.SendDataRichTextBox.Name = "SendDataRichTextBox";
            this.SendDataRichTextBox.Size = new System.Drawing.Size(212, 157);
            this.SendDataRichTextBox.TabIndex = 2;
            this.SendDataRichTextBox.Text = "";
            // 
            // BaudRateLabel
            // 
            this.BaudRateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BaudRateLabel.AutoSize = true;
            this.BaudRateLabel.Location = new System.Drawing.Point(263, 49);
            this.BaudRateLabel.Name = "BaudRateLabel";
            this.BaudRateLabel.Size = new System.Drawing.Size(50, 12);
            this.BaudRateLabel.TabIndex = 3;
            this.BaudRateLabel.Text = "Baud rate";
            // 
            // ReScanButton
            // 
            this.ReScanButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ReScanButton.Location = new System.Drawing.Point(241, 12);
            this.ReScanButton.Name = "ReScanButton";
            this.ReScanButton.Size = new System.Drawing.Size(75, 23);
            this.ReScanButton.TabIndex = 4;
            this.ReScanButton.Text = "Rescan port";
            this.ReScanButton.UseVisualStyleBackColor = true;
            this.ReScanButton.Click += new System.EventHandler(this.ReScanButton_Click);
            // 
            // SendDataGroupBox
            // 
            this.SendDataGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SendDataGroupBox.Controls.Add(this.ClearSendButton);
            this.SendDataGroupBox.Controls.Add(this.SendDataButton);
            this.SendDataGroupBox.Location = new System.Drawing.Point(241, 220);
            this.SendDataGroupBox.Name = "SendDataGroupBox";
            this.SendDataGroupBox.Size = new System.Drawing.Size(200, 100);
            this.SendDataGroupBox.TabIndex = 5;
            this.SendDataGroupBox.TabStop = false;
            this.SendDataGroupBox.Text = "Send data";
            // 
            // ClearSendButton
            // 
            this.ClearSendButton.Location = new System.Drawing.Point(111, 48);
            this.ClearSendButton.Name = "ClearSendButton";
            this.ClearSendButton.Size = new System.Drawing.Size(75, 23);
            this.ClearSendButton.TabIndex = 6;
            this.ClearSendButton.Text = "Clear send";
            this.ClearSendButton.UseVisualStyleBackColor = true;
            this.ClearSendButton.Click += new System.EventHandler(this.ClearSendButton_Click);
            // 
            // SendDataButton
            // 
            this.SendDataButton.Location = new System.Drawing.Point(15, 48);
            this.SendDataButton.Name = "SendDataButton";
            this.SendDataButton.Size = new System.Drawing.Size(75, 23);
            this.SendDataButton.TabIndex = 7;
            this.SendDataButton.Text = "send";
            this.SendDataButton.Click += new System.EventHandler(this.SendDataButton_Click);
            // 
            // PortComboBox
            // 
            this.PortComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PortComboBox.FormattingEnabled = true;
            this.PortComboBox.Location = new System.Drawing.Point(335, 15);
            this.PortComboBox.Name = "PortComboBox";
            this.PortComboBox.Size = new System.Drawing.Size(121, 20);
            this.PortComboBox.TabIndex = 6;
            // 
            // BuadRateComboBox
            // 
            this.BuadRateComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BuadRateComboBox.FormattingEnabled = true;
            this.BuadRateComboBox.Items.AddRange(new object[] {
            "9600",
            "115200"});
            this.BuadRateComboBox.Location = new System.Drawing.Point(335, 46);
            this.BuadRateComboBox.Name = "BuadRateComboBox";
            this.BuadRateComboBox.Size = new System.Drawing.Size(121, 20);
            this.BuadRateComboBox.TabIndex = 7;
            // 
            // StopBitComboBox
            // 
            this.StopBitComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StopBitComboBox.FormattingEnabled = true;
            this.StopBitComboBox.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.StopBitComboBox.Location = new System.Drawing.Point(335, 72);
            this.StopBitComboBox.Name = "StopBitComboBox";
            this.StopBitComboBox.Size = new System.Drawing.Size(121, 20);
            this.StopBitComboBox.TabIndex = 9;
            // 
            // StopBitsLabel
            // 
            this.StopBitsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StopBitsLabel.AutoSize = true;
            this.StopBitsLabel.Location = new System.Drawing.Point(263, 75);
            this.StopBitsLabel.Name = "StopBitsLabel";
            this.StopBitsLabel.Size = new System.Drawing.Size(45, 12);
            this.StopBitsLabel.TabIndex = 8;
            this.StopBitsLabel.Text = "Stop bits";
            // 
            // DataBitsComboBox
            // 
            this.DataBitsComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DataBitsComboBox.FormattingEnabled = true;
            this.DataBitsComboBox.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.DataBitsComboBox.Location = new System.Drawing.Point(335, 98);
            this.DataBitsComboBox.Name = "DataBitsComboBox";
            this.DataBitsComboBox.Size = new System.Drawing.Size(121, 20);
            this.DataBitsComboBox.TabIndex = 11;
            // 
            // DataBitsLabel
            // 
            this.DataBitsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DataBitsLabel.AutoSize = true;
            this.DataBitsLabel.Location = new System.Drawing.Point(263, 101);
            this.DataBitsLabel.Name = "DataBitsLabel";
            this.DataBitsLabel.Size = new System.Drawing.Size(45, 12);
            this.DataBitsLabel.TabIndex = 10;
            this.DataBitsLabel.Text = "Data bits";
            // 
            // ParityComboBox
            // 
            this.ParityComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ParityComboBox.FormattingEnabled = true;
            this.ParityComboBox.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.ParityComboBox.Location = new System.Drawing.Point(335, 124);
            this.ParityComboBox.Name = "ParityComboBox";
            this.ParityComboBox.Size = new System.Drawing.Size(121, 20);
            this.ParityComboBox.TabIndex = 13;
            // 
            // ParityLabel
            // 
            this.ParityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ParityLabel.AutoSize = true;
            this.ParityLabel.Location = new System.Drawing.Point(263, 127);
            this.ParityLabel.Name = "ParityLabel";
            this.ParityLabel.Size = new System.Drawing.Size(32, 12);
            this.ParityLabel.TabIndex = 12;
            this.ParityLabel.Text = "Parity";
            // 
            // OpenComPortButton
            // 
            this.OpenComPortButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenComPortButton.Location = new System.Drawing.Point(352, 156);
            this.OpenComPortButton.Name = "OpenComPortButton";
            this.OpenComPortButton.Size = new System.Drawing.Size(104, 23);
            this.OpenComPortButton.TabIndex = 15;
            this.OpenComPortButton.Text = "Open COM port";
            this.OpenComPortButton.UseVisualStyleBackColor = true;
            this.OpenComPortButton.Click += new System.EventHandler(this.OpenComPortButton_Click);
            // 
            // ClearReceivedButton
            // 
            this.ClearReceivedButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearReceivedButton.Location = new System.Drawing.Point(352, 185);
            this.ClearReceivedButton.Name = "ClearReceivedButton";
            this.ClearReceivedButton.Size = new System.Drawing.Size(104, 23);
            this.ClearReceivedButton.TabIndex = 16;
            this.ClearReceivedButton.Text = "Clear received";
            this.ClearReceivedButton.UseVisualStyleBackColor = true;
            this.ClearReceivedButton.Click += new System.EventHandler(this.ClearReceivedButton_Click);
            // 
            // SaveReceivedButton
            // 
            this.SaveReceivedButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveReceivedButton.Location = new System.Drawing.Point(241, 185);
            this.SaveReceivedButton.Name = "SaveReceivedButton";
            this.SaveReceivedButton.Size = new System.Drawing.Size(104, 23);
            this.SaveReceivedButton.TabIndex = 17;
            this.SaveReceivedButton.Text = "Save received";
            this.SaveReceivedButton.UseVisualStyleBackColor = true;
            this.SaveReceivedButton.Click += new System.EventHandler(this.SaveReceivedButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.SaveReceivedButton);
            this.Controls.Add(this.ClearReceivedButton);
            this.Controls.Add(this.OpenComPortButton);
            this.Controls.Add(this.ParityComboBox);
            this.Controls.Add(this.ParityLabel);
            this.Controls.Add(this.DataBitsComboBox);
            this.Controls.Add(this.DataBitsLabel);
            this.Controls.Add(this.StopBitComboBox);
            this.Controls.Add(this.StopBitsLabel);
            this.Controls.Add(this.BuadRateComboBox);
            this.Controls.Add(this.PortComboBox);
            this.Controls.Add(this.SendDataGroupBox);
            this.Controls.Add(this.ReScanButton);
            this.Controls.Add(this.BaudRateLabel);
            this.Controls.Add(this.SendDataRichTextBox);
            this.Controls.Add(this.ReceiveDataRichTextBox);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "Form1";
            this.Text = "UartMonitor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SendDataGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox ReceiveDataRichTextBox;
        private System.Windows.Forms.RichTextBox SendDataRichTextBox;
        private System.Windows.Forms.Label BaudRateLabel;
        private System.Windows.Forms.Button ReScanButton;
        private System.Windows.Forms.GroupBox SendDataGroupBox;
        private System.Windows.Forms.Button ClearSendButton;
        private System.Windows.Forms.Button SendDataButton;
        private System.Windows.Forms.ComboBox PortComboBox;
        private System.Windows.Forms.ComboBox BuadRateComboBox;
        private System.Windows.Forms.ComboBox StopBitComboBox;
        private System.Windows.Forms.Label StopBitsLabel;
        private System.Windows.Forms.ComboBox DataBitsComboBox;
        private System.Windows.Forms.Label DataBitsLabel;
        private System.Windows.Forms.ComboBox ParityComboBox;
        private System.Windows.Forms.Label ParityLabel;
        private System.Windows.Forms.Button OpenComPortButton;
        private System.Windows.Forms.Button ClearReceivedButton;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button SaveReceivedButton;
    }
}


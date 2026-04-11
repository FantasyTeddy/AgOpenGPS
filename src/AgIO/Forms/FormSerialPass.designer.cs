namespace AgIO
{
    partial class FormSerialPass
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSerialCancel = new System.Windows.Forms.Button();
            btnSerialOK = new System.Windows.Forms.Button();
            cboxSerialPassOn = new System.Windows.Forms.CheckBox();
            btnCloseSerial = new System.Windows.Forms.Button();
            btnOpenSerial = new System.Windows.Forms.Button();
            cboxBaud = new System.Windows.Forms.ComboBox();
            lblCurrentBaud = new System.Windows.Forms.Label();
            cboxRadioPort = new System.Windows.Forms.ComboBox();
            lblCurrentPort = new System.Windows.Forms.Label();
            btnRescan = new System.Windows.Forms.Button();
            label23 = new System.Windows.Forms.Label();
            label21 = new System.Windows.Forms.Label();
            cboxToSerial = new System.Windows.Forms.CheckBox();
            cboxToUDP = new System.Windows.Forms.CheckBox();
            nudSendToUDPPort = new System.Windows.Forms.NumericUpDown();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)nudSendToUDPPort).BeginInit();
            SuspendLayout();
            // 
            // btnSerialCancel
            // 
            btnSerialCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnSerialCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnSerialCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnSerialCancel.FlatAppearance.BorderSize = 0;
            btnSerialCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSerialCancel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnSerialCancel.Image = Properties.Resources.Cancel64;
            btnSerialCancel.Location = new System.Drawing.Point(480, 422);
            btnSerialCancel.Name = "btnSerialCancel";
            btnSerialCancel.Size = new System.Drawing.Size(88, 64);
            btnSerialCancel.TabIndex = 71;
            btnSerialCancel.UseVisualStyleBackColor = true;
            // 
            // btnSerialOK
            // 
            btnSerialOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnSerialOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnSerialOK.FlatAppearance.BorderSize = 0;
            btnSerialOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSerialOK.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnSerialOK.ForeColor = System.Drawing.SystemColors.ControlText;
            btnSerialOK.Image = Properties.Resources.OK64;
            btnSerialOK.Location = new System.Drawing.Point(593, 422);
            btnSerialOK.Name = "btnSerialOK";
            btnSerialOK.Size = new System.Drawing.Size(88, 64);
            btnSerialOK.TabIndex = 70;
            btnSerialOK.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            btnSerialOK.UseVisualStyleBackColor = true;
            btnSerialOK.Click += btnSerialOK_Click;
            // 
            // cboxSerialPassOn
            // 
            cboxSerialPassOn.Appearance = System.Windows.Forms.Appearance.Button;
            cboxSerialPassOn.BackColor = System.Drawing.Color.Salmon;
            cboxSerialPassOn.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            cboxSerialPassOn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(128, 255, 128);
            cboxSerialPassOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboxSerialPassOn.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            cboxSerialPassOn.Location = new System.Drawing.Point(215, 428);
            cboxSerialPassOn.Name = "cboxSerialPassOn";
            cboxSerialPassOn.Size = new System.Drawing.Size(184, 50);
            cboxSerialPassOn.TabIndex = 163;
            cboxSerialPassOn.Text = "Serial Pass On";
            cboxSerialPassOn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            cboxSerialPassOn.UseVisualStyleBackColor = false;
            cboxSerialPassOn.Click += cboxSerialPassOn_Click;
            // 
            // btnCloseSerial
            // 
            btnCloseSerial.BackColor = System.Drawing.Color.Transparent;
            btnCloseSerial.FlatAppearance.BorderSize = 0;
            btnCloseSerial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCloseSerial.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnCloseSerial.Image = Properties.Resources.USB_Disconnect;
            btnCloseSerial.Location = new System.Drawing.Point(584, 139);
            btnCloseSerial.Name = "btnCloseSerial";
            btnCloseSerial.Size = new System.Drawing.Size(101, 58);
            btnCloseSerial.TabIndex = 176;
            btnCloseSerial.UseVisualStyleBackColor = false;
            btnCloseSerial.Click += btnCloseSerial_Click;
            // 
            // btnOpenSerial
            // 
            btnOpenSerial.BackColor = System.Drawing.Color.Transparent;
            btnOpenSerial.FlatAppearance.BorderSize = 0;
            btnOpenSerial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnOpenSerial.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnOpenSerial.Image = Properties.Resources.USB_Connect;
            btnOpenSerial.Location = new System.Drawing.Point(463, 139);
            btnOpenSerial.Name = "btnOpenSerial";
            btnOpenSerial.Size = new System.Drawing.Size(101, 58);
            btnOpenSerial.TabIndex = 177;
            btnOpenSerial.UseVisualStyleBackColor = false;
            btnOpenSerial.Click += btnOpenSerial_Click;
            // 
            // cboxBaud
            // 
            cboxBaud.BackColor = System.Drawing.SystemColors.ControlLightLight;
            cboxBaud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboxBaud.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            cboxBaud.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            cboxBaud.FormattingEnabled = true;
            cboxBaud.Items.AddRange(new object[] { "4800", "9600", "19200", "38400", "57600", "115200", "128000", "256000" });
            cboxBaud.Location = new System.Drawing.Point(316, 153);
            cboxBaud.Name = "cboxBaud";
            cboxBaud.Size = new System.Drawing.Size(127, 37);
            cboxBaud.TabIndex = 175;
            // 
            // lblCurrentBaud
            // 
            lblCurrentBaud.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblCurrentBaud.Location = new System.Drawing.Point(316, 132);
            lblCurrentBaud.Name = "lblCurrentBaud";
            lblCurrentBaud.Size = new System.Drawing.Size(127, 18);
            lblCurrentBaud.TabIndex = 174;
            lblCurrentBaud.Text = "Baud";
            lblCurrentBaud.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboxRadioPort
            // 
            cboxRadioPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboxRadioPort.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            cboxRadioPort.FormattingEnabled = true;
            cboxRadioPort.Location = new System.Drawing.Point(161, 153);
            cboxRadioPort.Name = "cboxRadioPort";
            cboxRadioPort.Size = new System.Drawing.Size(124, 37);
            cboxRadioPort.TabIndex = 172;
            // 
            // lblCurrentPort
            // 
            lblCurrentPort.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblCurrentPort.Location = new System.Drawing.Point(168, 132);
            lblCurrentPort.Name = "lblCurrentPort";
            lblCurrentPort.Size = new System.Drawing.Size(119, 18);
            lblCurrentPort.TabIndex = 173;
            lblCurrentPort.Text = "Port";
            lblCurrentPort.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblCurrentPort.UseCompatibleTextRendering = true;
            // 
            // btnRescan
            // 
            btnRescan.BackColor = System.Drawing.Color.Transparent;
            btnRescan.FlatAppearance.BorderSize = 0;
            btnRescan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRescan.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnRescan.ForeColor = System.Drawing.SystemColors.ControlText;
            btnRescan.Image = Properties.Resources.ScanPorts;
            btnRescan.Location = new System.Drawing.Point(40, 139);
            btnRescan.Name = "btnRescan";
            btnRescan.Size = new System.Drawing.Size(89, 63);
            btnRescan.TabIndex = 171;
            btnRescan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnRescan.UseVisualStyleBackColor = false;
            btnRescan.Click += btnRescan_Click;
            // 
            // label23
            // 
            label23.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label23.Location = new System.Drawing.Point(132, 250);
            label23.Name = "label23";
            label23.Size = new System.Drawing.Size(337, 31);
            label23.TabIndex = 170;
            label23.Text = "Send NTRIP To GPS Using:";
            label23.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label21.Location = new System.Drawing.Point(228, 40);
            label21.Name = "label21";
            label21.Size = new System.Drawing.Size(156, 29);
            label21.TabIndex = 166;
            label21.Text = "Serial RTCM";
            // 
            // cboxToSerial
            // 
            cboxToSerial.Appearance = System.Windows.Forms.Appearance.Button;
            cboxToSerial.BackColor = System.Drawing.Color.Salmon;
            cboxToSerial.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            cboxToSerial.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(128, 255, 128);
            cboxToSerial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboxToSerial.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            cboxToSerial.Image = Properties.Resources.NtripToSerial;
            cboxToSerial.Location = new System.Drawing.Point(98, 303);
            cboxToSerial.Name = "cboxToSerial";
            cboxToSerial.Size = new System.Drawing.Size(150, 50);
            cboxToSerial.TabIndex = 179;
            cboxToSerial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            cboxToSerial.UseVisualStyleBackColor = false;
            cboxToSerial.Click += cboxToSerial_Click;
            // 
            // cboxToUDP
            // 
            cboxToUDP.Appearance = System.Windows.Forms.Appearance.Button;
            cboxToUDP.BackColor = System.Drawing.Color.Salmon;
            cboxToUDP.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            cboxToUDP.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(128, 255, 128);
            cboxToUDP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboxToUDP.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            cboxToUDP.Image = Properties.Resources.NtripToUDP;
            cboxToUDP.Location = new System.Drawing.Point(355, 300);
            cboxToUDP.Name = "cboxToUDP";
            cboxToUDP.Size = new System.Drawing.Size(150, 50);
            cboxToUDP.TabIndex = 180;
            cboxToUDP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            cboxToUDP.UseVisualStyleBackColor = false;
            cboxToUDP.Click += cboxToUDP_Click;
            // 
            // nudSendToUDPPort
            // 
            nudSendToUDPPort.BackColor = System.Drawing.Color.AliceBlue;
            nudSendToUDPPort.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            nudSendToUDPPort.Location = new System.Drawing.Point(517, 303);
            nudSendToUDPPort.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            nudSendToUDPPort.Name = "nudSendToUDPPort";
            nudSendToUDPPort.Size = new System.Drawing.Size(141, 46);
            nudSendToUDPPort.TabIndex = 178;
            nudSendToUDPPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudSendToUDPPort.Value = new decimal(new int[] { 2233, 0, 0, 0 });
            // 
            // label1
            // 
            label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(250, 319);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(100, 18);
            label1.TabIndex = 181;
            label1.Text = "Or";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            label1.UseCompatibleTextRendering = true;
            // 
            // FormSerialPass
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Gainsboro;
            ClientSize = new System.Drawing.Size(702, 497);
            ControlBox = false;
            Controls.Add(label1);
            Controls.Add(cboxToSerial);
            Controls.Add(cboxToUDP);
            Controls.Add(nudSendToUDPPort);
            Controls.Add(cboxSerialPassOn);
            Controls.Add(btnCloseSerial);
            Controls.Add(btnOpenSerial);
            Controls.Add(cboxBaud);
            Controls.Add(lblCurrentBaud);
            Controls.Add(cboxRadioPort);
            Controls.Add(lblCurrentPort);
            Controls.Add(btnRescan);
            Controls.Add(label23);
            Controls.Add(label21);
            Controls.Add(btnSerialCancel);
            Controls.Add(btnSerialOK);
            Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormSerialPass";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Serial Pass Thru Configuration";
            Load += FormSerialPass_Load;
            ((System.ComponentModel.ISupportInitialize)nudSendToUDPPort).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button btnSerialCancel;
        private System.Windows.Forms.Button btnSerialOK;
        private System.Windows.Forms.CheckBox cboxSerialPassOn;
        private System.Windows.Forms.Button btnCloseSerial;
        private System.Windows.Forms.Button btnOpenSerial;
        private System.Windows.Forms.ComboBox cboxBaud;
        private System.Windows.Forms.Label lblCurrentBaud;
        private System.Windows.Forms.ComboBox cboxRadioPort;
        private System.Windows.Forms.Label lblCurrentPort;
        private System.Windows.Forms.Button btnRescan;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.CheckBox cboxToSerial;
        private System.Windows.Forms.CheckBox cboxToUDP;
        private System.Windows.Forms.NumericUpDown nudSendToUDPPort;
        private System.Windows.Forms.Label label1;
    }
}
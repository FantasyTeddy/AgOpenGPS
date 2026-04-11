namespace AgIO
{
    partial class FormSerialMonitor
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
            components = new System.ComponentModel.Container();
            btnSerialCancel = new System.Windows.Forms.Button();
            cboxPort = new System.Windows.Forms.ComboBox();
            cboxBaud = new System.Windows.Forms.ComboBox();
            lblCurrentPort = new System.Windows.Forms.Label();
            lblCurrentBaud = new System.Windows.Forms.Label();
            btnCloseSerial = new System.Windows.Forms.Button();
            btnOpenSerial = new System.Windows.Forms.Button();
            textBoxRcv = new System.Windows.Forms.TextBox();
            btnRescan = new System.Windows.Forms.Button();
            btnLog = new System.Windows.Forms.Button();
            timer1 = new System.Windows.Forms.Timer(components);
            btnFileSave = new System.Windows.Forms.Button();
            btnClear = new System.Windows.Forms.Button();
            btnHelp = new System.Windows.Forms.Button();
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
            btnSerialCancel.Image = Properties.Resources.OK64;
            btnSerialCancel.Location = new System.Drawing.Point(462, 300);
            btnSerialCancel.Name = "btnSerialCancel";
            btnSerialCancel.Size = new System.Drawing.Size(65, 54);
            btnSerialCancel.TabIndex = 71;
            btnSerialCancel.UseVisualStyleBackColor = true;
            btnSerialCancel.Click += btnSerialCancel_Click;
            // 
            // cboxPort
            // 
            cboxPort.BackColor = System.Drawing.SystemColors.ControlLightLight;
            cboxPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboxPort.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            cboxPort.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            cboxPort.FormattingEnabled = true;
            cboxPort.Location = new System.Drawing.Point(96, 24);
            cboxPort.Name = "cboxPort";
            cboxPort.Size = new System.Drawing.Size(124, 37);
            cboxPort.TabIndex = 538;
            cboxPort.SelectedIndexChanged += cboxPort_SelectedIndexChanged;
            // 
            // cboxBaud
            // 
            cboxBaud.BackColor = System.Drawing.SystemColors.ControlLightLight;
            cboxBaud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboxBaud.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            cboxBaud.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            cboxBaud.FormattingEnabled = true;
            cboxBaud.Items.AddRange(new object[] { "4800", "9600", "19200", "38400", "57600", "115200", "460800" });
            cboxBaud.Location = new System.Drawing.Point(236, 24);
            cboxBaud.Name = "cboxBaud";
            cboxBaud.Size = new System.Drawing.Size(127, 37);
            cboxBaud.TabIndex = 537;
            cboxBaud.SelectedIndexChanged += cboxBaud_SelectedIndexChanged;
            // 
            // lblCurrentPort
            // 
            lblCurrentPort.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblCurrentPort.Location = new System.Drawing.Point(96, 3);
            lblCurrentPort.Name = "lblCurrentPort";
            lblCurrentPort.Size = new System.Drawing.Size(121, 18);
            lblCurrentPort.TabIndex = 536;
            lblCurrentPort.Text = "Port";
            lblCurrentPort.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCurrentBaud
            // 
            lblCurrentBaud.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblCurrentBaud.Location = new System.Drawing.Point(236, 3);
            lblCurrentBaud.Name = "lblCurrentBaud";
            lblCurrentBaud.Size = new System.Drawing.Size(124, 18);
            lblCurrentBaud.TabIndex = 535;
            lblCurrentBaud.Text = "Baud";
            lblCurrentBaud.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCloseSerial
            // 
            btnCloseSerial.BackColor = System.Drawing.Color.Transparent;
            btnCloseSerial.Enabled = false;
            btnCloseSerial.FlatAppearance.BorderSize = 0;
            btnCloseSerial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCloseSerial.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnCloseSerial.Image = Properties.Resources.USB_Disconnect;
            btnCloseSerial.Location = new System.Drawing.Point(467, 6);
            btnCloseSerial.Name = "btnCloseSerial";
            btnCloseSerial.Size = new System.Drawing.Size(56, 58);
            btnCloseSerial.TabIndex = 533;
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
            btnOpenSerial.Location = new System.Drawing.Point(380, 6);
            btnOpenSerial.Name = "btnOpenSerial";
            btnOpenSerial.Size = new System.Drawing.Size(58, 58);
            btnOpenSerial.TabIndex = 534;
            btnOpenSerial.UseVisualStyleBackColor = false;
            btnOpenSerial.Click += btnOpenSerial_Click;
            // 
            // textBoxRcv
            // 
            textBoxRcv.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            textBoxRcv.BackColor = System.Drawing.SystemColors.Window;
            textBoxRcv.Font = new System.Drawing.Font("Tahoma", 9.75F);
            textBoxRcv.Location = new System.Drawing.Point(12, 69);
            textBoxRcv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            textBoxRcv.Multiline = true;
            textBoxRcv.Name = "textBoxRcv";
            textBoxRcv.ReadOnly = true;
            textBoxRcv.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            textBoxRcv.Size = new System.Drawing.Size(521, 219);
            textBoxRcv.TabIndex = 539;
            // 
            // btnRescan
            // 
            btnRescan.BackColor = System.Drawing.Color.Transparent;
            btnRescan.FlatAppearance.BorderSize = 0;
            btnRescan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRescan.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnRescan.ForeColor = System.Drawing.SystemColors.ControlText;
            btnRescan.Image = Properties.Resources.ScanPorts;
            btnRescan.Location = new System.Drawing.Point(3, 3);
            btnRescan.Name = "btnRescan";
            btnRescan.Size = new System.Drawing.Size(61, 63);
            btnRescan.TabIndex = 540;
            btnRescan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnRescan.UseVisualStyleBackColor = false;
            btnRescan.Click += btnRescan_Click;
            // 
            // btnLog
            // 
            btnLog.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnLog.BackColor = System.Drawing.Color.Transparent;
            btnLog.FlatAppearance.BorderSize = 0;
            btnLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLog.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnLog.Image = Properties.Resources.LogNMEA;
            btnLog.Location = new System.Drawing.Point(363, 300);
            btnLog.Name = "btnLog";
            btnLog.Size = new System.Drawing.Size(65, 54);
            btnLog.TabIndex = 541;
            btnLog.UseVisualStyleBackColor = false;
            btnLog.Click += btnLog_Click;
            // 
            // timer1
            // 
            timer1.Interval = 333;
            timer1.Tick += timer1_Tick;
            // 
            // btnFileSave
            // 
            btnFileSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnFileSave.BackColor = System.Drawing.Color.Transparent;
            btnFileSave.FlatAppearance.BorderSize = 0;
            btnFileSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnFileSave.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnFileSave.Image = Properties.Resources.VehFileSave;
            btnFileSave.Location = new System.Drawing.Point(269, 300);
            btnFileSave.Name = "btnFileSave";
            btnFileSave.Size = new System.Drawing.Size(65, 54);
            btnFileSave.TabIndex = 542;
            btnFileSave.UseVisualStyleBackColor = false;
            btnFileSave.Click += btnFileSave_Click;
            // 
            // btnClear
            // 
            btnClear.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnClear.BackColor = System.Drawing.Color.Transparent;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClear.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnClear.Image = Properties.Resources.Trash;
            btnClear.Location = new System.Drawing.Point(175, 300);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(65, 54);
            btnClear.TabIndex = 543;
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnHelp
            // 
            btnHelp.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnHelp.FlatAppearance.BorderSize = 0;
            btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnHelp.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnHelp.ForeColor = System.Drawing.SystemColors.ControlText;
            btnHelp.Image = Properties.Resources.Help;
            btnHelp.Location = new System.Drawing.Point(34, 300);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new System.Drawing.Size(65, 54);
            btnHelp.TabIndex = 544;
            btnHelp.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            btnHelp.UseVisualStyleBackColor = true;
            btnHelp.Click += btnHelp_Click;
            // 
            // FormSerialMonitor
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(539, 361);
            ControlBox = false;
            Controls.Add(btnHelp);
            Controls.Add(btnClear);
            Controls.Add(btnFileSave);
            Controls.Add(btnLog);
            Controls.Add(btnRescan);
            Controls.Add(textBoxRcv);
            Controls.Add(cboxPort);
            Controls.Add(cboxBaud);
            Controls.Add(lblCurrentPort);
            Controls.Add(lblCurrentBaud);
            Controls.Add(btnCloseSerial);
            Controls.Add(btnOpenSerial);
            Controls.Add(btnSerialCancel);
            Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormSerialMonitor";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Serial Monitor - Baud: Teensy - 115200   Arduino - 38400";
            FormClosing += FormSerialMonitor_FormClosing;
            Load += FormUDp_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSerialCancel;
        private System.Windows.Forms.ComboBox cboxPort;
        private System.Windows.Forms.ComboBox cboxBaud;
        private System.Windows.Forms.Label lblCurrentPort;
        private System.Windows.Forms.Label lblCurrentBaud;
        private System.Windows.Forms.Button btnCloseSerial;
        private System.Windows.Forms.Button btnOpenSerial;
        private System.Windows.Forms.TextBox textBoxRcv;
        private System.Windows.Forms.Button btnRescan;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnFileSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnHelp;
    }
}
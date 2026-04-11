namespace AgIO
{
    partial class FormUDPMonitor
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
            textBoxRcv = new System.Windows.Forms.TextBox();
            btnLog = new System.Windows.Forms.Button();
            timer1 = new System.Windows.Forms.Timer(components);
            btnFileSave = new System.Windows.Forms.Button();
            btnClear = new System.Windows.Forms.Button();
            btnLogNMEA = new System.Windows.Forms.Button();
            lblSteerAngle = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            btnLogNTRIP = new System.Windows.Forms.Button();
            lblPGNGuide = new System.Windows.Forms.Label();
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
            btnSerialCancel.Location = new System.Drawing.Point(386, 232);
            btnSerialCancel.Name = "btnSerialCancel";
            btnSerialCancel.Size = new System.Drawing.Size(65, 54);
            btnSerialCancel.TabIndex = 71;
            btnSerialCancel.UseVisualStyleBackColor = true;
            btnSerialCancel.Click += btnSerialCancel_Click;
            // 
            // textBoxRcv
            // 
            textBoxRcv.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            textBoxRcv.BackColor = System.Drawing.SystemColors.Window;
            textBoxRcv.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            textBoxRcv.Location = new System.Drawing.Point(6, 31);
            textBoxRcv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            textBoxRcv.Multiline = true;
            textBoxRcv.Name = "textBoxRcv";
            textBoxRcv.ReadOnly = true;
            textBoxRcv.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            textBoxRcv.Size = new System.Drawing.Size(437, 194);
            textBoxRcv.TabIndex = 539;
            textBoxRcv.WordWrap = false;
            // 
            // btnLog
            // 
            btnLog.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnLog.BackColor = System.Drawing.Color.LightGreen;
            btnLog.FlatAppearance.BorderSize = 0;
            btnLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLog.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnLog.Image = Properties.Resources.LogNMEA;
            btnLog.Location = new System.Drawing.Point(290, 232);
            btnLog.Name = "btnLog";
            btnLog.Size = new System.Drawing.Size(78, 54);
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
            btnFileSave.Location = new System.Drawing.Point(77, 233);
            btnFileSave.Name = "btnFileSave";
            btnFileSave.Size = new System.Drawing.Size(53, 53);
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
            btnClear.Location = new System.Drawing.Point(6, 233);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(53, 53);
            btnClear.TabIndex = 543;
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnLogNMEA
            // 
            btnLogNMEA.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnLogNMEA.BackColor = System.Drawing.Color.Transparent;
            btnLogNMEA.FlatAppearance.BorderSize = 0;
            btnLogNMEA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLogNMEA.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnLogNMEA.Image = Properties.Resources.Nmea;
            btnLogNMEA.Location = new System.Drawing.Point(219, 233);
            btnLogNMEA.Name = "btnLogNMEA";
            btnLogNMEA.Size = new System.Drawing.Size(53, 53);
            btnLogNMEA.TabIndex = 544;
            btnLogNMEA.UseVisualStyleBackColor = false;
            btnLogNMEA.Click += btnLogNMEA_Click;
            // 
            // lblSteerAngle
            // 
            lblSteerAngle.AutoSize = true;
            lblSteerAngle.BackColor = System.Drawing.Color.Transparent;
            lblSteerAngle.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblSteerAngle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lblSteerAngle.Location = new System.Drawing.Point(15, 8);
            lblSteerAngle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblSteerAngle.Name = "lblSteerAngle";
            lblSteerAngle.Size = new System.Drawing.Size(44, 18);
            lblSteerAngle.TabIndex = 545;
            lblSteerAngle.Text = "Time";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label1.Location = new System.Drawing.Point(100, 8);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(134, 18);
            label1.TabIndex = 546;
            label1.Text = "IP Address : Port";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label2.Location = new System.Drawing.Point(310, 8);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(41, 18);
            label2.TabIndex = 547;
            label2.Text = "PGN";
            // 
            // btnLogNTRIP
            // 
            btnLogNTRIP.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnLogNTRIP.BackColor = System.Drawing.Color.Transparent;
            btnLogNTRIP.FlatAppearance.BorderSize = 0;
            btnLogNTRIP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLogNTRIP.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnLogNTRIP.Image = Properties.Resources.NTRIP_Client;
            btnLogNTRIP.Location = new System.Drawing.Point(148, 233);
            btnLogNTRIP.Name = "btnLogNTRIP";
            btnLogNTRIP.Size = new System.Drawing.Size(53, 53);
            btnLogNTRIP.TabIndex = 548;
            btnLogNTRIP.UseVisualStyleBackColor = false;
            btnLogNTRIP.Click += btnLogNTRIP_Click;
            // 
            // lblPGNGuide
            // 
            lblPGNGuide.AutoSize = true;
            lblPGNGuide.BackColor = System.Drawing.Color.Transparent;
            lblPGNGuide.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblPGNGuide.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lblPGNGuide.Location = new System.Drawing.Point(381, 8);
            lblPGNGuide.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPGNGuide.Name = "lblPGNGuide";
            lblPGNGuide.Size = new System.Drawing.Size(73, 18);
            lblPGNGuide.TabIndex = 549;
            lblPGNGuide.Text = "Guide ->";
            lblPGNGuide.Click += lblPGNGuide_Click;
            // 
            // FormUDPMonitor
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(456, 291);
            ControlBox = false;
            Controls.Add(lblPGNGuide);
            Controls.Add(btnLogNTRIP);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblSteerAngle);
            Controls.Add(btnLogNMEA);
            Controls.Add(btnClear);
            Controls.Add(btnFileSave);
            Controls.Add(btnLog);
            Controls.Add(textBoxRcv);
            Controls.Add(btnSerialCancel);
            Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size(465, 307);
            Name = "FormUDPMonitor";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "UDP Monitor";
            FormClosing += FormUDPMonitor_FormClosing;
            Load += FormUDp_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSerialCancel;
        private System.Windows.Forms.TextBox textBoxRcv;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnFileSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnLogNMEA;
        private System.Windows.Forms.Label lblSteerAngle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogNTRIP;
        private System.Windows.Forms.Label lblPGNGuide;
    }
}
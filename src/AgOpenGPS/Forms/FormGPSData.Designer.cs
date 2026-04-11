namespace AgOpenGPS
{
    partial class FormGPSData
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
            timer1 = new System.Windows.Forms.Timer(components);
            label3 = new System.Windows.Forms.Label();
            lblSatsTracked = new System.Windows.Forms.Label();
            lblLatitude = new System.Windows.Forms.Label();
            lblLongitude = new System.Windows.Forms.Label();
            lblAltitude = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            lblHDOP = new System.Windows.Forms.Label();
            lblEastingField = new System.Windows.Forms.Label();
            lblNorthingField = new System.Windows.Forms.Label();
            label27 = new System.Windows.Forms.Label();
            label28 = new System.Windows.Forms.Label();
            lblHz = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            lblTimeSlice = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            lblFrameTime = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            lbludpWatchCounts = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            lblFix2FixHeading = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            lblIMUHeading = new System.Windows.Forms.Label();
            label15 = new System.Windows.Forms.Label();
            lblFuzeHeading = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            lblAngularVelocity = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(5, 107);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(52, 18);
            label3.TabIndex = 9;
            label3.Text = "# Sats";
            // 
            // lblSatsTracked
            // 
            lblSatsTracked.AutoSize = true;
            lblSatsTracked.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblSatsTracked.ForeColor = System.Drawing.Color.White;
            lblSatsTracked.Location = new System.Drawing.Point(57, 108);
            lblSatsTracked.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            lblSatsTracked.Name = "lblSatsTracked";
            lblSatsTracked.Size = new System.Drawing.Size(41, 18);
            lblSatsTracked.TabIndex = 4;
            lblSatsTracked.Text = "Sats";
            lblSatsTracked.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLatitude
            // 
            lblLatitude.AutoSize = true;
            lblLatitude.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblLatitude.ForeColor = System.Drawing.Color.White;
            lblLatitude.Location = new System.Drawing.Point(5, -2);
            lblLatitude.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            lblLatitude.Name = "lblLatitude";
            lblLatitude.Size = new System.Drawing.Size(70, 18);
            lblLatitude.TabIndex = 12;
            lblLatitude.Text = "Latitude";
            // 
            // lblLongitude
            // 
            lblLongitude.AutoSize = true;
            lblLongitude.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblLongitude.ForeColor = System.Drawing.Color.White;
            lblLongitude.Location = new System.Drawing.Point(5, 19);
            lblLongitude.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            lblLongitude.Name = "lblLongitude";
            lblLongitude.Size = new System.Drawing.Size(119, 18);
            lblLongitude.TabIndex = 13;
            lblLongitude.Text = "-128.1234567";
            // 
            // lblAltitude
            // 
            lblAltitude.AutoSize = true;
            lblAltitude.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblAltitude.ForeColor = System.Drawing.Color.White;
            lblAltitude.Location = new System.Drawing.Point(57, 88);
            lblAltitude.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            lblAltitude.Name = "lblAltitude";
            lblAltitude.Size = new System.Drawing.Size(67, 18);
            lblAltitude.TabIndex = 14;
            lblAltitude.Text = "Altitude";
            lblAltitude.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label8.ForeColor = System.Drawing.Color.White;
            label8.Location = new System.Drawing.Point(23, 87);
            label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(34, 18);
            label8.TabIndex = 16;
            label8.Text = "Elev";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label9.ForeColor = System.Drawing.Color.White;
            label9.Location = new System.Drawing.Point(10, 127);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(47, 18);
            label9.TabIndex = 18;
            label9.Text = "HDOP";
            // 
            // lblHDOP
            // 
            lblHDOP.AutoSize = true;
            lblHDOP.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblHDOP.ForeColor = System.Drawing.Color.White;
            lblHDOP.Location = new System.Drawing.Point(57, 128);
            lblHDOP.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            lblHDOP.Name = "lblHDOP";
            lblHDOP.Size = new System.Drawing.Size(52, 18);
            lblHDOP.TabIndex = 17;
            lblHDOP.Text = "HDOP";
            lblHDOP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEastingField
            // 
            lblEastingField.AutoSize = true;
            lblEastingField.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblEastingField.ForeColor = System.Drawing.Color.White;
            lblEastingField.Location = new System.Drawing.Point(34, 62);
            lblEastingField.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            lblEastingField.Name = "lblEastingField";
            lblEastingField.Size = new System.Drawing.Size(63, 18);
            lblEastingField.TabIndex = 477;
            lblEastingField.Text = "Easting";
            // 
            // lblNorthingField
            // 
            lblNorthingField.AutoSize = true;
            lblNorthingField.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblNorthingField.ForeColor = System.Drawing.Color.White;
            lblNorthingField.Location = new System.Drawing.Point(34, 42);
            lblNorthingField.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            lblNorthingField.Name = "lblNorthingField";
            lblNorthingField.Size = new System.Drawing.Size(74, 18);
            lblNorthingField.TabIndex = 476;
            lblNorthingField.Text = "Northing";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label27.ForeColor = System.Drawing.Color.White;
            label27.Location = new System.Drawing.Point(17, 62);
            label27.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label27.Name = "label27";
            label27.Size = new System.Drawing.Size(16, 18);
            label27.TabIndex = 475;
            label27.Text = "E";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label28.ForeColor = System.Drawing.Color.White;
            label28.Location = new System.Drawing.Point(15, 42);
            label28.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label28.Name = "label28";
            label28.Size = new System.Drawing.Size(18, 18);
            label28.TabIndex = 474;
            label28.Text = "N";
            // 
            // lblHz
            // 
            lblHz.AutoSize = true;
            lblHz.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblHz.ForeColor = System.Drawing.Color.White;
            lblHz.Location = new System.Drawing.Point(57, 187);
            lblHz.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            lblHz.Name = "lblHz";
            lblHz.Size = new System.Drawing.Size(46, 18);
            lblHz.TabIndex = 506;
            lblHz.Text = "msec";
            lblHz.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label4.ForeColor = System.Drawing.Color.White;
            label4.Location = new System.Drawing.Point(34, 187);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(25, 18);
            label4.TabIndex = 509;
            label4.Text = "Hz";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label10.ForeColor = System.Drawing.Color.White;
            label10.Location = new System.Drawing.Point(2, 169);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(57, 18);
            label10.TabIndex = 511;
            label10.Text = "Raw Hz";
            // 
            // lblTimeSlice
            // 
            lblTimeSlice.AutoSize = true;
            lblTimeSlice.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblTimeSlice.ForeColor = System.Drawing.Color.White;
            lblTimeSlice.Location = new System.Drawing.Point(57, 169);
            lblTimeSlice.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            lblTimeSlice.Name = "lblTimeSlice";
            lblTimeSlice.Size = new System.Drawing.Size(46, 18);
            lblTimeSlice.TabIndex = 510;
            lblTimeSlice.Text = "msec";
            lblTimeSlice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label11.ForeColor = System.Drawing.Color.White;
            label11.Location = new System.Drawing.Point(9, 151);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(50, 18);
            label11.TabIndex = 513;
            label11.Text = "Frame";
            // 
            // lblFrameTime
            // 
            lblFrameTime.AutoSize = true;
            lblFrameTime.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblFrameTime.ForeColor = System.Drawing.Color.White;
            lblFrameTime.Location = new System.Drawing.Point(57, 151);
            lblFrameTime.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            lblFrameTime.Name = "lblFrameTime";
            lblFrameTime.Size = new System.Drawing.Size(46, 18);
            lblFrameTime.TabIndex = 512;
            lblFrameTime.Text = "msec";
            lblFrameTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(6, 211);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(52, 18);
            label2.TabIndex = 515;
            label2.Text = "Missed";
            // 
            // lbludpWatchCounts
            // 
            lbludpWatchCounts.AutoSize = true;
            lbludpWatchCounts.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lbludpWatchCounts.ForeColor = System.Drawing.Color.White;
            lbludpWatchCounts.Location = new System.Drawing.Point(57, 211);
            lbludpWatchCounts.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            lbludpWatchCounts.Name = "lbludpWatchCounts";
            lbludpWatchCounts.Size = new System.Drawing.Size(46, 18);
            lbludpWatchCounts.TabIndex = 514;
            lbludpWatchCounts.Text = "msec";
            lbludpWatchCounts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label5.ForeColor = System.Drawing.Color.White;
            label5.Location = new System.Drawing.Point(6, 239);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(52, 18);
            label5.TabIndex = 519;
            label5.Text = "Fix2Fix";
            // 
            // lblFix2FixHeading
            // 
            lblFix2FixHeading.AutoSize = true;
            lblFix2FixHeading.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblFix2FixHeading.ForeColor = System.Drawing.Color.White;
            lblFix2FixHeading.Location = new System.Drawing.Point(57, 239);
            lblFix2FixHeading.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            lblFix2FixHeading.Name = "lblFix2FixHeading";
            lblFix2FixHeading.Size = new System.Drawing.Size(53, 18);
            lblFix2FixHeading.TabIndex = 518;
            lblFix2FixHeading.Text = "359.1";
            lblFix2FixHeading.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label13.ForeColor = System.Drawing.Color.White;
            label13.Location = new System.Drawing.Point(22, 260);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(36, 18);
            label13.TabIndex = 517;
            label13.Text = "IMU";
            // 
            // lblIMUHeading
            // 
            lblIMUHeading.AutoSize = true;
            lblIMUHeading.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblIMUHeading.ForeColor = System.Drawing.Color.White;
            lblIMUHeading.Location = new System.Drawing.Point(57, 260);
            lblIMUHeading.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            lblIMUHeading.Name = "lblIMUHeading";
            lblIMUHeading.Size = new System.Drawing.Size(53, 18);
            lblIMUHeading.TabIndex = 516;
            lblIMUHeading.Text = "321.6";
            lblIMUHeading.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label15.ForeColor = System.Drawing.Color.White;
            label15.Location = new System.Drawing.Point(-2, 281);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(60, 18);
            label15.TabIndex = 521;
            label15.Text = "Heading";
            // 
            // lblFuzeHeading
            // 
            lblFuzeHeading.AutoSize = true;
            lblFuzeHeading.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblFuzeHeading.ForeColor = System.Drawing.Color.White;
            lblFuzeHeading.Location = new System.Drawing.Point(57, 281);
            lblFuzeHeading.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            lblFuzeHeading.Name = "lblFuzeHeading";
            lblFuzeHeading.Size = new System.Drawing.Size(53, 18);
            lblFuzeHeading.TabIndex = 520;
            lblFuzeHeading.Text = "344.0";
            lblFuzeHeading.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label12.ForeColor = System.Drawing.Color.White;
            label12.Location = new System.Drawing.Point(32, 307);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(26, 18);
            label12.TabIndex = 523;
            label12.Text = "AV";
            // 
            // lblAngularVelocity
            // 
            lblAngularVelocity.AutoSize = true;
            lblAngularVelocity.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblAngularVelocity.ForeColor = System.Drawing.Color.White;
            lblAngularVelocity.Location = new System.Drawing.Point(57, 307);
            lblAngularVelocity.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            lblAngularVelocity.Name = "lblAngularVelocity";
            lblAngularVelocity.Size = new System.Drawing.Size(43, 18);
            lblAngularVelocity.TabIndex = 522;
            lblAngularVelocity.Text = "3.56";
            lblAngularVelocity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormGPSData
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            BackColor = System.Drawing.Color.Black;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            ClientSize = new System.Drawing.Size(120, 330);
            Controls.Add(label12);
            Controls.Add(lblAngularVelocity);
            Controls.Add(label15);
            Controls.Add(lblFuzeHeading);
            Controls.Add(label5);
            Controls.Add(lblFix2FixHeading);
            Controls.Add(label13);
            Controls.Add(lblIMUHeading);
            Controls.Add(label2);
            Controls.Add(lbludpWatchCounts);
            Controls.Add(label11);
            Controls.Add(lblFrameTime);
            Controls.Add(label10);
            Controls.Add(lblTimeSlice);
            Controls.Add(label4);
            Controls.Add(lblHz);
            Controls.Add(lblLatitude);
            Controls.Add(lblLongitude);
            Controls.Add(lblEastingField);
            Controls.Add(lblNorthingField);
            Controls.Add(label27);
            Controls.Add(label28);
            Controls.Add(label9);
            Controls.Add(lblHDOP);
            Controls.Add(label8);
            Controls.Add(lblAltitude);
            Controls.Add(lblSatsTracked);
            Controls.Add(label3);
            Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormGPSData";
            ShowInTaskbar = false;
            Text = "System Data";
            FormClosing += FormGPSData_FormClosing;
            Load += FormGPSData_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSatsTracked;
        private System.Windows.Forms.Label lblLatitude;
        private System.Windows.Forms.Label lblLongitude;
        private System.Windows.Forms.Label lblAltitude;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblHDOP;
        private System.Windows.Forms.Label lblEastingField;
        private System.Windows.Forms.Label lblNorthingField;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label lblHz;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTimeSlice;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblFrameTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbludpWatchCounts;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblFix2FixHeading;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblIMUHeading;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblFuzeHeading;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblAngularVelocity;
    }
}
namespace AgIO
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
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            lblFixQuality = new System.Windows.Forms.Label();
            lblSatsTracked = new System.Windows.Forms.Label();
            lblAltitude = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            lblHDOP = new System.Windows.Forms.Label();
            label17 = new System.Windows.Forms.Label();
            lblSpeed = new System.Windows.Forms.Label();
            lblRoll = new System.Windows.Forms.Label();
            label15 = new System.Windows.Forms.Label();
            lblGPSHeading = new System.Windows.Forms.Label();
            label16 = new System.Windows.Forms.Label();
            label29 = new System.Windows.Forms.Label();
            label19 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label26 = new System.Windows.Forms.Label();
            label30 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            lblLongitude = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            lblLatitude = new System.Windows.Forms.Label();
            tboxVTG = new System.Windows.Forms.TextBox();
            tboxGGA = new System.Windows.Forms.TextBox();
            tboxHDT = new System.Windows.Forms.TextBox();
            tboxAVR = new System.Windows.Forms.TextBox();
            tboxPAOGI = new System.Windows.Forms.TextBox();
            tboxHPD = new System.Windows.Forms.TextBox();
            lblDualHeading = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            lblAge = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            tboxPANDA = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            lblIMUYawRate = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            lblIMUPitch = new System.Windows.Forms.Label();
            label20 = new System.Windows.Forms.Label();
            lblIMUHeading = new System.Windows.Forms.Label();
            label22 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            lblIMURoll = new System.Windows.Forms.Label();
            tboxKSXT = new System.Windows.Forms.TextBox();
            label13 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 250;
            timer1.Tick += timer1_Tick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label2.ForeColor = System.Drawing.Color.Black;
            label2.Location = new System.Drawing.Point(2, 79);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(52, 18);
            label2.TabIndex = 8;
            label2.Text = "Quality";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label3.ForeColor = System.Drawing.Color.Black;
            label3.Location = new System.Drawing.Point(180, 30);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(52, 18);
            label3.TabIndex = 9;
            label3.Text = "# Sats";
            // 
            // lblFixQuality
            // 
            lblFixQuality.AutoSize = true;
            lblFixQuality.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblFixQuality.Location = new System.Drawing.Point(52, 79);
            lblFixQuality.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            lblFixQuality.Name = "lblFixQuality";
            lblFixQuality.Size = new System.Drawing.Size(66, 18);
            lblFixQuality.TabIndex = 2;
            lblFixQuality.Text = "FixQual";
            lblFixQuality.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSatsTracked
            // 
            lblSatsTracked.AutoSize = true;
            lblSatsTracked.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblSatsTracked.Location = new System.Drawing.Point(231, 31);
            lblSatsTracked.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            lblSatsTracked.Name = "lblSatsTracked";
            lblSatsTracked.Size = new System.Drawing.Size(41, 18);
            lblSatsTracked.TabIndex = 4;
            lblSatsTracked.Text = "Sats";
            lblSatsTracked.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAltitude
            // 
            lblAltitude.AutoSize = true;
            lblAltitude.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblAltitude.Location = new System.Drawing.Point(231, 55);
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
            label8.ForeColor = System.Drawing.Color.Black;
            label8.Location = new System.Drawing.Point(198, 54);
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
            label9.ForeColor = System.Drawing.Color.Black;
            label9.Location = new System.Drawing.Point(185, 6);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(47, 18);
            label9.TabIndex = 18;
            label9.Text = "HDOP";
            // 
            // lblHDOP
            // 
            lblHDOP.AutoSize = true;
            lblHDOP.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblHDOP.Location = new System.Drawing.Point(231, 7);
            lblHDOP.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            lblHDOP.Name = "lblHDOP";
            lblHDOP.Size = new System.Drawing.Size(52, 18);
            lblHDOP.TabIndex = 17;
            lblHDOP.Text = "HDOP";
            lblHDOP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label17.ForeColor = System.Drawing.Color.Black;
            label17.Location = new System.Drawing.Point(6, 55);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(48, 18);
            label17.TabIndex = 116;
            label17.Text = "Speed";
            // 
            // lblSpeed
            // 
            lblSpeed.AutoSize = true;
            lblSpeed.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblSpeed.Location = new System.Drawing.Point(52, 55);
            lblSpeed.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            lblSpeed.Name = "lblSpeed";
            lblSpeed.Size = new System.Drawing.Size(54, 18);
            lblSpeed.TabIndex = 115;
            lblSpeed.Text = "Speed";
            lblSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRoll
            // 
            lblRoll.AutoSize = true;
            lblRoll.BackColor = System.Drawing.Color.Transparent;
            lblRoll.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblRoll.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            lblRoll.Location = new System.Drawing.Point(356, 55);
            lblRoll.Name = "lblRoll";
            lblRoll.Size = new System.Drawing.Size(49, 18);
            lblRoll.TabIndex = 463;
            lblRoll.Text = "-11.2";
            lblRoll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = System.Drawing.Color.Transparent;
            label15.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label15.ForeColor = System.Drawing.Color.Black;
            label15.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label15.Location = new System.Drawing.Point(455, 31);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(29, 18);
            label15.TabIndex = 460;
            label15.Text = "Roll";
            // 
            // lblGPSHeading
            // 
            lblGPSHeading.AutoSize = true;
            lblGPSHeading.BackColor = System.Drawing.Color.Transparent;
            lblGPSHeading.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblGPSHeading.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            lblGPSHeading.Location = new System.Drawing.Point(356, 6);
            lblGPSHeading.Name = "lblGPSHeading";
            lblGPSHeading.Size = new System.Drawing.Size(54, 19);
            lblGPSHeading.TabIndex = 462;
            lblGPSHeading.Text = "359.3";
            lblGPSHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = System.Drawing.Color.Transparent;
            label16.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label16.ForeColor = System.Drawing.Color.Black;
            label16.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label16.Location = new System.Drawing.Point(317, 6);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(40, 19);
            label16.TabIndex = 458;
            label16.Text = "VTG";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.BackColor = System.Drawing.Color.Transparent;
            label29.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label29.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label29.Location = new System.Drawing.Point(4, 267);
            label29.Name = "label29";
            label29.Size = new System.Drawing.Size(30, 13);
            label29.TabIndex = 496;
            label29.Text = "AVR";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = System.Drawing.Color.Transparent;
            label19.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label19.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label19.Location = new System.Drawing.Point(3, 112);
            label19.Name = "label19";
            label19.Size = new System.Drawing.Size(31, 13);
            label19.TabIndex = 501;
            label19.Text = "GGA";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = System.Drawing.Color.Transparent;
            label11.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label11.Location = new System.Drawing.Point(5, 205);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(28, 13);
            label11.TabIndex = 502;
            label11.Text = "OGI";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.BackColor = System.Drawing.Color.Transparent;
            label26.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label26.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label26.Location = new System.Drawing.Point(5, 143);
            label26.Name = "label26";
            label26.Size = new System.Drawing.Size(29, 13);
            label26.TabIndex = 503;
            label26.Text = "VTG";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.BackColor = System.Drawing.Color.Transparent;
            label30.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label30.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label30.Location = new System.Drawing.Point(4, 236);
            label30.Name = "label30";
            label30.Size = new System.Drawing.Size(30, 13);
            label30.TabIndex = 505;
            label30.Text = "HDT";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.Transparent;
            label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label4.Location = new System.Drawing.Point(4, 297);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(30, 13);
            label4.TabIndex = 509;
            label4.Text = "HPD";
            // 
            // lblLongitude
            // 
            lblLongitude.AutoSize = true;
            lblLongitude.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblLongitude.Location = new System.Drawing.Point(36, 5);
            lblLongitude.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            lblLongitude.Name = "lblLongitude";
            lblLongitude.Size = new System.Drawing.Size(82, 18);
            lblLongitude.TabIndex = 13;
            lblLongitude.Text = "Longitude";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label7.ForeColor = System.Drawing.Color.Black;
            label7.Location = new System.Drawing.Point(6, 5);
            label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(31, 18);
            label7.TabIndex = 15;
            label7.Text = "Lon";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label6.ForeColor = System.Drawing.Color.Black;
            label6.Location = new System.Drawing.Point(9, 29);
            label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(28, 18);
            label6.TabIndex = 5;
            label6.Text = "Lat";
            // 
            // lblLatitude
            // 
            lblLatitude.AutoSize = true;
            lblLatitude.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblLatitude.Location = new System.Drawing.Point(36, 29);
            lblLatitude.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            lblLatitude.Name = "lblLatitude";
            lblLatitude.Size = new System.Drawing.Size(70, 18);
            lblLatitude.TabIndex = 12;
            lblLatitude.Text = "Latitude";
            // 
            // tboxVTG
            // 
            tboxVTG.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tboxVTG.BackColor = System.Drawing.SystemColors.Window;
            tboxVTG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            tboxVTG.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tboxVTG.Location = new System.Drawing.Point(35, 139);
            tboxVTG.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            tboxVTG.Name = "tboxVTG";
            tboxVTG.ReadOnly = true;
            tboxVTG.Size = new System.Drawing.Size(404, 23);
            tboxVTG.TabIndex = 497;
            tboxVTG.Text = "$GPVTG,0,T,034.4,M,1,N,1.852,K";
            // 
            // tboxGGA
            // 
            tboxGGA.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tboxGGA.BackColor = System.Drawing.SystemColors.Window;
            tboxGGA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            tboxGGA.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tboxGGA.Location = new System.Drawing.Point(35, 108);
            tboxGGA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            tboxGGA.Name = "tboxGGA";
            tboxGGA.ReadOnly = true;
            tboxGGA.Size = new System.Drawing.Size(499, 23);
            tboxGGA.TabIndex = 498;
            tboxGGA.Text = "$GPGGA,055129.00,5326.1729618,N,111,09.6028200,W,4,12,0.9,300,M,46.9,M,,,";
            // 
            // tboxHDT
            // 
            tboxHDT.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tboxHDT.BackColor = System.Drawing.SystemColors.Window;
            tboxHDT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            tboxHDT.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tboxHDT.Location = new System.Drawing.Point(35, 232);
            tboxHDT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            tboxHDT.Name = "tboxHDT";
            tboxHDT.ReadOnly = true;
            tboxHDT.Size = new System.Drawing.Size(404, 23);
            tboxHDT.TabIndex = 499;
            tboxHDT.Text = "$GNHDT,123.456,T * 00";
            // 
            // tboxAVR
            // 
            tboxAVR.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tboxAVR.BackColor = System.Drawing.SystemColors.Window;
            tboxAVR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            tboxAVR.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tboxAVR.Location = new System.Drawing.Point(35, 263);
            tboxAVR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            tboxAVR.Name = "tboxAVR";
            tboxAVR.ReadOnly = true;
            tboxAVR.Size = new System.Drawing.Size(499, 23);
            tboxAVR.TabIndex = 500;
            tboxAVR.Text = "$PTNL,AVR,145331.50,+35.9990,Yaw,-7.8209,Tilt,-0.4305,Roll,444.232,3,1.2,17 * 03";
            // 
            // tboxPAOGI
            // 
            tboxPAOGI.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tboxPAOGI.BackColor = System.Drawing.SystemColors.Window;
            tboxPAOGI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            tboxPAOGI.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tboxPAOGI.Location = new System.Drawing.Point(35, 201);
            tboxPAOGI.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            tboxPAOGI.Name = "tboxPAOGI";
            tboxPAOGI.ReadOnly = true;
            tboxPAOGI.Size = new System.Drawing.Size(499, 23);
            tboxPAOGI.TabIndex = 504;
            tboxPAOGI.Text = "$PAOGI,055129.00,5326.1729618,N,111,09.6028200,W,4,12,0.9,300,M,46.9,M,,,";
            // 
            // tboxHPD
            // 
            tboxHPD.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tboxHPD.BackColor = System.Drawing.SystemColors.Window;
            tboxHPD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            tboxHPD.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tboxHPD.Location = new System.Drawing.Point(35, 294);
            tboxHPD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            tboxHPD.Name = "tboxHPD";
            tboxHPD.ReadOnly = true;
            tboxHPD.Size = new System.Drawing.Size(499, 23);
            tboxHPD.TabIndex = 510;
            tboxHPD.Text = "$PTNL,AVR,145331.50,+35.9990,Yaw,-7.8209,Tilt,-0.4305,Roll,444.232,3,1.2,17 * 03";
            // 
            // lblDualHeading
            // 
            lblDualHeading.AutoSize = true;
            lblDualHeading.BackColor = System.Drawing.Color.Transparent;
            lblDualHeading.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblDualHeading.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            lblDualHeading.Location = new System.Drawing.Point(356, 29);
            lblDualHeading.Name = "lblDualHeading";
            lblDualHeading.Size = new System.Drawing.Size(54, 19);
            lblDualHeading.TabIndex = 514;
            lblDualHeading.Text = "359.3";
            lblDualHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = System.Drawing.Color.Transparent;
            label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label10.ForeColor = System.Drawing.Color.Black;
            label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label10.Location = new System.Drawing.Point(316, 29);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(41, 19);
            label10.TabIndex = 513;
            label10.Text = "Dual";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblAge.Location = new System.Drawing.Point(231, 79);
            lblAge.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            lblAge.Name = "lblAge";
            lblAge.Size = new System.Drawing.Size(67, 18);
            lblAge.TabIndex = 515;
            lblAge.Text = "Altitude";
            lblAge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label12.ForeColor = System.Drawing.Color.Black;
            label12.Location = new System.Drawing.Point(199, 78);
            label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(33, 18);
            label12.TabIndex = 516;
            label12.Text = "Age";
            // 
            // tboxPANDA
            // 
            tboxPANDA.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tboxPANDA.BackColor = System.Drawing.SystemColors.Window;
            tboxPANDA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            tboxPANDA.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tboxPANDA.Location = new System.Drawing.Point(36, 170);
            tboxPANDA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            tboxPANDA.Name = "tboxPANDA";
            tboxPANDA.ReadOnly = true;
            tboxPANDA.Size = new System.Drawing.Size(499, 23);
            tboxPANDA.TabIndex = 518;
            tboxPANDA.Text = "$PANDA,145331.50,+35.9990,Yaw,-7.8209,Tilt,-0.4305,Roll,444.232,3,1.2,17 * 03";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.Transparent;
            label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label5.Location = new System.Drawing.Point(5, 173);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(30, 13);
            label5.TabIndex = 517;
            label5.Text = "NDA";
            // 
            // lblIMUYawRate
            // 
            lblIMUYawRate.AutoSize = true;
            lblIMUYawRate.BackColor = System.Drawing.Color.Transparent;
            lblIMUYawRate.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblIMUYawRate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            lblIMUYawRate.Location = new System.Drawing.Point(482, 77);
            lblIMUYawRate.Name = "lblIMUYawRate";
            lblIMUYawRate.Size = new System.Drawing.Size(49, 18);
            lblIMUYawRate.TabIndex = 520;
            lblIMUYawRate.Text = "-11.2";
            lblIMUYawRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = System.Drawing.Color.Transparent;
            label14.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label14.ForeColor = System.Drawing.Color.Black;
            label14.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label14.Location = new System.Drawing.Point(420, 77);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(66, 18);
            label14.TabIndex = 519;
            label14.Text = "YawRate";
            // 
            // lblIMUPitch
            // 
            lblIMUPitch.AutoSize = true;
            lblIMUPitch.BackColor = System.Drawing.Color.Transparent;
            lblIMUPitch.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblIMUPitch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            lblIMUPitch.Location = new System.Drawing.Point(482, 54);
            lblIMUPitch.Name = "lblIMUPitch";
            lblIMUPitch.Size = new System.Drawing.Size(49, 18);
            lblIMUPitch.TabIndex = 522;
            lblIMUPitch.Text = "-11.2";
            lblIMUPitch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.BackColor = System.Drawing.Color.Transparent;
            label20.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label20.ForeColor = System.Drawing.Color.Black;
            label20.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label20.Location = new System.Drawing.Point(450, 54);
            label20.Name = "label20";
            label20.Size = new System.Drawing.Size(38, 18);
            label20.TabIndex = 521;
            label20.Text = "Pitch";
            // 
            // lblIMUHeading
            // 
            lblIMUHeading.AutoSize = true;
            lblIMUHeading.BackColor = System.Drawing.Color.Transparent;
            lblIMUHeading.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblIMUHeading.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            lblIMUHeading.Location = new System.Drawing.Point(482, 8);
            lblIMUHeading.Name = "lblIMUHeading";
            lblIMUHeading.Size = new System.Drawing.Size(49, 18);
            lblIMUHeading.TabIndex = 524;
            lblIMUHeading.Text = "-11.2";
            lblIMUHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.BackColor = System.Drawing.Color.Transparent;
            label22.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label22.ForeColor = System.Drawing.Color.Black;
            label22.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label22.Location = new System.Drawing.Point(450, 8);
            label22.Name = "label22";
            label22.Size = new System.Drawing.Size(36, 18);
            label22.TabIndex = 523;
            label22.Text = "Yaw";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.Black;
            label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label1.Location = new System.Drawing.Point(328, 55);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(29, 18);
            label1.TabIndex = 525;
            label1.Text = "Roll";
            // 
            // lblIMURoll
            // 
            lblIMURoll.AutoSize = true;
            lblIMURoll.BackColor = System.Drawing.Color.Transparent;
            lblIMURoll.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblIMURoll.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            lblIMURoll.Location = new System.Drawing.Point(482, 31);
            lblIMURoll.Name = "lblIMURoll";
            lblIMURoll.Size = new System.Drawing.Size(49, 18);
            lblIMURoll.TabIndex = 526;
            lblIMURoll.Text = "-11.2";
            lblIMURoll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tboxKSXT
            // 
            tboxKSXT.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tboxKSXT.BackColor = System.Drawing.SystemColors.Window;
            tboxKSXT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            tboxKSXT.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tboxKSXT.Location = new System.Drawing.Point(35, 327);
            tboxKSXT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            tboxKSXT.Name = "tboxKSXT";
            tboxKSXT.ReadOnly = true;
            tboxKSXT.Size = new System.Drawing.Size(499, 23);
            tboxKSXT.TabIndex = 528;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = System.Drawing.Color.Transparent;
            label13.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label13.Location = new System.Drawing.Point(4, 330);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(28, 13);
            label13.TabIndex = 527;
            label13.Text = "SXT";
            // 
            // FormGPSData
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            BackColor = System.Drawing.Color.Gainsboro;
            ClientSize = new System.Drawing.Size(547, 357);
            Controls.Add(tboxKSXT);
            Controls.Add(label13);
            Controls.Add(lblIMURoll);
            Controls.Add(label1);
            Controls.Add(lblIMUHeading);
            Controls.Add(label22);
            Controls.Add(lblIMUPitch);
            Controls.Add(label20);
            Controls.Add(lblIMUYawRate);
            Controls.Add(label14);
            Controls.Add(tboxPANDA);
            Controls.Add(label5);
            Controls.Add(lblAge);
            Controls.Add(label12);
            Controls.Add(lblDualHeading);
            Controls.Add(label10);
            Controls.Add(tboxHPD);
            Controls.Add(label4);
            Controls.Add(lblLatitude);
            Controls.Add(label6);
            Controls.Add(tboxPAOGI);
            Controls.Add(label7);
            Controls.Add(tboxAVR);
            Controls.Add(lblLongitude);
            Controls.Add(tboxHDT);
            Controls.Add(tboxGGA);
            Controls.Add(tboxVTG);
            Controls.Add(label30);
            Controls.Add(label26);
            Controls.Add(label11);
            Controls.Add(label19);
            Controls.Add(label29);
            Controls.Add(lblRoll);
            Controls.Add(label15);
            Controls.Add(lblGPSHeading);
            Controls.Add(label17);
            Controls.Add(lblSpeed);
            Controls.Add(label9);
            Controls.Add(lblHDOP);
            Controls.Add(lblAltitude);
            Controls.Add(label2);
            Controls.Add(lblSatsTracked);
            Controls.Add(lblFixQuality);
            Controls.Add(label3);
            Controls.Add(label16);
            Controls.Add(label8);
            Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormGPSData";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "System Data";
            FormClosing += FormGPSData_FormClosing;
            Load += FormGPSData_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFixQuality;
        private System.Windows.Forms.Label lblSatsTracked;
        private System.Windows.Forms.Label lblAltitude;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblHDOP;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label lblRoll;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblGPSHeading;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblLongitude;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblLatitude;
        private System.Windows.Forms.TextBox tboxVTG;
        private System.Windows.Forms.TextBox tboxGGA;
        private System.Windows.Forms.TextBox tboxHDT;
        private System.Windows.Forms.TextBox tboxAVR;
        private System.Windows.Forms.TextBox tboxPAOGI;
        private System.Windows.Forms.TextBox tboxHPD;
        private System.Windows.Forms.Label lblDualHeading;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tboxPANDA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblIMUYawRate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblIMUPitch;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblIMUHeading;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIMURoll;
        private System.Windows.Forms.TextBox tboxKSXT;
        private System.Windows.Forms.Label label13;
    }
}
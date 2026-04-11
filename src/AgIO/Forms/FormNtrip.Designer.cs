namespace AgIO
{
    partial class FormNtrip
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
            tboxCasterIP = new System.Windows.Forms.TextBox();
            nudCasterPort = new System.Windows.Forms.NumericUpDown();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            tboxHostName = new System.Windows.Forms.TextBox();
            label14 = new System.Windows.Forms.Label();
            nudSendToUDPPort = new System.Windows.Forms.NumericUpDown();
            label10 = new System.Windows.Forms.Label();
            tboxUserName = new System.Windows.Forms.TextBox();
            tboxUserPassword = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            tboxMount = new System.Windows.Forms.TextBox();
            nudGGAInterval = new System.Windows.Forms.NumericUpDown();
            label15 = new System.Windows.Forms.Label();
            tboxEnterURL = new System.Windows.Forms.TextBox();
            btnGetIP = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            nudLatitude = new System.Windows.Forms.NumericUpDown();
            nudLongitude = new System.Windows.Forms.NumericUpDown();
            tboxCurrentLat = new System.Windows.Forms.TextBox();
            tboxCurrentLon = new System.Windows.Forms.TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            label9 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label16 = new System.Windows.Forms.Label();
            label17 = new System.Windows.Forms.Label();
            btnGetSourceTable = new System.Windows.Forms.Button();
            btnSetManualPosition = new System.Windows.Forms.Button();
            cboxGGAManual = new System.Windows.Forms.ComboBox();
            label19 = new System.Windows.Forms.Label();
            checkBoxusetcp = new System.Windows.Forms.CheckBox();
            btnPassUsername = new System.Windows.Forms.Button();
            btnPassPassword = new System.Windows.Forms.Button();
            cboxHTTP = new System.Windows.Forms.ComboBox();
            label20 = new System.Windows.Forms.Label();
            tabControl1 = new System.Windows.Forms.TabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            listboxIP = new System.Windows.Forms.ListBox();
            tabPage2 = new System.Windows.Forms.TabPage();
            label1 = new System.Windows.Forms.Label();
            cboxToSerial = new System.Windows.Forms.CheckBox();
            cboxToUDP = new System.Windows.Forms.CheckBox();
            tabPage3 = new System.Windows.Forms.TabPage();
            comboboxPacketSize = new System.Windows.Forms.ComboBox();
            labelRtcmPort = new System.Windows.Forms.Label();
            cboxIsNTRIPOn = new System.Windows.Forms.CheckBox();
            btnSerialOK = new System.Windows.Forms.Button();
            btnSerialCancel = new System.Windows.Forms.Button();
            btnHelp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)nudCasterPort).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSendToUDPPort).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudGGAInterval).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudLatitude).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudLongitude).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // tboxCasterIP
            // 
            tboxCasterIP.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tboxCasterIP.Location = new System.Drawing.Point(91, 379);
            tboxCasterIP.Name = "tboxCasterIP";
            tboxCasterIP.ReadOnly = true;
            tboxCasterIP.Size = new System.Drawing.Size(170, 33);
            tboxCasterIP.TabIndex = 79;
            tboxCasterIP.Text = "192.168.188.255";
            tboxCasterIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            tboxCasterIP.Validating += tboxCasterIP_Validating;
            // 
            // nudCasterPort
            // 
            nudCasterPort.BackColor = System.Drawing.Color.AliceBlue;
            nudCasterPort.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            nudCasterPort.Location = new System.Drawing.Point(494, 411);
            nudCasterPort.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            nudCasterPort.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCasterPort.Name = "nudCasterPort";
            nudCasterPort.Size = new System.Drawing.Size(119, 40);
            nudCasterPort.TabIndex = 80;
            nudCasterPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudCasterPort.Value = new decimal(new int[] { 8888, 0, 0, 0 });
            nudCasterPort.Enter += NudCasterPort_Enter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label5.Location = new System.Drawing.Point(49, 382);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(39, 25);
            label5.TabIndex = 82;
            label5.Text = "IP:";
            // 
            // label4
            // 
            label4.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label4.Location = new System.Drawing.Point(28, 263);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(297, 56);
            label4.TabIndex = 83;
            label4.Text = "Enter Broadcaster URL or IP:";
            label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // tboxHostName
            // 
            tboxHostName.BackColor = System.Drawing.Color.Gainsboro;
            tboxHostName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            tboxHostName.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tboxHostName.Location = new System.Drawing.Point(91, 32);
            tboxHostName.Name = "tboxHostName";
            tboxHostName.ReadOnly = true;
            tboxHostName.Size = new System.Drawing.Size(221, 23);
            tboxHostName.TabIndex = 86;
            tboxHostName.Text = "HostName";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label14.Location = new System.Drawing.Point(38, 32);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(47, 23);
            label14.TabIndex = 85;
            label14.Text = "Host";
            // 
            // nudSendToUDPPort
            // 
            nudSendToUDPPort.BackColor = System.Drawing.Color.White;
            nudSendToUDPPort.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            nudSendToUDPPort.Location = new System.Drawing.Point(569, 200);
            nudSendToUDPPort.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            nudSendToUDPPort.Name = "nudSendToUDPPort";
            nudSendToUDPPort.Size = new System.Drawing.Size(141, 46);
            nudSendToUDPPort.TabIndex = 74;
            nudSendToUDPPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudSendToUDPPort.Value = new decimal(new int[] { 36666, 0, 0, 0 });
            nudSendToUDPPort.Enter += NudSendToUDPPort_Enter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label10.Location = new System.Drawing.Point(53, 99);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(27, 23);
            label10.TabIndex = 76;
            label10.Text = "IP";
            // 
            // tboxUserName
            // 
            tboxUserName.BackColor = System.Drawing.Color.White;
            tboxUserName.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tboxUserName.Location = new System.Drawing.Point(389, 63);
            tboxUserName.Name = "tboxUserName";
            tboxUserName.PasswordChar = '*';
            tboxUserName.Size = new System.Drawing.Size(252, 33);
            tboxUserName.TabIndex = 100;
            tboxUserName.Click += tboxUserName_Click;
            // 
            // tboxUserPassword
            // 
            tboxUserPassword.BackColor = System.Drawing.Color.White;
            tboxUserPassword.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tboxUserPassword.Location = new System.Drawing.Point(389, 134);
            tboxUserPassword.Name = "tboxUserPassword";
            tboxUserPassword.PasswordChar = '*';
            tboxUserPassword.Size = new System.Drawing.Size(252, 33);
            tboxUserPassword.TabIndex = 101;
            tboxUserPassword.Click += tboxUserPassword_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(393, 35);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(106, 25);
            label3.TabIndex = 102;
            label3.Text = "Username";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label12.Location = new System.Drawing.Point(393, 106);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(100, 25);
            label12.TabIndex = 103;
            label12.Text = "Password";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label13.Location = new System.Drawing.Point(394, 291);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(77, 25);
            label13.TabIndex = 105;
            label13.Text = "Mount:";
            // 
            // tboxMount
            // 
            tboxMount.BackColor = System.Drawing.Color.White;
            tboxMount.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tboxMount.Location = new System.Drawing.Point(380, 322);
            tboxMount.Name = "tboxMount";
            tboxMount.Size = new System.Drawing.Size(341, 33);
            tboxMount.TabIndex = 104;
            tboxMount.Click += tboxMount_Click;
            // 
            // nudGGAInterval
            // 
            nudGGAInterval.BackColor = System.Drawing.Color.White;
            nudGGAInterval.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            nudGGAInterval.Location = new System.Drawing.Point(445, 373);
            nudGGAInterval.Maximum = new decimal(new int[] { 600, 0, 0, 0 });
            nudGGAInterval.Name = "nudGGAInterval";
            nudGGAInterval.Size = new System.Drawing.Size(113, 40);
            nudGGAInterval.TabIndex = 106;
            nudGGAInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudGGAInterval.Value = new decimal(new int[] { 20, 0, 0, 0 });
            nudGGAInterval.Enter += NudGGAInterval_Enter;
            // 
            // label15
            // 
            label15.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label15.Location = new System.Drawing.Point(411, 333);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(196, 33);
            label15.TabIndex = 107;
            label15.Text = "GGA Interval (secs)";
            label15.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // tboxEnterURL
            // 
            tboxEnterURL.BackColor = System.Drawing.Color.White;
            tboxEnterURL.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tboxEnterURL.Location = new System.Drawing.Point(21, 322);
            tboxEnterURL.Name = "tboxEnterURL";
            tboxEnterURL.Size = new System.Drawing.Size(341, 33);
            tboxEnterURL.TabIndex = 108;
            tboxEnterURL.Text = "RTK2Go.com";
            tboxEnterURL.Click += tboxEnterURL_Click;
            // 
            // btnGetIP
            // 
            btnGetIP.BackColor = System.Drawing.SystemColors.ButtonFace;
            btnGetIP.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnGetIP.Location = new System.Drawing.Point(74, 438);
            btnGetIP.Name = "btnGetIP";
            btnGetIP.Size = new System.Drawing.Size(204, 52);
            btnGetIP.TabIndex = 109;
            btnGetIP.Text = "Verify URL or IP";
            btnGetIP.UseVisualStyleBackColor = false;
            btnGetIP.Click += btnGetIP_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(23, 82);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(42, 23);
            label2.TabIndex = 115;
            label2.Text = "Lat:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label8.Location = new System.Drawing.Point(18, 137);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(47, 23);
            label8.TabIndex = 116;
            label8.Text = "Lon:";
            // 
            // nudLatitude
            // 
            nudLatitude.BackColor = System.Drawing.Color.White;
            nudLatitude.DecimalPlaces = 7;
            nudLatitude.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            nudLatitude.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            nudLatitude.Location = new System.Drawing.Point(76, 82);
            nudLatitude.Maximum = new decimal(new int[] { 90, 0, 0, 0 });
            nudLatitude.Minimum = new decimal(new int[] { 90, 0, 0, int.MinValue });
            nudLatitude.Name = "nudLatitude";
            nudLatitude.Size = new System.Drawing.Size(224, 33);
            nudLatitude.TabIndex = 118;
            nudLatitude.Value = new decimal(new int[] { 881234567, 0, 0, -2147024896 });
            nudLatitude.Enter += NudLatitude_Enter;
            // 
            // nudLongitude
            // 
            nudLongitude.BackColor = System.Drawing.Color.White;
            nudLongitude.DecimalPlaces = 7;
            nudLongitude.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            nudLongitude.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            nudLongitude.Location = new System.Drawing.Point(76, 137);
            nudLongitude.Maximum = new decimal(new int[] { 180, 0, 0, 0 });
            nudLongitude.Minimum = new decimal(new int[] { 180, 0, 0, int.MinValue });
            nudLongitude.Name = "nudLongitude";
            nudLongitude.Size = new System.Drawing.Size(224, 33);
            nudLongitude.TabIndex = 117;
            nudLongitude.Value = new decimal(new int[] { 1781234567, 0, 0, -2147024896 });
            nudLongitude.Enter += NudLongitude_Enter;
            // 
            // tboxCurrentLat
            // 
            tboxCurrentLat.BackColor = System.Drawing.Color.White;
            tboxCurrentLat.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            tboxCurrentLat.Location = new System.Drawing.Point(75, 310);
            tboxCurrentLat.Name = "tboxCurrentLat";
            tboxCurrentLat.ReadOnly = true;
            tboxCurrentLat.Size = new System.Drawing.Size(224, 33);
            tboxCurrentLat.TabIndex = 119;
            tboxCurrentLat.Text = "53.2398652";
            // 
            // tboxCurrentLon
            // 
            tboxCurrentLon.BackColor = System.Drawing.Color.White;
            tboxCurrentLon.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            tboxCurrentLon.Location = new System.Drawing.Point(75, 369);
            tboxCurrentLon.Name = "tboxCurrentLon";
            tboxCurrentLon.ReadOnly = true;
            tboxCurrentLon.Size = new System.Drawing.Size(224, 33);
            tboxCurrentLon.TabIndex = 120;
            tboxCurrentLon.Text = "-111.1234567";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 500;
            timer1.Tick += timer1_Tick;
            // 
            // label9
            // 
            label9.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label9.Location = new System.Drawing.Point(31, 271);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(319, 32);
            label9.TabIndex = 122;
            label9.Text = "Current GPS Fix:";
            label9.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label11.Location = new System.Drawing.Point(27, 314);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(42, 23);
            label11.TabIndex = 123;
            label11.Text = "Lat:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label16.Location = new System.Drawing.Point(23, 373);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(47, 23);
            label16.TabIndex = 124;
            label16.Text = "Lon:";
            // 
            // label17
            // 
            label17.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label17.Location = new System.Drawing.Point(45, 46);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(269, 30);
            label17.TabIndex = 125;
            label17.Text = "Manual Fix:";
            label17.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnGetSourceTable
            // 
            btnGetSourceTable.BackColor = System.Drawing.SystemColors.MenuBar;
            btnGetSourceTable.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnGetSourceTable.Location = new System.Drawing.Point(436, 225);
            btnGetSourceTable.Name = "btnGetSourceTable";
            btnGetSourceTable.Size = new System.Drawing.Size(235, 52);
            btnGetSourceTable.TabIndex = 127;
            btnGetSourceTable.Text = "Get Source Table";
            btnGetSourceTable.UseVisualStyleBackColor = false;
            btnGetSourceTable.Click += btnGetSourceTable_Click;
            // 
            // btnSetManualPosition
            // 
            btnSetManualPosition.BackColor = System.Drawing.Color.White;
            btnSetManualPosition.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnSetManualPosition.Location = new System.Drawing.Point(75, 430);
            btnSetManualPosition.Name = "btnSetManualPosition";
            btnSetManualPosition.Size = new System.Drawing.Size(224, 33);
            btnSetManualPosition.TabIndex = 121;
            btnSetManualPosition.Text = "Send To Manual Fix";
            btnSetManualPosition.UseVisualStyleBackColor = false;
            btnSetManualPosition.Click += btnSetManualPosition_Click;
            // 
            // cboxGGAManual
            // 
            cboxGGAManual.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboxGGAManual.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cboxGGAManual.FormattingEnabled = true;
            cboxGGAManual.Items.AddRange(new object[] { "Use Manual Fix", "Use GPS Fix" });
            cboxGGAManual.Location = new System.Drawing.Point(76, 190);
            cboxGGAManual.Name = "cboxGGAManual";
            cboxGGAManual.Size = new System.Drawing.Size(192, 33);
            cboxGGAManual.TabIndex = 128;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label19.Location = new System.Drawing.Point(564, 381);
            label19.Name = "label19";
            label19.Size = new System.Drawing.Size(81, 25);
            label19.TabIndex = 131;
            label19.Text = "0 = Off";
            // 
            // checkBoxusetcp
            // 
            checkBoxusetcp.Appearance = System.Windows.Forms.Appearance.Button;
            checkBoxusetcp.BackColor = System.Drawing.Color.PeachPuff;
            checkBoxusetcp.FlatAppearance.CheckedBackColor = System.Drawing.Color.SpringGreen;
            checkBoxusetcp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            checkBoxusetcp.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            checkBoxusetcp.Location = new System.Drawing.Point(68, 172);
            checkBoxusetcp.Name = "checkBoxusetcp";
            checkBoxusetcp.Size = new System.Drawing.Size(129, 41);
            checkBoxusetcp.TabIndex = 132;
            checkBoxusetcp.Text = "Only TCP:Port";
            checkBoxusetcp.UseVisualStyleBackColor = false;
            // 
            // btnPassUsername
            // 
            btnPassUsername.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnPassUsername.Location = new System.Drawing.Point(647, 60);
            btnPassUsername.Name = "btnPassUsername";
            btnPassUsername.Size = new System.Drawing.Size(63, 40);
            btnPassUsername.TabIndex = 133;
            btnPassUsername.Text = "(o)";
            btnPassUsername.UseVisualStyleBackColor = true;
            btnPassUsername.Click += btnPassUsername_Click;
            // 
            // btnPassPassword
            // 
            btnPassPassword.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnPassPassword.Location = new System.Drawing.Point(647, 131);
            btnPassPassword.Name = "btnPassPassword";
            btnPassPassword.Size = new System.Drawing.Size(63, 40);
            btnPassPassword.TabIndex = 134;
            btnPassPassword.Text = "(o)";
            btnPassPassword.UseVisualStyleBackColor = true;
            btnPassPassword.Click += btnPassPassword_Click;
            // 
            // cboxHTTP
            // 
            cboxHTTP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboxHTTP.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cboxHTTP.FormattingEnabled = true;
            cboxHTTP.Items.AddRange(new object[] { "1.0", "1.1" });
            cboxHTTP.Location = new System.Drawing.Point(68, 73);
            cboxHTTP.Name = "cboxHTTP";
            cboxHTTP.Size = new System.Drawing.Size(129, 33);
            cboxHTTP.TabIndex = 135;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label20.Location = new System.Drawing.Point(94, 45);
            label20.Name = "label20";
            label20.Size = new System.Drawing.Size(76, 25);
            label20.TabIndex = 136;
            label20.Text = "HTTP:";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tabControl1.ItemSize = new System.Drawing.Size(200, 40);
            tabControl1.Location = new System.Drawing.Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(741, 563);
            tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            tabControl1.TabIndex = 137;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = System.Drawing.Color.Gainsboro;
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(listboxIP);
            tabPage1.Controls.Add(tboxUserPassword);
            tabPage1.Controls.Add(btnGetSourceTable);
            tabPage1.Controls.Add(label13);
            tabPage1.Controls.Add(tboxUserName);
            tabPage1.Controls.Add(tboxMount);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(btnPassPassword);
            tabPage1.Controls.Add(label12);
            tabPage1.Controls.Add(btnPassUsername);
            tabPage1.Controls.Add(btnGetIP);
            tabPage1.Controls.Add(tboxCasterIP);
            tabPage1.Controls.Add(tboxEnterURL);
            tabPage1.Controls.Add(nudCasterPort);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(label14);
            tabPage1.Controls.Add(tboxHostName);
            tabPage1.Location = new System.Drawing.Point(4, 44);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(733, 515);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Source";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label6.Location = new System.Drawing.Point(489, 454);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(123, 23);
            label6.TabIndex = 146;
            label6.Text = "Default: 2101";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label7.Location = new System.Drawing.Point(494, 379);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(123, 25);
            label7.TabIndex = 145;
            label7.Text = "Caster Port:";
            // 
            // listboxIP
            // 
            listboxIP.BackColor = System.Drawing.Color.Gainsboro;
            listboxIP.Enabled = false;
            listboxIP.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            listboxIP.FormattingEnabled = true;
            listboxIP.Items.AddRange(new object[] { "1", "2", "3" });
            listboxIP.Location = new System.Drawing.Point(91, 94);
            listboxIP.Name = "listboxIP";
            listboxIP.Size = new System.Drawing.Size(221, 120);
            listboxIP.TabIndex = 144;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = System.Drawing.Color.Gainsboro;
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(cboxToSerial);
            tabPage2.Controls.Add(cboxToUDP);
            tabPage2.Controls.Add(nudSendToUDPPort);
            tabPage2.Controls.Add(label19);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label15);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(nudGGAInterval);
            tabPage2.Controls.Add(cboxGGAManual);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(nudLongitude);
            tabPage2.Controls.Add(label17);
            tabPage2.Controls.Add(nudLatitude);
            tabPage2.Controls.Add(label16);
            tabPage2.Controls.Add(tboxCurrentLat);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(tboxCurrentLon);
            tabPage2.Controls.Add(btnSetManualPosition);
            tabPage2.Location = new System.Drawing.Point(4, 44);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(3);
            tabPage2.Size = new System.Drawing.Size(733, 515);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Position";
            // 
            // label1
            // 
            label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(440, 61);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(240, 31);
            label1.TabIndex = 142;
            label1.Text = "Send To GPS Using:";
            label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // cboxToSerial
            // 
            cboxToSerial.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            cboxToSerial.Appearance = System.Windows.Forms.Appearance.Button;
            cboxToSerial.BackColor = System.Drawing.Color.Salmon;
            cboxToSerial.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            cboxToSerial.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(128, 255, 128);
            cboxToSerial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboxToSerial.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            cboxToSerial.Image = Properties.Resources.NtripToSerial;
            cboxToSerial.Location = new System.Drawing.Point(395, 106);
            cboxToSerial.Name = "cboxToSerial";
            cboxToSerial.Size = new System.Drawing.Size(150, 50);
            cboxToSerial.TabIndex = 140;
            cboxToSerial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            cboxToSerial.UseVisualStyleBackColor = false;
            cboxToSerial.Click += cboxToSerial_Click;
            // 
            // cboxToUDP
            // 
            cboxToUDP.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            cboxToUDP.Appearance = System.Windows.Forms.Appearance.Button;
            cboxToUDP.BackColor = System.Drawing.Color.Salmon;
            cboxToUDP.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            cboxToUDP.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(128, 255, 128);
            cboxToUDP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboxToUDP.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            cboxToUDP.Image = Properties.Resources.NtripToUDP;
            cboxToUDP.Location = new System.Drawing.Point(395, 197);
            cboxToUDP.Name = "cboxToUDP";
            cboxToUDP.Size = new System.Drawing.Size(150, 50);
            cboxToUDP.TabIndex = 141;
            cboxToUDP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            cboxToUDP.UseVisualStyleBackColor = false;
            cboxToUDP.Click += cboxToUDP_Click;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = System.Drawing.Color.Gainsboro;
            tabPage3.Controls.Add(comboboxPacketSize);
            tabPage3.Controls.Add(labelRtcmPort);
            tabPage3.Controls.Add(cboxHTTP);
            tabPage3.Controls.Add(checkBoxusetcp);
            tabPage3.Controls.Add(label20);
            tabPage3.Location = new System.Drawing.Point(4, 44);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new System.Drawing.Size(733, 515);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Advanced";
            // 
            // comboboxPacketSize
            // 
            comboboxPacketSize.BackColor = System.Drawing.SystemColors.ControlLightLight;
            comboboxPacketSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboboxPacketSize.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            comboboxPacketSize.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            comboboxPacketSize.FormattingEnabled = true;
            comboboxPacketSize.Items.AddRange(new object[] { "64", "128", "256" });
            comboboxPacketSize.Location = new System.Drawing.Point(68, 345);
            comboboxPacketSize.Name = "comboboxPacketSize";
            comboboxPacketSize.Size = new System.Drawing.Size(129, 47);
            comboboxPacketSize.TabIndex = 138;
            // 
            // labelRtcmPort
            // 
            labelRtcmPort.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelRtcmPort.Location = new System.Drawing.Point(48, 280);
            labelRtcmPort.Name = "labelRtcmPort";
            labelRtcmPort.Size = new System.Drawing.Size(174, 62);
            labelRtcmPort.TabIndex = 137;
            labelRtcmPort.Text = "UDP Send Packet Burst \r\nDefault 256 bytes\r\n";
            labelRtcmPort.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboxIsNTRIPOn
            // 
            cboxIsNTRIPOn.Appearance = System.Windows.Forms.Appearance.Button;
            cboxIsNTRIPOn.BackColor = System.Drawing.Color.Salmon;
            cboxIsNTRIPOn.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            cboxIsNTRIPOn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(128, 255, 128);
            cboxIsNTRIPOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboxIsNTRIPOn.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            cboxIsNTRIPOn.Location = new System.Drawing.Point(342, 588);
            cboxIsNTRIPOn.Name = "cboxIsNTRIPOn";
            cboxIsNTRIPOn.Size = new System.Drawing.Size(150, 50);
            cboxIsNTRIPOn.TabIndex = 92;
            cboxIsNTRIPOn.Text = "NTRIP On";
            cboxIsNTRIPOn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            cboxIsNTRIPOn.UseVisualStyleBackColor = false;
            cboxIsNTRIPOn.Click += cboxIsNTRIPOn_Click;
            // 
            // btnSerialOK
            // 
            btnSerialOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnSerialOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnSerialOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnSerialOK.FlatAppearance.BorderSize = 0;
            btnSerialOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSerialOK.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnSerialOK.ForeColor = System.Drawing.SystemColors.ControlText;
            btnSerialOK.Image = Properties.Resources.OK64;
            btnSerialOK.Location = new System.Drawing.Point(650, 581);
            btnSerialOK.Name = "btnSerialOK";
            btnSerialOK.Size = new System.Drawing.Size(105, 64);
            btnSerialOK.TabIndex = 94;
            btnSerialOK.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            btnSerialOK.UseVisualStyleBackColor = true;
            btnSerialOK.Click += btnSerialOK_Click;
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
            btnSerialCancel.Location = new System.Drawing.Point(529, 581);
            btnSerialCancel.Name = "btnSerialCancel";
            btnSerialCancel.Size = new System.Drawing.Size(105, 64);
            btnSerialCancel.TabIndex = 95;
            btnSerialCancel.UseVisualStyleBackColor = true;
            // 
            // btnHelp
            // 
            btnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnHelp.FlatAppearance.BorderSize = 0;
            btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnHelp.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnHelp.ForeColor = System.Drawing.SystemColors.ControlText;
            btnHelp.Image = Properties.Resources.Help;
            btnHelp.Location = new System.Drawing.Point(162, 577);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new System.Drawing.Size(76, 65);
            btnHelp.TabIndex = 533;
            btnHelp.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            btnHelp.UseVisualStyleBackColor = true;
            btnHelp.Click += btnHelp_Click;
            // 
            // FormNtrip
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.WhiteSmoke;
            ClientSize = new System.Drawing.Size(767, 648);
            ControlBox = false;
            Controls.Add(btnHelp);
            Controls.Add(tabControl1);
            Controls.Add(cboxIsNTRIPOn);
            Controls.Add(btnSerialCancel);
            Controls.Add(btnSerialOK);
            Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormNtrip";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "NTRIP Client Settings";
            Load += FormNtrip_Load;
            ((System.ComponentModel.ISupportInitialize)nudCasterPort).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSendToUDPPort).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudGGAInterval).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudLatitude).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudLongitude).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckBox cboxIsNTRIPOn;
        private System.Windows.Forms.TextBox tboxCasterIP;
        private System.Windows.Forms.NumericUpDown nudCasterPort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tboxHostName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown nudSendToUDPPort;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSerialOK;
        private System.Windows.Forms.TextBox tboxUserName;
        private System.Windows.Forms.TextBox tboxUserPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown nudGGAInterval;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tboxEnterURL;
        private System.Windows.Forms.Button btnGetIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudLatitude;
        private System.Windows.Forms.NumericUpDown nudLongitude;
        private System.Windows.Forms.TextBox tboxCurrentLat;
        private System.Windows.Forms.TextBox tboxCurrentLon;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnGetSourceTable;
        private System.Windows.Forms.Button btnSetManualPosition;
        private System.Windows.Forms.ComboBox cboxGGAManual;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.CheckBox checkBoxusetcp;
        public System.Windows.Forms.TextBox tboxMount;
        private System.Windows.Forms.Button btnPassUsername;
        private System.Windows.Forms.Button btnPassPassword;
        private System.Windows.Forms.ComboBox cboxHTTP;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox cboxToSerial;
        private System.Windows.Forms.CheckBox cboxToUDP;
        private System.Windows.Forms.ListBox listboxIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox comboboxPacketSize;
        private System.Windows.Forms.Label labelRtcmPort;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSerialCancel;
        private System.Windows.Forms.Button btnHelp;
    }
}
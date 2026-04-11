namespace GPS_Out
{
    partial class FrmStart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStart));
            tmrGGA = new System.Windows.Forms.Timer(components);
            tmrVTG = new System.Windows.Forms.Timer(components);
            tmrMinimize = new System.Windows.Forms.Timer(components);
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            tmrRMC = new System.Windows.Forms.Timer(components);
            tmrDisplay = new System.Windows.Forms.Timer(components);
            tmrZDA = new System.Windows.Forms.Timer(components);
            tabControl1 = new System.Windows.Forms.TabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
            lbAge = new System.Windows.Forms.Label();
            lbElev = new System.Windows.Forms.Label();
            lbSats = new System.Windows.Forms.Label();
            lbHDOP = new System.Windows.Forms.Label();
            lbSim = new System.Windows.Forms.Label();
            btnZDA = new System.Windows.Forms.Button();
            tbZDA = new System.Windows.Forms.TextBox();
            btnRMC = new System.Windows.Forms.Button();
            tbRMC = new System.Windows.Forms.TextBox();
            btnVTG = new System.Windows.Forms.Button();
            btnGGA = new System.Windows.Forms.Button();
            tbVTG = new System.Windows.Forms.TextBox();
            tbGGA = new System.Windows.Forms.TextBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            PortIndicator1 = new System.Windows.Forms.Label();
            btnRescan = new System.Windows.Forms.Button();
            lbPort = new System.Windows.Forms.Label();
            btnConnect1 = new System.Windows.Forms.Button();
            cboBaud1 = new System.Windows.Forms.ComboBox();
            cboPort1 = new System.Windows.Forms.ComboBox();
            lbBaud = new System.Windows.Forms.Label();
            lbQuality = new System.Windows.Forms.Label();
            lbSpeed = new System.Windows.Forms.Label();
            lbLat = new System.Windows.Forms.Label();
            lbLon = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            tabPage2 = new System.Windows.Forms.TabPage();
            cboPrecision = new System.Windows.Forms.ComboBox();
            label12 = new System.Windows.Forms.Label();
            ckSimulate = new System.Windows.Forms.CheckBox();
            rbGP = new System.Windows.Forms.RadioButton();
            rbGN = new System.Windows.Forms.RadioButton();
            ckGSA = new System.Windows.Forms.CheckBox();
            ckRoll = new System.Windows.Forms.CheckBox();
            ckAutoConnect = new System.Windows.Forms.CheckBox();
            ckAutoHide = new System.Windows.Forms.CheckBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            label19 = new System.Windows.Forms.Label();
            cboZDA = new System.Windows.Forms.ComboBox();
            label20 = new System.Windows.Forms.Label();
            label17 = new System.Windows.Forms.Label();
            cboRMC = new System.Windows.Forms.ComboBox();
            label18 = new System.Windows.Forms.Label();
            label16 = new System.Windows.Forms.Label();
            cboVTG = new System.Windows.Forms.ComboBox();
            label11 = new System.Windows.Forms.Label();
            cboGGA = new System.Windows.Forms.ComboBox();
            label10 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            tmrGSA = new System.Windows.Forms.Timer(components);
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // tmrGGA
            // 
            tmrGGA.Interval = 5000;
            tmrGGA.Tick += tmrGGA_Tick;
            // 
            // tmrVTG
            // 
            tmrVTG.Tick += tmrVTG_Tick;
            // 
            // tmrMinimize
            // 
            tmrMinimize.Enabled = true;
            tmrMinimize.Interval = 120000;
            tmrMinimize.Tick += tmrMinimize_Tick;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
            // 
            // tmrRMC
            // 
            tmrRMC.Tick += tmrRMC_Tick;
            // 
            // tmrDisplay
            // 
            tmrDisplay.Enabled = true;
            tmrDisplay.Interval = 500;
            tmrDisplay.Tick += tmrDisplay_Tick;
            // 
            // tmrZDA
            // 
            tmrZDA.Tick += tmrZDA_Tick;
            // 
            // tabControl1
            // 
            tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControl1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            tabControl1.ItemSize = new System.Drawing.Size(200, 40);
            tabControl1.Location = new System.Drawing.Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(626, 536);
            tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            tabControl1.TabIndex = 309;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = System.Drawing.Color.Transparent;
            tabPage1.Controls.Add(lbAge);
            tabPage1.Controls.Add(lbElev);
            tabPage1.Controls.Add(lbSats);
            tabPage1.Controls.Add(lbHDOP);
            tabPage1.Controls.Add(lbSim);
            tabPage1.Controls.Add(btnZDA);
            tabPage1.Controls.Add(tbZDA);
            tabPage1.Controls.Add(btnRMC);
            tabPage1.Controls.Add(tbRMC);
            tabPage1.Controls.Add(btnVTG);
            tabPage1.Controls.Add(btnGGA);
            tabPage1.Controls.Add(tbVTG);
            tabPage1.Controls.Add(tbGGA);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(lbQuality);
            tabPage1.Controls.Add(lbSpeed);
            tabPage1.Controls.Add(lbLat);
            tabPage1.Controls.Add(lbLon);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new System.Drawing.Point(4, 44);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(618, 488);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Main";
            // 
            // lbAge
            // 
            lbAge.AutoSize = true;
            lbAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lbAge.Location = new System.Drawing.Point(452, 218);
            lbAge.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            lbAge.Name = "lbAge";
            lbAge.Size = new System.Drawing.Size(126, 24);
            lbAge.TabIndex = 168;
            lbAge.Text = "1234567890.";
            lbAge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbElev
            // 
            lbElev.AutoSize = true;
            lbElev.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lbElev.Location = new System.Drawing.Point(452, 188);
            lbElev.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            lbElev.Name = "lbElev";
            lbElev.Size = new System.Drawing.Size(126, 24);
            lbElev.TabIndex = 167;
            lbElev.Text = "1234567890.";
            lbElev.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbSats
            // 
            lbSats.AutoSize = true;
            lbSats.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lbSats.Location = new System.Drawing.Point(452, 158);
            lbSats.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            lbSats.Name = "lbSats";
            lbSats.Size = new System.Drawing.Size(126, 24);
            lbSats.TabIndex = 166;
            lbSats.Text = "1234567890.";
            lbSats.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbHDOP
            // 
            lbHDOP.AutoSize = true;
            lbHDOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lbHDOP.Location = new System.Drawing.Point(452, 128);
            lbHDOP.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            lbHDOP.Name = "lbHDOP";
            lbHDOP.Size = new System.Drawing.Size(126, 24);
            lbHDOP.TabIndex = 165;
            lbHDOP.Text = "1234567890.";
            lbHDOP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbSim
            // 
            lbSim.BackColor = System.Drawing.Color.Transparent;
            lbSim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lbSim.Location = new System.Drawing.Point(244, 216);
            lbSim.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            lbSim.Name = "lbSim";
            lbSim.Size = new System.Drawing.Size(102, 24);
            lbSim.TabIndex = 317;
            lbSim.Text = "Simulated";
            lbSim.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnZDA
            // 
            btnZDA.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnZDA.Location = new System.Drawing.Point(6, 431);
            btnZDA.Name = "btnZDA";
            btnZDA.Size = new System.Drawing.Size(75, 47);
            btnZDA.TabIndex = 316;
            btnZDA.Text = "ZDA";
            btnZDA.UseVisualStyleBackColor = true;
            btnZDA.Click += btnZDA_Click;
            // 
            // tbZDA
            // 
            tbZDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tbZDA.Location = new System.Drawing.Point(93, 428);
            tbZDA.Multiline = true;
            tbZDA.Name = "tbZDA";
            tbZDA.ReadOnly = true;
            tbZDA.Size = new System.Drawing.Size(512, 52);
            tbZDA.TabIndex = 315;
            // 
            // btnRMC
            // 
            btnRMC.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnRMC.Location = new System.Drawing.Point(6, 373);
            btnRMC.Name = "btnRMC";
            btnRMC.Size = new System.Drawing.Size(75, 47);
            btnRMC.TabIndex = 314;
            btnRMC.Text = "RMC";
            btnRMC.UseVisualStyleBackColor = true;
            btnRMC.Click += btnRMC_Click;
            // 
            // tbRMC
            // 
            tbRMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tbRMC.Location = new System.Drawing.Point(93, 370);
            tbRMC.Multiline = true;
            tbRMC.Name = "tbRMC";
            tbRMC.ReadOnly = true;
            tbRMC.Size = new System.Drawing.Size(512, 52);
            tbRMC.TabIndex = 313;
            // 
            // btnVTG
            // 
            btnVTG.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnVTG.Location = new System.Drawing.Point(6, 315);
            btnVTG.Name = "btnVTG";
            btnVTG.Size = new System.Drawing.Size(75, 47);
            btnVTG.TabIndex = 312;
            btnVTG.Text = "VTG";
            btnVTG.UseVisualStyleBackColor = true;
            btnVTG.Click += btnVTG_Click;
            // 
            // btnGGA
            // 
            btnGGA.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnGGA.Location = new System.Drawing.Point(6, 257);
            btnGGA.Name = "btnGGA";
            btnGGA.Size = new System.Drawing.Size(75, 47);
            btnGGA.TabIndex = 311;
            btnGGA.Text = "GGA";
            btnGGA.UseVisualStyleBackColor = true;
            btnGGA.Click += btnGGA_Click;
            // 
            // tbVTG
            // 
            tbVTG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tbVTG.Location = new System.Drawing.Point(93, 312);
            tbVTG.Multiline = true;
            tbVTG.Name = "tbVTG";
            tbVTG.ReadOnly = true;
            tbVTG.Size = new System.Drawing.Size(512, 52);
            tbVTG.TabIndex = 310;
            // 
            // tbGGA
            // 
            tbGGA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tbGGA.Location = new System.Drawing.Point(93, 254);
            tbGGA.Multiline = true;
            tbGGA.Name = "tbGGA";
            tbGGA.ReadOnly = true;
            tbGGA.Size = new System.Drawing.Size(512, 52);
            tbGGA.TabIndex = 309;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(PortIndicator1);
            groupBox1.Controls.Add(btnRescan);
            groupBox1.Controls.Add(lbPort);
            groupBox1.Controls.Add(btnConnect1);
            groupBox1.Controls.Add(cboBaud1);
            groupBox1.Controls.Add(cboPort1);
            groupBox1.Controls.Add(lbBaud);
            groupBox1.Location = new System.Drawing.Point(8, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(597, 106);
            groupBox1.TabIndex = 169;
            groupBox1.TabStop = false;
            groupBox1.Text = "Serial Port";
            groupBox1.Paint += groupBox1_Paint;
            // 
            // PortIndicator1
            // 
            PortIndicator1.BackColor = System.Drawing.SystemColors.Control;
            PortIndicator1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            PortIndicator1.Image = Properties.Resources.Off;
            PortIndicator1.Location = new System.Drawing.Point(453, 54);
            PortIndicator1.Name = "PortIndicator1";
            PortIndicator1.Size = new System.Drawing.Size(41, 37);
            PortIndicator1.TabIndex = 129;
            PortIndicator1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRescan
            // 
            btnRescan.BackColor = System.Drawing.Color.Transparent;
            btnRescan.FlatAppearance.BorderSize = 0;
            btnRescan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            btnRescan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRescan.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnRescan.Image = Properties.Resources.ScanPorts;
            btnRescan.Location = new System.Drawing.Point(508, 24);
            btnRescan.Name = "btnRescan";
            btnRescan.Size = new System.Drawing.Size(72, 72);
            btnRescan.TabIndex = 151;
            btnRescan.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            btnRescan.UseVisualStyleBackColor = false;
            btnRescan.Click += btnRescan_Click;
            // 
            // lbPort
            // 
            lbPort.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lbPort.Location = new System.Drawing.Point(177, 27);
            lbPort.Name = "lbPort";
            lbPort.Size = new System.Drawing.Size(127, 23);
            lbPort.TabIndex = 126;
            lbPort.Text = "Port";
            lbPort.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnConnect1
            // 
            btnConnect1.BackColor = System.Drawing.SystemColors.ControlLight;
            btnConnect1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            btnConnect1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnConnect1.Location = new System.Drawing.Point(16, 54);
            btnConnect1.Name = "btnConnect1";
            btnConnect1.Size = new System.Drawing.Size(145, 37);
            btnConnect1.TabIndex = 128;
            btnConnect1.Text = "Connect";
            btnConnect1.UseVisualStyleBackColor = false;
            btnConnect1.Click += btnConnect1_Click;
            // 
            // cboBaud1
            // 
            cboBaud1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            cboBaud1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboBaud1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cboBaud1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            cboBaud1.FormattingEnabled = true;
            cboBaud1.Items.AddRange(new object[] { "4800", "9600", "19200", "38400", "57600", "115200" });
            cboBaud1.Location = new System.Drawing.Point(323, 54);
            cboBaud1.Name = "cboBaud1";
            cboBaud1.Size = new System.Drawing.Size(127, 37);
            cboBaud1.TabIndex = 130;
            cboBaud1.SelectedIndexChanged += cboBaud1_SelectedIndexChanged;
            // 
            // cboPort1
            // 
            cboPort1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboPort1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cboPort1.FormattingEnabled = true;
            cboPort1.Location = new System.Drawing.Point(175, 54);
            cboPort1.Name = "cboPort1";
            cboPort1.Size = new System.Drawing.Size(127, 37);
            cboPort1.TabIndex = 127;
            cboPort1.SelectedIndexChanged += cboPort1_SelectedIndexChanged;
            // 
            // lbBaud
            // 
            lbBaud.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lbBaud.Location = new System.Drawing.Point(327, 27);
            lbBaud.Name = "lbBaud";
            lbBaud.Size = new System.Drawing.Size(127, 23);
            lbBaud.TabIndex = 131;
            lbBaud.Text = "Baud";
            lbBaud.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbQuality
            // 
            lbQuality.BackColor = System.Drawing.Color.Transparent;
            lbQuality.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lbQuality.Location = new System.Drawing.Point(120, 216);
            lbQuality.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            lbQuality.Name = "lbQuality";
            lbQuality.Size = new System.Drawing.Size(126, 24);
            lbQuality.TabIndex = 164;
            lbQuality.Text = "RTK Fix";
            lbQuality.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbSpeed
            // 
            lbSpeed.AutoSize = true;
            lbSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lbSpeed.Location = new System.Drawing.Point(119, 188);
            lbSpeed.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            lbSpeed.Name = "lbSpeed";
            lbSpeed.Size = new System.Drawing.Size(126, 24);
            lbSpeed.TabIndex = 163;
            lbSpeed.Text = "1234567890.";
            lbSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbLat
            // 
            lbLat.AutoSize = true;
            lbLat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lbLat.Location = new System.Drawing.Point(119, 128);
            lbLat.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            lbLat.Name = "lbLat";
            lbLat.Size = new System.Drawing.Size(126, 24);
            lbLat.TabIndex = 162;
            lbLat.Text = "1234567890.";
            lbLat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbLon
            // 
            lbLon.AutoSize = true;
            lbLon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lbLon.Location = new System.Drawing.Point(119, 158);
            lbLon.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            lbLon.Name = "lbLon";
            lbLon.Size = new System.Drawing.Size(126, 24);
            lbLon.TabIndex = 161;
            lbLon.Text = "1234567890.";
            lbLon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label8.Location = new System.Drawing.Point(391, 216);
            label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(67, 24);
            label8.TabIndex = 160;
            label8.Text = "Age:";
            label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label7.Location = new System.Drawing.Point(350, 186);
            label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(108, 24);
            label7.TabIndex = 159;
            label7.Text = "Elevation:";
            label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label6.Location = new System.Drawing.Point(391, 156);
            label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(67, 24);
            label6.TabIndex = 158;
            label6.Text = "Sats:";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label5.Location = new System.Drawing.Point(372, 126);
            label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(86, 24);
            label5.TabIndex = 157;
            label5.Text = "HDOP:";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.BackColor = System.Drawing.Color.Transparent;
            label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label4.Location = new System.Drawing.Point(8, 216);
            label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(119, 24);
            label4.TabIndex = 156;
            label4.Text = "Quality:";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(8, 186);
            label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(119, 24);
            label3.TabIndex = 155;
            label3.Text = "Speed:";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(8, 126);
            label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(119, 24);
            label2.TabIndex = 154;
            label2.Text = "Latitude:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(8, 156);
            label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(119, 24);
            label1.TabIndex = 153;
            label1.Text = "Longitude:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = System.Drawing.Color.Gainsboro;
            tabPage2.Controls.Add(cboPrecision);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(ckSimulate);
            tabPage2.Controls.Add(rbGP);
            tabPage2.Controls.Add(rbGN);
            tabPage2.Controls.Add(ckGSA);
            tabPage2.Controls.Add(ckRoll);
            tabPage2.Controls.Add(ckAutoConnect);
            tabPage2.Controls.Add(ckAutoHide);
            tabPage2.Controls.Add(groupBox2);
            tabPage2.Location = new System.Drawing.Point(4, 44);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(3);
            tabPage2.Size = new System.Drawing.Size(618, 488);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Options";
            // 
            // cboPrecision
            // 
            cboPrecision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboPrecision.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cboPrecision.FormattingEnabled = true;
            cboPrecision.Items.AddRange(new object[] { "4", "5", "6", "7" });
            cboPrecision.Location = new System.Drawing.Point(481, 425);
            cboPrecision.Name = "cboPrecision";
            cboPrecision.Size = new System.Drawing.Size(71, 47);
            cboPrecision.TabIndex = 317;
            cboPrecision.SelectedIndexChanged += cbPrecision_SelectedIndexChanged;
            // 
            // label12
            // 
            label12.Location = new System.Drawing.Point(367, 418);
            label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(105, 61);
            label12.TabIndex = 316;
            label12.Text = "Decimal Precision";
            label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ckSimulate
            // 
            ckSimulate.Appearance = System.Windows.Forms.Appearance.Button;
            ckSimulate.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(192, 255, 192);
            ckSimulate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            ckSimulate.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            ckSimulate.Location = new System.Drawing.Point(97, 418);
            ckSimulate.Name = "ckSimulate";
            ckSimulate.Size = new System.Drawing.Size(182, 61);
            ckSimulate.TabIndex = 315;
            ckSimulate.Text = "Simulate Data";
            ckSimulate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            ckSimulate.UseVisualStyleBackColor = true;
            ckSimulate.CheckedChanged += ckSimulate_CheckedChanged;
            // 
            // rbGP
            // 
            rbGP.Appearance = System.Windows.Forms.Appearance.Button;
            rbGP.Checked = true;
            rbGP.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(192, 255, 192);
            rbGP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rbGP.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            rbGP.Location = new System.Drawing.Point(97, 264);
            rbGP.Name = "rbGP";
            rbGP.Size = new System.Drawing.Size(182, 61);
            rbGP.TabIndex = 314;
            rbGP.TabStop = true;
            rbGP.Text = "Send $GP---";
            rbGP.UseVisualStyleBackColor = true;
            rbGP.CheckedChanged += rbGP_CheckedChanged;
            // 
            // rbGN
            // 
            rbGN.Appearance = System.Windows.Forms.Appearance.Button;
            rbGN.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(192, 255, 192);
            rbGN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rbGN.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            rbGN.Location = new System.Drawing.Point(370, 264);
            rbGN.Name = "rbGN";
            rbGN.Size = new System.Drawing.Size(182, 61);
            rbGN.TabIndex = 313;
            rbGN.Text = "Send $GN---";
            rbGN.UseVisualStyleBackColor = true;
            // 
            // ckGSA
            // 
            ckGSA.Appearance = System.Windows.Forms.Appearance.Button;
            ckGSA.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(192, 255, 192);
            ckGSA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            ckGSA.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            ckGSA.Location = new System.Drawing.Point(370, 341);
            ckGSA.Name = "ckGSA";
            ckGSA.Size = new System.Drawing.Size(182, 61);
            ckGSA.TabIndex = 312;
            ckGSA.Text = "Send empty GSA";
            ckGSA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            ckGSA.UseVisualStyleBackColor = true;
            ckGSA.CheckedChanged += ckGSA_CheckedChanged;
            // 
            // ckRoll
            // 
            ckRoll.Appearance = System.Windows.Forms.Appearance.Button;
            ckRoll.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(192, 255, 192);
            ckRoll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            ckRoll.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            ckRoll.Location = new System.Drawing.Point(97, 341);
            ckRoll.Name = "ckRoll";
            ckRoll.Size = new System.Drawing.Size(182, 61);
            ckRoll.TabIndex = 311;
            ckRoll.Text = "Roll Corrected";
            ckRoll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            ckRoll.UseVisualStyleBackColor = true;
            ckRoll.CheckedChanged += ckRoll_CheckedChanged;
            // 
            // ckAutoConnect
            // 
            ckAutoConnect.Appearance = System.Windows.Forms.Appearance.Button;
            ckAutoConnect.Checked = true;
            ckAutoConnect.CheckState = System.Windows.Forms.CheckState.Checked;
            ckAutoConnect.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(192, 255, 192);
            ckAutoConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            ckAutoConnect.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            ckAutoConnect.Location = new System.Drawing.Point(97, 187);
            ckAutoConnect.Name = "ckAutoConnect";
            ckAutoConnect.Size = new System.Drawing.Size(182, 61);
            ckAutoConnect.TabIndex = 306;
            ckAutoConnect.Text = "Auto Connect";
            ckAutoConnect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            ckAutoConnect.UseVisualStyleBackColor = true;
            ckAutoConnect.CheckedChanged += ckAutoConnect_CheckedChanged;
            // 
            // ckAutoHide
            // 
            ckAutoHide.Appearance = System.Windows.Forms.Appearance.Button;
            ckAutoHide.Checked = true;
            ckAutoHide.CheckState = System.Windows.Forms.CheckState.Checked;
            ckAutoHide.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(192, 255, 192);
            ckAutoHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            ckAutoHide.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            ckAutoHide.Location = new System.Drawing.Point(370, 187);
            ckAutoHide.Name = "ckAutoHide";
            ckAutoHide.Size = new System.Drawing.Size(182, 61);
            ckAutoHide.TabIndex = 305;
            ckAutoHide.Text = "Auto Hide";
            ckAutoHide.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            ckAutoHide.UseVisualStyleBackColor = true;
            ckAutoHide.CheckedChanged += ckAutoHide_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label19);
            groupBox2.Controls.Add(cboZDA);
            groupBox2.Controls.Add(label20);
            groupBox2.Controls.Add(label17);
            groupBox2.Controls.Add(cboRMC);
            groupBox2.Controls.Add(label18);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(cboVTG);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(cboGGA);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            groupBox2.Location = new System.Drawing.Point(97, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(455, 175);
            groupBox2.TabIndex = 155;
            groupBox2.TabStop = false;
            groupBox2.Text = "Transfer Rate";
            groupBox2.Paint += groupBox1_Paint;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new System.Drawing.Point(392, 122);
            label19.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label19.Name = "label19";
            label19.Size = new System.Drawing.Size(39, 25);
            label19.TabIndex = 164;
            label19.Text = "Hz";
            // 
            // cboZDA
            // 
            cboZDA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboZDA.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cboZDA.FormattingEnabled = true;
            cboZDA.Items.AddRange(new object[] { "0", "1", "5", "10" });
            cboZDA.Location = new System.Drawing.Point(317, 111);
            cboZDA.Name = "cboZDA";
            cboZDA.Size = new System.Drawing.Size(71, 47);
            cboZDA.TabIndex = 163;
            cboZDA.SelectedIndexChanged += cboZDA_SelectedIndexChanged;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new System.Drawing.Point(259, 122);
            label20.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label20.Name = "label20";
            label20.Size = new System.Drawing.Size(55, 25);
            label20.TabIndex = 162;
            label20.Text = "ZDA";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new System.Drawing.Point(392, 50);
            label17.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(39, 25);
            label17.TabIndex = 161;
            label17.Text = "Hz";
            // 
            // cboRMC
            // 
            cboRMC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboRMC.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cboRMC.FormattingEnabled = true;
            cboRMC.Items.AddRange(new object[] { "0", "1", "5", "10" });
            cboRMC.Location = new System.Drawing.Point(317, 39);
            cboRMC.Name = "cboRMC";
            cboRMC.Size = new System.Drawing.Size(71, 47);
            cboRMC.TabIndex = 160;
            cboRMC.SelectedIndexChanged += cboRMC_SelectedIndexChanged;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new System.Drawing.Point(254, 50);
            label18.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label18.Name = "label18";
            label18.Size = new System.Drawing.Size(60, 25);
            label18.TabIndex = 159;
            label18.Text = "RMC";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new System.Drawing.Point(150, 122);
            label16.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(39, 25);
            label16.TabIndex = 158;
            label16.Text = "Hz";
            // 
            // cboVTG
            // 
            cboVTG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboVTG.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cboVTG.FormattingEnabled = true;
            cboVTG.Items.AddRange(new object[] { "0", "1", "5", "10" });
            cboVTG.Location = new System.Drawing.Point(75, 111);
            cboVTG.Name = "cboVTG";
            cboVTG.Size = new System.Drawing.Size(71, 47);
            cboVTG.TabIndex = 157;
            cboVTG.SelectedIndexChanged += cboVTG_SelectedIndexChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(150, 50);
            label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(39, 25);
            label11.TabIndex = 156;
            label11.Text = "Hz";
            // 
            // cboGGA
            // 
            cboGGA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboGGA.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cboGGA.FormattingEnabled = true;
            cboGGA.Items.AddRange(new object[] { "0", "1", "5", "10" });
            cboGGA.Location = new System.Drawing.Point(75, 39);
            cboGGA.Name = "cboGGA";
            cboGGA.Size = new System.Drawing.Size(71, 47);
            cboGGA.TabIndex = 155;
            cboGGA.SelectedIndexChanged += cboGGA_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(15, 122);
            label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(55, 25);
            label10.TabIndex = 154;
            label10.Text = "VTG";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(12, 50);
            label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(58, 25);
            label9.TabIndex = 153;
            label9.Text = "GGA";
            // 
            // tmrGSA
            // 
            tmrGSA.Interval = 1000;
            tmrGSA.Tick += tmrGSA_Tick;
            // 
            // FrmStart
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Control;
            ClientSize = new System.Drawing.Size(626, 536);
            Controls.Add(tabControl1);
            Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(6);
            MaximizeBox = false;
            Name = "FrmStart";
            Text = "GPS_Out";
            FormClosed += frmStart_FormClosed;
            Load += frmStart_Load;
            Resize += frmStart_Resize;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            groupBox1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer tmrGGA;
        private System.Windows.Forms.Timer tmrVTG;
        private System.Windows.Forms.Timer tmrMinimize;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer tmrRMC;
        private System.Windows.Forms.Timer tmrDisplay;
        private System.Windows.Forms.Timer tmrZDA;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label PortIndicator1;
        private System.Windows.Forms.Button btnRescan;
        private System.Windows.Forms.Label lbPort;
        private System.Windows.Forms.Button btnConnect1;
        private System.Windows.Forms.ComboBox cboBaud1;
        private System.Windows.Forms.ComboBox cboPort1;
        private System.Windows.Forms.Label lbBaud;
        private System.Windows.Forms.Label lbAge;
        private System.Windows.Forms.Label lbElev;
        private System.Windows.Forms.Label lbSats;
        private System.Windows.Forms.Label lbHDOP;
        private System.Windows.Forms.Label lbQuality;
        private System.Windows.Forms.Label lbSpeed;
        private System.Windows.Forms.Label lbLat;
        private System.Windows.Forms.Label lbLon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnZDA;
        private System.Windows.Forms.TextBox tbZDA;
        private System.Windows.Forms.Button btnRMC;
        private System.Windows.Forms.TextBox tbRMC;
        private System.Windows.Forms.Button btnVTG;
        private System.Windows.Forms.Button btnGGA;
        private System.Windows.Forms.TextBox tbVTG;
        private System.Windows.Forms.TextBox tbGGA;
        private System.Windows.Forms.CheckBox ckAutoConnect;
        private System.Windows.Forms.CheckBox ckAutoHide;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cboZDA;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cboRMC;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cboVTG;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboGGA;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rbGN;
        private System.Windows.Forms.CheckBox ckGSA;
        private System.Windows.Forms.CheckBox ckRoll;
        private System.Windows.Forms.RadioButton rbGP;
        private System.Windows.Forms.Timer tmrGSA;
        private System.Windows.Forms.Label lbSim;
        private System.Windows.Forms.CheckBox ckSimulate;
        private System.Windows.Forms.ComboBox cboPrecision;
        private System.Windows.Forms.Label label12;
    }
}


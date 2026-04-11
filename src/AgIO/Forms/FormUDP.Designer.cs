namespace AgIO
{
    partial class FormUDP
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
            label6 = new System.Windows.Forms.Label();
            lblNetworkHelp = new System.Windows.Forms.Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new System.Windows.Forms.Label();
            nudFirstIP = new System.Windows.Forms.NumericUpDown();
            nudSecndIP = new System.Windows.Forms.NumericUpDown();
            nudThirdIP = new System.Windows.Forms.NumericUpDown();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            tboxNets = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            lblHostname = new System.Windows.Forms.Label();
            lblNoAdapter = new System.Windows.Forms.Label();
            cboxUp = new System.Windows.Forms.CheckBox();
            label9 = new System.Windows.Forms.Label();
            lblSubTimer = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            lblBtnIMU = new System.Windows.Forms.Label();
            lblBtnGPS = new System.Windows.Forms.Label();
            label18 = new System.Windows.Forms.Label();
            lblIMU_IP = new System.Windows.Forms.Label();
            lblBtnMachine = new System.Windows.Forms.Label();
            label15 = new System.Windows.Forms.Label();
            lblGPSIP = new System.Windows.Forms.Label();
            lblSteerIP = new System.Windows.Forms.Label();
            lblBtnSteer = new System.Windows.Forms.Label();
            label16 = new System.Windows.Forms.Label();
            lblMachineIP = new System.Windows.Forms.Label();
            label17 = new System.Windows.Forms.Label();
            lblNewSubnet = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            btnSerialMonitor = new System.Windows.Forms.Button();
            btnNetworkCPL = new System.Windows.Forms.Button();
            btnUDPOff = new System.Windows.Forms.Button();
            btnSendSubnet = new System.Windows.Forms.Button();
            btnSerialCancel = new System.Windows.Forms.Button();
            pboxSendSteer = new System.Windows.Forms.PictureBox();
            btnAutoSet = new System.Windows.Forms.Button();
            label5 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)nudFirstIP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSecndIP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudThirdIP).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pboxSendSteer).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label6.Location = new System.Drawing.Point(453, 550);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(139, 23);
            label6.TabIndex = 144;
            label6.Text = "Current Subnet";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNetworkHelp
            // 
            lblNetworkHelp.BackColor = System.Drawing.Color.WhiteSmoke;
            lblNetworkHelp.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblNetworkHelp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lblNetworkHelp.Location = new System.Drawing.Point(376, 500);
            lblNetworkHelp.Name = "lblNetworkHelp";
            lblNetworkHelp.Size = new System.Drawing.Size(279, 46);
            lblNetworkHelp.TabIndex = 143;
            lblNetworkHelp.Text = "192 . 168 . 123  .  x";
            lblNetworkHelp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 500;
            timer1.Tick += timer1_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(395, 370);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(236, 23);
            label1.TabIndex = 147;
            label1.Text = "Enter New Subnet Address";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudFirstIP
            // 
            nudFirstIP.BackColor = System.Drawing.Color.White;
            nudFirstIP.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            nudFirstIP.Location = new System.Drawing.Point(338, 398);
            nudFirstIP.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            nudFirstIP.Name = "nudFirstIP";
            nudFirstIP.Size = new System.Drawing.Size(102, 40);
            nudFirstIP.TabIndex = 148;
            nudFirstIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudFirstIP.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            nudFirstIP.Value = new decimal(new int[] { 192, 0, 0, 0 });
            nudFirstIP.Click += nudFirstIP_Click;
            // 
            // nudSecndIP
            // 
            nudSecndIP.BackColor = System.Drawing.Color.White;
            nudSecndIP.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            nudSecndIP.Location = new System.Drawing.Point(455, 398);
            nudSecndIP.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            nudSecndIP.Name = "nudSecndIP";
            nudSecndIP.Size = new System.Drawing.Size(102, 40);
            nudSecndIP.TabIndex = 149;
            nudSecndIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudSecndIP.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            nudSecndIP.Value = new decimal(new int[] { 168, 0, 0, 0 });
            nudSecndIP.Click += nudFirstIP_Click;
            // 
            // nudThirdIP
            // 
            nudThirdIP.BackColor = System.Drawing.Color.White;
            nudThirdIP.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            nudThirdIP.Location = new System.Drawing.Point(572, 398);
            nudThirdIP.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            nudThirdIP.Name = "nudThirdIP";
            nudThirdIP.Size = new System.Drawing.Size(102, 40);
            nudThirdIP.TabIndex = 150;
            nudThirdIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudThirdIP.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            nudThirdIP.Value = new decimal(new int[] { 5, 0, 0, 0 });
            nudThirdIP.Click += nudFirstIP_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(438, 392);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(24, 35);
            label2.TabIndex = 152;
            label2.Text = ".";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(555, 392);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(24, 35);
            label3.TabIndex = 153;
            label3.Text = ".";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label8.Location = new System.Drawing.Point(697, 455);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(103, 23);
            label8.TabIndex = 157;
            label8.Text = "Set Subnet";
            label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label7.Location = new System.Drawing.Point(319, 10);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(118, 23);
            label7.TabIndex = 161;
            label7.Text = "Module Scan";
            label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tboxNets
            // 
            tboxNets.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            tboxNets.Location = new System.Drawing.Point(16, 45);
            tboxNets.Multiline = true;
            tboxNets.Name = "tboxNets";
            tboxNets.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            tboxNets.Size = new System.Drawing.Size(261, 468);
            tboxNets.TabIndex = 162;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label4.Location = new System.Drawing.Point(14, 13);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(101, 23);
            label4.TabIndex = 163;
            label4.Text = "Hostname:";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHostname
            // 
            lblHostname.AutoSize = true;
            lblHostname.BackColor = System.Drawing.Color.Gainsboro;
            lblHostname.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblHostname.Location = new System.Drawing.Point(112, 13);
            lblHostname.Name = "lblHostname";
            lblHostname.Size = new System.Drawing.Size(94, 23);
            lblHostname.TabIndex = 165;
            lblHostname.Text = "Hostname";
            lblHostname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNoAdapter
            // 
            lblNoAdapter.AutoSize = true;
            lblNoAdapter.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblNoAdapter.ForeColor = System.Drawing.Color.Red;
            lblNoAdapter.Location = new System.Drawing.Point(366, 469);
            lblNoAdapter.Name = "lblNoAdapter";
            lblNoAdapter.Size = new System.Drawing.Size(298, 25);
            lblNoAdapter.TabIndex = 166;
            lblNoAdapter.Text = "No Adapter For This Subnet";
            lblNoAdapter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboxUp
            // 
            cboxUp.Appearance = System.Windows.Forms.Appearance.Button;
            cboxUp.BackColor = System.Drawing.Color.White;
            cboxUp.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            cboxUp.Checked = true;
            cboxUp.CheckState = System.Windows.Forms.CheckState.Checked;
            cboxUp.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke;
            cboxUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboxUp.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            cboxUp.Location = new System.Drawing.Point(78, 520);
            cboxUp.Name = "cboxUp";
            cboxUp.Size = new System.Drawing.Size(171, 50);
            cboxUp.TabIndex = 168;
            cboxUp.Text = "Up";
            cboxUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            cboxUp.UseVisualStyleBackColor = false;
            cboxUp.Click += cboxUp_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label9.Location = new System.Drawing.Point(18, 534);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(51, 23);
            label9.TabIndex = 513;
            label9.Text = "Filter";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSubTimer
            // 
            lblSubTimer.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblSubTimer.Location = new System.Drawing.Point(300, 232);
            lblSubTimer.Name = "lblSubTimer";
            lblSubTimer.Size = new System.Drawing.Size(100, 23);
            lblSubTimer.TabIndex = 514;
            lblSubTimer.Text = "Scanning";
            lblSubTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label11.Location = new System.Drawing.Point(484, 10);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(99, 23);
            label11.TabIndex = 516;
            label11.Text = "IP Address";
            label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            tableLayoutPanel1.Controls.Add(lblBtnIMU, 2, 0);
            tableLayoutPanel1.Controls.Add(lblBtnGPS, 2, 2);
            tableLayoutPanel1.Controls.Add(label18, 0, 0);
            tableLayoutPanel1.Controls.Add(lblIMU_IP, 1, 0);
            tableLayoutPanel1.Controls.Add(lblBtnMachine, 2, 3);
            tableLayoutPanel1.Controls.Add(label15, 0, 1);
            tableLayoutPanel1.Controls.Add(lblGPSIP, 1, 2);
            tableLayoutPanel1.Controls.Add(lblSteerIP, 1, 1);
            tableLayoutPanel1.Controls.Add(lblBtnSteer, 2, 1);
            tableLayoutPanel1.Controls.Add(label16, 0, 3);
            tableLayoutPanel1.Controls.Add(lblMachineIP, 1, 3);
            tableLayoutPanel1.Controls.Add(label17, 0, 2);
            tableLayoutPanel1.Location = new System.Drawing.Point(323, 35);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new System.Drawing.Size(341, 177);
            tableLayoutPanel1.TabIndex = 519;
            // 
            // lblBtnIMU
            // 
            lblBtnIMU.AutoSize = true;
            lblBtnIMU.BackColor = System.Drawing.Color.Transparent;
            lblBtnIMU.Dock = System.Windows.Forms.DockStyle.Fill;
            lblBtnIMU.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblBtnIMU.Location = new System.Drawing.Point(310, 1);
            lblBtnIMU.Name = "lblBtnIMU";
            lblBtnIMU.Size = new System.Drawing.Size(27, 43);
            lblBtnIMU.TabIndex = 533;
            lblBtnIMU.Text = "-";
            lblBtnIMU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBtnGPS
            // 
            lblBtnGPS.AutoSize = true;
            lblBtnGPS.BackColor = System.Drawing.Color.Transparent;
            lblBtnGPS.Dock = System.Windows.Forms.DockStyle.Fill;
            lblBtnGPS.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblBtnGPS.Location = new System.Drawing.Point(310, 89);
            lblBtnGPS.Name = "lblBtnGPS";
            lblBtnGPS.Size = new System.Drawing.Size(27, 43);
            lblBtnGPS.TabIndex = 532;
            lblBtnGPS.Text = "-";
            lblBtnGPS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = System.Drawing.Color.Transparent;
            label18.Dock = System.Windows.Forms.DockStyle.Fill;
            label18.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label18.Location = new System.Drawing.Point(4, 1);
            label18.Name = "label18";
            label18.Size = new System.Drawing.Size(89, 43);
            label18.TabIndex = 524;
            label18.Text = "IMU";
            label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIMU_IP
            // 
            lblIMU_IP.AutoSize = true;
            lblIMU_IP.BackColor = System.Drawing.Color.Transparent;
            lblIMU_IP.Dock = System.Windows.Forms.DockStyle.Fill;
            lblIMU_IP.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblIMU_IP.Location = new System.Drawing.Point(100, 1);
            lblIMU_IP.Name = "lblIMU_IP";
            lblIMU_IP.Size = new System.Drawing.Size(203, 43);
            lblIMU_IP.TabIndex = 526;
            lblIMU_IP.Text = "..";
            lblIMU_IP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBtnMachine
            // 
            lblBtnMachine.AutoSize = true;
            lblBtnMachine.BackColor = System.Drawing.Color.Transparent;
            lblBtnMachine.Dock = System.Windows.Forms.DockStyle.Fill;
            lblBtnMachine.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblBtnMachine.Location = new System.Drawing.Point(310, 133);
            lblBtnMachine.Name = "lblBtnMachine";
            lblBtnMachine.Size = new System.Drawing.Size(27, 43);
            lblBtnMachine.TabIndex = 531;
            lblBtnMachine.Text = "-";
            lblBtnMachine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = System.Drawing.Color.Transparent;
            label15.Dock = System.Windows.Forms.DockStyle.Fill;
            label15.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label15.Location = new System.Drawing.Point(4, 45);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(89, 43);
            label15.TabIndex = 521;
            label15.Text = "Steer";
            label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGPSIP
            // 
            lblGPSIP.AutoSize = true;
            lblGPSIP.BackColor = System.Drawing.Color.Transparent;
            lblGPSIP.Dock = System.Windows.Forms.DockStyle.Fill;
            lblGPSIP.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblGPSIP.Location = new System.Drawing.Point(100, 89);
            lblGPSIP.Name = "lblGPSIP";
            lblGPSIP.Size = new System.Drawing.Size(203, 43);
            lblGPSIP.TabIndex = 530;
            lblGPSIP.Text = "..";
            lblGPSIP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSteerIP
            // 
            lblSteerIP.AutoSize = true;
            lblSteerIP.BackColor = System.Drawing.Color.Transparent;
            lblSteerIP.Dock = System.Windows.Forms.DockStyle.Fill;
            lblSteerIP.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblSteerIP.Location = new System.Drawing.Point(100, 45);
            lblSteerIP.Name = "lblSteerIP";
            lblSteerIP.Size = new System.Drawing.Size(203, 43);
            lblSteerIP.TabIndex = 526;
            lblSteerIP.Text = "..";
            lblSteerIP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBtnSteer
            // 
            lblBtnSteer.AutoSize = true;
            lblBtnSteer.BackColor = System.Drawing.Color.Transparent;
            lblBtnSteer.Dock = System.Windows.Forms.DockStyle.Fill;
            lblBtnSteer.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblBtnSteer.Location = new System.Drawing.Point(310, 45);
            lblBtnSteer.Name = "lblBtnSteer";
            lblBtnSteer.Size = new System.Drawing.Size(27, 43);
            lblBtnSteer.TabIndex = 521;
            lblBtnSteer.Text = "-";
            lblBtnSteer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = System.Drawing.Color.Transparent;
            label16.Dock = System.Windows.Forms.DockStyle.Fill;
            label16.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label16.Location = new System.Drawing.Point(4, 133);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(89, 43);
            label16.TabIndex = 522;
            label16.Text = "Machine";
            label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMachineIP
            // 
            lblMachineIP.AutoSize = true;
            lblMachineIP.BackColor = System.Drawing.Color.Transparent;
            lblMachineIP.Dock = System.Windows.Forms.DockStyle.Fill;
            lblMachineIP.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblMachineIP.Location = new System.Drawing.Point(100, 133);
            lblMachineIP.Name = "lblMachineIP";
            lblMachineIP.Size = new System.Drawing.Size(203, 43);
            lblMachineIP.TabIndex = 528;
            lblMachineIP.Text = "..";
            lblMachineIP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = System.Drawing.Color.Transparent;
            label17.Dock = System.Windows.Forms.DockStyle.Fill;
            label17.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label17.Location = new System.Drawing.Point(4, 89);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(89, 43);
            label17.TabIndex = 523;
            label17.Text = "GPS";
            label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNewSubnet
            // 
            lblNewSubnet.BackColor = System.Drawing.Color.Gainsboro;
            lblNewSubnet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblNewSubnet.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblNewSubnet.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lblNewSubnet.Location = new System.Drawing.Point(404, 223);
            lblNewSubnet.Name = "lblNewSubnet";
            lblNewSubnet.Size = new System.Drawing.Size(244, 45);
            lblNewSubnet.TabIndex = 520;
            lblNewSubnet.Text = "192 . 168 . 123";
            lblNewSubnet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label10.Location = new System.Drawing.Point(749, 268);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(102, 18);
            label10.TabIndex = 523;
            label10.Text = "UDP Monitor";
            label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSerialMonitor
            // 
            btnSerialMonitor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnSerialMonitor.FlatAppearance.BorderSize = 0;
            btnSerialMonitor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSerialMonitor.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnSerialMonitor.ForeColor = System.Drawing.SystemColors.ControlText;
            btnSerialMonitor.Image = Properties.Resources.ScanNetwork;
            btnSerialMonitor.Location = new System.Drawing.Point(756, 207);
            btnSerialMonitor.Name = "btnSerialMonitor";
            btnSerialMonitor.Size = new System.Drawing.Size(76, 65);
            btnSerialMonitor.TabIndex = 522;
            btnSerialMonitor.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            btnSerialMonitor.UseVisualStyleBackColor = true;
            btnSerialMonitor.Click += btnSerialMonitor_Click;
            // 
            // btnNetworkCPL
            // 
            btnNetworkCPL.BackgroundImage = Properties.Resources.DeviceManager;
            btnNetworkCPL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnNetworkCPL.FlatAppearance.BorderSize = 0;
            btnNetworkCPL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNetworkCPL.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnNetworkCPL.ForeColor = System.Drawing.SystemColors.ControlText;
            btnNetworkCPL.Location = new System.Drawing.Point(756, 1);
            btnNetworkCPL.Name = "btnNetworkCPL";
            btnNetworkCPL.Size = new System.Drawing.Size(76, 65);
            btnNetworkCPL.TabIndex = 521;
            btnNetworkCPL.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            btnNetworkCPL.UseVisualStyleBackColor = true;
            btnNetworkCPL.Click += btnNetworkCPL_Click;
            // 
            // btnUDPOff
            // 
            btnUDPOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnUDPOff.FlatAppearance.BorderSize = 0;
            btnUDPOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnUDPOff.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnUDPOff.ForeColor = System.Drawing.SystemColors.ControlText;
            btnUDPOff.Image = Properties.Resources.EthernetOff;
            btnUDPOff.Location = new System.Drawing.Point(740, 108);
            btnUDPOff.Margin = new System.Windows.Forms.Padding(0);
            btnUDPOff.Name = "btnUDPOff";
            btnUDPOff.Size = new System.Drawing.Size(107, 65);
            btnUDPOff.TabIndex = 151;
            btnUDPOff.UseVisualStyleBackColor = true;
            btnUDPOff.Click += btnUDPOff_Click;
            // 
            // btnSendSubnet
            // 
            btnSendSubnet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnSendSubnet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSendSubnet.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnSendSubnet.ForeColor = System.Drawing.SystemColors.ControlText;
            btnSendSubnet.Image = Properties.Resources.SubnetSend;
            btnSendSubnet.Location = new System.Drawing.Point(701, 373);
            btnSendSubnet.Name = "btnSendSubnet";
            btnSendSubnet.Size = new System.Drawing.Size(92, 79);
            btnSendSubnet.TabIndex = 151;
            btnSendSubnet.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            btnSendSubnet.UseVisualStyleBackColor = true;
            btnSendSubnet.Click += btnSendSubnet_Click;
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
            btnSerialCancel.Location = new System.Drawing.Point(766, 502);
            btnSerialCancel.Name = "btnSerialCancel";
            btnSerialCancel.Size = new System.Drawing.Size(92, 79);
            btnSerialCancel.TabIndex = 71;
            btnSerialCancel.UseVisualStyleBackColor = true;
            btnSerialCancel.Click += btnSerialCancel_Click;
            // 
            // pboxSendSteer
            // 
            pboxSendSteer.BackgroundImage = Properties.Resources.ConSt_Mandatory;
            pboxSendSteer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pboxSendSteer.Location = new System.Drawing.Point(728, 333);
            pboxSendSteer.Name = "pboxSendSteer";
            pboxSendSteer.Size = new System.Drawing.Size(38, 39);
            pboxSendSteer.TabIndex = 510;
            pboxSendSteer.TabStop = false;
            pboxSendSteer.Visible = false;
            // 
            // btnAutoSet
            // 
            btnAutoSet.BackColor = System.Drawing.Color.WhiteSmoke;
            btnAutoSet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnAutoSet.Enabled = false;
            btnAutoSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAutoSet.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnAutoSet.Image = Properties.Resources.DnArrow64;
            btnAutoSet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnAutoSet.Location = new System.Drawing.Point(440, 279);
            btnAutoSet.Name = "btnAutoSet";
            btnAutoSet.Size = new System.Drawing.Size(162, 58);
            btnAutoSet.TabIndex = 524;
            btnAutoSet.Text = "Auto Fill New Subnet";
            btnAutoSet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnAutoSet.UseVisualStyleBackColor = false;
            btnAutoSet.Click += btnAutoSet_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label5.Location = new System.Drawing.Point(763, 173);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(68, 18);
            label5.TabIndex = 525;
            label5.Text = "UDP Off";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label12.Location = new System.Drawing.Point(739, 61);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(112, 18);
            label12.TabIndex = 526;
            label12.Text = "Network Prop";
            label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormUDP
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Gainsboro;
            ClientSize = new System.Drawing.Size(861, 584);
            ControlBox = false;
            Controls.Add(label10);
            Controls.Add(label12);
            Controls.Add(label5);
            Controls.Add(btnAutoSet);
            Controls.Add(btnSerialMonitor);
            Controls.Add(btnNetworkCPL);
            Controls.Add(lblNewSubnet);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label11);
            Controls.Add(label9);
            Controls.Add(cboxUp);
            Controls.Add(lblNoAdapter);
            Controls.Add(lblHostname);
            Controls.Add(label4);
            Controls.Add(tboxNets);
            Controls.Add(label6);
            Controls.Add(lblNetworkHelp);
            Controls.Add(label7);
            Controls.Add(btnUDPOff);
            Controls.Add(btnSendSubnet);
            Controls.Add(nudThirdIP);
            Controls.Add(nudSecndIP);
            Controls.Add(nudFirstIP);
            Controls.Add(label1);
            Controls.Add(btnSerialCancel);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label8);
            Controls.Add(pboxSendSteer);
            Controls.Add(lblSubTimer);
            Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormUDP";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Ethernet Configuration";
            Load += FormUDp_Load;
            ((System.ComponentModel.ISupportInitialize)nudFirstIP).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSecndIP).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudThirdIP).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pboxSendSteer).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSerialCancel;
        private System.Windows.Forms.Label lblNetworkHelp;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudFirstIP;
        private System.Windows.Forms.NumericUpDown nudSecndIP;
        private System.Windows.Forms.NumericUpDown nudThirdIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tboxNets;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblHostname;
        private System.Windows.Forms.Label lblNoAdapter;
        private System.Windows.Forms.CheckBox cboxUp;
        private System.Windows.Forms.PictureBox pboxSendSteer;
        private System.Windows.Forms.Button btnSendSubnet;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblSubTimer;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblSteerIP;
        private System.Windows.Forms.Label lblGPSIP;
        private System.Windows.Forms.Label lblMachineIP;
        private System.Windows.Forms.Label lblIMU_IP;
        private System.Windows.Forms.Label lblNewSubnet;
        private System.Windows.Forms.Label lblBtnIMU;
        private System.Windows.Forms.Label lblBtnGPS;
        private System.Windows.Forms.Label lblBtnMachine;
        private System.Windows.Forms.Label lblBtnSteer;
        private System.Windows.Forms.Button btnNetworkCPL;
        private System.Windows.Forms.Button btnSerialMonitor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnUDPOff;
        private System.Windows.Forms.Button btnAutoSet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
    }
}
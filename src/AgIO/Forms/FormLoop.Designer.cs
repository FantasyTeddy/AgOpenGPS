
using System.Globalization;
using System.Windows.Forms;

namespace AgIO
{
    partial class FormLoop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLoop));
            oneSecondLoopTimer = new Timer(components);
            label6 = new Label();
            label8 = new Label();
            lblCurentLon = new Label();
            lblCurrentLat = new Label();
            lblWatch = new Label();
            lblNTRIPBytes = new Label();
            lblMod2Comm = new Label();
            lblMod1Comm = new Label();
            lblIMUComm = new Label();
            lblFromGPS = new Label();
            lblGPS1Comm = new Label();
            statusStrip1 = new StatusStrip();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            toolStripSettings = new ToolStripMenuItem();
            toolStripMenuProfiles = new ToolStripMenuItem();
            toolStripLogViewer = new ToolStripMenuItem();
            toolStripUDPMonitor = new ToolStripMenuItem();
            toolStripSerialMonitor = new ToolStripMenuItem();
            toolStripAgDiag = new ToolStripMenuItem();
            modSimToolStrip = new ToolStripMenuItem();
            toolStripEthernet = new ToolStripMenuItem();
            deviceManagerToolStripMenuItem = new ToolStripMenuItem();
            isobusToolStripMenuItem = new ToolStripMenuItem();
            settingsMenuStrip = new ToolStripDropDownButton();
            saveToolStrip = new ToolStripMenuItem();
            loadToolStrip = new ToolStripMenuItem();
            serialPassThroughToolStripMenuItem = new ToolStripMenuItem();
            lblSteerAngle = new Label();
            label1 = new Label();
            lblNTRIP_IP = new Label();
            lblSerialPorts = new Label();
            lblMount = new Label();
            lblIP = new Label();
            ntripMeterTimer = new Timer(components);
            lblMessages = new Label();
            lblWASCounts = new Label();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            lblSwitchStatus = new Label();
            lblWorkSwitchStatus = new Label();
            label9 = new Label();
            btnStartStopNtrip = new Button();
            lblMessagesFound = new Label();
            label5 = new Label();
            lbl1To8 = new Label();
            label10 = new Label();
            lbl9To16 = new Label();
            label12 = new Label();
            lblStationID = new Label();
            label13 = new Label();
            lblCount = new Label();
            label7 = new Label();
            lblToGPS = new Label();
            lblPing = new Label();
            lblPingMachine = new Label();
            label11 = new Label();
            btnMinimizeMainForm = new Button();
            btnGPS_Out = new Button();
            cboxIsSteerModule = new CheckBox();
            cboxIsIMUModule = new CheckBox();
            cboxIsMachineModule = new CheckBox();
            btnIMU = new Button();
            btnSteer = new Button();
            btnMachine = new Button();
            btnGPS = new Button();
            btnSlide = new Button();
            pictureBox1 = new PictureBox();
            btnExit = new Button();
            btnRunAOG = new Button();
            btnUDP = new Button();
            btnGPSData = new Button();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // oneSecondLoopTimer
            // 
            oneSecondLoopTimer.Interval = 1500;
            oneSecondLoopTimer.Tick += oneSecondLoopTimer_Tick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = System.Drawing.Color.Transparent;
            label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label6.Location = new System.Drawing.Point(6, 9);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(24, 16);
            label6.TabIndex = 151;
            label6.Text = "Lat";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = System.Drawing.Color.Transparent;
            label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label8.Location = new System.Drawing.Point(3, 31);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(27, 16);
            label8.TabIndex = 152;
            label8.Text = "Lon";
            // 
            // lblCurentLon
            // 
            lblCurentLon.AutoSize = true;
            lblCurentLon.BackColor = System.Drawing.Color.Transparent;
            lblCurentLon.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblCurentLon.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lblCurentLon.Location = new System.Drawing.Point(30, 30);
            lblCurentLon.Margin = new Padding(4, 0, 4, 0);
            lblCurentLon.Name = "lblCurentLon";
            lblCurentLon.Size = new System.Drawing.Size(98, 18);
            lblCurentLon.TabIndex = 154;
            lblCurentLon.Text = "-888.8888888";
            // 
            // lblCurrentLat
            // 
            lblCurrentLat.AutoSize = true;
            lblCurrentLat.BackColor = System.Drawing.Color.Transparent;
            lblCurrentLat.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblCurrentLat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lblCurrentLat.Location = new System.Drawing.Point(30, 8);
            lblCurrentLat.Margin = new Padding(4, 0, 4, 0);
            lblCurrentLat.Name = "lblCurrentLat";
            lblCurrentLat.Size = new System.Drawing.Size(90, 18);
            lblCurrentLat.TabIndex = 153;
            lblCurrentLat.Text = "-53.1234567";
            // 
            // lblWatch
            // 
            lblWatch.BackColor = System.Drawing.Color.Transparent;
            lblWatch.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblWatch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lblWatch.Location = new System.Drawing.Point(14, 96);
            lblWatch.Margin = new Padding(4, 0, 4, 0);
            lblWatch.Name = "lblWatch";
            lblWatch.Size = new System.Drawing.Size(105, 18);
            lblWatch.TabIndex = 146;
            lblWatch.Text = "Watch";
            lblWatch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNTRIPBytes
            // 
            lblNTRIPBytes.BackColor = System.Drawing.Color.Transparent;
            lblNTRIPBytes.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblNTRIPBytes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lblNTRIPBytes.Location = new System.Drawing.Point(14, 72);
            lblNTRIPBytes.Margin = new Padding(4, 0, 4, 0);
            lblNTRIPBytes.Name = "lblNTRIPBytes";
            lblNTRIPBytes.Size = new System.Drawing.Size(105, 18);
            lblNTRIPBytes.TabIndex = 148;
            lblNTRIPBytes.Text = "999,999,999";
            lblNTRIPBytes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblNTRIPBytes.Click += lblNTRIPBytes_Click;
            // 
            // lblMod2Comm
            // 
            lblMod2Comm.BackColor = System.Drawing.Color.Transparent;
            lblMod2Comm.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblMod2Comm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lblMod2Comm.Location = new System.Drawing.Point(167, 342);
            lblMod2Comm.Margin = new Padding(2, 0, 2, 0);
            lblMod2Comm.Name = "lblMod2Comm";
            lblMod2Comm.Size = new System.Drawing.Size(64, 25);
            lblMod2Comm.TabIndex = 178;
            lblMod2Comm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMod1Comm
            // 
            lblMod1Comm.BackColor = System.Drawing.Color.Transparent;
            lblMod1Comm.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblMod1Comm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lblMod1Comm.Location = new System.Drawing.Point(167, 170);
            lblMod1Comm.Margin = new Padding(2, 0, 2, 0);
            lblMod1Comm.Name = "lblMod1Comm";
            lblMod1Comm.Size = new System.Drawing.Size(64, 25);
            lblMod1Comm.TabIndex = 177;
            lblMod1Comm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblIMUComm
            // 
            lblIMUComm.BackColor = System.Drawing.Color.Transparent;
            lblIMUComm.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblIMUComm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lblIMUComm.Location = new System.Drawing.Point(167, 86);
            lblIMUComm.Margin = new Padding(2, 0, 2, 0);
            lblIMUComm.Name = "lblIMUComm";
            lblIMUComm.Size = new System.Drawing.Size(64, 25);
            lblIMUComm.TabIndex = 175;
            lblIMUComm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFromGPS
            // 
            lblFromGPS.AutoSize = true;
            lblFromGPS.BackColor = System.Drawing.Color.Transparent;
            lblFromGPS.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblFromGPS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lblFromGPS.Location = new System.Drawing.Point(330, 273);
            lblFromGPS.Margin = new Padding(2, 0, 2, 0);
            lblFromGPS.Name = "lblFromGPS";
            lblFromGPS.Size = new System.Drawing.Size(26, 18);
            lblFromGPS.TabIndex = 130;
            lblFromGPS.Text = "---";
            lblFromGPS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGPS1Comm
            // 
            lblGPS1Comm.BackColor = System.Drawing.Color.Transparent;
            lblGPS1Comm.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblGPS1Comm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lblGPS1Comm.Location = new System.Drawing.Point(167, 257);
            lblGPS1Comm.Margin = new Padding(2, 0, 2, 0);
            lblGPS1Comm.Name = "lblGPS1Comm";
            lblGPS1Comm.Size = new System.Drawing.Size(64, 25);
            lblGPS1Comm.TabIndex = 176;
            lblGPS1Comm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // statusStrip1
            // 
            statusStrip1.AutoSize = false;
            statusStrip1.BackColor = System.Drawing.Color.Transparent;
            statusStrip1.Dock = DockStyle.None;
            statusStrip1.ImageScalingSize = new System.Drawing.Size(64, 64);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton1, settingsMenuStrip });
            statusStrip1.Location = new System.Drawing.Point(0, 412);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 11, 0);
            statusStrip1.Size = new System.Drawing.Size(230, 70);
            statusStrip1.SizingGrip = false;
            statusStrip1.TabIndex = 149;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.AutoSize = false;
            toolStripDropDownButton1.BackColor = System.Drawing.Color.Transparent;
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { toolStripSettings, toolStripMenuProfiles, toolStripLogViewer, toolStripUDPMonitor, toolStripSerialMonitor, toolStripAgDiag, modSimToolStrip, toolStripEthernet, deviceManagerToolStripMenuItem, isobusToolStripMenuItem });
            toolStripDropDownButton1.Image = Properties.Resources.Settings48;
            toolStripDropDownButton1.ImageScaling = ToolStripItemImageScaling.None;
            toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.ShowDropDownArrow = false;
            toolStripDropDownButton1.Size = new System.Drawing.Size(110, 68);
            // 
            // toolStripSettings
            // 
            toolStripSettings.Font = new System.Drawing.Font("Tahoma", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            toolStripSettings.Image = Properties.Resources.Settings48;
            toolStripSettings.Name = "toolStripSettings";
            toolStripSettings.Size = new System.Drawing.Size(393, 70);
            toolStripSettings.Text = "Advanced Settings";
            toolStripSettings.Click += toolStripSettings_Click;
            // 
            // toolStripMenuProfiles
            // 
            toolStripMenuProfiles.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            toolStripMenuProfiles.Image = Properties.Resources.VehFileSave;
            toolStripMenuProfiles.Name = "toolStripMenuProfiles";
            toolStripMenuProfiles.Size = new System.Drawing.Size(393, 70);
            toolStripMenuProfiles.Text = "Profiles";
            toolStripMenuProfiles.Click += toolStripMenuProfiles_Click;
            // 
            // toolStripLogViewer
            // 
            toolStripLogViewer.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            toolStripLogViewer.Image = Properties.Resources.LogViewer;
            toolStripLogViewer.Name = "toolStripLogViewer";
            toolStripLogViewer.Size = new System.Drawing.Size(393, 70);
            toolStripLogViewer.Text = "Log Viewer";
            toolStripLogViewer.Click += toolStripLogViewer_Click;
            // 
            // toolStripUDPMonitor
            // 
            toolStripUDPMonitor.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            toolStripUDPMonitor.Image = Properties.Resources.ScanNetwork;
            toolStripUDPMonitor.Name = "toolStripUDPMonitor";
            toolStripUDPMonitor.Size = new System.Drawing.Size(393, 70);
            toolStripUDPMonitor.Text = "UDP Monitor";
            toolStripUDPMonitor.Click += toolStripUDPMonitor_Click;
            // 
            // toolStripSerialMonitor
            // 
            toolStripSerialMonitor.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            toolStripSerialMonitor.Image = Properties.Resources.SerialMonitor;
            toolStripSerialMonitor.Name = "toolStripSerialMonitor";
            toolStripSerialMonitor.Size = new System.Drawing.Size(393, 70);
            toolStripSerialMonitor.Text = "Serial Monitor";
            toolStripSerialMonitor.Click += toolStripSerialMonitor_Click;
            // 
            // toolStripAgDiag
            // 
            toolStripAgDiag.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold);
            toolStripAgDiag.Image = Properties.Resources.AgDiag;
            toolStripAgDiag.Name = "toolStripAgDiag";
            toolStripAgDiag.Size = new System.Drawing.Size(393, 70);
            toolStripAgDiag.Text = "AgDiag";
            toolStripAgDiag.Click += toolStripAgDiag_Click;
            // 
            // modSimToolStrip
            // 
            modSimToolStrip.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            modSimToolStrip.Image = Properties.Resources.ModuleSim2;
            modSimToolStrip.Name = "modSimToolStrip";
            modSimToolStrip.Size = new System.Drawing.Size(393, 70);
            modSimToolStrip.Text = "Module Sim";
            modSimToolStrip.Click += modSimToolStrip_Click;
            // 
            // toolStripEthernet
            // 
            toolStripEthernet.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            toolStripEthernet.Image = Properties.Resources.EthernetSetup;
            toolStripEthernet.Name = "toolStripEthernet";
            toolStripEthernet.Size = new System.Drawing.Size(393, 70);
            toolStripEthernet.Text = "Linux Users";
            toolStripEthernet.Click += toolStripEthernet_Click;
            // 
            // deviceManagerToolStripMenuItem
            // 
            deviceManagerToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            deviceManagerToolStripMenuItem.Image = Properties.Resources.DeviceManager;
            deviceManagerToolStripMenuItem.Name = "deviceManagerToolStripMenuItem";
            deviceManagerToolStripMenuItem.Size = new System.Drawing.Size(393, 70);
            deviceManagerToolStripMenuItem.Text = "Device Manager";
            deviceManagerToolStripMenuItem.Click += deviceManagerToolStripMenuItem_Click;
            // 
            // isobusToolStripMenuItem
            // 
            isobusToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            isobusToolStripMenuItem.Image = Properties.Resources.Isobus;
            isobusToolStripMenuItem.Name = "isobusToolStripMenuItem";
            isobusToolStripMenuItem.Size = new System.Drawing.Size(393, 70);
            isobusToolStripMenuItem.Text = "ISOBUS";
            isobusToolStripMenuItem.Click += isobusToolStripMenuItem_Click;
            // 
            // settingsMenuStrip
            // 
            settingsMenuStrip.AutoSize = false;
            settingsMenuStrip.BackColor = System.Drawing.Color.Transparent;
            settingsMenuStrip.DisplayStyle = ToolStripItemDisplayStyle.Image;
            settingsMenuStrip.DropDownItems.AddRange(new ToolStripItem[] { saveToolStrip, loadToolStrip, serialPassThroughToolStripMenuItem });
            settingsMenuStrip.Image = Properties.Resources.NtripSettings;
            settingsMenuStrip.ImageScaling = ToolStripItemImageScaling.None;
            settingsMenuStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            settingsMenuStrip.Name = "settingsMenuStrip";
            settingsMenuStrip.ShowDropDownArrow = false;
            settingsMenuStrip.Size = new System.Drawing.Size(110, 68);
            // 
            // saveToolStrip
            // 
            saveToolStrip.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            saveToolStrip.Image = Properties.Resources.NTRIP_Client;
            saveToolStrip.Name = "saveToolStrip";
            saveToolStrip.Size = new System.Drawing.Size(336, 70);
            saveToolStrip.Text = "NTRIP";
            saveToolStrip.Click += btnNTRIP_Click;
            // 
            // loadToolStrip
            // 
            loadToolStrip.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            loadToolStrip.Image = Properties.Resources.RadioSettings;
            loadToolStrip.Name = "loadToolStrip";
            loadToolStrip.Size = new System.Drawing.Size(336, 70);
            loadToolStrip.Text = "Radio (Not XBee)";
            loadToolStrip.Click += btnRadio_Click;
            // 
            // serialPassThroughToolStripMenuItem
            // 
            serialPassThroughToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            serialPassThroughToolStripMenuItem.Image = Properties.Resources.NTRIP_Serial;
            serialPassThroughToolStripMenuItem.Name = "serialPassThroughToolStripMenuItem";
            serialPassThroughToolStripMenuItem.Size = new System.Drawing.Size(336, 70);
            serialPassThroughToolStripMenuItem.Text = "Serial Port";
            serialPassThroughToolStripMenuItem.Click += serialPassThroughToolStripMenuItem_Click;
            // 
            // lblSteerAngle
            // 
            lblSteerAngle.AutoSize = true;
            lblSteerAngle.BackColor = System.Drawing.Color.Transparent;
            lblSteerAngle.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblSteerAngle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lblSteerAngle.Location = new System.Drawing.Point(549, 124);
            lblSteerAngle.Margin = new Padding(4, 0, 4, 0);
            lblSteerAngle.Name = "lblSteerAngle";
            lblSteerAngle.Size = new System.Drawing.Size(40, 18);
            lblSteerAngle.TabIndex = 473;
            lblSteerAngle.Text = "UDP";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            label1.Location = new System.Drawing.Point(15, 387);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(77, 15);
            label1.TabIndex = 470;
            label1.Text = "Com Ports:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNTRIP_IP
            // 
            lblNTRIP_IP.BackColor = System.Drawing.Color.Transparent;
            lblNTRIP_IP.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblNTRIP_IP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lblNTRIP_IP.Location = new System.Drawing.Point(471, 45);
            lblNTRIP_IP.Margin = new Padding(4, 0, 4, 0);
            lblNTRIP_IP.Name = "lblNTRIP_IP";
            lblNTRIP_IP.Size = new System.Drawing.Size(133, 18);
            lblNTRIP_IP.TabIndex = 468;
            lblNTRIP_IP.Text = "--";
            lblNTRIP_IP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSerialPorts
            // 
            lblSerialPorts.AutoSize = true;
            lblSerialPorts.BackColor = System.Drawing.Color.Transparent;
            lblSerialPorts.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblSerialPorts.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            lblSerialPorts.Location = new System.Drawing.Point(90, 388);
            lblSerialPorts.Margin = new Padding(2, 0, 2, 0);
            lblSerialPorts.Name = "lblSerialPorts";
            lblSerialPorts.Size = new System.Drawing.Size(45, 14);
            lblSerialPorts.TabIndex = 467;
            lblSerialPorts.Text = "Com12";
            lblSerialPorts.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblMount
            // 
            lblMount.BackColor = System.Drawing.Color.Transparent;
            lblMount.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblMount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lblMount.Location = new System.Drawing.Point(471, 66);
            lblMount.Margin = new Padding(4, 0, 4, 0);
            lblMount.Name = "lblMount";
            lblMount.Size = new System.Drawing.Size(133, 18);
            lblMount.TabIndex = 465;
            lblMount.Text = "--";
            lblMount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIP
            // 
            lblIP.BackColor = System.Drawing.Color.Transparent;
            lblIP.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblIP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lblIP.Location = new System.Drawing.Point(10, 161);
            lblIP.Margin = new Padding(4, 0, 4, 0);
            lblIP.Name = "lblIP";
            lblIP.Size = new System.Drawing.Size(123, 137);
            lblIP.TabIndex = 464;
            lblIP.Text = "288.288.288.288";
            lblIP.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            lblIP.Click += lblIP_Click;
            // 
            // ntripMeterTimer
            // 
            ntripMeterTimer.Interval = 50;
            ntripMeterTimer.Tick += ntripMeterTimer_Tick;
            // 
            // lblMessages
            // 
            lblMessages.BackColor = System.Drawing.Color.Transparent;
            lblMessages.BorderStyle = BorderStyle.FixedSingle;
            lblMessages.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblMessages.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lblMessages.Location = new System.Drawing.Point(643, 97);
            lblMessages.Margin = new Padding(4, 0, 4, 0);
            lblMessages.Name = "lblMessages";
            lblMessages.Size = new System.Drawing.Size(88, 298);
            lblMessages.TabIndex = 474;
            lblMessages.Text = "1888 - 18";
            lblMessages.Click += lblMessages_Click;
            // 
            // lblWASCounts
            // 
            lblWASCounts.AutoSize = true;
            lblWASCounts.BackColor = System.Drawing.Color.Transparent;
            lblWASCounts.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblWASCounts.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lblWASCounts.Location = new System.Drawing.Point(549, 147);
            lblWASCounts.Margin = new Padding(4, 0, 4, 0);
            lblWASCounts.Name = "lblWASCounts";
            lblWASCounts.Size = new System.Drawing.Size(43, 18);
            lblWASCounts.TabIndex = 476;
            lblWASCounts.Text = "Only";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label3.Location = new System.Drawing.Point(496, 123);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(56, 19);
            label3.TabIndex = 477;
            label3.Text = "Angle:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.Transparent;
            label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label4.Location = new System.Drawing.Point(488, 146);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(64, 19);
            label4.TabIndex = 478;
            label4.Text = "Counts:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label2.Location = new System.Drawing.Point(488, 187);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(61, 19);
            label2.TabIndex = 481;
            label2.Text = "Switch:";
            // 
            // lblSwitchStatus
            // 
            lblSwitchStatus.AutoSize = true;
            lblSwitchStatus.BackColor = System.Drawing.Color.Transparent;
            lblSwitchStatus.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblSwitchStatus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lblSwitchStatus.Location = new System.Drawing.Point(549, 188);
            lblSwitchStatus.Margin = new Padding(4, 0, 4, 0);
            lblSwitchStatus.Name = "lblSwitchStatus";
            lblSwitchStatus.Size = new System.Drawing.Size(18, 18);
            lblSwitchStatus.TabIndex = 482;
            lblSwitchStatus.Text = "*";
            // 
            // lblWorkSwitchStatus
            // 
            lblWorkSwitchStatus.AutoSize = true;
            lblWorkSwitchStatus.BackColor = System.Drawing.Color.Transparent;
            lblWorkSwitchStatus.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblWorkSwitchStatus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lblWorkSwitchStatus.Location = new System.Drawing.Point(549, 211);
            lblWorkSwitchStatus.Margin = new Padding(4, 0, 4, 0);
            lblWorkSwitchStatus.Name = "lblWorkSwitchStatus";
            lblWorkSwitchStatus.Size = new System.Drawing.Size(18, 18);
            lblWorkSwitchStatus.TabIndex = 484;
            lblWorkSwitchStatus.Text = "*";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = System.Drawing.Color.Transparent;
            label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label9.Location = new System.Drawing.Point(497, 210);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(52, 19);
            label9.TabIndex = 483;
            label9.Text = "Work:";
            // 
            // btnStartStopNtrip
            // 
            btnStartStopNtrip.BackColor = System.Drawing.Color.LightGray;
            btnStartStopNtrip.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            btnStartStopNtrip.FlatStyle = FlatStyle.Flat;
            btnStartStopNtrip.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnStartStopNtrip.ForeColor = System.Drawing.Color.Black;
            btnStartStopNtrip.ImeMode = ImeMode.NoControl;
            btnStartStopNtrip.Location = new System.Drawing.Point(25, 121);
            btnStartStopNtrip.Margin = new Padding(4);
            btnStartStopNtrip.Name = "btnStartStopNtrip";
            btnStartStopNtrip.Size = new System.Drawing.Size(80, 27);
            btnStartStopNtrip.TabIndex = 147;
            btnStartStopNtrip.Text = "StartStop";
            btnStartStopNtrip.UseVisualStyleBackColor = false;
            btnStartStopNtrip.Click += btnStartStopNtrip_Click;
            // 
            // lblMessagesFound
            // 
            lblMessagesFound.AutoSize = true;
            lblMessagesFound.BackColor = System.Drawing.Color.Transparent;
            lblMessagesFound.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblMessagesFound.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lblMessagesFound.Location = new System.Drawing.Point(695, 75);
            lblMessagesFound.Margin = new Padding(4, 0, 4, 0);
            lblMessagesFound.Name = "lblMessagesFound";
            lblMessagesFound.Size = new System.Drawing.Size(18, 18);
            lblMessagesFound.TabIndex = 491;
            lblMessagesFound.Text = "0";
            lblMessagesFound.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.Transparent;
            label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label5.Location = new System.Drawing.Point(643, 69);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(53, 18);
            label5.TabIndex = 492;
            label5.Text = "Found:";
            // 
            // lbl1To8
            // 
            lbl1To8.AutoSize = true;
            lbl1To8.BackColor = System.Drawing.Color.Transparent;
            lbl1To8.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lbl1To8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lbl1To8.Location = new System.Drawing.Point(486, 262);
            lbl1To8.Margin = new Padding(4, 0, 4, 0);
            lbl1To8.Name = "lbl1To8";
            lbl1To8.Size = new System.Drawing.Size(106, 23);
            lbl1To8.TabIndex = 500;
            lbl1To8.Text = "00000000";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = System.Drawing.Color.Transparent;
            label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label10.Location = new System.Drawing.Point(486, 242);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(106, 19);
            label10.TabIndex = 499;
            label10.Text = "8     <<      1";
            // 
            // lbl9To16
            // 
            lbl9To16.AutoSize = true;
            lbl9To16.BackColor = System.Drawing.Color.Transparent;
            lbl9To16.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lbl9To16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lbl9To16.Location = new System.Drawing.Point(486, 314);
            lbl9To16.Margin = new Padding(4, 0, 4, 0);
            lbl9To16.Name = "lbl9To16";
            lbl9To16.Size = new System.Drawing.Size(106, 23);
            lbl9To16.TabIndex = 502;
            lbl9To16.Text = "00000000";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = System.Drawing.Color.Transparent;
            label12.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label12.Location = new System.Drawing.Point(486, 293);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(105, 19);
            label12.TabIndex = 501;
            label12.Text = "16    <<     9";
            // 
            // lblStationID
            // 
            lblStationID.AutoSize = true;
            lblStationID.BackColor = System.Drawing.Color.Transparent;
            lblStationID.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblStationID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lblStationID.Location = new System.Drawing.Point(671, 48);
            lblStationID.Margin = new Padding(4, 0, 4, 0);
            lblStationID.Name = "lblStationID";
            lblStationID.Size = new System.Drawing.Size(18, 18);
            lblStationID.TabIndex = 507;
            lblStationID.Text = "0";
            lblStationID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = System.Drawing.Color.Transparent;
            label13.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label13.Location = new System.Drawing.Point(642, 48);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(29, 18);
            label13.TabIndex = 508;
            label13.Text = "ID:";
            // 
            // lblCount
            // 
            lblCount.BackColor = System.Drawing.Color.Transparent;
            lblCount.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblCount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lblCount.Location = new System.Drawing.Point(504, 90);
            lblCount.Margin = new Padding(4, 0, 4, 0);
            lblCount.Name = "lblCount";
            lblCount.Size = new System.Drawing.Size(69, 18);
            lblCount.TabIndex = 510;
            lblCount.Text = "-";
            lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = System.Drawing.Color.Transparent;
            label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label7.Location = new System.Drawing.Point(489, 349);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(71, 16);
            label7.TabIndex = 511;
            label7.Text = "Steer Ping:";
            // 
            // lblToGPS
            // 
            lblToGPS.AutoSize = true;
            lblToGPS.BackColor = System.Drawing.Color.Transparent;
            lblToGPS.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblToGPS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lblToGPS.Location = new System.Drawing.Point(330, 246);
            lblToGPS.Margin = new Padding(2, 0, 2, 0);
            lblToGPS.Name = "lblToGPS";
            lblToGPS.Size = new System.Drawing.Size(26, 18);
            lblToGPS.TabIndex = 512;
            lblToGPS.Text = "---";
            lblToGPS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPing
            // 
            lblPing.AutoSize = true;
            lblPing.BackColor = System.Drawing.Color.Transparent;
            lblPing.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblPing.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lblPing.Location = new System.Drawing.Point(558, 349);
            lblPing.Margin = new Padding(4, 0, 4, 0);
            lblPing.Name = "lblPing";
            lblPing.Size = new System.Drawing.Size(35, 16);
            lblPing.TabIndex = 524;
            lblPing.Text = "2850";
            lblPing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPingMachine
            // 
            lblPingMachine.AutoSize = true;
            lblPingMachine.BackColor = System.Drawing.Color.Transparent;
            lblPingMachine.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblPingMachine.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lblPingMachine.Location = new System.Drawing.Point(558, 374);
            lblPingMachine.Margin = new Padding(4, 0, 4, 0);
            lblPingMachine.Name = "lblPingMachine";
            lblPingMachine.Size = new System.Drawing.Size(35, 16);
            lblPingMachine.TabIndex = 525;
            lblPingMachine.Text = "2850";
            lblPingMachine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = System.Drawing.Color.Transparent;
            label11.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label11.Location = new System.Drawing.Point(495, 374);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(65, 16);
            label11.TabIndex = 526;
            label11.Text = "Tool Ping:";
            // 
            // btnMinimizeMainForm
            // 
            btnMinimizeMainForm.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizeMainForm.BackColor = System.Drawing.Color.Transparent;
            btnMinimizeMainForm.BackgroundImageLayout = ImageLayout.Center;
            btnMinimizeMainForm.FlatAppearance.BorderSize = 0;
            btnMinimizeMainForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            btnMinimizeMainForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            btnMinimizeMainForm.FlatStyle = FlatStyle.Flat;
            btnMinimizeMainForm.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnMinimizeMainForm.ForeColor = System.Drawing.Color.DimGray;
            btnMinimizeMainForm.Image = Properties.Resources.WindowMinimize;
            btnMinimizeMainForm.ImeMode = ImeMode.NoControl;
            btnMinimizeMainForm.Location = new System.Drawing.Point(609, 4);
            btnMinimizeMainForm.Name = "btnMinimizeMainForm";
            btnMinimizeMainForm.Size = new System.Drawing.Size(62, 38);
            btnMinimizeMainForm.TabIndex = 529;
            btnMinimizeMainForm.UseVisualStyleBackColor = false;
            btnMinimizeMainForm.Click += btnMinimizeMainForm_Click;
            // 
            // btnGPS_Out
            // 
            btnGPS_Out.BackColor = System.Drawing.Color.Transparent;
            btnGPS_Out.BackgroundImageLayout = ImageLayout.Zoom;
            btnGPS_Out.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            btnGPS_Out.FlatAppearance.BorderSize = 0;
            btnGPS_Out.FlatStyle = FlatStyle.Flat;
            btnGPS_Out.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnGPS_Out.ForeColor = System.Drawing.Color.Black;
            btnGPS_Out.Image = Properties.Resources.GPS_Out;
            btnGPS_Out.ImeMode = ImeMode.NoControl;
            btnGPS_Out.Location = new System.Drawing.Point(474, 415);
            btnGPS_Out.Margin = new Padding(4);
            btnGPS_Out.Name = "btnGPS_Out";
            btnGPS_Out.Size = new System.Drawing.Size(89, 65);
            btnGPS_Out.TabIndex = 523;
            btnGPS_Out.UseVisualStyleBackColor = false;
            btnGPS_Out.Click += btnGPS_Out_Click;
            // 
            // cboxIsSteerModule
            // 
            cboxIsSteerModule.Appearance = Appearance.Button;
            cboxIsSteerModule.BackColor = System.Drawing.Color.Transparent;
            cboxIsSteerModule.BackgroundImage = Properties.Resources.AddNew;
            cboxIsSteerModule.BackgroundImageLayout = ImageLayout.Zoom;
            cboxIsSteerModule.Checked = true;
            cboxIsSteerModule.CheckState = CheckState.Checked;
            cboxIsSteerModule.FlatAppearance.BorderSize = 0;
            cboxIsSteerModule.FlatStyle = FlatStyle.Popup;
            cboxIsSteerModule.Location = new System.Drawing.Point(413, 170);
            cboxIsSteerModule.Name = "cboxIsSteerModule";
            cboxIsSteerModule.Size = new System.Drawing.Size(26, 27);
            cboxIsSteerModule.TabIndex = 498;
            cboxIsSteerModule.UseVisualStyleBackColor = false;
            cboxIsSteerModule.Click += cboxIsSteerModule_Click;
            // 
            // cboxIsIMUModule
            // 
            cboxIsIMUModule.Appearance = Appearance.Button;
            cboxIsIMUModule.BackColor = System.Drawing.Color.Transparent;
            cboxIsIMUModule.BackgroundImage = Properties.Resources.AddNew;
            cboxIsIMUModule.BackgroundImageLayout = ImageLayout.Zoom;
            cboxIsIMUModule.Checked = true;
            cboxIsIMUModule.CheckState = CheckState.Checked;
            cboxIsIMUModule.FlatAppearance.BorderSize = 0;
            cboxIsIMUModule.FlatStyle = FlatStyle.Popup;
            cboxIsIMUModule.Location = new System.Drawing.Point(413, 88);
            cboxIsIMUModule.Name = "cboxIsIMUModule";
            cboxIsIMUModule.Size = new System.Drawing.Size(26, 27);
            cboxIsIMUModule.TabIndex = 496;
            cboxIsIMUModule.UseVisualStyleBackColor = false;
            cboxIsIMUModule.Click += cboxIsIMUModule_Click;
            // 
            // cboxIsMachineModule
            // 
            cboxIsMachineModule.Appearance = Appearance.Button;
            cboxIsMachineModule.BackColor = System.Drawing.Color.Transparent;
            cboxIsMachineModule.BackgroundImage = Properties.Resources.AddNew;
            cboxIsMachineModule.BackgroundImageLayout = ImageLayout.Zoom;
            cboxIsMachineModule.Checked = true;
            cboxIsMachineModule.CheckState = CheckState.Checked;
            cboxIsMachineModule.FlatAppearance.BorderSize = 0;
            cboxIsMachineModule.FlatStyle = FlatStyle.Popup;
            cboxIsMachineModule.Location = new System.Drawing.Point(413, 343);
            cboxIsMachineModule.Name = "cboxIsMachineModule";
            cboxIsMachineModule.Size = new System.Drawing.Size(26, 27);
            cboxIsMachineModule.TabIndex = 495;
            cboxIsMachineModule.TextImageRelation = TextImageRelation.ImageAboveText;
            cboxIsMachineModule.UseVisualStyleBackColor = false;
            cboxIsMachineModule.Click += cboxIsMachineModule_Click;
            // 
            // btnIMU
            // 
            btnIMU.BackColor = System.Drawing.Color.Transparent;
            btnIMU.BackgroundImage = Properties.Resources.B_IMU;
            btnIMU.BackgroundImageLayout = ImageLayout.Zoom;
            btnIMU.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            btnIMU.FlatAppearance.BorderSize = 0;
            btnIMU.FlatStyle = FlatStyle.Flat;
            btnIMU.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnIMU.ForeColor = System.Drawing.Color.White;
            btnIMU.ImeMode = ImeMode.NoControl;
            btnIMU.Location = new System.Drawing.Point(238, 70);
            btnIMU.Margin = new Padding(4);
            btnIMU.Name = "btnIMU";
            btnIMU.Size = new System.Drawing.Size(84, 59);
            btnIMU.TabIndex = 185;
            btnIMU.UseVisualStyleBackColor = false;
            btnIMU.Click += btnBringUpCommSettings_Click;
            // 
            // btnSteer
            // 
            btnSteer.BackColor = System.Drawing.Color.Transparent;
            btnSteer.BackgroundImage = Properties.Resources.B_Autosteer;
            btnSteer.BackgroundImageLayout = ImageLayout.Zoom;
            btnSteer.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            btnSteer.FlatAppearance.BorderSize = 0;
            btnSteer.FlatStyle = FlatStyle.Flat;
            btnSteer.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnSteer.ForeColor = System.Drawing.Color.White;
            btnSteer.ImeMode = ImeMode.NoControl;
            btnSteer.Location = new System.Drawing.Point(238, 155);
            btnSteer.Margin = new Padding(4);
            btnSteer.Name = "btnSteer";
            btnSteer.Size = new System.Drawing.Size(84, 59);
            btnSteer.TabIndex = 189;
            btnSteer.UseVisualStyleBackColor = false;
            btnSteer.Click += btnBringUpCommSettings_Click;
            // 
            // btnMachine
            // 
            btnMachine.BackColor = System.Drawing.Color.Transparent;
            btnMachine.BackgroundImage = Properties.Resources.B_Machine;
            btnMachine.BackgroundImageLayout = ImageLayout.Zoom;
            btnMachine.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            btnMachine.FlatAppearance.BorderSize = 0;
            btnMachine.FlatStyle = FlatStyle.Flat;
            btnMachine.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnMachine.ForeColor = System.Drawing.Color.White;
            btnMachine.ImeMode = ImeMode.NoControl;
            btnMachine.Location = new System.Drawing.Point(238, 325);
            btnMachine.Margin = new Padding(4);
            btnMachine.Name = "btnMachine";
            btnMachine.Size = new System.Drawing.Size(84, 59);
            btnMachine.TabIndex = 188;
            btnMachine.UseVisualStyleBackColor = false;
            btnMachine.Click += btnBringUpCommSettings_Click;
            // 
            // btnGPS
            // 
            btnGPS.BackColor = System.Drawing.Color.Transparent;
            btnGPS.BackgroundImage = Properties.Resources.B_GPS;
            btnGPS.BackgroundImageLayout = ImageLayout.Zoom;
            btnGPS.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            btnGPS.FlatAppearance.BorderSize = 0;
            btnGPS.FlatStyle = FlatStyle.Flat;
            btnGPS.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnGPS.ForeColor = System.Drawing.Color.White;
            btnGPS.ImeMode = ImeMode.NoControl;
            btnGPS.Location = new System.Drawing.Point(238, 240);
            btnGPS.Margin = new Padding(4);
            btnGPS.Name = "btnGPS";
            btnGPS.Size = new System.Drawing.Size(84, 59);
            btnGPS.TabIndex = 187;
            btnGPS.UseVisualStyleBackColor = false;
            btnGPS.Click += btnBringUpCommSettings_Click;
            // 
            // btnSlide
            // 
            btnSlide.BackColor = System.Drawing.Color.Transparent;
            btnSlide.BackgroundImage = Properties.Resources.ArrowGrnRight;
            btnSlide.BackgroundImageLayout = ImageLayout.Zoom;
            btnSlide.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            btnSlide.FlatAppearance.BorderSize = 0;
            btnSlide.FlatStyle = FlatStyle.Flat;
            btnSlide.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnSlide.ForeColor = System.Drawing.Color.White;
            btnSlide.ImeMode = ImeMode.NoControl;
            btnSlide.Location = new System.Drawing.Point(326, 415);
            btnSlide.Margin = new Padding(4);
            btnSlide.Name = "btnSlide";
            btnSlide.Size = new System.Drawing.Size(89, 65);
            btnSlide.TabIndex = 475;
            btnSlide.UseVisualStyleBackColor = false;
            btnSlide.Click += btnSlide_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.Black;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = Properties.Resources.AgIO_First;
            pictureBox1.Location = new System.Drawing.Point(409, 387);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(42, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 182;
            pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.BackColor = System.Drawing.Color.Transparent;
            btnExit.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnExit.ForeColor = System.Drawing.Color.White;
            btnExit.Image = Properties.Resources.WindowClose;
            btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnExit.ImeMode = ImeMode.NoControl;
            btnExit.Location = new System.Drawing.Point(653, 4);
            btnExit.Margin = new Padding(4);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(80, 38);
            btnExit.TabIndex = 192;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnRunAOG
            // 
            btnRunAOG.BackColor = System.Drawing.Color.Transparent;
            btnRunAOG.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            btnRunAOG.FlatAppearance.BorderSize = 0;
            btnRunAOG.FlatStyle = FlatStyle.Flat;
            btnRunAOG.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnRunAOG.ForeColor = System.Drawing.Color.White;
            btnRunAOG.Image = Properties.Resources.AgIOBtn;
            btnRunAOG.ImeMode = ImeMode.NoControl;
            btnRunAOG.Location = new System.Drawing.Point(227, 415);
            btnRunAOG.Margin = new Padding(4);
            btnRunAOG.Name = "btnRunAOG";
            btnRunAOG.Size = new System.Drawing.Size(89, 65);
            btnRunAOG.TabIndex = 190;
            btnRunAOG.UseVisualStyleBackColor = false;
            btnRunAOG.Click += btnRunAOG_Click;
            // 
            // btnUDP
            // 
            btnUDP.BackColor = System.Drawing.Color.Gainsboro;
            btnUDP.BackgroundImage = Properties.Resources.B_UDP;
            btnUDP.BackgroundImageLayout = ImageLayout.Zoom;
            btnUDP.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            btnUDP.FlatAppearance.BorderSize = 0;
            btnUDP.FlatStyle = FlatStyle.Flat;
            btnUDP.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnUDP.ForeColor = System.Drawing.Color.White;
            btnUDP.ImeMode = ImeMode.NoControl;
            btnUDP.Location = new System.Drawing.Point(18, 300);
            btnUDP.Margin = new Padding(4);
            btnUDP.Name = "btnUDP";
            btnUDP.Size = new System.Drawing.Size(107, 73);
            btnUDP.TabIndex = 184;
            btnUDP.UseVisualStyleBackColor = false;
            btnUDP.Click += btnUDP_Click;
            // 
            // btnGPSData
            // 
            btnGPSData.BackColor = System.Drawing.Color.Transparent;
            btnGPSData.BackgroundImageLayout = ImageLayout.Zoom;
            btnGPSData.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            btnGPSData.FlatAppearance.BorderSize = 0;
            btnGPSData.FlatStyle = FlatStyle.Flat;
            btnGPSData.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnGPSData.ForeColor = System.Drawing.Color.Black;
            btnGPSData.Image = Properties.Resources.Nmea;
            btnGPSData.ImeMode = ImeMode.NoControl;
            btnGPSData.Location = new System.Drawing.Point(140, 4);
            btnGPSData.Margin = new Padding(4);
            btnGPSData.Name = "btnGPSData";
            btnGPSData.Size = new System.Drawing.Size(62, 38);
            btnGPSData.TabIndex = 513;
            btnGPSData.UseVisualStyleBackColor = false;
            btnGPSData.Click += btnGPSData_Click;
            // 
            // FormLoop
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Gainsboro;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new System.Drawing.Size(734, 486);
            ControlBox = false;
            Controls.Add(btnMinimizeMainForm);
            Controls.Add(label11);
            Controls.Add(lblPingMachine);
            Controls.Add(lblPing);
            Controls.Add(btnGPS_Out);
            Controls.Add(label7);
            Controls.Add(lblCount);
            Controls.Add(lblStationID);
            Controls.Add(label13);
            Controls.Add(lbl9To16);
            Controls.Add(lbl1To8);
            Controls.Add(label10);
            Controls.Add(btnStartStopNtrip);
            Controls.Add(cboxIsSteerModule);
            Controls.Add(lblWatch);
            Controls.Add(cboxIsIMUModule);
            Controls.Add(lblNTRIPBytes);
            Controls.Add(cboxIsMachineModule);
            Controls.Add(lblMount);
            Controls.Add(label1);
            Controls.Add(lblNTRIP_IP);
            Controls.Add(lblSerialPorts);
            Controls.Add(btnIMU);
            Controls.Add(btnSteer);
            Controls.Add(btnMachine);
            Controls.Add(btnGPS);
            Controls.Add(lblMessagesFound);
            Controls.Add(lblWorkSwitchStatus);
            Controls.Add(label9);
            Controls.Add(lblSwitchStatus);
            Controls.Add(label2);
            Controls.Add(lblWASCounts);
            Controls.Add(lblSteerAngle);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnSlide);
            Controls.Add(pictureBox1);
            Controls.Add(label8);
            Controls.Add(lblGPS1Comm);
            Controls.Add(lblMod2Comm);
            Controls.Add(lblMod1Comm);
            Controls.Add(label6);
            Controls.Add(lblIMUComm);
            Controls.Add(lblMessages);
            Controls.Add(label5);
            Controls.Add(btnExit);
            Controls.Add(btnRunAOG);
            Controls.Add(statusStrip1);
            Controls.Add(label12);
            Controls.Add(lblCurentLon);
            Controls.Add(lblCurrentLat);
            Controls.Add(btnUDP);
            Controls.Add(lblIP);
            Controls.Add(lblToGPS);
            Controls.Add(lblFromGPS);
            Controls.Add(btnGPSData);
            Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimumSize = new System.Drawing.Size(50, 50);
            Name = "FormLoop";
            Padding = new Padding(4);
            Text = "AgIO";
            FormClosing += FormLoop_FormClosing;
            Load += FormLoop_Load;
            Resize += FormLoop_Resize;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer oneSecondLoopTimer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCurentLon;
        private System.Windows.Forms.Label lblCurrentLat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblWatch;
        private System.Windows.Forms.Button btnStartStopNtrip;
        private System.Windows.Forms.Label lblNTRIPBytes;
        private System.Windows.Forms.Label lblMod2Comm;
        private System.Windows.Forms.Label lblMod1Comm;
        private System.Windows.Forms.Label lblIMUComm;
        private System.Windows.Forms.Label lblFromGPS;
        private System.Windows.Forms.Label lblGPS1Comm;
        private System.Windows.Forms.ToolStripDropDownButton settingsMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem saveToolStrip;
        private System.Windows.Forms.ToolStripMenuItem loadToolStrip;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button btnUDP;
        private System.Windows.Forms.Button btnRunAOG;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Timer ntripMeterTimer;
        private System.Windows.Forms.Label lblMount;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.Label lblSerialPorts;
        private System.Windows.Forms.Label lblNTRIP_IP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSteerAngle;
        private System.Windows.Forms.Label lblMessages;
        private System.Windows.Forms.Button btnSlide;
        private System.Windows.Forms.Label lblWASCounts;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSwitchStatus;
        private System.Windows.Forms.Label lblWorkSwitchStatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblMessagesFound;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cboxIsMachineModule;
        private System.Windows.Forms.CheckBox cboxIsIMUModule;
        private System.Windows.Forms.CheckBox cboxIsSteerModule;
        private System.Windows.Forms.Label lbl1To8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl9To16;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblStationID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ToolStripMenuItem serialPassThroughToolStripMenuItem;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblToGPS;
        private System.Windows.Forms.Button btnGPSData;
        public System.Windows.Forms.Button btnIMU;
        public System.Windows.Forms.Button btnGPS;
        public System.Windows.Forms.Button btnMachine;
        public System.Windows.Forms.Button btnSteer;
        private System.Windows.Forms.ToolStripMenuItem toolStripEthernet;
        private System.Windows.Forms.ToolStripMenuItem toolStripSerialMonitor;
        private System.Windows.Forms.ToolStripMenuItem toolStripUDPMonitor;
        private System.Windows.Forms.Button btnGPS_Out;
        private System.Windows.Forms.Label lblPing;
        private System.Windows.Forms.Label lblPingMachine;
        private System.Windows.Forms.Label label11;
        private Button btnMinimizeMainForm;
        private ToolStripMenuItem modSimToolStrip;
        private ToolStripMenuItem toolStripLogViewer;
        private ToolStripMenuItem toolStripAgDiag;
        private ToolStripMenuItem toolStripSettings;
        private ToolStripMenuItem deviceManagerToolStripMenuItem;
    }
}


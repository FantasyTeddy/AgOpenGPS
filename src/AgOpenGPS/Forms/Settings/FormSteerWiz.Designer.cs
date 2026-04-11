namespace AgOpenGPS
{
    partial class FormSteerWiz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSteerWiz));
            timer1 = new System.Windows.Forms.Timer(components);
            lblSteerAngle = new System.Windows.Forms.Label();
            lblSteerAngleActual = new System.Windows.Forms.Label();
            lblError = new System.Windows.Forms.Label();
            lblPWMDisplay = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            lblCalcSteerAngleInner = new System.Windows.Forms.Label();
            lblDiameter = new System.Windows.Forms.Label();
            pbarSensor = new System.Windows.Forms.ProgressBar();
            lblPercentFS = new System.Windows.Forms.Label();
            tabControl1 = new System.Windows.Forms.TabControl();
            tabSteer = new System.Windows.Forms.TabPage();
            hsbarLowSteerPWM = new System.Windows.Forms.HScrollBar();
            label6 = new System.Windows.Forms.Label();
            lblLowSteerPWM = new System.Windows.Forms.Label();
            tabGain = new System.Windows.Forms.TabPage();
            tabStan = new System.Windows.Forms.TabPage();
            lblIntegralPercent = new System.Windows.Forms.Label();
            hsbarIntegral = new System.Windows.Forms.HScrollBar();
            label27 = new System.Windows.Forms.Label();
            label25 = new System.Windows.Forms.Label();
            lblHeadingErrorGain = new System.Windows.Forms.Label();
            lblStanleyGain = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            hsbarStanleyGain = new System.Windows.Forms.HScrollBar();
            hsbarHeadingErrorGain = new System.Windows.Forms.HScrollBar();
            tabInt = new System.Windows.Forms.TabPage();
            lblSideHillComp = new System.Windows.Forms.Label();
            hsbarSideHillComp = new System.Windows.Forms.HScrollBar();
            label22 = new System.Windows.Forms.Label();
            lblPureIntegral = new System.Windows.Forms.Label();
            hsbarIntegralPurePursuit = new System.Windows.Forms.HScrollBar();
            label26 = new System.Windows.Forms.Label();
            label24 = new System.Windows.Forms.Label();
            label21 = new System.Windows.Forms.Label();
            label20 = new System.Windows.Forms.Label();
            label19 = new System.Windows.Forms.Label();
            label18 = new System.Windows.Forms.Label();
            hsbarLookAheadMult = new System.Windows.Forms.HScrollBar();
            lblLookAhead = new System.Windows.Forms.Label();
            lblLookAheadMult = new System.Windows.Forms.Label();
            imageList1 = new System.Windows.Forms.ImageList(components);
            label15 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            hsbarMinPWM = new System.Windows.Forms.HScrollBar();
            hsbarProportionalGain = new System.Windows.Forms.HScrollBar();
            lblProportionalGain = new System.Windows.Forms.Label();
            lblHighSteerPWM = new System.Windows.Forms.Label();
            lblMinPWM = new System.Windows.Forms.Label();
            hsbarHighSteerPWM = new System.Windows.Forms.HScrollBar();
            lblMaxSteerAngle = new System.Windows.Forms.Label();
            hsbarMaxSteerAngle = new System.Windows.Forms.HScrollBar();
            label7 = new System.Windows.Forms.Label();
            hsbarCountsPerDegree = new System.Windows.Forms.HScrollBar();
            label10 = new System.Windows.Forms.Label();
            lblCountsPerDegree = new System.Windows.Forms.Label();
            hsbarWasOffset = new System.Windows.Forms.HScrollBar();
            lblSteerAngleSensorZero = new System.Windows.Forms.Label();
            pbarRight = new System.Windows.Forms.ProgressBar();
            pbarLeft = new System.Windows.Forms.ProgressBar();
            label28 = new System.Windows.Forms.Label();
            labelPressureTurnSensor = new System.Windows.Forms.Label();
            labelCurrentTurnSensor = new System.Windows.Forms.Label();
            labelEncoder = new System.Windows.Forms.Label();
            label70 = new System.Windows.Forms.Label();
            label29 = new System.Windows.Forms.Label();
            cboxMotorDrive = new System.Windows.Forms.ComboBox();
            cboxSteerEnable = new System.Windows.Forms.ComboBox();
            label62 = new System.Windows.Forms.Label();
            cboxConv = new System.Windows.Forms.ComboBox();
            label63 = new System.Windows.Forms.Label();
            label64 = new System.Windows.Forms.Label();
            label61 = new System.Windows.Forms.Label();
            nudMaxCounts = new NudlessNumericUpDown();
            label55 = new System.Windows.Forms.Label();
            label30 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            btnSteerStatus = new System.Windows.Forms.Button();
            label35 = new System.Windows.Forms.Label();
            label34 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            label38 = new System.Windows.Forms.Label();
            btnFreeDriveZero = new System.Windows.Forms.Button();
            btnSteerAngleUp = new AgLibrary.Controls.RepeatButton();
            btnFreeDrive = new System.Windows.Forms.Button();
            btnSteerAngleDown = new AgLibrary.Controls.RepeatButton();
            hsbarSensor = new System.Windows.Forms.HScrollBar();
            lblhsbarSensor = new System.Windows.Forms.Label();
            tabWiz = new System.Windows.Forms.TabControl();
            tabStart = new System.Windows.Forms.TabPage();
            btnStartWizard = new System.Windows.Forms.Button();
            tabLoadDef = new System.Windows.Forms.TabPage();
            label81 = new System.Windows.Forms.Label();
            label80 = new System.Windows.Forms.Label();
            btnOkNext_LoadDefault = new System.Windows.Forms.Button();
            btnLoadDefaults = new System.Windows.Forms.Button();
            tabWheelBase = new System.Windows.Forms.TabPage();
            label117 = new System.Windows.Forms.Label();
            label89 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            label90 = new System.Windows.Forms.Label();
            nudWheelbase = new NudlessNumericUpDown();
            label91 = new System.Windows.Forms.Label();
            button2 = new System.Windows.Forms.Button();
            tabWheelTrack = new System.Windows.Forms.TabPage();
            label118 = new System.Windows.Forms.Label();
            nudVehicleTrack = new NudlessNumericUpDown();
            label95 = new System.Windows.Forms.Label();
            label96 = new System.Windows.Forms.Label();
            button7 = new System.Windows.Forms.Button();
            label94 = new System.Windows.Forms.Label();
            button8 = new System.Windows.Forms.Button();
            tabAntennaDistance = new System.Windows.Forms.TabPage();
            label100 = new System.Windows.Forms.Label();
            button9 = new System.Windows.Forms.Button();
            label98 = new System.Windows.Forms.Label();
            nudAntennaPivot = new NudlessNumericUpDown();
            button10 = new System.Windows.Forms.Button();
            label99 = new System.Windows.Forms.Label();
            tabAntennaHeight = new System.Windows.Forms.TabPage();
            label114 = new System.Windows.Forms.Label();
            label97 = new System.Windows.Forms.Label();
            button13 = new System.Windows.Forms.Button();
            label92 = new System.Windows.Forms.Label();
            nudAntennaHeight = new NudlessNumericUpDown();
            label93 = new System.Windows.Forms.Label();
            button14 = new System.Windows.Forms.Button();
            tabAntennaOffset = new System.Windows.Forms.TabPage();
            button11 = new System.Windows.Forms.Button();
            label102 = new System.Windows.Forms.Label();
            nudAntennaOffset = new NudlessNumericUpDown();
            label104 = new System.Windows.Forms.Label();
            button12 = new System.Windows.Forms.Button();
            label103 = new System.Windows.Forms.Label();
            tabButtonSwitch = new System.Windows.Forms.TabPage();
            button15 = new System.Windows.Forms.Button();
            label53 = new System.Windows.Forms.Label();
            btnOkNext_ButtonSwitch = new System.Windows.Forms.Button();
            tabA2DConv = new System.Windows.Forms.TabPage();
            btnPrev_A2D = new System.Windows.Forms.Button();
            label52 = new System.Windows.Forms.Label();
            btnOkNext_A2D = new System.Windows.Forms.Button();
            tabMotorDriver = new System.Windows.Forms.TabPage();
            btnPrev_MotorDriver = new System.Windows.Forms.Button();
            label43 = new System.Windows.Forms.Label();
            btnOkNext_MotorDriver = new System.Windows.Forms.Button();
            tabInvertRelays = new System.Windows.Forms.TabPage();
            label59 = new System.Windows.Forms.Label();
            btnPrev_InvertRelays = new System.Windows.Forms.Button();
            label51 = new System.Windows.Forms.Label();
            btnOkNext_InvertRelays = new System.Windows.Forms.Button();
            chkSteerInvertRelays = new System.Windows.Forms.CheckBox();
            tabDanfoss = new System.Windows.Forms.TabPage();
            btnPrev_Danfoss = new System.Windows.Forms.Button();
            label50 = new System.Windows.Forms.Label();
            btnOkNext_Danfoss = new System.Windows.Forms.Button();
            cboxDanfoss = new System.Windows.Forms.CheckBox();
            tabRollInv = new System.Windows.Forms.TabPage();
            label115 = new System.Windows.Forms.Label();
            lblRoll = new System.Windows.Forms.Label();
            pictureBox9 = new System.Windows.Forms.PictureBox();
            cboxDataInvertRoll = new System.Windows.Forms.CheckBox();
            label36 = new System.Windows.Forms.Label();
            button4 = new System.Windows.Forms.Button();
            label46 = new System.Windows.Forms.Label();
            button18 = new System.Windows.Forms.Button();
            label107 = new System.Windows.Forms.Label();
            tabRollZero = new System.Windows.Forms.TabPage();
            lblRoll2 = new System.Windows.Forms.Label();
            label110 = new System.Windows.Forms.Label();
            label47 = new System.Windows.Forms.Label();
            label57 = new System.Windows.Forms.Label();
            lblRollZeroOffset = new System.Windows.Forms.Label();
            btnZeroRoll = new System.Windows.Forms.Button();
            btnRemoveZeroOffset = new System.Windows.Forms.Button();
            label48 = new System.Windows.Forms.Label();
            button3 = new System.Windows.Forms.Button();
            label56 = new System.Windows.Forms.Label();
            button19 = new System.Windows.Forms.Button();
            tabWAS = new System.Windows.Forms.TabPage();
            label45 = new System.Windows.Forms.Label();
            btnPrev_InvertWAS = new System.Windows.Forms.Button();
            label42 = new System.Windows.Forms.Label();
            btnOkWAS = new System.Windows.Forms.Button();
            chkInvertWAS = new System.Windows.Forms.CheckBox();
            tabWAS_Zero = new System.Windows.Forms.TabPage();
            label112 = new System.Windows.Forms.Label();
            lblCurrentHeading = new System.Windows.Forms.Label();
            label37 = new System.Windows.Forms.Label();
            button6 = new System.Windows.Forms.Button();
            btnRemoveWasOffset = new System.Windows.Forms.Button();
            label40 = new System.Windows.Forms.Label();
            btnOkNext_WAS_Zero = new System.Windows.Forms.Button();
            btnZeroWAS = new System.Windows.Forms.Button();
            tabMotorDirection = new System.Windows.Forms.TabPage();
            label58 = new System.Windows.Forms.Label();
            label41 = new System.Windows.Forms.Label();
            label17 = new System.Windows.Forms.Label();
            label33 = new System.Windows.Forms.Label();
            btnPrev_MotorDirection = new System.Windows.Forms.Button();
            btnOkNext_MotorDirection = new System.Windows.Forms.Button();
            btnSteerLeft = new System.Windows.Forms.Button();
            btnSteerRight = new System.Windows.Forms.Button();
            chkInvertSteer = new System.Windows.Forms.CheckBox();
            tabCPD_Setup = new System.Windows.Forms.TabPage();
            label60 = new System.Windows.Forms.Label();
            btnPrev_CountsPerDegree = new System.Windows.Forms.Button();
            label74 = new System.Windows.Forms.Label();
            label75 = new System.Windows.Forms.Label();
            btnSkipCPD_Setup = new System.Windows.Forms.Button();
            btnOKNext_CPDSetup = new System.Windows.Forms.Button();
            tabCountsPerDeg = new System.Windows.Forms.TabPage();
            label109 = new System.Windows.Forms.Label();
            lblRightStartAngle = new System.Windows.Forms.Label();
            button5 = new System.Windows.Forms.Button();
            lblCPDError = new System.Windows.Forms.Label();
            label39 = new System.Windows.Forms.Label();
            btnOkNext_CountsPerDeg = new System.Windows.Forms.Button();
            btnStartSA = new System.Windows.Forms.Button();
            tabAckCPD = new System.Windows.Forms.TabPage();
            btnAckReset = new System.Windows.Forms.Button();
            label101 = new System.Windows.Forms.Label();
            lblStartAngleLeft = new System.Windows.Forms.Label();
            label32 = new System.Windows.Forms.Label();
            hsbarAckerman = new System.Windows.Forms.HScrollBar();
            lblAckerman = new System.Windows.Forms.Label();
            button16 = new System.Windows.Forms.Button();
            lblAckermannError = new System.Windows.Forms.Label();
            label105 = new System.Windows.Forms.Label();
            label106 = new System.Windows.Forms.Label();
            label108 = new System.Windows.Forms.Label();
            lblDiameterLeft = new System.Windows.Forms.Label();
            lblCalcSteerAngleLeft = new System.Windows.Forms.Label();
            label111 = new System.Windows.Forms.Label();
            button17 = new System.Windows.Forms.Button();
            btnStartSA_Left = new System.Windows.Forms.Button();
            tabMaxSteerAngle = new System.Windows.Forms.TabPage();
            label113 = new System.Windows.Forms.Label();
            btnOkSetMaximumSteerAngle = new System.Windows.Forms.Button();
            label73 = new System.Windows.Forms.Label();
            btnPrev_MaxSteerAngle = new System.Windows.Forms.Button();
            label49 = new System.Windows.Forms.Label();
            label23 = new System.Windows.Forms.Label();
            btnOkNextMaxSteerAngle = new System.Windows.Forms.Button();
            tabCancelGuidance = new System.Windows.Forms.TabPage();
            btnPrev_CancelGuidance = new System.Windows.Forms.Button();
            btnOkNextCancelGuidance = new System.Windows.Forms.Button();
            label44 = new System.Windows.Forms.Label();
            cboxPressureSensor = new System.Windows.Forms.CheckBox();
            cboxEncoder = new System.Windows.Forms.CheckBox();
            cboxCurrentSensor = new System.Windows.Forms.CheckBox();
            tabPanicStop = new System.Windows.Forms.TabPage();
            btnPrev_Panic = new System.Windows.Forms.Button();
            label54 = new System.Windows.Forms.Label();
            btnOkNext_PanicStop = new System.Windows.Forms.Button();
            tab_MinimumGain = new System.Windows.Forms.TabPage();
            label72 = new System.Windows.Forms.Label();
            label79 = new System.Windows.Forms.Label();
            label78 = new System.Windows.Forms.Label();
            btnMinGainLeft = new System.Windows.Forms.Button();
            btnZeroMinMovementSetting = new System.Windows.Forms.Button();
            label77 = new System.Windows.Forms.Label();
            label76 = new System.Windows.Forms.Label();
            btnMinGainRight = new System.Windows.Forms.Button();
            label68 = new System.Windows.Forms.Label();
            btnPrev_Gain = new System.Windows.Forms.Button();
            btnOK_Next = new System.Windows.Forms.Button();
            tabPGain = new System.Windows.Forms.TabPage();
            label88 = new System.Windows.Forms.Label();
            label83 = new System.Windows.Forms.Label();
            label84 = new System.Windows.Forms.Label();
            btnLeftPGain = new System.Windows.Forms.Button();
            btnZeroPGain = new System.Windows.Forms.Button();
            label85 = new System.Windows.Forms.Label();
            label86 = new System.Windows.Forms.Label();
            btnRightPGain = new System.Windows.Forms.Button();
            label87 = new System.Windows.Forms.Label();
            btnPrev_PGain = new System.Windows.Forms.Button();
            btnNext_PGain = new System.Windows.Forms.Button();
            tabEnd = new System.Windows.Forms.TabPage();
            label116 = new System.Windows.Forms.Label();
            btnRestartWizard = new System.Windows.Forms.Button();
            label69 = new System.Windows.Forms.Label();
            btnPrev_End = new System.Windows.Forms.Button();
            btnExit = new System.Windows.Forms.Button();
            btnStopWizard = new System.Windows.Forms.Button();
            panel3 = new System.Windows.Forms.Panel();
            pbarProgress = new System.Windows.Forms.ProgressBar();
            label71 = new System.Windows.Forms.Label();
            lblBarCPD = new System.Windows.Forms.Label();
            label66 = new System.Windows.Forms.Label();
            label65 = new System.Windows.Forms.Label();
            lblBarAck = new System.Windows.Forms.Label();
            sideBarTimer = new System.Windows.Forms.Timer(components);
            label67 = new System.Windows.Forms.Label();
            lblBarWasOffset = new System.Windows.Forms.Label();
            btnCloseAll = new System.Windows.Forms.Button();
            tabControl1.SuspendLayout();
            tabSteer.SuspendLayout();
            tabStan.SuspendLayout();
            tabInt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudMaxCounts).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            tabWiz.SuspendLayout();
            tabStart.SuspendLayout();
            tabLoadDef.SuspendLayout();
            tabWheelBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudWheelbase).BeginInit();
            tabWheelTrack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudVehicleTrack).BeginInit();
            tabAntennaDistance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudAntennaPivot).BeginInit();
            tabAntennaHeight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudAntennaHeight).BeginInit();
            tabAntennaOffset.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudAntennaOffset).BeginInit();
            tabButtonSwitch.SuspendLayout();
            tabA2DConv.SuspendLayout();
            tabMotorDriver.SuspendLayout();
            tabInvertRelays.SuspendLayout();
            tabDanfoss.SuspendLayout();
            tabRollInv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            tabRollZero.SuspendLayout();
            tabWAS.SuspendLayout();
            tabWAS_Zero.SuspendLayout();
            tabMotorDirection.SuspendLayout();
            tabCPD_Setup.SuspendLayout();
            tabCountsPerDeg.SuspendLayout();
            tabAckCPD.SuspendLayout();
            tabMaxSteerAngle.SuspendLayout();
            tabCancelGuidance.SuspendLayout();
            tabPanicStop.SuspendLayout();
            tab_MinimumGain.SuspendLayout();
            tabPGain.SuspendLayout();
            tabEnd.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 250;
            timer1.Tick += Timer1_Tick;
            // 
            // lblSteerAngle
            // 
            lblSteerAngle.BackColor = System.Drawing.Color.Transparent;
            lblSteerAngle.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblSteerAngle.ForeColor = System.Drawing.Color.Black;
            lblSteerAngle.Location = new System.Drawing.Point(278, 4);
            lblSteerAngle.Name = "lblSteerAngle";
            lblSteerAngle.Size = new System.Drawing.Size(100, 31);
            lblSteerAngle.TabIndex = 306;
            lblSteerAngle.Text = "-55.5";
            lblSteerAngle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSteerAngleActual
            // 
            lblSteerAngleActual.BackColor = System.Drawing.Color.Transparent;
            lblSteerAngleActual.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblSteerAngleActual.ForeColor = System.Drawing.Color.Black;
            lblSteerAngleActual.Location = new System.Drawing.Point(484, 4);
            lblSteerAngleActual.Name = "lblSteerAngleActual";
            lblSteerAngleActual.Size = new System.Drawing.Size(100, 31);
            lblSteerAngleActual.TabIndex = 311;
            lblSteerAngleActual.Text = "-55.5";
            lblSteerAngleActual.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblError
            // 
            lblError.BackColor = System.Drawing.Color.Transparent;
            lblError.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblError.ForeColor = System.Drawing.Color.Black;
            lblError.Location = new System.Drawing.Point(352, 84);
            lblError.Name = "lblError";
            lblError.Size = new System.Drawing.Size(101, 31);
            lblError.TabIndex = 312;
            lblError.Text = "-30.0";
            lblError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPWMDisplay
            // 
            lblPWMDisplay.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblPWMDisplay.BackColor = System.Drawing.Color.White;
            lblPWMDisplay.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblPWMDisplay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lblPWMDisplay.Location = new System.Drawing.Point(607, 96);
            lblPWMDisplay.Name = "lblPWMDisplay";
            lblPWMDisplay.Size = new System.Drawing.Size(46, 23);
            lblPWMDisplay.TabIndex = 316;
            lblPWMDisplay.Text = "255";
            lblPWMDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            label9.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label9.BackColor = System.Drawing.Color.White;
            label9.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label9.Location = new System.Drawing.Point(547, 95);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(64, 23);
            label9.TabIndex = 318;
            label9.Text = "PWM:";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            label11.BackColor = System.Drawing.Color.Transparent;
            label11.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label11.ForeColor = System.Drawing.Color.Black;
            label11.Location = new System.Drawing.Point(411, 4);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(81, 33);
            label11.TabIndex = 319;
            label11.Text = "WAS:";
            label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            label12.BackColor = System.Drawing.Color.Transparent;
            label12.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label12.ForeColor = System.Drawing.Color.Black;
            label12.Location = new System.Drawing.Point(217, 2);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(68, 33);
            label12.TabIndex = 320;
            label12.Text = "Set:";
            label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            label13.BackColor = System.Drawing.Color.Transparent;
            label13.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label13.ForeColor = System.Drawing.Color.Black;
            label13.Location = new System.Drawing.Point(286, 84);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(75, 33);
            label13.TabIndex = 321;
            label13.Text = "Error:";
            label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = System.Drawing.Color.Transparent;
            label14.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label14.Location = new System.Drawing.Point(355, 71);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(45, 16);
            label14.TabIndex = 322;
            label14.Text = "Or +5";
            label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label8.AutoSize = true;
            label8.BackColor = System.Drawing.Color.Transparent;
            label8.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label8.Location = new System.Drawing.Point(296, 157);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(128, 25);
            label8.TabIndex = 328;
            label8.Text = "Steer Angle:";
            label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label1.Location = new System.Drawing.Point(320, 189);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(104, 25);
            label1.TabIndex = 327;
            label1.Text = "Diameter:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCalcSteerAngleInner
            // 
            lblCalcSteerAngleInner.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblCalcSteerAngleInner.AutoSize = true;
            lblCalcSteerAngleInner.BackColor = System.Drawing.Color.Transparent;
            lblCalcSteerAngleInner.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblCalcSteerAngleInner.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lblCalcSteerAngleInner.Location = new System.Drawing.Point(419, 158);
            lblCalcSteerAngleInner.Name = "lblCalcSteerAngleInner";
            lblCalcSteerAngleInner.Size = new System.Drawing.Size(45, 25);
            lblCalcSteerAngleInner.TabIndex = 326;
            lblCalcSteerAngleInner.Text = "0.0";
            lblCalcSteerAngleInner.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDiameter
            // 
            lblDiameter.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblDiameter.AutoSize = true;
            lblDiameter.BackColor = System.Drawing.Color.Transparent;
            lblDiameter.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblDiameter.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lblDiameter.Location = new System.Drawing.Point(419, 190);
            lblDiameter.Name = "lblDiameter";
            lblDiameter.Size = new System.Drawing.Size(71, 25);
            lblDiameter.TabIndex = 325;
            lblDiameter.Text = "0.0 m";
            lblDiameter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbarSensor
            // 
            pbarSensor.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            pbarSensor.Location = new System.Drawing.Point(37, 295);
            pbarSensor.Maximum = 255;
            pbarSensor.Name = "pbarSensor";
            pbarSensor.Size = new System.Drawing.Size(280, 26);
            pbarSensor.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            pbarSensor.TabIndex = 496;
            // 
            // lblPercentFS
            // 
            lblPercentFS.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblPercentFS.AutoSize = true;
            lblPercentFS.BackColor = System.Drawing.Color.Transparent;
            lblPercentFS.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblPercentFS.ForeColor = System.Drawing.Color.Black;
            lblPercentFS.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            lblPercentFS.Location = new System.Drawing.Point(336, 295);
            lblPercentFS.Name = "lblPercentFS";
            lblPercentFS.Size = new System.Drawing.Size(57, 29);
            lblPercentFS.TabIndex = 495;
            lblPercentFS.Text = "0%";
            lblPercentFS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            tabControl1.Controls.Add(tabSteer);
            tabControl1.Controls.Add(tabGain);
            tabControl1.Controls.Add(tabStan);
            tabControl1.Controls.Add(tabInt);
            tabControl1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tabControl1.ImageList = imageList1;
            tabControl1.ItemSize = new System.Drawing.Size(86, 48);
            tabControl1.Location = new System.Drawing.Point(988, 204);
            tabControl1.Margin = new System.Windows.Forms.Padding(4);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(356, 379);
            tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            tabControl1.TabIndex = 347;
            // 
            // tabSteer
            // 
            tabSteer.AutoScroll = true;
            tabSteer.BackColor = System.Drawing.Color.Gainsboro;
            tabSteer.BackgroundImage = Properties.Resources.Sf_SteerTab;
            tabSteer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            tabSteer.Controls.Add(hsbarLowSteerPWM);
            tabSteer.Controls.Add(label6);
            tabSteer.Controls.Add(lblLowSteerPWM);
            tabSteer.ImageIndex = 0;
            tabSteer.Location = new System.Drawing.Point(4, 52);
            tabSteer.Name = "tabSteer";
            tabSteer.Size = new System.Drawing.Size(348, 323);
            tabSteer.TabIndex = 5;
            // 
            // hsbarLowSteerPWM
            // 
            hsbarLowSteerPWM.LargeChange = 1;
            hsbarLowSteerPWM.Location = new System.Drawing.Point(65, 225);
            hsbarLowSteerPWM.Maximum = 255;
            hsbarLowSteerPWM.Name = "hsbarLowSteerPWM";
            hsbarLowSteerPWM.Size = new System.Drawing.Size(195, 30);
            hsbarLowSteerPWM.TabIndex = 269;
            hsbarLowSteerPWM.Value = 1;
            hsbarLowSteerPWM.ValueChanged += hsbarLowSteerPWM_ValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label6.ForeColor = System.Drawing.Color.Black;
            label6.Location = new System.Drawing.Point(196, 203);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(38, 19);
            label6.TabIndex = 337;
            label6.Text = "Low";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLowSteerPWM
            // 
            lblLowSteerPWM.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblLowSteerPWM.ForeColor = System.Drawing.Color.Black;
            lblLowSteerPWM.Location = new System.Drawing.Point(5, 223);
            lblLowSteerPWM.Name = "lblLowSteerPWM";
            lblLowSteerPWM.Size = new System.Drawing.Size(61, 35);
            lblLowSteerPWM.TabIndex = 273;
            lblLowSteerPWM.Text = "888";
            lblLowSteerPWM.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabGain
            // 
            tabGain.AutoScroll = true;
            tabGain.BackColor = System.Drawing.Color.Gainsboro;
            tabGain.BackgroundImage = Properties.Resources.Sf_GainTab;
            tabGain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            tabGain.ImageIndex = 1;
            tabGain.Location = new System.Drawing.Point(4, 52);
            tabGain.Name = "tabGain";
            tabGain.Size = new System.Drawing.Size(348, 323);
            tabGain.TabIndex = 13;
            // 
            // tabStan
            // 
            tabStan.BackColor = System.Drawing.Color.Gainsboro;
            tabStan.BackgroundImage = Properties.Resources.Sf_Stanley;
            tabStan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            tabStan.Controls.Add(lblIntegralPercent);
            tabStan.Controls.Add(hsbarIntegral);
            tabStan.Controls.Add(label27);
            tabStan.Controls.Add(label25);
            tabStan.Controls.Add(lblHeadingErrorGain);
            tabStan.Controls.Add(lblStanleyGain);
            tabStan.Controls.Add(label5);
            tabStan.Controls.Add(label3);
            tabStan.Controls.Add(hsbarStanleyGain);
            tabStan.Controls.Add(hsbarHeadingErrorGain);
            tabStan.ImageIndex = 2;
            tabStan.Location = new System.Drawing.Point(4, 52);
            tabStan.Name = "tabStan";
            tabStan.Size = new System.Drawing.Size(348, 323);
            tabStan.TabIndex = 15;
            // 
            // lblIntegralPercent
            // 
            lblIntegralPercent.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblIntegralPercent.ForeColor = System.Drawing.Color.Black;
            lblIntegralPercent.Location = new System.Drawing.Point(3, 245);
            lblIntegralPercent.Name = "lblIntegralPercent";
            lblIntegralPercent.Size = new System.Drawing.Size(60, 35);
            lblIntegralPercent.TabIndex = 352;
            lblIntegralPercent.Text = "888";
            lblIntegralPercent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // hsbarIntegral
            // 
            hsbarIntegral.LargeChange = 1;
            hsbarIntegral.Location = new System.Drawing.Point(68, 247);
            hsbarIntegral.Name = "hsbarIntegral";
            hsbarIntegral.Size = new System.Drawing.Size(202, 30);
            hsbarIntegral.TabIndex = 351;
            hsbarIntegral.Value = 5;
            hsbarIntegral.ValueChanged += hsbarIntegral_ValueChanged;
            // 
            // label27
            // 
            label27.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label27.ForeColor = System.Drawing.Color.Black;
            label27.Location = new System.Drawing.Point(63, 218);
            label27.Name = "label27";
            label27.Size = new System.Drawing.Size(204, 30);
            label27.TabIndex = 350;
            label27.Text = "Integral";
            label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            label27.UseCompatibleTextRendering = true;
            // 
            // label25
            // 
            label25.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label25.ForeColor = System.Drawing.Color.SandyBrown;
            label25.Location = new System.Drawing.Point(117, 3);
            label25.Name = "label25";
            label25.Size = new System.Drawing.Size(114, 31);
            label25.TabIndex = 347;
            label25.Text = "Stanley";
            label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHeadingErrorGain
            // 
            lblHeadingErrorGain.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblHeadingErrorGain.ForeColor = System.Drawing.Color.Black;
            lblHeadingErrorGain.Location = new System.Drawing.Point(9, 152);
            lblHeadingErrorGain.Name = "lblHeadingErrorGain";
            lblHeadingErrorGain.Size = new System.Drawing.Size(54, 35);
            lblHeadingErrorGain.TabIndex = 295;
            lblHeadingErrorGain.Text = "888";
            lblHeadingErrorGain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStanleyGain
            // 
            lblStanleyGain.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblStanleyGain.ForeColor = System.Drawing.Color.Black;
            lblStanleyGain.Location = new System.Drawing.Point(9, 64);
            lblStanleyGain.Name = "lblStanleyGain";
            lblStanleyGain.Size = new System.Drawing.Size(54, 35);
            lblStanleyGain.TabIndex = 299;
            lblStanleyGain.Text = "888";
            lblStanleyGain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label5.ForeColor = System.Drawing.Color.Black;
            label5.Location = new System.Drawing.Point(62, 126);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(204, 30);
            label5.TabIndex = 296;
            label5.Text = "Heading";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label3.ForeColor = System.Drawing.Color.Black;
            label3.Location = new System.Drawing.Point(63, 37);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(204, 28);
            label3.TabIndex = 298;
            label3.Text = "Distance";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hsbarStanleyGain
            // 
            hsbarStanleyGain.LargeChange = 1;
            hsbarStanleyGain.Location = new System.Drawing.Point(68, 66);
            hsbarStanleyGain.Maximum = 40;
            hsbarStanleyGain.Minimum = 1;
            hsbarStanleyGain.Name = "hsbarStanleyGain";
            hsbarStanleyGain.Size = new System.Drawing.Size(200, 30);
            hsbarStanleyGain.TabIndex = 297;
            hsbarStanleyGain.Value = 10;
            hsbarStanleyGain.ValueChanged += hsbarStanleyGain_ValueChanged;
            // 
            // hsbarHeadingErrorGain
            // 
            hsbarHeadingErrorGain.LargeChange = 1;
            hsbarHeadingErrorGain.Location = new System.Drawing.Point(68, 156);
            hsbarHeadingErrorGain.Maximum = 15;
            hsbarHeadingErrorGain.Minimum = 1;
            hsbarHeadingErrorGain.Name = "hsbarHeadingErrorGain";
            hsbarHeadingErrorGain.Size = new System.Drawing.Size(200, 30);
            hsbarHeadingErrorGain.TabIndex = 294;
            hsbarHeadingErrorGain.Value = 10;
            hsbarHeadingErrorGain.ValueChanged += hsbarHeadingErrorGain_ValueChanged;
            // 
            // tabInt
            // 
            tabInt.BackColor = System.Drawing.Color.Gainsboro;
            tabInt.BackgroundImage = Properties.Resources.Sf_PP;
            tabInt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            tabInt.Controls.Add(lblSideHillComp);
            tabInt.Controls.Add(hsbarSideHillComp);
            tabInt.Controls.Add(label22);
            tabInt.Controls.Add(lblPureIntegral);
            tabInt.Controls.Add(hsbarIntegralPurePursuit);
            tabInt.Controls.Add(label26);
            tabInt.Controls.Add(label24);
            tabInt.Controls.Add(label21);
            tabInt.Controls.Add(label20);
            tabInt.Controls.Add(label19);
            tabInt.Controls.Add(label18);
            tabInt.Controls.Add(hsbarLookAheadMult);
            tabInt.Controls.Add(lblLookAhead);
            tabInt.Controls.Add(lblLookAheadMult);
            tabInt.ForeColor = System.Drawing.Color.Black;
            tabInt.ImageIndex = 3;
            tabInt.Location = new System.Drawing.Point(4, 52);
            tabInt.Name = "tabInt";
            tabInt.Size = new System.Drawing.Size(348, 323);
            tabInt.TabIndex = 16;
            // 
            // lblSideHillComp
            // 
            lblSideHillComp.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblSideHillComp.ForeColor = System.Drawing.Color.Black;
            lblSideHillComp.Location = new System.Drawing.Point(6, 209);
            lblSideHillComp.Name = "lblSideHillComp";
            lblSideHillComp.Size = new System.Drawing.Size(60, 35);
            lblSideHillComp.TabIndex = 353;
            lblSideHillComp.Text = "888";
            lblSideHillComp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // hsbarSideHillComp
            // 
            hsbarSideHillComp.LargeChange = 1;
            hsbarSideHillComp.Location = new System.Drawing.Point(69, 208);
            hsbarSideHillComp.Name = "hsbarSideHillComp";
            hsbarSideHillComp.Size = new System.Drawing.Size(217, 30);
            hsbarSideHillComp.TabIndex = 352;
            hsbarSideHillComp.Value = 5;
            hsbarSideHillComp.ValueChanged += hsbarSideHillComp_ValueChanged;
            // 
            // label22
            // 
            label22.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label22.ForeColor = System.Drawing.Color.Black;
            label22.Location = new System.Drawing.Point(73, 187);
            label22.Name = "label22";
            label22.Size = new System.Drawing.Size(210, 19);
            label22.TabIndex = 351;
            label22.Text = "Sidehill Deg per Deg of Roll";
            label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            label22.UseCompatibleTextRendering = true;
            // 
            // lblPureIntegral
            // 
            lblPureIntegral.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblPureIntegral.ForeColor = System.Drawing.Color.Black;
            lblPureIntegral.Location = new System.Drawing.Point(5, 279);
            lblPureIntegral.Name = "lblPureIntegral";
            lblPureIntegral.Size = new System.Drawing.Size(60, 35);
            lblPureIntegral.TabIndex = 350;
            lblPureIntegral.Text = "888";
            lblPureIntegral.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // hsbarIntegralPurePursuit
            // 
            hsbarIntegralPurePursuit.LargeChange = 1;
            hsbarIntegralPurePursuit.Location = new System.Drawing.Point(68, 280);
            hsbarIntegralPurePursuit.Name = "hsbarIntegralPurePursuit";
            hsbarIntegralPurePursuit.Size = new System.Drawing.Size(217, 30);
            hsbarIntegralPurePursuit.TabIndex = 349;
            hsbarIntegralPurePursuit.Value = 5;
            hsbarIntegralPurePursuit.ValueChanged += hsbarIntegralPurePursuit_ValueChanged;
            // 
            // label26
            // 
            label26.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label26.ForeColor = System.Drawing.Color.SteelBlue;
            label26.Location = new System.Drawing.Point(88, 4);
            label26.Name = "label26";
            label26.Size = new System.Drawing.Size(172, 28);
            label26.TabIndex = 348;
            label26.Text = "Pure Pursuit";
            label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label24
            // 
            label24.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label24.ForeColor = System.Drawing.Color.Black;
            label24.Location = new System.Drawing.Point(74, 257);
            label24.Name = "label24";
            label24.Size = new System.Drawing.Size(204, 19);
            label24.TabIndex = 342;
            label24.Text = "Integral";
            label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            label24.UseCompatibleTextRendering = true;
            // 
            // label21
            // 
            label21.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label21.ForeColor = System.Drawing.Color.Black;
            label21.Location = new System.Drawing.Point(74, 42);
            label21.Name = "label21";
            label21.Size = new System.Drawing.Size(204, 19);
            label21.TabIndex = 303;
            label21.Text = "Look Ahead (m)";
            label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            label20.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label20.ForeColor = System.Drawing.SystemColors.ButtonFace;
            label20.Location = new System.Drawing.Point(579, 228);
            label20.Name = "label20";
            label20.Size = new System.Drawing.Size(204, 30);
            label20.TabIndex = 302;
            label20.Text = "Look Ahead Min";
            label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            label19.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label19.ForeColor = System.Drawing.Color.Black;
            label19.Location = new System.Drawing.Point(74, 114);
            label19.Name = "label19";
            label19.Size = new System.Drawing.Size(204, 19);
            label19.TabIndex = 301;
            label19.Text = "Look Ahead Speed Gain";
            label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            label18.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label18.ForeColor = System.Drawing.SystemColors.ButtonFace;
            label18.Location = new System.Drawing.Point(561, 13);
            label18.Name = "label18";
            label18.Size = new System.Drawing.Size(204, 30);
            label18.TabIndex = 300;
            label18.Text = "Look Ahead";
            label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hsbarLookAheadMult
            // 
            hsbarLookAheadMult.LargeChange = 1;
            hsbarLookAheadMult.Location = new System.Drawing.Point(68, 136);
            hsbarLookAheadMult.Maximum = 30;
            hsbarLookAheadMult.Minimum = 5;
            hsbarLookAheadMult.Name = "hsbarLookAheadMult";
            hsbarLookAheadMult.Size = new System.Drawing.Size(217, 30);
            hsbarLookAheadMult.TabIndex = 298;
            hsbarLookAheadMult.Value = 6;
            hsbarLookAheadMult.ValueChanged += hsbarLookAheadMult_ValueChanged;
            // 
            // lblLookAhead
            // 
            lblLookAhead.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblLookAhead.ForeColor = System.Drawing.Color.Black;
            lblLookAhead.Location = new System.Drawing.Point(4, 61);
            lblLookAhead.Name = "lblLookAhead";
            lblLookAhead.Size = new System.Drawing.Size(60, 35);
            lblLookAhead.TabIndex = 293;
            lblLookAhead.Text = "888";
            lblLookAhead.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLookAheadMult
            // 
            lblLookAheadMult.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblLookAheadMult.ForeColor = System.Drawing.Color.Black;
            lblLookAheadMult.Location = new System.Drawing.Point(4, 141);
            lblLookAheadMult.Name = "lblLookAheadMult";
            lblLookAheadMult.Size = new System.Drawing.Size(60, 35);
            lblLookAheadMult.TabIndex = 299;
            lblLookAheadMult.Text = "888";
            lblLookAheadMult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            imageList1.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = System.Drawing.Color.Transparent;
            imageList1.Images.SetKeyName(0, "ST_SteerTab.png");
            imageList1.Images.SetKeyName(1, "ST_GainTab.png");
            imageList1.Images.SetKeyName(2, "ST_StanleyTab.png");
            imageList1.Images.SetKeyName(3, "Sf_PPTab.png");
            // 
            // label15
            // 
            label15.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label15.AutoSize = true;
            label15.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label15.ForeColor = System.Drawing.Color.Black;
            label15.Location = new System.Drawing.Point(169, 255);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(228, 23);
            label15.TabIndex = 338;
            label15.Text = "PWM Minimum Movement";
            label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label4.ForeColor = System.Drawing.Color.Black;
            label4.Location = new System.Drawing.Point(213, 261);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(118, 19);
            label4.TabIndex = 336;
            label4.Text = "PWM Maximum";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label2.ForeColor = System.Drawing.Color.Black;
            label2.Location = new System.Drawing.Point(204, 181);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(133, 19);
            label2.TabIndex = 335;
            label2.Text = "Proportional Gain";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hsbarMinPWM
            // 
            hsbarMinPWM.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            hsbarMinPWM.LargeChange = 1;
            hsbarMinPWM.Location = new System.Drawing.Point(115, 281);
            hsbarMinPWM.Name = "hsbarMinPWM";
            hsbarMinPWM.Size = new System.Drawing.Size(309, 44);
            hsbarMinPWM.TabIndex = 284;
            hsbarMinPWM.Value = 10;
            hsbarMinPWM.ValueChanged += hsbarMinPWM_ValueChanged;
            // 
            // hsbarProportionalGain
            // 
            hsbarProportionalGain.LargeChange = 1;
            hsbarProportionalGain.Location = new System.Drawing.Point(136, 203);
            hsbarProportionalGain.Maximum = 200;
            hsbarProportionalGain.Name = "hsbarProportionalGain";
            hsbarProportionalGain.Size = new System.Drawing.Size(270, 41);
            hsbarProportionalGain.TabIndex = 254;
            hsbarProportionalGain.Value = 4;
            hsbarProportionalGain.ValueChanged += hsbarProportionalGain_ValueChanged;
            // 
            // lblProportionalGain
            // 
            lblProportionalGain.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblProportionalGain.ForeColor = System.Drawing.Color.Black;
            lblProportionalGain.Location = new System.Drawing.Point(46, 207);
            lblProportionalGain.Name = "lblProportionalGain";
            lblProportionalGain.Size = new System.Drawing.Size(83, 35);
            lblProportionalGain.TabIndex = 258;
            lblProportionalGain.Text = "888";
            lblProportionalGain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHighSteerPWM
            // 
            lblHighSteerPWM.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblHighSteerPWM.ForeColor = System.Drawing.Color.Black;
            lblHighSteerPWM.Location = new System.Drawing.Point(46, 283);
            lblHighSteerPWM.Name = "lblHighSteerPWM";
            lblHighSteerPWM.Size = new System.Drawing.Size(83, 35);
            lblHighSteerPWM.TabIndex = 278;
            lblHighSteerPWM.Text = "888";
            lblHighSteerPWM.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMinPWM
            // 
            lblMinPWM.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblMinPWM.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblMinPWM.ForeColor = System.Drawing.Color.Black;
            lblMinPWM.Location = new System.Drawing.Point(27, 284);
            lblMinPWM.Name = "lblMinPWM";
            lblMinPWM.Size = new System.Drawing.Size(82, 35);
            lblMinPWM.TabIndex = 288;
            lblMinPWM.Text = "888";
            lblMinPWM.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // hsbarHighSteerPWM
            // 
            hsbarHighSteerPWM.LargeChange = 2;
            hsbarHighSteerPWM.Location = new System.Drawing.Point(136, 280);
            hsbarHighSteerPWM.Maximum = 255;
            hsbarHighSteerPWM.Name = "hsbarHighSteerPWM";
            hsbarHighSteerPWM.Size = new System.Drawing.Size(270, 41);
            hsbarHighSteerPWM.TabIndex = 274;
            hsbarHighSteerPWM.Value = 50;
            hsbarHighSteerPWM.ValueChanged += hsbarHighSteerPWM_ValueChanged;
            // 
            // lblMaxSteerAngle
            // 
            lblMaxSteerAngle.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblMaxSteerAngle.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblMaxSteerAngle.ForeColor = System.Drawing.Color.Black;
            lblMaxSteerAngle.Location = new System.Drawing.Point(66, 255);
            lblMaxSteerAngle.Name = "lblMaxSteerAngle";
            lblMaxSteerAngle.Size = new System.Drawing.Size(92, 35);
            lblMaxSteerAngle.TabIndex = 303;
            lblMaxSteerAngle.Text = "888";
            lblMaxSteerAngle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // hsbarMaxSteerAngle
            // 
            hsbarMaxSteerAngle.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            hsbarMaxSteerAngle.LargeChange = 1;
            hsbarMaxSteerAngle.Location = new System.Drawing.Point(172, 247);
            hsbarMaxSteerAngle.Maximum = 80;
            hsbarMaxSteerAngle.Minimum = 10;
            hsbarMaxSteerAngle.Name = "hsbarMaxSteerAngle";
            hsbarMaxSteerAngle.Size = new System.Drawing.Size(270, 50);
            hsbarMaxSteerAngle.TabIndex = 299;
            hsbarMaxSteerAngle.Value = 10;
            hsbarMaxSteerAngle.ValueChanged += hsbarMaxSteerAngle_ValueChanged;
            // 
            // label7
            // 
            label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label7.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label7.ForeColor = System.Drawing.Color.Black;
            label7.Location = new System.Drawing.Point(17, 43);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(632, 57);
            label7.TabIndex = 334;
            label7.Text = "Turn steering wheel to RIGHT about 20 degrees.\r\nWhile driving in a steady circle, Press Rec and wait.";
            label7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // hsbarCountsPerDegree
            // 
            hsbarCountsPerDegree.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            hsbarCountsPerDegree.LargeChange = 1;
            hsbarCountsPerDegree.Location = new System.Drawing.Point(134, 271);
            hsbarCountsPerDegree.Maximum = 255;
            hsbarCountsPerDegree.Minimum = 1;
            hsbarCountsPerDegree.Name = "hsbarCountsPerDegree";
            hsbarCountsPerDegree.Size = new System.Drawing.Size(270, 50);
            hsbarCountsPerDegree.TabIndex = 304;
            hsbarCountsPerDegree.Value = 20;
            hsbarCountsPerDegree.ValueChanged += hsbarCountsPerDegree_ValueChanged;
            // 
            // label10
            // 
            label10.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label10.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label10.ForeColor = System.Drawing.Color.Black;
            label10.Location = new System.Drawing.Point(50, 52);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(544, 28);
            label10.TabIndex = 295;
            label10.Text = "Drive straight forward and Touch Zero";
            label10.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblCountsPerDegree
            // 
            lblCountsPerDegree.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblCountsPerDegree.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblCountsPerDegree.ForeColor = System.Drawing.Color.Black;
            lblCountsPerDegree.Location = new System.Drawing.Point(39, 278);
            lblCountsPerDegree.Name = "lblCountsPerDegree";
            lblCountsPerDegree.Size = new System.Drawing.Size(86, 35);
            lblCountsPerDegree.TabIndex = 308;
            lblCountsPerDegree.Text = "888";
            lblCountsPerDegree.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // hsbarWasOffset
            // 
            hsbarWasOffset.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            hsbarWasOffset.LargeChange = 20;
            hsbarWasOffset.Location = new System.Drawing.Point(188, 192);
            hsbarWasOffset.Maximum = 4000;
            hsbarWasOffset.Minimum = -4000;
            hsbarWasOffset.Name = "hsbarWasOffset";
            hsbarWasOffset.Size = new System.Drawing.Size(270, 50);
            hsbarWasOffset.SmallChange = 2;
            hsbarWasOffset.TabIndex = 294;
            hsbarWasOffset.ValueChanged += hsbarSteerAngleSensorZero_ValueChanged;
            // 
            // lblSteerAngleSensorZero
            // 
            lblSteerAngleSensorZero.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblSteerAngleSensorZero.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblSteerAngleSensorZero.ForeColor = System.Drawing.Color.Black;
            lblSteerAngleSensorZero.Location = new System.Drawing.Point(461, 200);
            lblSteerAngleSensorZero.Name = "lblSteerAngleSensorZero";
            lblSteerAngleSensorZero.Size = new System.Drawing.Size(109, 35);
            lblSteerAngleSensorZero.TabIndex = 298;
            lblSteerAngleSensorZero.Text = "-55.88";
            lblSteerAngleSensorZero.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pbarRight
            // 
            pbarRight.Location = new System.Drawing.Point(401, 36);
            pbarRight.Name = "pbarRight";
            pbarRight.Size = new System.Drawing.Size(212, 35);
            pbarRight.TabIndex = 330;
            // 
            // pbarLeft
            // 
            pbarLeft.Location = new System.Drawing.Point(187, 36);
            pbarLeft.Name = "pbarLeft";
            pbarLeft.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            pbarLeft.RightToLeftLayout = true;
            pbarLeft.Size = new System.Drawing.Size(212, 35);
            pbarLeft.TabIndex = 329;
            // 
            // label28
            // 
            label28.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label28.AutoSize = true;
            label28.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label28.ForeColor = System.Drawing.Color.Black;
            label28.Location = new System.Drawing.Point(182, 167);
            label28.Name = "label28";
            label28.Size = new System.Drawing.Size(218, 95);
            label28.TabIndex = 513;
            label28.Text = "Button - Push Release, On.   \r\n               Push Release, Off\r\n\r\nSwitch - While Pushed is On. \r\n               Released is Off.";
            // 
            // labelPressureTurnSensor
            // 
            labelPressureTurnSensor.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelPressureTurnSensor.AutoSize = true;
            labelPressureTurnSensor.ForeColor = System.Drawing.Color.Black;
            labelPressureTurnSensor.Location = new System.Drawing.Point(429, 93);
            labelPressureTurnSensor.Name = "labelPressureTurnSensor";
            labelPressureTurnSensor.Size = new System.Drawing.Size(110, 13);
            labelPressureTurnSensor.TabIndex = 512;
            labelPressureTurnSensor.Text = "Pressure Turn Sensor";
            // 
            // labelCurrentTurnSensor
            // 
            labelCurrentTurnSensor.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelCurrentTurnSensor.AutoSize = true;
            labelCurrentTurnSensor.ForeColor = System.Drawing.Color.Black;
            labelCurrentTurnSensor.Location = new System.Drawing.Point(282, 93);
            labelCurrentTurnSensor.Name = "labelCurrentTurnSensor";
            labelCurrentTurnSensor.Size = new System.Drawing.Size(105, 13);
            labelCurrentTurnSensor.TabIndex = 511;
            labelCurrentTurnSensor.Text = "Current Turn Sensor";
            // 
            // labelEncoder
            // 
            labelEncoder.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelEncoder.AutoSize = true;
            labelEncoder.ForeColor = System.Drawing.Color.Black;
            labelEncoder.Location = new System.Drawing.Point(158, 93);
            labelEncoder.Name = "labelEncoder";
            labelEncoder.Size = new System.Drawing.Size(65, 13);
            labelEncoder.TabIndex = 506;
            labelEncoder.Text = "Turn Sensor";
            // 
            // label70
            // 
            label70.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label70.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label70.ForeColor = System.Drawing.Color.Black;
            label70.Location = new System.Drawing.Point(8, 70);
            label70.Name = "label70";
            label70.Size = new System.Drawing.Size(626, 52);
            label70.TabIndex = 505;
            label70.Text = "Drive slowly and enable Auto Steer. Invert Direction if steer motor turns the wrong way.\r\nTest with Arrows.";
            label70.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label29
            // 
            label29.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label29.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label29.ForeColor = System.Drawing.Color.Black;
            label29.Location = new System.Drawing.Point(60, 109);
            label29.Name = "label29";
            label29.Size = new System.Drawing.Size(541, 32);
            label29.TabIndex = 504;
            label29.Text = "Invert Hydraulic Enable Relay?";
            label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboxMotorDrive
            // 
            cboxMotorDrive.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            cboxMotorDrive.BackColor = System.Drawing.Color.AliceBlue;
            cboxMotorDrive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboxMotorDrive.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cboxMotorDrive.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cboxMotorDrive.FormattingEnabled = true;
            cboxMotorDrive.Items.AddRange(new object[] { "Cytron", "IBT2" });
            cboxMotorDrive.Location = new System.Drawing.Point(238, 176);
            cboxMotorDrive.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            cboxMotorDrive.Name = "cboxMotorDrive";
            cboxMotorDrive.Size = new System.Drawing.Size(175, 37);
            cboxMotorDrive.TabIndex = 495;
            cboxMotorDrive.SelectedIndexChanged += cboxMotorDrive_SelectedIndexChanged;
            // 
            // cboxSteerEnable
            // 
            cboxSteerEnable.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            cboxSteerEnable.BackColor = System.Drawing.Color.AliceBlue;
            cboxSteerEnable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboxSteerEnable.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cboxSteerEnable.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cboxSteerEnable.FormattingEnabled = true;
            cboxSteerEnable.Items.AddRange(new object[] { "None", "Switch", "Button" });
            cboxSteerEnable.Location = new System.Drawing.Point(195, 111);
            cboxSteerEnable.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            cboxSteerEnable.Name = "cboxSteerEnable";
            cboxSteerEnable.Size = new System.Drawing.Size(175, 37);
            cboxSteerEnable.TabIndex = 498;
            cboxSteerEnable.SelectedIndexChanged += cboxSteerEnable_SelectedIndexChanged;
            // 
            // label62
            // 
            label62.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label62.BackColor = System.Drawing.Color.Transparent;
            label62.Font = new System.Drawing.Font("Tahoma", 15.75F);
            label62.ForeColor = System.Drawing.Color.Black;
            label62.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label62.Location = new System.Drawing.Point(84, 76);
            label62.Name = "label62";
            label62.Size = new System.Drawing.Size(396, 29);
            label62.TabIndex = 499;
            label62.Text = "Steer Enable Mode";
            label62.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // cboxConv
            // 
            cboxConv.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            cboxConv.BackColor = System.Drawing.Color.AliceBlue;
            cboxConv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboxConv.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cboxConv.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cboxConv.FormattingEnabled = true;
            cboxConv.Items.AddRange(new object[] { "Single", "Differential" });
            cboxConv.Location = new System.Drawing.Point(238, 176);
            cboxConv.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            cboxConv.Name = "cboxConv";
            cboxConv.Size = new System.Drawing.Size(175, 37);
            cboxConv.TabIndex = 500;
            cboxConv.SelectedIndexChanged += cboxConv_SelectedIndexChanged;
            // 
            // label63
            // 
            label63.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label63.BackColor = System.Drawing.Color.Transparent;
            label63.Font = new System.Drawing.Font("Tahoma", 15.75F);
            label63.ForeColor = System.Drawing.Color.Black;
            label63.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label63.Location = new System.Drawing.Point(67, 139);
            label63.Name = "label63";
            label63.Size = new System.Drawing.Size(529, 25);
            label63.TabIndex = 496;
            label63.Text = "What Style of Motor Driver?";
            label63.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label64
            // 
            label64.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label64.BackColor = System.Drawing.Color.Transparent;
            label64.Font = new System.Drawing.Font("Tahoma", 15.75F);
            label64.ForeColor = System.Drawing.Color.Black;
            label64.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label64.Location = new System.Drawing.Point(114, 138);
            label64.Name = "label64";
            label64.Size = new System.Drawing.Size(436, 25);
            label64.TabIndex = 497;
            label64.Text = "A/D Convertor Connection?";
            label64.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label61
            // 
            label61.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label61.BackColor = System.Drawing.Color.Transparent;
            label61.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label61.ForeColor = System.Drawing.Color.Black;
            label61.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label61.Location = new System.Drawing.Point(53, 204);
            label61.Name = "label61";
            label61.Size = new System.Drawing.Size(112, 32);
            label61.TabIndex = 494;
            label61.Text = "Turn Counts";
            label61.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // nudMaxCounts
            // 
            nudMaxCounts.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            nudMaxCounts.BackColor = System.Drawing.Color.AliceBlue;
            nudMaxCounts.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            nudMaxCounts.InterceptArrowKeys = false;
            nudMaxCounts.Location = new System.Drawing.Point(58, 239);
            nudMaxCounts.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            nudMaxCounts.Name = "nudMaxCounts";
            nudMaxCounts.ReadOnly = true;
            nudMaxCounts.Size = new System.Drawing.Size(107, 52);
            nudMaxCounts.TabIndex = 493;
            nudMaxCounts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudMaxCounts.Value = new decimal(new int[] { 15, 0, 0, 0 });
            nudMaxCounts.Click += nudMaxCounts_Click;
            // 
            // label55
            // 
            label55.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label55.BackColor = System.Drawing.Color.Transparent;
            label55.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label55.ForeColor = System.Drawing.Color.Black;
            label55.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label55.Location = new System.Drawing.Point(77, 109);
            label55.Name = "label55";
            label55.Size = new System.Drawing.Size(501, 31);
            label55.TabIndex = 489;
            label55.Text = "Do you have use a Danfoss Valve?";
            label55.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label30
            // 
            label30.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label30.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label30.ForeColor = System.Drawing.Color.Black;
            label30.Location = new System.Drawing.Point(12, 84);
            label30.Name = "label30";
            label30.Size = new System.Drawing.Size(635, 56);
            label30.TabIndex = 515;
            label30.Text = "Steer Angle must be POSITIVE when turning to the RIGHT.\r\nIf not, select the Invert WAS.";
            label30.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.White;
            panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel2.Controls.Add(btnSteerStatus);
            panel2.Controls.Add(label35);
            panel2.Controls.Add(label34);
            panel2.Controls.Add(lblError);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(lblSteerAngle);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(lblPWMDisplay);
            panel2.Controls.Add(lblSteerAngleActual);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(pbarLeft);
            panel2.Controls.Add(pbarRight);
            panel2.Controls.Add(label11);
            panel2.Location = new System.Drawing.Point(5, 430);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(665, 123);
            panel2.TabIndex = 324;
            // 
            // btnSteerStatus
            // 
            btnSteerStatus.BackColor = System.Drawing.Color.White;
            btnSteerStatus.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            btnSteerStatus.FlatAppearance.BorderSize = 0;
            btnSteerStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSteerStatus.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnSteerStatus.Image = Properties.Resources.WizSteerDot;
            btnSteerStatus.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnSteerStatus.Location = new System.Drawing.Point(14, 4);
            btnSteerStatus.Name = "btnSteerStatus";
            btnSteerStatus.Size = new System.Drawing.Size(135, 118);
            btnSteerStatus.TabIndex = 531;
            btnSteerStatus.UseVisualStyleBackColor = false;
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.BackColor = System.Drawing.Color.Transparent;
            label35.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label35.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label35.Location = new System.Drawing.Point(194, 74);
            label35.Name = "label35";
            label35.Size = new System.Drawing.Size(33, 16);
            label35.TabIndex = 332;
            label35.Text = "Left";
            label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.BackColor = System.Drawing.Color.Transparent;
            label34.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label34.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label34.Location = new System.Drawing.Point(572, 74);
            label34.Name = "label34";
            label34.Size = new System.Drawing.Size(41, 16);
            label34.TabIndex = 331;
            label34.Text = "Right";
            label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            panel1.Controls.Add(label38);
            panel1.Controls.Add(btnFreeDriveZero);
            panel1.Controls.Add(btnSteerAngleUp);
            panel1.Controls.Add(btnFreeDrive);
            panel1.Controls.Add(btnSteerAngleDown);
            panel1.Controls.Add(label14);
            panel1.Location = new System.Drawing.Point(915, 43);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(429, 100);
            panel1.TabIndex = 323;
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.BackColor = System.Drawing.Color.Transparent;
            label38.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label38.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label38.Location = new System.Drawing.Point(13, 72);
            label38.Name = "label38";
            label38.Size = new System.Drawing.Size(73, 16);
            label38.TabIndex = 325;
            label38.Text = "Free Drive";
            label38.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnFreeDriveZero
            // 
            btnFreeDriveZero.FlatAppearance.BorderColor = System.Drawing.Color.White;
            btnFreeDriveZero.FlatAppearance.BorderSize = 0;
            btnFreeDriveZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnFreeDriveZero.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnFreeDriveZero.ForeColor = System.Drawing.Color.White;
            btnFreeDriveZero.Image = Properties.Resources.SteerZero;
            btnFreeDriveZero.Location = new System.Drawing.Point(340, 13);
            btnFreeDriveZero.Name = "btnFreeDriveZero";
            btnFreeDriveZero.Size = new System.Drawing.Size(73, 56);
            btnFreeDriveZero.TabIndex = 313;
            btnFreeDriveZero.UseVisualStyleBackColor = true;
            btnFreeDriveZero.Click += btnFreeDriveZero_Click;
            // 
            // btnSteerAngleUp
            // 
            btnSteerAngleUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnSteerAngleUp.FlatAppearance.BorderSize = 0;
            btnSteerAngleUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSteerAngleUp.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnSteerAngleUp.Image = Properties.Resources.SteerRight;
            btnSteerAngleUp.Location = new System.Drawing.Point(230, 14);
            btnSteerAngleUp.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            btnSteerAngleUp.Name = "btnSteerAngleUp";
            btnSteerAngleUp.Size = new System.Drawing.Size(73, 74);
            btnSteerAngleUp.TabIndex = 315;
            btnSteerAngleUp.UseVisualStyleBackColor = true;
            btnSteerAngleUp.MouseDown += btnSteerAngleUp_MouseDown;
            // 
            // btnFreeDrive
            // 
            btnFreeDrive.BackColor = System.Drawing.Color.WhiteSmoke;
            btnFreeDrive.FlatAppearance.BorderSize = 0;
            btnFreeDrive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnFreeDrive.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnFreeDrive.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            btnFreeDrive.Image = Properties.Resources.SteerDriveOff;
            btnFreeDrive.Location = new System.Drawing.Point(13, 13);
            btnFreeDrive.Name = "btnFreeDrive";
            btnFreeDrive.Size = new System.Drawing.Size(73, 56);
            btnFreeDrive.TabIndex = 228;
            btnFreeDrive.UseVisualStyleBackColor = false;
            btnFreeDrive.Click += btnFreeDrive_Click;
            // 
            // btnSteerAngleDown
            // 
            btnSteerAngleDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnSteerAngleDown.FlatAppearance.BorderSize = 0;
            btnSteerAngleDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSteerAngleDown.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnSteerAngleDown.Image = Properties.Resources.SteerLeft;
            btnSteerAngleDown.Location = new System.Drawing.Point(124, 13);
            btnSteerAngleDown.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            btnSteerAngleDown.Name = "btnSteerAngleDown";
            btnSteerAngleDown.Size = new System.Drawing.Size(73, 74);
            btnSteerAngleDown.TabIndex = 314;
            btnSteerAngleDown.UseVisualStyleBackColor = true;
            btnSteerAngleDown.MouseDown += btnSteerAngleDown_MouseDown;
            // 
            // hsbarSensor
            // 
            hsbarSensor.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            hsbarSensor.LargeChange = 1;
            hsbarSensor.Location = new System.Drawing.Point(37, 247);
            hsbarSensor.Maximum = 255;
            hsbarSensor.Name = "hsbarSensor";
            hsbarSensor.Size = new System.Drawing.Size(280, 30);
            hsbarSensor.TabIndex = 516;
            hsbarSensor.Scroll += hsbarSensor_Scroll;
            // 
            // lblhsbarSensor
            // 
            lblhsbarSensor.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblhsbarSensor.AutoSize = true;
            lblhsbarSensor.BackColor = System.Drawing.Color.Transparent;
            lblhsbarSensor.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblhsbarSensor.ForeColor = System.Drawing.Color.Black;
            lblhsbarSensor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            lblhsbarSensor.Location = new System.Drawing.Point(336, 250);
            lblhsbarSensor.Name = "lblhsbarSensor";
            lblhsbarSensor.Size = new System.Drawing.Size(57, 29);
            lblhsbarSensor.TabIndex = 518;
            lblhsbarSensor.Text = "0%";
            lblhsbarSensor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabWiz
            // 
            tabWiz.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            tabWiz.Controls.Add(tabStart);
            tabWiz.Controls.Add(tabLoadDef);
            tabWiz.Controls.Add(tabWheelBase);
            tabWiz.Controls.Add(tabWheelTrack);
            tabWiz.Controls.Add(tabAntennaDistance);
            tabWiz.Controls.Add(tabAntennaHeight);
            tabWiz.Controls.Add(tabAntennaOffset);
            tabWiz.Controls.Add(tabButtonSwitch);
            tabWiz.Controls.Add(tabA2DConv);
            tabWiz.Controls.Add(tabMotorDriver);
            tabWiz.Controls.Add(tabInvertRelays);
            tabWiz.Controls.Add(tabDanfoss);
            tabWiz.Controls.Add(tabRollInv);
            tabWiz.Controls.Add(tabRollZero);
            tabWiz.Controls.Add(tabWAS);
            tabWiz.Controls.Add(tabWAS_Zero);
            tabWiz.Controls.Add(tabMotorDirection);
            tabWiz.Controls.Add(tabCPD_Setup);
            tabWiz.Controls.Add(tabCountsPerDeg);
            tabWiz.Controls.Add(tabAckCPD);
            tabWiz.Controls.Add(tabMaxSteerAngle);
            tabWiz.Controls.Add(tabCancelGuidance);
            tabWiz.Controls.Add(tabPanicStop);
            tabWiz.Controls.Add(tab_MinimumGain);
            tabWiz.Controls.Add(tabPGain);
            tabWiz.Controls.Add(tabEnd);
            tabWiz.Dock = System.Windows.Forms.DockStyle.Fill;
            tabWiz.ItemSize = new System.Drawing.Size(60, 15);
            tabWiz.Location = new System.Drawing.Point(0, 0);
            tabWiz.Name = "tabWiz";
            tabWiz.Padding = new System.Drawing.Point(0, 0);
            tabWiz.SelectedIndex = 0;
            tabWiz.Size = new System.Drawing.Size(663, 371);
            tabWiz.TabIndex = 522;
            // 
            // tabStart
            // 
            tabStart.BackColor = System.Drawing.Color.White;
            tabStart.Controls.Add(btnStartWizard);
            tabStart.Location = new System.Drawing.Point(4, 19);
            tabStart.Name = "tabStart";
            tabStart.Size = new System.Drawing.Size(655, 348);
            tabStart.TabIndex = 15;
            tabStart.Text = "tabStart";
            // 
            // btnStartWizard
            // 
            btnStartWizard.BackColor = System.Drawing.Color.PaleGreen;
            btnStartWizard.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            btnStartWizard.FlatAppearance.BorderSize = 2;
            btnStartWizard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnStartWizard.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnStartWizard.Image = Properties.Resources.OK64;
            btnStartWizard.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnStartWizard.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnStartWizard.Location = new System.Drawing.Point(226, 106);
            btnStartWizard.Name = "btnStartWizard";
            btnStartWizard.Size = new System.Drawing.Size(199, 80);
            btnStartWizard.TabIndex = 526;
            btnStartWizard.Text = "  Start Wizard";
            btnStartWizard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnStartWizard.UseVisualStyleBackColor = false;
            btnStartWizard.Click += btnStartWizard_Click;
            // 
            // tabLoadDef
            // 
            tabLoadDef.BackColor = System.Drawing.Color.White;
            tabLoadDef.Controls.Add(label81);
            tabLoadDef.Controls.Add(label80);
            tabLoadDef.Controls.Add(btnOkNext_LoadDefault);
            tabLoadDef.Controls.Add(btnLoadDefaults);
            tabLoadDef.Location = new System.Drawing.Point(4, 19);
            tabLoadDef.Name = "tabLoadDef";
            tabLoadDef.Size = new System.Drawing.Size(655, 348);
            tabLoadDef.TabIndex = 35;
            tabLoadDef.Text = "LoadDef";
            // 
            // label81
            // 
            label81.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label81.BackColor = System.Drawing.Color.Transparent;
            label81.Font = new System.Drawing.Font("Tahoma", 15.75F);
            label81.ForeColor = System.Drawing.Color.Black;
            label81.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label81.Location = new System.Drawing.Point(115, 188);
            label81.Name = "label81";
            label81.Size = new System.Drawing.Size(436, 25);
            label81.TabIndex = 536;
            label81.Text = "Highly Recommended";
            label81.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label80
            // 
            label80.AutoSize = true;
            label80.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label80.ForeColor = System.Drawing.Color.Black;
            label80.Location = new System.Drawing.Point(6, 5);
            label80.Name = "label80";
            label80.Size = new System.Drawing.Size(157, 25);
            label80.TabIndex = 535;
            label80.Text = "Load Defaults";
            label80.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnOkNext_LoadDefault
            // 
            btnOkNext_LoadDefault.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnOkNext_LoadDefault.BackColor = System.Drawing.Color.Transparent;
            btnOkNext_LoadDefault.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            btnOkNext_LoadDefault.FlatAppearance.BorderSize = 0;
            btnOkNext_LoadDefault.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnOkNext_LoadDefault.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnOkNext_LoadDefault.Image = Properties.Resources.Next;
            btnOkNext_LoadDefault.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnOkNext_LoadDefault.Location = new System.Drawing.Point(576, 269);
            btnOkNext_LoadDefault.Name = "btnOkNext_LoadDefault";
            btnOkNext_LoadDefault.Size = new System.Drawing.Size(72, 72);
            btnOkNext_LoadDefault.TabIndex = 534;
            btnOkNext_LoadDefault.UseVisualStyleBackColor = false;
            btnOkNext_LoadDefault.Click += btnOkNext_Click;
            // 
            // btnLoadDefaults
            // 
            btnLoadDefaults.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnLoadDefaults.BackColor = System.Drawing.Color.LightSteelBlue;
            btnLoadDefaults.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            btnLoadDefaults.FlatAppearance.BorderSize = 2;
            btnLoadDefaults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLoadDefaults.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnLoadDefaults.Image = Properties.Resources.OK64;
            btnLoadDefaults.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnLoadDefaults.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnLoadDefaults.Location = new System.Drawing.Point(234, 225);
            btnLoadDefaults.Name = "btnLoadDefaults";
            btnLoadDefaults.Size = new System.Drawing.Size(199, 80);
            btnLoadDefaults.TabIndex = 533;
            btnLoadDefaults.Text = "Load Defaults";
            btnLoadDefaults.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnLoadDefaults.UseVisualStyleBackColor = false;
            btnLoadDefaults.Click += btnLoadDefaults_Click;
            // 
            // tabWheelBase
            // 
            tabWheelBase.BackColor = System.Drawing.Color.White;
            tabWheelBase.BackgroundImage = Properties.Resources.RadiusWheelBase;
            tabWheelBase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            tabWheelBase.Controls.Add(label117);
            tabWheelBase.Controls.Add(label89);
            tabWheelBase.Controls.Add(button1);
            tabWheelBase.Controls.Add(label90);
            tabWheelBase.Controls.Add(nudWheelbase);
            tabWheelBase.Controls.Add(label91);
            tabWheelBase.Controls.Add(button2);
            tabWheelBase.Location = new System.Drawing.Point(4, 19);
            tabWheelBase.Name = "tabWheelBase";
            tabWheelBase.Size = new System.Drawing.Size(655, 348);
            tabWheelBase.TabIndex = 37;
            tabWheelBase.Text = "WBase";
            // 
            // label117
            // 
            label117.BackColor = System.Drawing.Color.White;
            label117.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label117.ForeColor = System.Drawing.Color.Black;
            label117.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label117.Location = new System.Drawing.Point(3, 8);
            label117.Name = "label117";
            label117.Size = new System.Drawing.Size(455, 154);
            label117.TabIndex = 544;
            label117.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label89
            // 
            label89.BackColor = System.Drawing.Color.White;
            label89.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label89.ForeColor = System.Drawing.Color.Black;
            label89.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label89.Location = new System.Drawing.Point(385, 5);
            label89.Name = "label89";
            label89.Size = new System.Drawing.Size(224, 257);
            label89.TabIndex = 543;
            label89.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            button1.BackColor = System.Drawing.Color.Transparent;
            button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Font = new System.Drawing.Font("Tahoma", 14.25F);
            button1.Image = Properties.Resources.Previous;
            button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            button1.Location = new System.Drawing.Point(486, 268);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(72, 72);
            button1.TabIndex = 542;
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnPrev_Click;
            // 
            // label90
            // 
            label90.AutoSize = true;
            label90.BackColor = System.Drawing.Color.Transparent;
            label90.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label90.ForeColor = System.Drawing.Color.Black;
            label90.Location = new System.Drawing.Point(6, 6);
            label90.Name = "label90";
            label90.Size = new System.Drawing.Size(126, 25);
            label90.TabIndex = 541;
            label90.Text = "Wheelbase";
            label90.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nudWheelbase
            // 
            nudWheelbase.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            nudWheelbase.BackColor = System.Drawing.Color.AliceBlue;
            nudWheelbase.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            nudWheelbase.InterceptArrowKeys = false;
            nudWheelbase.Location = new System.Drawing.Point(90, 231);
            nudWheelbase.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            nudWheelbase.Name = "nudWheelbase";
            nudWheelbase.ReadOnly = true;
            nudWheelbase.Size = new System.Drawing.Size(143, 65);
            nudWheelbase.TabIndex = 537;
            nudWheelbase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudWheelbase.Value = new decimal(new int[] { 333, 0, 0, 0 });
            nudWheelbase.Click += nudWheelbase_Click;
            // 
            // label91
            // 
            label91.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label91.BackColor = System.Drawing.Color.Linen;
            label91.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label91.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label91.ForeColor = System.Drawing.Color.Black;
            label91.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label91.Location = new System.Drawing.Point(67, 153);
            label91.Name = "label91";
            label91.Size = new System.Drawing.Size(180, 187);
            label91.TabIndex = 538;
            label91.Text = "Set Wheelbase";
            label91.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button2
            // 
            button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            button2.BackColor = System.Drawing.Color.Transparent;
            button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button2.Font = new System.Drawing.Font("Tahoma", 14.25F);
            button2.Image = Properties.Resources.Next;
            button2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            button2.Location = new System.Drawing.Point(577, 268);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(72, 72);
            button2.TabIndex = 540;
            button2.UseVisualStyleBackColor = false;
            button2.Click += btnOkNext_Click;
            // 
            // tabWheelTrack
            // 
            tabWheelTrack.BackColor = System.Drawing.Color.White;
            tabWheelTrack.BackgroundImage = Properties.Resources.RadiusWheelBase;
            tabWheelTrack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            tabWheelTrack.Controls.Add(label118);
            tabWheelTrack.Controls.Add(nudVehicleTrack);
            tabWheelTrack.Controls.Add(label95);
            tabWheelTrack.Controls.Add(label96);
            tabWheelTrack.Controls.Add(button7);
            tabWheelTrack.Controls.Add(label94);
            tabWheelTrack.Controls.Add(button8);
            tabWheelTrack.Location = new System.Drawing.Point(4, 19);
            tabWheelTrack.Name = "tabWheelTrack";
            tabWheelTrack.Size = new System.Drawing.Size(655, 348);
            tabWheelTrack.TabIndex = 38;
            tabWheelTrack.Text = "Track";
            // 
            // label118
            // 
            label118.BackColor = System.Drawing.Color.White;
            label118.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label118.ForeColor = System.Drawing.Color.Black;
            label118.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label118.Location = new System.Drawing.Point(2, 6);
            label118.Name = "label118";
            label118.Size = new System.Drawing.Size(294, 335);
            label118.TabIndex = 545;
            label118.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nudVehicleTrack
            // 
            nudVehicleTrack.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            nudVehicleTrack.BackColor = System.Drawing.Color.AliceBlue;
            nudVehicleTrack.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            nudVehicleTrack.InterceptArrowKeys = false;
            nudVehicleTrack.Location = new System.Drawing.Point(423, 185);
            nudVehicleTrack.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            nudVehicleTrack.Name = "nudVehicleTrack";
            nudVehicleTrack.ReadOnly = true;
            nudVehicleTrack.Size = new System.Drawing.Size(157, 65);
            nudVehicleTrack.TabIndex = 537;
            nudVehicleTrack.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudVehicleTrack.Value = new decimal(new int[] { 333, 0, 0, 0 });
            nudVehicleTrack.Click += nudVehicleTrack_Click;
            // 
            // label95
            // 
            label95.BackColor = System.Drawing.Color.Linen;
            label95.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label95.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label95.ForeColor = System.Drawing.Color.Black;
            label95.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label95.Location = new System.Drawing.Point(380, 144);
            label95.Name = "label95";
            label95.Size = new System.Drawing.Size(255, 131);
            label95.TabIndex = 538;
            label95.Text = "Set Track Width";
            label95.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label96
            // 
            label96.BackColor = System.Drawing.Color.White;
            label96.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label96.ForeColor = System.Drawing.Color.Black;
            label96.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label96.Location = new System.Drawing.Point(300, 20);
            label96.Name = "label96";
            label96.Size = new System.Drawing.Size(57, 80);
            label96.TabIndex = 544;
            label96.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button7
            // 
            button7.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            button7.BackColor = System.Drawing.Color.Transparent;
            button7.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button7.Font = new System.Drawing.Font("Tahoma", 14.25F);
            button7.Image = Properties.Resources.Previous;
            button7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            button7.Location = new System.Drawing.Point(486, 269);
            button7.Name = "button7";
            button7.Size = new System.Drawing.Size(72, 72);
            button7.TabIndex = 542;
            button7.UseVisualStyleBackColor = false;
            button7.Click += btnPrev_Click;
            // 
            // label94
            // 
            label94.AutoSize = true;
            label94.BackColor = System.Drawing.Color.Transparent;
            label94.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label94.ForeColor = System.Drawing.Color.Black;
            label94.Location = new System.Drawing.Point(6, 6);
            label94.Name = "label94";
            label94.Size = new System.Drawing.Size(142, 25);
            label94.TabIndex = 541;
            label94.Text = "Wheel Track";
            label94.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button8
            // 
            button8.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            button8.BackColor = System.Drawing.Color.Transparent;
            button8.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button8.Font = new System.Drawing.Font("Tahoma", 14.25F);
            button8.Image = Properties.Resources.Next;
            button8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            button8.Location = new System.Drawing.Point(577, 269);
            button8.Name = "button8";
            button8.Size = new System.Drawing.Size(72, 72);
            button8.TabIndex = 540;
            button8.UseVisualStyleBackColor = false;
            button8.Click += btnOkNext_Click;
            // 
            // tabAntennaDistance
            // 
            tabAntennaDistance.BackColor = System.Drawing.Color.White;
            tabAntennaDistance.BackgroundImage = Properties.Resources.AntennaTractor;
            tabAntennaDistance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            tabAntennaDistance.Controls.Add(label100);
            tabAntennaDistance.Controls.Add(button9);
            tabAntennaDistance.Controls.Add(label98);
            tabAntennaDistance.Controls.Add(nudAntennaPivot);
            tabAntennaDistance.Controls.Add(button10);
            tabAntennaDistance.Controls.Add(label99);
            tabAntennaDistance.Location = new System.Drawing.Point(4, 19);
            tabAntennaDistance.Name = "tabAntennaDistance";
            tabAntennaDistance.Size = new System.Drawing.Size(655, 348);
            tabAntennaDistance.TabIndex = 39;
            tabAntennaDistance.Text = "AntDist";
            // 
            // label100
            // 
            label100.BackColor = System.Drawing.Color.White;
            label100.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label100.ForeColor = System.Drawing.Color.Black;
            label100.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label100.Location = new System.Drawing.Point(315, 0);
            label100.Name = "label100";
            label100.Size = new System.Drawing.Size(151, 68);
            label100.TabIndex = 545;
            label100.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button9
            // 
            button9.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            button9.BackColor = System.Drawing.Color.Transparent;
            button9.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button9.Font = new System.Drawing.Font("Tahoma", 14.25F);
            button9.Image = Properties.Resources.Previous;
            button9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            button9.Location = new System.Drawing.Point(486, 269);
            button9.Name = "button9";
            button9.Size = new System.Drawing.Size(72, 72);
            button9.TabIndex = 542;
            button9.UseVisualStyleBackColor = false;
            button9.Click += btnPrev_Click;
            // 
            // label98
            // 
            label98.AutoSize = true;
            label98.BackColor = System.Drawing.Color.Transparent;
            label98.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label98.ForeColor = System.Drawing.Color.Black;
            label98.Location = new System.Drawing.Point(6, 6);
            label98.Name = "label98";
            label98.Size = new System.Drawing.Size(99, 50);
            label98.TabIndex = 541;
            label98.Text = "Antenna\r\nPosition";
            label98.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudAntennaPivot
            // 
            nudAntennaPivot.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            nudAntennaPivot.BackColor = System.Drawing.Color.AliceBlue;
            nudAntennaPivot.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            nudAntennaPivot.InterceptArrowKeys = false;
            nudAntennaPivot.Location = new System.Drawing.Point(230, 226);
            nudAntennaPivot.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            nudAntennaPivot.Minimum = new decimal(new int[] { 999, 0, 0, int.MinValue });
            nudAntennaPivot.Name = "nudAntennaPivot";
            nudAntennaPivot.ReadOnly = true;
            nudAntennaPivot.Size = new System.Drawing.Size(165, 65);
            nudAntennaPivot.TabIndex = 537;
            nudAntennaPivot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudAntennaPivot.Value = new decimal(new int[] { 333, 0, 0, 0 });
            nudAntennaPivot.Click += nudAntennaPivot_Click;
            // 
            // button10
            // 
            button10.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            button10.BackColor = System.Drawing.Color.Transparent;
            button10.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            button10.FlatAppearance.BorderSize = 0;
            button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button10.Font = new System.Drawing.Font("Tahoma", 14.25F);
            button10.Image = Properties.Resources.Next;
            button10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            button10.Location = new System.Drawing.Point(577, 269);
            button10.Name = "button10";
            button10.Size = new System.Drawing.Size(72, 72);
            button10.TabIndex = 540;
            button10.UseVisualStyleBackColor = false;
            button10.Click += btnOkNext_Click;
            // 
            // label99
            // 
            label99.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label99.BackColor = System.Drawing.Color.Linen;
            label99.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label99.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label99.ForeColor = System.Drawing.Color.Black;
            label99.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label99.Location = new System.Drawing.Point(133, 155);
            label99.Name = "label99";
            label99.Size = new System.Drawing.Size(352, 185);
            label99.TabIndex = 538;
            label99.Text = "Set Distance Antenna Is From Pivot Axle";
            label99.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabAntennaHeight
            // 
            tabAntennaHeight.BackColor = System.Drawing.Color.White;
            tabAntennaHeight.BackgroundImage = Properties.Resources.AntennaTractor;
            tabAntennaHeight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            tabAntennaHeight.Controls.Add(label114);
            tabAntennaHeight.Controls.Add(label97);
            tabAntennaHeight.Controls.Add(button13);
            tabAntennaHeight.Controls.Add(label92);
            tabAntennaHeight.Controls.Add(nudAntennaHeight);
            tabAntennaHeight.Controls.Add(label93);
            tabAntennaHeight.Controls.Add(button14);
            tabAntennaHeight.Location = new System.Drawing.Point(4, 19);
            tabAntennaHeight.Name = "tabAntennaHeight";
            tabAntennaHeight.Size = new System.Drawing.Size(655, 348);
            tabAntennaHeight.TabIndex = 41;
            tabAntennaHeight.Text = "AntHigh";
            // 
            // label114
            // 
            label114.BackColor = System.Drawing.Color.White;
            label114.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label114.ForeColor = System.Drawing.Color.Black;
            label114.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label114.Location = new System.Drawing.Point(163, 0);
            label114.Name = "label114";
            label114.Size = new System.Drawing.Size(162, 24);
            label114.TabIndex = 545;
            label114.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label97
            // 
            label97.BackColor = System.Drawing.Color.White;
            label97.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label97.ForeColor = System.Drawing.Color.Black;
            label97.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label97.Location = new System.Drawing.Point(109, 185);
            label97.Name = "label97";
            label97.Size = new System.Drawing.Size(371, 163);
            label97.TabIndex = 544;
            label97.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button13
            // 
            button13.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            button13.BackColor = System.Drawing.Color.Transparent;
            button13.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            button13.FlatAppearance.BorderSize = 0;
            button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button13.Font = new System.Drawing.Font("Tahoma", 14.25F);
            button13.Image = Properties.Resources.Previous;
            button13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            button13.Location = new System.Drawing.Point(486, 269);
            button13.Name = "button13";
            button13.Size = new System.Drawing.Size(72, 72);
            button13.TabIndex = 542;
            button13.UseVisualStyleBackColor = false;
            button13.Click += btnPrev_Click;
            // 
            // label92
            // 
            label92.AutoSize = true;
            label92.BackColor = System.Drawing.Color.Transparent;
            label92.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label92.ForeColor = System.Drawing.Color.Black;
            label92.Location = new System.Drawing.Point(6, 6);
            label92.Name = "label92";
            label92.Size = new System.Drawing.Size(99, 50);
            label92.TabIndex = 541;
            label92.Text = "Antenna\r\nHeight";
            label92.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudAntennaHeight
            // 
            nudAntennaHeight.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            nudAntennaHeight.BackColor = System.Drawing.Color.AliceBlue;
            nudAntennaHeight.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            nudAntennaHeight.InterceptArrowKeys = false;
            nudAntennaHeight.Location = new System.Drawing.Point(465, 87);
            nudAntennaHeight.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            nudAntennaHeight.Name = "nudAntennaHeight";
            nudAntennaHeight.ReadOnly = true;
            nudAntennaHeight.Size = new System.Drawing.Size(145, 65);
            nudAntennaHeight.TabIndex = 537;
            nudAntennaHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudAntennaHeight.Value = new decimal(new int[] { 333, 0, 0, 0 });
            nudAntennaHeight.Click += nudAntennaHeight_Click;
            // 
            // label93
            // 
            label93.BackColor = System.Drawing.Color.Linen;
            label93.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label93.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label93.ForeColor = System.Drawing.Color.Black;
            label93.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label93.Location = new System.Drawing.Point(436, 12);
            label93.Name = "label93";
            label93.Size = new System.Drawing.Size(198, 173);
            label93.TabIndex = 538;
            label93.Text = "Set Antenna Height";
            label93.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button14
            // 
            button14.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            button14.BackColor = System.Drawing.Color.Transparent;
            button14.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            button14.FlatAppearance.BorderSize = 0;
            button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button14.Font = new System.Drawing.Font("Tahoma", 14.25F);
            button14.Image = Properties.Resources.Next;
            button14.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            button14.Location = new System.Drawing.Point(577, 269);
            button14.Name = "button14";
            button14.Size = new System.Drawing.Size(72, 72);
            button14.TabIndex = 540;
            button14.UseVisualStyleBackColor = false;
            button14.Click += btnOkNext_Click;
            // 
            // tabAntennaOffset
            // 
            tabAntennaOffset.BackColor = System.Drawing.Color.White;
            tabAntennaOffset.BackgroundImage = Properties.Resources.AntennaTractor;
            tabAntennaOffset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            tabAntennaOffset.Controls.Add(button11);
            tabAntennaOffset.Controls.Add(label102);
            tabAntennaOffset.Controls.Add(nudAntennaOffset);
            tabAntennaOffset.Controls.Add(label104);
            tabAntennaOffset.Controls.Add(button12);
            tabAntennaOffset.Controls.Add(label103);
            tabAntennaOffset.Location = new System.Drawing.Point(4, 19);
            tabAntennaOffset.Name = "tabAntennaOffset";
            tabAntennaOffset.Size = new System.Drawing.Size(655, 348);
            tabAntennaOffset.TabIndex = 40;
            tabAntennaOffset.Text = "AntOff";
            // 
            // button11
            // 
            button11.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            button11.BackColor = System.Drawing.Color.Transparent;
            button11.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            button11.FlatAppearance.BorderSize = 0;
            button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button11.Font = new System.Drawing.Font("Tahoma", 14.25F);
            button11.Image = Properties.Resources.Previous;
            button11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            button11.Location = new System.Drawing.Point(485, 269);
            button11.Name = "button11";
            button11.Size = new System.Drawing.Size(72, 72);
            button11.TabIndex = 542;
            button11.UseVisualStyleBackColor = false;
            button11.Click += btnPrev_Click;
            // 
            // label102
            // 
            label102.AutoSize = true;
            label102.BackColor = System.Drawing.Color.Transparent;
            label102.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label102.ForeColor = System.Drawing.Color.Black;
            label102.Location = new System.Drawing.Point(0, 6);
            label102.Name = "label102";
            label102.Size = new System.Drawing.Size(169, 25);
            label102.TabIndex = 541;
            label102.Text = "Antenna Offset";
            label102.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nudAntennaOffset
            // 
            nudAntennaOffset.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            nudAntennaOffset.BackColor = System.Drawing.Color.AliceBlue;
            nudAntennaOffset.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            nudAntennaOffset.InterceptArrowKeys = false;
            nudAntennaOffset.Location = new System.Drawing.Point(250, 65);
            nudAntennaOffset.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            nudAntennaOffset.Minimum = new decimal(new int[] { 999, 0, 0, int.MinValue });
            nudAntennaOffset.Name = "nudAntennaOffset";
            nudAntennaOffset.ReadOnly = true;
            nudAntennaOffset.Size = new System.Drawing.Size(165, 65);
            nudAntennaOffset.TabIndex = 537;
            nudAntennaOffset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudAntennaOffset.Value = new decimal(new int[] { 333, 0, 0, 0 });
            nudAntennaOffset.Click += nudAntennaOffset_Click;
            // 
            // label104
            // 
            label104.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label104.AutoSize = true;
            label104.BackColor = System.Drawing.Color.Transparent;
            label104.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label104.ForeColor = System.Drawing.Color.Black;
            label104.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label104.Location = new System.Drawing.Point(471, 247);
            label104.Name = "label104";
            label104.Size = new System.Drawing.Size(86, 25);
            label104.TabIndex = 539;
            label104.Text = "0 = Off";
            label104.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // button12
            // 
            button12.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            button12.BackColor = System.Drawing.Color.Transparent;
            button12.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            button12.FlatAppearance.BorderSize = 0;
            button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button12.Font = new System.Drawing.Font("Tahoma", 14.25F);
            button12.Image = Properties.Resources.Next;
            button12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            button12.Location = new System.Drawing.Point(576, 269);
            button12.Name = "button12";
            button12.Size = new System.Drawing.Size(72, 72);
            button12.TabIndex = 540;
            button12.UseVisualStyleBackColor = false;
            button12.Click += btnOkNext_Click;
            // 
            // label103
            // 
            label103.BackColor = System.Drawing.Color.Linen;
            label103.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label103.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label103.ForeColor = System.Drawing.Color.Black;
            label103.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label103.Location = new System.Drawing.Point(171, 1);
            label103.Name = "label103";
            label103.Size = new System.Drawing.Size(313, 187);
            label103.TabIndex = 538;
            label103.Text = "Set Antenna Offset";
            label103.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabButtonSwitch
            // 
            tabButtonSwitch.BackColor = System.Drawing.Color.White;
            tabButtonSwitch.Controls.Add(button15);
            tabButtonSwitch.Controls.Add(label53);
            tabButtonSwitch.Controls.Add(cboxSteerEnable);
            tabButtonSwitch.Controls.Add(label28);
            tabButtonSwitch.Controls.Add(label62);
            tabButtonSwitch.Controls.Add(btnOkNext_ButtonSwitch);
            tabButtonSwitch.Location = new System.Drawing.Point(4, 19);
            tabButtonSwitch.Name = "tabButtonSwitch";
            tabButtonSwitch.Size = new System.Drawing.Size(655, 348);
            tabButtonSwitch.TabIndex = 19;
            tabButtonSwitch.Text = "ButtonSwitch";
            // 
            // button15
            // 
            button15.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            button15.BackColor = System.Drawing.Color.Transparent;
            button15.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            button15.FlatAppearance.BorderSize = 0;
            button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button15.Font = new System.Drawing.Font("Tahoma", 14.25F);
            button15.Image = Properties.Resources.Previous;
            button15.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            button15.Location = new System.Drawing.Point(485, 269);
            button15.Name = "button15";
            button15.Size = new System.Drawing.Size(72, 72);
            button15.TabIndex = 544;
            button15.UseVisualStyleBackColor = false;
            button15.Click += btnPrev_Click;
            // 
            // label53
            // 
            label53.AutoSize = true;
            label53.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label53.ForeColor = System.Drawing.Color.Black;
            label53.Location = new System.Drawing.Point(5, 4);
            label53.Name = "label53";
            label53.Size = new System.Drawing.Size(144, 25);
            label53.TabIndex = 533;
            label53.Text = "Steer Switch";
            label53.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnOkNext_ButtonSwitch
            // 
            btnOkNext_ButtonSwitch.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnOkNext_ButtonSwitch.BackColor = System.Drawing.Color.Transparent;
            btnOkNext_ButtonSwitch.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            btnOkNext_ButtonSwitch.FlatAppearance.BorderSize = 0;
            btnOkNext_ButtonSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnOkNext_ButtonSwitch.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnOkNext_ButtonSwitch.Image = Properties.Resources.Next;
            btnOkNext_ButtonSwitch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnOkNext_ButtonSwitch.Location = new System.Drawing.Point(576, 269);
            btnOkNext_ButtonSwitch.Name = "btnOkNext_ButtonSwitch";
            btnOkNext_ButtonSwitch.Size = new System.Drawing.Size(72, 72);
            btnOkNext_ButtonSwitch.TabIndex = 525;
            btnOkNext_ButtonSwitch.UseVisualStyleBackColor = false;
            btnOkNext_ButtonSwitch.Click += btnOkNext_Click;
            // 
            // tabA2DConv
            // 
            tabA2DConv.BackColor = System.Drawing.Color.White;
            tabA2DConv.Controls.Add(btnPrev_A2D);
            tabA2DConv.Controls.Add(label52);
            tabA2DConv.Controls.Add(cboxConv);
            tabA2DConv.Controls.Add(label64);
            tabA2DConv.Controls.Add(btnOkNext_A2D);
            tabA2DConv.Location = new System.Drawing.Point(4, 19);
            tabA2DConv.Name = "tabA2DConv";
            tabA2DConv.Size = new System.Drawing.Size(655, 348);
            tabA2DConv.TabIndex = 27;
            tabA2DConv.Text = "A2DConv";
            // 
            // btnPrev_A2D
            // 
            btnPrev_A2D.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnPrev_A2D.BackColor = System.Drawing.Color.Transparent;
            btnPrev_A2D.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            btnPrev_A2D.FlatAppearance.BorderSize = 0;
            btnPrev_A2D.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPrev_A2D.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnPrev_A2D.Image = Properties.Resources.Previous;
            btnPrev_A2D.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnPrev_A2D.Location = new System.Drawing.Point(485, 269);
            btnPrev_A2D.Name = "btnPrev_A2D";
            btnPrev_A2D.Size = new System.Drawing.Size(72, 72);
            btnPrev_A2D.TabIndex = 537;
            btnPrev_A2D.UseVisualStyleBackColor = false;
            btnPrev_A2D.Click += btnPrev_Click;
            // 
            // label52
            // 
            label52.AutoSize = true;
            label52.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label52.ForeColor = System.Drawing.Color.Black;
            label52.Location = new System.Drawing.Point(5, 4);
            label52.Name = "label52";
            label52.Size = new System.Drawing.Size(164, 25);
            label52.TabIndex = 533;
            label52.Text = "A/D Convertor";
            label52.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnOkNext_A2D
            // 
            btnOkNext_A2D.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnOkNext_A2D.BackColor = System.Drawing.Color.Transparent;
            btnOkNext_A2D.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            btnOkNext_A2D.FlatAppearance.BorderSize = 0;
            btnOkNext_A2D.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnOkNext_A2D.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnOkNext_A2D.Image = Properties.Resources.Next;
            btnOkNext_A2D.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnOkNext_A2D.Location = new System.Drawing.Point(576, 269);
            btnOkNext_A2D.Name = "btnOkNext_A2D";
            btnOkNext_A2D.Size = new System.Drawing.Size(72, 72);
            btnOkNext_A2D.TabIndex = 527;
            btnOkNext_A2D.UseVisualStyleBackColor = false;
            btnOkNext_A2D.Click += btnOkNext_Click;
            // 
            // tabMotorDriver
            // 
            tabMotorDriver.BackColor = System.Drawing.Color.White;
            tabMotorDriver.Controls.Add(btnPrev_MotorDriver);
            tabMotorDriver.Controls.Add(label43);
            tabMotorDriver.Controls.Add(cboxMotorDrive);
            tabMotorDriver.Controls.Add(label63);
            tabMotorDriver.Controls.Add(btnOkNext_MotorDriver);
            tabMotorDriver.Location = new System.Drawing.Point(4, 19);
            tabMotorDriver.Name = "tabMotorDriver";
            tabMotorDriver.Size = new System.Drawing.Size(655, 348);
            tabMotorDriver.TabIndex = 16;
            tabMotorDriver.Text = "MotorDriver";
            // 
            // btnPrev_MotorDriver
            // 
            btnPrev_MotorDriver.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnPrev_MotorDriver.BackColor = System.Drawing.Color.Transparent;
            btnPrev_MotorDriver.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            btnPrev_MotorDriver.FlatAppearance.BorderSize = 0;
            btnPrev_MotorDriver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPrev_MotorDriver.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnPrev_MotorDriver.Image = Properties.Resources.Previous;
            btnPrev_MotorDriver.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnPrev_MotorDriver.Location = new System.Drawing.Point(485, 269);
            btnPrev_MotorDriver.Name = "btnPrev_MotorDriver";
            btnPrev_MotorDriver.Size = new System.Drawing.Size(72, 72);
            btnPrev_MotorDriver.TabIndex = 537;
            btnPrev_MotorDriver.UseVisualStyleBackColor = false;
            btnPrev_MotorDriver.Click += btnPrev_Click;
            // 
            // label43
            // 
            label43.AutoSize = true;
            label43.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label43.ForeColor = System.Drawing.Color.Black;
            label43.Location = new System.Drawing.Point(4, 4);
            label43.Name = "label43";
            label43.Size = new System.Drawing.Size(213, 25);
            label43.TabIndex = 532;
            label43.Text = "Motor Driver Board";
            label43.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnOkNext_MotorDriver
            // 
            btnOkNext_MotorDriver.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnOkNext_MotorDriver.BackColor = System.Drawing.Color.Transparent;
            btnOkNext_MotorDriver.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            btnOkNext_MotorDriver.FlatAppearance.BorderSize = 0;
            btnOkNext_MotorDriver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnOkNext_MotorDriver.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnOkNext_MotorDriver.Image = Properties.Resources.Next;
            btnOkNext_MotorDriver.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnOkNext_MotorDriver.Location = new System.Drawing.Point(576, 269);
            btnOkNext_MotorDriver.Name = "btnOkNext_MotorDriver";
            btnOkNext_MotorDriver.Size = new System.Drawing.Size(72, 72);
            btnOkNext_MotorDriver.TabIndex = 526;
            btnOkNext_MotorDriver.UseVisualStyleBackColor = false;
            btnOkNext_MotorDriver.Click += btnOkNext_Click;
            // 
            // tabInvertRelays
            // 
            tabInvertRelays.BackColor = System.Drawing.Color.White;
            tabInvertRelays.Controls.Add(label59);
            tabInvertRelays.Controls.Add(btnPrev_InvertRelays);
            tabInvertRelays.Controls.Add(label51);
            tabInvertRelays.Controls.Add(label29);
            tabInvertRelays.Controls.Add(btnOkNext_InvertRelays);
            tabInvertRelays.Controls.Add(chkSteerInvertRelays);
            tabInvertRelays.Location = new System.Drawing.Point(4, 19);
            tabInvertRelays.Name = "tabInvertRelays";
            tabInvertRelays.Size = new System.Drawing.Size(655, 348);
            tabInvertRelays.TabIndex = 29;
            tabInvertRelays.Text = "InvertRelays";
            // 
            // label59
            // 
            label59.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label59.AutoSize = true;
            label59.BackColor = System.Drawing.Color.Transparent;
            label59.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label59.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label59.Location = new System.Drawing.Point(282, 236);
            label59.Name = "label59";
            label59.Size = new System.Drawing.Size(95, 16);
            label59.TabIndex = 539;
            label59.Text = "Invert Relays";
            label59.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnPrev_InvertRelays
            // 
            btnPrev_InvertRelays.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnPrev_InvertRelays.BackColor = System.Drawing.Color.Transparent;
            btnPrev_InvertRelays.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            btnPrev_InvertRelays.FlatAppearance.BorderSize = 0;
            btnPrev_InvertRelays.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPrev_InvertRelays.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnPrev_InvertRelays.Image = Properties.Resources.Previous;
            btnPrev_InvertRelays.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnPrev_InvertRelays.Location = new System.Drawing.Point(485, 269);
            btnPrev_InvertRelays.Name = "btnPrev_InvertRelays";
            btnPrev_InvertRelays.Size = new System.Drawing.Size(72, 72);
            btnPrev_InvertRelays.TabIndex = 537;
            btnPrev_InvertRelays.UseVisualStyleBackColor = false;
            btnPrev_InvertRelays.Click += btnPrev_Click;
            // 
            // label51
            // 
            label51.AutoSize = true;
            label51.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label51.ForeColor = System.Drawing.Color.Black;
            label51.Location = new System.Drawing.Point(5, 4);
            label51.Name = "label51";
            label51.Size = new System.Drawing.Size(223, 25);
            label51.TabIndex = 533;
            label51.Text = "Driver Control Relay";
            label51.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnOkNext_InvertRelays
            // 
            btnOkNext_InvertRelays.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnOkNext_InvertRelays.BackColor = System.Drawing.Color.Transparent;
            btnOkNext_InvertRelays.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            btnOkNext_InvertRelays.FlatAppearance.BorderSize = 0;
            btnOkNext_InvertRelays.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnOkNext_InvertRelays.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnOkNext_InvertRelays.Image = Properties.Resources.Next;
            btnOkNext_InvertRelays.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnOkNext_InvertRelays.Location = new System.Drawing.Point(576, 269);
            btnOkNext_InvertRelays.Name = "btnOkNext_InvertRelays";
            btnOkNext_InvertRelays.Size = new System.Drawing.Size(72, 72);
            btnOkNext_InvertRelays.TabIndex = 528;
            btnOkNext_InvertRelays.UseVisualStyleBackColor = false;
            btnOkNext_InvertRelays.Click += btnOkNext_Click;
            // 
            // chkSteerInvertRelays
            // 
            chkSteerInvertRelays.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            chkSteerInvertRelays.Appearance = System.Windows.Forms.Appearance.Button;
            chkSteerInvertRelays.BackColor = System.Drawing.Color.AliceBlue;
            chkSteerInvertRelays.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            chkSteerInvertRelays.FlatAppearance.CheckedBackColor = System.Drawing.Color.MediumAquamarine;
            chkSteerInvertRelays.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            chkSteerInvertRelays.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            chkSteerInvertRelays.ForeColor = System.Drawing.SystemColors.ControlText;
            chkSteerInvertRelays.Image = Properties.Resources.ConSt_InvertRelay;
            chkSteerInvertRelays.Location = new System.Drawing.Point(274, 155);
            chkSteerInvertRelays.Name = "chkSteerInvertRelays";
            chkSteerInvertRelays.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            chkSteerInvertRelays.Size = new System.Drawing.Size(109, 78);
            chkSteerInvertRelays.TabIndex = 503;
            chkSteerInvertRelays.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            chkSteerInvertRelays.UseVisualStyleBackColor = false;
            chkSteerInvertRelays.CheckedChanged += chkSteerInvertRelays_CheckedChanged;
            // 
            // tabDanfoss
            // 
            tabDanfoss.BackColor = System.Drawing.Color.White;
            tabDanfoss.Controls.Add(btnPrev_Danfoss);
            tabDanfoss.Controls.Add(label50);
            tabDanfoss.Controls.Add(label55);
            tabDanfoss.Controls.Add(btnOkNext_Danfoss);
            tabDanfoss.Controls.Add(cboxDanfoss);
            tabDanfoss.Location = new System.Drawing.Point(4, 19);
            tabDanfoss.Name = "tabDanfoss";
            tabDanfoss.Size = new System.Drawing.Size(655, 348);
            tabDanfoss.TabIndex = 28;
            tabDanfoss.Text = "Danfoss";
            // 
            // btnPrev_Danfoss
            // 
            btnPrev_Danfoss.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnPrev_Danfoss.BackColor = System.Drawing.Color.Transparent;
            btnPrev_Danfoss.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            btnPrev_Danfoss.FlatAppearance.BorderSize = 0;
            btnPrev_Danfoss.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPrev_Danfoss.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnPrev_Danfoss.Image = Properties.Resources.Previous;
            btnPrev_Danfoss.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnPrev_Danfoss.Location = new System.Drawing.Point(485, 269);
            btnPrev_Danfoss.Name = "btnPrev_Danfoss";
            btnPrev_Danfoss.Size = new System.Drawing.Size(72, 72);
            btnPrev_Danfoss.TabIndex = 537;
            btnPrev_Danfoss.UseVisualStyleBackColor = false;
            btnPrev_Danfoss.Click += btnPrev_Click;
            // 
            // label50
            // 
            label50.AutoSize = true;
            label50.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label50.ForeColor = System.Drawing.Color.Black;
            label50.Location = new System.Drawing.Point(5, 4);
            label50.Name = "label50";
            label50.Size = new System.Drawing.Size(160, 25);
            label50.TabIndex = 533;
            label50.Text = "Danfoss Valve";
            label50.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnOkNext_Danfoss
            // 
            btnOkNext_Danfoss.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnOkNext_Danfoss.BackColor = System.Drawing.Color.Transparent;
            btnOkNext_Danfoss.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            btnOkNext_Danfoss.FlatAppearance.BorderSize = 0;
            btnOkNext_Danfoss.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnOkNext_Danfoss.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnOkNext_Danfoss.Image = Properties.Resources.Next;
            btnOkNext_Danfoss.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnOkNext_Danfoss.Location = new System.Drawing.Point(576, 269);
            btnOkNext_Danfoss.Name = "btnOkNext_Danfoss";
            btnOkNext_Danfoss.Size = new System.Drawing.Size(72, 72);
            btnOkNext_Danfoss.TabIndex = 528;
            btnOkNext_Danfoss.UseVisualStyleBackColor = false;
            btnOkNext_Danfoss.Click += btnOkNext_Click;
            // 
            // cboxDanfoss
            // 
            cboxDanfoss.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            cboxDanfoss.Appearance = System.Windows.Forms.Appearance.Button;
            cboxDanfoss.BackColor = System.Drawing.Color.AliceBlue;
            cboxDanfoss.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            cboxDanfoss.FlatAppearance.CheckedBackColor = System.Drawing.Color.MediumAquamarine;
            cboxDanfoss.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboxDanfoss.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cboxDanfoss.ForeColor = System.Drawing.SystemColors.ControlText;
            cboxDanfoss.Image = Properties.Resources.ConSt_Danfoss;
            cboxDanfoss.Location = new System.Drawing.Point(274, 155);
            cboxDanfoss.Name = "cboxDanfoss";
            cboxDanfoss.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            cboxDanfoss.Size = new System.Drawing.Size(114, 78);
            cboxDanfoss.TabIndex = 507;
            cboxDanfoss.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            cboxDanfoss.UseVisualStyleBackColor = false;
            cboxDanfoss.CheckedChanged += cboxDanfoss_CheckedChanged;
            // 
            // tabRollInv
            // 
            tabRollInv.BackColor = System.Drawing.Color.White;
            tabRollInv.Controls.Add(label115);
            tabRollInv.Controls.Add(lblRoll);
            tabRollInv.Controls.Add(pictureBox9);
            tabRollInv.Controls.Add(cboxDataInvertRoll);
            tabRollInv.Controls.Add(label36);
            tabRollInv.Controls.Add(button4);
            tabRollInv.Controls.Add(label46);
            tabRollInv.Controls.Add(button18);
            tabRollInv.Controls.Add(label107);
            tabRollInv.Location = new System.Drawing.Point(4, 19);
            tabRollInv.Name = "tabRollInv";
            tabRollInv.Size = new System.Drawing.Size(655, 348);
            tabRollInv.TabIndex = 42;
            tabRollInv.Text = "RollInv";
            // 
            // label115
            // 
            label115.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label115.BackColor = System.Drawing.Color.Transparent;
            label115.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label115.ForeColor = System.Drawing.Color.Black;
            label115.Location = new System.Drawing.Point(139, 105);
            label115.Name = "label115";
            label115.Size = new System.Drawing.Size(268, 56);
            label115.TabIndex = 552;
            label115.Text = "If not Select Invert Roll";
            label115.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRoll
            // 
            lblRoll.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblRoll.BackColor = System.Drawing.Color.Transparent;
            lblRoll.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblRoll.ForeColor = System.Drawing.Color.Black;
            lblRoll.Location = new System.Drawing.Point(274, 274);
            lblRoll.Name = "lblRoll";
            lblRoll.Size = new System.Drawing.Size(100, 31);
            lblRoll.TabIndex = 532;
            lblRoll.Text = "-55.5";
            lblRoll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox9
            // 
            pictureBox9.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            pictureBox9.BackgroundImage = Properties.Resources.ConD_RollHelper;
            pictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            pictureBox9.Location = new System.Drawing.Point(486, 38);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new System.Drawing.Size(154, 217);
            pictureBox9.TabIndex = 550;
            pictureBox9.TabStop = false;
            // 
            // cboxDataInvertRoll
            // 
            cboxDataInvertRoll.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            cboxDataInvertRoll.Appearance = System.Windows.Forms.Appearance.Button;
            cboxDataInvertRoll.BackColor = System.Drawing.Color.WhiteSmoke;
            cboxDataInvertRoll.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            cboxDataInvertRoll.FlatAppearance.CheckedBackColor = System.Drawing.Color.MediumAquamarine;
            cboxDataInvertRoll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboxDataInvertRoll.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cboxDataInvertRoll.ForeColor = System.Drawing.Color.Black;
            cboxDataInvertRoll.Image = Properties.Resources.ConDa_InvertRoll;
            cboxDataInvertRoll.Location = new System.Drawing.Point(218, 169);
            cboxDataInvertRoll.Name = "cboxDataInvertRoll";
            cboxDataInvertRoll.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            cboxDataInvertRoll.Size = new System.Drawing.Size(130, 95);
            cboxDataInvertRoll.TabIndex = 549;
            cboxDataInvertRoll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            cboxDataInvertRoll.UseVisualStyleBackColor = false;
            cboxDataInvertRoll.Click += cboxDataInvertRoll_Click;
            // 
            // label36
            // 
            label36.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label36.BackColor = System.Drawing.Color.Transparent;
            label36.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label36.ForeColor = System.Drawing.Color.Black;
            label36.Location = new System.Drawing.Point(64, 50);
            label36.Name = "label36";
            label36.Size = new System.Drawing.Size(401, 56);
            label36.TabIndex = 545;
            label36.Text = "Put vehicle leaning strongly to the right. Roll to the right must be POSITIVE.";
            label36.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button4
            // 
            button4.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            button4.BackColor = System.Drawing.Color.Transparent;
            button4.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button4.Font = new System.Drawing.Font("Tahoma", 14.25F);
            button4.Image = Properties.Resources.Previous;
            button4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            button4.Location = new System.Drawing.Point(486, 270);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(72, 72);
            button4.TabIndex = 544;
            button4.UseVisualStyleBackColor = false;
            button4.Click += btnPrev_Click;
            // 
            // label46
            // 
            label46.AutoSize = true;
            label46.BackColor = System.Drawing.Color.Transparent;
            label46.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label46.ForeColor = System.Drawing.Color.Black;
            label46.Location = new System.Drawing.Point(6, 6);
            label46.Name = "label46";
            label46.Size = new System.Drawing.Size(148, 25);
            label46.TabIndex = 543;
            label46.Text = "Roll Function";
            label46.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button18
            // 
            button18.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            button18.BackColor = System.Drawing.Color.Transparent;
            button18.FlatAppearance.BorderColor = System.Drawing.Color.White;
            button18.FlatAppearance.BorderSize = 0;
            button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button18.Font = new System.Drawing.Font("Tahoma", 14.25F);
            button18.Image = Properties.Resources.Next;
            button18.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            button18.Location = new System.Drawing.Point(577, 270);
            button18.Name = "button18";
            button18.Size = new System.Drawing.Size(72, 72);
            button18.TabIndex = 542;
            button18.UseVisualStyleBackColor = false;
            button18.Click += btnOkNext_Click;
            // 
            // label107
            // 
            label107.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label107.BackColor = System.Drawing.Color.Transparent;
            label107.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label107.ForeColor = System.Drawing.Color.Black;
            label107.Location = new System.Drawing.Point(181, 274);
            label107.Name = "label107";
            label107.Size = new System.Drawing.Size(100, 31);
            label107.TabIndex = 551;
            label107.Text = "Roll:";
            label107.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabRollZero
            // 
            tabRollZero.BackColor = System.Drawing.Color.White;
            tabRollZero.Controls.Add(lblRoll2);
            tabRollZero.Controls.Add(label110);
            tabRollZero.Controls.Add(label47);
            tabRollZero.Controls.Add(label57);
            tabRollZero.Controls.Add(lblRollZeroOffset);
            tabRollZero.Controls.Add(btnZeroRoll);
            tabRollZero.Controls.Add(btnRemoveZeroOffset);
            tabRollZero.Controls.Add(label48);
            tabRollZero.Controls.Add(button3);
            tabRollZero.Controls.Add(label56);
            tabRollZero.Controls.Add(button19);
            tabRollZero.Location = new System.Drawing.Point(4, 19);
            tabRollZero.Name = "tabRollZero";
            tabRollZero.Size = new System.Drawing.Size(655, 348);
            tabRollZero.TabIndex = 44;
            tabRollZero.Text = "RollZero";
            // 
            // lblRoll2
            // 
            lblRoll2.BackColor = System.Drawing.Color.Transparent;
            lblRoll2.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblRoll2.ForeColor = System.Drawing.Color.Black;
            lblRoll2.Location = new System.Drawing.Point(274, 263);
            lblRoll2.Name = "lblRoll2";
            lblRoll2.Size = new System.Drawing.Size(100, 31);
            lblRoll2.TabIndex = 561;
            lblRoll2.Text = "-2.5";
            lblRoll2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label110
            // 
            label110.BackColor = System.Drawing.Color.Transparent;
            label110.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label110.ForeColor = System.Drawing.Color.Black;
            label110.Location = new System.Drawing.Point(181, 263);
            label110.Name = "label110";
            label110.Size = new System.Drawing.Size(100, 31);
            label110.TabIndex = 562;
            label110.Text = "Roll:";
            label110.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label47
            // 
            label47.AutoSize = true;
            label47.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label47.ForeColor = System.Drawing.Color.Black;
            label47.Location = new System.Drawing.Point(334, 117);
            label47.Name = "label47";
            label47.Size = new System.Drawing.Size(57, 13);
            label47.TabIndex = 560;
            label47.Text = "Zero Roll";
            // 
            // label57
            // 
            label57.AutoSize = true;
            label57.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label57.ForeColor = System.Drawing.Color.Black;
            label57.Location = new System.Drawing.Point(111, 117);
            label57.Name = "label57";
            label57.Size = new System.Drawing.Size(91, 13);
            label57.TabIndex = 559;
            label57.Text = "Remove Offset";
            // 
            // lblRollZeroOffset
            // 
            lblRollZeroOffset.AutoSize = true;
            lblRollZeroOffset.Font = new System.Drawing.Font("Tahoma", 20.25F);
            lblRollZeroOffset.ForeColor = System.Drawing.Color.Black;
            lblRollZeroOffset.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            lblRollZeroOffset.Location = new System.Drawing.Point(469, 164);
            lblRollZeroOffset.Name = "lblRollZeroOffset";
            lblRollZeroOffset.Size = new System.Drawing.Size(87, 33);
            lblRollZeroOffset.TabIndex = 556;
            lblRollZeroOffset.Text = "Offset";
            // 
            // btnZeroRoll
            // 
            btnZeroRoll.BackColor = System.Drawing.Color.Transparent;
            btnZeroRoll.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            btnZeroRoll.FlatAppearance.CheckedBackColor = System.Drawing.Color.Teal;
            btnZeroRoll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnZeroRoll.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnZeroRoll.ForeColor = System.Drawing.Color.Black;
            btnZeroRoll.Image = Properties.Resources.ConDa_RollSetZero;
            btnZeroRoll.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnZeroRoll.Location = new System.Drawing.Point(326, 136);
            btnZeroRoll.Name = "btnZeroRoll";
            btnZeroRoll.Size = new System.Drawing.Size(130, 95);
            btnZeroRoll.TabIndex = 557;
            btnZeroRoll.UseVisualStyleBackColor = false;
            btnZeroRoll.Click += btnZeroRoll_Click;
            // 
            // btnRemoveZeroOffset
            // 
            btnRemoveZeroOffset.BackColor = System.Drawing.Color.Transparent;
            btnRemoveZeroOffset.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            btnRemoveZeroOffset.FlatAppearance.CheckedBackColor = System.Drawing.Color.Teal;
            btnRemoveZeroOffset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRemoveZeroOffset.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnRemoveZeroOffset.ForeColor = System.Drawing.Color.Black;
            btnRemoveZeroOffset.Image = Properties.Resources.ConDa_RemoveOffset;
            btnRemoveZeroOffset.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnRemoveZeroOffset.Location = new System.Drawing.Point(103, 136);
            btnRemoveZeroOffset.Name = "btnRemoveZeroOffset";
            btnRemoveZeroOffset.Size = new System.Drawing.Size(130, 95);
            btnRemoveZeroOffset.TabIndex = 558;
            btnRemoveZeroOffset.UseVisualStyleBackColor = false;
            btnRemoveZeroOffset.Click += btnRemoveZeroOffset_Click;
            // 
            // label48
            // 
            label48.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            label48.BackColor = System.Drawing.Color.Transparent;
            label48.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label48.ForeColor = System.Drawing.Color.Black;
            label48.Location = new System.Drawing.Point(69, 44);
            label48.Name = "label48";
            label48.Size = new System.Drawing.Size(484, 56);
            label48.TabIndex = 555;
            label48.Text = "Park on level surface and touch \"Zero Roll\"";
            label48.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            button3.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            button3.BackColor = System.Drawing.Color.Transparent;
            button3.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button3.Font = new System.Drawing.Font("Tahoma", 14.25F);
            button3.Image = Properties.Resources.Previous;
            button3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            button3.Location = new System.Drawing.Point(486, 270);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(72, 72);
            button3.TabIndex = 554;
            button3.UseVisualStyleBackColor = false;
            button3.Click += btnPrev_Click;
            // 
            // label56
            // 
            label56.AutoSize = true;
            label56.BackColor = System.Drawing.Color.Transparent;
            label56.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label56.ForeColor = System.Drawing.Color.Black;
            label56.Location = new System.Drawing.Point(6, 6);
            label56.Name = "label56";
            label56.Size = new System.Drawing.Size(105, 25);
            label56.TabIndex = 553;
            label56.Text = "Roll Zero";
            label56.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button19
            // 
            button19.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            button19.BackColor = System.Drawing.Color.Transparent;
            button19.FlatAppearance.BorderColor = System.Drawing.Color.White;
            button19.FlatAppearance.BorderSize = 0;
            button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button19.Font = new System.Drawing.Font("Tahoma", 14.25F);
            button19.Image = Properties.Resources.Next;
            button19.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            button19.Location = new System.Drawing.Point(577, 270);
            button19.Name = "button19";
            button19.Size = new System.Drawing.Size(72, 72);
            button19.TabIndex = 552;
            button19.UseVisualStyleBackColor = false;
            button19.Click += btnOkNext_Click;
            // 
            // tabWAS
            // 
            tabWAS.BackColor = System.Drawing.Color.White;
            tabWAS.Controls.Add(label45);
            tabWAS.Controls.Add(btnPrev_InvertWAS);
            tabWAS.Controls.Add(label42);
            tabWAS.Controls.Add(label30);
            tabWAS.Controls.Add(btnOkWAS);
            tabWAS.Controls.Add(chkInvertWAS);
            tabWAS.Location = new System.Drawing.Point(4, 19);
            tabWAS.Name = "tabWAS";
            tabWAS.Size = new System.Drawing.Size(655, 348);
            tabWAS.TabIndex = 18;
            tabWAS.Text = "WAS";
            // 
            // label45
            // 
            label45.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label45.AutoSize = true;
            label45.BackColor = System.Drawing.Color.Transparent;
            label45.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label45.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label45.Location = new System.Drawing.Point(290, 236);
            label45.Name = "label45";
            label45.Size = new System.Drawing.Size(83, 16);
            label45.TabIndex = 538;
            label45.Text = "Invert WAS";
            label45.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnPrev_InvertWAS
            // 
            btnPrev_InvertWAS.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnPrev_InvertWAS.BackColor = System.Drawing.Color.Transparent;
            btnPrev_InvertWAS.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            btnPrev_InvertWAS.FlatAppearance.BorderSize = 0;
            btnPrev_InvertWAS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPrev_InvertWAS.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnPrev_InvertWAS.Image = Properties.Resources.Previous;
            btnPrev_InvertWAS.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnPrev_InvertWAS.Location = new System.Drawing.Point(485, 269);
            btnPrev_InvertWAS.Name = "btnPrev_InvertWAS";
            btnPrev_InvertWAS.Size = new System.Drawing.Size(72, 72);
            btnPrev_InvertWAS.TabIndex = 537;
            btnPrev_InvertWAS.UseVisualStyleBackColor = false;
            btnPrev_InvertWAS.Click += btnPrev_Click;
            // 
            // label42
            // 
            label42.AutoSize = true;
            label42.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label42.ForeColor = System.Drawing.Color.Black;
            label42.Location = new System.Drawing.Point(4, 4);
            label42.Name = "label42";
            label42.Size = new System.Drawing.Size(233, 25);
            label42.TabIndex = 532;
            label42.Text = "Invert WAS Direction";
            label42.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnOkWAS
            // 
            btnOkWAS.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnOkWAS.BackColor = System.Drawing.Color.Transparent;
            btnOkWAS.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            btnOkWAS.FlatAppearance.BorderSize = 0;
            btnOkWAS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnOkWAS.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnOkWAS.Image = Properties.Resources.Next;
            btnOkWAS.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnOkWAS.Location = new System.Drawing.Point(576, 269);
            btnOkWAS.Name = "btnOkWAS";
            btnOkWAS.Size = new System.Drawing.Size(72, 72);
            btnOkWAS.TabIndex = 526;
            btnOkWAS.UseVisualStyleBackColor = false;
            btnOkWAS.Click += btnOkNext_Click;
            // 
            // chkInvertWAS
            // 
            chkInvertWAS.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            chkInvertWAS.Appearance = System.Windows.Forms.Appearance.Button;
            chkInvertWAS.BackColor = System.Drawing.Color.AliceBlue;
            chkInvertWAS.Checked = true;
            chkInvertWAS.CheckState = System.Windows.Forms.CheckState.Checked;
            chkInvertWAS.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            chkInvertWAS.FlatAppearance.CheckedBackColor = System.Drawing.Color.MediumAquamarine;
            chkInvertWAS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            chkInvertWAS.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            chkInvertWAS.ForeColor = System.Drawing.SystemColors.ControlText;
            chkInvertWAS.Image = Properties.Resources.ConSt_InvertWAS;
            chkInvertWAS.Location = new System.Drawing.Point(274, 155);
            chkInvertWAS.Name = "chkInvertWAS";
            chkInvertWAS.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            chkInvertWAS.Size = new System.Drawing.Size(109, 78);
            chkInvertWAS.TabIndex = 490;
            chkInvertWAS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            chkInvertWAS.UseVisualStyleBackColor = false;
            chkInvertWAS.CheckedChanged += chkInvertWAS_CheckedChanged;
            // 
            // tabWAS_Zero
            // 
            tabWAS_Zero.BackColor = System.Drawing.Color.White;
            tabWAS_Zero.Controls.Add(label112);
            tabWAS_Zero.Controls.Add(lblCurrentHeading);
            tabWAS_Zero.Controls.Add(label37);
            tabWAS_Zero.Controls.Add(button6);
            tabWAS_Zero.Controls.Add(btnRemoveWasOffset);
            tabWAS_Zero.Controls.Add(label40);
            tabWAS_Zero.Controls.Add(hsbarWasOffset);
            tabWAS_Zero.Controls.Add(lblSteerAngleSensorZero);
            tabWAS_Zero.Controls.Add(label10);
            tabWAS_Zero.Controls.Add(btnOkNext_WAS_Zero);
            tabWAS_Zero.Controls.Add(btnZeroWAS);
            tabWAS_Zero.Location = new System.Drawing.Point(4, 19);
            tabWAS_Zero.Name = "tabWAS_Zero";
            tabWAS_Zero.Size = new System.Drawing.Size(655, 348);
            tabWAS_Zero.TabIndex = 21;
            tabWAS_Zero.Text = "WAS_Zero";
            // 
            // label112
            // 
            label112.AutoSize = true;
            label112.BackColor = System.Drawing.Color.Transparent;
            label112.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label112.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label112.Location = new System.Drawing.Point(75, 161);
            label112.Name = "label112";
            label112.Size = new System.Drawing.Size(45, 16);
            label112.TabIndex = 532;
            label112.Text = "Reset";
            label112.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCurrentHeading
            // 
            lblCurrentHeading.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblCurrentHeading.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblCurrentHeading.ForeColor = System.Drawing.Color.Black;
            lblCurrentHeading.Location = new System.Drawing.Point(278, 290);
            lblCurrentHeading.Name = "lblCurrentHeading";
            lblCurrentHeading.Size = new System.Drawing.Size(102, 35);
            lblCurrentHeading.TabIndex = 539;
            lblCurrentHeading.Text = "358.8";
            lblCurrentHeading.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label37
            // 
            label37.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label37.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label37.ForeColor = System.Drawing.Color.Black;
            label37.Location = new System.Drawing.Point(33, 289);
            label37.Name = "label37";
            label37.Size = new System.Drawing.Size(248, 35);
            label37.TabIndex = 540;
            label37.Text = "Current Heading:";
            label37.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button6
            // 
            button6.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            button6.BackColor = System.Drawing.Color.Transparent;
            button6.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button6.Font = new System.Drawing.Font("Tahoma", 14.25F);
            button6.Image = Properties.Resources.Previous;
            button6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            button6.Location = new System.Drawing.Point(485, 269);
            button6.Name = "button6";
            button6.Size = new System.Drawing.Size(72, 72);
            button6.TabIndex = 538;
            button6.UseVisualStyleBackColor = false;
            button6.Click += btnPrev_Click;
            // 
            // btnRemoveWasOffset
            // 
            btnRemoveWasOffset.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnRemoveWasOffset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnRemoveWasOffset.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            btnRemoveWasOffset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRemoveWasOffset.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnRemoveWasOffset.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            btnRemoveWasOffset.Image = Properties.Resources.WizWasZeroReset;
            btnRemoveWasOffset.Location = new System.Drawing.Point(71, 180);
            btnRemoveWasOffset.Name = "btnRemoveWasOffset";
            btnRemoveWasOffset.Size = new System.Drawing.Size(100, 72);
            btnRemoveWasOffset.TabIndex = 533;
            btnRemoveWasOffset.UseVisualStyleBackColor = true;
            btnRemoveWasOffset.Click += btnRemoveWasOffset_Click;
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label40.ForeColor = System.Drawing.Color.Black;
            label40.Location = new System.Drawing.Point(3, 4);
            label40.Name = "label40";
            label40.Size = new System.Drawing.Size(146, 25);
            label40.TabIndex = 532;
            label40.Text = "WAS Zeroing";
            label40.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnOkNext_WAS_Zero
            // 
            btnOkNext_WAS_Zero.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnOkNext_WAS_Zero.BackColor = System.Drawing.Color.Transparent;
            btnOkNext_WAS_Zero.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            btnOkNext_WAS_Zero.FlatAppearance.BorderSize = 0;
            btnOkNext_WAS_Zero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnOkNext_WAS_Zero.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnOkNext_WAS_Zero.Image = Properties.Resources.Next;
            btnOkNext_WAS_Zero.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnOkNext_WAS_Zero.Location = new System.Drawing.Point(576, 269);
            btnOkNext_WAS_Zero.Name = "btnOkNext_WAS_Zero";
            btnOkNext_WAS_Zero.Size = new System.Drawing.Size(72, 72);
            btnOkNext_WAS_Zero.TabIndex = 529;
            btnOkNext_WAS_Zero.UseVisualStyleBackColor = false;
            btnOkNext_WAS_Zero.Click += btnOkNext_Click;
            // 
            // btnZeroWAS
            // 
            btnZeroWAS.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnZeroWAS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            btnZeroWAS.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            btnZeroWAS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnZeroWAS.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnZeroWAS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            btnZeroWAS.Image = Properties.Resources.SteerZero;
            btnZeroWAS.Location = new System.Drawing.Point(273, 97);
            btnZeroWAS.Name = "btnZeroWAS";
            btnZeroWAS.Size = new System.Drawing.Size(100, 77);
            btnZeroWAS.TabIndex = 323;
            btnZeroWAS.UseVisualStyleBackColor = true;
            btnZeroWAS.Click += btnZeroWAS_Click;
            // 
            // tabMotorDirection
            // 
            tabMotorDirection.BackColor = System.Drawing.Color.White;
            tabMotorDirection.Controls.Add(label58);
            tabMotorDirection.Controls.Add(label41);
            tabMotorDirection.Controls.Add(label17);
            tabMotorDirection.Controls.Add(label33);
            tabMotorDirection.Controls.Add(label70);
            tabMotorDirection.Controls.Add(btnPrev_MotorDirection);
            tabMotorDirection.Controls.Add(btnOkNext_MotorDirection);
            tabMotorDirection.Controls.Add(btnSteerLeft);
            tabMotorDirection.Controls.Add(btnSteerRight);
            tabMotorDirection.Controls.Add(chkInvertSteer);
            tabMotorDirection.Location = new System.Drawing.Point(4, 19);
            tabMotorDirection.Name = "tabMotorDirection";
            tabMotorDirection.Size = new System.Drawing.Size(655, 348);
            tabMotorDirection.TabIndex = 17;
            tabMotorDirection.Text = "MotorDirection";
            tabMotorDirection.Enter += tabMotorDirection_Enter;
            tabMotorDirection.Leave += tabMotorDirection_Leave;
            // 
            // label58
            // 
            label58.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label58.AutoSize = true;
            label58.BackColor = System.Drawing.Color.Transparent;
            label58.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label58.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label58.Location = new System.Drawing.Point(274, 236);
            label58.Name = "label58";
            label58.Size = new System.Drawing.Size(110, 16);
            label58.TabIndex = 540;
            label58.Text = "Invert Direction";
            label58.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label41
            // 
            label41.AutoSize = true;
            label41.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label41.ForeColor = System.Drawing.Color.Black;
            label41.Location = new System.Drawing.Point(3, 4);
            label41.Name = "label41";
            label41.Size = new System.Drawing.Size(237, 25);
            label41.TabIndex = 532;
            label41.Text = "Steer Motor Direction";
            label41.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label17
            // 
            label17.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label17.AutoSize = true;
            label17.BackColor = System.Drawing.Color.Transparent;
            label17.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label17.Location = new System.Drawing.Point(174, 241);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(33, 16);
            label17.TabIndex = 530;
            label17.Text = "Left";
            label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label33
            // 
            label33.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label33.AutoSize = true;
            label33.BackColor = System.Drawing.Color.Transparent;
            label33.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label33.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label33.Location = new System.Drawing.Point(442, 241);
            label33.Name = "label33";
            label33.Size = new System.Drawing.Size(41, 16);
            label33.TabIndex = 529;
            label33.Text = "Right";
            label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnPrev_MotorDirection
            // 
            btnPrev_MotorDirection.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnPrev_MotorDirection.BackColor = System.Drawing.Color.Transparent;
            btnPrev_MotorDirection.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            btnPrev_MotorDirection.FlatAppearance.BorderSize = 0;
            btnPrev_MotorDirection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPrev_MotorDirection.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnPrev_MotorDirection.Image = Properties.Resources.Previous;
            btnPrev_MotorDirection.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnPrev_MotorDirection.Location = new System.Drawing.Point(485, 269);
            btnPrev_MotorDirection.Name = "btnPrev_MotorDirection";
            btnPrev_MotorDirection.Size = new System.Drawing.Size(72, 72);
            btnPrev_MotorDirection.TabIndex = 537;
            btnPrev_MotorDirection.UseVisualStyleBackColor = false;
            btnPrev_MotorDirection.Click += btnPrev_Click;
            // 
            // btnOkNext_MotorDirection
            // 
            btnOkNext_MotorDirection.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnOkNext_MotorDirection.BackColor = System.Drawing.Color.Transparent;
            btnOkNext_MotorDirection.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            btnOkNext_MotorDirection.FlatAppearance.BorderSize = 0;
            btnOkNext_MotorDirection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnOkNext_MotorDirection.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnOkNext_MotorDirection.Image = Properties.Resources.Next;
            btnOkNext_MotorDirection.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnOkNext_MotorDirection.Location = new System.Drawing.Point(576, 269);
            btnOkNext_MotorDirection.Name = "btnOkNext_MotorDirection";
            btnOkNext_MotorDirection.Size = new System.Drawing.Size(72, 72);
            btnOkNext_MotorDirection.TabIndex = 528;
            btnOkNext_MotorDirection.UseVisualStyleBackColor = false;
            btnOkNext_MotorDirection.Click += btnOkNext_Click;
            // 
            // btnSteerLeft
            // 
            btnSteerLeft.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnSteerLeft.BackColor = System.Drawing.Color.Transparent;
            btnSteerLeft.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            btnSteerLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSteerLeft.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnSteerLeft.Image = Properties.Resources.SteerLeft;
            btnSteerLeft.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnSteerLeft.Location = new System.Drawing.Point(150, 158);
            btnSteerLeft.Name = "btnSteerLeft";
            btnSteerLeft.Size = new System.Drawing.Size(76, 81);
            btnSteerLeft.TabIndex = 525;
            btnSteerLeft.UseVisualStyleBackColor = false;
            btnSteerLeft.Click += btnSteerLeft_Click;
            // 
            // btnSteerRight
            // 
            btnSteerRight.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnSteerRight.BackColor = System.Drawing.Color.Transparent;
            btnSteerRight.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            btnSteerRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSteerRight.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnSteerRight.Image = Properties.Resources.SteerRight;
            btnSteerRight.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnSteerRight.Location = new System.Drawing.Point(425, 158);
            btnSteerRight.Name = "btnSteerRight";
            btnSteerRight.Size = new System.Drawing.Size(76, 80);
            btnSteerRight.TabIndex = 526;
            btnSteerRight.UseVisualStyleBackColor = false;
            btnSteerRight.Click += btnSteerRight_Click;
            // 
            // chkInvertSteer
            // 
            chkInvertSteer.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            chkInvertSteer.Appearance = System.Windows.Forms.Appearance.Button;
            chkInvertSteer.BackColor = System.Drawing.Color.AliceBlue;
            chkInvertSteer.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            chkInvertSteer.FlatAppearance.CheckedBackColor = System.Drawing.Color.MediumAquamarine;
            chkInvertSteer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            chkInvertSteer.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            chkInvertSteer.ForeColor = System.Drawing.SystemColors.ControlText;
            chkInvertSteer.Image = Properties.Resources.ConSt_InvertDirection;
            chkInvertSteer.Location = new System.Drawing.Point(274, 155);
            chkInvertSteer.Name = "chkInvertSteer";
            chkInvertSteer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            chkInvertSteer.Size = new System.Drawing.Size(109, 78);
            chkInvertSteer.TabIndex = 491;
            chkInvertSteer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            chkInvertSteer.UseVisualStyleBackColor = false;
            chkInvertSteer.CheckedChanged += chkInvertSteer_CheckedChanged;
            // 
            // tabCPD_Setup
            // 
            tabCPD_Setup.BackColor = System.Drawing.Color.White;
            tabCPD_Setup.Controls.Add(label60);
            tabCPD_Setup.Controls.Add(btnPrev_CountsPerDegree);
            tabCPD_Setup.Controls.Add(label74);
            tabCPD_Setup.Controls.Add(label75);
            tabCPD_Setup.Controls.Add(btnSkipCPD_Setup);
            tabCPD_Setup.Controls.Add(btnOKNext_CPDSetup);
            tabCPD_Setup.Location = new System.Drawing.Point(4, 19);
            tabCPD_Setup.Name = "tabCPD_Setup";
            tabCPD_Setup.Size = new System.Drawing.Size(655, 348);
            tabCPD_Setup.TabIndex = 33;
            tabCPD_Setup.Text = "CPD_Setup";
            // 
            // label60
            // 
            label60.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label60.BackColor = System.Drawing.Color.Transparent;
            label60.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label60.ForeColor = System.Drawing.Color.Black;
            label60.Location = new System.Drawing.Point(13, 263);
            label60.Name = "label60";
            label60.Size = new System.Drawing.Size(468, 35);
            label60.TabIndex = 544;
            label60.Text = "* Begin * Calibration";
            label60.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnPrev_CountsPerDegree
            // 
            btnPrev_CountsPerDegree.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnPrev_CountsPerDegree.BackColor = System.Drawing.Color.Transparent;
            btnPrev_CountsPerDegree.FlatAppearance.BorderColor = System.Drawing.Color.White;
            btnPrev_CountsPerDegree.FlatAppearance.BorderSize = 0;
            btnPrev_CountsPerDegree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPrev_CountsPerDegree.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnPrev_CountsPerDegree.Image = Properties.Resources.Previous;
            btnPrev_CountsPerDegree.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnPrev_CountsPerDegree.Location = new System.Drawing.Point(485, 244);
            btnPrev_CountsPerDegree.Name = "btnPrev_CountsPerDegree";
            btnPrev_CountsPerDegree.Size = new System.Drawing.Size(72, 72);
            btnPrev_CountsPerDegree.TabIndex = 537;
            btnPrev_CountsPerDegree.UseVisualStyleBackColor = false;
            btnPrev_CountsPerDegree.Click += btnPrev_Click;
            // 
            // label74
            // 
            label74.AutoSize = true;
            label74.BackColor = System.Drawing.Color.Transparent;
            label74.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label74.ForeColor = System.Drawing.Color.Black;
            label74.Location = new System.Drawing.Point(5, 5);
            label74.Name = "label74";
            label74.Size = new System.Drawing.Size(182, 25);
            label74.TabIndex = 543;
            label74.Text = "WAS Calibration";
            label74.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label75
            // 
            label75.BackColor = System.Drawing.Color.Transparent;
            label75.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label75.ForeColor = System.Drawing.Color.Black;
            label75.Location = new System.Drawing.Point(79, 97);
            label75.Name = "label75";
            label75.Size = new System.Drawing.Size(402, 86);
            label75.TabIndex = 542;
            label75.Text = "* SKIP *  Counts Per Degree and Ackermann Setting?";
            label75.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSkipCPD_Setup
            // 
            btnSkipCPD_Setup.BackColor = System.Drawing.Color.Transparent;
            btnSkipCPD_Setup.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            btnSkipCPD_Setup.FlatAppearance.BorderSize = 0;
            btnSkipCPD_Setup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSkipCPD_Setup.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnSkipCPD_Setup.Image = Properties.Resources.Cancel64;
            btnSkipCPD_Setup.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnSkipCPD_Setup.Location = new System.Drawing.Point(487, 112);
            btnSkipCPD_Setup.Name = "btnSkipCPD_Setup";
            btnSkipCPD_Setup.Size = new System.Drawing.Size(72, 61);
            btnSkipCPD_Setup.TabIndex = 539;
            btnSkipCPD_Setup.UseVisualStyleBackColor = false;
            btnSkipCPD_Setup.Click += btnSkipCPD_Setup_Click;
            // 
            // btnOKNext_CPDSetup
            // 
            btnOKNext_CPDSetup.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnOKNext_CPDSetup.BackColor = System.Drawing.Color.Transparent;
            btnOKNext_CPDSetup.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            btnOKNext_CPDSetup.FlatAppearance.BorderSize = 0;
            btnOKNext_CPDSetup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnOKNext_CPDSetup.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnOKNext_CPDSetup.Image = Properties.Resources.Next;
            btnOKNext_CPDSetup.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnOKNext_CPDSetup.Location = new System.Drawing.Point(576, 244);
            btnOKNext_CPDSetup.Name = "btnOKNext_CPDSetup";
            btnOKNext_CPDSetup.Size = new System.Drawing.Size(72, 72);
            btnOKNext_CPDSetup.TabIndex = 541;
            btnOKNext_CPDSetup.UseVisualStyleBackColor = false;
            btnOKNext_CPDSetup.Click += btnOKNext_CPDSetup_Click;
            // 
            // tabCountsPerDeg
            // 
            tabCountsPerDeg.BackColor = System.Drawing.Color.White;
            tabCountsPerDeg.Controls.Add(label109);
            tabCountsPerDeg.Controls.Add(lblRightStartAngle);
            tabCountsPerDeg.Controls.Add(button5);
            tabCountsPerDeg.Controls.Add(lblCPDError);
            tabCountsPerDeg.Controls.Add(label39);
            tabCountsPerDeg.Controls.Add(hsbarCountsPerDegree);
            tabCountsPerDeg.Controls.Add(label8);
            tabCountsPerDeg.Controls.Add(lblCountsPerDegree);
            tabCountsPerDeg.Controls.Add(label7);
            tabCountsPerDeg.Controls.Add(lblDiameter);
            tabCountsPerDeg.Controls.Add(lblCalcSteerAngleInner);
            tabCountsPerDeg.Controls.Add(label1);
            tabCountsPerDeg.Controls.Add(btnOkNext_CountsPerDeg);
            tabCountsPerDeg.Controls.Add(btnStartSA);
            tabCountsPerDeg.Location = new System.Drawing.Point(4, 19);
            tabCountsPerDeg.Name = "tabCountsPerDeg";
            tabCountsPerDeg.Size = new System.Drawing.Size(655, 348);
            tabCountsPerDeg.TabIndex = 22;
            tabCountsPerDeg.Text = "CountsPerDeg";
            // 
            // label109
            // 
            label109.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label109.AutoSize = true;
            label109.BackColor = System.Drawing.Color.Transparent;
            label109.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label109.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label109.Location = new System.Drawing.Point(300, 125);
            label109.Name = "label109";
            label109.Size = new System.Drawing.Size(124, 25);
            label109.TabIndex = 557;
            label109.Text = "Start Angle:";
            label109.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRightStartAngle
            // 
            lblRightStartAngle.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblRightStartAngle.AutoSize = true;
            lblRightStartAngle.BackColor = System.Drawing.Color.Transparent;
            lblRightStartAngle.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblRightStartAngle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lblRightStartAngle.Location = new System.Drawing.Point(419, 125);
            lblRightStartAngle.Name = "lblRightStartAngle";
            lblRightStartAngle.Size = new System.Drawing.Size(45, 25);
            lblRightStartAngle.TabIndex = 556;
            lblRightStartAngle.Text = "0.0";
            lblRightStartAngle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button5
            // 
            button5.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            button5.BackColor = System.Drawing.Color.Transparent;
            button5.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button5.Font = new System.Drawing.Font("Tahoma", 14.25F);
            button5.Image = Properties.Resources.Previous;
            button5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            button5.Location = new System.Drawing.Point(485, 269);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(72, 72);
            button5.TabIndex = 538;
            button5.UseVisualStyleBackColor = false;
            button5.Click += btnPrev_Click;
            // 
            // lblCPDError
            // 
            lblCPDError.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblCPDError.AutoSize = true;
            lblCPDError.BackColor = System.Drawing.Color.Transparent;
            lblCPDError.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblCPDError.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lblCPDError.Location = new System.Drawing.Point(155, 235);
            lblCPDError.Name = "lblCPDError";
            lblCPDError.Size = new System.Drawing.Size(33, 25);
            lblCPDError.TabIndex = 532;
            lblCPDError.Text = "...";
            lblCPDError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label39
            // 
            label39.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label39.ForeColor = System.Drawing.Color.Black;
            label39.Location = new System.Drawing.Point(3, 3);
            label39.Name = "label39";
            label39.Size = new System.Drawing.Size(258, 26);
            label39.TabIndex = 531;
            label39.Text = "Counts per Degree";
            label39.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnOkNext_CountsPerDeg
            // 
            btnOkNext_CountsPerDeg.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnOkNext_CountsPerDeg.BackColor = System.Drawing.Color.Transparent;
            btnOkNext_CountsPerDeg.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            btnOkNext_CountsPerDeg.FlatAppearance.BorderSize = 0;
            btnOkNext_CountsPerDeg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnOkNext_CountsPerDeg.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnOkNext_CountsPerDeg.Image = Properties.Resources.Next;
            btnOkNext_CountsPerDeg.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnOkNext_CountsPerDeg.Location = new System.Drawing.Point(576, 269);
            btnOkNext_CountsPerDeg.Name = "btnOkNext_CountsPerDeg";
            btnOkNext_CountsPerDeg.Size = new System.Drawing.Size(72, 72);
            btnOkNext_CountsPerDeg.TabIndex = 529;
            btnOkNext_CountsPerDeg.UseVisualStyleBackColor = false;
            btnOkNext_CountsPerDeg.Click += btnOkNext_Click;
            // 
            // btnStartSA
            // 
            btnStartSA.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnStartSA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            btnStartSA.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnStartSA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            btnStartSA.Image = Properties.Resources.BoundaryRecord;
            btnStartSA.Location = new System.Drawing.Point(188, 129);
            btnStartSA.Name = "btnStartSA";
            btnStartSA.Size = new System.Drawing.Size(73, 78);
            btnStartSA.TabIndex = 323;
            btnStartSA.UseVisualStyleBackColor = true;
            btnStartSA.Click += btnStartSA_Click;
            // 
            // tabAckCPD
            // 
            tabAckCPD.BackColor = System.Drawing.Color.White;
            tabAckCPD.Controls.Add(btnAckReset);
            tabAckCPD.Controls.Add(label101);
            tabAckCPD.Controls.Add(lblStartAngleLeft);
            tabAckCPD.Controls.Add(label32);
            tabAckCPD.Controls.Add(hsbarAckerman);
            tabAckCPD.Controls.Add(lblAckerman);
            tabAckCPD.Controls.Add(button16);
            tabAckCPD.Controls.Add(lblAckermannError);
            tabAckCPD.Controls.Add(label105);
            tabAckCPD.Controls.Add(label106);
            tabAckCPD.Controls.Add(label108);
            tabAckCPD.Controls.Add(lblDiameterLeft);
            tabAckCPD.Controls.Add(lblCalcSteerAngleLeft);
            tabAckCPD.Controls.Add(label111);
            tabAckCPD.Controls.Add(button17);
            tabAckCPD.Controls.Add(btnStartSA_Left);
            tabAckCPD.Location = new System.Drawing.Point(4, 19);
            tabAckCPD.Name = "tabAckCPD";
            tabAckCPD.Size = new System.Drawing.Size(655, 348);
            tabAckCPD.TabIndex = 43;
            tabAckCPD.Text = "AckCPD";
            // 
            // btnAckReset
            // 
            btnAckReset.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnAckReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            btnAckReset.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnAckReset.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            btnAckReset.Location = new System.Drawing.Point(113, 130);
            btnAckReset.Name = "btnAckReset";
            btnAckReset.Size = new System.Drawing.Size(73, 78);
            btnAckReset.TabIndex = 556;
            btnAckReset.Text = "Reset To 100%";
            btnAckReset.UseVisualStyleBackColor = true;
            btnAckReset.Click += btnAckReset_Click;
            // 
            // label101
            // 
            label101.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label101.AutoSize = true;
            label101.BackColor = System.Drawing.Color.Transparent;
            label101.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label101.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label101.Location = new System.Drawing.Point(337, 125);
            label101.Name = "label101";
            label101.Size = new System.Drawing.Size(124, 25);
            label101.TabIndex = 555;
            label101.Text = "Start Angle:";
            label101.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStartAngleLeft
            // 
            lblStartAngleLeft.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblStartAngleLeft.AutoSize = true;
            lblStartAngleLeft.BackColor = System.Drawing.Color.Transparent;
            lblStartAngleLeft.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblStartAngleLeft.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lblStartAngleLeft.Location = new System.Drawing.Point(456, 125);
            lblStartAngleLeft.Name = "lblStartAngleLeft";
            lblStartAngleLeft.Size = new System.Drawing.Size(45, 25);
            lblStartAngleLeft.TabIndex = 554;
            lblStartAngleLeft.Text = "0.0";
            lblStartAngleLeft.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label32
            // 
            label32.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label32.BackColor = System.Drawing.Color.Transparent;
            label32.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label32.ForeColor = System.Drawing.Color.Black;
            label32.Location = new System.Drawing.Point(165, 254);
            label32.Name = "label32";
            label32.Size = new System.Drawing.Size(266, 29);
            label32.TabIndex = 553;
            label32.Text = "Ackermann Value:";
            label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hsbarAckerman
            // 
            hsbarAckerman.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            hsbarAckerman.LargeChange = 1;
            hsbarAckerman.Location = new System.Drawing.Point(164, 285);
            hsbarAckerman.Maximum = 200;
            hsbarAckerman.Minimum = 1;
            hsbarAckerman.Name = "hsbarAckerman";
            hsbarAckerman.Size = new System.Drawing.Size(270, 50);
            hsbarAckerman.TabIndex = 551;
            hsbarAckerman.Value = 100;
            hsbarAckerman.ValueChanged += hsbarAckerman_ValueChanged;
            // 
            // lblAckerman
            // 
            lblAckerman.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblAckerman.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblAckerman.ForeColor = System.Drawing.Color.Black;
            lblAckerman.Location = new System.Drawing.Point(64, 290);
            lblAckerman.Name = "lblAckerman";
            lblAckerman.Size = new System.Drawing.Size(91, 35);
            lblAckerman.TabIndex = 552;
            lblAckerman.Text = "888";
            lblAckerman.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button16
            // 
            button16.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            button16.BackColor = System.Drawing.Color.Transparent;
            button16.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            button16.FlatAppearance.BorderSize = 0;
            button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button16.Font = new System.Drawing.Font("Tahoma", 14.25F);
            button16.Image = Properties.Resources.Previous;
            button16.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            button16.Location = new System.Drawing.Point(486, 271);
            button16.Name = "button16";
            button16.Size = new System.Drawing.Size(72, 72);
            button16.TabIndex = 550;
            button16.UseVisualStyleBackColor = false;
            button16.Click += btnPrev_Click;
            // 
            // lblAckermannError
            // 
            lblAckermannError.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblAckermannError.AutoSize = true;
            lblAckermannError.BackColor = System.Drawing.Color.Transparent;
            lblAckermannError.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblAckermannError.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lblAckermannError.Location = new System.Drawing.Point(18, 219);
            lblAckermannError.Name = "lblAckermannError";
            lblAckermannError.Size = new System.Drawing.Size(33, 25);
            lblAckermannError.TabIndex = 549;
            lblAckermannError.Text = "...";
            lblAckermannError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label105
            // 
            label105.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label105.ForeColor = System.Drawing.Color.Black;
            label105.Location = new System.Drawing.Point(4, 5);
            label105.Name = "label105";
            label105.Size = new System.Drawing.Size(258, 26);
            label105.TabIndex = 548;
            label105.Text = "Ackermann";
            label105.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label106
            // 
            label106.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label106.AutoSize = true;
            label106.BackColor = System.Drawing.Color.Transparent;
            label106.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label106.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label106.Location = new System.Drawing.Point(333, 155);
            label106.Name = "label106";
            label106.Size = new System.Drawing.Size(128, 25);
            label106.TabIndex = 545;
            label106.Text = "Steer Angle:";
            label106.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label108
            // 
            label108.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label108.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label108.ForeColor = System.Drawing.Color.Black;
            label108.Location = new System.Drawing.Point(18, 43);
            label108.Name = "label108";
            label108.Size = new System.Drawing.Size(632, 57);
            label108.TabIndex = 546;
            label108.Text = "Turn steering wheel to LEFT roughly the same degrees as right.\r\nWhile driving in a steady circle, Press Rec and wait.";
            label108.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblDiameterLeft
            // 
            lblDiameterLeft.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblDiameterLeft.AutoSize = true;
            lblDiameterLeft.BackColor = System.Drawing.Color.Transparent;
            lblDiameterLeft.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblDiameterLeft.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lblDiameterLeft.Location = new System.Drawing.Point(456, 185);
            lblDiameterLeft.Name = "lblDiameterLeft";
            lblDiameterLeft.Size = new System.Drawing.Size(71, 25);
            lblDiameterLeft.TabIndex = 542;
            lblDiameterLeft.Text = "0.0 m";
            lblDiameterLeft.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCalcSteerAngleLeft
            // 
            lblCalcSteerAngleLeft.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblCalcSteerAngleLeft.AutoSize = true;
            lblCalcSteerAngleLeft.BackColor = System.Drawing.Color.Transparent;
            lblCalcSteerAngleLeft.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblCalcSteerAngleLeft.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lblCalcSteerAngleLeft.Location = new System.Drawing.Point(456, 155);
            lblCalcSteerAngleLeft.Name = "lblCalcSteerAngleLeft";
            lblCalcSteerAngleLeft.Size = new System.Drawing.Size(45, 25);
            lblCalcSteerAngleLeft.TabIndex = 543;
            lblCalcSteerAngleLeft.Text = "0.0";
            lblCalcSteerAngleLeft.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label111
            // 
            label111.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label111.AutoSize = true;
            label111.BackColor = System.Drawing.Color.Transparent;
            label111.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label111.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label111.Location = new System.Drawing.Point(357, 185);
            label111.Name = "label111";
            label111.Size = new System.Drawing.Size(104, 25);
            label111.TabIndex = 544;
            label111.Text = "Diameter:";
            label111.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button17
            // 
            button17.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            button17.BackColor = System.Drawing.Color.Transparent;
            button17.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            button17.FlatAppearance.BorderSize = 0;
            button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button17.Font = new System.Drawing.Font("Tahoma", 14.25F);
            button17.Image = Properties.Resources.Next;
            button17.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            button17.Location = new System.Drawing.Point(577, 271);
            button17.Name = "button17";
            button17.Size = new System.Drawing.Size(72, 72);
            button17.TabIndex = 547;
            button17.UseVisualStyleBackColor = false;
            button17.Click += btnOkNext_Click;
            // 
            // btnStartSA_Left
            // 
            btnStartSA_Left.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnStartSA_Left.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            btnStartSA_Left.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnStartSA_Left.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            btnStartSA_Left.Image = Properties.Resources.BoundaryRecord;
            btnStartSA_Left.Location = new System.Drawing.Point(238, 130);
            btnStartSA_Left.Name = "btnStartSA_Left";
            btnStartSA_Left.Size = new System.Drawing.Size(73, 78);
            btnStartSA_Left.TabIndex = 541;
            btnStartSA_Left.UseVisualStyleBackColor = true;
            btnStartSA_Left.Click += btnStartSA_Left_Click;
            // 
            // tabMaxSteerAngle
            // 
            tabMaxSteerAngle.BackColor = System.Drawing.Color.White;
            tabMaxSteerAngle.Controls.Add(label113);
            tabMaxSteerAngle.Controls.Add(btnOkSetMaximumSteerAngle);
            tabMaxSteerAngle.Controls.Add(label73);
            tabMaxSteerAngle.Controls.Add(btnPrev_MaxSteerAngle);
            tabMaxSteerAngle.Controls.Add(label49);
            tabMaxSteerAngle.Controls.Add(label23);
            tabMaxSteerAngle.Controls.Add(lblMaxSteerAngle);
            tabMaxSteerAngle.Controls.Add(hsbarMaxSteerAngle);
            tabMaxSteerAngle.Controls.Add(btnOkNextMaxSteerAngle);
            tabMaxSteerAngle.Location = new System.Drawing.Point(4, 19);
            tabMaxSteerAngle.Name = "tabMaxSteerAngle";
            tabMaxSteerAngle.Size = new System.Drawing.Size(655, 348);
            tabMaxSteerAngle.TabIndex = 26;
            tabMaxSteerAngle.Text = "MaxSteerAngle";
            // 
            // label113
            // 
            label113.AutoSize = true;
            label113.BackColor = System.Drawing.Color.Transparent;
            label113.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label113.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label113.Location = new System.Drawing.Point(503, 166);
            label113.Name = "label113";
            label113.Size = new System.Drawing.Size(29, 16);
            label113.TabIndex = 532;
            label113.Text = "Set";
            label113.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnOkSetMaximumSteerAngle
            // 
            btnOkSetMaximumSteerAngle.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnOkSetMaximumSteerAngle.BackColor = System.Drawing.Color.Transparent;
            btnOkSetMaximumSteerAngle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnOkSetMaximumSteerAngle.FlatAppearance.BorderColor = System.Drawing.Color.White;
            btnOkSetMaximumSteerAngle.FlatAppearance.BorderSize = 0;
            btnOkSetMaximumSteerAngle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnOkSetMaximumSteerAngle.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnOkSetMaximumSteerAngle.Image = Properties.Resources.OK64;
            btnOkSetMaximumSteerAngle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnOkSetMaximumSteerAngle.Location = new System.Drawing.Point(464, 92);
            btnOkSetMaximumSteerAngle.Name = "btnOkSetMaximumSteerAngle";
            btnOkSetMaximumSteerAngle.Size = new System.Drawing.Size(104, 72);
            btnOkSetMaximumSteerAngle.TabIndex = 541;
            btnOkSetMaximumSteerAngle.UseVisualStyleBackColor = false;
            btnOkSetMaximumSteerAngle.Click += btnOkSetMaximumSteerAngle_Click;
            // 
            // label73
            // 
            label73.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label73.BackColor = System.Drawing.Color.Transparent;
            label73.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label73.ForeColor = System.Drawing.Color.Black;
            label73.Location = new System.Drawing.Point(44, 99);
            label73.Name = "label73";
            label73.Size = new System.Drawing.Size(401, 56);
            label73.TabIndex = 538;
            label73.Text = "Turn steering to your desired limit for guidance and touch OK ->";
            label73.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnPrev_MaxSteerAngle
            // 
            btnPrev_MaxSteerAngle.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnPrev_MaxSteerAngle.BackColor = System.Drawing.Color.Transparent;
            btnPrev_MaxSteerAngle.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            btnPrev_MaxSteerAngle.FlatAppearance.BorderSize = 0;
            btnPrev_MaxSteerAngle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPrev_MaxSteerAngle.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnPrev_MaxSteerAngle.Image = Properties.Resources.Previous;
            btnPrev_MaxSteerAngle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnPrev_MaxSteerAngle.Location = new System.Drawing.Point(485, 269);
            btnPrev_MaxSteerAngle.Name = "btnPrev_MaxSteerAngle";
            btnPrev_MaxSteerAngle.Size = new System.Drawing.Size(72, 72);
            btnPrev_MaxSteerAngle.TabIndex = 537;
            btnPrev_MaxSteerAngle.UseVisualStyleBackColor = false;
            btnPrev_MaxSteerAngle.Click += btnPrev_Click;
            // 
            // label49
            // 
            label49.AutoSize = true;
            label49.BackColor = System.Drawing.Color.Transparent;
            label49.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label49.ForeColor = System.Drawing.Color.Black;
            label49.Location = new System.Drawing.Point(5, 5);
            label49.Name = "label49";
            label49.Size = new System.Drawing.Size(293, 25);
            label49.TabIndex = 532;
            label49.Text = "Guidance Steer Angle Limit";
            label49.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label23
            // 
            label23.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label23.BackColor = System.Drawing.Color.Transparent;
            label23.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label23.ForeColor = System.Drawing.Color.Black;
            label23.Location = new System.Drawing.Point(21, 206);
            label23.Name = "label23";
            label23.Size = new System.Drawing.Size(572, 29);
            label23.TabIndex = 531;
            label23.Text = "Or Manually Set Guidance Steer Angle Limit";
            label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOkNextMaxSteerAngle
            // 
            btnOkNextMaxSteerAngle.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnOkNextMaxSteerAngle.BackColor = System.Drawing.Color.Transparent;
            btnOkNextMaxSteerAngle.FlatAppearance.BorderColor = System.Drawing.Color.White;
            btnOkNextMaxSteerAngle.FlatAppearance.BorderSize = 0;
            btnOkNextMaxSteerAngle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnOkNextMaxSteerAngle.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnOkNextMaxSteerAngle.Image = Properties.Resources.Next;
            btnOkNextMaxSteerAngle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnOkNextMaxSteerAngle.Location = new System.Drawing.Point(576, 269);
            btnOkNextMaxSteerAngle.Name = "btnOkNextMaxSteerAngle";
            btnOkNextMaxSteerAngle.Size = new System.Drawing.Size(72, 72);
            btnOkNextMaxSteerAngle.TabIndex = 530;
            btnOkNextMaxSteerAngle.UseVisualStyleBackColor = false;
            btnOkNextMaxSteerAngle.Click += btnOkNext_Click;
            // 
            // tabCancelGuidance
            // 
            tabCancelGuidance.BackColor = System.Drawing.Color.White;
            tabCancelGuidance.Controls.Add(btnPrev_CancelGuidance);
            tabCancelGuidance.Controls.Add(btnOkNextCancelGuidance);
            tabCancelGuidance.Controls.Add(label44);
            tabCancelGuidance.Controls.Add(labelEncoder);
            tabCancelGuidance.Controls.Add(labelCurrentTurnSensor);
            tabCancelGuidance.Controls.Add(labelPressureTurnSensor);
            tabCancelGuidance.Controls.Add(pbarSensor);
            tabCancelGuidance.Controls.Add(nudMaxCounts);
            tabCancelGuidance.Controls.Add(label61);
            tabCancelGuidance.Controls.Add(hsbarSensor);
            tabCancelGuidance.Controls.Add(lblPercentFS);
            tabCancelGuidance.Controls.Add(lblhsbarSensor);
            tabCancelGuidance.Controls.Add(cboxPressureSensor);
            tabCancelGuidance.Controls.Add(cboxEncoder);
            tabCancelGuidance.Controls.Add(cboxCurrentSensor);
            tabCancelGuidance.Location = new System.Drawing.Point(4, 19);
            tabCancelGuidance.Name = "tabCancelGuidance";
            tabCancelGuidance.Size = new System.Drawing.Size(655, 348);
            tabCancelGuidance.TabIndex = 20;
            tabCancelGuidance.Text = "CancelGuidance";
            // 
            // btnPrev_CancelGuidance
            // 
            btnPrev_CancelGuidance.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnPrev_CancelGuidance.BackColor = System.Drawing.Color.Transparent;
            btnPrev_CancelGuidance.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            btnPrev_CancelGuidance.FlatAppearance.BorderSize = 0;
            btnPrev_CancelGuidance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPrev_CancelGuidance.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnPrev_CancelGuidance.Image = Properties.Resources.Previous;
            btnPrev_CancelGuidance.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnPrev_CancelGuidance.Location = new System.Drawing.Point(485, 269);
            btnPrev_CancelGuidance.Name = "btnPrev_CancelGuidance";
            btnPrev_CancelGuidance.Size = new System.Drawing.Size(72, 72);
            btnPrev_CancelGuidance.TabIndex = 536;
            btnPrev_CancelGuidance.UseVisualStyleBackColor = false;
            btnPrev_CancelGuidance.Click += btnPrev_Click;
            // 
            // btnOkNextCancelGuidance
            // 
            btnOkNextCancelGuidance.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnOkNextCancelGuidance.BackColor = System.Drawing.Color.Transparent;
            btnOkNextCancelGuidance.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            btnOkNextCancelGuidance.FlatAppearance.BorderSize = 0;
            btnOkNextCancelGuidance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnOkNextCancelGuidance.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnOkNextCancelGuidance.Image = Properties.Resources.Next;
            btnOkNextCancelGuidance.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnOkNextCancelGuidance.Location = new System.Drawing.Point(576, 269);
            btnOkNextCancelGuidance.Name = "btnOkNextCancelGuidance";
            btnOkNextCancelGuidance.Size = new System.Drawing.Size(72, 72);
            btnOkNextCancelGuidance.TabIndex = 533;
            btnOkNextCancelGuidance.UseVisualStyleBackColor = false;
            btnOkNextCancelGuidance.Click += btnOkNextCancelGuidance_Click;
            // 
            // label44
            // 
            label44.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label44.ForeColor = System.Drawing.Color.Black;
            label44.Location = new System.Drawing.Point(3, 5);
            label44.Name = "label44";
            label44.Size = new System.Drawing.Size(557, 26);
            label44.TabIndex = 532;
            label44.Text = "Automatic Canceling Feature";
            label44.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboxPressureSensor
            // 
            cboxPressureSensor.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            cboxPressureSensor.Appearance = System.Windows.Forms.Appearance.Button;
            cboxPressureSensor.BackColor = System.Drawing.Color.AliceBlue;
            cboxPressureSensor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            cboxPressureSensor.FlatAppearance.CheckedBackColor = System.Drawing.Color.MediumAquamarine;
            cboxPressureSensor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboxPressureSensor.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cboxPressureSensor.ForeColor = System.Drawing.SystemColors.ControlText;
            cboxPressureSensor.Image = Properties.Resources.ConSt_TurnSensorPressure;
            cboxPressureSensor.Location = new System.Drawing.Point(427, 110);
            cboxPressureSensor.Name = "cboxPressureSensor";
            cboxPressureSensor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            cboxPressureSensor.Size = new System.Drawing.Size(114, 78);
            cboxPressureSensor.TabIndex = 508;
            cboxPressureSensor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            cboxPressureSensor.UseVisualStyleBackColor = false;
            cboxPressureSensor.Click += cboxCancelGuidance_Click;
            // 
            // cboxEncoder
            // 
            cboxEncoder.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            cboxEncoder.Appearance = System.Windows.Forms.Appearance.Button;
            cboxEncoder.BackColor = System.Drawing.Color.AliceBlue;
            cboxEncoder.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            cboxEncoder.FlatAppearance.CheckedBackColor = System.Drawing.Color.MediumAquamarine;
            cboxEncoder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboxEncoder.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cboxEncoder.ForeColor = System.Drawing.SystemColors.ControlText;
            cboxEncoder.Image = Properties.Resources.ConSt_TurnSensor;
            cboxEncoder.Location = new System.Drawing.Point(129, 109);
            cboxEncoder.Name = "cboxEncoder";
            cboxEncoder.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            cboxEncoder.Size = new System.Drawing.Size(114, 78);
            cboxEncoder.TabIndex = 492;
            cboxEncoder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            cboxEncoder.UseVisualStyleBackColor = false;
            cboxEncoder.Click += cboxCancelGuidance_Click;
            // 
            // cboxCurrentSensor
            // 
            cboxCurrentSensor.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            cboxCurrentSensor.Appearance = System.Windows.Forms.Appearance.Button;
            cboxCurrentSensor.BackColor = System.Drawing.Color.AliceBlue;
            cboxCurrentSensor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            cboxCurrentSensor.FlatAppearance.CheckedBackColor = System.Drawing.Color.MediumAquamarine;
            cboxCurrentSensor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboxCurrentSensor.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cboxCurrentSensor.ForeColor = System.Drawing.SystemColors.ControlText;
            cboxCurrentSensor.Image = Properties.Resources.ConSt_TurnSensorCurrent;
            cboxCurrentSensor.Location = new System.Drawing.Point(278, 109);
            cboxCurrentSensor.Name = "cboxCurrentSensor";
            cboxCurrentSensor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            cboxCurrentSensor.Size = new System.Drawing.Size(114, 78);
            cboxCurrentSensor.TabIndex = 510;
            cboxCurrentSensor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            cboxCurrentSensor.UseVisualStyleBackColor = false;
            cboxCurrentSensor.Click += cboxCancelGuidance_Click;
            // 
            // tabPanicStop
            // 
            tabPanicStop.BackColor = System.Drawing.Color.White;
            tabPanicStop.Controls.Add(btnPrev_Panic);
            tabPanicStop.Controls.Add(label54);
            tabPanicStop.Controls.Add(btnOkNext_PanicStop);
            tabPanicStop.Location = new System.Drawing.Point(4, 19);
            tabPanicStop.Name = "tabPanicStop";
            tabPanicStop.Size = new System.Drawing.Size(655, 348);
            tabPanicStop.TabIndex = 30;
            tabPanicStop.Text = "PanicStop";
            // 
            // btnPrev_Panic
            // 
            btnPrev_Panic.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnPrev_Panic.BackColor = System.Drawing.Color.Transparent;
            btnPrev_Panic.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            btnPrev_Panic.FlatAppearance.BorderSize = 0;
            btnPrev_Panic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPrev_Panic.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnPrev_Panic.Image = Properties.Resources.Previous;
            btnPrev_Panic.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnPrev_Panic.Location = new System.Drawing.Point(485, 269);
            btnPrev_Panic.Name = "btnPrev_Panic";
            btnPrev_Panic.Size = new System.Drawing.Size(72, 72);
            btnPrev_Panic.TabIndex = 535;
            btnPrev_Panic.UseVisualStyleBackColor = false;
            btnPrev_Panic.Click += btnPrev_Click;
            // 
            // label54
            // 
            label54.AutoSize = true;
            label54.BackColor = System.Drawing.Color.Transparent;
            label54.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label54.ForeColor = System.Drawing.Color.Black;
            label54.Location = new System.Drawing.Point(5, 5);
            label54.Name = "label54";
            label54.Size = new System.Drawing.Size(192, 25);
            label54.TabIndex = 534;
            label54.Text = "Panic Stop Speed";
            label54.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnOkNext_PanicStop
            // 
            btnOkNext_PanicStop.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnOkNext_PanicStop.BackColor = System.Drawing.Color.Transparent;
            btnOkNext_PanicStop.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            btnOkNext_PanicStop.FlatAppearance.BorderSize = 0;
            btnOkNext_PanicStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnOkNext_PanicStop.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnOkNext_PanicStop.Image = Properties.Resources.Next;
            btnOkNext_PanicStop.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnOkNext_PanicStop.Location = new System.Drawing.Point(576, 269);
            btnOkNext_PanicStop.Name = "btnOkNext_PanicStop";
            btnOkNext_PanicStop.Size = new System.Drawing.Size(72, 72);
            btnOkNext_PanicStop.TabIndex = 533;
            btnOkNext_PanicStop.UseVisualStyleBackColor = false;
            btnOkNext_PanicStop.Click += btnOkNext_Click;
            // 
            // tab_MinimumGain
            // 
            tab_MinimumGain.BackColor = System.Drawing.Color.White;
            tab_MinimumGain.Controls.Add(label72);
            tab_MinimumGain.Controls.Add(label79);
            tab_MinimumGain.Controls.Add(label78);
            tab_MinimumGain.Controls.Add(btnMinGainLeft);
            tab_MinimumGain.Controls.Add(btnZeroMinMovementSetting);
            tab_MinimumGain.Controls.Add(label77);
            tab_MinimumGain.Controls.Add(label76);
            tab_MinimumGain.Controls.Add(btnMinGainRight);
            tab_MinimumGain.Controls.Add(label68);
            tab_MinimumGain.Controls.Add(label15);
            tab_MinimumGain.Controls.Add(btnPrev_Gain);
            tab_MinimumGain.Controls.Add(btnOK_Next);
            tab_MinimumGain.Controls.Add(hsbarMinPWM);
            tab_MinimumGain.Controls.Add(lblMinPWM);
            tab_MinimumGain.Location = new System.Drawing.Point(4, 19);
            tab_MinimumGain.Name = "tab_MinimumGain";
            tab_MinimumGain.Size = new System.Drawing.Size(655, 348);
            tab_MinimumGain.TabIndex = 34;
            tab_MinimumGain.Text = "MinGain";
            tab_MinimumGain.Enter += tab_MinimumGain_Enter;
            tab_MinimumGain.Leave += tab_MinimumGain_Leave;
            // 
            // label72
            // 
            label72.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label72.AutoSize = true;
            label72.BackColor = System.Drawing.Color.Transparent;
            label72.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label72.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label72.Location = new System.Drawing.Point(516, 106);
            label72.Name = "label72";
            label72.Size = new System.Drawing.Size(36, 16);
            label72.TabIndex = 549;
            label72.Text = "Zero";
            label72.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label79
            // 
            label79.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label79.AutoSize = true;
            label79.BackColor = System.Drawing.Color.Transparent;
            label79.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label79.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label79.Location = new System.Drawing.Point(576, 212);
            label79.Name = "label79";
            label79.Size = new System.Drawing.Size(41, 16);
            label79.TabIndex = 548;
            label79.Text = "Right";
            label79.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label78
            // 
            label78.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label78.AutoSize = true;
            label78.BackColor = System.Drawing.Color.Transparent;
            label78.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label78.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label78.Location = new System.Drawing.Point(457, 212);
            label78.Name = "label78";
            label78.Size = new System.Drawing.Size(33, 16);
            label78.TabIndex = 547;
            label78.Text = "Left";
            label78.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnMinGainLeft
            // 
            btnMinGainLeft.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnMinGainLeft.BackColor = System.Drawing.Color.Transparent;
            btnMinGainLeft.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            btnMinGainLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnMinGainLeft.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnMinGainLeft.Image = Properties.Resources.SteerLeft;
            btnMinGainLeft.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnMinGainLeft.Location = new System.Drawing.Point(433, 142);
            btnMinGainLeft.Name = "btnMinGainLeft";
            btnMinGainLeft.Size = new System.Drawing.Size(76, 68);
            btnMinGainLeft.TabIndex = 546;
            btnMinGainLeft.UseVisualStyleBackColor = false;
            btnMinGainLeft.Click += btnMinGainLeft_Click;
            // 
            // btnZeroMinMovementSetting
            // 
            btnZeroMinMovementSetting.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnZeroMinMovementSetting.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            btnZeroMinMovementSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnZeroMinMovementSetting.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnZeroMinMovementSetting.ForeColor = System.Drawing.Color.White;
            btnZeroMinMovementSetting.Image = Properties.Resources.SteerZero;
            btnZeroMinMovementSetting.Location = new System.Drawing.Point(496, 37);
            btnZeroMinMovementSetting.Name = "btnZeroMinMovementSetting";
            btnZeroMinMovementSetting.Size = new System.Drawing.Size(76, 68);
            btnZeroMinMovementSetting.TabIndex = 545;
            btnZeroMinMovementSetting.UseVisualStyleBackColor = true;
            btnZeroMinMovementSetting.Click += btnZeroMinMovementSetting_Click;
            // 
            // label77
            // 
            label77.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label77.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label77.ForeColor = System.Drawing.Color.Black;
            label77.Location = new System.Drawing.Point(26, 97);
            label77.Name = "label77";
            label77.Size = new System.Drawing.Size(369, 137);
            label77.TabIndex = 544;
            label77.Text = "Change Setpoint with steer buttons. \r\n\r\nAdjust Minumum Movement as high as possible without steer motor or hydraulics moving steering";
            label77.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label76
            // 
            label76.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label76.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label76.ForeColor = System.Drawing.Color.Black;
            label76.Location = new System.Drawing.Point(26, 36);
            label76.Name = "label76";
            label76.Size = new System.Drawing.Size(371, 55);
            label76.TabIndex = 543;
            label76.Text = "Drive slowly straight forward, Allow system to steer";
            label76.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnMinGainRight
            // 
            btnMinGainRight.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnMinGainRight.BackColor = System.Drawing.Color.Transparent;
            btnMinGainRight.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            btnMinGainRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnMinGainRight.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnMinGainRight.Image = Properties.Resources.SteerRight;
            btnMinGainRight.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnMinGainRight.Location = new System.Drawing.Point(557, 142);
            btnMinGainRight.Name = "btnMinGainRight";
            btnMinGainRight.Size = new System.Drawing.Size(76, 68);
            btnMinGainRight.TabIndex = 542;
            btnMinGainRight.UseVisualStyleBackColor = false;
            btnMinGainRight.Click += btnMinGainRight_Click;
            // 
            // label68
            // 
            label68.AutoSize = true;
            label68.BackColor = System.Drawing.Color.Transparent;
            label68.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label68.ForeColor = System.Drawing.Color.Black;
            label68.Location = new System.Drawing.Point(5, 5);
            label68.Name = "label68";
            label68.Size = new System.Drawing.Size(306, 25);
            label68.TabIndex = 538;
            label68.Text = "Minimum Movement Setting";
            label68.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnPrev_Gain
            // 
            btnPrev_Gain.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnPrev_Gain.BackColor = System.Drawing.Color.Transparent;
            btnPrev_Gain.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            btnPrev_Gain.FlatAppearance.BorderSize = 0;
            btnPrev_Gain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPrev_Gain.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnPrev_Gain.Image = Properties.Resources.Previous;
            btnPrev_Gain.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnPrev_Gain.Location = new System.Drawing.Point(485, 269);
            btnPrev_Gain.Name = "btnPrev_Gain";
            btnPrev_Gain.Size = new System.Drawing.Size(72, 72);
            btnPrev_Gain.TabIndex = 537;
            btnPrev_Gain.UseVisualStyleBackColor = false;
            btnPrev_Gain.Click += btnPrev_Click;
            // 
            // btnOK_Next
            // 
            btnOK_Next.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnOK_Next.BackColor = System.Drawing.Color.Transparent;
            btnOK_Next.FlatAppearance.BorderColor = System.Drawing.Color.White;
            btnOK_Next.FlatAppearance.BorderSize = 0;
            btnOK_Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnOK_Next.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnOK_Next.Image = Properties.Resources.Next;
            btnOK_Next.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnOK_Next.Location = new System.Drawing.Point(576, 269);
            btnOK_Next.Name = "btnOK_Next";
            btnOK_Next.Size = new System.Drawing.Size(72, 72);
            btnOK_Next.TabIndex = 536;
            btnOK_Next.UseVisualStyleBackColor = false;
            btnOK_Next.Click += btnOkNext_Click;
            // 
            // tabPGain
            // 
            tabPGain.BackColor = System.Drawing.Color.White;
            tabPGain.Controls.Add(label88);
            tabPGain.Controls.Add(label83);
            tabPGain.Controls.Add(label84);
            tabPGain.Controls.Add(label4);
            tabPGain.Controls.Add(btnLeftPGain);
            tabPGain.Controls.Add(btnZeroPGain);
            tabPGain.Controls.Add(label2);
            tabPGain.Controls.Add(label85);
            tabPGain.Controls.Add(label86);
            tabPGain.Controls.Add(btnRightPGain);
            tabPGain.Controls.Add(label87);
            tabPGain.Controls.Add(hsbarHighSteerPWM);
            tabPGain.Controls.Add(btnPrev_PGain);
            tabPGain.Controls.Add(btnNext_PGain);
            tabPGain.Controls.Add(hsbarProportionalGain);
            tabPGain.Controls.Add(lblProportionalGain);
            tabPGain.Controls.Add(lblHighSteerPWM);
            tabPGain.Location = new System.Drawing.Point(4, 19);
            tabPGain.Name = "tabPGain";
            tabPGain.Size = new System.Drawing.Size(655, 348);
            tabPGain.TabIndex = 36;
            tabPGain.Text = "PGain";
            tabPGain.Enter += tabPGain_Enter;
            tabPGain.Leave += tabPGain_Leave;
            // 
            // label88
            // 
            label88.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label88.AutoSize = true;
            label88.BackColor = System.Drawing.Color.Transparent;
            label88.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label88.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label88.Location = new System.Drawing.Point(586, 228);
            label88.Name = "label88";
            label88.Size = new System.Drawing.Size(41, 16);
            label88.TabIndex = 560;
            label88.Text = "Right";
            label88.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label83
            // 
            label83.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label83.AutoSize = true;
            label83.BackColor = System.Drawing.Color.Transparent;
            label83.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label83.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label83.Location = new System.Drawing.Point(515, 60);
            label83.Name = "label83";
            label83.Size = new System.Drawing.Size(77, 16);
            label83.TabIndex = 559;
            label83.Text = "Zero or +5";
            label83.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label84
            // 
            label84.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label84.AutoSize = true;
            label84.BackColor = System.Drawing.Color.Transparent;
            label84.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label84.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label84.Location = new System.Drawing.Point(492, 228);
            label84.Name = "label84";
            label84.Size = new System.Drawing.Size(33, 16);
            label84.TabIndex = 558;
            label84.Text = "Left";
            label84.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnLeftPGain
            // 
            btnLeftPGain.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnLeftPGain.BackColor = System.Drawing.Color.Transparent;
            btnLeftPGain.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            btnLeftPGain.FlatAppearance.BorderSize = 0;
            btnLeftPGain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLeftPGain.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnLeftPGain.Image = Properties.Resources.SteerLeft;
            btnLeftPGain.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnLeftPGain.Location = new System.Drawing.Point(468, 158);
            btnLeftPGain.Name = "btnLeftPGain";
            btnLeftPGain.Size = new System.Drawing.Size(76, 68);
            btnLeftPGain.TabIndex = 557;
            btnLeftPGain.UseVisualStyleBackColor = false;
            btnLeftPGain.Click += btnLeftPGain_Click;
            // 
            // btnZeroPGain
            // 
            btnZeroPGain.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnZeroPGain.FlatAppearance.BorderColor = System.Drawing.Color.White;
            btnZeroPGain.FlatAppearance.BorderSize = 0;
            btnZeroPGain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnZeroPGain.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnZeroPGain.ForeColor = System.Drawing.Color.White;
            btnZeroPGain.Image = Properties.Resources.SteerZero;
            btnZeroPGain.Location = new System.Drawing.Point(520, 72);
            btnZeroPGain.Name = "btnZeroPGain";
            btnZeroPGain.Size = new System.Drawing.Size(76, 67);
            btnZeroPGain.TabIndex = 556;
            btnZeroPGain.UseVisualStyleBackColor = true;
            btnZeroPGain.Click += btnZeroPGain_Click;
            // 
            // label85
            // 
            label85.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label85.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label85.ForeColor = System.Drawing.Color.Black;
            label85.Location = new System.Drawing.Point(27, 95);
            label85.Name = "label85";
            label85.Size = new System.Drawing.Size(435, 56);
            label85.TabIndex = 555;
            label85.Text = "Set Proportional for good response. \r\nSet PWM Maximum to limit turning speed.";
            label85.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label86
            // 
            label86.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label86.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label86.ForeColor = System.Drawing.Color.Black;
            label86.Location = new System.Drawing.Point(27, 50);
            label86.Name = "label86";
            label86.Size = new System.Drawing.Size(435, 33);
            label86.TabIndex = 554;
            label86.Text = "Drive forward and enable Auto Steer";
            label86.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnRightPGain
            // 
            btnRightPGain.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnRightPGain.BackColor = System.Drawing.Color.Transparent;
            btnRightPGain.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            btnRightPGain.FlatAppearance.BorderSize = 0;
            btnRightPGain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRightPGain.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnRightPGain.Image = Properties.Resources.SteerRight;
            btnRightPGain.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnRightPGain.Location = new System.Drawing.Point(568, 158);
            btnRightPGain.Name = "btnRightPGain";
            btnRightPGain.Size = new System.Drawing.Size(76, 68);
            btnRightPGain.TabIndex = 553;
            btnRightPGain.UseVisualStyleBackColor = false;
            btnRightPGain.Click += btnRightPGain_Click;
            // 
            // label87
            // 
            label87.AutoSize = true;
            label87.BackColor = System.Drawing.Color.Transparent;
            label87.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label87.ForeColor = System.Drawing.Color.Black;
            label87.Location = new System.Drawing.Point(6, 6);
            label87.Name = "label87";
            label87.Size = new System.Drawing.Size(141, 25);
            label87.TabIndex = 552;
            label87.Text = "Gain Setting";
            label87.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnPrev_PGain
            // 
            btnPrev_PGain.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnPrev_PGain.BackColor = System.Drawing.Color.Transparent;
            btnPrev_PGain.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            btnPrev_PGain.FlatAppearance.BorderSize = 0;
            btnPrev_PGain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPrev_PGain.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnPrev_PGain.Image = Properties.Resources.Previous;
            btnPrev_PGain.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnPrev_PGain.Location = new System.Drawing.Point(486, 270);
            btnPrev_PGain.Name = "btnPrev_PGain";
            btnPrev_PGain.Size = new System.Drawing.Size(72, 72);
            btnPrev_PGain.TabIndex = 551;
            btnPrev_PGain.UseVisualStyleBackColor = false;
            btnPrev_PGain.Click += btnPrev_Click;
            // 
            // btnNext_PGain
            // 
            btnNext_PGain.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnNext_PGain.BackColor = System.Drawing.Color.Transparent;
            btnNext_PGain.FlatAppearance.BorderColor = System.Drawing.Color.White;
            btnNext_PGain.FlatAppearance.BorderSize = 0;
            btnNext_PGain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNext_PGain.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnNext_PGain.Image = Properties.Resources.Next;
            btnNext_PGain.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnNext_PGain.Location = new System.Drawing.Point(577, 270);
            btnNext_PGain.Name = "btnNext_PGain";
            btnNext_PGain.Size = new System.Drawing.Size(72, 72);
            btnNext_PGain.TabIndex = 550;
            btnNext_PGain.UseVisualStyleBackColor = false;
            btnNext_PGain.Click += btnOkNext_Click;
            // 
            // tabEnd
            // 
            tabEnd.BackColor = System.Drawing.Color.White;
            tabEnd.Controls.Add(label116);
            tabEnd.Controls.Add(btnRestartWizard);
            tabEnd.Controls.Add(label69);
            tabEnd.Controls.Add(btnPrev_End);
            tabEnd.Controls.Add(btnExit);
            tabEnd.Location = new System.Drawing.Point(4, 19);
            tabEnd.Name = "tabEnd";
            tabEnd.Size = new System.Drawing.Size(655, 348);
            tabEnd.TabIndex = 32;
            tabEnd.Text = "End";
            // 
            // label116
            // 
            label116.BackColor = System.Drawing.Color.Transparent;
            label116.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label116.ForeColor = System.Drawing.Color.Black;
            label116.Location = new System.Drawing.Point(50, 114);
            label116.Name = "label116";
            label116.Size = new System.Drawing.Size(530, 152);
            label116.TabIndex = 538;
            label116.Text = "Now go drive an AB Line and fine tune settings based on your speed and soil conditions.\r\n\r\nRemember: CPD, Min PWM, and Look Ahead are critical settings. ";
            label116.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRestartWizard
            // 
            btnRestartWizard.BackColor = System.Drawing.Color.LightBlue;
            btnRestartWizard.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            btnRestartWizard.FlatAppearance.BorderSize = 0;
            btnRestartWizard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRestartWizard.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnRestartWizard.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnRestartWizard.Location = new System.Drawing.Point(222, 53);
            btnRestartWizard.Name = "btnRestartWizard";
            btnRestartWizard.Size = new System.Drawing.Size(178, 33);
            btnRestartWizard.TabIndex = 533;
            btnRestartWizard.Text = "Restart Wizard";
            btnRestartWizard.UseVisualStyleBackColor = false;
            btnRestartWizard.Click += btnRestartWizard_Click;
            // 
            // label69
            // 
            label69.AutoSize = true;
            label69.BackColor = System.Drawing.Color.Transparent;
            label69.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label69.ForeColor = System.Drawing.Color.Black;
            label69.Location = new System.Drawing.Point(258, 20);
            label69.Name = "label69";
            label69.Size = new System.Drawing.Size(111, 25);
            label69.TabIndex = 537;
            label69.Text = "Finished !";
            label69.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnPrev_End
            // 
            btnPrev_End.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnPrev_End.BackColor = System.Drawing.Color.Transparent;
            btnPrev_End.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            btnPrev_End.FlatAppearance.BorderSize = 0;
            btnPrev_End.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPrev_End.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnPrev_End.Image = Properties.Resources.Previous;
            btnPrev_End.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnPrev_End.Location = new System.Drawing.Point(451, 271);
            btnPrev_End.Name = "btnPrev_End";
            btnPrev_End.Size = new System.Drawing.Size(72, 72);
            btnPrev_End.TabIndex = 536;
            btnPrev_End.UseVisualStyleBackColor = false;
            btnPrev_End.Click += btnPrev_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnExit.BackColor = System.Drawing.Color.Transparent;
            btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnExit.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnExit.Image = Properties.Resources.OK64;
            btnExit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnExit.Location = new System.Drawing.Point(546, 271);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(104, 72);
            btnExit.TabIndex = 530;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnStopWizard
            // 
            btnStopWizard.BackColor = System.Drawing.Color.LightCoral;
            btnStopWizard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnStopWizard.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            btnStopWizard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnStopWizard.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnStopWizard.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnStopWizard.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnStopWizard.Location = new System.Drawing.Point(18, 7);
            btnStopWizard.Name = "btnStopWizard";
            btnStopWizard.Size = new System.Drawing.Size(148, 38);
            btnStopWizard.TabIndex = 527;
            btnStopWizard.Text = "Restart Wizard";
            btnStopWizard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnStopWizard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnStopWizard.UseVisualStyleBackColor = false;
            btnStopWizard.Click += btnStopWizard_Click;
            // 
            // panel3
            // 
            panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel3.Controls.Add(tabWiz);
            panel3.Location = new System.Drawing.Point(5, 51);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(665, 373);
            panel3.TabIndex = 531;
            // 
            // pbarProgress
            // 
            pbarProgress.Location = new System.Drawing.Point(336, 18);
            pbarProgress.Name = "pbarProgress";
            pbarProgress.Size = new System.Drawing.Size(323, 15);
            pbarProgress.Step = 1;
            pbarProgress.TabIndex = 532;
            // 
            // label71
            // 
            label71.AutoSize = true;
            label71.BackColor = System.Drawing.Color.Transparent;
            label71.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label71.ForeColor = System.Drawing.Color.Black;
            label71.Location = new System.Drawing.Point(235, 12);
            label71.Name = "label71";
            label71.Size = new System.Drawing.Size(100, 23);
            label71.TabIndex = 532;
            label71.Text = "Progress:";
            label71.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBarCPD
            // 
            lblBarCPD.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblBarCPD.AutoSize = true;
            lblBarCPD.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblBarCPD.ForeColor = System.Drawing.Color.Black;
            lblBarCPD.Location = new System.Drawing.Point(675, 146);
            lblBarCPD.Name = "lblBarCPD";
            lblBarCPD.Size = new System.Drawing.Size(51, 25);
            lblBarCPD.TabIndex = 534;
            lblBarCPD.Text = "888";
            lblBarCPD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label66
            // 
            label66.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label66.AutoSize = true;
            label66.BackColor = System.Drawing.Color.Transparent;
            label66.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label66.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label66.Location = new System.Drawing.Point(675, 124);
            label66.Name = "label66";
            label66.Size = new System.Drawing.Size(123, 23);
            label66.TabIndex = 535;
            label66.Text = "Counts P Deg";
            label66.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label65
            // 
            label65.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label65.AutoSize = true;
            label65.BackColor = System.Drawing.Color.Transparent;
            label65.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label65.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label65.Location = new System.Drawing.Point(675, 176);
            label65.Name = "label65";
            label65.Size = new System.Drawing.Size(104, 23);
            label65.TabIndex = 537;
            label65.Text = "Ackermann";
            label65.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBarAck
            // 
            lblBarAck.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblBarAck.AutoSize = true;
            lblBarAck.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblBarAck.ForeColor = System.Drawing.Color.Black;
            lblBarAck.Location = new System.Drawing.Point(675, 198);
            lblBarAck.Name = "lblBarAck";
            lblBarAck.Size = new System.Drawing.Size(51, 25);
            lblBarAck.TabIndex = 536;
            lblBarAck.Text = "888";
            lblBarAck.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sideBarTimer
            // 
            sideBarTimer.Enabled = true;
            sideBarTimer.Interval = 1000;
            sideBarTimer.Tick += sideBarTimer_Tick;
            // 
            // label67
            // 
            label67.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label67.AutoSize = true;
            label67.BackColor = System.Drawing.Color.Transparent;
            label67.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label67.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label67.Location = new System.Drawing.Point(675, 72);
            label67.Name = "label67";
            label67.Size = new System.Drawing.Size(104, 23);
            label67.TabIndex = 539;
            label67.Text = "WAS Offset";
            label67.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBarWasOffset
            // 
            lblBarWasOffset.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblBarWasOffset.AutoSize = true;
            lblBarWasOffset.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblBarWasOffset.ForeColor = System.Drawing.Color.Black;
            lblBarWasOffset.Location = new System.Drawing.Point(675, 93);
            lblBarWasOffset.Name = "lblBarWasOffset";
            lblBarWasOffset.Size = new System.Drawing.Size(51, 25);
            lblBarWasOffset.TabIndex = 538;
            lblBarWasOffset.Text = "888";
            lblBarWasOffset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCloseAll
            // 
            btnCloseAll.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnCloseAll.BackColor = System.Drawing.Color.Transparent;
            btnCloseAll.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCloseAll.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            btnCloseAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCloseAll.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnCloseAll.Image = Properties.Resources.boundaryStop;
            btnCloseAll.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnCloseAll.Location = new System.Drawing.Point(688, 479);
            btnCloseAll.Name = "btnCloseAll";
            btnCloseAll.Size = new System.Drawing.Size(104, 72);
            btnCloseAll.TabIndex = 540;
            btnCloseAll.UseVisualStyleBackColor = false;
            btnCloseAll.Click += btnExit_Click;
            // 
            // FormSteerWiz
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(805, 558);
            ControlBox = false;
            Controls.Add(btnCloseAll);
            Controls.Add(label67);
            Controls.Add(lblBarWasOffset);
            Controls.Add(label65);
            Controls.Add(lblBarAck);
            Controls.Add(label66);
            Controls.Add(lblBarCPD);
            Controls.Add(label71);
            Controls.Add(pbarProgress);
            Controls.Add(panel3);
            Controls.Add(btnStopWizard);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(tabControl1);
            Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            HelpButton = true;
            MinimizeBox = false;
            Name = "FormSteerWiz";
            Padding = new System.Windows.Forms.Padding(2);
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Auto Steer Wizard";
            FormClosing += FormSteer_FormClosing;
            Load += FormSteer_Load;
            tabControl1.ResumeLayout(false);
            tabSteer.ResumeLayout(false);
            tabSteer.PerformLayout();
            tabStan.ResumeLayout(false);
            tabInt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudMaxCounts).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabWiz.ResumeLayout(false);
            tabStart.ResumeLayout(false);
            tabLoadDef.ResumeLayout(false);
            tabLoadDef.PerformLayout();
            tabWheelBase.ResumeLayout(false);
            tabWheelBase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudWheelbase).EndInit();
            tabWheelTrack.ResumeLayout(false);
            tabWheelTrack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudVehicleTrack).EndInit();
            tabAntennaDistance.ResumeLayout(false);
            tabAntennaDistance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudAntennaPivot).EndInit();
            tabAntennaHeight.ResumeLayout(false);
            tabAntennaHeight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudAntennaHeight).EndInit();
            tabAntennaOffset.ResumeLayout(false);
            tabAntennaOffset.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudAntennaOffset).EndInit();
            tabButtonSwitch.ResumeLayout(false);
            tabButtonSwitch.PerformLayout();
            tabA2DConv.ResumeLayout(false);
            tabA2DConv.PerformLayout();
            tabMotorDriver.ResumeLayout(false);
            tabMotorDriver.PerformLayout();
            tabInvertRelays.ResumeLayout(false);
            tabInvertRelays.PerformLayout();
            tabDanfoss.ResumeLayout(false);
            tabDanfoss.PerformLayout();
            tabRollInv.ResumeLayout(false);
            tabRollInv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            tabRollZero.ResumeLayout(false);
            tabRollZero.PerformLayout();
            tabWAS.ResumeLayout(false);
            tabWAS.PerformLayout();
            tabWAS_Zero.ResumeLayout(false);
            tabWAS_Zero.PerformLayout();
            tabMotorDirection.ResumeLayout(false);
            tabMotorDirection.PerformLayout();
            tabCPD_Setup.ResumeLayout(false);
            tabCPD_Setup.PerformLayout();
            tabCountsPerDeg.ResumeLayout(false);
            tabCountsPerDeg.PerformLayout();
            tabAckCPD.ResumeLayout(false);
            tabAckCPD.PerformLayout();
            tabMaxSteerAngle.ResumeLayout(false);
            tabMaxSteerAngle.PerformLayout();
            tabCancelGuidance.ResumeLayout(false);
            tabCancelGuidance.PerformLayout();
            tabPanicStop.ResumeLayout(false);
            tabPanicStop.PerformLayout();
            tab_MinimumGain.ResumeLayout(false);
            tab_MinimumGain.PerformLayout();
            tabPGain.ResumeLayout(false);
            tabPGain.PerformLayout();
            tabEnd.ResumeLayout(false);
            tabEnd.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnFreeDrive;
        private System.Windows.Forms.Label lblHighSteerPWM;
        private System.Windows.Forms.HScrollBar hsbarHighSteerPWM;
        private System.Windows.Forms.Label lblLowSteerPWM;
        private System.Windows.Forms.HScrollBar hsbarLowSteerPWM;
        private System.Windows.Forms.Label lblProportionalGain;
        private System.Windows.Forms.HScrollBar hsbarProportionalGain;
        private System.Windows.Forms.Label lblLookAhead;
        private System.Windows.Forms.Label lblMinPWM;
        private System.Windows.Forms.HScrollBar hsbarMinPWM;
        private System.Windows.Forms.Label lblMaxSteerAngle;
        private System.Windows.Forms.HScrollBar hsbarMaxSteerAngle;
        private System.Windows.Forms.Label lblLookAheadMult;
        private System.Windows.Forms.HScrollBar hsbarHeadingErrorGain;
        private System.Windows.Forms.Label lblStanleyGain;
        private System.Windows.Forms.HScrollBar hsbarStanleyGain;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblHeadingErrorGain;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblSteerAngle;
        private System.Windows.Forms.Label lblSteerAngleActual;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnFreeDriveZero;
        private AgLibrary.Controls.RepeatButton btnSteerAngleDown;
        private AgLibrary.Controls.RepeatButton btnSteerAngleUp;
        private System.Windows.Forms.Label lblPWMDisplay;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabGain;
        private System.Windows.Forms.TabPage tabStan;
        private System.Windows.Forms.TabPage tabInt;
        private System.Windows.Forms.Button btnStartSA;
        private System.Windows.Forms.Label lblCalcSteerAngleInner;
        private System.Windows.Forms.Label lblDiameter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TabPage tabSteer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ProgressBar pbarRight;
        private System.Windows.Forms.ProgressBar pbarLeft;
        private System.Windows.Forms.Button btnZeroWAS;
        private System.Windows.Forms.HScrollBar hsbarCountsPerDegree;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblCountsPerDegree;
        private System.Windows.Forms.HScrollBar hsbarWasOffset;
        private System.Windows.Forms.Label lblSteerAngleSensorZero;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.HScrollBar hsbarIntegral;
        private System.Windows.Forms.HScrollBar hsbarIntegralPurePursuit;
        private System.Windows.Forms.Label lblIntegralPercent;
        private System.Windows.Forms.Label lblPureIntegral;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ProgressBar pbarSensor;
        private System.Windows.Forms.Label lblPercentFS;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label labelPressureTurnSensor;
        private System.Windows.Forms.Label labelCurrentTurnSensor;
        private System.Windows.Forms.Label labelEncoder;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.ComboBox cboxMotorDrive;
        private System.Windows.Forms.ComboBox cboxSteerEnable;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.ComboBox cboxConv;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.Label label61;
        private NudlessNumericUpDown nudMaxCounts;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.CheckBox cboxCurrentSensor;
        private System.Windows.Forms.CheckBox cboxPressureSensor;
        private System.Windows.Forms.CheckBox cboxDanfoss;
        private System.Windows.Forms.CheckBox chkSteerInvertRelays;
        private System.Windows.Forms.CheckBox chkInvertSteer;
        private System.Windows.Forms.CheckBox cboxEncoder;
        private System.Windows.Forms.CheckBox chkInvertWAS;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.HScrollBar hsbarSensor;
        private System.Windows.Forms.Label lblhsbarSensor;
        private System.Windows.Forms.TabControl tabWiz;
        private System.Windows.Forms.TabPage tabStart;
        private System.Windows.Forms.TabPage tabMotorDriver;
        private System.Windows.Forms.TabPage tabMotorDirection;
        private System.Windows.Forms.Button btnSteerLeft;
        private System.Windows.Forms.Button btnSteerRight;
        private System.Windows.Forms.TabPage tabWAS;
        private System.Windows.Forms.TabPage tabButtonSwitch;
        private System.Windows.Forms.Button btnStartWizard;
        private System.Windows.Forms.Button btnStopWizard;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TabPage tabCancelGuidance;
        private System.Windows.Forms.TabPage tabWAS_Zero;
        private System.Windows.Forms.TabPage tabCountsPerDeg;
        private System.Windows.Forms.Button btnOkWAS;
        private System.Windows.Forms.Button btnOkNext_MotorDriver;
        private System.Windows.Forms.Button btnOkNext_MotorDirection;
        private System.Windows.Forms.Button btnOkNext_WAS_Zero;
        private System.Windows.Forms.Button btnOkNext_CountsPerDeg;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnOkNext_ButtonSwitch;
        private System.Windows.Forms.TabPage tabMaxSteerAngle;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button btnOkNextMaxSteerAngle;
        private System.Windows.Forms.TabPage tabA2DConv;
        private System.Windows.Forms.Button btnOkNext_A2D;
        private System.Windows.Forms.TabPage tabInvertRelays;
        private System.Windows.Forms.TabPage tabDanfoss;
        private System.Windows.Forms.Button btnOkNext_InvertRelays;
        private System.Windows.Forms.Button btnOkNext_Danfoss;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Button btnOkNextCancelGuidance;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Button btnSteerStatus;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TabPage tabPanicStop;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Button btnOkNext_PanicStop;
        private System.Windows.Forms.Button btnPrev_A2D;
        private System.Windows.Forms.Button btnPrev_MotorDriver;
        private System.Windows.Forms.Button btnPrev_InvertRelays;
        private System.Windows.Forms.Button btnPrev_Danfoss;
        private System.Windows.Forms.Button btnPrev_InvertWAS;
        private System.Windows.Forms.Button btnPrev_MotorDirection;
        private System.Windows.Forms.Button btnPrev_CountsPerDegree;
        private System.Windows.Forms.Button btnPrev_MaxSteerAngle;
        private System.Windows.Forms.Button btnPrev_CancelGuidance;
        private System.Windows.Forms.Button btnPrev_Panic;
        private System.Windows.Forms.TabPage tabEnd;
        private System.Windows.Forms.Button btnPrev_End;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.ProgressBar pbarProgress;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.TabPage tabCPD_Setup;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.Label label75;
        private System.Windows.Forms.Button btnSkipCPD_Setup;
        private System.Windows.Forms.Button btnOKNext_CPDSetup;
        private System.Windows.Forms.Button btnRestartWizard;
        private System.Windows.Forms.Button btnRemoveWasOffset;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Button btnLoadDefaults;
        private System.Windows.Forms.Label lblBarCPD;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.Label lblBarAck;
        private System.Windows.Forms.Timer sideBarTimer;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.Label lblBarWasOffset;
        private System.Windows.Forms.Label lblCPDError;
        private System.Windows.Forms.Button btnCloseAll;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TabPage tab_MinimumGain;
        private System.Windows.Forms.Button btnPrev_Gain;
        private System.Windows.Forms.Button btnOK_Next;
        private System.Windows.Forms.Button btnMinGainRight;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.Button btnOkSetMaximumSteerAngle;
        private System.Windows.Forms.Label label73;
        private System.Windows.Forms.Label label76;
        private System.Windows.Forms.Label label77;
        private System.Windows.Forms.Button btnZeroMinMovementSetting;
        private System.Windows.Forms.Label label79;
        private System.Windows.Forms.Label label78;
        private System.Windows.Forms.Button btnMinGainLeft;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.TabPage tabLoadDef;
        private System.Windows.Forms.Label label81;
        private System.Windows.Forms.Label label80;
        private System.Windows.Forms.Button btnOkNext_LoadDefault;
        private System.Windows.Forms.TabPage tabPGain;
        private System.Windows.Forms.Label label88;
        private System.Windows.Forms.Label label83;
        private System.Windows.Forms.Label label84;
        private System.Windows.Forms.Button btnLeftPGain;
        private System.Windows.Forms.Button btnZeroPGain;
        private System.Windows.Forms.Label label85;
        private System.Windows.Forms.Label label86;
        private System.Windows.Forms.Button btnRightPGain;
        private System.Windows.Forms.Label label87;
        private System.Windows.Forms.Button btnPrev_PGain;
        private System.Windows.Forms.Button btnNext_PGain;
        private System.Windows.Forms.TabPage tabWheelBase;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label90;
        private NudlessNumericUpDown nudWheelbase;
        private System.Windows.Forms.Label label91;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage tabWheelTrack;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label94;
        private NudlessNumericUpDown nudVehicleTrack;
        private System.Windows.Forms.Label label95;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TabPage tabAntennaDistance;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label98;
        private NudlessNumericUpDown nudAntennaPivot;
        private System.Windows.Forms.Label label99;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TabPage tabAntennaOffset;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label label102;
        private NudlessNumericUpDown nudAntennaOffset;
        private System.Windows.Forms.Label label103;
        private System.Windows.Forms.Label label104;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.TabPage tabAntennaHeight;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Label label92;
        private NudlessNumericUpDown nudAntennaHeight;
        private System.Windows.Forms.Label label93;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.TabPage tabRollInv;
        private System.Windows.Forms.Label label89;
        private System.Windows.Forms.Label label96;
        private System.Windows.Forms.Label label97;
        private System.Windows.Forms.Label label100;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.TabPage tabAckCPD;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Label lblAckermannError;
        private System.Windows.Forms.Label label105;
        private System.Windows.Forms.Label label106;
        private System.Windows.Forms.Label label108;
        private System.Windows.Forms.Label lblDiameterLeft;
        private System.Windows.Forms.Label lblCalcSteerAngleLeft;
        private System.Windows.Forms.Label label111;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button btnStartSA_Left;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.HScrollBar hsbarAckerman;
        private System.Windows.Forms.Label lblAckerman;
        private System.Windows.Forms.Label label101;
        private System.Windows.Forms.Label lblStartAngleLeft;
        private System.Windows.Forms.Button btnAckReset;
        private System.Windows.Forms.Label lblCurrentHeading;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Label lblRoll;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.CheckBox cboxDataInvertRoll;
        private System.Windows.Forms.TabPage tabRollZero;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Label label107;
        private System.Windows.Forms.Label lblRoll2;
        private System.Windows.Forms.Label label110;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label lblRollZeroOffset;
        private System.Windows.Forms.Button btnZeroRoll;
        private System.Windows.Forms.Button btnRemoveZeroOffset;
        private System.Windows.Forms.Label label109;
        private System.Windows.Forms.Label lblRightStartAngle;
        private System.Windows.Forms.Label label112;
        private System.Windows.Forms.Label label113;
        private System.Windows.Forms.Label label114;
        private System.Windows.Forms.Label label115;
        private System.Windows.Forms.Label label116;
        private System.Windows.Forms.Label label117;
        private System.Windows.Forms.Label label118;
        private System.Windows.Forms.Label lblSideHillComp;
        private System.Windows.Forms.HScrollBar hsbarSideHillComp;
        private System.Windows.Forms.HScrollBar hsbarLookAheadMult;
    }
}
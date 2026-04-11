namespace AgOpenGPS
{
    partial class FormSteer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSteer));
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
            labelSteerAngle = new System.Windows.Forms.Label();
            labelDiameter = new System.Windows.Forms.Label();
            lblCalcSteerAngleInner = new System.Windows.Forms.Label();
            lblDiameter = new System.Windows.Forms.Label();
            pbarSensor = new System.Windows.Forms.ProgressBar();
            lblPercentFS = new System.Windows.Forms.Label();
            tabControl1 = new System.Windows.Forms.TabControl();
            tabPP = new System.Windows.Forms.TabPage();
            labelAcquire = new System.Windows.Forms.Label();
            labelIntegralInfo = new System.Windows.Forms.Label();
            labelSlow = new System.Windows.Forms.Label();
            labelFast = new System.Windows.Forms.Label();
            labelSteerResponse = new System.Windows.Forms.Label();
            lblHoldLookAhead = new System.Windows.Forms.Label();
            hsbarHoldLookAhead = new System.Windows.Forms.HScrollBar();
            hsbarIntegralPurePursuit = new System.Windows.Forms.HScrollBar();
            label26 = new System.Windows.Forms.Label();
            labelIntegralPP = new System.Windows.Forms.Label();
            label20 = new System.Windows.Forms.Label();
            label18 = new System.Windows.Forms.Label();
            lblAcquirePP = new System.Windows.Forms.Label();
            lblPureIntegral = new System.Windows.Forms.Label();
            tabStan = new System.Windows.Forms.TabPage();
            lblIntegralPercent = new System.Windows.Forms.Label();
            hsbarIntegral = new System.Windows.Forms.HScrollBar();
            labelIntergralStanley = new System.Windows.Forms.Label();
            label25 = new System.Windows.Forms.Label();
            lblHeadingErrorGain = new System.Windows.Forms.Label();
            lblStanleyGain = new System.Windows.Forms.Label();
            labelHeading = new System.Windows.Forms.Label();
            labelDistance = new System.Windows.Forms.Label();
            hsbarStanleyGain = new System.Windows.Forms.HScrollBar();
            hsbarHeadingErrorGain = new System.Windows.Forms.HScrollBar();
            tabSteer = new System.Windows.Forms.TabPage();
            labelMaxSteerAngle = new System.Windows.Forms.Label();
            lblAV_Set = new System.Windows.Forms.Label();
            lblAV_Act = new System.Windows.Forms.Label();
            lblMaxSteerAngle = new System.Windows.Forms.Label();
            label36 = new System.Windows.Forms.Label();
            labelAckermann = new System.Windows.Forms.Label();
            label38 = new System.Windows.Forms.Label();
            labelCountsPerDegree = new System.Windows.Forms.Label();
            hsbarAckerman = new System.Windows.Forms.HScrollBar();
            hsbarMaxSteerAngle = new System.Windows.Forms.HScrollBar();
            lblAckerman = new System.Windows.Forms.Label();
            pbarRight = new System.Windows.Forms.ProgressBar();
            pbarLeft = new System.Windows.Forms.ProgressBar();
            lblActualSteerAngleUpper = new System.Windows.Forms.Label();
            btnZeroWAS = new System.Windows.Forms.Button();
            hsbarCountsPerDegree = new System.Windows.Forms.HScrollBar();
            labelWasZero = new System.Windows.Forms.Label();
            lblCountsPerDegree = new System.Windows.Forms.Label();
            hsbarWasOffset = new System.Windows.Forms.HScrollBar();
            lblSteerAngleSensorZero = new System.Windows.Forms.Label();
            tabPPAdv = new System.Windows.Forms.TabPage();
            labelAcquireFactor = new System.Windows.Forms.Label();
            lblDistanceAdv = new System.Windows.Forms.Label();
            hsbarLookAheadMult = new System.Windows.Forms.HScrollBar();
            labelDist = new System.Windows.Forms.Label();
            lblLookAheadMult = new System.Windows.Forms.Label();
            lblHoldAdv = new System.Windows.Forms.Label();
            labelSpeedFactor = new System.Windows.Forms.Label();
            lblAcqAdv = new System.Windows.Forms.Label();
            labelDeadzone = new System.Windows.Forms.Label();
            hsbarAcquireFactor = new System.Windows.Forms.HScrollBar();
            labelAcquire2 = new System.Windows.Forms.Label();
            lblAcquireFactor = new System.Windows.Forms.Label();
            labelHold = new System.Windows.Forms.Label();
            labelAcquireDescription = new System.Windows.Forms.Label();
            labelOnDelay = new System.Windows.Forms.Label();
            labelHeadingDegree = new System.Windows.Forms.Label();
            nudDeadZoneDelay = new NudlessNumericUpDown();
            nudDeadZoneHeading = new NudlessNumericUpDown();
            tabGain = new System.Windows.Forms.TabPage();
            label6 = new System.Windows.Forms.Label();
            labelMinToMove = new System.Windows.Forms.Label();
            labelMaxLimit = new System.Windows.Forms.Label();
            labelProportionalGain = new System.Windows.Forms.Label();
            hsbarMinPWM = new System.Windows.Forms.HScrollBar();
            hsbarProportionalGain = new System.Windows.Forms.HScrollBar();
            lblProportionalGain = new System.Windows.Forms.Label();
            lblHighSteerPWM = new System.Windows.Forms.Label();
            lblMinPWM = new System.Windows.Forms.Label();
            hsbarHighSteerPWM = new System.Windows.Forms.HScrollBar();
            imageList1 = new System.Windows.Forms.ImageList(components);
            lblSideHillComp = new System.Windows.Forms.Label();
            hsbarSideHillComp = new System.Windows.Forms.HScrollBar();
            labelSideHill = new System.Windows.Forms.Label();
            labelSteerDescription = new System.Windows.Forms.Label();
            labelPressureTurnSensor = new System.Windows.Forms.Label();
            labelCurrentTurnSensor = new System.Windows.Forms.Label();
            labelEncoder = new System.Windows.Forms.Label();
            labelInvertMotor = new System.Windows.Forms.Label();
            labelInvertRelays = new System.Windows.Forms.Label();
            labelSendAndSave = new System.Windows.Forms.Label();
            cboxMotorDrive = new System.Windows.Forms.ComboBox();
            cboxSteerEnable = new System.Windows.Forms.ComboBox();
            labelSteerEnable = new System.Windows.Forms.Label();
            cboxConv = new System.Windows.Forms.ComboBox();
            labelMotorDriver = new System.Windows.Forms.Label();
            labelADConverter = new System.Windows.Forms.Label();
            labelTurnSensor = new System.Windows.Forms.Label();
            label55 = new System.Windows.Forms.Label();
            labelInvertWas = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            btnExpand = new AgLibrary.Controls.RepeatButton();
            panel1 = new System.Windows.Forms.Panel();
            btnStartSA = new System.Windows.Forms.Button();
            btnFreeDriveZero = new System.Windows.Forms.Button();
            btnSteerAngleUp = new AgLibrary.Controls.RepeatButton();
            btnFreeDrive = new System.Windows.Forms.Button();
            btnSteerAngleDown = new AgLibrary.Controls.RepeatButton();
            hsbarSensor = new System.Windows.Forms.HScrollBar();
            lblhsbarSensor = new System.Windows.Forms.Label();
            labelReset = new System.Windows.Forms.Label();
            cboxXY = new System.Windows.Forms.ComboBox();
            labelIMUAxis = new System.Windows.Forms.Label();
            label34 = new System.Windows.Forms.Label();
            tabSteerSettings = new System.Windows.Forms.TabControl();
            tabSensors = new System.Windows.Forms.TabPage();
            nudMaxCounts = new NudlessNumericUpDown();
            cboxCurrentSensor = new System.Windows.Forms.CheckBox();
            cboxEncoder = new System.Windows.Forms.CheckBox();
            cboxPressureSensor = new System.Windows.Forms.CheckBox();
            tabConfig = new System.Windows.Forms.TabPage();
            chkInvertWAS = new System.Windows.Forms.CheckBox();
            chkInvertSteer = new System.Windows.Forms.CheckBox();
            chkSteerInvertRelays = new System.Windows.Forms.CheckBox();
            cboxDanfoss = new System.Windows.Forms.CheckBox();
            tabSettings = new System.Windows.Forms.TabPage();
            grpSmartWAS = new System.Windows.Forms.GroupBox();
            lblSmartCalStatus = new System.Windows.Forms.Label();
            btnSmartZeroWAS = new System.Windows.Forms.Button();
            lblSmartCalConfidence = new System.Windows.Forms.Label();
            lblSmartCalSamples = new System.Windows.Forms.Label();
            labelSteerInReverse = new System.Windows.Forms.Label();
            label41 = new System.Windows.Forms.Label();
            label39 = new System.Windows.Forms.Label();
            hsbarUTurnCompensation = new System.Windows.Forms.HScrollBar();
            lblUTurnCompensation = new System.Windows.Forms.Label();
            labelUturnCompensation = new System.Windows.Forms.Label();
            cboxSteerInReverse = new System.Windows.Forms.CheckBox();
            btnStanleyPure = new System.Windows.Forms.Button();
            tabAlarm = new System.Windows.Forms.TabPage();
            labelMinSpeed = new System.Windows.Forms.Label();
            label166 = new System.Windows.Forms.Label();
            labelMaxSpeed = new System.Windows.Forms.Label();
            label163 = new System.Windows.Forms.Label();
            label160 = new System.Windows.Forms.Label();
            labelManualTurns = new System.Windows.Forms.Label();
            pictureBox17 = new System.Windows.Forms.PictureBox();
            pictureBox16 = new System.Windows.Forms.PictureBox();
            pictureBox10 = new System.Windows.Forms.PictureBox();
            nudMinSteerSpeed = new NudlessNumericUpDown();
            nudMaxSteerSpeed = new NudlessNumericUpDown();
            nudGuidanceSpeedLimit = new NudlessNumericUpDown();
            tabOnTheLine = new System.Windows.Forms.TabPage();
            labelLineWidth = new System.Windows.Forms.Label();
            label44 = new System.Windows.Forms.Label();
            labelNudgeDistance = new System.Windows.Forms.Label();
            label43 = new System.Windows.Forms.Label();
            groupboxlabelGuidanceBar = new System.Windows.Forms.GroupBox();
            rbtnSteerBar = new System.Windows.Forms.RadioButton();
            labelSteerBar = new System.Windows.Forms.Label();
            labelOnOff = new System.Windows.Forms.Label();
            rbtnLightBar = new System.Windows.Forms.RadioButton();
            labelLightbar = new System.Windows.Forms.Label();
            chkDisplayLightbar = new System.Windows.Forms.CheckBox();
            labelCmPix = new System.Windows.Forms.Label();
            label107 = new System.Windows.Forms.Label();
            label46 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            labelNextGuidanceLine = new System.Windows.Forms.Label();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            pictureBox12 = new System.Windows.Forms.PictureBox();
            pictureBox5 = new System.Windows.Forms.PictureBox();
            nudcmPerPixel = new NudlessNumericUpDown();
            nudLineWidth = new NudlessNumericUpDown();
            nudSnapDistance = new NudlessNumericUpDown();
            nudGuidanceLookAhead = new NudlessNumericUpDown();
            imageList2 = new System.Windows.Forms.ImageList(components);
            labelWizard = new System.Windows.Forms.Label();
            btnSteerWizard = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            pboxSendSteer = new System.Windows.Forms.PictureBox();
            btnSendSteerConfigPGN = new System.Windows.Forms.Button();
            btnClose = new System.Windows.Forms.Button();
            tabControl1.SuspendLayout();
            tabPP.SuspendLayout();
            tabStan.SuspendLayout();
            tabSteer.SuspendLayout();
            tabPPAdv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudDeadZoneDelay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudDeadZoneHeading).BeginInit();
            tabGain.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            tabSteerSettings.SuspendLayout();
            tabSensors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudMaxCounts).BeginInit();
            tabConfig.SuspendLayout();
            tabSettings.SuspendLayout();
            grpSmartWAS.SuspendLayout();
            tabAlarm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox17).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox16).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMinSteerSpeed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMaxSteerSpeed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudGuidanceSpeedLimit).BeginInit();
            tabOnTheLine.SuspendLayout();
            groupboxlabelGuidanceBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudcmPerPixel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudLineWidth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSnapDistance).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudGuidanceLookAhead).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxSendSteer).BeginInit();
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
            lblSteerAngle.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblSteerAngle.BackColor = System.Drawing.Color.Transparent;
            lblSteerAngle.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblSteerAngle.ForeColor = System.Drawing.Color.Black;
            lblSteerAngle.Location = new System.Drawing.Point(32, 8);
            lblSteerAngle.Name = "lblSteerAngle";
            lblSteerAngle.Size = new System.Drawing.Size(71, 23);
            lblSteerAngle.TabIndex = 306;
            lblSteerAngle.Text = "-55.5";
            lblSteerAngle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            lblSteerAngle.Click += expandWindow_Click;
            // 
            // lblSteerAngleActual
            // 
            lblSteerAngleActual.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblSteerAngleActual.BackColor = System.Drawing.Color.Transparent;
            lblSteerAngleActual.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblSteerAngleActual.ForeColor = System.Drawing.Color.Black;
            lblSteerAngleActual.Location = new System.Drawing.Point(131, 8);
            lblSteerAngleActual.Name = "lblSteerAngleActual";
            lblSteerAngleActual.Size = new System.Drawing.Size(71, 23);
            lblSteerAngleActual.TabIndex = 311;
            lblSteerAngleActual.Text = "-55.5";
            lblSteerAngleActual.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            lblSteerAngleActual.Click += expandWindow_Click;
            // 
            // lblError
            // 
            lblError.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblError.BackColor = System.Drawing.Color.Transparent;
            lblError.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblError.ForeColor = System.Drawing.Color.Black;
            lblError.Location = new System.Drawing.Point(225, 8);
            lblError.Name = "lblError";
            lblError.Size = new System.Drawing.Size(71, 23);
            lblError.TabIndex = 312;
            lblError.Text = "-30.0";
            lblError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            lblError.Click += expandWindow_Click;
            // 
            // lblPWMDisplay
            // 
            lblPWMDisplay.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblPWMDisplay.BackColor = System.Drawing.Color.Transparent;
            lblPWMDisplay.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblPWMDisplay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lblPWMDisplay.Location = new System.Drawing.Point(78, 76);
            lblPWMDisplay.Name = "lblPWMDisplay";
            lblPWMDisplay.Size = new System.Drawing.Size(64, 23);
            lblPWMDisplay.TabIndex = 316;
            lblPWMDisplay.Text = "255";
            lblPWMDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            label9.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label9.BackColor = System.Drawing.Color.Transparent;
            label9.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label9.Location = new System.Drawing.Point(17, 76);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(64, 23);
            label9.TabIndex = 318;
            label9.Text = "PWM:";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            label11.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label11.AutoSize = true;
            label11.BackColor = System.Drawing.Color.Transparent;
            label11.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label11.ForeColor = System.Drawing.Color.Black;
            label11.Location = new System.Drawing.Point(101, 11);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(30, 16);
            label11.TabIndex = 319;
            label11.Text = "Act:";
            label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            label11.Click += expandWindow_Click;
            // 
            // label12
            // 
            label12.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label12.AutoSize = true;
            label12.BackColor = System.Drawing.Color.Transparent;
            label12.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label12.ForeColor = System.Drawing.Color.Black;
            label12.Location = new System.Drawing.Point(4, 11);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(31, 16);
            label12.TabIndex = 320;
            label12.Text = "Set:";
            label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            label12.Click += expandWindow_Click;
            // 
            // label13
            // 
            label13.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label13.AutoSize = true;
            label13.BackColor = System.Drawing.Color.Transparent;
            label13.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label13.ForeColor = System.Drawing.Color.Black;
            label13.Location = new System.Drawing.Point(198, 11);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(29, 16);
            label13.TabIndex = 321;
            label13.Text = "Err:";
            label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            label13.Click += expandWindow_Click;
            // 
            // label14
            // 
            label14.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label14.AutoSize = true;
            label14.BackColor = System.Drawing.Color.Transparent;
            label14.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label14.Location = new System.Drawing.Point(289, 77);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(45, 16);
            label14.TabIndex = 322;
            label14.Text = "Or +5";
            label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSteerAngle
            // 
            labelSteerAngle.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelSteerAngle.AutoSize = true;
            labelSteerAngle.BackColor = System.Drawing.Color.Transparent;
            labelSteerAngle.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelSteerAngle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            labelSteerAngle.Location = new System.Drawing.Point(113, 113);
            labelSteerAngle.Name = "labelSteerAngle";
            labelSteerAngle.Size = new System.Drawing.Size(114, 23);
            labelSteerAngle.TabIndex = 328;
            labelSteerAngle.Text = "Steer Angle:";
            labelSteerAngle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelDiameter
            // 
            labelDiameter.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelDiameter.AutoSize = true;
            labelDiameter.BackColor = System.Drawing.Color.Transparent;
            labelDiameter.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelDiameter.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            labelDiameter.Location = new System.Drawing.Point(115, 148);
            labelDiameter.Name = "labelDiameter";
            labelDiameter.Size = new System.Drawing.Size(93, 23);
            labelDiameter.TabIndex = 327;
            labelDiameter.Text = "Diameter:";
            labelDiameter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCalcSteerAngleInner
            // 
            lblCalcSteerAngleInner.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblCalcSteerAngleInner.AutoSize = true;
            lblCalcSteerAngleInner.BackColor = System.Drawing.Color.Transparent;
            lblCalcSteerAngleInner.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblCalcSteerAngleInner.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lblCalcSteerAngleInner.Location = new System.Drawing.Point(294, 113);
            lblCalcSteerAngleInner.Name = "lblCalcSteerAngleInner";
            lblCalcSteerAngleInner.Size = new System.Drawing.Size(40, 23);
            lblCalcSteerAngleInner.TabIndex = 326;
            lblCalcSteerAngleInner.Text = "0.0";
            lblCalcSteerAngleInner.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDiameter
            // 
            lblDiameter.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblDiameter.AutoSize = true;
            lblDiameter.BackColor = System.Drawing.Color.Transparent;
            lblDiameter.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblDiameter.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lblDiameter.Location = new System.Drawing.Point(294, 148);
            lblDiameter.Name = "lblDiameter";
            lblDiameter.Size = new System.Drawing.Size(64, 23);
            lblDiameter.TabIndex = 325;
            lblDiameter.Text = "0.0 m";
            lblDiameter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbarSensor
            // 
            pbarSensor.BackColor = System.Drawing.Color.White;
            pbarSensor.Location = new System.Drawing.Point(187, 205);
            pbarSensor.Maximum = 255;
            pbarSensor.Name = "pbarSensor";
            pbarSensor.Size = new System.Drawing.Size(257, 53);
            pbarSensor.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            pbarSensor.TabIndex = 496;
            // 
            // lblPercentFS
            // 
            lblPercentFS.AutoSize = true;
            lblPercentFS.BackColor = System.Drawing.Color.Transparent;
            lblPercentFS.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblPercentFS.ForeColor = System.Drawing.Color.Black;
            lblPercentFS.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            lblPercentFS.Location = new System.Drawing.Point(450, 216);
            lblPercentFS.Name = "lblPercentFS";
            lblPercentFS.Size = new System.Drawing.Size(57, 29);
            lblPercentFS.TabIndex = 495;
            lblPercentFS.Text = "0%";
            lblPercentFS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            tabControl1.Controls.Add(tabPP);
            tabControl1.Controls.Add(tabStan);
            tabControl1.Controls.Add(tabSteer);
            tabControl1.Controls.Add(tabPPAdv);
            tabControl1.Controls.Add(tabGain);
            tabControl1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tabControl1.ImageList = imageList1;
            tabControl1.ItemSize = new System.Drawing.Size(65, 48);
            tabControl1.Location = new System.Drawing.Point(2, 5);
            tabControl1.Margin = new System.Windows.Forms.Padding(4);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(373, 402);
            tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            tabControl1.TabIndex = 347;
            // 
            // tabPP
            // 
            tabPP.BackColor = System.Drawing.Color.Gainsboro;
            tabPP.BackgroundImage = Properties.Resources.Sf_PP;
            tabPP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            tabPP.Controls.Add(labelAcquire);
            tabPP.Controls.Add(labelIntegralInfo);
            tabPP.Controls.Add(labelSlow);
            tabPP.Controls.Add(labelFast);
            tabPP.Controls.Add(labelSteerResponse);
            tabPP.Controls.Add(lblHoldLookAhead);
            tabPP.Controls.Add(hsbarHoldLookAhead);
            tabPP.Controls.Add(hsbarIntegralPurePursuit);
            tabPP.Controls.Add(label26);
            tabPP.Controls.Add(labelIntegralPP);
            tabPP.Controls.Add(label20);
            tabPP.Controls.Add(label18);
            tabPP.Controls.Add(lblAcquirePP);
            tabPP.Controls.Add(lblPureIntegral);
            tabPP.ForeColor = System.Drawing.Color.Black;
            tabPP.ImageIndex = 3;
            tabPP.Location = new System.Drawing.Point(4, 52);
            tabPP.Name = "tabPP";
            tabPP.Size = new System.Drawing.Size(365, 346);
            tabPP.TabIndex = 16;
            // 
            // labelAcquire
            // 
            labelAcquire.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelAcquire.ForeColor = System.Drawing.Color.Black;
            labelAcquire.Location = new System.Drawing.Point(85, 159);
            labelAcquire.Name = "labelAcquire";
            labelAcquire.Size = new System.Drawing.Size(111, 24);
            labelAcquire.TabIndex = 548;
            labelAcquire.Text = "Acquire:";
            labelAcquire.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            labelAcquire.Visible = false;
            // 
            // labelIntegralInfo
            // 
            labelIntegralInfo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelIntegralInfo.ForeColor = System.Drawing.Color.Black;
            labelIntegralInfo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            labelIntegralInfo.Location = new System.Drawing.Point(6, 290);
            labelIntegralInfo.Name = "labelIntegralInfo";
            labelIntegralInfo.Size = new System.Drawing.Size(288, 46);
            labelIntegralInfo.TabIndex = 361;
            labelIntegralInfo.Text = "It will slowly increase steer angle to reduce cross track error";
            labelIntegralInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelSlow
            // 
            labelSlow.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelSlow.ForeColor = System.Drawing.Color.Black;
            labelSlow.Location = new System.Drawing.Point(279, 64);
            labelSlow.Name = "labelSlow";
            labelSlow.Size = new System.Drawing.Size(84, 19);
            labelSlow.TabIndex = 360;
            labelSlow.Text = "Slow";
            labelSlow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelFast
            // 
            labelFast.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelFast.ForeColor = System.Drawing.Color.Black;
            labelFast.Location = new System.Drawing.Point(10, 64);
            labelFast.Name = "labelFast";
            labelFast.Size = new System.Drawing.Size(72, 19);
            labelFast.TabIndex = 358;
            labelFast.Text = "Fast";
            labelFast.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSteerResponse
            // 
            labelSteerResponse.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelSteerResponse.ForeColor = System.Drawing.Color.Black;
            labelSteerResponse.Location = new System.Drawing.Point(81, 60);
            labelSteerResponse.Name = "labelSteerResponse";
            labelSteerResponse.Size = new System.Drawing.Size(196, 24);
            labelSteerResponse.TabIndex = 356;
            labelSteerResponse.Text = "Steer Response";
            labelSteerResponse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHoldLookAhead
            // 
            lblHoldLookAhead.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblHoldLookAhead.ForeColor = System.Drawing.Color.Black;
            lblHoldLookAhead.Location = new System.Drawing.Point(3, 83);
            lblHoldLookAhead.Name = "lblHoldLookAhead";
            lblHoldLookAhead.Size = new System.Drawing.Size(47, 35);
            lblHoldLookAhead.TabIndex = 355;
            lblHoldLookAhead.Text = "5.2";
            lblHoldLookAhead.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // hsbarHoldLookAhead
            // 
            hsbarHoldLookAhead.LargeChange = 1;
            hsbarHoldLookAhead.Location = new System.Drawing.Point(53, 86);
            hsbarHoldLookAhead.Maximum = 70;
            hsbarHoldLookAhead.Minimum = 10;
            hsbarHoldLookAhead.Name = "hsbarHoldLookAhead";
            hsbarHoldLookAhead.Size = new System.Drawing.Size(264, 30);
            hsbarHoldLookAhead.TabIndex = 354;
            hsbarHoldLookAhead.Value = 25;
            hsbarHoldLookAhead.ValueChanged += hsbarHoldLookAhead_ValueChanged;
            // 
            // hsbarIntegralPurePursuit
            // 
            hsbarIntegralPurePursuit.LargeChange = 1;
            hsbarIntegralPurePursuit.Location = new System.Drawing.Point(53, 239);
            hsbarIntegralPurePursuit.Name = "hsbarIntegralPurePursuit";
            hsbarIntegralPurePursuit.Size = new System.Drawing.Size(264, 30);
            hsbarIntegralPurePursuit.TabIndex = 349;
            hsbarIntegralPurePursuit.Value = 5;
            hsbarIntegralPurePursuit.ValueChanged += hsbarIntegralPurePursuit_ValueChanged;
            // 
            // label26
            // 
            label26.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label26.ForeColor = System.Drawing.Color.SteelBlue;
            label26.Location = new System.Drawing.Point(8, 3);
            label26.Name = "label26";
            label26.Size = new System.Drawing.Size(351, 26);
            label26.TabIndex = 348;
            label26.Text = "Pure Pursuit";
            label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelIntegralPP
            // 
            labelIntegralPP.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelIntegralPP.ForeColor = System.Drawing.Color.Black;
            labelIntegralPP.Location = new System.Drawing.Point(53, 213);
            labelIntegralPP.Name = "labelIntegralPP";
            labelIntegralPP.Size = new System.Drawing.Size(264, 24);
            labelIntegralPP.TabIndex = 342;
            labelIntegralPP.Text = "Integral";
            labelIntegralPP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            labelIntegralPP.UseCompatibleTextRendering = true;
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
            // lblAcquirePP
            // 
            lblAcquirePP.AutoSize = true;
            lblAcquirePP.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblAcquirePP.ForeColor = System.Drawing.Color.Black;
            lblAcquirePP.Location = new System.Drawing.Point(192, 163);
            lblAcquirePP.Name = "lblAcquirePP";
            lblAcquirePP.Size = new System.Drawing.Size(34, 19);
            lblAcquirePP.TabIndex = 515;
            lblAcquirePP.Text = "2.6";
            lblAcquirePP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            lblAcquirePP.Visible = false;
            // 
            // lblPureIntegral
            // 
            lblPureIntegral.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblPureIntegral.ForeColor = System.Drawing.Color.Black;
            lblPureIntegral.Location = new System.Drawing.Point(5, 236);
            lblPureIntegral.Name = "lblPureIntegral";
            lblPureIntegral.Size = new System.Drawing.Size(50, 35);
            lblPureIntegral.TabIndex = 350;
            lblPureIntegral.Text = "20";
            lblPureIntegral.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabStan
            // 
            tabStan.BackColor = System.Drawing.Color.Gainsboro;
            tabStan.BackgroundImage = Properties.Resources.Sf_Stanley;
            tabStan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            tabStan.Controls.Add(lblIntegralPercent);
            tabStan.Controls.Add(hsbarIntegral);
            tabStan.Controls.Add(labelIntergralStanley);
            tabStan.Controls.Add(label25);
            tabStan.Controls.Add(lblHeadingErrorGain);
            tabStan.Controls.Add(lblStanleyGain);
            tabStan.Controls.Add(labelHeading);
            tabStan.Controls.Add(labelDistance);
            tabStan.Controls.Add(hsbarStanleyGain);
            tabStan.Controls.Add(hsbarHeadingErrorGain);
            tabStan.ImageIndex = 2;
            tabStan.Location = new System.Drawing.Point(4, 52);
            tabStan.Name = "tabStan";
            tabStan.Size = new System.Drawing.Size(365, 346);
            tabStan.TabIndex = 15;
            // 
            // lblIntegralPercent
            // 
            lblIntegralPercent.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblIntegralPercent.ForeColor = System.Drawing.Color.Black;
            lblIntegralPercent.Location = new System.Drawing.Point(3, 259);
            lblIntegralPercent.Name = "lblIntegralPercent";
            lblIntegralPercent.Size = new System.Drawing.Size(60, 35);
            lblIntegralPercent.TabIndex = 352;
            lblIntegralPercent.Text = "888";
            lblIntegralPercent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // hsbarIntegral
            // 
            hsbarIntegral.LargeChange = 1;
            hsbarIntegral.Location = new System.Drawing.Point(68, 261);
            hsbarIntegral.Name = "hsbarIntegral";
            hsbarIntegral.Size = new System.Drawing.Size(202, 30);
            hsbarIntegral.TabIndex = 351;
            hsbarIntegral.Value = 5;
            hsbarIntegral.ValueChanged += hsbarIntegral_ValueChanged;
            // 
            // labelIntergralStanley
            // 
            labelIntergralStanley.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelIntergralStanley.ForeColor = System.Drawing.Color.Black;
            labelIntergralStanley.Location = new System.Drawing.Point(63, 232);
            labelIntergralStanley.Name = "labelIntergralStanley";
            labelIntergralStanley.Size = new System.Drawing.Size(204, 24);
            labelIntergralStanley.TabIndex = 350;
            labelIntergralStanley.Text = "Integral";
            labelIntergralStanley.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            labelIntergralStanley.UseCompatibleTextRendering = true;
            // 
            // label25
            // 
            label25.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label25.ForeColor = System.Drawing.Color.Chocolate;
            label25.Location = new System.Drawing.Point(70, 3);
            label25.Name = "label25";
            label25.Size = new System.Drawing.Size(201, 31);
            label25.TabIndex = 347;
            label25.Text = "Stanley Gains";
            label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHeadingErrorGain
            // 
            lblHeadingErrorGain.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblHeadingErrorGain.ForeColor = System.Drawing.Color.Black;
            lblHeadingErrorGain.Location = new System.Drawing.Point(9, 166);
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
            lblStanleyGain.Location = new System.Drawing.Point(9, 78);
            lblStanleyGain.Name = "lblStanleyGain";
            lblStanleyGain.Size = new System.Drawing.Size(54, 35);
            lblStanleyGain.TabIndex = 299;
            lblStanleyGain.Text = "888";
            lblStanleyGain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelHeading
            // 
            labelHeading.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelHeading.ForeColor = System.Drawing.Color.Black;
            labelHeading.Location = new System.Drawing.Point(62, 140);
            labelHeading.Name = "labelHeading";
            labelHeading.Size = new System.Drawing.Size(204, 24);
            labelHeading.TabIndex = 296;
            labelHeading.Text = "Heading";
            labelHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDistance
            // 
            labelDistance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelDistance.ForeColor = System.Drawing.Color.Black;
            labelDistance.Location = new System.Drawing.Point(63, 51);
            labelDistance.Name = "labelDistance";
            labelDistance.Size = new System.Drawing.Size(204, 24);
            labelDistance.TabIndex = 298;
            labelDistance.Text = "Distance";
            labelDistance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hsbarStanleyGain
            // 
            hsbarStanleyGain.LargeChange = 1;
            hsbarStanleyGain.Location = new System.Drawing.Point(68, 80);
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
            hsbarHeadingErrorGain.Location = new System.Drawing.Point(68, 170);
            hsbarHeadingErrorGain.Maximum = 15;
            hsbarHeadingErrorGain.Minimum = 1;
            hsbarHeadingErrorGain.Name = "hsbarHeadingErrorGain";
            hsbarHeadingErrorGain.Size = new System.Drawing.Size(200, 30);
            hsbarHeadingErrorGain.TabIndex = 294;
            hsbarHeadingErrorGain.Value = 10;
            hsbarHeadingErrorGain.ValueChanged += hsbarHeadingErrorGain_ValueChanged;
            // 
            // tabSteer
            // 
            tabSteer.AutoScroll = true;
            tabSteer.BackColor = System.Drawing.Color.Gainsboro;
            tabSteer.BackgroundImage = Properties.Resources.Sf_SteerTab;
            tabSteer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            tabSteer.Controls.Add(labelMaxSteerAngle);
            tabSteer.Controls.Add(lblAV_Set);
            tabSteer.Controls.Add(lblAV_Act);
            tabSteer.Controls.Add(lblMaxSteerAngle);
            tabSteer.Controls.Add(label36);
            tabSteer.Controls.Add(labelAckermann);
            tabSteer.Controls.Add(label38);
            tabSteer.Controls.Add(labelCountsPerDegree);
            tabSteer.Controls.Add(hsbarAckerman);
            tabSteer.Controls.Add(hsbarMaxSteerAngle);
            tabSteer.Controls.Add(lblAckerman);
            tabSteer.Controls.Add(pbarRight);
            tabSteer.Controls.Add(pbarLeft);
            tabSteer.Controls.Add(lblActualSteerAngleUpper);
            tabSteer.Controls.Add(btnZeroWAS);
            tabSteer.Controls.Add(hsbarCountsPerDegree);
            tabSteer.Controls.Add(labelWasZero);
            tabSteer.Controls.Add(lblCountsPerDegree);
            tabSteer.Controls.Add(hsbarWasOffset);
            tabSteer.Controls.Add(lblSteerAngleSensorZero);
            tabSteer.ImageIndex = 0;
            tabSteer.Location = new System.Drawing.Point(4, 52);
            tabSteer.Name = "tabSteer";
            tabSteer.Size = new System.Drawing.Size(365, 346);
            tabSteer.TabIndex = 5;
            // 
            // labelMaxSteerAngle
            // 
            labelMaxSteerAngle.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelMaxSteerAngle.ForeColor = System.Drawing.Color.Black;
            labelMaxSteerAngle.Location = new System.Drawing.Point(77, 276);
            labelMaxSteerAngle.Name = "labelMaxSteerAngle";
            labelMaxSteerAngle.Size = new System.Drawing.Size(190, 24);
            labelMaxSteerAngle.TabIndex = 341;
            labelMaxSteerAngle.Text = "Max Steer Angle";
            labelMaxSteerAngle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAV_Set
            // 
            lblAV_Set.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lblAV_Set.AutoSize = true;
            lblAV_Set.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblAV_Set.Location = new System.Drawing.Point(-328, 18);
            lblAV_Set.Name = "lblAV_Set";
            lblAV_Set.Size = new System.Drawing.Size(51, 19);
            lblAV_Set.TabIndex = 529;
            lblAV_Set.Text = "-55.8";
            lblAV_Set.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAV_Act
            // 
            lblAV_Act.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lblAV_Act.AutoSize = true;
            lblAV_Act.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblAV_Act.Location = new System.Drawing.Point(-328, 42);
            lblAV_Act.Name = "lblAV_Act";
            lblAV_Act.Size = new System.Drawing.Size(54, 19);
            lblAV_Act.TabIndex = 528;
            lblAV_Act.Text = "66.89";
            lblAV_Act.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMaxSteerAngle
            // 
            lblMaxSteerAngle.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblMaxSteerAngle.ForeColor = System.Drawing.Color.Black;
            lblMaxSteerAngle.Location = new System.Drawing.Point(19, 297);
            lblMaxSteerAngle.Name = "lblMaxSteerAngle";
            lblMaxSteerAngle.Size = new System.Drawing.Size(52, 35);
            lblMaxSteerAngle.TabIndex = 303;
            lblMaxSteerAngle.Text = "888";
            lblMaxSteerAngle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label36
            // 
            label36.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label36.AutoSize = true;
            label36.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label36.Location = new System.Drawing.Point(-372, 44);
            label36.Name = "label36";
            label36.Size = new System.Drawing.Size(50, 16);
            label36.TabIndex = 530;
            label36.Text = "AV Act:";
            label36.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelAckermann
            // 
            labelAckermann.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelAckermann.ForeColor = System.Drawing.Color.Black;
            labelAckermann.Location = new System.Drawing.Point(77, 205);
            labelAckermann.Name = "labelAckermann";
            labelAckermann.Size = new System.Drawing.Size(190, 24);
            labelAckermann.TabIndex = 335;
            labelAckermann.Text = "Ackermann";
            labelAckermann.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label38
            // 
            label38.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label38.AutoSize = true;
            label38.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label38.Location = new System.Drawing.Point(-373, 20);
            label38.Name = "label38";
            label38.Size = new System.Drawing.Size(51, 16);
            label38.TabIndex = 531;
            label38.Text = "AV Set:";
            label38.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelCountsPerDegree
            // 
            labelCountsPerDegree.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelCountsPerDegree.ForeColor = System.Drawing.Color.Black;
            labelCountsPerDegree.Location = new System.Drawing.Point(77, 133);
            labelCountsPerDegree.Name = "labelCountsPerDegree";
            labelCountsPerDegree.Size = new System.Drawing.Size(190, 24);
            labelCountsPerDegree.TabIndex = 334;
            labelCountsPerDegree.Text = "Counts per Degree";
            labelCountsPerDegree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hsbarAckerman
            // 
            hsbarAckerman.LargeChange = 1;
            hsbarAckerman.Location = new System.Drawing.Point(72, 230);
            hsbarAckerman.Maximum = 200;
            hsbarAckerman.Minimum = 1;
            hsbarAckerman.Name = "hsbarAckerman";
            hsbarAckerman.Size = new System.Drawing.Size(200, 30);
            hsbarAckerman.TabIndex = 331;
            hsbarAckerman.Value = 100;
            hsbarAckerman.ValueChanged += hsbarAckerman_ValueChanged;
            // 
            // hsbarMaxSteerAngle
            // 
            hsbarMaxSteerAngle.LargeChange = 1;
            hsbarMaxSteerAngle.Location = new System.Drawing.Point(72, 299);
            hsbarMaxSteerAngle.Maximum = 80;
            hsbarMaxSteerAngle.Minimum = 10;
            hsbarMaxSteerAngle.Name = "hsbarMaxSteerAngle";
            hsbarMaxSteerAngle.Size = new System.Drawing.Size(200, 30);
            hsbarMaxSteerAngle.TabIndex = 299;
            hsbarMaxSteerAngle.Value = 10;
            hsbarMaxSteerAngle.ValueChanged += hsbarMaxSteerAngle_ValueChanged;
            // 
            // lblAckerman
            // 
            lblAckerman.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblAckerman.ForeColor = System.Drawing.Color.Black;
            lblAckerman.Location = new System.Drawing.Point(16, 228);
            lblAckerman.Name = "lblAckerman";
            lblAckerman.Size = new System.Drawing.Size(55, 35);
            lblAckerman.TabIndex = 333;
            lblAckerman.Text = "888";
            lblAckerman.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pbarRight
            // 
            pbarRight.Location = new System.Drawing.Point(171, 2);
            pbarRight.Maximum = 50;
            pbarRight.Name = "pbarRight";
            pbarRight.Size = new System.Drawing.Size(159, 10);
            pbarRight.TabIndex = 330;
            // 
            // pbarLeft
            // 
            pbarLeft.Location = new System.Drawing.Point(11, 2);
            pbarLeft.Maximum = 50;
            pbarLeft.Name = "pbarLeft";
            pbarLeft.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            pbarLeft.RightToLeftLayout = true;
            pbarLeft.Size = new System.Drawing.Size(159, 10);
            pbarLeft.TabIndex = 329;
            // 
            // lblActualSteerAngleUpper
            // 
            lblActualSteerAngleUpper.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lblActualSteerAngleUpper.AutoSize = true;
            lblActualSteerAngleUpper.BackColor = System.Drawing.Color.Transparent;
            lblActualSteerAngleUpper.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblActualSteerAngleUpper.ForeColor = System.Drawing.Color.Black;
            lblActualSteerAngleUpper.Location = new System.Drawing.Point(-567, 16);
            lblActualSteerAngleUpper.Name = "lblActualSteerAngleUpper";
            lblActualSteerAngleUpper.Size = new System.Drawing.Size(39, 19);
            lblActualSteerAngleUpper.TabIndex = 324;
            lblActualSteerAngleUpper.Text = "255";
            lblActualSteerAngleUpper.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnZeroWAS
            // 
            btnZeroWAS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            btnZeroWAS.FlatAppearance.BorderSize = 0;
            btnZeroWAS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnZeroWAS.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnZeroWAS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            btnZeroWAS.Image = Properties.Resources.SteerZero;
            btnZeroWAS.Location = new System.Drawing.Point(134, 21);
            btnZeroWAS.Name = "btnZeroWAS";
            btnZeroWAS.Size = new System.Drawing.Size(70, 30);
            btnZeroWAS.TabIndex = 323;
            btnZeroWAS.UseVisualStyleBackColor = true;
            btnZeroWAS.Click += btnZeroWAS_Click;
            // 
            // hsbarCountsPerDegree
            // 
            hsbarCountsPerDegree.LargeChange = 1;
            hsbarCountsPerDegree.Location = new System.Drawing.Point(72, 157);
            hsbarCountsPerDegree.Maximum = 255;
            hsbarCountsPerDegree.Minimum = 1;
            hsbarCountsPerDegree.Name = "hsbarCountsPerDegree";
            hsbarCountsPerDegree.Size = new System.Drawing.Size(200, 30);
            hsbarCountsPerDegree.TabIndex = 304;
            hsbarCountsPerDegree.Value = 20;
            hsbarCountsPerDegree.ValueChanged += hsbarCountsPerDegree_ValueChanged;
            // 
            // labelWasZero
            // 
            labelWasZero.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
            labelWasZero.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelWasZero.ForeColor = System.Drawing.Color.Black;
            labelWasZero.Location = new System.Drawing.Point(77, 62);
            labelWasZero.Name = "labelWasZero";
            labelWasZero.Size = new System.Drawing.Size(190, 24);
            labelWasZero.TabIndex = 295;
            labelWasZero.Text = "WAS Zero";
            labelWasZero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCountsPerDegree
            // 
            lblCountsPerDegree.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblCountsPerDegree.ForeColor = System.Drawing.Color.Black;
            lblCountsPerDegree.Location = new System.Drawing.Point(16, 155);
            lblCountsPerDegree.Name = "lblCountsPerDegree";
            lblCountsPerDegree.Size = new System.Drawing.Size(55, 35);
            lblCountsPerDegree.TabIndex = 308;
            lblCountsPerDegree.Text = "888";
            lblCountsPerDegree.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // hsbarWasOffset
            // 
            hsbarWasOffset.LargeChange = 20;
            hsbarWasOffset.Location = new System.Drawing.Point(72, 85);
            hsbarWasOffset.Maximum = 4000;
            hsbarWasOffset.Minimum = -4000;
            hsbarWasOffset.Name = "hsbarWasOffset";
            hsbarWasOffset.Size = new System.Drawing.Size(194, 30);
            hsbarWasOffset.SmallChange = 2;
            hsbarWasOffset.TabIndex = 294;
            hsbarWasOffset.ValueChanged += hsbarSteerAngleSensorZero_ValueChanged;
            // 
            // lblSteerAngleSensorZero
            // 
            lblSteerAngleSensorZero.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblSteerAngleSensorZero.ForeColor = System.Drawing.Color.Black;
            lblSteerAngleSensorZero.Location = new System.Drawing.Point(1, 83);
            lblSteerAngleSensorZero.Name = "lblSteerAngleSensorZero";
            lblSteerAngleSensorZero.Size = new System.Drawing.Size(70, 35);
            lblSteerAngleSensorZero.TabIndex = 298;
            lblSteerAngleSensorZero.Text = "-55.88";
            lblSteerAngleSensorZero.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabPPAdv
            // 
            tabPPAdv.BackColor = System.Drawing.Color.Gainsboro;
            tabPPAdv.Controls.Add(labelAcquireFactor);
            tabPPAdv.Controls.Add(lblDistanceAdv);
            tabPPAdv.Controls.Add(hsbarLookAheadMult);
            tabPPAdv.Controls.Add(labelDist);
            tabPPAdv.Controls.Add(lblLookAheadMult);
            tabPPAdv.Controls.Add(lblHoldAdv);
            tabPPAdv.Controls.Add(labelSpeedFactor);
            tabPPAdv.Controls.Add(lblAcqAdv);
            tabPPAdv.Controls.Add(labelDeadzone);
            tabPPAdv.Controls.Add(hsbarAcquireFactor);
            tabPPAdv.Controls.Add(labelAcquire2);
            tabPPAdv.Controls.Add(lblAcquireFactor);
            tabPPAdv.Controls.Add(labelHold);
            tabPPAdv.Controls.Add(labelAcquireDescription);
            tabPPAdv.Controls.Add(labelOnDelay);
            tabPPAdv.Controls.Add(labelHeadingDegree);
            tabPPAdv.Controls.Add(nudDeadZoneDelay);
            tabPPAdv.Controls.Add(nudDeadZoneHeading);
            tabPPAdv.ImageIndex = 4;
            tabPPAdv.Location = new System.Drawing.Point(4, 52);
            tabPPAdv.Name = "tabPPAdv";
            tabPPAdv.Padding = new System.Windows.Forms.Padding(3);
            tabPPAdv.Size = new System.Drawing.Size(365, 346);
            tabPPAdv.TabIndex = 17;
            // 
            // labelAcquireFactor
            // 
            labelAcquireFactor.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelAcquireFactor.ForeColor = System.Drawing.Color.Black;
            labelAcquireFactor.Location = new System.Drawing.Point(85, 208);
            labelAcquireFactor.Name = "labelAcquireFactor";
            labelAcquireFactor.Size = new System.Drawing.Size(250, 24);
            labelAcquireFactor.TabIndex = 548;
            labelAcquireFactor.Text = "Acquire Factor";
            labelAcquireFactor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDistanceAdv
            // 
            lblDistanceAdv.AutoSize = true;
            lblDistanceAdv.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblDistanceAdv.ForeColor = System.Drawing.Color.Black;
            lblDistanceAdv.Location = new System.Drawing.Point(91, 312);
            lblDistanceAdv.Name = "lblDistanceAdv";
            lblDistanceAdv.Size = new System.Drawing.Size(46, 23);
            lblDistanceAdv.TabIndex = 516;
            lblDistanceAdv.Text = "888";
            lblDistanceAdv.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // hsbarLookAheadMult
            // 
            hsbarLookAheadMult.LargeChange = 1;
            hsbarLookAheadMult.Location = new System.Drawing.Point(73, 143);
            hsbarLookAheadMult.Maximum = 60;
            hsbarLookAheadMult.Minimum = 5;
            hsbarLookAheadMult.Name = "hsbarLookAheadMult";
            hsbarLookAheadMult.Size = new System.Drawing.Size(276, 30);
            hsbarLookAheadMult.TabIndex = 298;
            hsbarLookAheadMult.Value = 6;
            hsbarLookAheadMult.ValueChanged += hsbarLookAheadMult_ValueChanged;
            // 
            // labelDist
            // 
            labelDist.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelDist.ForeColor = System.Drawing.Color.Black;
            labelDist.Location = new System.Drawing.Point(3, 311);
            labelDist.Name = "labelDist";
            labelDist.Size = new System.Drawing.Size(88, 23);
            labelDist.TabIndex = 515;
            labelDist.Text = "Distance:";
            labelDist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLookAheadMult
            // 
            lblLookAheadMult.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblLookAheadMult.ForeColor = System.Drawing.Color.Black;
            lblLookAheadMult.Location = new System.Drawing.Point(8, 142);
            lblLookAheadMult.Name = "lblLookAheadMult";
            lblLookAheadMult.Size = new System.Drawing.Size(60, 35);
            lblLookAheadMult.TabIndex = 299;
            lblLookAheadMult.Text = "888";
            lblLookAheadMult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHoldAdv
            // 
            lblHoldAdv.AutoSize = true;
            lblHoldAdv.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblHoldAdv.ForeColor = System.Drawing.Color.Black;
            lblHoldAdv.Location = new System.Drawing.Point(315, 312);
            lblHoldAdv.Name = "lblHoldAdv";
            lblHoldAdv.Size = new System.Drawing.Size(46, 23);
            lblHoldAdv.TabIndex = 514;
            lblHoldAdv.Text = "888";
            lblHoldAdv.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSpeedFactor
            // 
            labelSpeedFactor.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelSpeedFactor.ForeColor = System.Drawing.Color.Black;
            labelSpeedFactor.Location = new System.Drawing.Point(85, 116);
            labelSpeedFactor.Name = "labelSpeedFactor";
            labelSpeedFactor.Size = new System.Drawing.Size(250, 24);
            labelSpeedFactor.TabIndex = 301;
            labelSpeedFactor.Text = "Speed Factor";
            labelSpeedFactor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAcqAdv
            // 
            lblAcqAdv.AutoSize = true;
            lblAcqAdv.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblAcqAdv.ForeColor = System.Drawing.Color.Black;
            lblAcqAdv.Location = new System.Drawing.Point(216, 312);
            lblAcqAdv.Name = "lblAcqAdv";
            lblAcqAdv.Size = new System.Drawing.Size(46, 23);
            lblAcqAdv.TabIndex = 513;
            lblAcqAdv.Text = "888";
            lblAcqAdv.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelDeadzone
            // 
            labelDeadzone.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelDeadzone.ForeColor = System.Drawing.Color.Black;
            labelDeadzone.Location = new System.Drawing.Point(62, 9);
            labelDeadzone.Name = "labelDeadzone";
            labelDeadzone.Size = new System.Drawing.Size(250, 24);
            labelDeadzone.TabIndex = 541;
            labelDeadzone.Text = " ------ Dead Zone -----";
            labelDeadzone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hsbarAcquireFactor
            // 
            hsbarAcquireFactor.LargeChange = 1;
            hsbarAcquireFactor.Location = new System.Drawing.Point(73, 235);
            hsbarAcquireFactor.Maximum = 300;
            hsbarAcquireFactor.Minimum = 20;
            hsbarAcquireFactor.Name = "hsbarAcquireFactor";
            hsbarAcquireFactor.Size = new System.Drawing.Size(276, 30);
            hsbarAcquireFactor.TabIndex = 508;
            hsbarAcquireFactor.Value = 75;
            hsbarAcquireFactor.ValueChanged += hsbarAcquireFactor_ValueChanged;
            // 
            // labelAcquire2
            // 
            labelAcquire2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelAcquire2.ForeColor = System.Drawing.Color.Black;
            labelAcquire2.Location = new System.Drawing.Point(139, 312);
            labelAcquire2.Name = "labelAcquire2";
            labelAcquire2.Size = new System.Drawing.Size(80, 23);
            labelAcquire2.TabIndex = 512;
            labelAcquire2.Text = "Acquire:";
            labelAcquire2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAcquireFactor
            // 
            lblAcquireFactor.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblAcquireFactor.ForeColor = System.Drawing.Color.Black;
            lblAcquireFactor.Location = new System.Drawing.Point(8, 232);
            lblAcquireFactor.Name = "lblAcquireFactor";
            lblAcquireFactor.Size = new System.Drawing.Size(60, 35);
            lblAcquireFactor.TabIndex = 509;
            lblAcquireFactor.Text = "888";
            lblAcquireFactor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelHold
            // 
            labelHold.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelHold.ForeColor = System.Drawing.Color.Black;
            labelHold.Location = new System.Drawing.Point(265, 311);
            labelHold.Name = "labelHold";
            labelHold.Size = new System.Drawing.Size(55, 23);
            labelHold.TabIndex = 511;
            labelHold.Text = "Hold:";
            labelHold.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAcquireDescription
            // 
            labelAcquireDescription.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelAcquireDescription.ForeColor = System.Drawing.Color.Black;
            labelAcquireDescription.Location = new System.Drawing.Point(103, 269);
            labelAcquireDescription.Name = "labelAcquireDescription";
            labelAcquireDescription.Size = new System.Drawing.Size(246, 23);
            labelAcquireDescription.TabIndex = 510;
            labelAcquireDescription.Text = "Acquire = Factor * Hold";
            labelAcquireDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelOnDelay
            // 
            labelOnDelay.BackColor = System.Drawing.Color.Transparent;
            labelOnDelay.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelOnDelay.ForeColor = System.Drawing.Color.Black;
            labelOnDelay.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            labelOnDelay.Location = new System.Drawing.Point(190, 72);
            labelOnDelay.Name = "labelOnDelay";
            labelOnDelay.Size = new System.Drawing.Size(172, 22);
            labelOnDelay.TabIndex = 543;
            labelOnDelay.Text = "On Delay (sec)";
            labelOnDelay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelHeadingDegree
            // 
            labelHeadingDegree.BackColor = System.Drawing.Color.Transparent;
            labelHeadingDegree.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelHeadingDegree.ForeColor = System.Drawing.Color.Black;
            labelHeadingDegree.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            labelHeadingDegree.Location = new System.Drawing.Point(5, 72);
            labelHeadingDegree.Name = "labelHeadingDegree";
            labelHeadingDegree.Size = new System.Drawing.Size(179, 22);
            labelHeadingDegree.TabIndex = 539;
            labelHeadingDegree.Text = "Heading (Degree)";
            labelHeadingDegree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudDeadZoneDelay
            // 
            nudDeadZoneDelay.BackColor = System.Drawing.Color.White;
            nudDeadZoneDelay.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            nudDeadZoneDelay.InterceptArrowKeys = false;
            nudDeadZoneDelay.Location = new System.Drawing.Point(223, 37);
            nudDeadZoneDelay.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudDeadZoneDelay.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudDeadZoneDelay.Name = "nudDeadZoneDelay";
            nudDeadZoneDelay.ReadOnly = true;
            nudDeadZoneDelay.Size = new System.Drawing.Size(107, 36);
            nudDeadZoneDelay.TabIndex = 542;
            nudDeadZoneDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudDeadZoneDelay.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nudDeadZoneDelay.Click += nudDeadZoneDelay_Click;
            // 
            // nudDeadZoneHeading
            // 
            nudDeadZoneHeading.BackColor = System.Drawing.Color.White;
            nudDeadZoneHeading.DecimalPlaces = 1;
            nudDeadZoneHeading.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            nudDeadZoneHeading.InterceptArrowKeys = false;
            nudDeadZoneHeading.Location = new System.Drawing.Point(41, 38);
            nudDeadZoneHeading.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            nudDeadZoneHeading.Minimum = new decimal(new int[] { 1, 0, 0, 65536 });
            nudDeadZoneHeading.Name = "nudDeadZoneHeading";
            nudDeadZoneHeading.ReadOnly = true;
            nudDeadZoneHeading.Size = new System.Drawing.Size(107, 36);
            nudDeadZoneHeading.TabIndex = 538;
            nudDeadZoneHeading.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudDeadZoneHeading.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nudDeadZoneHeading.Click += nudDeadZoneHeading_Click;
            // 
            // tabGain
            // 
            tabGain.AutoScroll = true;
            tabGain.BackColor = System.Drawing.Color.Gainsboro;
            tabGain.BackgroundImage = Properties.Resources.Sf_GainTab;
            tabGain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            tabGain.Controls.Add(label6);
            tabGain.Controls.Add(labelMinToMove);
            tabGain.Controls.Add(labelMaxLimit);
            tabGain.Controls.Add(labelProportionalGain);
            tabGain.Controls.Add(hsbarMinPWM);
            tabGain.Controls.Add(hsbarProportionalGain);
            tabGain.Controls.Add(lblProportionalGain);
            tabGain.Controls.Add(lblHighSteerPWM);
            tabGain.Controls.Add(lblMinPWM);
            tabGain.Controls.Add(hsbarHighSteerPWM);
            tabGain.ImageIndex = 1;
            tabGain.Location = new System.Drawing.Point(4, 52);
            tabGain.Name = "tabGain";
            tabGain.Size = new System.Drawing.Size(365, 346);
            tabGain.TabIndex = 13;
            // 
            // label6
            // 
            label6.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label6.ForeColor = System.Drawing.Color.Black;
            label6.Location = new System.Drawing.Point(3, 16);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(360, 25);
            label6.TabIndex = 339;
            label6.Text = "Gain";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMinToMove
            // 
            labelMinToMove.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelMinToMove.ForeColor = System.Drawing.Color.Black;
            labelMinToMove.Location = new System.Drawing.Point(44, 244);
            labelMinToMove.Name = "labelMinToMove";
            labelMinToMove.Size = new System.Drawing.Size(250, 24);
            labelMinToMove.TabIndex = 338;
            labelMinToMove.Text = "Minimum to Move";
            labelMinToMove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMaxLimit
            // 
            labelMaxLimit.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelMaxLimit.ForeColor = System.Drawing.Color.Black;
            labelMaxLimit.Location = new System.Drawing.Point(44, 154);
            labelMaxLimit.Name = "labelMaxLimit";
            labelMaxLimit.Size = new System.Drawing.Size(250, 24);
            labelMaxLimit.TabIndex = 336;
            labelMaxLimit.Text = "Maximum Limit";
            labelMaxLimit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelProportionalGain
            // 
            labelProportionalGain.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelProportionalGain.ForeColor = System.Drawing.Color.Black;
            labelProportionalGain.Location = new System.Drawing.Point(44, 64);
            labelProportionalGain.Name = "labelProportionalGain";
            labelProportionalGain.Size = new System.Drawing.Size(250, 24);
            labelProportionalGain.TabIndex = 335;
            labelProportionalGain.Text = "Proportional Gain";
            labelProportionalGain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hsbarMinPWM
            // 
            hsbarMinPWM.LargeChange = 1;
            hsbarMinPWM.Location = new System.Drawing.Point(68, 269);
            hsbarMinPWM.Maximum = 200;
            hsbarMinPWM.Name = "hsbarMinPWM";
            hsbarMinPWM.Size = new System.Drawing.Size(202, 30);
            hsbarMinPWM.TabIndex = 284;
            hsbarMinPWM.Value = 10;
            hsbarMinPWM.ValueChanged += hsbarMinPWM_ValueChanged;
            // 
            // hsbarProportionalGain
            // 
            hsbarProportionalGain.LargeChange = 1;
            hsbarProportionalGain.Location = new System.Drawing.Point(68, 89);
            hsbarProportionalGain.Maximum = 200;
            hsbarProportionalGain.Minimum = 1;
            hsbarProportionalGain.Name = "hsbarProportionalGain";
            hsbarProportionalGain.Size = new System.Drawing.Size(202, 30);
            hsbarProportionalGain.TabIndex = 254;
            hsbarProportionalGain.Value = 4;
            hsbarProportionalGain.ValueChanged += hsbarProportionalGain_ValueChanged;
            // 
            // lblProportionalGain
            // 
            lblProportionalGain.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblProportionalGain.ForeColor = System.Drawing.Color.Black;
            lblProportionalGain.Location = new System.Drawing.Point(8, 87);
            lblProportionalGain.Name = "lblProportionalGain";
            lblProportionalGain.Size = new System.Drawing.Size(61, 35);
            lblProportionalGain.TabIndex = 258;
            lblProportionalGain.Text = "888";
            lblProportionalGain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHighSteerPWM
            // 
            lblHighSteerPWM.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblHighSteerPWM.ForeColor = System.Drawing.Color.Black;
            lblHighSteerPWM.Location = new System.Drawing.Point(8, 176);
            lblHighSteerPWM.Name = "lblHighSteerPWM";
            lblHighSteerPWM.Size = new System.Drawing.Size(61, 35);
            lblHighSteerPWM.TabIndex = 278;
            lblHighSteerPWM.Text = "888";
            lblHighSteerPWM.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMinPWM
            // 
            lblMinPWM.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblMinPWM.ForeColor = System.Drawing.Color.Black;
            lblMinPWM.Location = new System.Drawing.Point(8, 266);
            lblMinPWM.Name = "lblMinPWM";
            lblMinPWM.Size = new System.Drawing.Size(61, 35);
            lblMinPWM.TabIndex = 288;
            lblMinPWM.Text = "888";
            lblMinPWM.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // hsbarHighSteerPWM
            // 
            hsbarHighSteerPWM.LargeChange = 2;
            hsbarHighSteerPWM.Location = new System.Drawing.Point(68, 179);
            hsbarHighSteerPWM.Maximum = 256;
            hsbarHighSteerPWM.Name = "hsbarHighSteerPWM";
            hsbarHighSteerPWM.Size = new System.Drawing.Size(202, 30);
            hsbarHighSteerPWM.TabIndex = 274;
            hsbarHighSteerPWM.Value = 50;
            hsbarHighSteerPWM.ValueChanged += hsbarHighSteerPWM_ValueChanged;
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
            imageList1.Images.SetKeyName(4, "ST_NerdAdv.png");
            // 
            // lblSideHillComp
            // 
            lblSideHillComp.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblSideHillComp.ForeColor = System.Drawing.Color.Black;
            lblSideHillComp.Location = new System.Drawing.Point(18, 161);
            lblSideHillComp.Name = "lblSideHillComp";
            lblSideHillComp.Size = new System.Drawing.Size(88, 35);
            lblSideHillComp.TabIndex = 353;
            lblSideHillComp.Text = "888";
            lblSideHillComp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // hsbarSideHillComp
            // 
            hsbarSideHillComp.LargeChange = 1;
            hsbarSideHillComp.Location = new System.Drawing.Point(109, 150);
            hsbarSideHillComp.Name = "hsbarSideHillComp";
            hsbarSideHillComp.Size = new System.Drawing.Size(339, 53);
            hsbarSideHillComp.TabIndex = 352;
            hsbarSideHillComp.Value = 5;
            hsbarSideHillComp.ValueChanged += hsbarSideHillComp_ValueChanged;
            // 
            // labelSideHill
            // 
            labelSideHill.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelSideHill.ForeColor = System.Drawing.Color.Black;
            labelSideHill.Location = new System.Drawing.Point(109, 124);
            labelSideHill.Name = "labelSideHill";
            labelSideHill.Size = new System.Drawing.Size(339, 24);
            labelSideHill.TabIndex = 351;
            labelSideHill.Text = "Sidehill Deg Turn per Deg of Roll";
            labelSideHill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            labelSideHill.UseCompatibleTextRendering = true;
            // 
            // labelSteerDescription
            // 
            labelSteerDescription.AutoSize = true;
            labelSteerDescription.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelSteerDescription.ForeColor = System.Drawing.Color.Black;
            labelSteerDescription.Location = new System.Drawing.Point(317, 383);
            labelSteerDescription.Name = "labelSteerDescription";
            labelSteerDescription.Size = new System.Drawing.Size(193, 32);
            labelSteerDescription.TabIndex = 513;
            labelSteerDescription.Text = "Button - Push On. Push Off\r\nSwitch - Pushed On, Release Off";
            // 
            // labelPressureTurnSensor
            // 
            labelPressureTurnSensor.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelPressureTurnSensor.ForeColor = System.Drawing.Color.Black;
            labelPressureTurnSensor.Location = new System.Drawing.Point(5, 134);
            labelPressureTurnSensor.Name = "labelPressureTurnSensor";
            labelPressureTurnSensor.Size = new System.Drawing.Size(200, 24);
            labelPressureTurnSensor.TabIndex = 512;
            labelPressureTurnSensor.Text = "Pressure Sensor";
            labelPressureTurnSensor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelCurrentTurnSensor
            // 
            labelCurrentTurnSensor.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelCurrentTurnSensor.ForeColor = System.Drawing.Color.Black;
            labelCurrentTurnSensor.Location = new System.Drawing.Point(5, 269);
            labelCurrentTurnSensor.Name = "labelCurrentTurnSensor";
            labelCurrentTurnSensor.Size = new System.Drawing.Size(200, 24);
            labelCurrentTurnSensor.TabIndex = 511;
            labelCurrentTurnSensor.Text = "Current Sensor";
            labelCurrentTurnSensor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelEncoder
            // 
            labelEncoder.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelEncoder.ForeColor = System.Drawing.Color.Black;
            labelEncoder.Location = new System.Drawing.Point(5, 6);
            labelEncoder.Name = "labelEncoder";
            labelEncoder.Size = new System.Drawing.Size(200, 24);
            labelEncoder.TabIndex = 506;
            labelEncoder.Text = "Count Sensor";
            labelEncoder.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelInvertMotor
            // 
            labelInvertMotor.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelInvertMotor.ForeColor = System.Drawing.Color.Black;
            labelInvertMotor.Location = new System.Drawing.Point(129, 167);
            labelInvertMotor.Name = "labelInvertMotor";
            labelInvertMotor.Size = new System.Drawing.Size(181, 24);
            labelInvertMotor.TabIndex = 505;
            labelInvertMotor.Text = "Invert Motor Dir";
            labelInvertMotor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelInvertRelays
            // 
            labelInvertRelays.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelInvertRelays.ForeColor = System.Drawing.Color.Black;
            labelInvertRelays.Location = new System.Drawing.Point(129, 299);
            labelInvertRelays.Name = "labelInvertRelays";
            labelInvertRelays.Size = new System.Drawing.Size(181, 24);
            labelInvertRelays.TabIndex = 504;
            labelInvertRelays.Text = "Invert Relays";
            labelInvertRelays.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelSendAndSave
            // 
            labelSendAndSave.BackColor = System.Drawing.Color.Transparent;
            labelSendAndSave.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelSendAndSave.ForeColor = System.Drawing.Color.Black;
            labelSendAndSave.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            labelSendAndSave.Location = new System.Drawing.Point(641, 530);
            labelSendAndSave.Name = "labelSendAndSave";
            labelSendAndSave.Size = new System.Drawing.Size(175, 21);
            labelSendAndSave.TabIndex = 502;
            labelSendAndSave.Text = "Send + Save";
            labelSendAndSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboxMotorDrive
            // 
            cboxMotorDrive.BackColor = System.Drawing.Color.White;
            cboxMotorDrive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboxMotorDrive.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cboxMotorDrive.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cboxMotorDrive.FormattingEnabled = true;
            cboxMotorDrive.Items.AddRange(new object[] { "Cytron", "IBT2" });
            cboxMotorDrive.Location = new System.Drawing.Point(329, 46);
            cboxMotorDrive.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            cboxMotorDrive.Name = "cboxMotorDrive";
            cboxMotorDrive.Size = new System.Drawing.Size(175, 37);
            cboxMotorDrive.TabIndex = 495;
            cboxMotorDrive.Click += EnableAlert_Click;
            // 
            // cboxSteerEnable
            // 
            cboxSteerEnable.BackColor = System.Drawing.Color.White;
            cboxSteerEnable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboxSteerEnable.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cboxSteerEnable.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cboxSteerEnable.FormattingEnabled = true;
            cboxSteerEnable.Items.AddRange(new object[] { "None", "Switch", "Button" });
            cboxSteerEnable.Location = new System.Drawing.Point(329, 340);
            cboxSteerEnable.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            cboxSteerEnable.Name = "cboxSteerEnable";
            cboxSteerEnable.Size = new System.Drawing.Size(175, 37);
            cboxSteerEnable.TabIndex = 498;
            cboxSteerEnable.Click += EnableAlert_Click;
            // 
            // labelSteerEnable
            // 
            labelSteerEnable.BackColor = System.Drawing.Color.Transparent;
            labelSteerEnable.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelSteerEnable.ForeColor = System.Drawing.Color.Black;
            labelSteerEnable.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            labelSteerEnable.Location = new System.Drawing.Point(326, 314);
            labelSteerEnable.Name = "labelSteerEnable";
            labelSteerEnable.Size = new System.Drawing.Size(181, 24);
            labelSteerEnable.TabIndex = 499;
            labelSteerEnable.Text = "Steer Enable";
            labelSteerEnable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboxConv
            // 
            cboxConv.BackColor = System.Drawing.Color.White;
            cboxConv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboxConv.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cboxConv.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cboxConv.FormattingEnabled = true;
            cboxConv.Items.AddRange(new object[] { "Single", "Differential" });
            cboxConv.Location = new System.Drawing.Point(329, 144);
            cboxConv.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            cboxConv.Name = "cboxConv";
            cboxConv.Size = new System.Drawing.Size(175, 37);
            cboxConv.TabIndex = 500;
            cboxConv.Click += EnableAlert_Click;
            // 
            // labelMotorDriver
            // 
            labelMotorDriver.BackColor = System.Drawing.Color.Transparent;
            labelMotorDriver.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelMotorDriver.ForeColor = System.Drawing.Color.Black;
            labelMotorDriver.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            labelMotorDriver.Location = new System.Drawing.Point(326, 20);
            labelMotorDriver.Name = "labelMotorDriver";
            labelMotorDriver.Size = new System.Drawing.Size(181, 24);
            labelMotorDriver.TabIndex = 496;
            labelMotorDriver.Text = "Motor Driver";
            labelMotorDriver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelADConverter
            // 
            labelADConverter.BackColor = System.Drawing.Color.Transparent;
            labelADConverter.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelADConverter.ForeColor = System.Drawing.Color.Black;
            labelADConverter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            labelADConverter.Location = new System.Drawing.Point(326, 118);
            labelADConverter.Name = "labelADConverter";
            labelADConverter.Size = new System.Drawing.Size(181, 24);
            labelADConverter.TabIndex = 497;
            labelADConverter.Text = "A2D Convertor";
            labelADConverter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTurnSensor
            // 
            labelTurnSensor.BackColor = System.Drawing.Color.Transparent;
            labelTurnSensor.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelTurnSensor.ForeColor = System.Drawing.Color.Black;
            labelTurnSensor.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            labelTurnSensor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            labelTurnSensor.Location = new System.Drawing.Point(220, 20);
            labelTurnSensor.Name = "labelTurnSensor";
            labelTurnSensor.Size = new System.Drawing.Size(200, 24);
            labelTurnSensor.TabIndex = 494;
            labelTurnSensor.Text = "Turn Sensor";
            labelTurnSensor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label55
            // 
            label55.BackColor = System.Drawing.Color.Transparent;
            label55.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label55.ForeColor = System.Drawing.Color.Black;
            label55.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label55.Location = new System.Drawing.Point(1, 32);
            label55.Name = "label55";
            label55.Size = new System.Drawing.Size(130, 24);
            label55.TabIndex = 489;
            label55.Text = "Danfoss";
            label55.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelInvertWas
            // 
            labelInvertWas.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelInvertWas.ForeColor = System.Drawing.Color.Black;
            labelInvertWas.Location = new System.Drawing.Point(129, 30);
            labelInvertWas.Name = "labelInvertWas";
            labelInvertWas.Size = new System.Drawing.Size(181, 24);
            labelInvertWas.TabIndex = 515;
            labelInvertWas.Text = "Invert WAS";
            labelInvertWas.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            panel2.Controls.Add(btnExpand);
            panel2.Controls.Add(lblError);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(lblSteerAngle);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(lblSteerAngleActual);
            panel2.Controls.Add(label13);
            panel2.Location = new System.Drawing.Point(4, 403);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(365, 43);
            panel2.TabIndex = 324;
            // 
            // btnExpand
            // 
            btnExpand.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnExpand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnExpand.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            btnExpand.FlatAppearance.BorderSize = 0;
            btnExpand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnExpand.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnExpand.Image = Properties.Resources.ArrowRight;
            btnExpand.Location = new System.Drawing.Point(299, 3);
            btnExpand.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            btnExpand.Name = "btnExpand";
            btnExpand.Size = new System.Drawing.Size(62, 37);
            btnExpand.TabIndex = 329;
            btnExpand.UseVisualStyleBackColor = true;
            btnExpand.Click += expandWindow_Click;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.Gainsboro;
            panel1.Controls.Add(lblPWMDisplay);
            panel1.Controls.Add(btnStartSA);
            panel1.Controls.Add(labelSteerAngle);
            panel1.Controls.Add(btnFreeDriveZero);
            panel1.Controls.Add(btnSteerAngleUp);
            panel1.Controls.Add(btnFreeDrive);
            panel1.Controls.Add(labelDiameter);
            panel1.Controls.Add(btnSteerAngleDown);
            panel1.Controls.Add(lblCalcSteerAngleInner);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(lblDiameter);
            panel1.Location = new System.Drawing.Point(5, 446);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(364, 176);
            panel1.TabIndex = 323;
            // 
            // btnStartSA
            // 
            btnStartSA.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnStartSA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            btnStartSA.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnStartSA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            btnStartSA.Image = Properties.Resources.BoundaryRecord;
            btnStartSA.Location = new System.Drawing.Point(15, 104);
            btnStartSA.Name = "btnStartSA";
            btnStartSA.Size = new System.Drawing.Size(71, 67);
            btnStartSA.TabIndex = 323;
            btnStartSA.UseVisualStyleBackColor = true;
            btnStartSA.Click += btnStartSA_Click;
            // 
            // btnFreeDriveZero
            // 
            btnFreeDriveZero.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnFreeDriveZero.BackColor = System.Drawing.Color.White;
            btnFreeDriveZero.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            btnFreeDriveZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnFreeDriveZero.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnFreeDriveZero.ForeColor = System.Drawing.Color.White;
            btnFreeDriveZero.Image = Properties.Resources.SteerZero;
            btnFreeDriveZero.Location = new System.Drawing.Point(277, 17);
            btnFreeDriveZero.Name = "btnFreeDriveZero";
            btnFreeDriveZero.Size = new System.Drawing.Size(73, 56);
            btnFreeDriveZero.TabIndex = 313;
            btnFreeDriveZero.UseVisualStyleBackColor = false;
            btnFreeDriveZero.Click += btnFreeDriveZero_Click;
            // 
            // btnSteerAngleUp
            // 
            btnSteerAngleUp.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnSteerAngleUp.BackColor = System.Drawing.Color.White;
            btnSteerAngleUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnSteerAngleUp.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            btnSteerAngleUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSteerAngleUp.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnSteerAngleUp.Image = Properties.Resources.ArrowRight;
            btnSteerAngleUp.Location = new System.Drawing.Point(186, 17);
            btnSteerAngleUp.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            btnSteerAngleUp.Name = "btnSteerAngleUp";
            btnSteerAngleUp.Size = new System.Drawing.Size(73, 56);
            btnSteerAngleUp.TabIndex = 315;
            btnSteerAngleUp.UseVisualStyleBackColor = false;
            btnSteerAngleUp.MouseDown += btnSteerAngleUp_MouseDown;
            // 
            // btnFreeDrive
            // 
            btnFreeDrive.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnFreeDrive.BackColor = System.Drawing.Color.WhiteSmoke;
            btnFreeDrive.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            btnFreeDrive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnFreeDrive.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnFreeDrive.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            btnFreeDrive.Image = Properties.Resources.SteerDriveOff;
            btnFreeDrive.Location = new System.Drawing.Point(4, 17);
            btnFreeDrive.Name = "btnFreeDrive";
            btnFreeDrive.Size = new System.Drawing.Size(73, 56);
            btnFreeDrive.TabIndex = 228;
            btnFreeDrive.UseVisualStyleBackColor = false;
            btnFreeDrive.Click += btnFreeDrive_Click;
            // 
            // btnSteerAngleDown
            // 
            btnSteerAngleDown.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnSteerAngleDown.BackColor = System.Drawing.Color.White;
            btnSteerAngleDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnSteerAngleDown.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            btnSteerAngleDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSteerAngleDown.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnSteerAngleDown.Image = Properties.Resources.ArrowLeft;
            btnSteerAngleDown.Location = new System.Drawing.Point(95, 17);
            btnSteerAngleDown.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            btnSteerAngleDown.Name = "btnSteerAngleDown";
            btnSteerAngleDown.Size = new System.Drawing.Size(73, 56);
            btnSteerAngleDown.TabIndex = 314;
            btnSteerAngleDown.UseVisualStyleBackColor = false;
            btnSteerAngleDown.MouseDown += btnSteerAngleDown_MouseDown;
            // 
            // hsbarSensor
            // 
            hsbarSensor.LargeChange = 1;
            hsbarSensor.Location = new System.Drawing.Point(187, 320);
            hsbarSensor.Maximum = 255;
            hsbarSensor.Name = "hsbarSensor";
            hsbarSensor.Size = new System.Drawing.Size(257, 53);
            hsbarSensor.TabIndex = 516;
            hsbarSensor.Scroll += hsbarSensor_Scroll;
            // 
            // lblhsbarSensor
            // 
            lblhsbarSensor.AutoSize = true;
            lblhsbarSensor.BackColor = System.Drawing.Color.Transparent;
            lblhsbarSensor.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblhsbarSensor.ForeColor = System.Drawing.Color.Black;
            lblhsbarSensor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            lblhsbarSensor.Location = new System.Drawing.Point(450, 329);
            lblhsbarSensor.Name = "lblhsbarSensor";
            lblhsbarSensor.Size = new System.Drawing.Size(57, 29);
            lblhsbarSensor.TabIndex = 518;
            lblhsbarSensor.Text = "0%";
            lblhsbarSensor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelReset
            // 
            labelReset.BackColor = System.Drawing.Color.Transparent;
            labelReset.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelReset.ForeColor = System.Drawing.Color.Black;
            labelReset.Location = new System.Drawing.Point(485, 530);
            labelReset.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            labelReset.Name = "labelReset";
            labelReset.Size = new System.Drawing.Size(150, 23);
            labelReset.TabIndex = 523;
            labelReset.Text = "Reset All To Defaults";
            labelReset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboxXY
            // 
            cboxXY.BackColor = System.Drawing.Color.White;
            cboxXY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboxXY.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cboxXY.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cboxXY.FormattingEnabled = true;
            cboxXY.Items.AddRange(new object[] { "X", "Y" });
            cboxXY.Location = new System.Drawing.Point(329, 242);
            cboxXY.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            cboxXY.Name = "cboxXY";
            cboxXY.Size = new System.Drawing.Size(175, 37);
            cboxXY.TabIndex = 525;
            cboxXY.Click += EnableAlert_Click;
            // 
            // labelIMUAxis
            // 
            labelIMUAxis.BackColor = System.Drawing.Color.Transparent;
            labelIMUAxis.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelIMUAxis.ForeColor = System.Drawing.Color.Black;
            labelIMUAxis.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            labelIMUAxis.Location = new System.Drawing.Point(326, 216);
            labelIMUAxis.Name = "labelIMUAxis";
            labelIMUAxis.Size = new System.Drawing.Size(181, 24);
            labelIMUAxis.TabIndex = 524;
            labelIMUAxis.Text = "IMU X or Y Axis";
            labelIMUAxis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label34
            // 
            label34.BackColor = System.Drawing.Color.Transparent;
            label34.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label34.ForeColor = System.Drawing.Color.Black;
            label34.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label34.Location = new System.Drawing.Point(283, 213);
            label34.Name = "label34";
            label34.Size = new System.Drawing.Size(201, 24);
            label34.TabIndex = 527;
            label34.Text = "Stanley/ Pure";
            label34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabSteerSettings
            // 
            tabSteerSettings.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            tabSteerSettings.Controls.Add(tabSensors);
            tabSteerSettings.Controls.Add(tabConfig);
            tabSteerSettings.Controls.Add(tabSettings);
            tabSteerSettings.Controls.Add(tabAlarm);
            tabSteerSettings.Controls.Add(tabOnTheLine);
            tabSteerSettings.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tabSteerSettings.ImageList = imageList2;
            tabSteerSettings.ItemSize = new System.Drawing.Size(100, 48);
            tabSteerSettings.Location = new System.Drawing.Point(373, 5);
            tabSteerSettings.Name = "tabSteerSettings";
            tabSteerSettings.SelectedIndex = 0;
            tabSteerSettings.Size = new System.Drawing.Size(520, 525);
            tabSteerSettings.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            tabSteerSettings.TabIndex = 528;
            // 
            // tabSensors
            // 
            tabSensors.BackColor = System.Drawing.Color.LightGray;
            tabSensors.Controls.Add(hsbarSensor);
            tabSensors.Controls.Add(nudMaxCounts);
            tabSensors.Controls.Add(labelTurnSensor);
            tabSensors.Controls.Add(pbarSensor);
            tabSensors.Controls.Add(lblPercentFS);
            tabSensors.Controls.Add(lblhsbarSensor);
            tabSensors.Controls.Add(labelPressureTurnSensor);
            tabSensors.Controls.Add(labelCurrentTurnSensor);
            tabSensors.Controls.Add(labelEncoder);
            tabSensors.Controls.Add(cboxCurrentSensor);
            tabSensors.Controls.Add(cboxEncoder);
            tabSensors.Controls.Add(cboxPressureSensor);
            tabSensors.ImageIndex = 0;
            tabSensors.Location = new System.Drawing.Point(4, 52);
            tabSensors.Name = "tabSensors";
            tabSensors.Padding = new System.Windows.Forms.Padding(3);
            tabSensors.Size = new System.Drawing.Size(512, 469);
            tabSensors.TabIndex = 0;
            // 
            // nudMaxCounts
            // 
            nudMaxCounts.BackColor = System.Drawing.Color.White;
            nudMaxCounts.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            nudMaxCounts.InterceptArrowKeys = false;
            nudMaxCounts.Location = new System.Drawing.Point(267, 45);
            nudMaxCounts.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            nudMaxCounts.Name = "nudMaxCounts";
            nudMaxCounts.ReadOnly = true;
            nudMaxCounts.Size = new System.Drawing.Size(107, 52);
            nudMaxCounts.TabIndex = 493;
            nudMaxCounts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudMaxCounts.Value = new decimal(new int[] { 15, 0, 0, 0 });
            nudMaxCounts.Click += nudMaxCounts_Click;
            // 
            // cboxCurrentSensor
            // 
            cboxCurrentSensor.Appearance = System.Windows.Forms.Appearance.Button;
            cboxCurrentSensor.BackColor = System.Drawing.Color.White;
            cboxCurrentSensor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            cboxCurrentSensor.FlatAppearance.CheckedBackColor = System.Drawing.Color.MediumAquamarine;
            cboxCurrentSensor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboxCurrentSensor.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cboxCurrentSensor.ForeColor = System.Drawing.SystemColors.ControlText;
            cboxCurrentSensor.Image = Properties.Resources.ConSt_TurnSensorCurrent;
            cboxCurrentSensor.Location = new System.Drawing.Point(48, 295);
            cboxCurrentSensor.Name = "cboxCurrentSensor";
            cboxCurrentSensor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            cboxCurrentSensor.Size = new System.Drawing.Size(114, 78);
            cboxCurrentSensor.TabIndex = 510;
            cboxCurrentSensor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            cboxCurrentSensor.UseVisualStyleBackColor = false;
            cboxCurrentSensor.Click += EnableAlert_Click;
            // 
            // cboxEncoder
            // 
            cboxEncoder.Appearance = System.Windows.Forms.Appearance.Button;
            cboxEncoder.BackColor = System.Drawing.Color.White;
            cboxEncoder.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            cboxEncoder.FlatAppearance.CheckedBackColor = System.Drawing.Color.MediumAquamarine;
            cboxEncoder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboxEncoder.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cboxEncoder.ForeColor = System.Drawing.SystemColors.ControlText;
            cboxEncoder.Image = Properties.Resources.ConSt_TurnSensor;
            cboxEncoder.Location = new System.Drawing.Point(48, 32);
            cboxEncoder.Name = "cboxEncoder";
            cboxEncoder.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            cboxEncoder.Size = new System.Drawing.Size(114, 78);
            cboxEncoder.TabIndex = 492;
            cboxEncoder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            cboxEncoder.UseVisualStyleBackColor = false;
            cboxEncoder.Click += EnableAlert_Click;
            // 
            // cboxPressureSensor
            // 
            cboxPressureSensor.Appearance = System.Windows.Forms.Appearance.Button;
            cboxPressureSensor.BackColor = System.Drawing.Color.White;
            cboxPressureSensor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            cboxPressureSensor.FlatAppearance.CheckedBackColor = System.Drawing.Color.MediumAquamarine;
            cboxPressureSensor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboxPressureSensor.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cboxPressureSensor.ForeColor = System.Drawing.SystemColors.ControlText;
            cboxPressureSensor.Image = Properties.Resources.ConSt_TurnSensorPressure;
            cboxPressureSensor.Location = new System.Drawing.Point(48, 159);
            cboxPressureSensor.Name = "cboxPressureSensor";
            cboxPressureSensor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            cboxPressureSensor.Size = new System.Drawing.Size(114, 78);
            cboxPressureSensor.TabIndex = 508;
            cboxPressureSensor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            cboxPressureSensor.UseVisualStyleBackColor = false;
            cboxPressureSensor.Click += EnableAlert_Click;
            // 
            // tabConfig
            // 
            tabConfig.BackColor = System.Drawing.Color.LightGray;
            tabConfig.Controls.Add(cboxXY);
            tabConfig.Controls.Add(labelIMUAxis);
            tabConfig.Controls.Add(labelInvertWas);
            tabConfig.Controls.Add(label55);
            tabConfig.Controls.Add(labelSteerDescription);
            tabConfig.Controls.Add(labelADConverter);
            tabConfig.Controls.Add(labelInvertMotor);
            tabConfig.Controls.Add(labelMotorDriver);
            tabConfig.Controls.Add(labelInvertRelays);
            tabConfig.Controls.Add(cboxConv);
            tabConfig.Controls.Add(labelSteerEnable);
            tabConfig.Controls.Add(cboxMotorDrive);
            tabConfig.Controls.Add(cboxSteerEnable);
            tabConfig.Controls.Add(chkInvertWAS);
            tabConfig.Controls.Add(chkInvertSteer);
            tabConfig.Controls.Add(chkSteerInvertRelays);
            tabConfig.Controls.Add(cboxDanfoss);
            tabConfig.ImageIndex = 1;
            tabConfig.Location = new System.Drawing.Point(4, 52);
            tabConfig.Name = "tabConfig";
            tabConfig.Padding = new System.Windows.Forms.Padding(3);
            tabConfig.Size = new System.Drawing.Size(512, 469);
            tabConfig.TabIndex = 1;
            // 
            // chkInvertWAS
            // 
            chkInvertWAS.Appearance = System.Windows.Forms.Appearance.Button;
            chkInvertWAS.BackColor = System.Drawing.Color.White;
            chkInvertWAS.Checked = true;
            chkInvertWAS.CheckState = System.Windows.Forms.CheckState.Checked;
            chkInvertWAS.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            chkInvertWAS.FlatAppearance.CheckedBackColor = System.Drawing.Color.MediumAquamarine;
            chkInvertWAS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            chkInvertWAS.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            chkInvertWAS.ForeColor = System.Drawing.SystemColors.ControlText;
            chkInvertWAS.Image = Properties.Resources.ConSt_InvertWAS;
            chkInvertWAS.Location = new System.Drawing.Point(165, 57);
            chkInvertWAS.Name = "chkInvertWAS";
            chkInvertWAS.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            chkInvertWAS.Size = new System.Drawing.Size(109, 78);
            chkInvertWAS.TabIndex = 490;
            chkInvertWAS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            chkInvertWAS.UseVisualStyleBackColor = false;
            chkInvertWAS.Click += EnableAlert_Click;
            // 
            // chkInvertSteer
            // 
            chkInvertSteer.Appearance = System.Windows.Forms.Appearance.Button;
            chkInvertSteer.BackColor = System.Drawing.Color.White;
            chkInvertSteer.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            chkInvertSteer.FlatAppearance.CheckedBackColor = System.Drawing.Color.MediumAquamarine;
            chkInvertSteer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            chkInvertSteer.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            chkInvertSteer.ForeColor = System.Drawing.SystemColors.ControlText;
            chkInvertSteer.Image = Properties.Resources.ConSt_InvertDirection;
            chkInvertSteer.Location = new System.Drawing.Point(165, 192);
            chkInvertSteer.Name = "chkInvertSteer";
            chkInvertSteer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            chkInvertSteer.Size = new System.Drawing.Size(109, 78);
            chkInvertSteer.TabIndex = 491;
            chkInvertSteer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            chkInvertSteer.UseVisualStyleBackColor = false;
            chkInvertSteer.Click += EnableAlert_Click;
            // 
            // chkSteerInvertRelays
            // 
            chkSteerInvertRelays.Appearance = System.Windows.Forms.Appearance.Button;
            chkSteerInvertRelays.BackColor = System.Drawing.Color.White;
            chkSteerInvertRelays.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            chkSteerInvertRelays.FlatAppearance.CheckedBackColor = System.Drawing.Color.MediumAquamarine;
            chkSteerInvertRelays.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            chkSteerInvertRelays.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            chkSteerInvertRelays.ForeColor = System.Drawing.SystemColors.ControlText;
            chkSteerInvertRelays.Image = Properties.Resources.ConSt_InvertRelay;
            chkSteerInvertRelays.Location = new System.Drawing.Point(165, 324);
            chkSteerInvertRelays.Name = "chkSteerInvertRelays";
            chkSteerInvertRelays.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            chkSteerInvertRelays.Size = new System.Drawing.Size(109, 78);
            chkSteerInvertRelays.TabIndex = 503;
            chkSteerInvertRelays.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            chkSteerInvertRelays.UseVisualStyleBackColor = false;
            chkSteerInvertRelays.Click += EnableAlert_Click;
            // 
            // cboxDanfoss
            // 
            cboxDanfoss.Appearance = System.Windows.Forms.Appearance.Button;
            cboxDanfoss.BackColor = System.Drawing.Color.White;
            cboxDanfoss.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            cboxDanfoss.FlatAppearance.CheckedBackColor = System.Drawing.Color.MediumAquamarine;
            cboxDanfoss.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboxDanfoss.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cboxDanfoss.ForeColor = System.Drawing.SystemColors.ControlText;
            cboxDanfoss.Image = Properties.Resources.ConSt_Danfoss;
            cboxDanfoss.Location = new System.Drawing.Point(9, 57);
            cboxDanfoss.Name = "cboxDanfoss";
            cboxDanfoss.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            cboxDanfoss.Size = new System.Drawing.Size(114, 78);
            cboxDanfoss.TabIndex = 507;
            cboxDanfoss.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            cboxDanfoss.UseVisualStyleBackColor = false;
            cboxDanfoss.Click += EnableAlert_Click;
            // 
            // tabSettings
            // 
            tabSettings.BackColor = System.Drawing.Color.LightGray;
            tabSettings.Controls.Add(grpSmartWAS);
            tabSettings.Controls.Add(labelSteerInReverse);
            tabSettings.Controls.Add(label41);
            tabSettings.Controls.Add(label39);
            tabSettings.Controls.Add(hsbarUTurnCompensation);
            tabSettings.Controls.Add(lblUTurnCompensation);
            tabSettings.Controls.Add(labelUturnCompensation);
            tabSettings.Controls.Add(hsbarSideHillComp);
            tabSettings.Controls.Add(label34);
            tabSettings.Controls.Add(lblSideHillComp);
            tabSettings.Controls.Add(labelSideHill);
            tabSettings.Controls.Add(cboxSteerInReverse);
            tabSettings.Controls.Add(btnStanleyPure);
            tabSettings.ImageIndex = 2;
            tabSettings.Location = new System.Drawing.Point(4, 52);
            tabSettings.Name = "tabSettings";
            tabSettings.Padding = new System.Windows.Forms.Padding(3);
            tabSettings.Size = new System.Drawing.Size(512, 469);
            tabSettings.TabIndex = 2;
            tabSettings.Enter += tabSettings_Enter;
            tabSettings.Leave += tabSettings_Leave;
            // 
            // grpSmartWAS
            // 
            grpSmartWAS.BackColor = System.Drawing.Color.Transparent;
            grpSmartWAS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            grpSmartWAS.Controls.Add(lblSmartCalStatus);
            grpSmartWAS.Controls.Add(btnSmartZeroWAS);
            grpSmartWAS.Controls.Add(lblSmartCalConfidence);
            grpSmartWAS.Controls.Add(lblSmartCalSamples);
            grpSmartWAS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            grpSmartWAS.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            grpSmartWAS.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            grpSmartWAS.Location = new System.Drawing.Point(23, 251);
            grpSmartWAS.Name = "grpSmartWAS";
            grpSmartWAS.Size = new System.Drawing.Size(220, 200);
            grpSmartWAS.TabIndex = 535;
            grpSmartWAS.TabStop = false;
            grpSmartWAS.Text = "Smart WAS";
            // 
            // lblSmartCalStatus
            // 
            lblSmartCalStatus.AutoSize = true;
            lblSmartCalStatus.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblSmartCalStatus.Location = new System.Drawing.Point(10, 150);
            lblSmartCalStatus.Name = "lblSmartCalStatus";
            lblSmartCalStatus.Size = new System.Drawing.Size(43, 13);
            lblSmartCalStatus.TabIndex = 343;
            lblSmartCalStatus.Text = "Ready";
            // 
            // btnSmartZeroWAS
            // 
            btnSmartZeroWAS.BackColor = System.Drawing.Color.White;
            btnSmartZeroWAS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            btnSmartZeroWAS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSmartZeroWAS.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnSmartZeroWAS.ForeColor = System.Drawing.Color.FromArgb(0, 122, 204);
            btnSmartZeroWAS.Image = Properties.Resources.ST_SmartWAS;
            btnSmartZeroWAS.Location = new System.Drawing.Point(46, 38);
            btnSmartZeroWAS.Name = "btnSmartZeroWAS";
            btnSmartZeroWAS.Size = new System.Drawing.Size(128, 60);
            btnSmartZeroWAS.TabIndex = 340;
            btnSmartZeroWAS.Text = "0.0°";
            btnSmartZeroWAS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnSmartZeroWAS.UseVisualStyleBackColor = false;
            btnSmartZeroWAS.Click += btnSmartZeroWAS_Click;
            // 
            // lblSmartCalConfidence
            // 
            lblSmartCalConfidence.AutoSize = true;
            lblSmartCalConfidence.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblSmartCalConfidence.ForeColor = System.Drawing.Color.Gray;
            lblSmartCalConfidence.Location = new System.Drawing.Point(110, 170);
            lblSmartCalConfidence.Name = "lblSmartCalConfidence";
            lblSmartCalConfidence.Size = new System.Drawing.Size(85, 13);
            lblSmartCalConfidence.TabIndex = 342;
            lblSmartCalConfidence.Text = "Confidence: 0%";
            // 
            // lblSmartCalSamples
            // 
            lblSmartCalSamples.AutoSize = true;
            lblSmartCalSamples.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblSmartCalSamples.ForeColor = System.Drawing.Color.Gray;
            lblSmartCalSamples.Location = new System.Drawing.Point(10, 170);
            lblSmartCalSamples.Name = "lblSmartCalSamples";
            lblSmartCalSamples.Size = new System.Drawing.Size(59, 13);
            lblSmartCalSamples.TabIndex = 341;
            lblSmartCalSamples.Text = "Samples: 0";
            // 
            // labelSteerInReverse
            // 
            labelSteerInReverse.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelSteerInReverse.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            labelSteerInReverse.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            labelSteerInReverse.Location = new System.Drawing.Point(283, 347);
            labelSteerInReverse.Name = "labelSteerInReverse";
            labelSteerInReverse.Size = new System.Drawing.Size(201, 24);
            labelSteerInReverse.TabIndex = 534;
            labelSteerInReverse.Text = "Steer In Reverse?";
            labelSteerInReverse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label41
            // 
            label41.AutoSize = true;
            label41.BackColor = System.Drawing.Color.Transparent;
            label41.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label41.ForeColor = System.Drawing.Color.Black;
            label41.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label41.Location = new System.Drawing.Point(426, 103);
            label41.Name = "label41";
            label41.Size = new System.Drawing.Size(18, 16);
            label41.TabIndex = 532;
            label41.Text = "In";
            label41.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label39
            // 
            label39.AutoSize = true;
            label39.BackColor = System.Drawing.Color.Transparent;
            label39.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label39.ForeColor = System.Drawing.Color.Black;
            label39.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label39.Location = new System.Drawing.Point(112, 103);
            label39.Name = "label39";
            label39.Size = new System.Drawing.Size(27, 16);
            label39.TabIndex = 531;
            label39.Text = "Out";
            label39.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // hsbarUTurnCompensation
            // 
            hsbarUTurnCompensation.LargeChange = 1;
            hsbarUTurnCompensation.Location = new System.Drawing.Point(109, 46);
            hsbarUTurnCompensation.Maximum = 20;
            hsbarUTurnCompensation.Minimum = 2;
            hsbarUTurnCompensation.Name = "hsbarUTurnCompensation";
            hsbarUTurnCompensation.Size = new System.Drawing.Size(339, 53);
            hsbarUTurnCompensation.TabIndex = 529;
            hsbarUTurnCompensation.Value = 5;
            hsbarUTurnCompensation.ValueChanged += hsbarUTurnCompensation_ValueChanged;
            // 
            // lblUTurnCompensation
            // 
            lblUTurnCompensation.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblUTurnCompensation.ForeColor = System.Drawing.Color.Black;
            lblUTurnCompensation.Location = new System.Drawing.Point(18, 56);
            lblUTurnCompensation.Name = "lblUTurnCompensation";
            lblUTurnCompensation.Size = new System.Drawing.Size(88, 35);
            lblUTurnCompensation.TabIndex = 530;
            lblUTurnCompensation.Text = "888";
            lblUTurnCompensation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelUturnCompensation
            // 
            labelUturnCompensation.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelUturnCompensation.ForeColor = System.Drawing.Color.Black;
            labelUturnCompensation.Location = new System.Drawing.Point(109, 20);
            labelUturnCompensation.Name = "labelUturnCompensation";
            labelUturnCompensation.Size = new System.Drawing.Size(339, 24);
            labelUturnCompensation.TabIndex = 528;
            labelUturnCompensation.Text = "UTurn Compensation";
            labelUturnCompensation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            labelUturnCompensation.UseCompatibleTextRendering = true;
            // 
            // cboxSteerInReverse
            // 
            cboxSteerInReverse.Appearance = System.Windows.Forms.Appearance.Button;
            cboxSteerInReverse.BackColor = System.Drawing.Color.White;
            cboxSteerInReverse.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            cboxSteerInReverse.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            cboxSteerInReverse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboxSteerInReverse.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cboxSteerInReverse.ForeColor = System.Drawing.SystemColors.ControlText;
            cboxSteerInReverse.Image = Properties.Resources.ConV_RevSteer;
            cboxSteerInReverse.Location = new System.Drawing.Point(340, 374);
            cboxSteerInReverse.Name = "cboxSteerInReverse";
            cboxSteerInReverse.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            cboxSteerInReverse.Size = new System.Drawing.Size(86, 90);
            cboxSteerInReverse.TabIndex = 533;
            cboxSteerInReverse.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            cboxSteerInReverse.UseVisualStyleBackColor = false;
            cboxSteerInReverse.Click += cboxSteerInReverse_Click;
            // 
            // btnStanleyPure
            // 
            btnStanleyPure.BackColor = System.Drawing.Color.White;
            btnStanleyPure.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnStanleyPure.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            btnStanleyPure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnStanleyPure.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnStanleyPure.ForeColor = System.Drawing.Color.Black;
            btnStanleyPure.Image = Properties.Resources.ModeStanley;
            btnStanleyPure.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnStanleyPure.Location = new System.Drawing.Point(340, 240);
            btnStanleyPure.Margin = new System.Windows.Forms.Padding(0);
            btnStanleyPure.Name = "btnStanleyPure";
            btnStanleyPure.RightToLeft = System.Windows.Forms.RightToLeft.No;
            btnStanleyPure.Size = new System.Drawing.Size(86, 90);
            btnStanleyPure.TabIndex = 526;
            btnStanleyPure.UseVisualStyleBackColor = false;
            btnStanleyPure.Click += btnStanleyPure_Click;
            // 
            // tabAlarm
            // 
            tabAlarm.BackColor = System.Drawing.Color.Gainsboro;
            tabAlarm.Controls.Add(labelMinSpeed);
            tabAlarm.Controls.Add(label166);
            tabAlarm.Controls.Add(labelMaxSpeed);
            tabAlarm.Controls.Add(label163);
            tabAlarm.Controls.Add(label160);
            tabAlarm.Controls.Add(labelManualTurns);
            tabAlarm.Controls.Add(pictureBox17);
            tabAlarm.Controls.Add(pictureBox16);
            tabAlarm.Controls.Add(pictureBox10);
            tabAlarm.Controls.Add(nudMinSteerSpeed);
            tabAlarm.Controls.Add(nudMaxSteerSpeed);
            tabAlarm.Controls.Add(nudGuidanceSpeedLimit);
            tabAlarm.ImageIndex = 3;
            tabAlarm.Location = new System.Drawing.Point(4, 52);
            tabAlarm.Name = "tabAlarm";
            tabAlarm.Size = new System.Drawing.Size(512, 469);
            tabAlarm.TabIndex = 3;
            tabAlarm.Enter += tabAlarm_Enter;
            tabAlarm.Leave += tabAlarm_Leave;
            // 
            // labelMinSpeed
            // 
            labelMinSpeed.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelMinSpeed.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            labelMinSpeed.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            labelMinSpeed.Location = new System.Drawing.Point(6, 249);
            labelMinSpeed.Name = "labelMinSpeed";
            labelMinSpeed.Size = new System.Drawing.Size(223, 24);
            labelMinSpeed.TabIndex = 504;
            labelMinSpeed.Text = "Min Speed";
            labelMinSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label166
            // 
            label166.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label166.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label166.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label166.Location = new System.Drawing.Point(62, 412);
            label166.Name = "label166";
            label166.Size = new System.Drawing.Size(110, 24);
            label166.TabIndex = 507;
            label166.Text = "kmh";
            label166.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMaxSpeed
            // 
            labelMaxSpeed.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelMaxSpeed.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            labelMaxSpeed.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            labelMaxSpeed.Location = new System.Drawing.Point(284, 251);
            labelMaxSpeed.Name = "labelMaxSpeed";
            labelMaxSpeed.Size = new System.Drawing.Size(223, 24);
            labelMaxSpeed.TabIndex = 500;
            labelMaxSpeed.Text = "Max Speed";
            labelMaxSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label163
            // 
            label163.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label163.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label163.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label163.Location = new System.Drawing.Point(340, 412);
            label163.Name = "label163";
            label163.Size = new System.Drawing.Size(110, 24);
            label163.TabIndex = 503;
            label163.Text = "kmh";
            label163.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label160
            // 
            label160.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label160.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label160.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label160.Location = new System.Drawing.Point(339, 209);
            label160.Name = "label160";
            label160.Size = new System.Drawing.Size(110, 24);
            label160.TabIndex = 494;
            label160.Text = "Kmh";
            label160.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelManualTurns
            // 
            labelManualTurns.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelManualTurns.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            labelManualTurns.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            labelManualTurns.Location = new System.Drawing.Point(284, 45);
            labelManualTurns.Name = "labelManualTurns";
            labelManualTurns.Size = new System.Drawing.Size(223, 24);
            labelManualTurns.TabIndex = 499;
            labelManualTurns.Text = "Manual Turns";
            labelManualTurns.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox17
            // 
            pictureBox17.BackgroundImage = Properties.Resources.ConV_MinAutoSteer;
            pictureBox17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pictureBox17.Location = new System.Drawing.Point(58, 276);
            pictureBox17.Name = "pictureBox17";
            pictureBox17.Size = new System.Drawing.Size(118, 75);
            pictureBox17.TabIndex = 506;
            pictureBox17.TabStop = false;
            // 
            // pictureBox16
            // 
            pictureBox16.BackgroundImage = Properties.Resources.ConV_MaxAutoSteer;
            pictureBox16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pictureBox16.Location = new System.Drawing.Point(336, 276);
            pictureBox16.Name = "pictureBox16";
            pictureBox16.Size = new System.Drawing.Size(118, 75);
            pictureBox16.TabIndex = 502;
            pictureBox16.TabStop = false;
            // 
            // pictureBox10
            // 
            pictureBox10.BackgroundImage = Properties.Resources.con_VehicleFunctionSpeedLimit;
            pictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pictureBox10.Location = new System.Drawing.Point(335, 74);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new System.Drawing.Size(118, 74);
            pictureBox10.TabIndex = 493;
            pictureBox10.TabStop = false;
            // 
            // nudMinSteerSpeed
            // 
            nudMinSteerSpeed.BackColor = System.Drawing.Color.White;
            nudMinSteerSpeed.DecimalPlaces = 1;
            nudMinSteerSpeed.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            nudMinSteerSpeed.InterceptArrowKeys = false;
            nudMinSteerSpeed.Location = new System.Drawing.Point(62, 357);
            nudMinSteerSpeed.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudMinSteerSpeed.Name = "nudMinSteerSpeed";
            nudMinSteerSpeed.ReadOnly = true;
            nudMinSteerSpeed.Size = new System.Drawing.Size(110, 52);
            nudMinSteerSpeed.TabIndex = 505;
            nudMinSteerSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudMinSteerSpeed.Value = new decimal(new int[] { 10, 0, 0, 65536 });
            nudMinSteerSpeed.Click += nudMinSteerSpeed_Click;
            // 
            // nudMaxSteerSpeed
            // 
            nudMaxSteerSpeed.BackColor = System.Drawing.Color.White;
            nudMaxSteerSpeed.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            nudMaxSteerSpeed.InterceptArrowKeys = false;
            nudMaxSteerSpeed.Location = new System.Drawing.Point(340, 357);
            nudMaxSteerSpeed.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            nudMaxSteerSpeed.Name = "nudMaxSteerSpeed";
            nudMaxSteerSpeed.ReadOnly = true;
            nudMaxSteerSpeed.Size = new System.Drawing.Size(110, 52);
            nudMaxSteerSpeed.TabIndex = 501;
            nudMaxSteerSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudMaxSteerSpeed.Value = new decimal(new int[] { 12, 0, 0, 0 });
            nudMaxSteerSpeed.Click += nudMaxSteerSpeed_Click;
            // 
            // nudGuidanceSpeedLimit
            // 
            nudGuidanceSpeedLimit.BackColor = System.Drawing.Color.White;
            nudGuidanceSpeedLimit.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            nudGuidanceSpeedLimit.InterceptArrowKeys = false;
            nudGuidanceSpeedLimit.Location = new System.Drawing.Point(339, 154);
            nudGuidanceSpeedLimit.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            nudGuidanceSpeedLimit.Name = "nudGuidanceSpeedLimit";
            nudGuidanceSpeedLimit.ReadOnly = true;
            nudGuidanceSpeedLimit.Size = new System.Drawing.Size(110, 52);
            nudGuidanceSpeedLimit.TabIndex = 492;
            nudGuidanceSpeedLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudGuidanceSpeedLimit.Value = new decimal(new int[] { 7, 0, 0, 0 });
            nudGuidanceSpeedLimit.Click += nudGuidanceSpeedLimit_Click;
            // 
            // tabOnTheLine
            // 
            tabOnTheLine.BackColor = System.Drawing.Color.Gainsboro;
            tabOnTheLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            tabOnTheLine.Controls.Add(labelLineWidth);
            tabOnTheLine.Controls.Add(label44);
            tabOnTheLine.Controls.Add(labelNudgeDistance);
            tabOnTheLine.Controls.Add(label43);
            tabOnTheLine.Controls.Add(groupboxlabelGuidanceBar);
            tabOnTheLine.Controls.Add(labelCmPix);
            tabOnTheLine.Controls.Add(label107);
            tabOnTheLine.Controls.Add(label46);
            tabOnTheLine.Controls.Add(pictureBox1);
            tabOnTheLine.Controls.Add(labelNextGuidanceLine);
            tabOnTheLine.Controls.Add(pictureBox2);
            tabOnTheLine.Controls.Add(pictureBox12);
            tabOnTheLine.Controls.Add(pictureBox5);
            tabOnTheLine.Controls.Add(nudcmPerPixel);
            tabOnTheLine.Controls.Add(nudLineWidth);
            tabOnTheLine.Controls.Add(nudSnapDistance);
            tabOnTheLine.Controls.Add(nudGuidanceLookAhead);
            tabOnTheLine.ImageIndex = 4;
            tabOnTheLine.Location = new System.Drawing.Point(4, 52);
            tabOnTheLine.Name = "tabOnTheLine";
            tabOnTheLine.Padding = new System.Windows.Forms.Padding(3);
            tabOnTheLine.Size = new System.Drawing.Size(512, 469);
            tabOnTheLine.TabIndex = 4;
            tabOnTheLine.Enter += tabOnTheLine_Enter;
            tabOnTheLine.Leave += tabOnTheLine_Leave;
            // 
            // labelLineWidth
            // 
            labelLineWidth.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelLineWidth.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            labelLineWidth.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            labelLineWidth.Location = new System.Drawing.Point(20, 19);
            labelLineWidth.Name = "labelLineWidth";
            labelLineWidth.Size = new System.Drawing.Size(205, 24);
            labelLineWidth.TabIndex = 523;
            labelLineWidth.Text = "Line Width";
            labelLineWidth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label44
            // 
            label44.AutoSize = true;
            label44.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label44.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label44.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label44.Location = new System.Drawing.Point(171, 95);
            label44.Name = "label44";
            label44.Size = new System.Drawing.Size(43, 18);
            label44.TabIndex = 522;
            label44.Text = "pixels";
            label44.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelNudgeDistance
            // 
            labelNudgeDistance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelNudgeDistance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            labelNudgeDistance.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            labelNudgeDistance.Location = new System.Drawing.Point(288, 19);
            labelNudgeDistance.Name = "labelNudgeDistance";
            labelNudgeDistance.Size = new System.Drawing.Size(205, 24);
            labelNudgeDistance.TabIndex = 519;
            labelNudgeDistance.Text = "Nudge Distance";
            labelNudgeDistance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label43
            // 
            label43.AutoSize = true;
            label43.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label43.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label43.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label43.Location = new System.Drawing.Point(437, 95);
            label43.Name = "label43";
            label43.Size = new System.Drawing.Size(28, 18);
            label43.TabIndex = 518;
            label43.Text = "cm";
            label43.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupboxlabelGuidanceBar
            // 
            groupboxlabelGuidanceBar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            groupboxlabelGuidanceBar.Controls.Add(rbtnSteerBar);
            groupboxlabelGuidanceBar.Controls.Add(labelSteerBar);
            groupboxlabelGuidanceBar.Controls.Add(labelOnOff);
            groupboxlabelGuidanceBar.Controls.Add(rbtnLightBar);
            groupboxlabelGuidanceBar.Controls.Add(labelLightbar);
            groupboxlabelGuidanceBar.Controls.Add(chkDisplayLightbar);
            groupboxlabelGuidanceBar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            groupboxlabelGuidanceBar.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            groupboxlabelGuidanceBar.ForeColor = System.Drawing.Color.Black;
            groupboxlabelGuidanceBar.Location = new System.Drawing.Point(17, 311);
            groupboxlabelGuidanceBar.Name = "groupboxlabelGuidanceBar";
            groupboxlabelGuidanceBar.Size = new System.Drawing.Size(473, 139);
            groupboxlabelGuidanceBar.TabIndex = 528;
            groupboxlabelGuidanceBar.TabStop = false;
            groupboxlabelGuidanceBar.Text = "Guidance Bar";
            // 
            // rbtnSteerBar
            // 
            rbtnSteerBar.Appearance = System.Windows.Forms.Appearance.Button;
            rbtnSteerBar.BackColor = System.Drawing.Color.WhiteSmoke;
            rbtnSteerBar.Checked = true;
            rbtnSteerBar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            rbtnSteerBar.FlatAppearance.BorderSize = 2;
            rbtnSteerBar.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            rbtnSteerBar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rbtnSteerBar.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            rbtnSteerBar.ForeColor = System.Drawing.SystemColors.ControlText;
            rbtnSteerBar.Image = Properties.Resources.ConD_SteerBarBar;
            rbtnSteerBar.Location = new System.Drawing.Point(185, 35);
            rbtnSteerBar.Name = "rbtnSteerBar";
            rbtnSteerBar.Size = new System.Drawing.Size(121, 74);
            rbtnSteerBar.TabIndex = 469;
            rbtnSteerBar.TabStop = true;
            rbtnSteerBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            rbtnSteerBar.UseVisualStyleBackColor = false;
            rbtnSteerBar.Click += rbtnSteerBar_Click;
            // 
            // labelSteerBar
            // 
            labelSteerBar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelSteerBar.BackColor = System.Drawing.Color.Transparent;
            labelSteerBar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelSteerBar.ForeColor = System.Drawing.Color.Black;
            labelSteerBar.Location = new System.Drawing.Point(179, 112);
            labelSteerBar.Name = "labelSteerBar";
            labelSteerBar.Size = new System.Drawing.Size(132, 19);
            labelSteerBar.TabIndex = 533;
            labelSteerBar.Text = "Steer Bar";
            labelSteerBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelOnOff
            // 
            labelOnOff.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelOnOff.BackColor = System.Drawing.Color.Transparent;
            labelOnOff.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelOnOff.ForeColor = System.Drawing.Color.Black;
            labelOnOff.Location = new System.Drawing.Point(343, 112);
            labelOnOff.Name = "labelOnOff";
            labelOnOff.Size = new System.Drawing.Size(132, 19);
            labelOnOff.TabIndex = 534;
            labelOnOff.Text = "On/Off";
            labelOnOff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rbtnLightBar
            // 
            rbtnLightBar.Appearance = System.Windows.Forms.Appearance.Button;
            rbtnLightBar.BackColor = System.Drawing.Color.WhiteSmoke;
            rbtnLightBar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            rbtnLightBar.FlatAppearance.BorderSize = 2;
            rbtnLightBar.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            rbtnLightBar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rbtnLightBar.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            rbtnLightBar.ForeColor = System.Drawing.SystemColors.ControlText;
            rbtnLightBar.Image = Properties.Resources.ConD_LightBar;
            rbtnLightBar.Location = new System.Drawing.Point(11, 35);
            rbtnLightBar.Name = "rbtnLightBar";
            rbtnLightBar.Size = new System.Drawing.Size(121, 74);
            rbtnLightBar.TabIndex = 468;
            rbtnLightBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            rbtnLightBar.UseVisualStyleBackColor = false;
            rbtnLightBar.Click += rbtnLightBar_Click;
            // 
            // labelLightbar
            // 
            labelLightbar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelLightbar.BackColor = System.Drawing.Color.Transparent;
            labelLightbar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelLightbar.ForeColor = System.Drawing.Color.Black;
            labelLightbar.Location = new System.Drawing.Point(5, 112);
            labelLightbar.Name = "labelLightbar";
            labelLightbar.Size = new System.Drawing.Size(132, 19);
            labelLightbar.TabIndex = 520;
            labelLightbar.Text = "Lightbar";
            labelLightbar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkDisplayLightbar
            // 
            chkDisplayLightbar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            chkDisplayLightbar.Appearance = System.Windows.Forms.Appearance.Button;
            chkDisplayLightbar.BackColor = System.Drawing.Color.WhiteSmoke;
            chkDisplayLightbar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            chkDisplayLightbar.FlatAppearance.BorderSize = 2;
            chkDisplayLightbar.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            chkDisplayLightbar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            chkDisplayLightbar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            chkDisplayLightbar.ForeColor = System.Drawing.SystemColors.ControlText;
            chkDisplayLightbar.Image = Properties.Resources.SwitchOn;
            chkDisplayLightbar.Location = new System.Drawing.Point(359, 35);
            chkDisplayLightbar.Name = "chkDisplayLightbar";
            chkDisplayLightbar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            chkDisplayLightbar.Size = new System.Drawing.Size(100, 74);
            chkDisplayLightbar.TabIndex = 529;
            chkDisplayLightbar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            chkDisplayLightbar.UseVisualStyleBackColor = false;
            chkDisplayLightbar.Click += chkDisplayLightbar_Click;
            // 
            // labelCmPix
            // 
            labelCmPix.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelCmPix.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            labelCmPix.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            labelCmPix.Location = new System.Drawing.Point(289, 164);
            labelCmPix.Name = "labelCmPix";
            labelCmPix.Size = new System.Drawing.Size(205, 24);
            labelCmPix.TabIndex = 527;
            labelCmPix.Text = "cm Per Pixel";
            labelCmPix.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label107
            // 
            label107.AutoSize = true;
            label107.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label107.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label107.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label107.Location = new System.Drawing.Point(160, 245);
            label107.Name = "label107";
            label107.Size = new System.Drawing.Size(62, 18);
            label107.TabIndex = 513;
            label107.Text = "Seconds";
            label107.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label46
            // 
            label46.AutoSize = true;
            label46.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label46.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label46.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label46.Location = new System.Drawing.Point(436, 242);
            label46.Name = "label46";
            label46.Size = new System.Drawing.Size(30, 19);
            label46.TabIndex = 526;
            label46.Text = "cm";
            label46.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.ConV_CmPixel;
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pictureBox1.Location = new System.Drawing.Point(285, 190);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(118, 75);
            pictureBox1.TabIndex = 525;
            pictureBox1.TabStop = false;
            // 
            // labelNextGuidanceLine
            // 
            labelNextGuidanceLine.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelNextGuidanceLine.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            labelNextGuidanceLine.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            labelNextGuidanceLine.Location = new System.Drawing.Point(20, 164);
            labelNextGuidanceLine.Name = "labelNextGuidanceLine";
            labelNextGuidanceLine.Size = new System.Drawing.Size(205, 24);
            labelNextGuidanceLine.TabIndex = 514;
            labelNextGuidanceLine.Text = "Next Guidance Line Search Time";
            labelNextGuidanceLine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.ConV_SnapDistance;
            pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pictureBox2.Location = new System.Drawing.Point(285, 44);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(118, 75);
            pictureBox2.TabIndex = 517;
            pictureBox2.TabStop = false;
            // 
            // pictureBox12
            // 
            pictureBox12.BackgroundImage = Properties.Resources.ConV_GuidanceLookAhead;
            pictureBox12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pictureBox12.Location = new System.Drawing.Point(17, 190);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new System.Drawing.Size(118, 75);
            pictureBox12.TabIndex = 515;
            pictureBox12.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImage = Properties.Resources.ConV_LineWith;
            pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pictureBox5.Location = new System.Drawing.Point(17, 44);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new System.Drawing.Size(118, 75);
            pictureBox5.TabIndex = 521;
            pictureBox5.TabStop = false;
            // 
            // nudcmPerPixel
            // 
            nudcmPerPixel.BackColor = System.Drawing.Color.White;
            nudcmPerPixel.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            nudcmPerPixel.InterceptArrowKeys = false;
            nudcmPerPixel.Location = new System.Drawing.Point(412, 193);
            nudcmPerPixel.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            nudcmPerPixel.Name = "nudcmPerPixel";
            nudcmPerPixel.ReadOnly = true;
            nudcmPerPixel.Size = new System.Drawing.Size(78, 46);
            nudcmPerPixel.TabIndex = 524;
            nudcmPerPixel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudcmPerPixel.Value = new decimal(new int[] { 3, 0, 0, 0 });
            nudcmPerPixel.Click += nudcmPerPixel_Click;
            // 
            // nudLineWidth
            // 
            nudLineWidth.BackColor = System.Drawing.Color.White;
            nudLineWidth.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            nudLineWidth.InterceptArrowKeys = false;
            nudLineWidth.Location = new System.Drawing.Point(153, 47);
            nudLineWidth.Maximum = new decimal(new int[] { 8, 0, 0, 0 });
            nudLineWidth.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudLineWidth.Name = "nudLineWidth";
            nudLineWidth.ReadOnly = true;
            nudLineWidth.Size = new System.Drawing.Size(78, 46);
            nudLineWidth.TabIndex = 520;
            nudLineWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudLineWidth.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nudLineWidth.Click += nudLineWidth_Click;
            // 
            // nudSnapDistance
            // 
            nudSnapDistance.BackColor = System.Drawing.Color.White;
            nudSnapDistance.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            nudSnapDistance.InterceptArrowKeys = false;
            nudSnapDistance.Location = new System.Drawing.Point(412, 47);
            nudSnapDistance.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudSnapDistance.Name = "nudSnapDistance";
            nudSnapDistance.ReadOnly = true;
            nudSnapDistance.Size = new System.Drawing.Size(78, 46);
            nudSnapDistance.TabIndex = 516;
            nudSnapDistance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudSnapDistance.Value = new decimal(new int[] { 499, 0, 0, 0 });
            nudSnapDistance.Click += nudSnapDistance_Click;
            // 
            // nudGuidanceLookAhead
            // 
            nudGuidanceLookAhead.BackColor = System.Drawing.Color.White;
            nudGuidanceLookAhead.DecimalPlaces = 1;
            nudGuidanceLookAhead.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            nudGuidanceLookAhead.InterceptArrowKeys = false;
            nudGuidanceLookAhead.Location = new System.Drawing.Point(142, 196);
            nudGuidanceLookAhead.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudGuidanceLookAhead.Minimum = new decimal(new int[] { 1, 0, 0, 65536 });
            nudGuidanceLookAhead.Name = "nudGuidanceLookAhead";
            nudGuidanceLookAhead.ReadOnly = true;
            nudGuidanceLookAhead.Size = new System.Drawing.Size(100, 46);
            nudGuidanceLookAhead.TabIndex = 512;
            nudGuidanceLookAhead.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudGuidanceLookAhead.Value = new decimal(new int[] { 10, 0, 0, 0 });
            nudGuidanceLookAhead.Click += nudGuidanceLookAhead_Click;
            // 
            // imageList2
            // 
            imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            imageList2.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("imageList2.ImageStream");
            imageList2.TransparentColor = System.Drawing.Color.Transparent;
            imageList2.Images.SetKeyName(0, "Sensors.png");
            imageList2.Images.SetKeyName(1, "ConS_Pins.png");
            imageList2.Images.SetKeyName(2, "ConS_ModulesSteer.png");
            imageList2.Images.SetKeyName(3, "ConS_Alarm.png");
            imageList2.Images.SetKeyName(4, "ConS_VehicleConfig.png");
            // 
            // labelWizard
            // 
            labelWizard.BackColor = System.Drawing.Color.Transparent;
            labelWizard.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelWizard.ForeColor = System.Drawing.Color.Black;
            labelWizard.Location = new System.Drawing.Point(381, 530);
            labelWizard.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            labelWizard.Name = "labelWizard";
            labelWizard.Size = new System.Drawing.Size(100, 23);
            labelWizard.TabIndex = 530;
            labelWizard.Text = "Wizard";
            labelWizard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSteerWizard
            // 
            btnSteerWizard.BackColor = System.Drawing.Color.Transparent;
            btnSteerWizard.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            btnSteerWizard.FlatAppearance.BorderSize = 0;
            btnSteerWizard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            btnSteerWizard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSteerWizard.Font = new System.Drawing.Font("Tahoma", 15.75F);
            btnSteerWizard.Image = Properties.Resources.WizardWand;
            btnSteerWizard.Location = new System.Drawing.Point(393, 553);
            btnSteerWizard.Name = "btnSteerWizard";
            btnSteerWizard.Size = new System.Drawing.Size(75, 69);
            btnSteerWizard.TabIndex = 529;
            btnSteerWizard.UseVisualStyleBackColor = false;
            btnSteerWizard.Click += btnSteerWizard_Click;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.AliceBlue;
            button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button2.Font = new System.Drawing.Font("Tahoma", 15.75F);
            button2.Image = Properties.Resources.Reset_Default;
            button2.Location = new System.Drawing.Point(523, 554);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(75, 69);
            button2.TabIndex = 522;
            button2.UseVisualStyleBackColor = false;
            button2.Click += btnVehicleReset_Click;
            // 
            // pboxSendSteer
            // 
            pboxSendSteer.BackgroundImage = Properties.Resources.ConSt_Mandatory1;
            pboxSendSteer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pboxSendSteer.Location = new System.Drawing.Point(753, 560);
            pboxSendSteer.Name = "pboxSendSteer";
            pboxSendSteer.Size = new System.Drawing.Size(61, 62);
            pboxSendSteer.TabIndex = 509;
            pboxSendSteer.TabStop = false;
            pboxSendSteer.Visible = false;
            // 
            // btnSendSteerConfigPGN
            // 
            btnSendSteerConfigPGN.BackColor = System.Drawing.Color.White;
            btnSendSteerConfigPGN.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            btnSendSteerConfigPGN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSendSteerConfigPGN.Image = Properties.Resources.ToolAcceptChange;
            btnSendSteerConfigPGN.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnSendSteerConfigPGN.Location = new System.Drawing.Point(643, 560);
            btnSendSteerConfigPGN.Name = "btnSendSteerConfigPGN";
            btnSendSteerConfigPGN.Size = new System.Drawing.Size(103, 62);
            btnSendSteerConfigPGN.TabIndex = 501;
            btnSendSteerConfigPGN.UseVisualStyleBackColor = false;
            btnSendSteerConfigPGN.Click += btnSendSteerConfigPGN_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = System.Drawing.Color.Transparent;
            btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClose.Font = new System.Drawing.Font("Tahoma", 15.75F);
            btnClose.Image = Properties.Resources.OK64;
            btnClose.Location = new System.Drawing.Point(824, 558);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(64, 64);
            btnClose.TabIndex = 531;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // FormSteer
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            BackColor = System.Drawing.Color.WhiteSmoke;
            ClientSize = new System.Drawing.Size(898, 628);
            Controls.Add(btnClose);
            Controls.Add(labelWizard);
            Controls.Add(btnSteerWizard);
            Controls.Add(tabSteerSettings);
            Controls.Add(button2);
            Controls.Add(labelReset);
            Controls.Add(labelSendAndSave);
            Controls.Add(pboxSendSteer);
            Controls.Add(btnSendSteerConfigPGN);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(tabControl1);
            Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(918, 673);
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size(387, 478);
            Name = "FormSteer";
            Padding = new System.Windows.Forms.Padding(2);
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Auto Steer Configuration";
            FormClosing += FormSteer_FormClosing;
            Load += FormSteer_Load;
            tabControl1.ResumeLayout(false);
            tabPP.ResumeLayout(false);
            tabPP.PerformLayout();
            tabStan.ResumeLayout(false);
            tabSteer.ResumeLayout(false);
            tabSteer.PerformLayout();
            tabPPAdv.ResumeLayout(false);
            tabPPAdv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudDeadZoneDelay).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudDeadZoneHeading).EndInit();
            tabGain.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabSteerSettings.ResumeLayout(false);
            tabSensors.ResumeLayout(false);
            tabSensors.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudMaxCounts).EndInit();
            tabConfig.ResumeLayout(false);
            tabConfig.PerformLayout();
            tabSettings.ResumeLayout(false);
            tabSettings.PerformLayout();
            grpSmartWAS.ResumeLayout(false);
            grpSmartWAS.PerformLayout();
            tabAlarm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox17).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox16).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMinSteerSpeed).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMaxSteerSpeed).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudGuidanceSpeedLimit).EndInit();
            tabOnTheLine.ResumeLayout(false);
            tabOnTheLine.PerformLayout();
            groupboxlabelGuidanceBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudcmPerPixel).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudLineWidth).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSnapDistance).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudGuidanceLookAhead).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxSendSteer).EndInit();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnFreeDrive;
        private System.Windows.Forms.Label lblHighSteerPWM;
        private System.Windows.Forms.HScrollBar hsbarHighSteerPWM;
        private System.Windows.Forms.Label lblProportionalGain;
        private System.Windows.Forms.HScrollBar hsbarProportionalGain;
        private System.Windows.Forms.Label lblMinPWM;
        private System.Windows.Forms.HScrollBar hsbarMinPWM;
        private System.Windows.Forms.Label lblMaxSteerAngle;
        private System.Windows.Forms.HScrollBar hsbarMaxSteerAngle;
        private System.Windows.Forms.HScrollBar hsbarLookAheadMult;
        private System.Windows.Forms.Label lblLookAheadMult;
        private System.Windows.Forms.HScrollBar hsbarHeadingErrorGain;
        private System.Windows.Forms.Label lblStanleyGain;
        private System.Windows.Forms.HScrollBar hsbarStanleyGain;
        private System.Windows.Forms.Label labelDistance;
        private System.Windows.Forms.Label labelHeading;
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
        private System.Windows.Forms.TabPage tabPP;
        private System.Windows.Forms.Button btnStartSA;
        private System.Windows.Forms.Label lblCalcSteerAngleInner;
        private System.Windows.Forms.Label lblDiameter;
        private System.Windows.Forms.Label labelSteerAngle;
        private System.Windows.Forms.Label labelDiameter;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label labelMinToMove;
        private System.Windows.Forms.Label labelMaxLimit;
        private System.Windows.Forms.Label labelProportionalGain;
        private System.Windows.Forms.Label labelIntegralPP;
        private System.Windows.Forms.Label labelMaxSteerAngle;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label labelSpeedFactor;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TabPage tabSteer;
        private System.Windows.Forms.Label labelAckermann;
        private System.Windows.Forms.Label labelCountsPerDegree;
        private System.Windows.Forms.HScrollBar hsbarAckerman;
        private System.Windows.Forms.Label lblAckerman;
        private System.Windows.Forms.ProgressBar pbarRight;
        private System.Windows.Forms.ProgressBar pbarLeft;
        private System.Windows.Forms.Label lblActualSteerAngleUpper;
        private System.Windows.Forms.Button btnZeroWAS;
        private System.Windows.Forms.HScrollBar hsbarCountsPerDegree;
        private System.Windows.Forms.Label lblCountsPerDegree;
        private System.Windows.Forms.HScrollBar hsbarWasOffset;
        private System.Windows.Forms.Label lblSteerAngleSensorZero;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label labelIntergralStanley;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.HScrollBar hsbarIntegral;
        private System.Windows.Forms.HScrollBar hsbarIntegralPurePursuit;
        private System.Windows.Forms.Label lblIntegralPercent;
        private System.Windows.Forms.Label lblPureIntegral;
        private System.Windows.Forms.Label lblSideHillComp;
        private System.Windows.Forms.HScrollBar hsbarSideHillComp;
        private System.Windows.Forms.Label labelSideHill;
        private System.Windows.Forms.ProgressBar pbarSensor;
        private System.Windows.Forms.Label lblPercentFS;
        private System.Windows.Forms.Label labelSteerDescription;
        private System.Windows.Forms.Label labelPressureTurnSensor;
        private System.Windows.Forms.Label labelCurrentTurnSensor;
        private System.Windows.Forms.Label labelEncoder;
        private System.Windows.Forms.Label labelInvertMotor;
        private System.Windows.Forms.Label labelInvertRelays;
        private System.Windows.Forms.Label labelSendAndSave;
        private System.Windows.Forms.ComboBox cboxMotorDrive;
        private System.Windows.Forms.ComboBox cboxSteerEnable;
        private System.Windows.Forms.Label labelSteerEnable;
        private System.Windows.Forms.ComboBox cboxConv;
        private System.Windows.Forms.Label labelMotorDriver;
        private System.Windows.Forms.Label labelADConverter;
        private System.Windows.Forms.Label labelTurnSensor;
        private NudlessNumericUpDown nudMaxCounts;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.CheckBox cboxCurrentSensor;
        private System.Windows.Forms.CheckBox cboxPressureSensor;
        private System.Windows.Forms.PictureBox pboxSendSteer;
        private System.Windows.Forms.CheckBox cboxDanfoss;
        private System.Windows.Forms.CheckBox chkSteerInvertRelays;
        private System.Windows.Forms.CheckBox chkInvertSteer;
        private System.Windows.Forms.CheckBox cboxEncoder;
        private System.Windows.Forms.CheckBox chkInvertWAS;
        private System.Windows.Forms.Button btnSendSteerConfigPGN;
        private System.Windows.Forms.Label labelInvertWas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.HScrollBar hsbarSensor;
        private System.Windows.Forms.Label lblhsbarSensor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelReset;
        private System.Windows.Forms.ComboBox cboxXY;
        private System.Windows.Forms.Label labelIMUAxis;
        private System.Windows.Forms.Label label34;
        public System.Windows.Forms.Button btnStanleyPure;
        private System.Windows.Forms.Label lblAV_Set;
        private System.Windows.Forms.Label lblAV_Act;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label38;
        private AgLibrary.Controls.RepeatButton btnExpand;
        private System.Windows.Forms.TabControl tabSteerSettings;
        private System.Windows.Forms.TabPage tabSensors;
        private System.Windows.Forms.TabPage tabConfig;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Button btnSteerWizard;
        private System.Windows.Forms.Label labelWizard;
        private System.Windows.Forms.HScrollBar hsbarUTurnCompensation;
        private System.Windows.Forms.Label lblUTurnCompensation;
        private System.Windows.Forms.Label labelUturnCompensation;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TabPage tabAlarm;
        private NudlessNumericUpDown nudMinSteerSpeed;
        private System.Windows.Forms.Label labelMinSpeed;
        private System.Windows.Forms.Label label166;
        private System.Windows.Forms.Label labelMaxSpeed;
        private System.Windows.Forms.Label label163;
        private System.Windows.Forms.Label label160;
        private System.Windows.Forms.Label labelManualTurns;
        private NudlessNumericUpDown nudMaxSteerSpeed;
        private NudlessNumericUpDown nudGuidanceSpeedLimit;
        private System.Windows.Forms.PictureBox pictureBox17;
        private System.Windows.Forms.PictureBox pictureBox16;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Label label107;
        private System.Windows.Forms.Label labelNextGuidanceLine;
        private NudlessNumericUpDown nudGuidanceLookAhead;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.Label labelNudgeDistance;
        private System.Windows.Forms.Label label43;
        private NudlessNumericUpDown nudSnapDistance;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelLineWidth;
        private System.Windows.Forms.Label label44;
        private NudlessNumericUpDown nudLineWidth;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label labelCmPix;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.PictureBox pictureBox1;
        private NudlessNumericUpDown nudcmPerPixel;
        private System.Windows.Forms.Label labelSteerInReverse;
        private System.Windows.Forms.CheckBox cboxSteerInReverse;
        private System.Windows.Forms.Label labelHeadingDegree;
        private NudlessNumericUpDown nudDeadZoneHeading;
        private System.Windows.Forms.TabPage tabOnTheLine;
        private System.Windows.Forms.GroupBox groupboxlabelGuidanceBar;
        private System.Windows.Forms.RadioButton rbtnSteerBar;
        private System.Windows.Forms.Label labelSteerBar;
        private System.Windows.Forms.RadioButton rbtnLightBar;
        private System.Windows.Forms.Label labelLightbar;
        private System.Windows.Forms.CheckBox chkDisplayLightbar;
        private System.Windows.Forms.Label labelSlow;
        private System.Windows.Forms.Label labelFast;
        private System.Windows.Forms.Label labelSteerResponse;
        private System.Windows.Forms.Label lblHoldLookAhead;
        private System.Windows.Forms.HScrollBar hsbarHoldLookAhead;
        private System.Windows.Forms.Label labelIntegralInfo;
        private System.Windows.Forms.Label labelOnOff;
        private System.Windows.Forms.Label labelOnDelay;
        private NudlessNumericUpDown nudDeadZoneDelay;
        private System.Windows.Forms.Label labelDeadzone;
        private System.Windows.Forms.Label labelHold;
        private System.Windows.Forms.Label labelAcquireDescription;
        private System.Windows.Forms.Label lblAcquireFactor;
        private System.Windows.Forms.HScrollBar hsbarAcquireFactor;
        private System.Windows.Forms.Label lblHoldAdv;
        private System.Windows.Forms.Label lblAcqAdv;
        private System.Windows.Forms.Label labelAcquire2;
        private System.Windows.Forms.Label lblDistanceAdv;
        private System.Windows.Forms.Label labelDist;
        private System.Windows.Forms.TabPage tabPPAdv;
        private System.Windows.Forms.Label labelAcquireFactor;
        private System.Windows.Forms.Label labelAcquire;
        private System.Windows.Forms.Label lblAcquirePP;
        private System.Windows.Forms.Label labelWasZero;

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox grpSmartWAS;
        private System.Windows.Forms.Label lblSmartCalStatus;
        private System.Windows.Forms.Button btnSmartZeroWAS;
        private System.Windows.Forms.Label lblSmartCalConfidence;
        private System.Windows.Forms.Label lblSmartCalSamples;
    }
}
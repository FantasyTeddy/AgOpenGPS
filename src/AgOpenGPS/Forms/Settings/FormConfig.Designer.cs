using AgOpenGPS.Core.Models;
using AgOpenGPS.ResourcesBrands;

namespace AgOpenGPS
{
    partial class FormConfig
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
            panelLeftSideMenu = new System.Windows.Forms.Panel();
            btnFeatureHides = new System.Windows.Forms.Button();
            btnDisplay = new System.Windows.Forms.Button();
            btnTram = new System.Windows.Forms.Button();
            panelArduinoSubMenu = new System.Windows.Forms.Panel();
            btnMachineRelay = new System.Windows.Forms.Button();
            btnMachineModule = new System.Windows.Forms.Button();
            btnArduino = new System.Windows.Forms.Button();
            btnUTurn = new System.Windows.Forms.Button();
            panelDataSourcesSubMenu = new System.Windows.Forms.Panel();
            btnSubRoll = new System.Windows.Forms.Button();
            btnSubHeading = new System.Windows.Forms.Button();
            btnDataSources = new System.Windows.Forms.Button();
            panelToolSubMenu = new System.Windows.Forms.Panel();
            btnSubSwitches = new System.Windows.Forms.Button();
            btnSubToolSettings = new System.Windows.Forms.Button();
            btnSubSections = new System.Windows.Forms.Button();
            btnSubToolOffset = new System.Windows.Forms.Button();
            btnSubPivot = new System.Windows.Forms.Button();
            btnSubHitch = new System.Windows.Forms.Button();
            btnSubToolType = new System.Windows.Forms.Button();
            btnTool = new System.Windows.Forms.Button();
            panelVehicleSubMenu = new System.Windows.Forms.Panel();
            button1 = new System.Windows.Forms.Button();
            btnSubAntenna = new System.Windows.Forms.Button();
            btnSubDimensions = new System.Windows.Forms.Button();
            btnSubVehicleType = new System.Windows.Forms.Button();
            btnVehicle = new System.Windows.Forms.Button();
            tab1 = new System.Windows.Forms.TabControl();
            tabSummary = new System.Windows.Forms.TabPage();
            configSummaryControl = new AgOpenGPS.Forms.Config.ConfigSummaryControl();
            tabVConfig = new System.Windows.Forms.TabPage();
            configVehicleControl = new AgOpenGPS.Forms.Config.ConfigVehicleControl();
            tabVAntenna = new System.Windows.Forms.TabPage();
            labelPivotDistance = new System.Windows.Forms.Label();
            labelAntHeight = new System.Windows.Forms.Label();
            labelCenter = new System.Windows.Forms.Label();
            labelAntOffset = new System.Windows.Forms.GroupBox();
            rbtnAntennaCenter = new System.Windows.Forms.RadioButton();
            rbtnAntennaRight = new System.Windows.Forms.RadioButton();
            rbtnAntennaLeft = new System.Windows.Forms.RadioButton();
            labelLeft = new System.Windows.Forms.Label();
            labelRight = new System.Windows.Forms.Label();
            labelDualPositionOnRight = new System.Windows.Forms.Label();
            label100 = new System.Windows.Forms.Label();
            label99 = new System.Windows.Forms.Label();
            label98 = new System.Windows.Forms.Label();
            nudAntennaOffset = new NudlessNumericUpDown();
            nudAntennaHeight = new NudlessNumericUpDown();
            nudAntennaPivot = new NudlessNumericUpDown();
            pboxAntenna = new System.Windows.Forms.PictureBox();
            tabVDimensions = new System.Windows.Forms.TabPage();
            HitchLengthBlindBox = new System.Windows.Forms.PictureBox();
            label97 = new System.Windows.Forms.Label();
            label95 = new System.Windows.Forms.Label();
            label94 = new System.Windows.Forms.Label();
            labelHitchLength = new System.Windows.Forms.Label();
            labelTrack = new System.Windows.Forms.Label();
            labelWheelBase2 = new System.Windows.Forms.Label();
            nudTractorHitchLength = new NudlessNumericUpDown();
            nudVehicleTrack = new NudlessNumericUpDown();
            nudWheelbase = new NudlessNumericUpDown();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            tabVGuidance = new System.Windows.Forms.TabPage();
            tabTConfig = new System.Windows.Forms.TabPage();
            labelBoxAttachmentStyle = new System.Windows.Forms.GroupBox();
            pboxConfigHarvester = new System.Windows.Forms.PictureBox();
            rbtnTBT = new System.Windows.Forms.RadioButton();
            rbtnFixedRear = new System.Windows.Forms.RadioButton();
            rbtnFront = new System.Windows.Forms.RadioButton();
            rbtnTrailing = new System.Windows.Forms.RadioButton();
            tabTHitch = new System.Windows.Forms.TabPage();
            label112 = new System.Windows.Forms.Label();
            labelTractorUnits = new System.Windows.Forms.Label();
            nudTrailingHitchLength = new NudlessNumericUpDown();
            nudDrawbarLength = new NudlessNumericUpDown();
            nudTankHitch = new NudlessNumericUpDown();
            picboxToolHitch = new System.Windows.Forms.PictureBox();
            tabToolOffset = new System.Windows.Forms.TabPage();
            btnZeroOverlap = new System.Windows.Forms.Button();
            btnZeroToolOffset = new System.Windows.Forms.Button();
            label176 = new System.Windows.Forms.Label();
            label175 = new System.Windows.Forms.Label();
            labelOverlapGap = new System.Windows.Forms.GroupBox();
            labelOverlap2 = new System.Windows.Forms.Label();
            labelGap = new System.Windows.Forms.Label();
            rbtnToolOverlap = new System.Windows.Forms.RadioButton();
            rbtnToolGap = new System.Windows.Forms.RadioButton();
            labelToolOffset = new System.Windows.Forms.GroupBox();
            labelToolRight = new System.Windows.Forms.Label();
            rbtnLeftNegative = new System.Windows.Forms.RadioButton();
            rbtnToolRightPositive = new System.Windows.Forms.RadioButton();
            labelToolLeft = new System.Windows.Forms.Label();
            nudOverlap = new NudlessNumericUpDown();
            nudOffset = new NudlessNumericUpDown();
            tabToolPivot = new System.Windows.Forms.TabPage();
            btnPivotOffsetZero = new System.Windows.Forms.Button();
            LabelCm = new System.Windows.Forms.Label();
            nudTrailingToolToPivotLength = new NudlessNumericUpDown();
            rbtnPivotBehindPos = new System.Windows.Forms.RadioButton();
            rbtnPivotAheadNeg = new System.Windows.Forms.RadioButton();
            tabTSections = new System.Windows.Forms.TabPage();
            panelSymmetricSections = new System.Windows.Forms.Panel();
            nudZone8To = new NudlessNumericUpDown();
            lblZoneStart8 = new System.Windows.Forms.Label();
            labelZone8 = new System.Windows.Forms.Label();
            label158 = new System.Windows.Forms.Label();
            nudZone7To = new NudlessNumericUpDown();
            lblZoneStart7 = new System.Windows.Forms.Label();
            labelZone7 = new System.Windows.Forms.Label();
            label155 = new System.Windows.Forms.Label();
            nudZone6To = new NudlessNumericUpDown();
            nudZone4To = new NudlessNumericUpDown();
            nudZone1To = new NudlessNumericUpDown();
            nudZone5To = new NudlessNumericUpDown();
            nudZone3To = new NudlessNumericUpDown();
            nudZone2To = new NudlessNumericUpDown();
            lblZoneStart6 = new System.Windows.Forms.Label();
            lblZoneStart5 = new System.Windows.Forms.Label();
            lblZoneStart4 = new System.Windows.Forms.Label();
            lblZoneStart3 = new System.Windows.Forms.Label();
            lblZoneStart2 = new System.Windows.Forms.Label();
            lblZoneStart1 = new System.Windows.Forms.Label();
            labelZone1 = new System.Windows.Forms.Label();
            labelZone2 = new System.Windows.Forms.Label();
            labelZone6 = new System.Windows.Forms.Label();
            labelZone3 = new System.Windows.Forms.Label();
            labelZone5 = new System.Windows.Forms.Label();
            labelZone4 = new System.Windows.Forms.Label();
            label152 = new System.Windows.Forms.Label();
            label117 = new System.Windows.Forms.Label();
            label116 = new System.Windows.Forms.Label();
            label104 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label178 = new System.Windows.Forms.Label();
            labelBoundary = new System.Windows.Forms.Label();
            lblTurnOffBelowUnits = new System.Windows.Forms.Label();
            labelChoose = new System.Windows.Forms.Label();
            lblInchCm2 = new System.Windows.Forms.Label();
            labelSectionWidth = new System.Windows.Forms.Label();
            cboxNumSections = new System.Windows.Forms.ComboBox();
            lblVehicleToolWidth = new System.Windows.Forms.Label();
            labelCoverage = new System.Windows.Forms.Label();
            labelZonesBox = new System.Windows.Forms.Label();
            labelNumOfSections = new System.Windows.Forms.Label();
            cboxNumberOfZones = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label19 = new System.Windows.Forms.Label();
            label30 = new System.Windows.Forms.Label();
            label32 = new System.Windows.Forms.Label();
            label34 = new System.Windows.Forms.Label();
            label35 = new System.Windows.Forms.Label();
            label40 = new System.Windows.Forms.Label();
            label39 = new System.Windows.Forms.Label();
            label38 = new System.Windows.Forms.Label();
            label37 = new System.Windows.Forms.Label();
            label41 = new System.Windows.Forms.Label();
            label45 = new System.Windows.Forms.Label();
            label46 = new System.Windows.Forms.Label();
            label47 = new System.Windows.Forms.Label();
            label48 = new System.Windows.Forms.Label();
            nudCutoffSpeed = new NudlessNumericUpDown();
            nudDefaultSectionWidth = new NudlessNumericUpDown();
            nudMinCoverage = new NudlessNumericUpDown();
            nudSection16 = new NudlessNumericUpDown();
            nudSection15 = new NudlessNumericUpDown();
            nudSection14 = new NudlessNumericUpDown();
            nudSection13 = new NudlessNumericUpDown();
            nudSection12 = new NudlessNumericUpDown();
            nudSection11 = new NudlessNumericUpDown();
            nudSection10 = new NudlessNumericUpDown();
            nudSection09 = new NudlessNumericUpDown();
            nudSection08 = new NudlessNumericUpDown();
            nudSection07 = new NudlessNumericUpDown();
            nudSection06 = new NudlessNumericUpDown();
            nudSection05 = new NudlessNumericUpDown();
            nudSection04 = new NudlessNumericUpDown();
            nudSection03 = new NudlessNumericUpDown();
            nudSection02 = new NudlessNumericUpDown();
            nudSection01 = new NudlessNumericUpDown();
            nudNumberOfSections = new NudlessNumericUpDown();
            cboxSectionBoundaryControl = new System.Windows.Forms.CheckBox();
            pictureBox11 = new System.Windows.Forms.PictureBox();
            cboxIsUnique = new System.Windows.Forms.CheckBox();
            tabTSwitches = new System.Windows.Forms.TabPage();
            labelGroupSteerSwitch = new System.Windows.Forms.GroupBox();
            chkSetAutoSectionsSteer = new System.Windows.Forms.CheckBox();
            chkSelectSteerSwitch = new System.Windows.Forms.CheckBox();
            chkSetManualSectionsSteer = new System.Windows.Forms.CheckBox();
            labelGroupWorkSwitch = new System.Windows.Forms.GroupBox();
            chkSelectWorkSwitch = new System.Windows.Forms.CheckBox();
            chkSetAutoSections = new System.Windows.Forms.CheckBox();
            chkSetManualSections = new System.Windows.Forms.CheckBox();
            chkWorkSwActiveLow = new System.Windows.Forms.CheckBox();
            tabTSettings = new System.Windows.Forms.TabPage();
            labelLookAheadTiming = new System.Windows.Forms.Label();
            labelOnTime = new System.Windows.Forms.Label();
            labelOffTime = new System.Windows.Forms.Label();
            labelDelayTime = new System.Windows.Forms.Label();
            nudLookAheadOff = new NudlessNumericUpDown();
            nudTurnOffDelay = new NudlessNumericUpDown();
            nudLookAhead = new NudlessNumericUpDown();
            pictureBox18 = new System.Windows.Forms.PictureBox();
            pictureBox4 = new System.Windows.Forms.PictureBox();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            tabDHeading = new System.Windows.Forms.TabPage();
            labelFixAlarmStop = new System.Windows.Forms.Label();
            label118 = new System.Windows.Forms.Label();
            label113 = new System.Windows.Forms.Label();
            labelFixAlarm = new System.Windows.Forms.Label();
            labelGboxDual = new System.Windows.Forms.GroupBox();
            labelAutoSwitchDualFixSpeed = new System.Windows.Forms.Label();
            nudAutoSwitchDualFixSpeed = new NudlessNumericUpDown();
            cboxIsAutoSwitchDualFixOn = new System.Windows.Forms.CheckBox();
            labelReverseDistance = new System.Windows.Forms.Label();
            nudDualReverseDistance = new NudlessNumericUpDown();
            pictureBox13 = new System.Windows.Forms.PictureBox();
            nudDualHeadingOffset = new NudlessNumericUpDown();
            labelHeadingOffset = new System.Windows.Forms.Label();
            labelGboxSingle = new System.Windows.Forms.GroupBox();
            lblHeadingDistance = new System.Windows.Forms.Label();
            cboxMinGPSStep = new System.Windows.Forms.CheckBox();
            labelDefault70 = new System.Windows.Forms.Label();
            lblFusionIMU = new System.Windows.Forms.Label();
            lblIMU = new System.Windows.Forms.Label();
            lblGPS = new System.Windows.Forms.Label();
            hsbarFusion = new System.Windows.Forms.HScrollBar();
            lblFusion = new System.Windows.Forms.Label();
            labelIMUFusion = new System.Windows.Forms.Label();
            cboxIsReverseOn = new System.Windows.Forms.CheckBox();
            labelFix2Fix = new System.Windows.Forms.Label();
            labelGpsStep = new System.Windows.Forms.Label();
            headingGroupBox = new System.Windows.Forms.GroupBox();
            rbtnHeadingHDT = new System.Windows.Forms.RadioButton();
            rbtnHeadingFix = new System.Windows.Forms.RadioButton();
            nudFixJumpDistance = new NudlessNumericUpDown();
            cboxIsRTK_KillAutoSteer = new System.Windows.Forms.CheckBox();
            cboxIsRTK = new System.Windows.Forms.CheckBox();
            tabDRoll = new System.Windows.Forms.TabPage();
            btnRollOffsetUp = new AgLibrary.Controls.RepeatButton();
            btnRollOffsetDown = new AgLibrary.Controls.RepeatButton();
            pictureBox9 = new System.Windows.Forms.PictureBox();
            labelInvertRoll = new System.Windows.Forms.Label();
            labelZeroRoll = new System.Windows.Forms.Label();
            labelRemoveOffset = new System.Windows.Forms.Label();
            lblRollZeroOffset = new System.Windows.Forms.Label();
            labelLess = new System.Windows.Forms.Label();
            labelMore = new System.Windows.Forms.Label();
            lblRollFilterPercent = new System.Windows.Forms.Label();
            labelRollFilter = new System.Windows.Forms.Label();
            hsbarRollFilter = new System.Windows.Forms.HScrollBar();
            btnResetIMU = new System.Windows.Forms.Button();
            btnZeroRoll = new System.Windows.Forms.Button();
            btnRemoveZeroOffset = new System.Windows.Forms.Button();
            cboxDataInvertRoll = new System.Windows.Forms.CheckBox();
            tabUTurn = new System.Windows.Forms.TabPage();
            labelUturnSmooth = new System.Windows.Forms.Label();
            labelUturnExtend = new System.Windows.Forms.Label();
            lblFtMTurnRadius = new System.Windows.Forms.Label();
            lblFtMUTurn = new System.Windows.Forms.Label();
            lblSmoothing = new System.Windows.Forms.Label();
            lblDistance = new System.Windows.Forms.Label();
            nudYouTurnRadius = new NudlessNumericUpDown();
            nudTurnDistanceFromBoundary = new NudlessNumericUpDown();
            label64 = new System.Windows.Forms.Label();
            btnTurnSmoothingUp = new AgLibrary.Controls.RepeatButton();
            btnTurnSmoothingDown = new AgLibrary.Controls.RepeatButton();
            label59 = new System.Windows.Forms.Label();
            label58 = new System.Windows.Forms.Label();
            lblWhenTrig = new System.Windows.Forms.Label();
            btnDistanceUp = new AgLibrary.Controls.RepeatButton();
            btnDistanceDn = new AgLibrary.Controls.RepeatButton();
            tabRelay = new System.Windows.Forms.TabPage();
            cboxPin23 = new System.Windows.Forms.ComboBox();
            cboxPin22 = new System.Windows.Forms.ComboBox();
            cboxPin21 = new System.Windows.Forms.ComboBox();
            cboxPin20 = new System.Windows.Forms.ComboBox();
            label143 = new System.Windows.Forms.Label();
            label144 = new System.Windows.Forms.Label();
            label145 = new System.Windows.Forms.Label();
            label146 = new System.Windows.Forms.Label();
            cboxPin19 = new System.Windows.Forms.ComboBox();
            cboxPin18 = new System.Windows.Forms.ComboBox();
            cboxPin17 = new System.Windows.Forms.ComboBox();
            cboxPin16 = new System.Windows.Forms.ComboBox();
            cboxPin15 = new System.Windows.Forms.ComboBox();
            cboxPin14 = new System.Windows.Forms.ComboBox();
            cboxPin13 = new System.Windows.Forms.ComboBox();
            cboxPin12 = new System.Windows.Forms.ComboBox();
            cboxPin11 = new System.Windows.Forms.ComboBox();
            cboxPin10 = new System.Windows.Forms.ComboBox();
            cboxPin9 = new System.Windows.Forms.ComboBox();
            cboxPin8 = new System.Windows.Forms.ComboBox();
            cboxPin7 = new System.Windows.Forms.ComboBox();
            cboxPin6 = new System.Windows.Forms.ComboBox();
            cboxPin5 = new System.Windows.Forms.ComboBox();
            cboxPin4 = new System.Windows.Forms.ComboBox();
            cboxPin3 = new System.Windows.Forms.ComboBox();
            cboxPin2 = new System.Windows.Forms.ComboBox();
            cboxPin1 = new System.Windows.Forms.ComboBox();
            label138 = new System.Windows.Forms.Label();
            label139 = new System.Windows.Forms.Label();
            label140 = new System.Windows.Forms.Label();
            label141 = new System.Windows.Forms.Label();
            label142 = new System.Windows.Forms.Label();
            label133 = new System.Windows.Forms.Label();
            label134 = new System.Windows.Forms.Label();
            label135 = new System.Windows.Forms.Label();
            label136 = new System.Windows.Forms.Label();
            label137 = new System.Windows.Forms.Label();
            label132 = new System.Windows.Forms.Label();
            label131 = new System.Windows.Forms.Label();
            label130 = new System.Windows.Forms.Label();
            label129 = new System.Windows.Forms.Label();
            label128 = new System.Windows.Forms.Label();
            label127 = new System.Windows.Forms.Label();
            label126 = new System.Windows.Forms.Label();
            label125 = new System.Windows.Forms.Label();
            label124 = new System.Windows.Forms.Label();
            labelSendandSave = new System.Windows.Forms.Label();
            cboxPin0 = new System.Windows.Forms.ComboBox();
            label123 = new System.Windows.Forms.Label();
            btnRelaySetDefaultConfig = new System.Windows.Forms.Button();
            btnRelayResetConfigToNone = new System.Windows.Forms.Button();
            pboxSendRelay = new System.Windows.Forms.PictureBox();
            btnSendRelayConfigPGN = new System.Windows.Forms.Button();
            tabAMachine = new System.Windows.Forms.TabPage();
            labelUser4 = new System.Windows.Forms.Label();
            labelUser3 = new System.Windows.Forms.Label();
            labelUser2 = new System.Windows.Forms.Label();
            labelUser1 = new System.Windows.Forms.Label();
            labelGroupHyd = new System.Windows.Forms.GroupBox();
            labelPlantPop = new System.Windows.Forms.Label();
            nudHydLiftLookAhead = new NudlessNumericUpDown();
            labelHydLiftSec = new System.Windows.Forms.Label();
            labelRaiseTime = new System.Windows.Forms.Label();
            labelEnable = new System.Windows.Forms.Label();
            labelLowTime = new System.Windows.Forms.Label();
            cboxIsHydOn = new System.Windows.Forms.CheckBox();
            pictureBox6 = new System.Windows.Forms.PictureBox();
            nudLowerTime = new NudlessNumericUpDown();
            pictureBox7 = new System.Windows.Forms.PictureBox();
            nudRaiseTime = new NudlessNumericUpDown();
            labelHydLiftInvert = new System.Windows.Forms.Label();
            labelSendSaveHydraulicLift = new System.Windows.Forms.Label();
            labelMachineMod = new System.Windows.Forms.Label();
            nudUser4 = new NudlessNumericUpDown();
            nudUser3 = new NudlessNumericUpDown();
            nudUser2 = new NudlessNumericUpDown();
            nudUser1 = new NudlessNumericUpDown();
            pboxSendMachine = new System.Windows.Forms.PictureBox();
            cboxMachInvertRelays = new System.Windows.Forms.CheckBox();
            btnSendMachinePGN = new System.Windows.Forms.Button();
            tabTram = new System.Windows.Forms.TabPage();
            labelDisplay = new System.Windows.Forms.Label();
            labelOverride = new System.Windows.Forms.Label();
            lblTramWidthUnits = new System.Windows.Forms.Label();
            labelTramWidth = new System.Windows.Forms.Label();
            nudTramWidth = new NudlessNumericUpDown();
            cboxDisplayTramControl = new System.Windows.Forms.CheckBox();
            chkBoxOverrideTramControlPos = new System.Windows.Forms.CheckBox();
            pictureBox8 = new System.Windows.Forms.PictureBox();
            tabBtns = new System.Windows.Forms.TabPage();
            labelHardwareMessage = new System.Windows.Forms.Label();
            labelPowerLossOnOff = new System.Windows.Forms.Label();
            labelOffAgIO = new System.Windows.Forms.Label();
            labelSectionSoundOnOff = new System.Windows.Forms.Label();
            labelBottomMenu = new System.Windows.Forms.Label();
            labelNudgeCtrlOnOff = new System.Windows.Forms.Label();
            labelRightMenu = new System.Windows.Forms.Label();
            labelStartAgIO = new System.Windows.Forms.Label();
            labelHydLiftSoundOnOff = new System.Windows.Forms.Label();
            labelAutosteerSoundOnOff = new System.Windows.Forms.Label();
            labelUturnSoundOnOff = new System.Windows.Forms.Label();
            labelSounds = new System.Windows.Forms.Label();
            labelUturnOnOff = new System.Windows.Forms.Label();
            labelLateralOnOff = new System.Windows.Forms.Label();
            labelOffsetFixOnOff = new System.Windows.Forms.Label();
            labelContourOnOff = new System.Windows.Forms.Label();
            labelABSmoothOnOff = new System.Windows.Forms.Label();
            labelRecPathOnOff = new System.Windows.Forms.Label();
            labelBoundOnOff = new System.Windows.Forms.Label();
            labelTramlineOnOff = new System.Windows.Forms.Label();
            labelHeadlandOnOff = new System.Windows.Forms.Label();
            labelScreenButtons = new System.Windows.Forms.Label();
            labelToolsMenu = new System.Windows.Forms.Label();
            labelFieldMenu = new System.Windows.Forms.Label();
            label93 = new System.Windows.Forms.Label();
            cboxHardwareMessages = new System.Windows.Forms.CheckBox();
            cboxShutdownWhenNoPower = new System.Windows.Forms.CheckBox();
            cboxAutoOffAgIO = new System.Windows.Forms.CheckBox();
            cboxSectionsSound = new System.Windows.Forms.CheckBox();
            cboxFeatureNudge = new System.Windows.Forms.CheckBox();
            btnRightMenuOrder = new System.Windows.Forms.Button();
            cboxAutoStartAgIO = new System.Windows.Forms.CheckBox();
            cboxHydLiftSound = new System.Windows.Forms.CheckBox();
            cboxTurnSound = new System.Windows.Forms.CheckBox();
            cboxSteerSound = new System.Windows.Forms.CheckBox();
            cboxFeatureLateral = new System.Windows.Forms.CheckBox();
            cboxFeatureUTurn = new System.Windows.Forms.CheckBox();
            cboxFeatureOffsetFix = new System.Windows.Forms.CheckBox();
            cboxFeatureHideContour = new System.Windows.Forms.CheckBox();
            cboxFeatureABSmooth = new System.Windows.Forms.CheckBox();
            cboxFeatureRecPath = new System.Windows.Forms.CheckBox();
            cboxFeatureBoundary = new System.Windows.Forms.CheckBox();
            cboxFeatureHeadland = new System.Windows.Forms.CheckBox();
            cboxFeatureTram = new System.Windows.Forms.CheckBox();
            tabDisplay = new System.Windows.Forms.TabPage();
            lblHeadlandDist = new System.Windows.Forms.Label();
            chkboxHeadlandDist = new System.Windows.Forms.CheckBox();
            labelLineSmoothOnOff = new System.Windows.Forms.Label();
            labelSectionLinesOnOff = new System.Windows.Forms.Label();
            labelDirectionMarkOnOff = new System.Windows.Forms.Label();
            labelElevationOnOff = new System.Windows.Forms.Label();
            unitsGroupBox = new System.Windows.Forms.GroupBox();
            rbtnDisplayImperial = new System.Windows.Forms.RadioButton();
            rbtnDisplayMetric = new System.Windows.Forms.RadioButton();
            labelSvenArrowOnOff = new System.Windows.Forms.Label();
            labelBrightnessOnOff = new System.Windows.Forms.Label();
            labelFieldTextureOnOff = new System.Windows.Forms.Label();
            labelPolyOnOff = new System.Windows.Forms.Label();
            labelKeyboardOnOff = new System.Windows.Forms.Label();
            labelFullscreenOnOff = new System.Windows.Forms.Label();
            labelSpeedoOnOff = new System.Windows.Forms.Label();
            labelGuideLinesOnOff = new System.Windows.Forms.Label();
            labelGridOnOff = new System.Windows.Forms.Label();
            nudNumGuideLines = new NudlessNumericUpDown();
            chkLineSmooth = new System.Windows.Forms.CheckBox();
            chkSectionLines = new System.Windows.Forms.CheckBox();
            chkDirectionMarkers = new System.Windows.Forms.CheckBox();
            chkDisplayLogElevation = new System.Windows.Forms.CheckBox();
            chkSvennArrow = new System.Windows.Forms.CheckBox();
            chkDisplayBrightness = new System.Windows.Forms.CheckBox();
            chkDisplayFloor = new System.Windows.Forms.CheckBox();
            chkDisplayKeyboard = new System.Windows.Forms.CheckBox();
            chkDisplayPolygons = new System.Windows.Forms.CheckBox();
            chkDisplayStartFullScreen = new System.Windows.Forms.CheckBox();
            chkDisplayGrid = new System.Windows.Forms.CheckBox();
            chkDisplaySpeedo = new System.Windows.Forms.CheckBox();
            chkDisplayExtraGuides = new System.Windows.Forms.CheckBox();
            labelCurrentVehicle = new System.Windows.Forms.Label();
            labelCurrentTool = new System.Windows.Forms.Label();
            lblInchesCm = new System.Windows.Forms.Label();
            lblSecTotalWidth = new System.Windows.Forms.Label();
            labelToolWidthBottom = new System.Windows.Forms.Label();
            panelBottom = new System.Windows.Forms.Panel();
            lblFeetMeters = new System.Windows.Forms.Label();
            btnOK = new System.Windows.Forms.Button();
            labelUnitsBottom = new System.Windows.Forms.Label();
            panelLeftSideMenu.SuspendLayout();
            panelArduinoSubMenu.SuspendLayout();
            panelDataSourcesSubMenu.SuspendLayout();
            panelToolSubMenu.SuspendLayout();
            panelVehicleSubMenu.SuspendLayout();
            tab1.SuspendLayout();
            tabSummary.SuspendLayout();
            tabVConfig.SuspendLayout();
            tabVAntenna.SuspendLayout();
            labelAntOffset.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudAntennaOffset).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAntennaHeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAntennaPivot).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxAntenna).BeginInit();
            tabVDimensions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)HitchLengthBlindBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudTractorHitchLength).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudVehicleTrack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudWheelbase).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabTConfig.SuspendLayout();
            labelBoxAttachmentStyle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pboxConfigHarvester).BeginInit();
            tabTHitch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudTrailingHitchLength).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudDrawbarLength).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudTankHitch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picboxToolHitch).BeginInit();
            tabToolOffset.SuspendLayout();
            labelOverlapGap.SuspendLayout();
            labelToolOffset.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudOverlap).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudOffset).BeginInit();
            tabToolPivot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudTrailingToolToPivotLength).BeginInit();
            tabTSections.SuspendLayout();
            panelSymmetricSections.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudZone8To).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudZone7To).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudZone6To).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudZone4To).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudZone1To).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudZone5To).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudZone3To).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudZone2To).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCutoffSpeed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudDefaultSectionWidth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMinCoverage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSection16).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSection15).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSection14).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSection13).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSection12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSection11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSection10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSection09).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSection08).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSection07).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSection06).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSection05).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSection04).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSection03).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSection02).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSection01).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudNumberOfSections).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            tabTSwitches.SuspendLayout();
            labelGroupSteerSwitch.SuspendLayout();
            labelGroupWorkSwitch.SuspendLayout();
            tabTSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudLookAheadOff).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudTurnOffDelay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudLookAhead).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox18).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            tabDHeading.SuspendLayout();
            labelGboxDual.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudAutoSwitchDualFixSpeed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudDualReverseDistance).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudDualHeadingOffset).BeginInit();
            labelGboxSingle.SuspendLayout();
            headingGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudFixJumpDistance).BeginInit();
            tabDRoll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            tabUTurn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudYouTurnRadius).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudTurnDistanceFromBoundary).BeginInit();
            tabRelay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pboxSendRelay).BeginInit();
            tabAMachine.SuspendLayout();
            labelGroupHyd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudHydLiftLookAhead).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudLowerTime).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudRaiseTime).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudUser4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudUser3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudUser2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudUser1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxSendMachine).BeginInit();
            tabTram.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudTramWidth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            tabBtns.SuspendLayout();
            tabDisplay.SuspendLayout();
            unitsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudNumGuideLines).BeginInit();
            panelBottom.SuspendLayout();
            SuspendLayout();
            // 
            // panelLeftSideMenu
            // 
            panelLeftSideMenu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            panelLeftSideMenu.Controls.Add(btnFeatureHides);
            panelLeftSideMenu.Controls.Add(btnDisplay);
            panelLeftSideMenu.Controls.Add(btnTram);
            panelLeftSideMenu.Controls.Add(panelArduinoSubMenu);
            panelLeftSideMenu.Controls.Add(btnArduino);
            panelLeftSideMenu.Controls.Add(btnUTurn);
            panelLeftSideMenu.Controls.Add(panelDataSourcesSubMenu);
            panelLeftSideMenu.Controls.Add(btnDataSources);
            panelLeftSideMenu.Controls.Add(panelToolSubMenu);
            panelLeftSideMenu.Controls.Add(btnTool);
            panelLeftSideMenu.Controls.Add(panelVehicleSubMenu);
            panelLeftSideMenu.Controls.Add(btnVehicle);
            panelLeftSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            panelLeftSideMenu.Location = new System.Drawing.Point(4, 4);
            panelLeftSideMenu.Name = "panelLeftSideMenu";
            panelLeftSideMenu.Size = new System.Drawing.Size(120, 707);
            panelLeftSideMenu.TabIndex = 110;
            // 
            // btnFeatureHides
            // 
            btnFeatureHides.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            btnFeatureHides.Dock = System.Windows.Forms.DockStyle.Top;
            btnFeatureHides.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            btnFeatureHides.FlatAppearance.BorderSize = 0;
            btnFeatureHides.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnFeatureHides.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnFeatureHides.ForeColor = System.Drawing.SystemColors.ButtonFace;
            btnFeatureHides.Image = Properties.Resources.Con_FeatureMenu;
            btnFeatureHides.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnFeatureHides.Location = new System.Drawing.Point(0, 1596);
            btnFeatureHides.Name = "btnFeatureHides";
            btnFeatureHides.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            btnFeatureHides.Size = new System.Drawing.Size(120, 80);
            btnFeatureHides.TabIndex = 4;
            btnFeatureHides.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnFeatureHides.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnFeatureHides.UseVisualStyleBackColor = false;
            btnFeatureHides.Click += btnFeatureHides_Click;
            // 
            // btnDisplay
            // 
            btnDisplay.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            btnDisplay.Dock = System.Windows.Forms.DockStyle.Top;
            btnDisplay.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            btnDisplay.FlatAppearance.BorderSize = 0;
            btnDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnDisplay.ForeColor = System.Drawing.SystemColors.ButtonFace;
            btnDisplay.Image = Properties.Resources.Con_Display;
            btnDisplay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnDisplay.Location = new System.Drawing.Point(0, 1516);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            btnDisplay.Size = new System.Drawing.Size(120, 80);
            btnDisplay.TabIndex = 2;
            btnDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnDisplay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnDisplay.UseVisualStyleBackColor = false;
            btnDisplay.Click += btnDisplay_Click;
            // 
            // btnTram
            // 
            btnTram.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            btnTram.Dock = System.Windows.Forms.DockStyle.Top;
            btnTram.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            btnTram.FlatAppearance.BorderSize = 0;
            btnTram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnTram.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnTram.ForeColor = System.Drawing.SystemColors.ButtonFace;
            btnTram.Image = Properties.Resources.Con_TramMenu;
            btnTram.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnTram.Location = new System.Drawing.Point(0, 1436);
            btnTram.Name = "btnTram";
            btnTram.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            btnTram.Size = new System.Drawing.Size(120, 80);
            btnTram.TabIndex = 3;
            btnTram.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnTram.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnTram.UseVisualStyleBackColor = false;
            btnTram.Click += btnTram_Click;
            // 
            // panelArduinoSubMenu
            // 
            panelArduinoSubMenu.BackColor = System.Drawing.Color.RosyBrown;
            panelArduinoSubMenu.Controls.Add(btnMachineRelay);
            panelArduinoSubMenu.Controls.Add(btnMachineModule);
            panelArduinoSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            panelArduinoSubMenu.Location = new System.Drawing.Point(0, 1276);
            panelArduinoSubMenu.Name = "panelArduinoSubMenu";
            panelArduinoSubMenu.Size = new System.Drawing.Size(120, 160);
            panelArduinoSubMenu.TabIndex = 116;
            // 
            // btnMachineRelay
            // 
            btnMachineRelay.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            btnMachineRelay.Dock = System.Windows.Forms.DockStyle.Top;
            btnMachineRelay.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            btnMachineRelay.FlatAppearance.BorderSize = 0;
            btnMachineRelay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnMachineRelay.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnMachineRelay.ForeColor = System.Drawing.SystemColors.ButtonFace;
            btnMachineRelay.Image = Properties.Resources.ConS_Pins;
            btnMachineRelay.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnMachineRelay.Location = new System.Drawing.Point(0, 80);
            btnMachineRelay.Name = "btnMachineRelay";
            btnMachineRelay.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            btnMachineRelay.Size = new System.Drawing.Size(120, 80);
            btnMachineRelay.TabIndex = 3;
            btnMachineRelay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnMachineRelay.UseVisualStyleBackColor = false;
            btnMachineRelay.Click += btnMachineRelay_Click;
            // 
            // btnMachineModule
            // 
            btnMachineModule.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            btnMachineModule.Dock = System.Windows.Forms.DockStyle.Top;
            btnMachineModule.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            btnMachineModule.FlatAppearance.BorderSize = 0;
            btnMachineModule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnMachineModule.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnMachineModule.ForeColor = System.Drawing.SystemColors.ButtonFace;
            btnMachineModule.Image = Properties.Resources.ConS_ModulesMachine;
            btnMachineModule.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnMachineModule.Location = new System.Drawing.Point(0, 0);
            btnMachineModule.Name = "btnMachineModule";
            btnMachineModule.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            btnMachineModule.Size = new System.Drawing.Size(120, 80);
            btnMachineModule.TabIndex = 1;
            btnMachineModule.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnMachineModule.UseVisualStyleBackColor = false;
            btnMachineModule.Click += btnMachineModule_Click;
            // 
            // btnArduino
            // 
            btnArduino.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            btnArduino.Dock = System.Windows.Forms.DockStyle.Top;
            btnArduino.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            btnArduino.FlatAppearance.BorderSize = 0;
            btnArduino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnArduino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnArduino.ForeColor = System.Drawing.SystemColors.ButtonFace;
            btnArduino.Image = Properties.Resources.Con_ModulesMenu;
            btnArduino.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnArduino.Location = new System.Drawing.Point(0, 1196);
            btnArduino.Name = "btnArduino";
            btnArduino.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            btnArduino.Size = new System.Drawing.Size(120, 80);
            btnArduino.TabIndex = 115;
            btnArduino.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnArduino.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnArduino.UseVisualStyleBackColor = false;
            btnArduino.Click += btnArduino_Click;
            // 
            // btnUTurn
            // 
            btnUTurn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            btnUTurn.Dock = System.Windows.Forms.DockStyle.Top;
            btnUTurn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            btnUTurn.FlatAppearance.BorderSize = 0;
            btnUTurn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnUTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnUTurn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            btnUTurn.Image = Properties.Resources.Con_UTurnMenu;
            btnUTurn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnUTurn.Location = new System.Drawing.Point(0, 1121);
            btnUTurn.Name = "btnUTurn";
            btnUTurn.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            btnUTurn.Size = new System.Drawing.Size(120, 75);
            btnUTurn.TabIndex = 116;
            btnUTurn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnUTurn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnUTurn.UseVisualStyleBackColor = false;
            btnUTurn.Click += btnUTurn_Click;
            // 
            // panelDataSourcesSubMenu
            // 
            panelDataSourcesSubMenu.BackColor = System.Drawing.Color.FromArgb(35, 32, 39);
            panelDataSourcesSubMenu.Controls.Add(btnSubRoll);
            panelDataSourcesSubMenu.Controls.Add(btnSubHeading);
            panelDataSourcesSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            panelDataSourcesSubMenu.Location = new System.Drawing.Point(0, 961);
            panelDataSourcesSubMenu.Name = "panelDataSourcesSubMenu";
            panelDataSourcesSubMenu.Size = new System.Drawing.Size(120, 160);
            panelDataSourcesSubMenu.TabIndex = 7;
            // 
            // btnSubRoll
            // 
            btnSubRoll.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            btnSubRoll.Dock = System.Windows.Forms.DockStyle.Top;
            btnSubRoll.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            btnSubRoll.FlatAppearance.BorderSize = 0;
            btnSubRoll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSubRoll.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnSubRoll.ForeColor = System.Drawing.SystemColors.ButtonFace;
            btnSubRoll.Image = Properties.Resources.ConS_SourcesRoll;
            btnSubRoll.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnSubRoll.Location = new System.Drawing.Point(0, 80);
            btnSubRoll.Name = "btnSubRoll";
            btnSubRoll.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            btnSubRoll.Size = new System.Drawing.Size(120, 80);
            btnSubRoll.TabIndex = 0;
            btnSubRoll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnSubRoll.UseVisualStyleBackColor = false;
            btnSubRoll.Click += btnSubRoll_Click;
            // 
            // btnSubHeading
            // 
            btnSubHeading.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            btnSubHeading.Dock = System.Windows.Forms.DockStyle.Top;
            btnSubHeading.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            btnSubHeading.FlatAppearance.BorderSize = 0;
            btnSubHeading.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSubHeading.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnSubHeading.ForeColor = System.Drawing.SystemColors.ButtonFace;
            btnSubHeading.Image = Properties.Resources.ConS_SourcesHeading;
            btnSubHeading.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnSubHeading.Location = new System.Drawing.Point(0, 0);
            btnSubHeading.Name = "btnSubHeading";
            btnSubHeading.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            btnSubHeading.Size = new System.Drawing.Size(120, 80);
            btnSubHeading.TabIndex = 1;
            btnSubHeading.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnSubHeading.UseVisualStyleBackColor = false;
            btnSubHeading.Click += btnSubHeading_Click;
            // 
            // btnDataSources
            // 
            btnDataSources.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            btnDataSources.Dock = System.Windows.Forms.DockStyle.Top;
            btnDataSources.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            btnDataSources.FlatAppearance.BorderSize = 0;
            btnDataSources.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDataSources.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnDataSources.ForeColor = System.Drawing.SystemColors.ButtonFace;
            btnDataSources.Image = Properties.Resources.Con_SourcesMenu;
            btnDataSources.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnDataSources.Location = new System.Drawing.Point(0, 881);
            btnDataSources.Name = "btnDataSources";
            btnDataSources.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            btnDataSources.Size = new System.Drawing.Size(120, 80);
            btnDataSources.TabIndex = 114;
            btnDataSources.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnDataSources.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnDataSources.UseVisualStyleBackColor = false;
            btnDataSources.Click += btnDataSources_Click;
            // 
            // panelToolSubMenu
            // 
            panelToolSubMenu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            panelToolSubMenu.Controls.Add(btnSubSwitches);
            panelToolSubMenu.Controls.Add(btnSubToolSettings);
            panelToolSubMenu.Controls.Add(btnSubSections);
            panelToolSubMenu.Controls.Add(btnSubToolOffset);
            panelToolSubMenu.Controls.Add(btnSubPivot);
            panelToolSubMenu.Controls.Add(btnSubHitch);
            panelToolSubMenu.Controls.Add(btnSubToolType);
            panelToolSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            panelToolSubMenu.Location = new System.Drawing.Point(0, 375);
            panelToolSubMenu.Name = "panelToolSubMenu";
            panelToolSubMenu.Size = new System.Drawing.Size(120, 506);
            panelToolSubMenu.TabIndex = 4;
            // 
            // btnSubSwitches
            // 
            btnSubSwitches.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            btnSubSwitches.Dock = System.Windows.Forms.DockStyle.Top;
            btnSubSwitches.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            btnSubSwitches.FlatAppearance.BorderSize = 0;
            btnSubSwitches.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSubSwitches.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnSubSwitches.ForeColor = System.Drawing.SystemColors.ButtonFace;
            btnSubSwitches.Image = Properties.Resources.ConS_ImplementSwitch;
            btnSubSwitches.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnSubSwitches.Location = new System.Drawing.Point(0, 432);
            btnSubSwitches.Name = "btnSubSwitches";
            btnSubSwitches.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            btnSubSwitches.Size = new System.Drawing.Size(120, 72);
            btnSubSwitches.TabIndex = 1;
            btnSubSwitches.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnSubSwitches.UseVisualStyleBackColor = false;
            btnSubSwitches.Click += btnSubSwitches_Click;
            // 
            // btnSubToolSettings
            // 
            btnSubToolSettings.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            btnSubToolSettings.Dock = System.Windows.Forms.DockStyle.Top;
            btnSubToolSettings.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            btnSubToolSettings.FlatAppearance.BorderSize = 0;
            btnSubToolSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSubToolSettings.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnSubToolSettings.ForeColor = System.Drawing.SystemColors.ButtonFace;
            btnSubToolSettings.Image = Properties.Resources.ConS_ImplementSettings;
            btnSubToolSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnSubToolSettings.Location = new System.Drawing.Point(0, 360);
            btnSubToolSettings.Name = "btnSubToolSettings";
            btnSubToolSettings.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            btnSubToolSettings.Size = new System.Drawing.Size(120, 72);
            btnSubToolSettings.TabIndex = 4;
            btnSubToolSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnSubToolSettings.UseVisualStyleBackColor = false;
            btnSubToolSettings.Click += btnSubToolSettings_Click;
            // 
            // btnSubSections
            // 
            btnSubSections.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            btnSubSections.Dock = System.Windows.Forms.DockStyle.Top;
            btnSubSections.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            btnSubSections.FlatAppearance.BorderSize = 0;
            btnSubSections.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSubSections.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnSubSections.ForeColor = System.Drawing.SystemColors.ButtonFace;
            btnSubSections.Image = Properties.Resources.ConS_ImplementSection;
            btnSubSections.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnSubSections.Location = new System.Drawing.Point(0, 288);
            btnSubSections.Name = "btnSubSections";
            btnSubSections.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            btnSubSections.Size = new System.Drawing.Size(120, 72);
            btnSubSections.TabIndex = 0;
            btnSubSections.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnSubSections.UseVisualStyleBackColor = false;
            btnSubSections.Click += btnSubSections_Click;
            // 
            // btnSubToolOffset
            // 
            btnSubToolOffset.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            btnSubToolOffset.Dock = System.Windows.Forms.DockStyle.Top;
            btnSubToolOffset.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            btnSubToolOffset.FlatAppearance.BorderSize = 0;
            btnSubToolOffset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSubToolOffset.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnSubToolOffset.ForeColor = System.Drawing.SystemColors.ButtonFace;
            btnSubToolOffset.Image = Properties.Resources.ConS_ImplementOffset;
            btnSubToolOffset.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnSubToolOffset.Location = new System.Drawing.Point(0, 216);
            btnSubToolOffset.Name = "btnSubToolOffset";
            btnSubToolOffset.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            btnSubToolOffset.Size = new System.Drawing.Size(120, 72);
            btnSubToolOffset.TabIndex = 1;
            btnSubToolOffset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnSubToolOffset.UseVisualStyleBackColor = false;
            btnSubToolOffset.Click += btnSubToolOffset_Click;
            // 
            // btnSubPivot
            // 
            btnSubPivot.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            btnSubPivot.Dock = System.Windows.Forms.DockStyle.Top;
            btnSubPivot.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            btnSubPivot.FlatAppearance.BorderSize = 0;
            btnSubPivot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSubPivot.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnSubPivot.ForeColor = System.Drawing.SystemColors.ButtonFace;
            btnSubPivot.Image = Properties.Resources.ConS_ImplementPivot;
            btnSubPivot.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnSubPivot.Location = new System.Drawing.Point(0, 144);
            btnSubPivot.Name = "btnSubPivot";
            btnSubPivot.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            btnSubPivot.Size = new System.Drawing.Size(120, 72);
            btnSubPivot.TabIndex = 217;
            btnSubPivot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnSubPivot.UseVisualStyleBackColor = false;
            btnSubPivot.Click += btnSubPivot_Click;
            // 
            // btnSubHitch
            // 
            btnSubHitch.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            btnSubHitch.Dock = System.Windows.Forms.DockStyle.Top;
            btnSubHitch.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            btnSubHitch.FlatAppearance.BorderSize = 0;
            btnSubHitch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSubHitch.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnSubHitch.ForeColor = System.Drawing.SystemColors.ButtonFace;
            btnSubHitch.Image = Properties.Resources.ConS_ImplementHitch;
            btnSubHitch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnSubHitch.Location = new System.Drawing.Point(0, 72);
            btnSubHitch.Name = "btnSubHitch";
            btnSubHitch.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            btnSubHitch.Size = new System.Drawing.Size(120, 72);
            btnSubHitch.TabIndex = 5;
            btnSubHitch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnSubHitch.UseVisualStyleBackColor = false;
            btnSubHitch.Click += btnSubHitch_Click;
            // 
            // btnSubToolType
            // 
            btnSubToolType.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            btnSubToolType.Dock = System.Windows.Forms.DockStyle.Top;
            btnSubToolType.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            btnSubToolType.FlatAppearance.BorderSize = 0;
            btnSubToolType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSubToolType.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnSubToolType.ForeColor = System.Drawing.SystemColors.ButtonFace;
            btnSubToolType.Image = Properties.Resources.ConS_ImplementConfig;
            btnSubToolType.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnSubToolType.Location = new System.Drawing.Point(0, 0);
            btnSubToolType.Name = "btnSubToolType";
            btnSubToolType.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            btnSubToolType.Size = new System.Drawing.Size(120, 72);
            btnSubToolType.TabIndex = 6;
            btnSubToolType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnSubToolType.UseVisualStyleBackColor = false;
            btnSubToolType.Click += btnSubToolType_Click;
            // 
            // btnTool
            // 
            btnTool.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            btnTool.Dock = System.Windows.Forms.DockStyle.Top;
            btnTool.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            btnTool.FlatAppearance.BorderSize = 0;
            btnTool.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnTool.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnTool.ForeColor = System.Drawing.SystemColors.ButtonFace;
            btnTool.Image = Properties.Resources.Con_ImplementMenu;
            btnTool.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnTool.Location = new System.Drawing.Point(0, 295);
            btnTool.Name = "btnTool";
            btnTool.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            btnTool.Size = new System.Drawing.Size(120, 80);
            btnTool.TabIndex = 3;
            btnTool.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnTool.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnTool.UseVisualStyleBackColor = false;
            btnTool.Click += btnTool_Click;
            // 
            // panelVehicleSubMenu
            // 
            panelVehicleSubMenu.BackColor = System.Drawing.Color.FromArgb(35, 32, 39);
            panelVehicleSubMenu.Controls.Add(button1);
            panelVehicleSubMenu.Controls.Add(btnSubAntenna);
            panelVehicleSubMenu.Controls.Add(btnSubDimensions);
            panelVehicleSubMenu.Controls.Add(btnSubVehicleType);
            panelVehicleSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            panelVehicleSubMenu.Location = new System.Drawing.Point(0, 80);
            panelVehicleSubMenu.Name = "panelVehicleSubMenu";
            panelVehicleSubMenu.Size = new System.Drawing.Size(120, 215);
            panelVehicleSubMenu.TabIndex = 2;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(42, 38, 46);
            button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(42, 38, 46);
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.ForeColor = System.Drawing.Color.Silver;
            button1.Location = new System.Drawing.Point(-36, -370);
            button1.Name = "button1";
            button1.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            button1.Size = new System.Drawing.Size(231, 40);
            button1.TabIndex = 6;
            button1.Text = "Type";
            button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            // 
            // btnSubAntenna
            // 
            btnSubAntenna.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            btnSubAntenna.Dock = System.Windows.Forms.DockStyle.Top;
            btnSubAntenna.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            btnSubAntenna.FlatAppearance.BorderSize = 0;
            btnSubAntenna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSubAntenna.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnSubAntenna.ForeColor = System.Drawing.SystemColors.ButtonFace;
            btnSubAntenna.Image = Properties.Resources.ConS_ImplementAntenna;
            btnSubAntenna.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnSubAntenna.Location = new System.Drawing.Point(0, 144);
            btnSubAntenna.Name = "btnSubAntenna";
            btnSubAntenna.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            btnSubAntenna.Size = new System.Drawing.Size(120, 72);
            btnSubAntenna.TabIndex = 2;
            btnSubAntenna.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnSubAntenna.UseVisualStyleBackColor = false;
            btnSubAntenna.Click += btnSubAntenna_Click;
            // 
            // btnSubDimensions
            // 
            btnSubDimensions.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            btnSubDimensions.Dock = System.Windows.Forms.DockStyle.Top;
            btnSubDimensions.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            btnSubDimensions.FlatAppearance.BorderSize = 0;
            btnSubDimensions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSubDimensions.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnSubDimensions.ForeColor = System.Drawing.SystemColors.ButtonFace;
            btnSubDimensions.Image = Properties.Resources.ConS_ImplementHitch;
            btnSubDimensions.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnSubDimensions.Location = new System.Drawing.Point(0, 72);
            btnSubDimensions.Name = "btnSubDimensions";
            btnSubDimensions.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            btnSubDimensions.Size = new System.Drawing.Size(120, 72);
            btnSubDimensions.TabIndex = 1;
            btnSubDimensions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnSubDimensions.UseVisualStyleBackColor = false;
            btnSubDimensions.Click += btnSubDimensions_Click;
            // 
            // btnSubVehicleType
            // 
            btnSubVehicleType.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            btnSubVehicleType.Dock = System.Windows.Forms.DockStyle.Top;
            btnSubVehicleType.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            btnSubVehicleType.FlatAppearance.BorderSize = 0;
            btnSubVehicleType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSubVehicleType.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnSubVehicleType.ForeColor = System.Drawing.SystemColors.ButtonFace;
            btnSubVehicleType.Image = Properties.Resources.ConS_VehicleConfig;
            btnSubVehicleType.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnSubVehicleType.Location = new System.Drawing.Point(0, 0);
            btnSubVehicleType.Name = "btnSubVehicleType";
            btnSubVehicleType.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            btnSubVehicleType.Size = new System.Drawing.Size(120, 72);
            btnSubVehicleType.TabIndex = 0;
            btnSubVehicleType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnSubVehicleType.UseVisualStyleBackColor = false;
            btnSubVehicleType.Click += btnSubVehicleType_Click;
            // 
            // btnVehicle
            // 
            btnVehicle.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            btnVehicle.Dock = System.Windows.Forms.DockStyle.Top;
            btnVehicle.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            btnVehicle.FlatAppearance.BorderSize = 0;
            btnVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnVehicle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            btnVehicle.Image = Properties.Resources.Con_VehicleMenu;
            btnVehicle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnVehicle.Location = new System.Drawing.Point(0, 0);
            btnVehicle.Name = "btnVehicle";
            btnVehicle.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            btnVehicle.Size = new System.Drawing.Size(120, 80);
            btnVehicle.TabIndex = 113;
            btnVehicle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnVehicle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnVehicle.UseVisualStyleBackColor = false;
            btnVehicle.Click += btnVehicle_Click;
            // 
            // tab1
            // 
            tab1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            tab1.Controls.Add(tabSummary);
            tab1.Controls.Add(tabVConfig);
            tab1.Controls.Add(tabVAntenna);
            tab1.Controls.Add(tabVDimensions);
            tab1.Controls.Add(tabVGuidance);
            tab1.Controls.Add(tabTConfig);
            tab1.Controls.Add(tabTHitch);
            tab1.Controls.Add(tabToolOffset);
            tab1.Controls.Add(tabToolPivot);
            tab1.Controls.Add(tabTSections);
            tab1.Controls.Add(tabTSwitches);
            tab1.Controls.Add(tabTSettings);
            tab1.Controls.Add(tabDHeading);
            tab1.Controls.Add(tabDRoll);
            tab1.Controls.Add(tabUTurn);
            tab1.Controls.Add(tabRelay);
            tab1.Controls.Add(tabAMachine);
            tab1.Controls.Add(tabTram);
            tab1.Controls.Add(tabBtns);
            tab1.Controls.Add(tabDisplay);
            tab1.Dock = System.Windows.Forms.DockStyle.Top;
            tab1.ItemSize = new System.Drawing.Size(60, 40);
            tab1.Location = new System.Drawing.Point(124, 4);
            tab1.Name = "tab1";
            tab1.Padding = new System.Drawing.Point(0, 0);
            tab1.SelectedIndex = 0;
            tab1.Size = new System.Drawing.Size(867, 632);
            tab1.TabIndex = 0;
            // 
            // tabSummary
            // 
            tabSummary.BackColor = System.Drawing.Color.Gainsboro;
            tabSummary.Controls.Add(configSummaryControl);
            tabSummary.ForeColor = System.Drawing.Color.WhiteSmoke;
            tabSummary.Location = new System.Drawing.Point(4, 44);
            tabSummary.Name = "tabSummary";
            tabSummary.Padding = new System.Windows.Forms.Padding(3);
            tabSummary.Size = new System.Drawing.Size(859, 584);
            tabSummary.TabIndex = 0;
            tabSummary.Text = "tSum";
            tabSummary.Enter += tabSummary_Enter;
            tabSummary.Leave += tabSummary_Leave;
            // 
            // configSummaryControl
            // 
            configSummaryControl.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            configSummaryControl.BackColor = System.Drawing.Color.Gainsboro;
            configSummaryControl.Font = new System.Drawing.Font("Tahoma", 9.75F);
            configSummaryControl.ForeColor = System.Drawing.Color.WhiteSmoke;
            configSummaryControl.Location = new System.Drawing.Point(0, 0);
            configSummaryControl.Name = "configSummaryControl";
            configSummaryControl.Padding = new System.Windows.Forms.Padding(3);
            configSummaryControl.Size = new System.Drawing.Size(859, 583);
            configSummaryControl.TabIndex = 521;
            // 
            // tabVConfig
            // 
            tabVConfig.BackColor = System.Drawing.Color.WhiteSmoke;
            tabVConfig.Controls.Add(configVehicleControl);
            tabVConfig.Location = new System.Drawing.Point(4, 44);
            tabVConfig.Name = "tabVConfig";
            tabVConfig.Size = new System.Drawing.Size(859, 584);
            tabVConfig.TabIndex = 4;
            tabVConfig.Text = "vConfig";
            tabVConfig.Enter += tabVConfig_Enter;
            tabVConfig.Leave += tabVConfig_Leave;
            // 
            // configVehicleControl
            // 
            configVehicleControl.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            configVehicleControl.BackColor = System.Drawing.Color.WhiteSmoke;
            configVehicleControl.Font = new System.Drawing.Font("Tahoma", 9.75F);
            configVehicleControl.Location = new System.Drawing.Point(0, 0);
            configVehicleControl.Name = "configVehicleControl";
            configVehicleControl.Size = new System.Drawing.Size(859, 584);
            configVehicleControl.TabIndex = 536;
            // 
            // tabVAntenna
            // 
            tabVAntenna.BackColor = System.Drawing.Color.WhiteSmoke;
            tabVAntenna.Controls.Add(labelPivotDistance);
            tabVAntenna.Controls.Add(labelAntHeight);
            tabVAntenna.Controls.Add(labelCenter);
            tabVAntenna.Controls.Add(labelAntOffset);
            tabVAntenna.Controls.Add(labelLeft);
            tabVAntenna.Controls.Add(labelRight);
            tabVAntenna.Controls.Add(labelDualPositionOnRight);
            tabVAntenna.Controls.Add(label100);
            tabVAntenna.Controls.Add(label99);
            tabVAntenna.Controls.Add(label98);
            tabVAntenna.Controls.Add(nudAntennaOffset);
            tabVAntenna.Controls.Add(nudAntennaHeight);
            tabVAntenna.Controls.Add(nudAntennaPivot);
            tabVAntenna.Controls.Add(pboxAntenna);
            tabVAntenna.Location = new System.Drawing.Point(4, 44);
            tabVAntenna.Name = "tabVAntenna";
            tabVAntenna.Size = new System.Drawing.Size(859, 584);
            tabVAntenna.TabIndex = 12;
            tabVAntenna.Text = "vAnt";
            tabVAntenna.Enter += tabVAntenna_Enter;
            tabVAntenna.Leave += tabVAntenna_Leave;
            // 
            // labelPivotDistance
            // 
            labelPivotDistance.BackColor = System.Drawing.Color.Transparent;
            labelPivotDistance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelPivotDistance.ForeColor = System.Drawing.Color.Black;
            labelPivotDistance.Location = new System.Drawing.Point(126, 24);
            labelPivotDistance.Name = "labelPivotDistance";
            labelPivotDistance.Size = new System.Drawing.Size(144, 16);
            labelPivotDistance.TabIndex = 503;
            labelPivotDistance.Text = "Pivot Distance";
            labelPivotDistance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAntHeight
            // 
            labelAntHeight.BackColor = System.Drawing.Color.Transparent;
            labelAntHeight.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelAntHeight.ForeColor = System.Drawing.Color.Black;
            labelAntHeight.Location = new System.Drawing.Point(394, 263);
            labelAntHeight.Name = "labelAntHeight";
            labelAntHeight.Size = new System.Drawing.Size(142, 16);
            labelAntHeight.TabIndex = 502;
            labelAntHeight.Text = "Antenna Height";
            labelAntHeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCenter
            // 
            labelCenter.BackColor = System.Drawing.Color.Transparent;
            labelCenter.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelCenter.ForeColor = System.Drawing.Color.Black;
            labelCenter.Location = new System.Drawing.Point(510, 534);
            labelCenter.Name = "labelCenter";
            labelCenter.Size = new System.Drawing.Size(73, 16);
            labelCenter.TabIndex = 501;
            labelCenter.Text = "Center";
            labelCenter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAntOffset
            // 
            labelAntOffset.Controls.Add(rbtnAntennaCenter);
            labelAntOffset.Controls.Add(rbtnAntennaRight);
            labelAntOffset.Controls.Add(rbtnAntennaLeft);
            labelAntOffset.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelAntOffset.Location = new System.Drawing.Point(342, 417);
            labelAntOffset.Name = "labelAntOffset";
            labelAntOffset.Size = new System.Drawing.Size(405, 114);
            labelAntOffset.TabIndex = 500;
            labelAntOffset.TabStop = false;
            labelAntOffset.Text = "Antenna Offset";
            // 
            // rbtnAntennaCenter
            // 
            rbtnAntennaCenter.Appearance = System.Windows.Forms.Appearance.Button;
            rbtnAntennaCenter.BackColor = System.Drawing.Color.Transparent;
            rbtnAntennaCenter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            rbtnAntennaCenter.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            rbtnAntennaCenter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rbtnAntennaCenter.Image = Properties.Resources.AntennaNoOffset;
            rbtnAntennaCenter.Location = new System.Drawing.Point(168, 25);
            rbtnAntennaCenter.Name = "rbtnAntennaCenter";
            rbtnAntennaCenter.Size = new System.Drawing.Size(73, 81);
            rbtnAntennaCenter.TabIndex = 480;
            rbtnAntennaCenter.UseVisualStyleBackColor = false;
            rbtnAntennaCenter.Click += rbtnAntennaLeft_Click;
            // 
            // rbtnAntennaRight
            // 
            rbtnAntennaRight.Appearance = System.Windows.Forms.Appearance.Button;
            rbtnAntennaRight.BackColor = System.Drawing.Color.Transparent;
            rbtnAntennaRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            rbtnAntennaRight.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            rbtnAntennaRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rbtnAntennaRight.Image = Properties.Resources.AntennaRightOffset;
            rbtnAntennaRight.Location = new System.Drawing.Point(306, 25);
            rbtnAntennaRight.Name = "rbtnAntennaRight";
            rbtnAntennaRight.Size = new System.Drawing.Size(73, 81);
            rbtnAntennaRight.TabIndex = 479;
            rbtnAntennaRight.UseVisualStyleBackColor = false;
            rbtnAntennaRight.Click += rbtnAntennaLeft_Click;
            // 
            // rbtnAntennaLeft
            // 
            rbtnAntennaLeft.Appearance = System.Windows.Forms.Appearance.Button;
            rbtnAntennaLeft.BackColor = System.Drawing.Color.Transparent;
            rbtnAntennaLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            rbtnAntennaLeft.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            rbtnAntennaLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rbtnAntennaLeft.Image = Properties.Resources.AntennaLeftOffset;
            rbtnAntennaLeft.Location = new System.Drawing.Point(28, 25);
            rbtnAntennaLeft.Name = "rbtnAntennaLeft";
            rbtnAntennaLeft.Size = new System.Drawing.Size(73, 81);
            rbtnAntennaLeft.TabIndex = 478;
            rbtnAntennaLeft.UseVisualStyleBackColor = false;
            rbtnAntennaLeft.Click += rbtnAntennaLeft_Click;
            // 
            // labelLeft
            // 
            labelLeft.BackColor = System.Drawing.Color.Transparent;
            labelLeft.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelLeft.ForeColor = System.Drawing.Color.Black;
            labelLeft.Location = new System.Drawing.Point(370, 534);
            labelLeft.Name = "labelLeft";
            labelLeft.Size = new System.Drawing.Size(73, 16);
            labelLeft.TabIndex = 499;
            labelLeft.Text = "Left";
            labelLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRight
            // 
            labelRight.BackColor = System.Drawing.Color.Transparent;
            labelRight.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelRight.ForeColor = System.Drawing.Color.Black;
            labelRight.Location = new System.Drawing.Point(648, 534);
            labelRight.Name = "labelRight";
            labelRight.Size = new System.Drawing.Size(73, 16);
            labelRight.TabIndex = 498;
            labelRight.Text = "Right";
            labelRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDualPositionOnRight
            // 
            labelDualPositionOnRight.BackColor = System.Drawing.Color.Transparent;
            labelDualPositionOnRight.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelDualPositionOnRight.ForeColor = System.Drawing.Color.Black;
            labelDualPositionOnRight.Location = new System.Drawing.Point(370, 565);
            labelDualPositionOnRight.Name = "labelDualPositionOnRight";
            labelDualPositionOnRight.Size = new System.Drawing.Size(377, 16);
            labelDualPositionOnRight.TabIndex = 493;
            labelDualPositionOnRight.Text = "** Dual Position Antenna on Right";
            labelDualPositionOnRight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label100
            // 
            label100.AutoSize = true;
            label100.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label100.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label100.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label100.Location = new System.Drawing.Point(620, 371);
            label100.Name = "label100";
            label100.Size = new System.Drawing.Size(32, 19);
            label100.TabIndex = 483;
            label100.Text = "cm";
            label100.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label99
            // 
            label99.AutoSize = true;
            label99.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label99.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label99.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label99.Location = new System.Drawing.Point(540, 225);
            label99.Name = "label99";
            label99.Size = new System.Drawing.Size(32, 19);
            label99.TabIndex = 482;
            label99.Text = "cm";
            label99.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label98
            // 
            label98.AutoSize = true;
            label98.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label98.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label98.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label98.Location = new System.Drawing.Point(276, 62);
            label98.Name = "label98";
            label98.Size = new System.Drawing.Size(32, 19);
            label98.TabIndex = 481;
            label98.Text = "cm";
            label98.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nudAntennaOffset
            // 
            nudAntennaOffset.BackColor = System.Drawing.Color.AliceBlue;
            nudAntennaOffset.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            nudAntennaOffset.InterceptArrowKeys = false;
            nudAntennaOffset.Location = new System.Drawing.Point(474, 352);
            nudAntennaOffset.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            nudAntennaOffset.Name = "nudAntennaOffset";
            nudAntennaOffset.ReadOnly = true;
            nudAntennaOffset.Size = new System.Drawing.Size(144, 52);
            nudAntennaOffset.TabIndex = 2;
            nudAntennaOffset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudAntennaOffset.Value = new decimal(new int[] { 0, 0, 0, 0 });
            nudAntennaOffset.Click += nudAntennaOffset_Click;
            // 
            // nudAntennaHeight
            // 
            nudAntennaHeight.BackColor = System.Drawing.Color.AliceBlue;
            nudAntennaHeight.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            nudAntennaHeight.InterceptArrowKeys = false;
            nudAntennaHeight.Location = new System.Drawing.Point(392, 208);
            nudAntennaHeight.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudAntennaHeight.Name = "nudAntennaHeight";
            nudAntennaHeight.ReadOnly = true;
            nudAntennaHeight.RightToLeft = System.Windows.Forms.RightToLeft.No;
            nudAntennaHeight.Size = new System.Drawing.Size(144, 52);
            nudAntennaHeight.TabIndex = 3;
            nudAntennaHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudAntennaHeight.Value = new decimal(new int[] { 300, 0, 0, 0 });
            nudAntennaHeight.Click += nudAntennaHeight_Click;
            // 
            // nudAntennaPivot
            // 
            nudAntennaPivot.BackColor = System.Drawing.Color.AliceBlue;
            nudAntennaPivot.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            nudAntennaPivot.InterceptArrowKeys = false;
            nudAntennaPivot.Location = new System.Drawing.Point(126, 43);
            nudAntennaPivot.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            nudAntennaPivot.Minimum = new decimal(new int[] { 999, 0, 0, int.MinValue });
            nudAntennaPivot.Name = "nudAntennaPivot";
            nudAntennaPivot.ReadOnly = true;
            nudAntennaPivot.RightToLeft = System.Windows.Forms.RightToLeft.No;
            nudAntennaPivot.Size = new System.Drawing.Size(144, 52);
            nudAntennaPivot.TabIndex = 1;
            nudAntennaPivot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudAntennaPivot.Value = new decimal(new int[] { 111, 0, 0, 0 });
            nudAntennaPivot.Click += nudAntennaPivot_Click;
            // 
            // pboxAntenna
            // 
            pboxAntenna.BackgroundImage = Properties.Resources.AntennaTractor;
            pboxAntenna.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pboxAntenna.Location = new System.Drawing.Point(22, 106);
            pboxAntenna.Name = "pboxAntenna";
            pboxAntenna.Size = new System.Drawing.Size(514, 446);
            pboxAntenna.TabIndex = 48;
            pboxAntenna.TabStop = false;
            // 
            // tabVDimensions
            // 
            tabVDimensions.BackColor = System.Drawing.Color.WhiteSmoke;
            tabVDimensions.Controls.Add(HitchLengthBlindBox);
            tabVDimensions.Controls.Add(label97);
            tabVDimensions.Controls.Add(label95);
            tabVDimensions.Controls.Add(label94);
            tabVDimensions.Controls.Add(labelHitchLength);
            tabVDimensions.Controls.Add(labelTrack);
            tabVDimensions.Controls.Add(labelWheelBase2);
            tabVDimensions.Controls.Add(nudTractorHitchLength);
            tabVDimensions.Controls.Add(nudVehicleTrack);
            tabVDimensions.Controls.Add(nudWheelbase);
            tabVDimensions.Controls.Add(pictureBox1);
            tabVDimensions.Location = new System.Drawing.Point(4, 44);
            tabVDimensions.Name = "tabVDimensions";
            tabVDimensions.Size = new System.Drawing.Size(859, 584);
            tabVDimensions.TabIndex = 13;
            tabVDimensions.Text = "vDim";
            tabVDimensions.Enter += tabVDimensions_Enter;
            // 
            // HitchLengthBlindBox
            // 
            HitchLengthBlindBox.Location = new System.Drawing.Point(21, 36);
            HitchLengthBlindBox.Name = "HitchLengthBlindBox";
            HitchLengthBlindBox.Size = new System.Drawing.Size(349, 230);
            HitchLengthBlindBox.TabIndex = 484;
            HitchLengthBlindBox.TabStop = false;
            HitchLengthBlindBox.Visible = false;
            // 
            // label97
            // 
            label97.AutoSize = true;
            label97.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label97.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label97.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label97.Location = new System.Drawing.Point(750, 143);
            label97.Name = "label97";
            label97.Size = new System.Drawing.Size(32, 19);
            label97.TabIndex = 483;
            label97.Text = "cm";
            label97.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label95
            // 
            label95.AutoSize = true;
            label95.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label95.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label95.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label95.Location = new System.Drawing.Point(236, 375);
            label95.Name = "label95";
            label95.Size = new System.Drawing.Size(32, 19);
            label95.TabIndex = 481;
            label95.Text = "cm";
            label95.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label94
            // 
            label94.AutoSize = true;
            label94.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label94.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label94.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label94.Location = new System.Drawing.Point(197, 289);
            label94.Name = "label94";
            label94.Size = new System.Drawing.Size(32, 19);
            label94.TabIndex = 480;
            label94.Text = "cm";
            label94.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelHitchLength
            // 
            labelHitchLength.ForeColor = System.Drawing.SystemColors.ControlText;
            labelHitchLength.Location = new System.Drawing.Point(37, 327);
            labelHitchLength.Name = "labelHitchLength";
            labelHitchLength.Size = new System.Drawing.Size(152, 16);
            labelHitchLength.TabIndex = 479;
            labelHitchLength.Text = "Hitch Length";
            labelHitchLength.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTrack
            // 
            labelTrack.ForeColor = System.Drawing.SystemColors.ControlText;
            labelTrack.Location = new System.Drawing.Point(700, 221);
            labelTrack.Name = "labelTrack";
            labelTrack.Size = new System.Drawing.Size(133, 16);
            labelTrack.TabIndex = 476;
            labelTrack.Text = "Track";
            labelTrack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelWheelBase2
            // 
            labelWheelBase2.ForeColor = System.Drawing.SystemColors.ControlText;
            labelWheelBase2.Location = new System.Drawing.Point(179, 453);
            labelWheelBase2.Name = "labelWheelBase2";
            labelWheelBase2.Size = new System.Drawing.Size(152, 16);
            labelWheelBase2.TabIndex = 475;
            labelWheelBase2.Text = "Wheelbase";
            labelWheelBase2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudTractorHitchLength
            // 
            nudTractorHitchLength.BackColor = System.Drawing.Color.AliceBlue;
            nudTractorHitchLength.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            nudTractorHitchLength.InterceptArrowKeys = false;
            nudTractorHitchLength.Location = new System.Drawing.Point(37, 272);
            nudTractorHitchLength.Maximum = new decimal(new int[] { 4000, 0, 0, 0 });
            nudTractorHitchLength.Name = "nudTractorHitchLength";
            nudTractorHitchLength.ReadOnly = true;
            nudTractorHitchLength.RightToLeft = System.Windows.Forms.RightToLeft.No;
            nudTractorHitchLength.Size = new System.Drawing.Size(152, 52);
            nudTractorHitchLength.TabIndex = 478;
            nudTractorHitchLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudTractorHitchLength.Value = new decimal(new int[] { 301, 0, 0, 0 });
            nudTractorHitchLength.Click += nudTractorHitchLength_Click;
            // 
            // nudVehicleTrack
            // 
            nudVehicleTrack.BackColor = System.Drawing.Color.AliceBlue;
            nudVehicleTrack.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            nudVehicleTrack.InterceptArrowKeys = false;
            nudVehicleTrack.Location = new System.Drawing.Point(700, 165);
            nudVehicleTrack.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            nudVehicleTrack.Minimum = new decimal(new int[] { 20, 0, 0, 0 });
            nudVehicleTrack.Name = "nudVehicleTrack";
            nudVehicleTrack.ReadOnly = true;
            nudVehicleTrack.RightToLeft = System.Windows.Forms.RightToLeft.No;
            nudVehicleTrack.Size = new System.Drawing.Size(133, 52);
            nudVehicleTrack.TabIndex = 53;
            nudVehicleTrack.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudVehicleTrack.Value = new decimal(new int[] { 301, 0, 0, 0 });
            nudVehicleTrack.Click += nudVehicleTrack_Click;
            // 
            // nudWheelbase
            // 
            nudWheelbase.BackColor = System.Drawing.Color.AliceBlue;
            nudWheelbase.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            nudWheelbase.InterceptArrowKeys = false;
            nudWheelbase.Location = new System.Drawing.Point(179, 397);
            nudWheelbase.Maximum = new decimal(new int[] { 1999, 0, 0, 0 });
            nudWheelbase.Minimum = new decimal(new int[] { 50, 0, 0, 0 });
            nudWheelbase.Name = "nudWheelbase";
            nudWheelbase.ReadOnly = true;
            nudWheelbase.RightToLeft = System.Windows.Forms.RightToLeft.No;
            nudWheelbase.Size = new System.Drawing.Size(152, 52);
            nudWheelbase.TabIndex = 52;
            nudWheelbase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudWheelbase.Value = new decimal(new int[] { 499, 0, 0, 0 });
            nudWheelbase.Click += nudWheelbase_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.RadiusWheelBase;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new System.Drawing.Point(4, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(814, 545);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 32;
            pictureBox1.TabStop = false;
            // 
            // tabVGuidance
            // 
            tabVGuidance.BackColor = System.Drawing.Color.WhiteSmoke;
            tabVGuidance.Location = new System.Drawing.Point(4, 44);
            tabVGuidance.Name = "tabVGuidance";
            tabVGuidance.Size = new System.Drawing.Size(859, 584);
            tabVGuidance.TabIndex = 14;
            tabVGuidance.Text = "vGuid";
            tabVGuidance.Enter += tabVGuidance_Enter;
            tabVGuidance.Leave += tabVGuidance_Leave;
            // 
            // tabTConfig
            // 
            tabTConfig.BackColor = System.Drawing.Color.WhiteSmoke;
            tabTConfig.Controls.Add(labelBoxAttachmentStyle);
            tabTConfig.Location = new System.Drawing.Point(4, 44);
            tabTConfig.Name = "tabTConfig";
            tabTConfig.Size = new System.Drawing.Size(859, 584);
            tabTConfig.TabIndex = 11;
            tabTConfig.Text = "tConfig";
            tabTConfig.Enter += tabTConfig_Enter;
            tabTConfig.Leave += tabTConfig_Leave;
            // 
            // labelBoxAttachmentStyle
            // 
            labelBoxAttachmentStyle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            labelBoxAttachmentStyle.Controls.Add(pboxConfigHarvester);
            labelBoxAttachmentStyle.Controls.Add(rbtnTBT);
            labelBoxAttachmentStyle.Controls.Add(rbtnFixedRear);
            labelBoxAttachmentStyle.Controls.Add(rbtnFront);
            labelBoxAttachmentStyle.Controls.Add(rbtnTrailing);
            labelBoxAttachmentStyle.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelBoxAttachmentStyle.ForeColor = System.Drawing.Color.Black;
            labelBoxAttachmentStyle.Location = new System.Drawing.Point(45, 57);
            labelBoxAttachmentStyle.Name = "labelBoxAttachmentStyle";
            labelBoxAttachmentStyle.Size = new System.Drawing.Size(727, 484);
            labelBoxAttachmentStyle.TabIndex = 111;
            labelBoxAttachmentStyle.TabStop = false;
            labelBoxAttachmentStyle.Text = "Attachment Style";
            // 
            // pboxConfigHarvester
            // 
            pboxConfigHarvester.BackgroundImage = Properties.Resources.vehiclePageHarvester;
            pboxConfigHarvester.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pboxConfigHarvester.Location = new System.Drawing.Point(206, 123);
            pboxConfigHarvester.Name = "pboxConfigHarvester";
            pboxConfigHarvester.Size = new System.Drawing.Size(305, 206);
            pboxConfigHarvester.TabIndex = 113;
            pboxConfigHarvester.TabStop = false;
            // 
            // rbtnTBT
            // 
            rbtnTBT.Appearance = System.Windows.Forms.Appearance.Button;
            rbtnTBT.BackColor = System.Drawing.Color.Transparent;
            rbtnTBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            rbtnTBT.FlatAppearance.BorderSize = 0;
            rbtnTBT.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            rbtnTBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rbtnTBT.Image = Properties.Resources.ToolChkTBT;
            rbtnTBT.Location = new System.Drawing.Point(394, 48);
            rbtnTBT.Name = "rbtnTBT";
            rbtnTBT.Size = new System.Drawing.Size(309, 152);
            rbtnTBT.TabIndex = 112;
            rbtnTBT.UseVisualStyleBackColor = false;
            // 
            // rbtnFixedRear
            // 
            rbtnFixedRear.Appearance = System.Windows.Forms.Appearance.Button;
            rbtnFixedRear.BackColor = System.Drawing.Color.Transparent;
            rbtnFixedRear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            rbtnFixedRear.FlatAppearance.BorderSize = 0;
            rbtnFixedRear.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            rbtnFixedRear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rbtnFixedRear.Image = Properties.Resources.ToolChkRear;
            rbtnFixedRear.Location = new System.Drawing.Point(16, 48);
            rbtnFixedRear.Name = "rbtnFixedRear";
            rbtnFixedRear.Size = new System.Drawing.Size(309, 152);
            rbtnFixedRear.TabIndex = 111;
            rbtnFixedRear.UseVisualStyleBackColor = false;
            // 
            // rbtnFront
            // 
            rbtnFront.Appearance = System.Windows.Forms.Appearance.Button;
            rbtnFront.BackColor = System.Drawing.Color.Transparent;
            rbtnFront.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            rbtnFront.FlatAppearance.BorderSize = 0;
            rbtnFront.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            rbtnFront.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rbtnFront.Image = Properties.Resources.ToolChkFront;
            rbtnFront.Location = new System.Drawing.Point(16, 290);
            rbtnFront.Name = "rbtnFront";
            rbtnFront.Size = new System.Drawing.Size(309, 152);
            rbtnFront.TabIndex = 110;
            rbtnFront.UseVisualStyleBackColor = false;
            // 
            // rbtnTrailing
            // 
            rbtnTrailing.Appearance = System.Windows.Forms.Appearance.Button;
            rbtnTrailing.BackColor = System.Drawing.Color.Transparent;
            rbtnTrailing.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            rbtnTrailing.Checked = true;
            rbtnTrailing.FlatAppearance.BorderSize = 0;
            rbtnTrailing.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            rbtnTrailing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rbtnTrailing.Image = Properties.Resources.ToolChkTrailing;
            rbtnTrailing.Location = new System.Drawing.Point(394, 290);
            rbtnTrailing.Name = "rbtnTrailing";
            rbtnTrailing.Size = new System.Drawing.Size(309, 152);
            rbtnTrailing.TabIndex = 109;
            rbtnTrailing.TabStop = true;
            rbtnTrailing.UseVisualStyleBackColor = false;
            // 
            // tabTHitch
            // 
            tabTHitch.BackColor = System.Drawing.Color.WhiteSmoke;
            tabTHitch.Controls.Add(label112);
            tabTHitch.Controls.Add(labelTractorUnits);
            tabTHitch.Controls.Add(nudTrailingHitchLength);
            tabTHitch.Controls.Add(nudDrawbarLength);
            tabTHitch.Controls.Add(nudTankHitch);
            tabTHitch.Controls.Add(picboxToolHitch);
            tabTHitch.Location = new System.Drawing.Point(4, 44);
            tabTHitch.Name = "tabTHitch";
            tabTHitch.Size = new System.Drawing.Size(859, 584);
            tabTHitch.TabIndex = 5;
            tabTHitch.Text = "tHitch";
            tabTHitch.Enter += tabTHitch_Enter;
            tabTHitch.Leave += tabTHitch_Leave;
            // 
            // label112
            // 
            label112.AutoSize = true;
            label112.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label112.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label112.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label112.Location = new System.Drawing.Point(381, 495);
            label112.Name = "label112";
            label112.Size = new System.Drawing.Size(32, 19);
            label112.TabIndex = 484;
            label112.Text = "cm";
            label112.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTractorUnits
            // 
            labelTractorUnits.AutoSize = true;
            labelTractorUnits.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelTractorUnits.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            labelTractorUnits.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            labelTractorUnits.Location = new System.Drawing.Point(368, 476);
            labelTractorUnits.Name = "labelTractorUnits";
            labelTractorUnits.Size = new System.Drawing.Size(57, 19);
            labelTractorUnits.TabIndex = 485;
            labelTractorUnits.Text = "Units:";
            labelTractorUnits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudTrailingHitchLength
            // 
            nudTrailingHitchLength.BackColor = System.Drawing.Color.AliceBlue;
            nudTrailingHitchLength.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            nudTrailingHitchLength.InterceptArrowKeys = false;
            nudTrailingHitchLength.Location = new System.Drawing.Point(456, 407);
            nudTrailingHitchLength.Maximum = new decimal(new int[] { 3000, 0, 0, 0 });
            nudTrailingHitchLength.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            nudTrailingHitchLength.Name = "nudTrailingHitchLength";
            nudTrailingHitchLength.ReadOnly = true;
            nudTrailingHitchLength.Size = new System.Drawing.Size(124, 52);
            nudTrailingHitchLength.TabIndex = 3;
            nudTrailingHitchLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudTrailingHitchLength.Value = new decimal(new int[] { 520, 0, 0, 0 });
            nudTrailingHitchLength.Click += nudTrailingHitchLength_Click;
            // 
            // nudDrawbarLength
            // 
            nudDrawbarLength.BackColor = System.Drawing.Color.AliceBlue;
            nudDrawbarLength.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            nudDrawbarLength.InterceptArrowKeys = false;
            nudDrawbarLength.Location = new System.Drawing.Point(401, 407);
            nudDrawbarLength.Maximum = new decimal(new int[] { 3000, 0, 0, 0 });
            nudDrawbarLength.Name = "nudDrawbarLength";
            nudDrawbarLength.ReadOnly = true;
            nudDrawbarLength.RightToLeft = System.Windows.Forms.RightToLeft.No;
            nudDrawbarLength.Size = new System.Drawing.Size(124, 52);
            nudDrawbarLength.TabIndex = 1;
            nudDrawbarLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudDrawbarLength.Value = new decimal(new int[] { 51, 0, 0, 0 });
            nudDrawbarLength.Click += nudDrawbarLength_Click;
            // 
            // nudTankHitch
            // 
            nudTankHitch.BackColor = System.Drawing.Color.AliceBlue;
            nudTankHitch.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            nudTankHitch.InterceptArrowKeys = false;
            nudTankHitch.Location = new System.Drawing.Point(643, 407);
            nudTankHitch.Maximum = new decimal(new int[] { 3000, 0, 0, 0 });
            nudTankHitch.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            nudTankHitch.Name = "nudTankHitch";
            nudTankHitch.ReadOnly = true;
            nudTankHitch.Size = new System.Drawing.Size(124, 52);
            nudTankHitch.TabIndex = 2;
            nudTankHitch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudTankHitch.Value = new decimal(new int[] { 326, 0, 0, 0 });
            nudTankHitch.Click += nudTankHitch_Click;
            // 
            // picboxToolHitch
            // 
            picboxToolHitch.BackgroundImage = Properties.Resources.ToolHitchPageFront;
            picboxToolHitch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            picboxToolHitch.Location = new System.Drawing.Point(13, 12);
            picboxToolHitch.Name = "picboxToolHitch";
            picboxToolHitch.Size = new System.Drawing.Size(838, 407);
            picboxToolHitch.TabIndex = 0;
            picboxToolHitch.TabStop = false;
            // 
            // tabToolOffset
            // 
            tabToolOffset.BackColor = System.Drawing.Color.WhiteSmoke;
            tabToolOffset.Controls.Add(btnZeroOverlap);
            tabToolOffset.Controls.Add(btnZeroToolOffset);
            tabToolOffset.Controls.Add(label176);
            tabToolOffset.Controls.Add(label175);
            tabToolOffset.Controls.Add(labelOverlapGap);
            tabToolOffset.Controls.Add(labelToolOffset);
            tabToolOffset.Controls.Add(nudOverlap);
            tabToolOffset.Controls.Add(nudOffset);
            tabToolOffset.Location = new System.Drawing.Point(4, 44);
            tabToolOffset.Name = "tabToolOffset";
            tabToolOffset.Size = new System.Drawing.Size(859, 584);
            tabToolOffset.TabIndex = 26;
            tabToolOffset.Text = "tOffs";
            tabToolOffset.Enter += tabToolOffset_Enter;
            tabToolOffset.Leave += tabToolOffset_Leave;
            // 
            // btnZeroOverlap
            // 
            btnZeroOverlap.BackColor = System.Drawing.Color.Transparent;
            btnZeroOverlap.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            btnZeroOverlap.FlatAppearance.BorderSize = 0;
            btnZeroOverlap.FlatAppearance.CheckedBackColor = System.Drawing.Color.Teal;
            btnZeroOverlap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnZeroOverlap.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnZeroOverlap.ForeColor = System.Drawing.Color.Black;
            btnZeroOverlap.Image = Properties.Resources.SteerZero;
            btnZeroOverlap.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnZeroOverlap.Location = new System.Drawing.Point(513, 109);
            btnZeroOverlap.Name = "btnZeroOverlap";
            btnZeroOverlap.Size = new System.Drawing.Size(114, 52);
            btnZeroOverlap.TabIndex = 489;
            btnZeroOverlap.UseVisualStyleBackColor = false;
            btnZeroOverlap.Click += btnZeroOverlap_Click;
            // 
            // btnZeroToolOffset
            // 
            btnZeroToolOffset.BackColor = System.Drawing.Color.Transparent;
            btnZeroToolOffset.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            btnZeroToolOffset.FlatAppearance.BorderSize = 0;
            btnZeroToolOffset.FlatAppearance.CheckedBackColor = System.Drawing.Color.Teal;
            btnZeroToolOffset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnZeroToolOffset.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnZeroToolOffset.ForeColor = System.Drawing.Color.Black;
            btnZeroToolOffset.Image = Properties.Resources.SteerZero;
            btnZeroToolOffset.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnZeroToolOffset.Location = new System.Drawing.Point(93, 109);
            btnZeroToolOffset.Name = "btnZeroToolOffset";
            btnZeroToolOffset.Size = new System.Drawing.Size(114, 52);
            btnZeroToolOffset.TabIndex = 488;
            btnZeroToolOffset.UseVisualStyleBackColor = false;
            btnZeroToolOffset.Click += btnZeroToolOffset_Click;
            // 
            // label176
            // 
            label176.AutoSize = true;
            label176.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label176.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label176.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label176.Location = new System.Drawing.Point(774, 125);
            label176.Name = "label176";
            label176.Size = new System.Drawing.Size(32, 19);
            label176.TabIndex = 486;
            label176.Text = "cm";
            label176.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label175
            // 
            label175.AutoSize = true;
            label175.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label175.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label175.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label175.Location = new System.Drawing.Point(350, 124);
            label175.Name = "label175";
            label175.Size = new System.Drawing.Size(32, 19);
            label175.TabIndex = 485;
            label175.Text = "cm";
            label175.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelOverlapGap
            // 
            labelOverlapGap.Controls.Add(labelOverlap2);
            labelOverlapGap.Controls.Add(labelGap);
            labelOverlapGap.Controls.Add(rbtnToolOverlap);
            labelOverlapGap.Controls.Add(rbtnToolGap);
            labelOverlapGap.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelOverlapGap.Location = new System.Drawing.Point(442, 201);
            labelOverlapGap.Name = "labelOverlapGap";
            labelOverlapGap.Size = new System.Drawing.Size(396, 290);
            labelOverlapGap.TabIndex = 481;
            labelOverlapGap.TabStop = false;
            labelOverlapGap.Text = "Overlap / Gap";
            // 
            // labelOverlap2
            // 
            labelOverlap2.BackColor = System.Drawing.Color.Transparent;
            labelOverlap2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelOverlap2.ForeColor = System.Drawing.Color.Black;
            labelOverlap2.Location = new System.Drawing.Point(23, 256);
            labelOverlap2.Name = "labelOverlap2";
            labelOverlap2.Size = new System.Drawing.Size(166, 16);
            labelOverlap2.TabIndex = 481;
            labelOverlap2.Text = "Overlap";
            labelOverlap2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelGap
            // 
            labelGap.BackColor = System.Drawing.Color.Transparent;
            labelGap.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelGap.ForeColor = System.Drawing.Color.Black;
            labelGap.Location = new System.Drawing.Point(214, 256);
            labelGap.Name = "labelGap";
            labelGap.Size = new System.Drawing.Size(166, 16);
            labelGap.TabIndex = 480;
            labelGap.Text = "Gap";
            labelGap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rbtnToolOverlap
            // 
            rbtnToolOverlap.Appearance = System.Windows.Forms.Appearance.Button;
            rbtnToolOverlap.BackColor = System.Drawing.Color.Transparent;
            rbtnToolOverlap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            rbtnToolOverlap.Checked = true;
            rbtnToolOverlap.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            rbtnToolOverlap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rbtnToolOverlap.Image = Properties.Resources.ToolOverlap;
            rbtnToolOverlap.Location = new System.Drawing.Point(23, 35);
            rbtnToolOverlap.Name = "rbtnToolOverlap";
            rbtnToolOverlap.Size = new System.Drawing.Size(166, 218);
            rbtnToolOverlap.TabIndex = 479;
            rbtnToolOverlap.TabStop = true;
            rbtnToolOverlap.UseVisualStyleBackColor = false;
            rbtnToolOverlap.Click += rbtnToolOverlap_Click;
            // 
            // rbtnToolGap
            // 
            rbtnToolGap.Appearance = System.Windows.Forms.Appearance.Button;
            rbtnToolGap.BackColor = System.Drawing.Color.Transparent;
            rbtnToolGap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            rbtnToolGap.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            rbtnToolGap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rbtnToolGap.Image = Properties.Resources.ToolGap;
            rbtnToolGap.Location = new System.Drawing.Point(214, 35);
            rbtnToolGap.Name = "rbtnToolGap";
            rbtnToolGap.Size = new System.Drawing.Size(166, 218);
            rbtnToolGap.TabIndex = 478;
            rbtnToolGap.UseVisualStyleBackColor = false;
            rbtnToolGap.Click += rbtnToolOverlap_Click;
            // 
            // labelToolOffset
            // 
            labelToolOffset.Controls.Add(labelToolRight);
            labelToolOffset.Controls.Add(rbtnLeftNegative);
            labelToolOffset.Controls.Add(rbtnToolRightPositive);
            labelToolOffset.Controls.Add(labelToolLeft);
            labelToolOffset.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelToolOffset.Location = new System.Drawing.Point(28, 201);
            labelToolOffset.Name = "labelToolOffset";
            labelToolOffset.Size = new System.Drawing.Size(389, 290);
            labelToolOffset.TabIndex = 480;
            labelToolOffset.TabStop = false;
            labelToolOffset.Text = "Tool Offset Direction";
            // 
            // labelToolRight
            // 
            labelToolRight.BackColor = System.Drawing.Color.Transparent;
            labelToolRight.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelToolRight.ForeColor = System.Drawing.Color.Black;
            labelToolRight.Location = new System.Drawing.Point(205, 256);
            labelToolRight.Name = "labelToolRight";
            labelToolRight.Size = new System.Drawing.Size(166, 16);
            labelToolRight.TabIndex = 480;
            labelToolRight.Text = "Tool Right";
            labelToolRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rbtnLeftNegative
            // 
            rbtnLeftNegative.Appearance = System.Windows.Forms.Appearance.Button;
            rbtnLeftNegative.BackColor = System.Drawing.Color.Transparent;
            rbtnLeftNegative.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            rbtnLeftNegative.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            rbtnLeftNegative.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rbtnLeftNegative.Image = Properties.Resources.ToolOffsetNegativeLeft;
            rbtnLeftNegative.Location = new System.Drawing.Point(17, 35);
            rbtnLeftNegative.Name = "rbtnLeftNegative";
            rbtnLeftNegative.Size = new System.Drawing.Size(166, 218);
            rbtnLeftNegative.TabIndex = 479;
            rbtnLeftNegative.UseVisualStyleBackColor = false;
            rbtnLeftNegative.Click += rbtnToolRightPositive_Click;
            // 
            // rbtnToolRightPositive
            // 
            rbtnToolRightPositive.Appearance = System.Windows.Forms.Appearance.Button;
            rbtnToolRightPositive.BackColor = System.Drawing.Color.Transparent;
            rbtnToolRightPositive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            rbtnToolRightPositive.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            rbtnToolRightPositive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rbtnToolRightPositive.Image = Properties.Resources.ToolOffsetPositiveRight;
            rbtnToolRightPositive.Location = new System.Drawing.Point(205, 35);
            rbtnToolRightPositive.Name = "rbtnToolRightPositive";
            rbtnToolRightPositive.Size = new System.Drawing.Size(166, 218);
            rbtnToolRightPositive.TabIndex = 478;
            rbtnToolRightPositive.UseVisualStyleBackColor = false;
            rbtnToolRightPositive.Click += rbtnToolRightPositive_Click;
            // 
            // labelToolLeft
            // 
            labelToolLeft.BackColor = System.Drawing.Color.Transparent;
            labelToolLeft.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelToolLeft.ForeColor = System.Drawing.Color.Black;
            labelToolLeft.Location = new System.Drawing.Point(17, 256);
            labelToolLeft.Name = "labelToolLeft";
            labelToolLeft.Size = new System.Drawing.Size(166, 16);
            labelToolLeft.TabIndex = 476;
            labelToolLeft.Text = "Tool Left";
            labelToolLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudOverlap
            // 
            nudOverlap.BackColor = System.Drawing.Color.AliceBlue;
            nudOverlap.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            nudOverlap.InterceptArrowKeys = false;
            nudOverlap.Location = new System.Drawing.Point(656, 109);
            nudOverlap.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudOverlap.Name = "nudOverlap";
            nudOverlap.ReadOnly = true;
            nudOverlap.Size = new System.Drawing.Size(114, 52);
            nudOverlap.TabIndex = 116;
            nudOverlap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudOverlap.Value = new decimal(new int[] { 8, 0, 0, 0 });
            nudOverlap.Click += nudOverlap_Click;
            // 
            // nudOffset
            // 
            nudOffset.BackColor = System.Drawing.Color.AliceBlue;
            nudOffset.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            nudOffset.InterceptArrowKeys = false;
            nudOffset.Location = new System.Drawing.Point(233, 109);
            nudOffset.Maximum = new decimal(new int[] { 2500, 0, 0, 0 });
            nudOffset.Name = "nudOffset";
            nudOffset.ReadOnly = true;
            nudOffset.Size = new System.Drawing.Size(114, 52);
            nudOffset.TabIndex = 115;
            nudOffset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudOffset.Value = new decimal(new int[] { 25, 0, 0, 0 });
            nudOffset.Click += nudOffset_Click;
            // 
            // tabToolPivot
            // 
            tabToolPivot.BackColor = System.Drawing.Color.WhiteSmoke;
            tabToolPivot.Controls.Add(btnPivotOffsetZero);
            tabToolPivot.Controls.Add(LabelCm);
            tabToolPivot.Controls.Add(nudTrailingToolToPivotLength);
            tabToolPivot.Controls.Add(rbtnPivotBehindPos);
            tabToolPivot.Controls.Add(rbtnPivotAheadNeg);
            tabToolPivot.Location = new System.Drawing.Point(4, 44);
            tabToolPivot.Name = "tabToolPivot";
            tabToolPivot.Padding = new System.Windows.Forms.Padding(3);
            tabToolPivot.Size = new System.Drawing.Size(859, 584);
            tabToolPivot.TabIndex = 27;
            tabToolPivot.Text = "tPivot";
            tabToolPivot.Enter += tabToolPivot_Enter;
            tabToolPivot.Leave += tabToolPivot_Leave;
            // 
            // btnPivotOffsetZero
            // 
            btnPivotOffsetZero.BackColor = System.Drawing.Color.Transparent;
            btnPivotOffsetZero.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            btnPivotOffsetZero.FlatAppearance.BorderSize = 0;
            btnPivotOffsetZero.FlatAppearance.CheckedBackColor = System.Drawing.Color.Teal;
            btnPivotOffsetZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPivotOffsetZero.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnPivotOffsetZero.ForeColor = System.Drawing.Color.Black;
            btnPivotOffsetZero.Image = Properties.Resources.SteerZero;
            btnPivotOffsetZero.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnPivotOffsetZero.Location = new System.Drawing.Point(368, 410);
            btnPivotOffsetZero.Name = "btnPivotOffsetZero";
            btnPivotOffsetZero.Size = new System.Drawing.Size(114, 52);
            btnPivotOffsetZero.TabIndex = 489;
            btnPivotOffsetZero.UseVisualStyleBackColor = false;
            btnPivotOffsetZero.Click += btnPivotOffsetZero_Click;
            // 
            // LabelCm
            // 
            LabelCm.AutoSize = true;
            LabelCm.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            LabelCm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            LabelCm.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            LabelCm.Location = new System.Drawing.Point(405, 315);
            LabelCm.Name = "LabelCm";
            LabelCm.Size = new System.Drawing.Size(32, 19);
            LabelCm.TabIndex = 485;
            LabelCm.Text = "cm";
            LabelCm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nudTrailingToolToPivotLength
            // 
            nudTrailingToolToPivotLength.BackColor = System.Drawing.Color.AliceBlue;
            nudTrailingToolToPivotLength.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            nudTrailingToolToPivotLength.InterceptArrowKeys = false;
            nudTrailingToolToPivotLength.Location = new System.Drawing.Point(320, 337);
            nudTrailingToolToPivotLength.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            nudTrailingToolToPivotLength.Name = "nudTrailingToolToPivotLength";
            nudTrailingToolToPivotLength.ReadOnly = true;
            nudTrailingToolToPivotLength.RightToLeft = System.Windows.Forms.RightToLeft.No;
            nudTrailingToolToPivotLength.Size = new System.Drawing.Size(205, 52);
            nudTrailingToolToPivotLength.TabIndex = 214;
            nudTrailingToolToPivotLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudTrailingToolToPivotLength.Value = new decimal(new int[] { 51, 0, 0, 0 });
            nudTrailingToolToPivotLength.Click += nudTrailingToolToPivotLength_Click;
            // 
            // rbtnPivotBehindPos
            // 
            rbtnPivotBehindPos.Appearance = System.Windows.Forms.Appearance.Button;
            rbtnPivotBehindPos.BackColor = System.Drawing.Color.Transparent;
            rbtnPivotBehindPos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            rbtnPivotBehindPos.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            rbtnPivotBehindPos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rbtnPivotBehindPos.Image = Properties.Resources.ToolHitchPivotOffsetNeg;
            rbtnPivotBehindPos.Location = new System.Drawing.Point(577, 162);
            rbtnPivotBehindPos.Name = "rbtnPivotBehindPos";
            rbtnPivotBehindPos.Size = new System.Drawing.Size(201, 300);
            rbtnPivotBehindPos.TabIndex = 216;
            rbtnPivotBehindPos.UseVisualStyleBackColor = false;
            rbtnPivotBehindPos.Click += rbtnPivotBehindPos_Click;
            // 
            // rbtnPivotAheadNeg
            // 
            rbtnPivotAheadNeg.Appearance = System.Windows.Forms.Appearance.Button;
            rbtnPivotAheadNeg.BackColor = System.Drawing.Color.Transparent;
            rbtnPivotAheadNeg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            rbtnPivotAheadNeg.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            rbtnPivotAheadNeg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rbtnPivotAheadNeg.Image = Properties.Resources.ToolHitchPivotOffsetPos;
            rbtnPivotAheadNeg.Location = new System.Drawing.Point(72, 162);
            rbtnPivotAheadNeg.Name = "rbtnPivotAheadNeg";
            rbtnPivotAheadNeg.Size = new System.Drawing.Size(201, 300);
            rbtnPivotAheadNeg.TabIndex = 215;
            rbtnPivotAheadNeg.UseVisualStyleBackColor = false;
            rbtnPivotAheadNeg.Click += rbtnPivotBehindPos_Click;
            // 
            // tabTSections
            // 
            tabTSections.BackColor = System.Drawing.Color.WhiteSmoke;
            tabTSections.Controls.Add(panelSymmetricSections);
            tabTSections.Controls.Add(label178);
            tabTSections.Controls.Add(labelBoundary);
            tabTSections.Controls.Add(lblTurnOffBelowUnits);
            tabTSections.Controls.Add(labelChoose);
            tabTSections.Controls.Add(lblInchCm2);
            tabTSections.Controls.Add(labelSectionWidth);
            tabTSections.Controls.Add(cboxNumSections);
            tabTSections.Controls.Add(lblVehicleToolWidth);
            tabTSections.Controls.Add(labelCoverage);
            tabTSections.Controls.Add(labelZonesBox);
            tabTSections.Controls.Add(labelNumOfSections);
            tabTSections.Controls.Add(cboxNumberOfZones);
            tabTSections.Controls.Add(label1);
            tabTSections.Controls.Add(label4);
            tabTSections.Controls.Add(label19);
            tabTSections.Controls.Add(label30);
            tabTSections.Controls.Add(label32);
            tabTSections.Controls.Add(label34);
            tabTSections.Controls.Add(label35);
            tabTSections.Controls.Add(label40);
            tabTSections.Controls.Add(label39);
            tabTSections.Controls.Add(label38);
            tabTSections.Controls.Add(label37);
            tabTSections.Controls.Add(label41);
            tabTSections.Controls.Add(label45);
            tabTSections.Controls.Add(label46);
            tabTSections.Controls.Add(label47);
            tabTSections.Controls.Add(label48);
            tabTSections.Controls.Add(nudCutoffSpeed);
            tabTSections.Controls.Add(nudDefaultSectionWidth);
            tabTSections.Controls.Add(nudMinCoverage);
            tabTSections.Controls.Add(nudSection16);
            tabTSections.Controls.Add(nudSection15);
            tabTSections.Controls.Add(nudSection14);
            tabTSections.Controls.Add(nudSection13);
            tabTSections.Controls.Add(nudSection12);
            tabTSections.Controls.Add(nudSection11);
            tabTSections.Controls.Add(nudSection10);
            tabTSections.Controls.Add(nudSection09);
            tabTSections.Controls.Add(nudSection08);
            tabTSections.Controls.Add(nudSection07);
            tabTSections.Controls.Add(nudSection06);
            tabTSections.Controls.Add(nudSection05);
            tabTSections.Controls.Add(nudSection04);
            tabTSections.Controls.Add(nudSection03);
            tabTSections.Controls.Add(nudSection02);
            tabTSections.Controls.Add(nudSection01);
            tabTSections.Controls.Add(nudNumberOfSections);
            tabTSections.Controls.Add(cboxSectionBoundaryControl);
            tabTSections.Controls.Add(pictureBox11);
            tabTSections.Controls.Add(cboxIsUnique);
            tabTSections.ForeColor = System.Drawing.Color.Black;
            tabTSections.Location = new System.Drawing.Point(4, 44);
            tabTSections.Name = "tabTSections";
            tabTSections.Size = new System.Drawing.Size(859, 584);
            tabTSections.TabIndex = 7;
            tabTSections.Text = "tSect";
            tabTSections.Enter += tabTSections_Enter;
            tabTSections.Leave += tabTSections_Leave;
            // 
            // panelSymmetricSections
            // 
            panelSymmetricSections.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            panelSymmetricSections.Controls.Add(nudZone8To);
            panelSymmetricSections.Controls.Add(lblZoneStart8);
            panelSymmetricSections.Controls.Add(labelZone8);
            panelSymmetricSections.Controls.Add(label158);
            panelSymmetricSections.Controls.Add(nudZone7To);
            panelSymmetricSections.Controls.Add(lblZoneStart7);
            panelSymmetricSections.Controls.Add(labelZone7);
            panelSymmetricSections.Controls.Add(label155);
            panelSymmetricSections.Controls.Add(nudZone6To);
            panelSymmetricSections.Controls.Add(nudZone4To);
            panelSymmetricSections.Controls.Add(nudZone1To);
            panelSymmetricSections.Controls.Add(nudZone5To);
            panelSymmetricSections.Controls.Add(nudZone3To);
            panelSymmetricSections.Controls.Add(nudZone2To);
            panelSymmetricSections.Controls.Add(lblZoneStart6);
            panelSymmetricSections.Controls.Add(lblZoneStart5);
            panelSymmetricSections.Controls.Add(lblZoneStart4);
            panelSymmetricSections.Controls.Add(lblZoneStart3);
            panelSymmetricSections.Controls.Add(lblZoneStart2);
            panelSymmetricSections.Controls.Add(lblZoneStart1);
            panelSymmetricSections.Controls.Add(labelZone1);
            panelSymmetricSections.Controls.Add(labelZone2);
            panelSymmetricSections.Controls.Add(labelZone6);
            panelSymmetricSections.Controls.Add(labelZone3);
            panelSymmetricSections.Controls.Add(labelZone5);
            panelSymmetricSections.Controls.Add(labelZone4);
            panelSymmetricSections.Controls.Add(label152);
            panelSymmetricSections.Controls.Add(label117);
            panelSymmetricSections.Controls.Add(label116);
            panelSymmetricSections.Controls.Add(label104);
            panelSymmetricSections.Controls.Add(label7);
            panelSymmetricSections.Controls.Add(label6);
            panelSymmetricSections.Location = new System.Drawing.Point(6, 20);
            panelSymmetricSections.Name = "panelSymmetricSections";
            panelSymmetricSections.Size = new System.Drawing.Size(842, 274);
            panelSymmetricSections.TabIndex = 495;
            // 
            // nudZone8To
            // 
            nudZone8To.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            nudZone8To.BackColor = System.Drawing.Color.AliceBlue;
            nudZone8To.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            nudZone8To.InterceptArrowKeys = false;
            nudZone8To.Location = new System.Drawing.Point(751, 186);
            nudZone8To.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            nudZone8To.Name = "nudZone8To";
            nudZone8To.ReadOnly = true;
            nudZone8To.Size = new System.Drawing.Size(87, 43);
            nudZone8To.TabIndex = 509;
            nudZone8To.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudZone8To.Value = new decimal(new int[] { 98, 0, 0, 0 });
            nudZone8To.Click += nudZone8To_Click;
            // 
            // lblZoneStart8
            // 
            lblZoneStart8.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblZoneStart8.BackColor = System.Drawing.Color.Transparent;
            lblZoneStart8.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblZoneStart8.ForeColor = System.Drawing.Color.Black;
            lblZoneStart8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            lblZoneStart8.Location = new System.Drawing.Point(670, 186);
            lblZoneStart8.Name = "lblZoneStart8";
            lblZoneStart8.Size = new System.Drawing.Size(55, 42);
            lblZoneStart8.TabIndex = 511;
            lblZoneStart8.Text = "99 ->";
            lblZoneStart8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelZone8
            // 
            labelZone8.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelZone8.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelZone8.ForeColor = System.Drawing.Color.Black;
            labelZone8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            labelZone8.Location = new System.Drawing.Point(682, 151);
            labelZone8.Name = "labelZone8";
            labelZone8.Size = new System.Drawing.Size(156, 29);
            labelZone8.TabIndex = 510;
            labelZone8.Text = "Zone 8";
            labelZone8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label158
            // 
            label158.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label158.AutoSize = true;
            label158.BackColor = System.Drawing.Color.Transparent;
            label158.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label158.ForeColor = System.Drawing.Color.Black;
            label158.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label158.Location = new System.Drawing.Point(721, 194);
            label158.Name = "label158";
            label158.Size = new System.Drawing.Size(31, 23);
            label158.TabIndex = 512;
            label158.Text = "->";
            // 
            // nudZone7To
            // 
            nudZone7To.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            nudZone7To.BackColor = System.Drawing.Color.AliceBlue;
            nudZone7To.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            nudZone7To.InterceptArrowKeys = false;
            nudZone7To.Location = new System.Drawing.Point(526, 189);
            nudZone7To.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            nudZone7To.Name = "nudZone7To";
            nudZone7To.ReadOnly = true;
            nudZone7To.Size = new System.Drawing.Size(87, 43);
            nudZone7To.TabIndex = 505;
            nudZone7To.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudZone7To.Value = new decimal(new int[] { 98, 0, 0, 0 });
            nudZone7To.Click += nudZone7To_Click;
            // 
            // lblZoneStart7
            // 
            lblZoneStart7.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblZoneStart7.BackColor = System.Drawing.Color.Transparent;
            lblZoneStart7.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblZoneStart7.ForeColor = System.Drawing.Color.Black;
            lblZoneStart7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            lblZoneStart7.Location = new System.Drawing.Point(445, 189);
            lblZoneStart7.Name = "lblZoneStart7";
            lblZoneStart7.Size = new System.Drawing.Size(55, 42);
            lblZoneStart7.TabIndex = 507;
            lblZoneStart7.Text = "99 ->";
            lblZoneStart7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelZone7
            // 
            labelZone7.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelZone7.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelZone7.ForeColor = System.Drawing.Color.Black;
            labelZone7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            labelZone7.Location = new System.Drawing.Point(456, 154);
            labelZone7.Name = "labelZone7";
            labelZone7.Size = new System.Drawing.Size(158, 29);
            labelZone7.TabIndex = 506;
            labelZone7.Text = "Zone 7";
            labelZone7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label155
            // 
            label155.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label155.AutoSize = true;
            label155.BackColor = System.Drawing.Color.Transparent;
            label155.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label155.ForeColor = System.Drawing.Color.Black;
            label155.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label155.Location = new System.Drawing.Point(496, 197);
            label155.Name = "label155";
            label155.Size = new System.Drawing.Size(31, 23);
            label155.TabIndex = 508;
            label155.Text = "->";
            // 
            // nudZone6To
            // 
            nudZone6To.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            nudZone6To.BackColor = System.Drawing.Color.AliceBlue;
            nudZone6To.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            nudZone6To.InterceptArrowKeys = false;
            nudZone6To.Location = new System.Drawing.Point(302, 188);
            nudZone6To.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            nudZone6To.Name = "nudZone6To";
            nudZone6To.ReadOnly = true;
            nudZone6To.Size = new System.Drawing.Size(87, 43);
            nudZone6To.TabIndex = 480;
            nudZone6To.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudZone6To.Value = new decimal(new int[] { 98, 0, 0, 0 });
            nudZone6To.Click += nudZone6To_Click;
            // 
            // nudZone4To
            // 
            nudZone4To.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            nudZone4To.BackColor = System.Drawing.Color.AliceBlue;
            nudZone4To.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            nudZone4To.InterceptArrowKeys = false;
            nudZone4To.Location = new System.Drawing.Point(751, 68);
            nudZone4To.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            nudZone4To.Name = "nudZone4To";
            nudZone4To.ReadOnly = true;
            nudZone4To.Size = new System.Drawing.Size(87, 43);
            nudZone4To.TabIndex = 476;
            nudZone4To.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudZone4To.Value = new decimal(new int[] { 98, 0, 0, 0 });
            nudZone4To.Click += nudZone4To_Click;
            // 
            // nudZone1To
            // 
            nudZone1To.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            nudZone1To.BackColor = System.Drawing.Color.AliceBlue;
            nudZone1To.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            nudZone1To.InterceptArrowKeys = false;
            nudZone1To.Location = new System.Drawing.Point(81, 69);
            nudZone1To.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            nudZone1To.Name = "nudZone1To";
            nudZone1To.ReadOnly = true;
            nudZone1To.Size = new System.Drawing.Size(87, 43);
            nudZone1To.TabIndex = 461;
            nudZone1To.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudZone1To.Value = new decimal(new int[] { 98, 0, 0, 0 });
            nudZone1To.Click += nudZone1To_Click;
            // 
            // nudZone5To
            // 
            nudZone5To.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            nudZone5To.BackColor = System.Drawing.Color.AliceBlue;
            nudZone5To.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            nudZone5To.InterceptArrowKeys = false;
            nudZone5To.Location = new System.Drawing.Point(81, 187);
            nudZone5To.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            nudZone5To.Name = "nudZone5To";
            nudZone5To.ReadOnly = true;
            nudZone5To.Size = new System.Drawing.Size(87, 43);
            nudZone5To.TabIndex = 478;
            nudZone5To.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudZone5To.Value = new decimal(new int[] { 98, 0, 0, 0 });
            nudZone5To.Click += nudZone5To_Click;
            // 
            // nudZone3To
            // 
            nudZone3To.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            nudZone3To.BackColor = System.Drawing.Color.AliceBlue;
            nudZone3To.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            nudZone3To.InterceptArrowKeys = false;
            nudZone3To.Location = new System.Drawing.Point(526, 70);
            nudZone3To.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            nudZone3To.Name = "nudZone3To";
            nudZone3To.ReadOnly = true;
            nudZone3To.Size = new System.Drawing.Size(87, 43);
            nudZone3To.TabIndex = 467;
            nudZone3To.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudZone3To.Value = new decimal(new int[] { 98, 0, 0, 0 });
            nudZone3To.Click += nudZone3To_Click;
            // 
            // nudZone2To
            // 
            nudZone2To.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            nudZone2To.BackColor = System.Drawing.Color.AliceBlue;
            nudZone2To.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            nudZone2To.InterceptArrowKeys = false;
            nudZone2To.Location = new System.Drawing.Point(302, 70);
            nudZone2To.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            nudZone2To.Name = "nudZone2To";
            nudZone2To.ReadOnly = true;
            nudZone2To.Size = new System.Drawing.Size(87, 43);
            nudZone2To.TabIndex = 464;
            nudZone2To.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudZone2To.Value = new decimal(new int[] { 98, 0, 0, 0 });
            nudZone2To.Click += nudZone2To_Click;
            // 
            // lblZoneStart6
            // 
            lblZoneStart6.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblZoneStart6.BackColor = System.Drawing.Color.Transparent;
            lblZoneStart6.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblZoneStart6.ForeColor = System.Drawing.Color.Black;
            lblZoneStart6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            lblZoneStart6.Location = new System.Drawing.Point(221, 188);
            lblZoneStart6.Name = "lblZoneStart6";
            lblZoneStart6.Size = new System.Drawing.Size(55, 42);
            lblZoneStart6.TabIndex = 499;
            lblZoneStart6.Text = "99";
            lblZoneStart6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblZoneStart5
            // 
            lblZoneStart5.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblZoneStart5.BackColor = System.Drawing.Color.Transparent;
            lblZoneStart5.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblZoneStart5.ForeColor = System.Drawing.Color.Black;
            lblZoneStart5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            lblZoneStart5.Location = new System.Drawing.Point(1, 189);
            lblZoneStart5.Name = "lblZoneStart5";
            lblZoneStart5.Size = new System.Drawing.Size(55, 42);
            lblZoneStart5.TabIndex = 498;
            lblZoneStart5.Text = "99 ->";
            lblZoneStart5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblZoneStart4
            // 
            lblZoneStart4.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblZoneStart4.BackColor = System.Drawing.Color.Transparent;
            lblZoneStart4.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblZoneStart4.ForeColor = System.Drawing.Color.Black;
            lblZoneStart4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            lblZoneStart4.Location = new System.Drawing.Point(671, 70);
            lblZoneStart4.Name = "lblZoneStart4";
            lblZoneStart4.Size = new System.Drawing.Size(55, 42);
            lblZoneStart4.TabIndex = 497;
            lblZoneStart4.Text = "99 ->";
            lblZoneStart4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblZoneStart3
            // 
            lblZoneStart3.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblZoneStart3.BackColor = System.Drawing.Color.Transparent;
            lblZoneStart3.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblZoneStart3.ForeColor = System.Drawing.Color.Black;
            lblZoneStart3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            lblZoneStart3.Location = new System.Drawing.Point(445, 70);
            lblZoneStart3.Name = "lblZoneStart3";
            lblZoneStart3.Size = new System.Drawing.Size(55, 42);
            lblZoneStart3.TabIndex = 496;
            lblZoneStart3.Text = "99 ->";
            lblZoneStart3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblZoneStart2
            // 
            lblZoneStart2.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblZoneStart2.BackColor = System.Drawing.Color.Transparent;
            lblZoneStart2.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblZoneStart2.ForeColor = System.Drawing.Color.Black;
            lblZoneStart2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            lblZoneStart2.Location = new System.Drawing.Point(221, 71);
            lblZoneStart2.Name = "lblZoneStart2";
            lblZoneStart2.Size = new System.Drawing.Size(55, 42);
            lblZoneStart2.TabIndex = 495;
            lblZoneStart2.Text = "99 ->";
            lblZoneStart2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblZoneStart1
            // 
            lblZoneStart1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblZoneStart1.BackColor = System.Drawing.Color.Transparent;
            lblZoneStart1.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblZoneStart1.ForeColor = System.Drawing.Color.Black;
            lblZoneStart1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            lblZoneStart1.Location = new System.Drawing.Point(1, 70);
            lblZoneStart1.Name = "lblZoneStart1";
            lblZoneStart1.Size = new System.Drawing.Size(55, 42);
            lblZoneStart1.TabIndex = 494;
            lblZoneStart1.Text = "1 ->";
            lblZoneStart1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelZone1
            // 
            labelZone1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelZone1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelZone1.ForeColor = System.Drawing.Color.Black;
            labelZone1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            labelZone1.Location = new System.Drawing.Point(7, 34);
            labelZone1.Name = "labelZone1";
            labelZone1.Size = new System.Drawing.Size(161, 29);
            labelZone1.TabIndex = 487;
            labelZone1.Text = "Zone 1";
            labelZone1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelZone2
            // 
            labelZone2.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelZone2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelZone2.ForeColor = System.Drawing.Color.Black;
            labelZone2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            labelZone2.Location = new System.Drawing.Point(234, 35);
            labelZone2.Name = "labelZone2";
            labelZone2.Size = new System.Drawing.Size(155, 29);
            labelZone2.TabIndex = 491;
            labelZone2.Text = "Zone 2";
            labelZone2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelZone6
            // 
            labelZone6.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelZone6.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelZone6.ForeColor = System.Drawing.Color.Black;
            labelZone6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            labelZone6.Location = new System.Drawing.Point(234, 153);
            labelZone6.Name = "labelZone6";
            labelZone6.Size = new System.Drawing.Size(155, 29);
            labelZone6.TabIndex = 492;
            labelZone6.Text = "Zone 6";
            labelZone6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelZone3
            // 
            labelZone3.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelZone3.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelZone3.ForeColor = System.Drawing.Color.Black;
            labelZone3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            labelZone3.Location = new System.Drawing.Point(456, 34);
            labelZone3.Name = "labelZone3";
            labelZone3.Size = new System.Drawing.Size(158, 29);
            labelZone3.TabIndex = 490;
            labelZone3.Text = "Zone 3";
            labelZone3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelZone5
            // 
            labelZone5.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelZone5.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelZone5.ForeColor = System.Drawing.Color.Black;
            labelZone5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            labelZone5.Location = new System.Drawing.Point(15, 152);
            labelZone5.Name = "labelZone5";
            labelZone5.Size = new System.Drawing.Size(153, 29);
            labelZone5.TabIndex = 488;
            labelZone5.Text = "Zone 5";
            labelZone5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelZone4
            // 
            labelZone4.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelZone4.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelZone4.ForeColor = System.Drawing.Color.Black;
            labelZone4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            labelZone4.Location = new System.Drawing.Point(677, 33);
            labelZone4.Name = "labelZone4";
            labelZone4.Size = new System.Drawing.Size(162, 29);
            labelZone4.TabIndex = 489;
            labelZone4.Text = "Zone 4";
            labelZone4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label152
            // 
            label152.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label152.AutoSize = true;
            label152.BackColor = System.Drawing.Color.Transparent;
            label152.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label152.ForeColor = System.Drawing.Color.Black;
            label152.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label152.Location = new System.Drawing.Point(272, 196);
            label152.Name = "label152";
            label152.Size = new System.Drawing.Size(31, 23);
            label152.TabIndex = 504;
            label152.Text = "->";
            // 
            // label117
            // 
            label117.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label117.AutoSize = true;
            label117.BackColor = System.Drawing.Color.Transparent;
            label117.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label117.ForeColor = System.Drawing.Color.Black;
            label117.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label117.Location = new System.Drawing.Point(52, 197);
            label117.Name = "label117";
            label117.Size = new System.Drawing.Size(31, 23);
            label117.TabIndex = 503;
            label117.Text = "->";
            // 
            // label116
            // 
            label116.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label116.AutoSize = true;
            label116.BackColor = System.Drawing.Color.Transparent;
            label116.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label116.ForeColor = System.Drawing.Color.Black;
            label116.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label116.Location = new System.Drawing.Point(722, 78);
            label116.Name = "label116";
            label116.Size = new System.Drawing.Size(31, 23);
            label116.TabIndex = 502;
            label116.Text = "->";
            // 
            // label104
            // 
            label104.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label104.AutoSize = true;
            label104.BackColor = System.Drawing.Color.Transparent;
            label104.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label104.ForeColor = System.Drawing.Color.Black;
            label104.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label104.Location = new System.Drawing.Point(52, 78);
            label104.Name = "label104";
            label104.Size = new System.Drawing.Size(31, 23);
            label104.TabIndex = 501;
            label104.Text = "->";
            // 
            // label7
            // 
            label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label7.AutoSize = true;
            label7.BackColor = System.Drawing.Color.Transparent;
            label7.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label7.ForeColor = System.Drawing.Color.Black;
            label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label7.Location = new System.Drawing.Point(496, 78);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(31, 23);
            label7.TabIndex = 500;
            label7.Text = "->";
            // 
            // label6
            // 
            label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label6.AutoSize = true;
            label6.BackColor = System.Drawing.Color.Transparent;
            label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label6.ForeColor = System.Drawing.Color.Black;
            label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label6.Location = new System.Drawing.Point(273, 79);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(31, 23);
            label6.TabIndex = 497;
            label6.Text = "->";
            // 
            // label178
            // 
            label178.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label178.AutoSize = true;
            label178.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label178.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label178.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label178.Location = new System.Drawing.Point(290, 410);
            label178.Name = "label178";
            label178.Size = new System.Drawing.Size(32, 19);
            label178.TabIndex = 503;
            label178.Text = "cm";
            label178.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelBoundary
            // 
            labelBoundary.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelBoundary.BackColor = System.Drawing.Color.Transparent;
            labelBoundary.Font = new System.Drawing.Font("Tahoma", 15.75F);
            labelBoundary.ForeColor = System.Drawing.Color.Black;
            labelBoundary.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            labelBoundary.Location = new System.Drawing.Point(240, 429);
            labelBoundary.Name = "labelBoundary";
            labelBoundary.Size = new System.Drawing.Size(168, 32);
            labelBoundary.TabIndex = 502;
            labelBoundary.Text = "Boundary";
            labelBoundary.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblTurnOffBelowUnits
            // 
            lblTurnOffBelowUnits.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblTurnOffBelowUnits.AutoSize = true;
            lblTurnOffBelowUnits.BackColor = System.Drawing.Color.Transparent;
            lblTurnOffBelowUnits.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblTurnOffBelowUnits.ForeColor = System.Drawing.Color.Black;
            lblTurnOffBelowUnits.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            lblTurnOffBelowUnits.Location = new System.Drawing.Point(740, 548);
            lblTurnOffBelowUnits.Name = "lblTurnOffBelowUnits";
            lblTurnOffBelowUnits.Size = new System.Drawing.Size(57, 23);
            lblTurnOffBelowUnits.TabIndex = 498;
            lblTurnOffBelowUnits.Text = "Km/H";
            // 
            // labelChoose
            // 
            labelChoose.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelChoose.BackColor = System.Drawing.Color.Transparent;
            labelChoose.Font = new System.Drawing.Font("Tahoma", 15.75F);
            labelChoose.ForeColor = System.Drawing.Color.Black;
            labelChoose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            labelChoose.Location = new System.Drawing.Point(22, 436);
            labelChoose.Name = "labelChoose";
            labelChoose.Size = new System.Drawing.Size(177, 25);
            labelChoose.TabIndex = 497;
            labelChoose.Text = "Choose";
            labelChoose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblInchCm2
            // 
            lblInchCm2.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblInchCm2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblInchCm2.ForeColor = System.Drawing.Color.DarkGreen;
            lblInchCm2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            lblInchCm2.Location = new System.Drawing.Point(655, 370);
            lblInchCm2.Name = "lblInchCm2";
            lblInchCm2.Size = new System.Drawing.Size(135, 25);
            lblInchCm2.TabIndex = 496;
            lblInchCm2.Text = "Inch";
            lblInchCm2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSectionWidth
            // 
            labelSectionWidth.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelSectionWidth.BackColor = System.Drawing.Color.Transparent;
            labelSectionWidth.Font = new System.Drawing.Font("Tahoma", 15.75F);
            labelSectionWidth.ForeColor = System.Drawing.Color.Black;
            labelSectionWidth.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            labelSectionWidth.Location = new System.Drawing.Point(217, 325);
            labelSectionWidth.Name = "labelSectionWidth";
            labelSectionWidth.Size = new System.Drawing.Size(177, 25);
            labelSectionWidth.TabIndex = 297;
            labelSectionWidth.Text = "Section Width";
            labelSectionWidth.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // cboxNumSections
            // 
            cboxNumSections.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            cboxNumSections.BackColor = System.Drawing.Color.AliceBlue;
            cboxNumSections.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboxNumSections.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cboxNumSections.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cboxNumSections.FormattingEnabled = true;
            cboxNumSections.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16" });
            cboxNumSections.Location = new System.Drawing.Point(506, 356);
            cboxNumSections.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            cboxNumSections.Name = "cboxNumSections";
            cboxNumSections.Size = new System.Drawing.Size(74, 50);
            cboxNumSections.TabIndex = 295;
            cboxNumSections.SelectedIndexChanged += cboxNumSections_SelectedIndexChanged;
            // 
            // lblVehicleToolWidth
            // 
            lblVehicleToolWidth.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblVehicleToolWidth.Font = new System.Drawing.Font("Tahoma", 24F);
            lblVehicleToolWidth.ForeColor = System.Drawing.Color.Black;
            lblVehicleToolWidth.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            lblVehicleToolWidth.Location = new System.Drawing.Point(638, 327);
            lblVehicleToolWidth.Name = "lblVehicleToolWidth";
            lblVehicleToolWidth.Size = new System.Drawing.Size(172, 39);
            lblVehicleToolWidth.TabIndex = 294;
            lblVehicleToolWidth.Text = "II";
            lblVehicleToolWidth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCoverage
            // 
            labelCoverage.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelCoverage.BackColor = System.Drawing.Color.Transparent;
            labelCoverage.Font = new System.Drawing.Font("Tahoma", 15.75F);
            labelCoverage.ForeColor = System.Drawing.Color.Black;
            labelCoverage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            labelCoverage.Location = new System.Drawing.Point(443, 429);
            labelCoverage.Name = "labelCoverage";
            labelCoverage.Size = new System.Drawing.Size(174, 32);
            labelCoverage.TabIndex = 293;
            labelCoverage.Text = "% Coverage";
            labelCoverage.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // labelZonesBox
            // 
            labelZonesBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelZonesBox.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelZonesBox.ForeColor = System.Drawing.Color.Black;
            labelZonesBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            labelZonesBox.Location = new System.Drawing.Point(30, 319);
            labelZonesBox.Name = "labelZonesBox";
            labelZonesBox.Size = new System.Drawing.Size(97, 29);
            labelZonesBox.TabIndex = 493;
            labelZonesBox.Text = "Zones";
            labelZonesBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNumOfSections
            // 
            labelNumOfSections.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelNumOfSections.BackColor = System.Drawing.Color.Transparent;
            labelNumOfSections.Font = new System.Drawing.Font("Tahoma", 15.75F);
            labelNumOfSections.ForeColor = System.Drawing.Color.Black;
            labelNumOfSections.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            labelNumOfSections.Location = new System.Drawing.Point(442, 315);
            labelNumOfSections.Name = "labelNumOfSections";
            labelNumOfSections.Size = new System.Drawing.Size(195, 33);
            labelNumOfSections.TabIndex = 291;
            labelNumOfSections.Text = "Sections";
            labelNumOfSections.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // cboxNumberOfZones
            // 
            cboxNumberOfZones.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            cboxNumberOfZones.BackColor = System.Drawing.Color.AliceBlue;
            cboxNumberOfZones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboxNumberOfZones.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cboxNumberOfZones.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cboxNumberOfZones.FormattingEnabled = true;
            cboxNumberOfZones.Items.AddRange(new object[] { "2", "3", "4", "5", "6", "7", "8" });
            cboxNumberOfZones.Location = new System.Drawing.Point(27, 355);
            cboxNumberOfZones.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            cboxNumberOfZones.Name = "cboxNumberOfZones";
            cboxNumberOfZones.Size = new System.Drawing.Size(100, 50);
            cboxNumberOfZones.TabIndex = 468;
            cboxNumberOfZones.SelectedIndexChanged += cboxNumberOfZones_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.Black;
            label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label1.Location = new System.Drawing.Point(758, 73);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(38, 25);
            label1.TabIndex = 290;
            label1.Text = "16";
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label4.ForeColor = System.Drawing.Color.Black;
            label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label4.Location = new System.Drawing.Point(654, 73);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(38, 25);
            label4.TabIndex = 288;
            label4.Text = "15";
            // 
            // label19
            // 
            label19.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label19.AutoSize = true;
            label19.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label19.ForeColor = System.Drawing.Color.Black;
            label19.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label19.Location = new System.Drawing.Point(550, 73);
            label19.Name = "label19";
            label19.Size = new System.Drawing.Size(38, 25);
            label19.TabIndex = 287;
            label19.Text = "14";
            // 
            // label30
            // 
            label30.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label30.AutoSize = true;
            label30.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label30.ForeColor = System.Drawing.Color.Black;
            label30.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label30.Location = new System.Drawing.Point(443, 73);
            label30.Name = "label30";
            label30.Size = new System.Drawing.Size(38, 25);
            label30.TabIndex = 286;
            label30.Text = "13";
            // 
            // label32
            // 
            label32.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label32.AutoSize = true;
            label32.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label32.ForeColor = System.Drawing.Color.Black;
            label32.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label32.Location = new System.Drawing.Point(555, 203);
            label32.Name = "label32";
            label32.Size = new System.Drawing.Size(25, 25);
            label32.TabIndex = 276;
            label32.Text = "6";
            // 
            // label34
            // 
            label34.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label34.AutoSize = true;
            label34.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label34.ForeColor = System.Drawing.Color.Black;
            label34.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label34.Location = new System.Drawing.Point(135, 203);
            label34.Name = "label34";
            label34.Size = new System.Drawing.Size(25, 25);
            label34.TabIndex = 275;
            label34.Text = "2";
            // 
            // label35
            // 
            label35.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label35.AutoSize = true;
            label35.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label35.ForeColor = System.Drawing.Color.Black;
            label35.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label35.Location = new System.Drawing.Point(240, 203);
            label35.Name = "label35";
            label35.Size = new System.Drawing.Size(25, 25);
            label35.TabIndex = 274;
            label35.Text = "3";
            // 
            // label40
            // 
            label40.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label40.AutoSize = true;
            label40.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label40.ForeColor = System.Drawing.Color.Black;
            label40.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label40.Location = new System.Drawing.Point(339, 73);
            label40.Name = "label40";
            label40.Size = new System.Drawing.Size(38, 25);
            label40.TabIndex = 282;
            label40.Text = "12";
            // 
            // label39
            // 
            label39.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label39.AutoSize = true;
            label39.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label39.ForeColor = System.Drawing.Color.Black;
            label39.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label39.Location = new System.Drawing.Point(235, 73);
            label39.Name = "label39";
            label39.Size = new System.Drawing.Size(38, 25);
            label39.TabIndex = 281;
            label39.Text = "11";
            // 
            // label38
            // 
            label38.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label38.AutoSize = true;
            label38.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label38.ForeColor = System.Drawing.Color.Black;
            label38.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label38.Location = new System.Drawing.Point(131, 73);
            label38.Name = "label38";
            label38.Size = new System.Drawing.Size(38, 25);
            label38.TabIndex = 280;
            label38.Text = "10";
            // 
            // label37
            // 
            label37.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label37.AutoSize = true;
            label37.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label37.ForeColor = System.Drawing.Color.Black;
            label37.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label37.Location = new System.Drawing.Point(33, 73);
            label37.Name = "label37";
            label37.Size = new System.Drawing.Size(25, 25);
            label37.TabIndex = 279;
            label37.Text = "9";
            // 
            // label41
            // 
            label41.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label41.AutoSize = true;
            label41.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label41.ForeColor = System.Drawing.Color.Black;
            label41.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label41.Location = new System.Drawing.Point(765, 203);
            label41.Name = "label41";
            label41.Size = new System.Drawing.Size(25, 25);
            label41.TabIndex = 278;
            label41.Text = "8";
            // 
            // label45
            // 
            label45.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label45.AutoSize = true;
            label45.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label45.ForeColor = System.Drawing.Color.Black;
            label45.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label45.Location = new System.Drawing.Point(660, 203);
            label45.Name = "label45";
            label45.Size = new System.Drawing.Size(25, 25);
            label45.TabIndex = 277;
            label45.Text = "7";
            // 
            // label46
            // 
            label46.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label46.AutoSize = true;
            label46.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label46.ForeColor = System.Drawing.Color.Black;
            label46.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label46.Location = new System.Drawing.Point(345, 203);
            label46.Name = "label46";
            label46.Size = new System.Drawing.Size(25, 25);
            label46.TabIndex = 273;
            label46.Text = "4";
            // 
            // label47
            // 
            label47.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label47.AutoSize = true;
            label47.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label47.ForeColor = System.Drawing.Color.Black;
            label47.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label47.Location = new System.Drawing.Point(450, 203);
            label47.Name = "label47";
            label47.Size = new System.Drawing.Size(25, 25);
            label47.TabIndex = 272;
            label47.Text = "5";
            // 
            // label48
            // 
            label48.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label48.AutoSize = true;
            label48.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label48.ForeColor = System.Drawing.Color.Black;
            label48.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label48.Location = new System.Drawing.Point(30, 203);
            label48.Name = "label48";
            label48.Size = new System.Drawing.Size(25, 25);
            label48.TabIndex = 271;
            label48.Text = "1";
            // 
            // nudCutoffSpeed
            // 
            nudCutoffSpeed.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            nudCutoffSpeed.BackColor = System.Drawing.Color.AliceBlue;
            nudCutoffSpeed.DecimalPlaces = 1;
            nudCutoffSpeed.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            nudCutoffSpeed.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nudCutoffSpeed.InterceptArrowKeys = false;
            nudCutoffSpeed.Location = new System.Drawing.Point(698, 495);
            nudCutoffSpeed.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            nudCutoffSpeed.Name = "nudCutoffSpeed";
            nudCutoffSpeed.ReadOnly = true;
            nudCutoffSpeed.Size = new System.Drawing.Size(127, 52);
            nudCutoffSpeed.TabIndex = 499;
            nudCutoffSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudCutoffSpeed.Value = new decimal(new int[] { 11, 0, 0, 65536 });
            nudCutoffSpeed.Click += nudCutoffSpeed_Click;
            // 
            // nudDefaultSectionWidth
            // 
            nudDefaultSectionWidth.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            nudDefaultSectionWidth.BackColor = System.Drawing.Color.AliceBlue;
            nudDefaultSectionWidth.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            nudDefaultSectionWidth.InterceptArrowKeys = false;
            nudDefaultSectionWidth.Location = new System.Drawing.Point(218, 355);
            nudDefaultSectionWidth.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudDefaultSectionWidth.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            nudDefaultSectionWidth.Name = "nudDefaultSectionWidth";
            nudDefaultSectionWidth.ReadOnly = true;
            nudDefaultSectionWidth.Size = new System.Drawing.Size(179, 52);
            nudDefaultSectionWidth.TabIndex = 296;
            nudDefaultSectionWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudDefaultSectionWidth.Value = new decimal(new int[] { 50, 0, 0, 0 });
            nudDefaultSectionWidth.Click += nudDefaultSectionWidth_Click;
            // 
            // nudMinCoverage
            // 
            nudMinCoverage.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            nudMinCoverage.BackColor = System.Drawing.Color.AliceBlue;
            nudMinCoverage.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            nudMinCoverage.InterceptArrowKeys = false;
            nudMinCoverage.Location = new System.Drawing.Point(462, 464);
            nudMinCoverage.Name = "nudMinCoverage";
            nudMinCoverage.ReadOnly = true;
            nudMinCoverage.Size = new System.Drawing.Size(132, 52);
            nudMinCoverage.TabIndex = 292;
            nudMinCoverage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudMinCoverage.Value = new decimal(new int[] { 100, 0, 0, 0 });
            nudMinCoverage.Click += nudMinCoverage_Click;
            // 
            // nudSection16
            // 
            nudSection16.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            nudSection16.BackColor = System.Drawing.Color.AliceBlue;
            nudSection16.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            nudSection16.InterceptArrowKeys = false;
            nudSection16.Location = new System.Drawing.Point(743, 104);
            nudSection16.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            nudSection16.Name = "nudSection16";
            nudSection16.ReadOnly = true;
            nudSection16.Size = new System.Drawing.Size(87, 36);
            nudSection16.TabIndex = 289;
            nudSection16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudSection16.Value = new decimal(new int[] { 92, 0, 0, 0 });
            nudSection16.Click += NudSection1_Click;
            // 
            // nudSection15
            // 
            nudSection15.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            nudSection15.BackColor = System.Drawing.Color.AliceBlue;
            nudSection15.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            nudSection15.InterceptArrowKeys = false;
            nudSection15.Location = new System.Drawing.Point(638, 104);
            nudSection15.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            nudSection15.Name = "nudSection15";
            nudSection15.ReadOnly = true;
            nudSection15.Size = new System.Drawing.Size(87, 36);
            nudSection15.TabIndex = 285;
            nudSection15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudSection15.Value = new decimal(new int[] { 92, 0, 0, 0 });
            nudSection15.Click += NudSection1_Click;
            // 
            // nudSection14
            // 
            nudSection14.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            nudSection14.BackColor = System.Drawing.Color.AliceBlue;
            nudSection14.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            nudSection14.InterceptArrowKeys = false;
            nudSection14.Location = new System.Drawing.Point(533, 104);
            nudSection14.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            nudSection14.Name = "nudSection14";
            nudSection14.ReadOnly = true;
            nudSection14.Size = new System.Drawing.Size(87, 36);
            nudSection14.TabIndex = 284;
            nudSection14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudSection14.Value = new decimal(new int[] { 92, 0, 0, 0 });
            nudSection14.Click += NudSection1_Click;
            // 
            // nudSection13
            // 
            nudSection13.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            nudSection13.BackColor = System.Drawing.Color.AliceBlue;
            nudSection13.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            nudSection13.InterceptArrowKeys = false;
            nudSection13.Location = new System.Drawing.Point(428, 104);
            nudSection13.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            nudSection13.Name = "nudSection13";
            nudSection13.ReadOnly = true;
            nudSection13.Size = new System.Drawing.Size(87, 36);
            nudSection13.TabIndex = 283;
            nudSection13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudSection13.Value = new decimal(new int[] { 92, 0, 0, 0 });
            nudSection13.Click += NudSection1_Click;
            // 
            // nudSection12
            // 
            nudSection12.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            nudSection12.BackColor = System.Drawing.Color.AliceBlue;
            nudSection12.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            nudSection12.InterceptArrowKeys = false;
            nudSection12.Location = new System.Drawing.Point(323, 104);
            nudSection12.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            nudSection12.Name = "nudSection12";
            nudSection12.ReadOnly = true;
            nudSection12.Size = new System.Drawing.Size(87, 36);
            nudSection12.TabIndex = 270;
            nudSection12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudSection12.Value = new decimal(new int[] { 92, 0, 0, 0 });
            nudSection12.Click += NudSection1_Click;
            // 
            // nudSection11
            // 
            nudSection11.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            nudSection11.BackColor = System.Drawing.Color.AliceBlue;
            nudSection11.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            nudSection11.InterceptArrowKeys = false;
            nudSection11.Location = new System.Drawing.Point(218, 104);
            nudSection11.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            nudSection11.Name = "nudSection11";
            nudSection11.ReadOnly = true;
            nudSection11.Size = new System.Drawing.Size(87, 36);
            nudSection11.TabIndex = 269;
            nudSection11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudSection11.Value = new decimal(new int[] { 92, 0, 0, 0 });
            nudSection11.Click += NudSection1_Click;
            // 
            // nudSection10
            // 
            nudSection10.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            nudSection10.BackColor = System.Drawing.Color.AliceBlue;
            nudSection10.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            nudSection10.InterceptArrowKeys = false;
            nudSection10.Location = new System.Drawing.Point(113, 104);
            nudSection10.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            nudSection10.Name = "nudSection10";
            nudSection10.ReadOnly = true;
            nudSection10.Size = new System.Drawing.Size(87, 36);
            nudSection10.TabIndex = 268;
            nudSection10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudSection10.Value = new decimal(new int[] { 92, 0, 0, 0 });
            nudSection10.Click += NudSection1_Click;
            // 
            // nudSection09
            // 
            nudSection09.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            nudSection09.BackColor = System.Drawing.Color.AliceBlue;
            nudSection09.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            nudSection09.InterceptArrowKeys = false;
            nudSection09.Location = new System.Drawing.Point(8, 104);
            nudSection09.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            nudSection09.Name = "nudSection09";
            nudSection09.ReadOnly = true;
            nudSection09.Size = new System.Drawing.Size(87, 36);
            nudSection09.TabIndex = 267;
            nudSection09.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudSection09.Value = new decimal(new int[] { 92, 0, 0, 0 });
            nudSection09.Click += NudSection1_Click;
            // 
            // nudSection08
            // 
            nudSection08.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            nudSection08.BackColor = System.Drawing.Color.AliceBlue;
            nudSection08.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            nudSection08.InterceptArrowKeys = false;
            nudSection08.Location = new System.Drawing.Point(743, 233);
            nudSection08.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            nudSection08.Name = "nudSection08";
            nudSection08.ReadOnly = true;
            nudSection08.Size = new System.Drawing.Size(87, 36);
            nudSection08.TabIndex = 266;
            nudSection08.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudSection08.Value = new decimal(new int[] { 92, 0, 0, 0 });
            nudSection08.Click += NudSection1_Click;
            // 
            // nudSection07
            // 
            nudSection07.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            nudSection07.BackColor = System.Drawing.Color.AliceBlue;
            nudSection07.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            nudSection07.InterceptArrowKeys = false;
            nudSection07.Location = new System.Drawing.Point(638, 233);
            nudSection07.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            nudSection07.Name = "nudSection07";
            nudSection07.ReadOnly = true;
            nudSection07.Size = new System.Drawing.Size(87, 36);
            nudSection07.TabIndex = 265;
            nudSection07.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudSection07.Value = new decimal(new int[] { 93, 0, 0, 0 });
            nudSection07.Click += NudSection1_Click;
            // 
            // nudSection06
            // 
            nudSection06.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            nudSection06.BackColor = System.Drawing.Color.AliceBlue;
            nudSection06.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            nudSection06.InterceptArrowKeys = false;
            nudSection06.Location = new System.Drawing.Point(533, 233);
            nudSection06.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            nudSection06.Name = "nudSection06";
            nudSection06.ReadOnly = true;
            nudSection06.Size = new System.Drawing.Size(87, 36);
            nudSection06.TabIndex = 264;
            nudSection06.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudSection06.Value = new decimal(new int[] { 3888, 0, 0, 0 });
            nudSection06.Click += NudSection1_Click;
            // 
            // nudSection05
            // 
            nudSection05.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            nudSection05.BackColor = System.Drawing.Color.AliceBlue;
            nudSection05.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            nudSection05.InterceptArrowKeys = false;
            nudSection05.Location = new System.Drawing.Point(428, 233);
            nudSection05.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            nudSection05.Name = "nudSection05";
            nudSection05.ReadOnly = true;
            nudSection05.Size = new System.Drawing.Size(87, 36);
            nudSection05.TabIndex = 263;
            nudSection05.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudSection05.Value = new decimal(new int[] { 95, 0, 0, 0 });
            nudSection05.Click += NudSection1_Click;
            // 
            // nudSection04
            // 
            nudSection04.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            nudSection04.BackColor = System.Drawing.Color.AliceBlue;
            nudSection04.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            nudSection04.InterceptArrowKeys = false;
            nudSection04.Location = new System.Drawing.Point(323, 233);
            nudSection04.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            nudSection04.Name = "nudSection04";
            nudSection04.ReadOnly = true;
            nudSection04.Size = new System.Drawing.Size(87, 36);
            nudSection04.TabIndex = 262;
            nudSection04.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudSection04.Value = new decimal(new int[] { 96, 0, 0, 0 });
            nudSection04.Click += NudSection1_Click;
            // 
            // nudSection03
            // 
            nudSection03.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            nudSection03.BackColor = System.Drawing.Color.AliceBlue;
            nudSection03.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            nudSection03.InterceptArrowKeys = false;
            nudSection03.Location = new System.Drawing.Point(218, 233);
            nudSection03.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            nudSection03.Name = "nudSection03";
            nudSection03.ReadOnly = true;
            nudSection03.Size = new System.Drawing.Size(87, 36);
            nudSection03.TabIndex = 261;
            nudSection03.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudSection03.Value = new decimal(new int[] { 97, 0, 0, 0 });
            nudSection03.Click += NudSection1_Click;
            // 
            // nudSection02
            // 
            nudSection02.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            nudSection02.BackColor = System.Drawing.Color.AliceBlue;
            nudSection02.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            nudSection02.InterceptArrowKeys = false;
            nudSection02.Location = new System.Drawing.Point(113, 233);
            nudSection02.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            nudSection02.Name = "nudSection02";
            nudSection02.ReadOnly = true;
            nudSection02.Size = new System.Drawing.Size(87, 36);
            nudSection02.TabIndex = 260;
            nudSection02.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudSection02.Value = new decimal(new int[] { 98, 0, 0, 0 });
            nudSection02.Click += NudSection1_Click;
            // 
            // nudSection01
            // 
            nudSection01.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            nudSection01.BackColor = System.Drawing.Color.AliceBlue;
            nudSection01.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            nudSection01.InterceptArrowKeys = false;
            nudSection01.Location = new System.Drawing.Point(8, 233);
            nudSection01.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            nudSection01.Name = "nudSection01";
            nudSection01.ReadOnly = true;
            nudSection01.Size = new System.Drawing.Size(87, 36);
            nudSection01.TabIndex = 259;
            nudSection01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudSection01.Value = new decimal(new int[] { 99, 0, 0, 0 });
            nudSection01.Click += NudSection1_Click;
            // 
            // nudNumberOfSections
            // 
            nudNumberOfSections.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            nudNumberOfSections.BackColor = System.Drawing.Color.AliceBlue;
            nudNumberOfSections.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            nudNumberOfSections.InterceptArrowKeys = false;
            nudNumberOfSections.Location = new System.Drawing.Point(486, 355);
            nudNumberOfSections.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudNumberOfSections.Name = "nudNumberOfSections";
            nudNumberOfSections.ReadOnly = true;
            nudNumberOfSections.Size = new System.Drawing.Size(108, 52);
            nudNumberOfSections.TabIndex = 458;
            nudNumberOfSections.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudNumberOfSections.Value = new decimal(new int[] { 48, 0, 0, 0 });
            nudNumberOfSections.Click += nudNumberOfSections_Click;
            // 
            // cboxSectionBoundaryControl
            // 
            cboxSectionBoundaryControl.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            cboxSectionBoundaryControl.Appearance = System.Windows.Forms.Appearance.Button;
            cboxSectionBoundaryControl.BackColor = System.Drawing.Color.AliceBlue;
            cboxSectionBoundaryControl.BackgroundImage = Properties.Resources.SectionOffBoundary;
            cboxSectionBoundaryControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            cboxSectionBoundaryControl.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            cboxSectionBoundaryControl.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            cboxSectionBoundaryControl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            cboxSectionBoundaryControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboxSectionBoundaryControl.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cboxSectionBoundaryControl.ForeColor = System.Drawing.Color.Black;
            cboxSectionBoundaryControl.Location = new System.Drawing.Point(245, 464);
            cboxSectionBoundaryControl.Name = "cboxSectionBoundaryControl";
            cboxSectionBoundaryControl.Size = new System.Drawing.Size(149, 107);
            cboxSectionBoundaryControl.TabIndex = 501;
            cboxSectionBoundaryControl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            cboxSectionBoundaryControl.UseVisualStyleBackColor = false;
            cboxSectionBoundaryControl.Click += cboxSectionBoundaryControl_Click;
            // 
            // pictureBox11
            // 
            pictureBox11.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            pictureBox11.Image = Properties.Resources.SectionOffBelow;
            pictureBox11.Location = new System.Drawing.Point(701, 435);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new System.Drawing.Size(116, 57);
            pictureBox11.TabIndex = 500;
            pictureBox11.TabStop = false;
            // 
            // cboxIsUnique
            // 
            cboxIsUnique.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            cboxIsUnique.Appearance = System.Windows.Forms.Appearance.Button;
            cboxIsUnique.BackColor = System.Drawing.Color.AliceBlue;
            cboxIsUnique.BackgroundImage = Properties.Resources.ConT_Symmetric;
            cboxIsUnique.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            cboxIsUnique.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            cboxIsUnique.FlatAppearance.CheckedBackColor = System.Drawing.Color.AliceBlue;
            cboxIsUnique.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            cboxIsUnique.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            cboxIsUnique.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboxIsUnique.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cboxIsUnique.ForeColor = System.Drawing.SystemColors.ControlText;
            cboxIsUnique.Location = new System.Drawing.Point(28, 464);
            cboxIsUnique.Name = "cboxIsUnique";
            cboxIsUnique.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            cboxIsUnique.Size = new System.Drawing.Size(165, 110);
            cboxIsUnique.TabIndex = 454;
            cboxIsUnique.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            cboxIsUnique.UseVisualStyleBackColor = false;
            cboxIsUnique.Click += cboxIsUnique_Click;
            // 
            // tabTSwitches
            // 
            tabTSwitches.BackColor = System.Drawing.Color.WhiteSmoke;
            tabTSwitches.Controls.Add(labelGroupSteerSwitch);
            tabTSwitches.Controls.Add(labelGroupWorkSwitch);
            tabTSwitches.Location = new System.Drawing.Point(4, 44);
            tabTSwitches.Name = "tabTSwitches";
            tabTSwitches.Size = new System.Drawing.Size(859, 584);
            tabTSwitches.TabIndex = 9;
            tabTSwitches.Text = "tSwit";
            tabTSwitches.Enter += tabTSwitches_Enter;
            tabTSwitches.Leave += tabTSwitches_Leave;
            // 
            // labelGroupSteerSwitch
            // 
            labelGroupSteerSwitch.Controls.Add(chkSetAutoSectionsSteer);
            labelGroupSteerSwitch.Controls.Add(chkSelectSteerSwitch);
            labelGroupSteerSwitch.Controls.Add(chkSetManualSectionsSteer);
            labelGroupSteerSwitch.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelGroupSteerSwitch.Location = new System.Drawing.Point(466, 64);
            labelGroupSteerSwitch.Name = "labelGroupSteerSwitch";
            labelGroupSteerSwitch.Size = new System.Drawing.Size(323, 370);
            labelGroupSteerSwitch.TabIndex = 457;
            labelGroupSteerSwitch.TabStop = false;
            labelGroupSteerSwitch.Text = "Steer Switch";
            // 
            // chkSetAutoSectionsSteer
            // 
            chkSetAutoSectionsSteer.Appearance = System.Windows.Forms.Appearance.Button;
            chkSetAutoSectionsSteer.BackColor = System.Drawing.Color.AliceBlue;
            chkSetAutoSectionsSteer.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            chkSetAutoSectionsSteer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            chkSetAutoSectionsSteer.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            chkSetAutoSectionsSteer.ForeColor = System.Drawing.SystemColors.ControlText;
            chkSetAutoSectionsSteer.Image = Properties.Resources.SectionMasterOff;
            chkSetAutoSectionsSteer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            chkSetAutoSectionsSteer.Location = new System.Drawing.Point(44, 272);
            chkSetAutoSectionsSteer.Name = "chkSetAutoSectionsSteer";
            chkSetAutoSectionsSteer.Size = new System.Drawing.Size(238, 71);
            chkSetAutoSectionsSteer.TabIndex = 458;
            chkSetAutoSectionsSteer.Text = "        Auto Sections";
            chkSetAutoSectionsSteer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            chkSetAutoSectionsSteer.UseVisualStyleBackColor = false;
            chkSetAutoSectionsSteer.Click += chkSetAutoSectionsSteer_Click;
            // 
            // chkSelectSteerSwitch
            // 
            chkSelectSteerSwitch.Appearance = System.Windows.Forms.Appearance.Button;
            chkSelectSteerSwitch.BackColor = System.Drawing.Color.AliceBlue;
            chkSelectSteerSwitch.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            chkSelectSteerSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            chkSelectSteerSwitch.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            chkSelectSteerSwitch.ForeColor = System.Drawing.SystemColors.ControlText;
            chkSelectSteerSwitch.Image = Properties.Resources.AutoSteerOff;
            chkSelectSteerSwitch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            chkSelectSteerSwitch.Location = new System.Drawing.Point(44, 56);
            chkSelectSteerSwitch.Name = "chkSelectSteerSwitch";
            chkSelectSteerSwitch.Size = new System.Drawing.Size(238, 70);
            chkSelectSteerSwitch.TabIndex = 2;
            chkSelectSteerSwitch.Text = "Activate";
            chkSelectSteerSwitch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            chkSelectSteerSwitch.UseVisualStyleBackColor = false;
            chkSelectSteerSwitch.Click += chkSelectSteerSwitch_Click;
            // 
            // chkSetManualSectionsSteer
            // 
            chkSetManualSectionsSteer.Appearance = System.Windows.Forms.Appearance.Button;
            chkSetManualSectionsSteer.BackColor = System.Drawing.Color.AliceBlue;
            chkSetManualSectionsSteer.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            chkSetManualSectionsSteer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            chkSetManualSectionsSteer.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            chkSetManualSectionsSteer.ForeColor = System.Drawing.SystemColors.ControlText;
            chkSetManualSectionsSteer.Image = Properties.Resources.ManualOff;
            chkSetManualSectionsSteer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            chkSetManualSectionsSteer.Location = new System.Drawing.Point(44, 172);
            chkSetManualSectionsSteer.Name = "chkSetManualSectionsSteer";
            chkSetManualSectionsSteer.Size = new System.Drawing.Size(238, 71);
            chkSetManualSectionsSteer.TabIndex = 457;
            chkSetManualSectionsSteer.Text = "        Manual Sections";
            chkSetManualSectionsSteer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            chkSetManualSectionsSteer.UseVisualStyleBackColor = false;
            chkSetManualSectionsSteer.Click += chkSetManualSectionsSteer_Click;
            // 
            // labelGroupWorkSwitch
            // 
            labelGroupWorkSwitch.BackColor = System.Drawing.Color.Transparent;
            labelGroupWorkSwitch.Controls.Add(chkSelectWorkSwitch);
            labelGroupWorkSwitch.Controls.Add(chkSetAutoSections);
            labelGroupWorkSwitch.Controls.Add(chkSetManualSections);
            labelGroupWorkSwitch.Controls.Add(chkWorkSwActiveLow);
            labelGroupWorkSwitch.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelGroupWorkSwitch.ForeColor = System.Drawing.Color.Black;
            labelGroupWorkSwitch.Location = new System.Drawing.Point(70, 64);
            labelGroupWorkSwitch.Name = "labelGroupWorkSwitch";
            labelGroupWorkSwitch.Size = new System.Drawing.Size(323, 462);
            labelGroupWorkSwitch.TabIndex = 67;
            labelGroupWorkSwitch.TabStop = false;
            labelGroupWorkSwitch.Text = "Work Switch";
            // 
            // chkSelectWorkSwitch
            // 
            chkSelectWorkSwitch.Appearance = System.Windows.Forms.Appearance.Button;
            chkSelectWorkSwitch.BackColor = System.Drawing.Color.AliceBlue;
            chkSelectWorkSwitch.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            chkSelectWorkSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            chkSelectWorkSwitch.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            chkSelectWorkSwitch.ForeColor = System.Drawing.SystemColors.ControlText;
            chkSelectWorkSwitch.Image = Properties.Resources.HydraulicLiftOff;
            chkSelectWorkSwitch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            chkSelectWorkSwitch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            chkSelectWorkSwitch.Location = new System.Drawing.Point(38, 56);
            chkSelectWorkSwitch.Name = "chkSelectWorkSwitch";
            chkSelectWorkSwitch.Size = new System.Drawing.Size(238, 70);
            chkSelectWorkSwitch.TabIndex = 1;
            chkSelectWorkSwitch.Text = "Activate";
            chkSelectWorkSwitch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            chkSelectWorkSwitch.UseVisualStyleBackColor = false;
            chkSelectWorkSwitch.Click += chkSelectWorkSwitch_Click;
            // 
            // chkSetAutoSections
            // 
            chkSetAutoSections.Appearance = System.Windows.Forms.Appearance.Button;
            chkSetAutoSections.BackColor = System.Drawing.Color.AliceBlue;
            chkSetAutoSections.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            chkSetAutoSections.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            chkSetAutoSections.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            chkSetAutoSections.ForeColor = System.Drawing.SystemColors.ControlText;
            chkSetAutoSections.Image = Properties.Resources.SectionMasterOff;
            chkSetAutoSections.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            chkSetAutoSections.Location = new System.Drawing.Point(38, 272);
            chkSetAutoSections.Name = "chkSetAutoSections";
            chkSetAutoSections.Size = new System.Drawing.Size(238, 71);
            chkSetAutoSections.TabIndex = 456;
            chkSetAutoSections.Text = "        Auto Sections";
            chkSetAutoSections.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            chkSetAutoSections.UseVisualStyleBackColor = false;
            chkSetAutoSections.Click += chkSetAutoSections_Click;
            // 
            // chkSetManualSections
            // 
            chkSetManualSections.Appearance = System.Windows.Forms.Appearance.Button;
            chkSetManualSections.BackColor = System.Drawing.Color.AliceBlue;
            chkSetManualSections.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            chkSetManualSections.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            chkSetManualSections.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            chkSetManualSections.ForeColor = System.Drawing.SystemColors.ControlText;
            chkSetManualSections.Image = Properties.Resources.ManualOff;
            chkSetManualSections.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            chkSetManualSections.Location = new System.Drawing.Point(38, 172);
            chkSetManualSections.Name = "chkSetManualSections";
            chkSetManualSections.Size = new System.Drawing.Size(238, 71);
            chkSetManualSections.TabIndex = 0;
            chkSetManualSections.Text = "        Manual Sections";
            chkSetManualSections.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            chkSetManualSections.UseVisualStyleBackColor = false;
            chkSetManualSections.Click += chkSetManualSections_Click;
            // 
            // chkWorkSwActiveLow
            // 
            chkWorkSwActiveLow.Appearance = System.Windows.Forms.Appearance.Button;
            chkWorkSwActiveLow.BackColor = System.Drawing.Color.AliceBlue;
            chkWorkSwActiveLow.Checked = true;
            chkWorkSwActiveLow.CheckState = System.Windows.Forms.CheckState.Checked;
            chkWorkSwActiveLow.FlatAppearance.CheckedBackColor = System.Drawing.Color.AliceBlue;
            chkWorkSwActiveLow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            chkWorkSwActiveLow.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            chkWorkSwActiveLow.ForeColor = System.Drawing.SystemColors.ControlText;
            chkWorkSwActiveLow.Image = Properties.Resources.SwitchActiveClosed;
            chkWorkSwActiveLow.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            chkWorkSwActiveLow.Location = new System.Drawing.Point(38, 373);
            chkWorkSwActiveLow.Name = "chkWorkSwActiveLow";
            chkWorkSwActiveLow.Size = new System.Drawing.Size(238, 71);
            chkWorkSwActiveLow.TabIndex = 0;
            chkWorkSwActiveLow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            chkWorkSwActiveLow.UseVisualStyleBackColor = false;
            chkWorkSwActiveLow.Click += chkWorkSwActiveLow_Click;
            // 
            // tabTSettings
            // 
            tabTSettings.BackColor = System.Drawing.Color.WhiteSmoke;
            tabTSettings.Controls.Add(labelLookAheadTiming);
            tabTSettings.Controls.Add(labelOnTime);
            tabTSettings.Controls.Add(labelOffTime);
            tabTSettings.Controls.Add(labelDelayTime);
            tabTSettings.Controls.Add(nudLookAheadOff);
            tabTSettings.Controls.Add(nudTurnOffDelay);
            tabTSettings.Controls.Add(nudLookAhead);
            tabTSettings.Controls.Add(pictureBox18);
            tabTSettings.Controls.Add(pictureBox4);
            tabTSettings.Controls.Add(pictureBox3);
            tabTSettings.ForeColor = System.Drawing.SystemColors.ButtonFace;
            tabTSettings.Location = new System.Drawing.Point(4, 44);
            tabTSettings.Name = "tabTSettings";
            tabTSettings.Size = new System.Drawing.Size(859, 584);
            tabTSettings.TabIndex = 10;
            tabTSettings.Text = "TSettings";
            tabTSettings.Enter += tabTSettings_Enter;
            tabTSettings.Leave += tabTSettings_Leave;
            // 
            // labelLookAheadTiming
            // 
            labelLookAheadTiming.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelLookAheadTiming.BackColor = System.Drawing.Color.Transparent;
            labelLookAheadTiming.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelLookAheadTiming.ForeColor = System.Drawing.Color.Black;
            labelLookAheadTiming.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            labelLookAheadTiming.Location = new System.Drawing.Point(62, 31);
            labelLookAheadTiming.Name = "labelLookAheadTiming";
            labelLookAheadTiming.Size = new System.Drawing.Size(707, 33);
            labelLookAheadTiming.TabIndex = 134;
            labelLookAheadTiming.Text = "Look Ahead Time Settings";
            labelLookAheadTiming.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelOnTime
            // 
            labelOnTime.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelOnTime.BackColor = System.Drawing.Color.Transparent;
            labelOnTime.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelOnTime.ForeColor = System.Drawing.Color.Black;
            labelOnTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            labelOnTime.Location = new System.Drawing.Point(0, 528);
            labelOnTime.Name = "labelOnTime";
            labelOnTime.Size = new System.Drawing.Size(279, 39);
            labelOnTime.TabIndex = 131;
            labelOnTime.Text = "On (secs)";
            labelOnTime.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelOffTime
            // 
            labelOffTime.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelOffTime.BackColor = System.Drawing.Color.Transparent;
            labelOffTime.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelOffTime.ForeColor = System.Drawing.Color.Black;
            labelOffTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            labelOffTime.Location = new System.Drawing.Point(287, 528);
            labelOffTime.Name = "labelOffTime";
            labelOffTime.Size = new System.Drawing.Size(279, 39);
            labelOffTime.TabIndex = 130;
            labelOffTime.Text = "Off (secs)";
            labelOffTime.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelDelayTime
            // 
            labelDelayTime.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelDelayTime.BackColor = System.Drawing.Color.Transparent;
            labelDelayTime.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelDelayTime.ForeColor = System.Drawing.Color.Black;
            labelDelayTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            labelDelayTime.Location = new System.Drawing.Point(582, 528);
            labelDelayTime.Name = "labelDelayTime";
            labelDelayTime.Size = new System.Drawing.Size(271, 39);
            labelDelayTime.TabIndex = 129;
            labelDelayTime.Text = "Turn Off Delay (secs)";
            labelDelayTime.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nudLookAheadOff
            // 
            nudLookAheadOff.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            nudLookAheadOff.BackColor = System.Drawing.Color.AliceBlue;
            nudLookAheadOff.DecimalPlaces = 1;
            nudLookAheadOff.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            nudLookAheadOff.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nudLookAheadOff.InterceptArrowKeys = false;
            nudLookAheadOff.Location = new System.Drawing.Point(363, 467);
            nudLookAheadOff.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            nudLookAheadOff.Name = "nudLookAheadOff";
            nudLookAheadOff.ReadOnly = true;
            nudLookAheadOff.Size = new System.Drawing.Size(114, 52);
            nudLookAheadOff.TabIndex = 124;
            nudLookAheadOff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudLookAheadOff.Value = new decimal(new int[] { 5, 0, 0, 65536 });
            nudLookAheadOff.Click += nudLookAheadOff_Click;
            // 
            // nudTurnOffDelay
            // 
            nudTurnOffDelay.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            nudTurnOffDelay.BackColor = System.Drawing.Color.AliceBlue;
            nudTurnOffDelay.DecimalPlaces = 1;
            nudTurnOffDelay.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            nudTurnOffDelay.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nudTurnOffDelay.InterceptArrowKeys = false;
            nudTurnOffDelay.Location = new System.Drawing.Point(649, 467);
            nudTurnOffDelay.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudTurnOffDelay.Name = "nudTurnOffDelay";
            nudTurnOffDelay.ReadOnly = true;
            nudTurnOffDelay.Size = new System.Drawing.Size(114, 52);
            nudTurnOffDelay.TabIndex = 119;
            nudTurnOffDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudTurnOffDelay.Value = new decimal(new int[] { 0, 0, 0, 0 });
            nudTurnOffDelay.Click += nudTurnOffDelay_Click;
            // 
            // nudLookAhead
            // 
            nudLookAhead.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            nudLookAhead.BackColor = System.Drawing.Color.AliceBlue;
            nudLookAhead.DecimalPlaces = 1;
            nudLookAhead.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            nudLookAhead.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nudLookAhead.InterceptArrowKeys = false;
            nudLookAhead.Location = new System.Drawing.Point(78, 467);
            nudLookAhead.Maximum = new decimal(new int[] { 22, 0, 0, 0 });
            nudLookAhead.Minimum = new decimal(new int[] { 2, 0, 0, 65536 });
            nudLookAhead.Name = "nudLookAhead";
            nudLookAhead.ReadOnly = true;
            nudLookAhead.Size = new System.Drawing.Size(114, 52);
            nudLookAhead.TabIndex = 117;
            nudLookAhead.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudLookAhead.Value = new decimal(new int[] { 10, 0, 0, 65536 });
            nudLookAhead.Click += nudLookAhead_Click;
            // 
            // pictureBox18
            // 
            pictureBox18.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            pictureBox18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pictureBox18.Image = Properties.Resources.SectionLookAheadDelay;
            pictureBox18.Location = new System.Drawing.Point(574, 108);
            pictureBox18.Name = "pictureBox18";
            pictureBox18.Size = new System.Drawing.Size(279, 353);
            pictureBox18.TabIndex = 133;
            pictureBox18.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pictureBox4.Image = Properties.Resources.SectionLookAheadOff;
            pictureBox4.Location = new System.Drawing.Point(287, 108);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new System.Drawing.Size(279, 353);
            pictureBox4.TabIndex = 132;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pictureBox3.Image = Properties.Resources.SectionOnLookAhead;
            pictureBox3.Location = new System.Drawing.Point(0, 108);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(279, 353);
            pictureBox3.TabIndex = 127;
            pictureBox3.TabStop = false;
            // 
            // tabDHeading
            // 
            tabDHeading.BackColor = System.Drawing.Color.WhiteSmoke;
            tabDHeading.Controls.Add(labelFixAlarmStop);
            tabDHeading.Controls.Add(label118);
            tabDHeading.Controls.Add(label113);
            tabDHeading.Controls.Add(labelFixAlarm);
            tabDHeading.Controls.Add(labelGboxDual);
            tabDHeading.Controls.Add(labelGboxSingle);
            tabDHeading.Controls.Add(headingGroupBox);
            tabDHeading.Controls.Add(nudFixJumpDistance);
            tabDHeading.Controls.Add(cboxIsRTK_KillAutoSteer);
            tabDHeading.Controls.Add(cboxIsRTK);
            tabDHeading.Location = new System.Drawing.Point(4, 44);
            tabDHeading.Name = "tabDHeading";
            tabDHeading.Size = new System.Drawing.Size(859, 584);
            tabDHeading.TabIndex = 15;
            tabDHeading.Text = "dHead";
            tabDHeading.Enter += tabDHeading_Enter;
            tabDHeading.Leave += tabDHeading_Leave;
            // 
            // labelFixAlarmStop
            // 
            labelFixAlarmStop.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelFixAlarmStop.BackColor = System.Drawing.Color.Transparent;
            labelFixAlarmStop.Font = new System.Drawing.Font("Tahoma", 14.25F);
            labelFixAlarmStop.ForeColor = System.Drawing.Color.Black;
            labelFixAlarmStop.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            labelFixAlarmStop.Location = new System.Drawing.Point(200, 438);
            labelFixAlarmStop.Name = "labelFixAlarmStop";
            labelFixAlarmStop.Size = new System.Drawing.Size(142, 53);
            labelFixAlarmStop.TabIndex = 478;
            labelFixAlarmStop.Text = "Alarm Stops Autosteer";
            labelFixAlarmStop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label118
            // 
            label118.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label118.BackColor = System.Drawing.Color.Transparent;
            label118.Font = new System.Drawing.Font("Tahoma", 14.25F);
            label118.ForeColor = System.Drawing.Color.Black;
            label118.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label118.Location = new System.Drawing.Point(965, 338);
            label118.Name = "label118";
            label118.Size = new System.Drawing.Size(144, 29);
            label118.TabIndex = 476;
            label118.Text = "0 to Disable";
            label118.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label113
            // 
            label113.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label113.BackColor = System.Drawing.Color.Transparent;
            label113.Font = new System.Drawing.Font("Tahoma", 14.25F);
            label113.ForeColor = System.Drawing.Color.Black;
            label113.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label113.Location = new System.Drawing.Point(961, 226);
            label113.Name = "label113";
            label113.Size = new System.Drawing.Size(152, 47);
            label113.TabIndex = 475;
            label113.Text = "Fix Jump Distance (cm) ";
            label113.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFixAlarm
            // 
            labelFixAlarm.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelFixAlarm.BackColor = System.Drawing.Color.Transparent;
            labelFixAlarm.Font = new System.Drawing.Font("Tahoma", 14.25F);
            labelFixAlarm.ForeColor = System.Drawing.Color.Black;
            labelFixAlarm.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            labelFixAlarm.Location = new System.Drawing.Point(47, 465);
            labelFixAlarm.Name = "labelFixAlarm";
            labelFixAlarm.Size = new System.Drawing.Size(127, 28);
            labelFixAlarm.TabIndex = 471;
            labelFixAlarm.Text = "RTK Fix Alarm";
            labelFixAlarm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelGboxDual
            // 
            labelGboxDual.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelGboxDual.BackColor = System.Drawing.Color.WhiteSmoke;
            labelGboxDual.Controls.Add(labelAutoSwitchDualFixSpeed);
            labelGboxDual.Controls.Add(nudAutoSwitchDualFixSpeed);
            labelGboxDual.Controls.Add(cboxIsAutoSwitchDualFixOn);
            labelGboxDual.Controls.Add(labelReverseDistance);
            labelGboxDual.Controls.Add(nudDualReverseDistance);
            labelGboxDual.Controls.Add(pictureBox13);
            labelGboxDual.Controls.Add(nudDualHeadingOffset);
            labelGboxDual.Controls.Add(labelHeadingOffset);
            labelGboxDual.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelGboxDual.Location = new System.Drawing.Point(3, 116);
            labelGboxDual.Name = "labelGboxDual";
            labelGboxDual.Size = new System.Drawing.Size(385, 304);
            labelGboxDual.TabIndex = 471;
            labelGboxDual.TabStop = false;
            labelGboxDual.Text = "Dual Antenna Settings";
            // 
            // labelAutoSwitchDualFixSpeed
            // 
            labelAutoSwitchDualFixSpeed.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelAutoSwitchDualFixSpeed.AutoSize = true;
            labelAutoSwitchDualFixSpeed.BackColor = System.Drawing.Color.Transparent;
            labelAutoSwitchDualFixSpeed.Font = new System.Drawing.Font("Tahoma", 14.25F);
            labelAutoSwitchDualFixSpeed.ForeColor = System.Drawing.Color.Black;
            labelAutoSwitchDualFixSpeed.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            labelAutoSwitchDualFixSpeed.Location = new System.Drawing.Point(15, 265);
            labelAutoSwitchDualFixSpeed.Name = "labelAutoSwitchDualFixSpeed";
            labelAutoSwitchDualFixSpeed.Size = new System.Drawing.Size(121, 23);
            labelAutoSwitchDualFixSpeed.TabIndex = 485;
            labelAutoSwitchDualFixSpeed.Text = "Switch speed";
            labelAutoSwitchDualFixSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudAutoSwitchDualFixSpeed
            // 
            nudAutoSwitchDualFixSpeed.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            nudAutoSwitchDualFixSpeed.BackColor = System.Drawing.Color.AliceBlue;
            nudAutoSwitchDualFixSpeed.DecimalPlaces = 1;
            nudAutoSwitchDualFixSpeed.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            nudAutoSwitchDualFixSpeed.InterceptArrowKeys = false;
            nudAutoSwitchDualFixSpeed.Location = new System.Drawing.Point(242, 260);
            nudAutoSwitchDualFixSpeed.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudAutoSwitchDualFixSpeed.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudAutoSwitchDualFixSpeed.Name = "nudAutoSwitchDualFixSpeed";
            nudAutoSwitchDualFixSpeed.ReadOnly = true;
            nudAutoSwitchDualFixSpeed.Size = new System.Drawing.Size(97, 33);
            nudAutoSwitchDualFixSpeed.TabIndex = 484;
            nudAutoSwitchDualFixSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudAutoSwitchDualFixSpeed.Value = new decimal(new int[] { 2, 0, 0, 0 });
            nudAutoSwitchDualFixSpeed.Click += nudAutoSwitchDualFixSpeed_Click;
            // 
            // cboxIsAutoSwitchDualFixOn
            // 
            cboxIsAutoSwitchDualFixOn.Appearance = System.Windows.Forms.Appearance.Button;
            cboxIsAutoSwitchDualFixOn.BackColor = System.Drawing.SystemColors.Control;
            cboxIsAutoSwitchDualFixOn.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            cboxIsAutoSwitchDualFixOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboxIsAutoSwitchDualFixOn.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            cboxIsAutoSwitchDualFixOn.ForeColor = System.Drawing.SystemColors.ControlText;
            cboxIsAutoSwitchDualFixOn.Location = new System.Drawing.Point(15, 215);
            cboxIsAutoSwitchDualFixOn.Name = "cboxIsAutoSwitchDualFixOn";
            cboxIsAutoSwitchDualFixOn.Size = new System.Drawing.Size(326, 33);
            cboxIsAutoSwitchDualFixOn.TabIndex = 483;
            cboxIsAutoSwitchDualFixOn.Text = "Auto Dual <-> Fix";
            cboxIsAutoSwitchDualFixOn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            cboxIsAutoSwitchDualFixOn.UseVisualStyleBackColor = false;
            cboxIsAutoSwitchDualFixOn.CheckedChanged += cboxIsAutoSwitchDualFixOn_CheckedChanged;
            // 
            // labelReverseDistance
            // 
            labelReverseDistance.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelReverseDistance.BackColor = System.Drawing.Color.Transparent;
            labelReverseDistance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelReverseDistance.ForeColor = System.Drawing.Color.Black;
            labelReverseDistance.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            labelReverseDistance.Location = new System.Drawing.Point(159, 122);
            labelReverseDistance.Name = "labelReverseDistance";
            labelReverseDistance.Size = new System.Drawing.Size(226, 23);
            labelReverseDistance.TabIndex = 473;
            labelReverseDistance.Text = "Reverse Distance (m)";
            labelReverseDistance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudDualReverseDistance
            // 
            nudDualReverseDistance.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            nudDualReverseDistance.AutoSize = true;
            nudDualReverseDistance.BackColor = System.Drawing.Color.AliceBlue;
            nudDualReverseDistance.DecimalPlaces = 2;
            nudDualReverseDistance.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            nudDualReverseDistance.InterceptArrowKeys = false;
            nudDualReverseDistance.Location = new System.Drawing.Point(197, 148);
            nudDualReverseDistance.Maximum = new decimal(new int[] { 9, 0, 0, 65536 });
            nudDualReverseDistance.Minimum = new decimal(new int[] { 1, 0, 0, 65536 });
            nudDualReverseDistance.Name = "nudDualReverseDistance";
            nudDualReverseDistance.ReadOnly = true;
            nudDualReverseDistance.Size = new System.Drawing.Size(144, 52);
            nudDualReverseDistance.TabIndex = 472;
            nudDualReverseDistance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudDualReverseDistance.Value = new decimal(new int[] { 1, 0, 0, 65536 });
            nudDualReverseDistance.Click += nudDualReverseDistance_Click;
            // 
            // pictureBox13
            // 
            pictureBox13.BackgroundImage = Properties.Resources.Con_SourcesHead;
            pictureBox13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pictureBox13.Location = new System.Drawing.Point(19, 52);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new System.Drawing.Size(130, 109);
            pictureBox13.TabIndex = 471;
            pictureBox13.TabStop = false;
            // 
            // nudDualHeadingOffset
            // 
            nudDualHeadingOffset.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            nudDualHeadingOffset.AutoSize = true;
            nudDualHeadingOffset.BackColor = System.Drawing.Color.AliceBlue;
            nudDualHeadingOffset.DecimalPlaces = 1;
            nudDualHeadingOffset.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            nudDualHeadingOffset.InterceptArrowKeys = false;
            nudDualHeadingOffset.Location = new System.Drawing.Point(197, 67);
            nudDualHeadingOffset.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            nudDualHeadingOffset.Name = "nudDualHeadingOffset";
            nudDualHeadingOffset.ReadOnly = true;
            nudDualHeadingOffset.Size = new System.Drawing.Size(144, 52);
            nudDualHeadingOffset.TabIndex = 470;
            nudDualHeadingOffset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudDualHeadingOffset.Value = new decimal(new int[] { 999, 0, 0, -2147418112 });
            nudDualHeadingOffset.Click += nudDualHeadingOffset_Click;
            // 
            // labelHeadingOffset
            // 
            labelHeadingOffset.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelHeadingOffset.BackColor = System.Drawing.Color.Transparent;
            labelHeadingOffset.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelHeadingOffset.ForeColor = System.Drawing.Color.Black;
            labelHeadingOffset.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            labelHeadingOffset.Location = new System.Drawing.Point(155, 41);
            labelHeadingOffset.Name = "labelHeadingOffset";
            labelHeadingOffset.Size = new System.Drawing.Size(230, 23);
            labelHeadingOffset.TabIndex = 469;
            labelHeadingOffset.Text = "Heading Offset (Degree)";
            labelHeadingOffset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelGboxSingle
            // 
            labelGboxSingle.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelGboxSingle.Controls.Add(lblHeadingDistance);
            labelGboxSingle.Controls.Add(cboxMinGPSStep);
            labelGboxSingle.Controls.Add(labelDefault70);
            labelGboxSingle.Controls.Add(lblFusionIMU);
            labelGboxSingle.Controls.Add(lblIMU);
            labelGboxSingle.Controls.Add(lblGPS);
            labelGboxSingle.Controls.Add(hsbarFusion);
            labelGboxSingle.Controls.Add(lblFusion);
            labelGboxSingle.Controls.Add(labelIMUFusion);
            labelGboxSingle.Controls.Add(cboxIsReverseOn);
            labelGboxSingle.Controls.Add(labelFix2Fix);
            labelGboxSingle.Controls.Add(labelGpsStep);
            labelGboxSingle.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelGboxSingle.Location = new System.Drawing.Point(394, 116);
            labelGboxSingle.Name = "labelGboxSingle";
            labelGboxSingle.Size = new System.Drawing.Size(446, 451);
            labelGboxSingle.TabIndex = 308;
            labelGboxSingle.TabStop = false;
            labelGboxSingle.Text = "Single Antenna Settings";
            // 
            // lblHeadingDistance
            // 
            lblHeadingDistance.AutoSize = true;
            lblHeadingDistance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblHeadingDistance.ForeColor = System.Drawing.Color.Black;
            lblHeadingDistance.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            lblHeadingDistance.Location = new System.Drawing.Point(192, 132);
            lblHeadingDistance.Name = "lblHeadingDistance";
            lblHeadingDistance.Size = new System.Drawing.Size(25, 25);
            lblHeadingDistance.TabIndex = 482;
            lblHeadingDistance.Text = "1";
            lblHeadingDistance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboxMinGPSStep
            // 
            cboxMinGPSStep.Appearance = System.Windows.Forms.Appearance.Button;
            cboxMinGPSStep.BackColor = System.Drawing.Color.AliceBlue;
            cboxMinGPSStep.Checked = true;
            cboxMinGPSStep.CheckState = System.Windows.Forms.CheckState.Checked;
            cboxMinGPSStep.FlatAppearance.CheckedBackColor = System.Drawing.Color.AliceBlue;
            cboxMinGPSStep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboxMinGPSStep.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cboxMinGPSStep.ForeColor = System.Drawing.Color.Black;
            cboxMinGPSStep.Location = new System.Drawing.Point(109, 52);
            cboxMinGPSStep.Name = "cboxMinGPSStep";
            cboxMinGPSStep.Size = new System.Drawing.Size(190, 39);
            cboxMinGPSStep.TabIndex = 480;
            cboxMinGPSStep.Text = "10 cm";
            cboxMinGPSStep.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            cboxMinGPSStep.UseVisualStyleBackColor = false;
            cboxMinGPSStep.CheckedChanged += cboxMinGPSStep_CheckedChanged;
            // 
            // labelDefault70
            // 
            labelDefault70.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelDefault70.ForeColor = System.Drawing.Color.Black;
            labelDefault70.Location = new System.Drawing.Point(109, 296);
            labelDefault70.Name = "labelDefault70";
            labelDefault70.Size = new System.Drawing.Size(235, 23);
            labelDefault70.TabIndex = 479;
            labelDefault70.Text = "Default: 70%";
            labelDefault70.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFusionIMU
            // 
            lblFusionIMU.AutoSize = true;
            lblFusionIMU.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblFusionIMU.ForeColor = System.Drawing.Color.Black;
            lblFusionIMU.Location = new System.Drawing.Point(12, 240);
            lblFusionIMU.Name = "lblFusionIMU";
            lblFusionIMU.Size = new System.Drawing.Size(95, 39);
            lblFusionIMU.TabIndex = 476;
            lblFusionIMU.Text = "90%";
            // 
            // lblIMU
            // 
            lblIMU.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblIMU.ForeColor = System.Drawing.Color.ForestGreen;
            lblIMU.Location = new System.Drawing.Point(59, 203);
            lblIMU.Name = "lblIMU";
            lblIMU.Size = new System.Drawing.Size(76, 23);
            lblIMU.TabIndex = 475;
            lblIMU.Text = "IMU <";
            lblIMU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGPS
            // 
            lblGPS.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblGPS.ForeColor = System.Drawing.Color.Red;
            lblGPS.Location = new System.Drawing.Point(319, 203);
            lblGPS.Name = "lblGPS";
            lblGPS.Size = new System.Drawing.Size(69, 23);
            lblGPS.TabIndex = 474;
            lblGPS.Text = "> GPS";
            lblGPS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hsbarFusion
            // 
            hsbarFusion.LargeChange = 1;
            hsbarFusion.Location = new System.Drawing.Point(109, 233);
            hsbarFusion.Maximum = 60;
            hsbarFusion.Minimum = 5;
            hsbarFusion.Name = "hsbarFusion";
            hsbarFusion.Size = new System.Drawing.Size(235, 58);
            hsbarFusion.TabIndex = 471;
            hsbarFusion.Value = 30;
            hsbarFusion.ValueChanged += hsbarFusion_ValueChanged;
            // 
            // lblFusion
            // 
            lblFusion.AutoSize = true;
            lblFusion.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblFusion.ForeColor = System.Drawing.Color.Black;
            lblFusion.Location = new System.Drawing.Point(349, 240);
            lblFusion.Name = "lblFusion";
            lblFusion.Size = new System.Drawing.Size(95, 39);
            lblFusion.TabIndex = 473;
            lblFusion.Text = "30%";
            // 
            // labelIMUFusion
            // 
            labelIMUFusion.AutoSize = true;
            labelIMUFusion.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelIMUFusion.ForeColor = System.Drawing.Color.Black;
            labelIMUFusion.Location = new System.Drawing.Point(203, 203);
            labelIMUFusion.Name = "labelIMUFusion";
            labelIMUFusion.Size = new System.Drawing.Size(72, 25);
            labelIMUFusion.TabIndex = 472;
            labelIMUFusion.Text = "Fusion";
            labelIMUFusion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboxIsReverseOn
            // 
            cboxIsReverseOn.Appearance = System.Windows.Forms.Appearance.Button;
            cboxIsReverseOn.BackColor = System.Drawing.Color.AliceBlue;
            cboxIsReverseOn.Checked = true;
            cboxIsReverseOn.CheckState = System.Windows.Forms.CheckState.Checked;
            cboxIsReverseOn.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            cboxIsReverseOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboxIsReverseOn.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cboxIsReverseOn.ForeColor = System.Drawing.Color.Black;
            cboxIsReverseOn.Location = new System.Drawing.Point(118, 372);
            cboxIsReverseOn.Name = "cboxIsReverseOn";
            cboxIsReverseOn.Size = new System.Drawing.Size(226, 52);
            cboxIsReverseOn.TabIndex = 465;
            cboxIsReverseOn.Text = "Reverse Detection";
            cboxIsReverseOn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            cboxIsReverseOn.UseVisualStyleBackColor = false;
            // 
            // labelFix2Fix
            // 
            labelFix2Fix.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelFix2Fix.ForeColor = System.Drawing.Color.Black;
            labelFix2Fix.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            labelFix2Fix.Location = new System.Drawing.Point(83, 102);
            labelFix2Fix.Name = "labelFix2Fix";
            labelFix2Fix.Size = new System.Drawing.Size(237, 23);
            labelFix2Fix.TabIndex = 481;
            labelFix2Fix.Text = "Fix To Fix Distance";
            labelFix2Fix.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelGpsStep
            // 
            labelGpsStep.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelGpsStep.ForeColor = System.Drawing.Color.Black;
            labelGpsStep.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            labelGpsStep.Location = new System.Drawing.Point(63, 29);
            labelGpsStep.Name = "labelGpsStep";
            labelGpsStep.Size = new System.Drawing.Size(292, 23);
            labelGpsStep.TabIndex = 478;
            labelGpsStep.Text = "Minimum GPS Step";
            labelGpsStep.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // headingGroupBox
            // 
            headingGroupBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            headingGroupBox.Controls.Add(rbtnHeadingHDT);
            headingGroupBox.Controls.Add(rbtnHeadingFix);
            headingGroupBox.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            headingGroupBox.ForeColor = System.Drawing.Color.Black;
            headingGroupBox.Location = new System.Drawing.Point(63, -26);
            headingGroupBox.Name = "headingGroupBox";
            headingGroupBox.Size = new System.Drawing.Size(515, 132);
            headingGroupBox.TabIndex = 85;
            headingGroupBox.TabStop = false;
            headingGroupBox.Text = "Antenna Type";
            // 
            // rbtnHeadingHDT
            // 
            rbtnHeadingHDT.Appearance = System.Windows.Forms.Appearance.Button;
            rbtnHeadingHDT.BackColor = System.Drawing.Color.AliceBlue;
            rbtnHeadingHDT.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            rbtnHeadingHDT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rbtnHeadingHDT.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            rbtnHeadingHDT.ForeColor = System.Drawing.Color.Black;
            rbtnHeadingHDT.Image = Properties.Resources.Con_SourcesGPSDual;
            rbtnHeadingHDT.Location = new System.Drawing.Point(6, 44);
            rbtnHeadingHDT.Name = "rbtnHeadingHDT";
            rbtnHeadingHDT.Size = new System.Drawing.Size(117, 82);
            rbtnHeadingHDT.TabIndex = 2;
            rbtnHeadingHDT.Text = "Dual";
            rbtnHeadingHDT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            rbtnHeadingHDT.UseVisualStyleBackColor = false;
            rbtnHeadingHDT.CheckedChanged += rbtnHeadingFix_CheckedChanged;
            // 
            // rbtnHeadingFix
            // 
            rbtnHeadingFix.Appearance = System.Windows.Forms.Appearance.Button;
            rbtnHeadingFix.BackColor = System.Drawing.Color.AliceBlue;
            rbtnHeadingFix.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            rbtnHeadingFix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rbtnHeadingFix.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            rbtnHeadingFix.ForeColor = System.Drawing.Color.Black;
            rbtnHeadingFix.Image = Properties.Resources.Con_SourcesGPSSingle;
            rbtnHeadingFix.Location = new System.Drawing.Point(387, 44);
            rbtnHeadingFix.Name = "rbtnHeadingFix";
            rbtnHeadingFix.Size = new System.Drawing.Size(117, 82);
            rbtnHeadingFix.TabIndex = 0;
            rbtnHeadingFix.Text = "Fix";
            rbtnHeadingFix.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            rbtnHeadingFix.UseVisualStyleBackColor = false;
            rbtnHeadingFix.CheckedChanged += rbtnHeadingFix_CheckedChanged;
            // 
            // nudFixJumpDistance
            // 
            nudFixJumpDistance.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            nudFixJumpDistance.AutoSize = true;
            nudFixJumpDistance.BackColor = System.Drawing.Color.AliceBlue;
            nudFixJumpDistance.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            nudFixJumpDistance.InterceptArrowKeys = false;
            nudFixJumpDistance.Location = new System.Drawing.Point(965, 279);
            nudFixJumpDistance.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudFixJumpDistance.Name = "nudFixJumpDistance";
            nudFixJumpDistance.ReadOnly = true;
            nudFixJumpDistance.Size = new System.Drawing.Size(144, 52);
            nudFixJumpDistance.TabIndex = 474;
            nudFixJumpDistance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudFixJumpDistance.Value = new decimal(new int[] { 0, 0, 0, 0 });
            nudFixJumpDistance.Click += nudFixJumpDistance_Click;
            // 
            // cboxIsRTK_KillAutoSteer
            // 
            cboxIsRTK_KillAutoSteer.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            cboxIsRTK_KillAutoSteer.Appearance = System.Windows.Forms.Appearance.Button;
            cboxIsRTK_KillAutoSteer.BackColor = System.Drawing.Color.AliceBlue;
            cboxIsRTK_KillAutoSteer.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            cboxIsRTK_KillAutoSteer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboxIsRTK_KillAutoSteer.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cboxIsRTK_KillAutoSteer.ForeColor = System.Drawing.Color.Black;
            cboxIsRTK_KillAutoSteer.Image = Properties.Resources.AutoSteerOff;
            cboxIsRTK_KillAutoSteer.Location = new System.Drawing.Point(218, 494);
            cboxIsRTK_KillAutoSteer.Name = "cboxIsRTK_KillAutoSteer";
            cboxIsRTK_KillAutoSteer.Size = new System.Drawing.Size(103, 69);
            cboxIsRTK_KillAutoSteer.TabIndex = 477;
            cboxIsRTK_KillAutoSteer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            cboxIsRTK_KillAutoSteer.UseVisualStyleBackColor = false;
            // 
            // cboxIsRTK
            // 
            cboxIsRTK.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            cboxIsRTK.Appearance = System.Windows.Forms.Appearance.Button;
            cboxIsRTK.BackColor = System.Drawing.Color.AliceBlue;
            cboxIsRTK.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            cboxIsRTK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboxIsRTK.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cboxIsRTK.ForeColor = System.Drawing.Color.Black;
            cboxIsRTK.Image = Properties.Resources.Con_SourcesRTKAlarm;
            cboxIsRTK.Location = new System.Drawing.Point(59, 494);
            cboxIsRTK.Name = "cboxIsRTK";
            cboxIsRTK.Size = new System.Drawing.Size(103, 69);
            cboxIsRTK.TabIndex = 309;
            cboxIsRTK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            cboxIsRTK.UseVisualStyleBackColor = false;
            // 
            // tabDRoll
            // 
            tabDRoll.BackColor = System.Drawing.Color.WhiteSmoke;
            tabDRoll.Controls.Add(btnRollOffsetUp);
            tabDRoll.Controls.Add(btnRollOffsetDown);
            tabDRoll.Controls.Add(pictureBox9);
            tabDRoll.Controls.Add(labelInvertRoll);
            tabDRoll.Controls.Add(labelZeroRoll);
            tabDRoll.Controls.Add(labelRemoveOffset);
            tabDRoll.Controls.Add(lblRollZeroOffset);
            tabDRoll.Controls.Add(labelLess);
            tabDRoll.Controls.Add(labelMore);
            tabDRoll.Controls.Add(lblRollFilterPercent);
            tabDRoll.Controls.Add(labelRollFilter);
            tabDRoll.Controls.Add(hsbarRollFilter);
            tabDRoll.Controls.Add(btnResetIMU);
            tabDRoll.Controls.Add(btnZeroRoll);
            tabDRoll.Controls.Add(btnRemoveZeroOffset);
            tabDRoll.Controls.Add(cboxDataInvertRoll);
            tabDRoll.ForeColor = System.Drawing.SystemColors.ButtonFace;
            tabDRoll.Location = new System.Drawing.Point(4, 44);
            tabDRoll.Name = "tabDRoll";
            tabDRoll.Size = new System.Drawing.Size(859, 584);
            tabDRoll.TabIndex = 16;
            tabDRoll.Text = "dRoll";
            tabDRoll.Enter += tabDRoll_Enter;
            tabDRoll.Leave += tabDRoll_Leave;
            // 
            // btnRollOffsetUp
            // 
            btnRollOffsetUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnRollOffsetUp.FlatAppearance.BorderSize = 0;
            btnRollOffsetUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRollOffsetUp.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnRollOffsetUp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            btnRollOffsetUp.Image = Properties.Resources.UpArrow64;
            btnRollOffsetUp.Location = new System.Drawing.Point(416, 214);
            btnRollOffsetUp.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            btnRollOffsetUp.Name = "btnRollOffsetUp";
            btnRollOffsetUp.Size = new System.Drawing.Size(59, 69);
            btnRollOffsetUp.TabIndex = 487;
            btnRollOffsetUp.UseVisualStyleBackColor = true;
            btnRollOffsetUp.Click += btnRollOffsetUp_Click;
            // 
            // btnRollOffsetDown
            // 
            btnRollOffsetDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnRollOffsetDown.FlatAppearance.BorderSize = 0;
            btnRollOffsetDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRollOffsetDown.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnRollOffsetDown.ForeColor = System.Drawing.SystemColors.ButtonFace;
            btnRollOffsetDown.Image = Properties.Resources.DnArrow64;
            btnRollOffsetDown.Location = new System.Drawing.Point(342, 215);
            btnRollOffsetDown.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            btnRollOffsetDown.Name = "btnRollOffsetDown";
            btnRollOffsetDown.Size = new System.Drawing.Size(59, 69);
            btnRollOffsetDown.TabIndex = 486;
            btnRollOffsetDown.UseVisualStyleBackColor = true;
            btnRollOffsetDown.Click += btnRollOffsetDown_Click;
            // 
            // pictureBox9
            // 
            pictureBox9.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            pictureBox9.BackColor = System.Drawing.Color.White;
            pictureBox9.BackgroundImage = Properties.Resources.ConD_RollHelper;
            pictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            pictureBox9.Location = new System.Drawing.Point(577, 343);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new System.Drawing.Size(154, 217);
            pictureBox9.TabIndex = 485;
            pictureBox9.TabStop = false;
            // 
            // labelInvertRoll
            // 
            labelInvertRoll.ForeColor = System.Drawing.Color.Black;
            labelInvertRoll.Location = new System.Drawing.Point(593, 182);
            labelInvertRoll.Name = "labelInvertRoll";
            labelInvertRoll.Size = new System.Drawing.Size(130, 16);
            labelInvertRoll.TabIndex = 484;
            labelInvertRoll.Text = "Invert Roll";
            // 
            // labelZeroRoll
            // 
            labelZeroRoll.ForeColor = System.Drawing.Color.Black;
            labelZeroRoll.Location = new System.Drawing.Point(86, 183);
            labelZeroRoll.Name = "labelZeroRoll";
            labelZeroRoll.Size = new System.Drawing.Size(130, 16);
            labelZeroRoll.TabIndex = 483;
            labelZeroRoll.Text = "Zero Roll";
            // 
            // labelRemoveOffset
            // 
            labelRemoveOffset.ForeColor = System.Drawing.Color.Black;
            labelRemoveOffset.Location = new System.Drawing.Point(86, 27);
            labelRemoveOffset.Name = "labelRemoveOffset";
            labelRemoveOffset.Size = new System.Drawing.Size(130, 16);
            labelRemoveOffset.TabIndex = 482;
            labelRemoveOffset.Text = "Remove Offset";
            // 
            // lblRollZeroOffset
            // 
            lblRollZeroOffset.AutoSize = true;
            lblRollZeroOffset.Font = new System.Drawing.Font("Tahoma", 20.25F);
            lblRollZeroOffset.ForeColor = System.Drawing.Color.Black;
            lblRollZeroOffset.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            lblRollZeroOffset.Location = new System.Drawing.Point(229, 230);
            lblRollZeroOffset.Name = "lblRollZeroOffset";
            lblRollZeroOffset.Size = new System.Drawing.Size(100, 33);
            lblRollZeroOffset.TabIndex = 75;
            lblRollZeroOffset.Text = "label11";
            // 
            // labelLess
            // 
            labelLess.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelLess.BackColor = System.Drawing.Color.Transparent;
            labelLess.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelLess.ForeColor = System.Drawing.Color.Black;
            labelLess.Location = new System.Drawing.Point(3, 428);
            labelLess.Name = "labelLess";
            labelLess.Size = new System.Drawing.Size(93, 23);
            labelLess.TabIndex = 347;
            labelLess.Text = "Less";
            labelLess.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelMore
            // 
            labelMore.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelMore.BackColor = System.Drawing.Color.Transparent;
            labelMore.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelMore.ForeColor = System.Drawing.Color.Black;
            labelMore.Location = new System.Drawing.Point(343, 428);
            labelMore.Name = "labelMore";
            labelMore.Size = new System.Drawing.Size(137, 23);
            labelMore.TabIndex = 346;
            labelMore.Text = "More";
            labelMore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRollFilterPercent
            // 
            lblRollFilterPercent.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblRollFilterPercent.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblRollFilterPercent.ForeColor = System.Drawing.Color.Black;
            lblRollFilterPercent.Location = new System.Drawing.Point(185, 505);
            lblRollFilterPercent.Name = "lblRollFilterPercent";
            lblRollFilterPercent.Size = new System.Drawing.Size(95, 39);
            lblRollFilterPercent.TabIndex = 344;
            lblRollFilterPercent.Text = "65%";
            // 
            // labelRollFilter
            // 
            labelRollFilter.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelRollFilter.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelRollFilter.ForeColor = System.Drawing.Color.Black;
            labelRollFilter.Location = new System.Drawing.Point(102, 428);
            labelRollFilter.Name = "labelRollFilter";
            labelRollFilter.Size = new System.Drawing.Size(237, 23);
            labelRollFilter.TabIndex = 345;
            labelRollFilter.Text = "Roll Filter";
            labelRollFilter.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // hsbarRollFilter
            // 
            hsbarRollFilter.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            hsbarRollFilter.LargeChange = 1;
            hsbarRollFilter.Location = new System.Drawing.Point(55, 454);
            hsbarRollFilter.Maximum = 98;
            hsbarRollFilter.Name = "hsbarRollFilter";
            hsbarRollFilter.Size = new System.Drawing.Size(335, 43);
            hsbarRollFilter.TabIndex = 343;
            hsbarRollFilter.Value = 5;
            hsbarRollFilter.ValueChanged += hsbarRollFilter_ValueChanged;
            // 
            // btnResetIMU
            // 
            btnResetIMU.BackColor = System.Drawing.Color.White;
            btnResetIMU.BackgroundImage = Properties.Resources.ConDa_ResetIMU;
            btnResetIMU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnResetIMU.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            btnResetIMU.FlatAppearance.CheckedBackColor = System.Drawing.Color.Teal;
            btnResetIMU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnResetIMU.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnResetIMU.ForeColor = System.Drawing.Color.Black;
            btnResetIMU.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnResetIMU.Location = new System.Drawing.Point(593, 45);
            btnResetIMU.Name = "btnResetIMU";
            btnResetIMU.Size = new System.Drawing.Size(130, 95);
            btnResetIMU.TabIndex = 85;
            btnResetIMU.UseVisualStyleBackColor = false;
            btnResetIMU.Click += btnResetIMU_Click;
            // 
            // btnZeroRoll
            // 
            btnZeroRoll.BackColor = System.Drawing.Color.White;
            btnZeroRoll.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            btnZeroRoll.FlatAppearance.CheckedBackColor = System.Drawing.Color.Teal;
            btnZeroRoll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnZeroRoll.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnZeroRoll.ForeColor = System.Drawing.Color.Black;
            btnZeroRoll.Image = Properties.Resources.ConDa_RollSetZero;
            btnZeroRoll.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnZeroRoll.Location = new System.Drawing.Point(86, 202);
            btnZeroRoll.Name = "btnZeroRoll";
            btnZeroRoll.Size = new System.Drawing.Size(130, 95);
            btnZeroRoll.TabIndex = 76;
            btnZeroRoll.UseVisualStyleBackColor = false;
            btnZeroRoll.Click += btnZeroRoll_Click;
            // 
            // btnRemoveZeroOffset
            // 
            btnRemoveZeroOffset.BackColor = System.Drawing.Color.White;
            btnRemoveZeroOffset.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            btnRemoveZeroOffset.FlatAppearance.CheckedBackColor = System.Drawing.Color.Teal;
            btnRemoveZeroOffset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRemoveZeroOffset.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnRemoveZeroOffset.ForeColor = System.Drawing.Color.Black;
            btnRemoveZeroOffset.Image = Properties.Resources.ConDa_RemoveOffset;
            btnRemoveZeroOffset.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnRemoveZeroOffset.Location = new System.Drawing.Point(86, 46);
            btnRemoveZeroOffset.Name = "btnRemoveZeroOffset";
            btnRemoveZeroOffset.Size = new System.Drawing.Size(130, 95);
            btnRemoveZeroOffset.TabIndex = 76;
            btnRemoveZeroOffset.UseVisualStyleBackColor = false;
            btnRemoveZeroOffset.Click += btnRemoveZeroOffset_Click;
            // 
            // cboxDataInvertRoll
            // 
            cboxDataInvertRoll.Appearance = System.Windows.Forms.Appearance.Button;
            cboxDataInvertRoll.BackColor = System.Drawing.Color.White;
            cboxDataInvertRoll.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            cboxDataInvertRoll.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            cboxDataInvertRoll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboxDataInvertRoll.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cboxDataInvertRoll.ForeColor = System.Drawing.Color.Black;
            cboxDataInvertRoll.Image = Properties.Resources.ConDa_InvertRoll;
            cboxDataInvertRoll.Location = new System.Drawing.Point(593, 201);
            cboxDataInvertRoll.Name = "cboxDataInvertRoll";
            cboxDataInvertRoll.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            cboxDataInvertRoll.Size = new System.Drawing.Size(130, 95);
            cboxDataInvertRoll.TabIndex = 452;
            cboxDataInvertRoll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            cboxDataInvertRoll.UseVisualStyleBackColor = false;
            // 
            // tabUTurn
            // 
            tabUTurn.BackColor = System.Drawing.Color.WhiteSmoke;
            tabUTurn.Controls.Add(labelUturnSmooth);
            tabUTurn.Controls.Add(labelUturnExtend);
            tabUTurn.Controls.Add(lblFtMTurnRadius);
            tabUTurn.Controls.Add(lblFtMUTurn);
            tabUTurn.Controls.Add(lblSmoothing);
            tabUTurn.Controls.Add(lblDistance);
            tabUTurn.Controls.Add(nudYouTurnRadius);
            tabUTurn.Controls.Add(nudTurnDistanceFromBoundary);
            tabUTurn.Controls.Add(label64);
            tabUTurn.Controls.Add(btnTurnSmoothingUp);
            tabUTurn.Controls.Add(btnTurnSmoothingDown);
            tabUTurn.Controls.Add(label59);
            tabUTurn.Controls.Add(label58);
            tabUTurn.Controls.Add(lblWhenTrig);
            tabUTurn.Controls.Add(btnDistanceUp);
            tabUTurn.Controls.Add(btnDistanceDn);
            tabUTurn.Location = new System.Drawing.Point(4, 44);
            tabUTurn.Name = "tabUTurn";
            tabUTurn.Size = new System.Drawing.Size(859, 584);
            tabUTurn.TabIndex = 18;
            tabUTurn.Text = "uTurn";
            tabUTurn.Enter += tabUTurn_Enter;
            tabUTurn.Leave += tabUTurn_Leave;
            // 
            // labelUturnSmooth
            // 
            labelUturnSmooth.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelUturnSmooth.ForeColor = System.Drawing.Color.Black;
            labelUturnSmooth.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            labelUturnSmooth.Location = new System.Drawing.Point(298, 389);
            labelUturnSmooth.Name = "labelUturnSmooth";
            labelUturnSmooth.Size = new System.Drawing.Size(170, 77);
            labelUturnSmooth.TabIndex = 474;
            labelUturnSmooth.Text = "Set Smoothing to 3 or 4x Radius";
            // 
            // labelUturnExtend
            // 
            labelUturnExtend.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelUturnExtend.ForeColor = System.Drawing.Color.Black;
            labelUturnExtend.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            labelUturnExtend.Location = new System.Drawing.Point(62, 389);
            labelUturnExtend.Name = "labelUturnExtend";
            labelUturnExtend.Size = new System.Drawing.Size(175, 82);
            labelUturnExtend.TabIndex = 473;
            labelUturnExtend.Text = "Set extension length to 2 or 3x Radius\r\n";
            // 
            // lblFtMTurnRadius
            // 
            lblFtMTurnRadius.AutoSize = true;
            lblFtMTurnRadius.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblFtMTurnRadius.ForeColor = System.Drawing.Color.Black;
            lblFtMTurnRadius.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            lblFtMTurnRadius.Location = new System.Drawing.Point(645, 209);
            lblFtMTurnRadius.Name = "lblFtMTurnRadius";
            lblFtMTurnRadius.Size = new System.Drawing.Size(36, 25);
            lblFtMTurnRadius.TabIndex = 472;
            lblFtMTurnRadius.Text = "FF";
            // 
            // lblFtMUTurn
            // 
            lblFtMUTurn.AutoSize = true;
            lblFtMUTurn.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblFtMUTurn.ForeColor = System.Drawing.Color.Black;
            lblFtMUTurn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            lblFtMUTurn.Location = new System.Drawing.Point(645, 489);
            lblFtMUTurn.Name = "lblFtMUTurn";
            lblFtMUTurn.Size = new System.Drawing.Size(36, 25);
            lblFtMUTurn.TabIndex = 469;
            lblFtMUTurn.Text = "FF";
            // 
            // lblSmoothing
            // 
            lblSmoothing.AutoSize = true;
            lblSmoothing.BackColor = System.Drawing.Color.Transparent;
            lblSmoothing.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblSmoothing.ForeColor = System.Drawing.Color.Black;
            lblSmoothing.Location = new System.Drawing.Point(323, 274);
            lblSmoothing.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblSmoothing.Name = "lblSmoothing";
            lblSmoothing.Size = new System.Drawing.Size(95, 45);
            lblSmoothing.TabIndex = 464;
            lblSmoothing.Text = "XXX";
            // 
            // lblDistance
            // 
            lblDistance.AutoSize = true;
            lblDistance.BackColor = System.Drawing.Color.Transparent;
            lblDistance.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblDistance.ForeColor = System.Drawing.Color.Black;
            lblDistance.Location = new System.Drawing.Point(96, 274);
            lblDistance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblDistance.Name = "lblDistance";
            lblDistance.Size = new System.Drawing.Size(95, 45);
            lblDistance.TabIndex = 455;
            lblDistance.Text = "XXX";
            // 
            // nudYouTurnRadius
            // 
            nudYouTurnRadius.BackColor = System.Drawing.Color.White;
            nudYouTurnRadius.DecimalPlaces = 2;
            nudYouTurnRadius.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            nudYouTurnRadius.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            nudYouTurnRadius.Increment = new decimal(new int[] { 2, 0, 0, 65536 });
            nudYouTurnRadius.InterceptArrowKeys = false;
            nudYouTurnRadius.Location = new System.Drawing.Point(582, 154);
            nudYouTurnRadius.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            nudYouTurnRadius.Name = "nudYouTurnRadius";
            nudYouTurnRadius.ReadOnly = true;
            nudYouTurnRadius.Size = new System.Drawing.Size(160, 52);
            nudYouTurnRadius.TabIndex = 471;
            nudYouTurnRadius.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudYouTurnRadius.Value = new decimal(new int[] { 2, 0, 0, 0 });
            nudYouTurnRadius.Click += nudYouTurnRadius_Click;
            // 
            // nudTurnDistanceFromBoundary
            // 
            nudTurnDistanceFromBoundary.BackColor = System.Drawing.Color.White;
            nudTurnDistanceFromBoundary.DecimalPlaces = 2;
            nudTurnDistanceFromBoundary.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            nudTurnDistanceFromBoundary.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            nudTurnDistanceFromBoundary.Increment = new decimal(new int[] { 2, 0, 0, 65536 });
            nudTurnDistanceFromBoundary.InterceptArrowKeys = false;
            nudTurnDistanceFromBoundary.Location = new System.Drawing.Point(582, 434);
            nudTurnDistanceFromBoundary.Name = "nudTurnDistanceFromBoundary";
            nudTurnDistanceFromBoundary.ReadOnly = true;
            nudTurnDistanceFromBoundary.Size = new System.Drawing.Size(160, 52);
            nudTurnDistanceFromBoundary.TabIndex = 468;
            nudTurnDistanceFromBoundary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudTurnDistanceFromBoundary.Value = new decimal(new int[] { 10, 0, 0, 65536 });
            nudTurnDistanceFromBoundary.Click += nudTurnDistanceFromBoundary_Click;
            nudTurnDistanceFromBoundary.Enter += nudTurnDistanceFromBoundary_Click;
            // 
            // label64
            // 
            label64.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label64.ForeColor = System.Drawing.SystemColors.ButtonFace;
            label64.Image = Properties.Resources.ConU_UturnRadius;
            label64.Location = new System.Drawing.Point(602, 27);
            label64.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label64.Name = "label64";
            label64.Size = new System.Drawing.Size(109, 107);
            label64.TabIndex = 470;
            label64.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnTurnSmoothingUp
            // 
            btnTurnSmoothingUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnTurnSmoothingUp.FlatAppearance.BorderSize = 0;
            btnTurnSmoothingUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnTurnSmoothingUp.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnTurnSmoothingUp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            btnTurnSmoothingUp.Image = Properties.Resources.UpArrow64;
            btnTurnSmoothingUp.Location = new System.Drawing.Point(387, 317);
            btnTurnSmoothingUp.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            btnTurnSmoothingUp.Name = "btnTurnSmoothingUp";
            btnTurnSmoothingUp.Size = new System.Drawing.Size(59, 69);
            btnTurnSmoothingUp.TabIndex = 466;
            btnTurnSmoothingUp.UseVisualStyleBackColor = true;
            btnTurnSmoothingUp.Click += btnTurnSmoothingUp_Click;
            // 
            // btnTurnSmoothingDown
            // 
            btnTurnSmoothingDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnTurnSmoothingDown.FlatAppearance.BorderSize = 0;
            btnTurnSmoothingDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnTurnSmoothingDown.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnTurnSmoothingDown.ForeColor = System.Drawing.SystemColors.ButtonFace;
            btnTurnSmoothingDown.Image = Properties.Resources.DnArrow64;
            btnTurnSmoothingDown.Location = new System.Drawing.Point(294, 317);
            btnTurnSmoothingDown.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            btnTurnSmoothingDown.Name = "btnTurnSmoothingDown";
            btnTurnSmoothingDown.Size = new System.Drawing.Size(59, 69);
            btnTurnSmoothingDown.TabIndex = 465;
            btnTurnSmoothingDown.UseVisualStyleBackColor = true;
            btnTurnSmoothingDown.Click += btnTurnSmoothingDown_Click;
            // 
            // label59
            // 
            label59.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label59.ForeColor = System.Drawing.SystemColors.ButtonFace;
            label59.Image = Properties.Resources.ConU_UTurnSmooth;
            label59.Location = new System.Drawing.Point(313, 141);
            label59.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label59.Name = "label59";
            label59.Size = new System.Drawing.Size(109, 120);
            label59.TabIndex = 467;
            label59.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label58
            // 
            label58.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label58.ForeColor = System.Drawing.SystemColors.ButtonFace;
            label58.Image = Properties.Resources.ConU_UturnDistance;
            label58.Location = new System.Drawing.Point(602, 308);
            label58.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label58.Name = "label58";
            label58.Size = new System.Drawing.Size(109, 119);
            label58.TabIndex = 463;
            label58.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblWhenTrig
            // 
            lblWhenTrig.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblWhenTrig.ForeColor = System.Drawing.SystemColors.ButtonFace;
            lblWhenTrig.Image = Properties.Resources.ConU_UturnLength;
            lblWhenTrig.Location = new System.Drawing.Point(84, 141);
            lblWhenTrig.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblWhenTrig.Name = "lblWhenTrig";
            lblWhenTrig.Size = new System.Drawing.Size(116, 133);
            lblWhenTrig.TabIndex = 458;
            lblWhenTrig.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnDistanceUp
            // 
            btnDistanceUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnDistanceUp.FlatAppearance.BorderSize = 0;
            btnDistanceUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDistanceUp.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnDistanceUp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            btnDistanceUp.Image = Properties.Resources.UpArrow64;
            btnDistanceUp.Location = new System.Drawing.Point(160, 317);
            btnDistanceUp.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            btnDistanceUp.Name = "btnDistanceUp";
            btnDistanceUp.Size = new System.Drawing.Size(59, 69);
            btnDistanceUp.TabIndex = 457;
            btnDistanceUp.UseVisualStyleBackColor = true;
            btnDistanceUp.Click += btnDistanceUp_Click;
            // 
            // btnDistanceDn
            // 
            btnDistanceDn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnDistanceDn.FlatAppearance.BorderSize = 0;
            btnDistanceDn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDistanceDn.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnDistanceDn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            btnDistanceDn.Image = Properties.Resources.DnArrow64;
            btnDistanceDn.Location = new System.Drawing.Point(67, 317);
            btnDistanceDn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            btnDistanceDn.Name = "btnDistanceDn";
            btnDistanceDn.Size = new System.Drawing.Size(59, 69);
            btnDistanceDn.TabIndex = 456;
            btnDistanceDn.UseVisualStyleBackColor = true;
            btnDistanceDn.Click += btnDistanceDn_Click;
            // 
            // tabRelay
            // 
            tabRelay.BackColor = System.Drawing.Color.WhiteSmoke;
            tabRelay.Controls.Add(cboxPin23);
            tabRelay.Controls.Add(cboxPin22);
            tabRelay.Controls.Add(cboxPin21);
            tabRelay.Controls.Add(cboxPin20);
            tabRelay.Controls.Add(label143);
            tabRelay.Controls.Add(label144);
            tabRelay.Controls.Add(label145);
            tabRelay.Controls.Add(label146);
            tabRelay.Controls.Add(cboxPin19);
            tabRelay.Controls.Add(cboxPin18);
            tabRelay.Controls.Add(cboxPin17);
            tabRelay.Controls.Add(cboxPin16);
            tabRelay.Controls.Add(cboxPin15);
            tabRelay.Controls.Add(cboxPin14);
            tabRelay.Controls.Add(cboxPin13);
            tabRelay.Controls.Add(cboxPin12);
            tabRelay.Controls.Add(cboxPin11);
            tabRelay.Controls.Add(cboxPin10);
            tabRelay.Controls.Add(cboxPin9);
            tabRelay.Controls.Add(cboxPin8);
            tabRelay.Controls.Add(cboxPin7);
            tabRelay.Controls.Add(cboxPin6);
            tabRelay.Controls.Add(cboxPin5);
            tabRelay.Controls.Add(cboxPin4);
            tabRelay.Controls.Add(cboxPin3);
            tabRelay.Controls.Add(cboxPin2);
            tabRelay.Controls.Add(cboxPin1);
            tabRelay.Controls.Add(label138);
            tabRelay.Controls.Add(label139);
            tabRelay.Controls.Add(label140);
            tabRelay.Controls.Add(label141);
            tabRelay.Controls.Add(label142);
            tabRelay.Controls.Add(label133);
            tabRelay.Controls.Add(label134);
            tabRelay.Controls.Add(label135);
            tabRelay.Controls.Add(label136);
            tabRelay.Controls.Add(label137);
            tabRelay.Controls.Add(label132);
            tabRelay.Controls.Add(label131);
            tabRelay.Controls.Add(label130);
            tabRelay.Controls.Add(label129);
            tabRelay.Controls.Add(label128);
            tabRelay.Controls.Add(label127);
            tabRelay.Controls.Add(label126);
            tabRelay.Controls.Add(label125);
            tabRelay.Controls.Add(label124);
            tabRelay.Controls.Add(labelSendandSave);
            tabRelay.Controls.Add(cboxPin0);
            tabRelay.Controls.Add(label123);
            tabRelay.Controls.Add(btnRelaySetDefaultConfig);
            tabRelay.Controls.Add(btnRelayResetConfigToNone);
            tabRelay.Controls.Add(pboxSendRelay);
            tabRelay.Controls.Add(btnSendRelayConfigPGN);
            tabRelay.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            tabRelay.Location = new System.Drawing.Point(4, 44);
            tabRelay.Name = "tabRelay";
            tabRelay.Padding = new System.Windows.Forms.Padding(3);
            tabRelay.Size = new System.Drawing.Size(859, 584);
            tabRelay.TabIndex = 24;
            tabRelay.Text = "aRelay";
            tabRelay.Enter += tabRelay_Enter;
            tabRelay.Leave += tabRelay_Leave;
            // 
            // cboxPin23
            // 
            cboxPin23.BackColor = System.Drawing.Color.AliceBlue;
            cboxPin23.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboxPin23.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cboxPin23.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cboxPin23.FormattingEnabled = true;
            cboxPin23.Items.AddRange(new object[] { "-", "Section 1", "Section 2", "Section 3", "Section 4", "Section 5", "Section 6", "Section 7", "Section 8", "Section 9", "Section 10", "Section 11", "Section 12", "Section 13", "Section 14", "Section 15", "Section 16", "Hyd Up", "Hyd Down", "Tramline" });
            cboxPin23.Location = new System.Drawing.Point(529, 394);
            cboxPin23.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            cboxPin23.Name = "cboxPin23";
            cboxPin23.Size = new System.Drawing.Size(139, 33);
            cboxPin23.TabIndex = 555;
            cboxPin23.Click += cboxPin0_Click;
            // 
            // cboxPin22
            // 
            cboxPin22.BackColor = System.Drawing.Color.AliceBlue;
            cboxPin22.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboxPin22.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cboxPin22.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cboxPin22.FormattingEnabled = true;
            cboxPin22.Items.AddRange(new object[] { "-", "Section 1", "Section 2", "Section 3", "Section 4", "Section 5", "Section 6", "Section 7", "Section 8", "Section 9", "Section 10", "Section 11", "Section 12", "Section 13", "Section 14", "Section 15", "Section 16", "Hyd Up", "Hyd Down", "Tramline" });
            cboxPin22.Location = new System.Drawing.Point(356, 394);
            cboxPin22.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            cboxPin22.Name = "cboxPin22";
            cboxPin22.Size = new System.Drawing.Size(139, 33);
            cboxPin22.TabIndex = 554;
            cboxPin22.Click += cboxPin0_Click;
            // 
            // cboxPin21
            // 
            cboxPin21.BackColor = System.Drawing.Color.AliceBlue;
            cboxPin21.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboxPin21.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cboxPin21.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cboxPin21.FormattingEnabled = true;
            cboxPin21.Items.AddRange(new object[] { "-", "Section 1", "Section 2", "Section 3", "Section 4", "Section 5", "Section 6", "Section 7", "Section 8", "Section 9", "Section 10", "Section 11", "Section 12", "Section 13", "Section 14", "Section 15", "Section 16", "Hyd Up", "Hyd Down", "Tramline" });
            cboxPin21.Location = new System.Drawing.Point(183, 394);
            cboxPin21.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            cboxPin21.Name = "cboxPin21";
            cboxPin21.Size = new System.Drawing.Size(139, 33);
            cboxPin21.TabIndex = 553;
            cboxPin21.Click += cboxPin0_Click;
            // 
            // cboxPin20
            // 
            cboxPin20.BackColor = System.Drawing.Color.AliceBlue;
            cboxPin20.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboxPin20.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cboxPin20.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cboxPin20.FormattingEnabled = true;
            cboxPin20.Items.AddRange(new object[] { "-", "Section 1", "Section 2", "Section 3", "Section 4", "Section 5", "Section 6", "Section 7", "Section 8", "Section 9", "Section 10", "Section 11", "Section 12", "Section 13", "Section 14", "Section 15", "Section 16", "Hyd Up", "Hyd Down", "Tramline" });
            cboxPin20.Location = new System.Drawing.Point(10, 394);
            cboxPin20.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            cboxPin20.Name = "cboxPin20";
            cboxPin20.Size = new System.Drawing.Size(139, 33);
            cboxPin20.TabIndex = 552;
            cboxPin20.Click += cboxPin0_Click;
            // 
            // label143
            // 
            label143.BackColor = System.Drawing.Color.Transparent;
            label143.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label143.ForeColor = System.Drawing.Color.Black;
            label143.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label143.Location = new System.Drawing.Point(22, 364);
            label143.Name = "label143";
            label143.Size = new System.Drawing.Size(116, 29);
            label143.TabIndex = 551;
            label143.Text = "Pin 21";
            label143.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label144
            // 
            label144.BackColor = System.Drawing.Color.Transparent;
            label144.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label144.ForeColor = System.Drawing.Color.Black;
            label144.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label144.Location = new System.Drawing.Point(193, 364);
            label144.Name = "label144";
            label144.Size = new System.Drawing.Size(116, 29);
            label144.TabIndex = 550;
            label144.Text = "Pin 22";
            label144.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label145
            // 
            label145.BackColor = System.Drawing.Color.Transparent;
            label145.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label145.ForeColor = System.Drawing.Color.Black;
            label145.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label145.Location = new System.Drawing.Point(366, 364);
            label145.Name = "label145";
            label145.Size = new System.Drawing.Size(116, 29);
            label145.TabIndex = 549;
            label145.Text = "Pin 23";
            label145.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label146
            // 
            label146.BackColor = System.Drawing.Color.Transparent;
            label146.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label146.ForeColor = System.Drawing.Color.Black;
            label146.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label146.Location = new System.Drawing.Point(541, 364);
            label146.Name = "label146";
            label146.Size = new System.Drawing.Size(116, 29);
            label146.TabIndex = 548;
            label146.Text = "Pin 24";
            label146.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // cboxPin19
            // 
            cboxPin19.BackColor = System.Drawing.Color.AliceBlue;
            cboxPin19.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboxPin19.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cboxPin19.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cboxPin19.FormattingEnabled = true;
            cboxPin19.Items.AddRange(new object[] { "-", "Section 1", "Section 2", "Section 3", "Section 4", "Section 5", "Section 6", "Section 7", "Section 8", "Section 9", "Section 10", "Section 11", "Section 12", "Section 13", "Section 14", "Section 15", "Section 16", "Hyd Up", "Hyd Down", "Tramline" });
            cboxPin19.Location = new System.Drawing.Point(702, 302);
            cboxPin19.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            cboxPin19.Name = "cboxPin19";
            cboxPin19.Size = new System.Drawing.Size(139, 33);
            cboxPin19.TabIndex = 547;
            cboxPin19.Click += cboxPin0_Click;
            // 
            // cboxPin18
            // 
            cboxPin18.BackColor = System.Drawing.Color.AliceBlue;
            cboxPin18.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboxPin18.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cboxPin18.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cboxPin18.FormattingEnabled = true;
            cboxPin18.Items.AddRange(new object[] { "-", "Section 1", "Section 2", "Section 3", "Section 4", "Section 5", "Section 6", "Section 7", "Section 8", "Section 9", "Section 10", "Section 11", "Section 12", "Section 13", "Section 14", "Section 15", "Section 16", "Hyd Up", "Hyd Down", "Tramline" });
            cboxPin18.Location = new System.Drawing.Point(529, 302);
            cboxPin18.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            cboxPin18.Name = "cboxPin18";
            cboxPin18.Size = new System.Drawing.Size(139, 33);
            cboxPin18.TabIndex = 546;
            cboxPin18.Click += cboxPin0_Click;
            // 
            // cboxPin17
            // 
            cboxPin17.BackColor = System.Drawing.Color.AliceBlue;
            cboxPin17.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboxPin17.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cboxPin17.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cboxPin17.FormattingEnabled = true;
            cboxPin17.Items.AddRange(new object[] { "-", "Section 1", "Section 2", "Section 3", "Section 4", "Section 5", "Section 6", "Section 7", "Section 8", "Section 9", "Section 10", "Section 11", "Section 12", "Section 13", "Section 14", "Section 15", "Section 16", "Hyd Up", "Hyd Down", "Tramline" });
            cboxPin17.Location = new System.Drawing.Point(356, 302);
            cboxPin17.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            cboxPin17.Name = "cboxPin17";
            cboxPin17.Size = new System.Drawing.Size(139, 33);
            cboxPin17.TabIndex = 545;
            cboxPin17.Click += cboxPin0_Click;
            // 
            // cboxPin16
            // 
            cboxPin16.BackColor = System.Drawing.Color.AliceBlue;
            cboxPin16.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboxPin16.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cboxPin16.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cboxPin16.FormattingEnabled = true;
            cboxPin16.Items.AddRange(new object[] { "-", "Section 1", "Section 2", "Section 3", "Section 4", "Section 5", "Section 6", "Section 7", "Section 8", "Section 9", "Section 10", "Section 11", "Section 12", "Section 13", "Section 14", "Section 15", "Section 16", "Hyd Up", "Hyd Down", "Tramline" });
            cboxPin16.Location = new System.Drawing.Point(183, 302);
            cboxPin16.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            cboxPin16.Name = "cboxPin16";
            cboxPin16.Size = new System.Drawing.Size(139, 33);
            cboxPin16.TabIndex = 544;
            cboxPin16.Click += cboxPin0_Click;
            // 
            // cboxPin15
            // 
            cboxPin15.BackColor = System.Drawing.Color.AliceBlue;
            cboxPin15.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboxPin15.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cboxPin15.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cboxPin15.FormattingEnabled = true;
            cboxPin15.Items.AddRange(new object[] { "-", "Section 1", "Section 2", "Section 3", "Section 4", "Section 5", "Section 6", "Section 7", "Section 8", "Section 9", "Section 10", "Section 11", "Section 12", "Section 13", "Section 14", "Section 15", "Section 16", "Hyd Up", "Hyd Down", "Tramline" });
            cboxPin15.Location = new System.Drawing.Point(10, 302);
            cboxPin15.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            cboxPin15.Name = "cboxPin15";
            cboxPin15.Size = new System.Drawing.Size(139, 33);
            cboxPin15.TabIndex = 543;
            cboxPin15.Click += cboxPin0_Click;
            // 
            // cboxPin14
            // 
            cboxPin14.BackColor = System.Drawing.Color.AliceBlue;
            cboxPin14.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboxPin14.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cboxPin14.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cboxPin14.FormattingEnabled = true;
            cboxPin14.Items.AddRange(new object[] { "-", "Section 1", "Section 2", "Section 3", "Section 4", "Section 5", "Section 6", "Section 7", "Section 8", "Section 9", "Section 10", "Section 11", "Section 12", "Section 13", "Section 14", "Section 15", "Section 16", "Hyd Up", "Hyd Down", "Tramline" });
            cboxPin14.Location = new System.Drawing.Point(702, 210);
            cboxPin14.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            cboxPin14.Name = "cboxPin14";
            cboxPin14.Size = new System.Drawing.Size(139, 33);
            cboxPin14.TabIndex = 542;
            cboxPin14.Click += cboxPin0_Click;
            // 
            // cboxPin13
            // 
            cboxPin13.BackColor = System.Drawing.Color.AliceBlue;
            cboxPin13.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboxPin13.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cboxPin13.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cboxPin13.FormattingEnabled = true;
            cboxPin13.Items.AddRange(new object[] { "-", "Section 1", "Section 2", "Section 3", "Section 4", "Section 5", "Section 6", "Section 7", "Section 8", "Section 9", "Section 10", "Section 11", "Section 12", "Section 13", "Section 14", "Section 15", "Section 16", "Hyd Up", "Hyd Down", "Tramline" });
            cboxPin13.Location = new System.Drawing.Point(529, 210);
            cboxPin13.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            cboxPin13.Name = "cboxPin13";
            cboxPin13.Size = new System.Drawing.Size(139, 33);
            cboxPin13.TabIndex = 541;
            cboxPin13.Click += cboxPin0_Click;
            // 
            // cboxPin12
            // 
            cboxPin12.BackColor = System.Drawing.Color.AliceBlue;
            cboxPin12.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboxPin12.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cboxPin12.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cboxPin12.FormattingEnabled = true;
            cboxPin12.Items.AddRange(new object[] { "-", "Section 1", "Section 2", "Section 3", "Section 4", "Section 5", "Section 6", "Section 7", "Section 8", "Section 9", "Section 10", "Section 11", "Section 12", "Section 13", "Section 14", "Section 15", "Section 16", "Hyd Up", "Hyd Down", "Tramline" });
            cboxPin12.Location = new System.Drawing.Point(356, 210);
            cboxPin12.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            cboxPin12.Name = "cboxPin12";
            cboxPin12.Size = new System.Drawing.Size(139, 33);
            cboxPin12.TabIndex = 540;
            cboxPin12.Click += cboxPin0_Click;
            // 
            // cboxPin11
            // 
            cboxPin11.BackColor = System.Drawing.Color.AliceBlue;
            cboxPin11.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboxPin11.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cboxPin11.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cboxPin11.FormattingEnabled = true;
            cboxPin11.Items.AddRange(new object[] { "-", "Section 1", "Section 2", "Section 3", "Section 4", "Section 5", "Section 6", "Section 7", "Section 8", "Section 9", "Section 10", "Section 11", "Section 12", "Section 13", "Section 14", "Section 15", "Section 16", "Hyd Up", "Hyd Down", "Tramline" });
            cboxPin11.Location = new System.Drawing.Point(183, 210);
            cboxPin11.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            cboxPin11.Name = "cboxPin11";
            cboxPin11.Size = new System.Drawing.Size(139, 33);
            cboxPin11.TabIndex = 539;
            cboxPin11.Click += cboxPin0_Click;
            // 
            // cboxPin10
            // 
            cboxPin10.BackColor = System.Drawing.Color.AliceBlue;
            cboxPin10.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboxPin10.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cboxPin10.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cboxPin10.FormattingEnabled = true;
            cboxPin10.Items.AddRange(new object[] { "-", "Section 1", "Section 2", "Section 3", "Section 4", "Section 5", "Section 6", "Section 7", "Section 8", "Section 9", "Section 10", "Section 11", "Section 12", "Section 13", "Section 14", "Section 15", "Section 16", "Hyd Up", "Hyd Down", "Tramline" });
            cboxPin10.Location = new System.Drawing.Point(10, 210);
            cboxPin10.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            cboxPin10.Name = "cboxPin10";
            cboxPin10.Size = new System.Drawing.Size(139, 33);
            cboxPin10.TabIndex = 538;
            cboxPin10.Click += cboxPin0_Click;
            // 
            // cboxPin9
            // 
            cboxPin9.BackColor = System.Drawing.Color.AliceBlue;
            cboxPin9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboxPin9.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cboxPin9.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cboxPin9.FormattingEnabled = true;
            cboxPin9.Items.AddRange(new object[] { "-", "Section 1", "Section 2", "Section 3", "Section 4", "Section 5", "Section 6", "Section 7", "Section 8", "Section 9", "Section 10", "Section 11", "Section 12", "Section 13", "Section 14", "Section 15", "Section 16", "Hyd Up", "Hyd Down", "Tramline" });
            cboxPin9.Location = new System.Drawing.Point(702, 118);
            cboxPin9.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            cboxPin9.Name = "cboxPin9";
            cboxPin9.Size = new System.Drawing.Size(139, 33);
            cboxPin9.TabIndex = 537;
            cboxPin9.Click += cboxPin0_Click;
            // 
            // cboxPin8
            // 
            cboxPin8.BackColor = System.Drawing.Color.AliceBlue;
            cboxPin8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboxPin8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cboxPin8.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cboxPin8.FormattingEnabled = true;
            cboxPin8.Items.AddRange(new object[] { "-", "Section 1", "Section 2", "Section 3", "Section 4", "Section 5", "Section 6", "Section 7", "Section 8", "Section 9", "Section 10", "Section 11", "Section 12", "Section 13", "Section 14", "Section 15", "Section 16", "Hyd Up", "Hyd Down", "Tramline" });
            cboxPin8.Location = new System.Drawing.Point(529, 118);
            cboxPin8.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            cboxPin8.Name = "cboxPin8";
            cboxPin8.Size = new System.Drawing.Size(139, 33);
            cboxPin8.TabIndex = 536;
            cboxPin8.Click += cboxPin0_Click;
            // 
            // cboxPin7
            // 
            cboxPin7.BackColor = System.Drawing.Color.AliceBlue;
            cboxPin7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboxPin7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cboxPin7.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cboxPin7.FormattingEnabled = true;
            cboxPin7.Items.AddRange(new object[] { "-", "Section 1", "Section 2", "Section 3", "Section 4", "Section 5", "Section 6", "Section 7", "Section 8", "Section 9", "Section 10", "Section 11", "Section 12", "Section 13", "Section 14", "Section 15", "Section 16", "Hyd Up", "Hyd Down", "Tramline" });
            cboxPin7.Location = new System.Drawing.Point(356, 118);
            cboxPin7.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            cboxPin7.Name = "cboxPin7";
            cboxPin7.Size = new System.Drawing.Size(139, 33);
            cboxPin7.TabIndex = 535;
            cboxPin7.Click += cboxPin0_Click;
            // 
            // cboxPin6
            // 
            cboxPin6.BackColor = System.Drawing.Color.AliceBlue;
            cboxPin6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboxPin6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cboxPin6.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cboxPin6.FormattingEnabled = true;
            cboxPin6.Items.AddRange(new object[] { "-", "Section 1", "Section 2", "Section 3", "Section 4", "Section 5", "Section 6", "Section 7", "Section 8", "Section 9", "Section 10", "Section 11", "Section 12", "Section 13", "Section 14", "Section 15", "Section 16", "Hyd Up", "Hyd Down", "Tramline" });
            cboxPin6.Location = new System.Drawing.Point(183, 118);
            cboxPin6.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            cboxPin6.Name = "cboxPin6";
            cboxPin6.Size = new System.Drawing.Size(139, 33);
            cboxPin6.TabIndex = 534;
            cboxPin6.Click += cboxPin0_Click;
            // 
            // cboxPin5
            // 
            cboxPin5.BackColor = System.Drawing.Color.AliceBlue;
            cboxPin5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboxPin5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cboxPin5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cboxPin5.FormattingEnabled = true;
            cboxPin5.Items.AddRange(new object[] { "-", "Section 1", "Section 2", "Section 3", "Section 4", "Section 5", "Section 6", "Section 7", "Section 8", "Section 9", "Section 10", "Section 11", "Section 12", "Section 13", "Section 14", "Section 15", "Section 16", "Hyd Up", "Hyd Down", "Tramline" });
            cboxPin5.Location = new System.Drawing.Point(10, 118);
            cboxPin5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            cboxPin5.Name = "cboxPin5";
            cboxPin5.Size = new System.Drawing.Size(139, 33);
            cboxPin5.TabIndex = 533;
            cboxPin5.Click += cboxPin0_Click;
            // 
            // cboxPin4
            // 
            cboxPin4.BackColor = System.Drawing.Color.AliceBlue;
            cboxPin4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboxPin4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cboxPin4.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cboxPin4.FormattingEnabled = true;
            cboxPin4.Location = new System.Drawing.Point(702, 26);
            cboxPin4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            cboxPin4.Name = "cboxPin4";
            cboxPin4.Size = new System.Drawing.Size(139, 33);
            cboxPin4.TabIndex = 529;
            cboxPin4.Click += cboxPin0_Click;
            // 
            // cboxPin3
            // 
            cboxPin3.BackColor = System.Drawing.Color.AliceBlue;
            cboxPin3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboxPin3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cboxPin3.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cboxPin3.FormattingEnabled = true;
            cboxPin3.Location = new System.Drawing.Point(529, 26);
            cboxPin3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            cboxPin3.Name = "cboxPin3";
            cboxPin3.Size = new System.Drawing.Size(139, 33);
            cboxPin3.TabIndex = 528;
            cboxPin3.Click += cboxPin0_Click;
            // 
            // cboxPin2
            // 
            cboxPin2.BackColor = System.Drawing.Color.AliceBlue;
            cboxPin2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboxPin2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cboxPin2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cboxPin2.FormattingEnabled = true;
            cboxPin2.Location = new System.Drawing.Point(356, 26);
            cboxPin2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            cboxPin2.Name = "cboxPin2";
            cboxPin2.Size = new System.Drawing.Size(139, 33);
            cboxPin2.TabIndex = 527;
            cboxPin2.Click += cboxPin0_Click;
            // 
            // cboxPin1
            // 
            cboxPin1.BackColor = System.Drawing.Color.AliceBlue;
            cboxPin1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboxPin1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cboxPin1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cboxPin1.FormattingEnabled = true;
            cboxPin1.Location = new System.Drawing.Point(183, 26);
            cboxPin1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            cboxPin1.Name = "cboxPin1";
            cboxPin1.Size = new System.Drawing.Size(139, 33);
            cboxPin1.TabIndex = 526;
            cboxPin1.Click += cboxPin0_Click;
            // 
            // label138
            // 
            label138.BackColor = System.Drawing.Color.Transparent;
            label138.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label138.ForeColor = System.Drawing.Color.Black;
            label138.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label138.Location = new System.Drawing.Point(713, 269);
            label138.Name = "label138";
            label138.Size = new System.Drawing.Size(116, 29);
            label138.TabIndex = 525;
            label138.Text = "Pin 20";
            label138.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label139
            // 
            label139.BackColor = System.Drawing.Color.Transparent;
            label139.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label139.ForeColor = System.Drawing.Color.Black;
            label139.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label139.Location = new System.Drawing.Point(22, 269);
            label139.Name = "label139";
            label139.Size = new System.Drawing.Size(116, 29);
            label139.TabIndex = 523;
            label139.Text = "Pin 16";
            label139.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label140
            // 
            label140.BackColor = System.Drawing.Color.Transparent;
            label140.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label140.ForeColor = System.Drawing.Color.Black;
            label140.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label140.Location = new System.Drawing.Point(193, 269);
            label140.Name = "label140";
            label140.Size = new System.Drawing.Size(116, 29);
            label140.TabIndex = 521;
            label140.Text = "Pin 17";
            label140.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label141
            // 
            label141.BackColor = System.Drawing.Color.Transparent;
            label141.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label141.ForeColor = System.Drawing.Color.Black;
            label141.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label141.Location = new System.Drawing.Point(366, 269);
            label141.Name = "label141";
            label141.Size = new System.Drawing.Size(116, 29);
            label141.TabIndex = 519;
            label141.Text = "Pin 18";
            label141.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label142
            // 
            label142.BackColor = System.Drawing.Color.Transparent;
            label142.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label142.ForeColor = System.Drawing.Color.Black;
            label142.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label142.Location = new System.Drawing.Point(541, 269);
            label142.Name = "label142";
            label142.Size = new System.Drawing.Size(116, 29);
            label142.TabIndex = 517;
            label142.Text = "Pin 19";
            label142.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label133
            // 
            label133.BackColor = System.Drawing.Color.Transparent;
            label133.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label133.ForeColor = System.Drawing.Color.Black;
            label133.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label133.Location = new System.Drawing.Point(713, 177);
            label133.Name = "label133";
            label133.Size = new System.Drawing.Size(116, 29);
            label133.TabIndex = 515;
            label133.Text = "Pin 15";
            label133.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label134
            // 
            label134.BackColor = System.Drawing.Color.Transparent;
            label134.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label134.ForeColor = System.Drawing.Color.Black;
            label134.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label134.Location = new System.Drawing.Point(22, 177);
            label134.Name = "label134";
            label134.Size = new System.Drawing.Size(116, 29);
            label134.TabIndex = 513;
            label134.Text = "Pin 11";
            label134.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label135
            // 
            label135.BackColor = System.Drawing.Color.Transparent;
            label135.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label135.ForeColor = System.Drawing.Color.Black;
            label135.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label135.Location = new System.Drawing.Point(193, 177);
            label135.Name = "label135";
            label135.Size = new System.Drawing.Size(116, 29);
            label135.TabIndex = 511;
            label135.Text = "Pin 12";
            label135.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label136
            // 
            label136.BackColor = System.Drawing.Color.Transparent;
            label136.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label136.ForeColor = System.Drawing.Color.Black;
            label136.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label136.Location = new System.Drawing.Point(366, 177);
            label136.Name = "label136";
            label136.Size = new System.Drawing.Size(116, 29);
            label136.TabIndex = 509;
            label136.Text = "Pin 13";
            label136.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label137
            // 
            label137.BackColor = System.Drawing.Color.Transparent;
            label137.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label137.ForeColor = System.Drawing.Color.Black;
            label137.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label137.Location = new System.Drawing.Point(541, 177);
            label137.Name = "label137";
            label137.Size = new System.Drawing.Size(116, 29);
            label137.TabIndex = 507;
            label137.Text = "Pin 14";
            label137.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label132
            // 
            label132.BackColor = System.Drawing.Color.Transparent;
            label132.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label132.ForeColor = System.Drawing.Color.Black;
            label132.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label132.Location = new System.Drawing.Point(713, 85);
            label132.Name = "label132";
            label132.Size = new System.Drawing.Size(116, 29);
            label132.TabIndex = 505;
            label132.Text = "Pin 10";
            label132.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label131
            // 
            label131.BackColor = System.Drawing.Color.Transparent;
            label131.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label131.ForeColor = System.Drawing.Color.Black;
            label131.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label131.Location = new System.Drawing.Point(193, -6);
            label131.Name = "label131";
            label131.Size = new System.Drawing.Size(116, 29);
            label131.TabIndex = 503;
            label131.Text = "Pin 2";
            label131.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label130
            // 
            label130.BackColor = System.Drawing.Color.Transparent;
            label130.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label130.ForeColor = System.Drawing.Color.Black;
            label130.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label130.Location = new System.Drawing.Point(366, -6);
            label130.Name = "label130";
            label130.Size = new System.Drawing.Size(116, 29);
            label130.TabIndex = 501;
            label130.Text = "Pin 3";
            label130.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label129
            // 
            label129.BackColor = System.Drawing.Color.Transparent;
            label129.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label129.ForeColor = System.Drawing.Color.Black;
            label129.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label129.Location = new System.Drawing.Point(541, -6);
            label129.Name = "label129";
            label129.Size = new System.Drawing.Size(116, 29);
            label129.TabIndex = 499;
            label129.Text = "Pin 4";
            label129.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label128
            // 
            label128.BackColor = System.Drawing.Color.Transparent;
            label128.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label128.ForeColor = System.Drawing.Color.Black;
            label128.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label128.Location = new System.Drawing.Point(713, -6);
            label128.Name = "label128";
            label128.Size = new System.Drawing.Size(116, 29);
            label128.TabIndex = 497;
            label128.Text = "Pin 5";
            label128.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label127
            // 
            label127.BackColor = System.Drawing.Color.Transparent;
            label127.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label127.ForeColor = System.Drawing.Color.Black;
            label127.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label127.Location = new System.Drawing.Point(22, 85);
            label127.Name = "label127";
            label127.Size = new System.Drawing.Size(116, 29);
            label127.TabIndex = 495;
            label127.Text = "Pin 6";
            label127.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label126
            // 
            label126.BackColor = System.Drawing.Color.Transparent;
            label126.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label126.ForeColor = System.Drawing.Color.Black;
            label126.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label126.Location = new System.Drawing.Point(193, 85);
            label126.Name = "label126";
            label126.Size = new System.Drawing.Size(116, 29);
            label126.TabIndex = 493;
            label126.Text = "Pin 7";
            label126.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label125
            // 
            label125.BackColor = System.Drawing.Color.Transparent;
            label125.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label125.ForeColor = System.Drawing.Color.Black;
            label125.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label125.Location = new System.Drawing.Point(366, 85);
            label125.Name = "label125";
            label125.Size = new System.Drawing.Size(116, 29);
            label125.TabIndex = 491;
            label125.Text = "Pin 8";
            label125.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label124
            // 
            label124.BackColor = System.Drawing.Color.Transparent;
            label124.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label124.ForeColor = System.Drawing.Color.Black;
            label124.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label124.Location = new System.Drawing.Point(541, 85);
            label124.Name = "label124";
            label124.Size = new System.Drawing.Size(116, 29);
            label124.TabIndex = 489;
            label124.Text = "Pin 9";
            label124.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // labelSendandSave
            // 
            labelSendandSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            labelSendandSave.BackColor = System.Drawing.Color.Transparent;
            labelSendandSave.Font = new System.Drawing.Font("Tahoma", 15.75F);
            labelSendandSave.ForeColor = System.Drawing.Color.Black;
            labelSendandSave.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            labelSendandSave.Location = new System.Drawing.Point(460, 507);
            labelSendandSave.Name = "labelSendandSave";
            labelSendandSave.Size = new System.Drawing.Size(172, 62);
            labelSendandSave.TabIndex = 486;
            labelSendandSave.Text = "Send +  Save";
            labelSendandSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboxPin0
            // 
            cboxPin0.BackColor = System.Drawing.Color.AliceBlue;
            cboxPin0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboxPin0.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cboxPin0.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cboxPin0.FormattingEnabled = true;
            cboxPin0.Location = new System.Drawing.Point(10, 26);
            cboxPin0.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            cboxPin0.Name = "cboxPin0";
            cboxPin0.Size = new System.Drawing.Size(139, 33);
            cboxPin0.TabIndex = 483;
            cboxPin0.Click += cboxPin0_Click;
            // 
            // label123
            // 
            label123.BackColor = System.Drawing.Color.Transparent;
            label123.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label123.ForeColor = System.Drawing.Color.Black;
            label123.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label123.Location = new System.Drawing.Point(22, -6);
            label123.Name = "label123";
            label123.Size = new System.Drawing.Size(116, 29);
            label123.TabIndex = 484;
            label123.Text = "Pin 1";
            label123.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnRelaySetDefaultConfig
            // 
            btnRelaySetDefaultConfig.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnRelaySetDefaultConfig.BackColor = System.Drawing.Color.Transparent;
            btnRelaySetDefaultConfig.FlatAppearance.BorderSize = 0;
            btnRelaySetDefaultConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRelaySetDefaultConfig.Image = Properties.Resources.UpArrow64;
            btnRelaySetDefaultConfig.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnRelaySetDefaultConfig.Location = new System.Drawing.Point(148, 500);
            btnRelaySetDefaultConfig.Name = "btnRelaySetDefaultConfig";
            btnRelaySetDefaultConfig.Size = new System.Drawing.Size(133, 85);
            btnRelaySetDefaultConfig.TabIndex = 532;
            btnRelaySetDefaultConfig.UseVisualStyleBackColor = false;
            btnRelaySetDefaultConfig.Click += btnRelaySetDefaultConfig_Click;
            // 
            // btnRelayResetConfigToNone
            // 
            btnRelayResetConfigToNone.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnRelayResetConfigToNone.BackColor = System.Drawing.Color.Transparent;
            btnRelayResetConfigToNone.FlatAppearance.BorderSize = 0;
            btnRelayResetConfigToNone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRelayResetConfigToNone.Image = Properties.Resources.back_button;
            btnRelayResetConfigToNone.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnRelayResetConfigToNone.Location = new System.Drawing.Point(0, 502);
            btnRelayResetConfigToNone.Name = "btnRelayResetConfigToNone";
            btnRelayResetConfigToNone.Size = new System.Drawing.Size(133, 85);
            btnRelayResetConfigToNone.TabIndex = 531;
            btnRelayResetConfigToNone.UseVisualStyleBackColor = false;
            btnRelayResetConfigToNone.Click += btnRelayResetConfigToNone_Click;
            // 
            // pboxSendRelay
            // 
            pboxSendRelay.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            pboxSendRelay.BackgroundImage = Properties.Resources.ConSt_Mandatory1;
            pboxSendRelay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            pboxSendRelay.Location = new System.Drawing.Point(751, 494);
            pboxSendRelay.Name = "pboxSendRelay";
            pboxSendRelay.Size = new System.Drawing.Size(93, 85);
            pboxSendRelay.TabIndex = 487;
            pboxSendRelay.TabStop = false;
            pboxSendRelay.Visible = false;
            // 
            // btnSendRelayConfigPGN
            // 
            btnSendRelayConfigPGN.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnSendRelayConfigPGN.BackColor = System.Drawing.Color.Transparent;
            btnSendRelayConfigPGN.FlatAppearance.BorderSize = 0;
            btnSendRelayConfigPGN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSendRelayConfigPGN.Image = Properties.Resources.ToolAcceptChange;
            btnSendRelayConfigPGN.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnSendRelayConfigPGN.Location = new System.Drawing.Point(616, 507);
            btnSendRelayConfigPGN.Name = "btnSendRelayConfigPGN";
            btnSendRelayConfigPGN.Size = new System.Drawing.Size(133, 62);
            btnSendRelayConfigPGN.TabIndex = 485;
            btnSendRelayConfigPGN.UseVisualStyleBackColor = false;
            btnSendRelayConfigPGN.Click += btnSendRelayConfigPGN_Click;
            // 
            // tabAMachine
            // 
            tabAMachine.BackColor = System.Drawing.Color.WhiteSmoke;
            tabAMachine.Controls.Add(labelUser4);
            tabAMachine.Controls.Add(labelUser3);
            tabAMachine.Controls.Add(labelUser2);
            tabAMachine.Controls.Add(labelUser1);
            tabAMachine.Controls.Add(labelGroupHyd);
            tabAMachine.Controls.Add(labelHydLiftInvert);
            tabAMachine.Controls.Add(labelSendSaveHydraulicLift);
            tabAMachine.Controls.Add(labelMachineMod);
            tabAMachine.Controls.Add(nudUser4);
            tabAMachine.Controls.Add(nudUser3);
            tabAMachine.Controls.Add(nudUser2);
            tabAMachine.Controls.Add(nudUser1);
            tabAMachine.Controls.Add(pboxSendMachine);
            tabAMachine.Controls.Add(cboxMachInvertRelays);
            tabAMachine.Controls.Add(btnSendMachinePGN);
            tabAMachine.Location = new System.Drawing.Point(4, 44);
            tabAMachine.Name = "tabAMachine";
            tabAMachine.Size = new System.Drawing.Size(859, 584);
            tabAMachine.TabIndex = 20;
            tabAMachine.Text = "aMach";
            tabAMachine.Enter += tabAMachine_Enter;
            tabAMachine.Leave += tabAMachine_Leave;
            // 
            // labelUser4
            // 
            labelUser4.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelUser4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelUser4.ForeColor = System.Drawing.Color.Black;
            labelUser4.Location = new System.Drawing.Point(662, 326);
            labelUser4.Name = "labelUser4";
            labelUser4.Size = new System.Drawing.Size(111, 16);
            labelUser4.TabIndex = 492;
            labelUser4.Text = "User 4";
            // 
            // labelUser3
            // 
            labelUser3.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelUser3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelUser3.ForeColor = System.Drawing.Color.Black;
            labelUser3.Location = new System.Drawing.Point(662, 234);
            labelUser3.Name = "labelUser3";
            labelUser3.Size = new System.Drawing.Size(111, 16);
            labelUser3.TabIndex = 491;
            labelUser3.Text = "User 3";
            // 
            // labelUser2
            // 
            labelUser2.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelUser2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelUser2.ForeColor = System.Drawing.Color.Black;
            labelUser2.Location = new System.Drawing.Point(662, 147);
            labelUser2.Name = "labelUser2";
            labelUser2.Size = new System.Drawing.Size(111, 16);
            labelUser2.TabIndex = 490;
            labelUser2.Text = "User 2";
            // 
            // labelUser1
            // 
            labelUser1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelUser1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelUser1.ForeColor = System.Drawing.Color.Black;
            labelUser1.Location = new System.Drawing.Point(662, 56);
            labelUser1.Name = "labelUser1";
            labelUser1.Size = new System.Drawing.Size(111, 16);
            labelUser1.TabIndex = 489;
            labelUser1.Text = "User 1";
            // 
            // labelGroupHyd
            // 
            labelGroupHyd.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelGroupHyd.Controls.Add(labelPlantPop);
            labelGroupHyd.Controls.Add(nudHydLiftLookAhead);
            labelGroupHyd.Controls.Add(labelHydLiftSec);
            labelGroupHyd.Controls.Add(labelRaiseTime);
            labelGroupHyd.Controls.Add(labelEnable);
            labelGroupHyd.Controls.Add(labelLowTime);
            labelGroupHyd.Controls.Add(cboxIsHydOn);
            labelGroupHyd.Controls.Add(pictureBox6);
            labelGroupHyd.Controls.Add(nudLowerTime);
            labelGroupHyd.Controls.Add(pictureBox7);
            labelGroupHyd.Controls.Add(nudRaiseTime);
            labelGroupHyd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelGroupHyd.Location = new System.Drawing.Point(30, 41);
            labelGroupHyd.Name = "labelGroupHyd";
            labelGroupHyd.Size = new System.Drawing.Size(548, 394);
            labelGroupHyd.TabIndex = 484;
            labelGroupHyd.TabStop = false;
            labelGroupHyd.Text = "Hydraulic Lift Config";
            // 
            // labelPlantPop
            // 
            labelPlantPop.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelPlantPop.ForeColor = System.Drawing.Color.Black;
            labelPlantPop.Location = new System.Drawing.Point(226, 133);
            labelPlantPop.Name = "labelPlantPop";
            labelPlantPop.Size = new System.Drawing.Size(110, 16);
            labelPlantPop.TabIndex = 480;
            labelPlantPop.Text = "Plant Pop";
            labelPlantPop.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // nudHydLiftLookAhead
            // 
            nudHydLiftLookAhead.BackColor = System.Drawing.Color.White;
            nudHydLiftLookAhead.DecimalPlaces = 1;
            nudHydLiftLookAhead.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            nudHydLiftLookAhead.InterceptArrowKeys = false;
            nudHydLiftLookAhead.Location = new System.Drawing.Point(34, 278);
            nudHydLiftLookAhead.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            nudHydLiftLookAhead.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudHydLiftLookAhead.Name = "nudHydLiftLookAhead";
            nudHydLiftLookAhead.ReadOnly = true;
            nudHydLiftLookAhead.Size = new System.Drawing.Size(148, 52);
            nudHydLiftLookAhead.TabIndex = 117;
            nudHydLiftLookAhead.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudHydLiftLookAhead.Value = new decimal(new int[] { 5, 0, 0, 0 });
            nudHydLiftLookAhead.Click += nudHydLiftSecs_Click;
            // 
            // labelHydLiftSec
            // 
            labelHydLiftSec.BackColor = System.Drawing.Color.Transparent;
            labelHydLiftSec.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelHydLiftSec.ForeColor = System.Drawing.Color.Black;
            labelHydLiftSec.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            labelHydLiftSec.Location = new System.Drawing.Point(30, 200);
            labelHydLiftSec.Name = "labelHydLiftSec";
            labelHydLiftSec.Size = new System.Drawing.Size(151, 73);
            labelHydLiftSec.TabIndex = 128;
            labelHydLiftSec.Text = "Hydraulic Lift Look Ahead (secs)";
            labelHydLiftSec.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // labelRaiseTime
            // 
            labelRaiseTime.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelRaiseTime.ForeColor = System.Drawing.Color.Black;
            labelRaiseTime.Location = new System.Drawing.Point(223, 55);
            labelRaiseTime.Name = "labelRaiseTime";
            labelRaiseTime.Size = new System.Drawing.Size(123, 16);
            labelRaiseTime.TabIndex = 478;
            labelRaiseTime.Text = "Raise Time (secs)";
            // 
            // labelEnable
            // 
            labelEnable.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelEnable.ForeColor = System.Drawing.Color.Black;
            labelEnable.Location = new System.Drawing.Point(31, 52);
            labelEnable.Name = "labelEnable";
            labelEnable.Size = new System.Drawing.Size(126, 16);
            labelEnable.TabIndex = 479;
            labelEnable.Text = "Enable";
            // 
            // labelLowTime
            // 
            labelLowTime.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelLowTime.ForeColor = System.Drawing.Color.Black;
            labelLowTime.Location = new System.Drawing.Point(223, 260);
            labelLowTime.Name = "labelLowTime";
            labelLowTime.Size = new System.Drawing.Size(123, 16);
            labelLowTime.TabIndex = 477;
            labelLowTime.Text = "Lower Time (secs)";
            // 
            // cboxIsHydOn
            // 
            cboxIsHydOn.Appearance = System.Windows.Forms.Appearance.Button;
            cboxIsHydOn.BackColor = System.Drawing.Color.WhiteSmoke;
            cboxIsHydOn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            cboxIsHydOn.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            cboxIsHydOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboxIsHydOn.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cboxIsHydOn.ForeColor = System.Drawing.SystemColors.ControlText;
            cboxIsHydOn.Image = Properties.Resources.SwitchOn;
            cboxIsHydOn.Location = new System.Drawing.Point(34, 74);
            cboxIsHydOn.Name = "cboxIsHydOn";
            cboxIsHydOn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            cboxIsHydOn.Size = new System.Drawing.Size(123, 74);
            cboxIsHydOn.TabIndex = 0;
            cboxIsHydOn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            cboxIsHydOn.UseVisualStyleBackColor = false;
            cboxIsHydOn.CheckedChanged += cboxIsHydOn_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.BackgroundImage = Properties.Resources.ConMa_LiftLowerTime;
            pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pictureBox6.Location = new System.Drawing.Point(352, 226);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new System.Drawing.Size(177, 154);
            pictureBox6.TabIndex = 456;
            pictureBox6.TabStop = false;
            // 
            // nudLowerTime
            // 
            nudLowerTime.BackColor = System.Drawing.Color.White;
            nudLowerTime.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            nudLowerTime.InterceptArrowKeys = false;
            nudLowerTime.Location = new System.Drawing.Point(226, 279);
            nudLowerTime.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            nudLowerTime.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudLowerTime.Name = "nudLowerTime";
            nudLowerTime.ReadOnly = true;
            nudLowerTime.Size = new System.Drawing.Size(114, 52);
            nudLowerTime.TabIndex = 4;
            nudLowerTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudLowerTime.Value = new decimal(new int[] { 255, 0, 0, 0 });
            nudLowerTime.Click += nudLowerTime_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.BackgroundImage = Properties.Resources.ConMa_LiftRaiseTime;
            pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pictureBox7.Location = new System.Drawing.Point(352, 26);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new System.Drawing.Size(177, 154);
            pictureBox7.TabIndex = 457;
            pictureBox7.TabStop = false;
            // 
            // nudRaiseTime
            // 
            nudRaiseTime.BackColor = System.Drawing.Color.White;
            nudRaiseTime.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            nudRaiseTime.InterceptArrowKeys = false;
            nudRaiseTime.Location = new System.Drawing.Point(226, 75);
            nudRaiseTime.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            nudRaiseTime.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudRaiseTime.Name = "nudRaiseTime";
            nudRaiseTime.ReadOnly = true;
            nudRaiseTime.Size = new System.Drawing.Size(114, 52);
            nudRaiseTime.TabIndex = 3;
            nudRaiseTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudRaiseTime.Value = new decimal(new int[] { 255, 0, 0, 0 });
            nudRaiseTime.Click += nudRaiseTime_Click;
            // 
            // labelHydLiftInvert
            // 
            labelHydLiftInvert.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelHydLiftInvert.ForeColor = System.Drawing.Color.Black;
            labelHydLiftInvert.Location = new System.Drawing.Point(116, 443);
            labelHydLiftInvert.Name = "labelHydLiftInvert";
            labelHydLiftInvert.Size = new System.Drawing.Size(192, 16);
            labelHydLiftInvert.TabIndex = 476;
            labelHydLiftInvert.Text = "Invert Relays";
            // 
            // labelSendSaveHydraulicLift
            // 
            labelSendSaveHydraulicLift.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelSendSaveHydraulicLift.BackColor = System.Drawing.Color.Transparent;
            labelSendSaveHydraulicLift.Font = new System.Drawing.Font("Tahoma", 15.75F);
            labelSendSaveHydraulicLift.ForeColor = System.Drawing.Color.Black;
            labelSendSaveHydraulicLift.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            labelSendSaveHydraulicLift.Location = new System.Drawing.Point(519, 507);
            labelSendSaveHydraulicLift.Name = "labelSendSaveHydraulicLift";
            labelSendSaveHydraulicLift.Size = new System.Drawing.Size(172, 37);
            labelSendSaveHydraulicLift.TabIndex = 455;
            labelSendSaveHydraulicLift.Text = "Send + Save";
            labelSendSaveHydraulicLift.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelMachineMod
            // 
            labelMachineMod.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelMachineMod.BackColor = System.Drawing.Color.Transparent;
            labelMachineMod.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelMachineMod.ForeColor = System.Drawing.Color.Black;
            labelMachineMod.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            labelMachineMod.Location = new System.Drawing.Point(3, 3);
            labelMachineMod.Name = "labelMachineMod";
            labelMachineMod.Size = new System.Drawing.Size(853, 25);
            labelMachineMod.TabIndex = 450;
            labelMachineMod.Text = "Machine Module";
            labelMachineMod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudUser4
            // 
            nudUser4.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            nudUser4.BackColor = System.Drawing.Color.White;
            nudUser4.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            nudUser4.InterceptArrowKeys = false;
            nudUser4.Location = new System.Drawing.Point(659, 342);
            nudUser4.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            nudUser4.Name = "nudUser4";
            nudUser4.ReadOnly = true;
            nudUser4.Size = new System.Drawing.Size(114, 52);
            nudUser4.TabIndex = 488;
            nudUser4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudUser4.Value = new decimal(new int[] { 255, 0, 0, 0 });
            nudUser4.Click += nudUser4_Click;
            // 
            // nudUser3
            // 
            nudUser3.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            nudUser3.BackColor = System.Drawing.Color.White;
            nudUser3.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            nudUser3.InterceptArrowKeys = false;
            nudUser3.Location = new System.Drawing.Point(659, 253);
            nudUser3.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            nudUser3.Name = "nudUser3";
            nudUser3.ReadOnly = true;
            nudUser3.Size = new System.Drawing.Size(114, 52);
            nudUser3.TabIndex = 487;
            nudUser3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudUser3.Value = new decimal(new int[] { 255, 0, 0, 0 });
            nudUser3.Click += nudUser3_Click;
            // 
            // nudUser2
            // 
            nudUser2.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            nudUser2.BackColor = System.Drawing.Color.White;
            nudUser2.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            nudUser2.InterceptArrowKeys = false;
            nudUser2.Location = new System.Drawing.Point(659, 164);
            nudUser2.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            nudUser2.Name = "nudUser2";
            nudUser2.ReadOnly = true;
            nudUser2.Size = new System.Drawing.Size(114, 52);
            nudUser2.TabIndex = 486;
            nudUser2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudUser2.Value = new decimal(new int[] { 255, 0, 0, 0 });
            nudUser2.Click += nudUser2_Click;
            // 
            // nudUser1
            // 
            nudUser1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            nudUser1.BackColor = System.Drawing.Color.White;
            nudUser1.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            nudUser1.InterceptArrowKeys = false;
            nudUser1.Location = new System.Drawing.Point(659, 75);
            nudUser1.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            nudUser1.Name = "nudUser1";
            nudUser1.ReadOnly = true;
            nudUser1.Size = new System.Drawing.Size(114, 52);
            nudUser1.TabIndex = 485;
            nudUser1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudUser1.Value = new decimal(new int[] { 255, 0, 0, 0 });
            nudUser1.Click += nudUser1_Click;
            // 
            // pboxSendMachine
            // 
            pboxSendMachine.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            pboxSendMachine.BackgroundImage = Properties.Resources.ConSt_Mandatory1;
            pboxSendMachine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            pboxSendMachine.Location = new System.Drawing.Point(712, 412);
            pboxSendMachine.Name = "pboxSendMachine";
            pboxSendMachine.Size = new System.Drawing.Size(88, 79);
            pboxSendMachine.TabIndex = 483;
            pboxSendMachine.TabStop = false;
            pboxSendMachine.Visible = false;
            // 
            // cboxMachInvertRelays
            // 
            cboxMachInvertRelays.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            cboxMachInvertRelays.Appearance = System.Windows.Forms.Appearance.Button;
            cboxMachInvertRelays.BackColor = System.Drawing.Color.WhiteSmoke;
            cboxMachInvertRelays.Checked = true;
            cboxMachInvertRelays.CheckState = System.Windows.Forms.CheckState.Checked;
            cboxMachInvertRelays.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            cboxMachInvertRelays.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            cboxMachInvertRelays.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboxMachInvertRelays.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cboxMachInvertRelays.ForeColor = System.Drawing.SystemColors.ControlText;
            cboxMachInvertRelays.Image = Properties.Resources.ConSt_InvertRelay;
            cboxMachInvertRelays.Location = new System.Drawing.Point(116, 462);
            cboxMachInvertRelays.Name = "cboxMachInvertRelays";
            cboxMachInvertRelays.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            cboxMachInvertRelays.Size = new System.Drawing.Size(192, 98);
            cboxMachInvertRelays.TabIndex = 2;
            cboxMachInvertRelays.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            cboxMachInvertRelays.UseVisualStyleBackColor = false;
            cboxMachInvertRelays.Click += Enable_AlertM_Click;
            // 
            // btnSendMachinePGN
            // 
            btnSendMachinePGN.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnSendMachinePGN.BackColor = System.Drawing.Color.White;
            btnSendMachinePGN.FlatAppearance.BorderSize = 0;
            btnSendMachinePGN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSendMachinePGN.Image = Properties.Resources.ToolAcceptChange;
            btnSendMachinePGN.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnSendMachinePGN.Location = new System.Drawing.Point(704, 494);
            btnSendMachinePGN.Name = "btnSendMachinePGN";
            btnSendMachinePGN.Size = new System.Drawing.Size(103, 62);
            btnSendMachinePGN.TabIndex = 1;
            btnSendMachinePGN.UseVisualStyleBackColor = false;
            btnSendMachinePGN.Click += btnSendMachinePGN_Click;
            // 
            // tabTram
            // 
            tabTram.BackColor = System.Drawing.Color.WhiteSmoke;
            tabTram.Controls.Add(labelDisplay);
            tabTram.Controls.Add(labelOverride);
            tabTram.Controls.Add(lblTramWidthUnits);
            tabTram.Controls.Add(labelTramWidth);
            tabTram.Controls.Add(nudTramWidth);
            tabTram.Controls.Add(cboxDisplayTramControl);
            tabTram.Controls.Add(chkBoxOverrideTramControlPos);
            tabTram.Controls.Add(pictureBox8);
            tabTram.ForeColor = System.Drawing.Color.Black;
            tabTram.Location = new System.Drawing.Point(4, 44);
            tabTram.Name = "tabTram";
            tabTram.Size = new System.Drawing.Size(859, 584);
            tabTram.TabIndex = 21;
            tabTram.Text = "tTram";
            tabTram.Enter += tabTram_Enter;
            tabTram.Leave += tabTram_Leave;
            // 
            // labelDisplay
            // 
            labelDisplay.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelDisplay.BackColor = System.Drawing.Color.Transparent;
            labelDisplay.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelDisplay.ForeColor = System.Drawing.Color.Black;
            labelDisplay.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            labelDisplay.Location = new System.Drawing.Point(594, 13);
            labelDisplay.Name = "labelDisplay";
            labelDisplay.Size = new System.Drawing.Size(179, 16);
            labelDisplay.TabIndex = 486;
            labelDisplay.Text = "Display?";
            labelDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelOverride
            // 
            labelOverride.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelOverride.BackColor = System.Drawing.Color.Transparent;
            labelOverride.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelOverride.ForeColor = System.Drawing.Color.Black;
            labelOverride.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            labelOverride.Location = new System.Drawing.Point(301, 286);
            labelOverride.Name = "labelOverride";
            labelOverride.Size = new System.Drawing.Size(282, 16);
            labelOverride.TabIndex = 483;
            labelOverride.Text = "Overide";
            labelOverride.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTramWidthUnits
            // 
            lblTramWidthUnits.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblTramWidthUnits.AutoSize = true;
            lblTramWidthUnits.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblTramWidthUnits.ForeColor = System.Drawing.Color.Black;
            lblTramWidthUnits.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            lblTramWidthUnits.Location = new System.Drawing.Point(452, 120);
            lblTramWidthUnits.Name = "lblTramWidthUnits";
            lblTramWidthUnits.Size = new System.Drawing.Size(30, 19);
            lblTramWidthUnits.TabIndex = 478;
            lblTramWidthUnits.Text = "cm";
            lblTramWidthUnits.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTramWidth
            // 
            labelTramWidth.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelTramWidth.ForeColor = System.Drawing.Color.Black;
            labelTramWidth.Location = new System.Drawing.Point(292, 85);
            labelTramWidth.Name = "labelTramWidth";
            labelTramWidth.Size = new System.Drawing.Size(156, 16);
            labelTramWidth.TabIndex = 477;
            labelTramWidth.Text = "Tram Width";
            labelTramWidth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudTramWidth
            // 
            nudTramWidth.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            nudTramWidth.BackColor = System.Drawing.Color.AliceBlue;
            nudTramWidth.Cursor = System.Windows.Forms.Cursors.IBeam;
            nudTramWidth.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            nudTramWidth.InterceptArrowKeys = false;
            nudTramWidth.Location = new System.Drawing.Point(291, 105);
            nudTramWidth.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudTramWidth.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudTramWidth.Name = "nudTramWidth";
            nudTramWidth.ReadOnly = true;
            nudTramWidth.Size = new System.Drawing.Size(157, 52);
            nudTramWidth.TabIndex = 1;
            nudTramWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudTramWidth.Value = new decimal(new int[] { 5000, 0, 0, 0 });
            nudTramWidth.Click += nudTramWidth_Click;
            // 
            // cboxDisplayTramControl
            // 
            cboxDisplayTramControl.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            cboxDisplayTramControl.Appearance = System.Windows.Forms.Appearance.Button;
            cboxDisplayTramControl.BackColor = System.Drawing.Color.Transparent;
            cboxDisplayTramControl.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            cboxDisplayTramControl.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            cboxDisplayTramControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboxDisplayTramControl.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cboxDisplayTramControl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            cboxDisplayTramControl.Image = Properties.Resources.ConT_TramOverrideDisplay;
            cboxDisplayTramControl.Location = new System.Drawing.Point(594, 31);
            cboxDisplayTramControl.Name = "cboxDisplayTramControl";
            cboxDisplayTramControl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            cboxDisplayTramControl.Size = new System.Drawing.Size(179, 195);
            cboxDisplayTramControl.TabIndex = 485;
            cboxDisplayTramControl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            cboxDisplayTramControl.UseVisualStyleBackColor = false;
            // 
            // chkBoxOverrideTramControlPos
            // 
            chkBoxOverrideTramControlPos.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            chkBoxOverrideTramControlPos.Appearance = System.Windows.Forms.Appearance.Button;
            chkBoxOverrideTramControlPos.BackColor = System.Drawing.Color.Transparent;
            chkBoxOverrideTramControlPos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            chkBoxOverrideTramControlPos.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            chkBoxOverrideTramControlPos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            chkBoxOverrideTramControlPos.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            chkBoxOverrideTramControlPos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            chkBoxOverrideTramControlPos.Image = Properties.Resources.ConT_TramOverride;
            chkBoxOverrideTramControlPos.Location = new System.Drawing.Point(301, 305);
            chkBoxOverrideTramControlPos.Name = "chkBoxOverrideTramControlPos";
            chkBoxOverrideTramControlPos.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            chkBoxOverrideTramControlPos.Size = new System.Drawing.Size(282, 232);
            chkBoxOverrideTramControlPos.TabIndex = 484;
            chkBoxOverrideTramControlPos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            chkBoxOverrideTramControlPos.UseVisualStyleBackColor = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            pictureBox8.Image = Properties.Resources.ConT_TramSpacing;
            pictureBox8.Location = new System.Drawing.Point(107, 31);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new System.Drawing.Size(179, 195);
            pictureBox8.TabIndex = 119;
            pictureBox8.TabStop = false;
            // 
            // tabBtns
            // 
            tabBtns.BackColor = System.Drawing.Color.WhiteSmoke;
            tabBtns.Controls.Add(labelHardwareMessage);
            tabBtns.Controls.Add(labelPowerLossOnOff);
            tabBtns.Controls.Add(labelOffAgIO);
            tabBtns.Controls.Add(labelSectionSoundOnOff);
            tabBtns.Controls.Add(labelBottomMenu);
            tabBtns.Controls.Add(labelNudgeCtrlOnOff);
            tabBtns.Controls.Add(labelRightMenu);
            tabBtns.Controls.Add(labelStartAgIO);
            tabBtns.Controls.Add(labelHydLiftSoundOnOff);
            tabBtns.Controls.Add(labelAutosteerSoundOnOff);
            tabBtns.Controls.Add(labelUturnSoundOnOff);
            tabBtns.Controls.Add(labelSounds);
            tabBtns.Controls.Add(labelUturnOnOff);
            tabBtns.Controls.Add(labelLateralOnOff);
            tabBtns.Controls.Add(labelOffsetFixOnOff);
            tabBtns.Controls.Add(labelContourOnOff);
            tabBtns.Controls.Add(labelABSmoothOnOff);
            tabBtns.Controls.Add(labelRecPathOnOff);
            tabBtns.Controls.Add(labelBoundOnOff);
            tabBtns.Controls.Add(labelTramlineOnOff);
            tabBtns.Controls.Add(labelHeadlandOnOff);
            tabBtns.Controls.Add(labelScreenButtons);
            tabBtns.Controls.Add(labelToolsMenu);
            tabBtns.Controls.Add(labelFieldMenu);
            tabBtns.Controls.Add(label93);
            tabBtns.Controls.Add(cboxHardwareMessages);
            tabBtns.Controls.Add(cboxShutdownWhenNoPower);
            tabBtns.Controls.Add(cboxAutoOffAgIO);
            tabBtns.Controls.Add(cboxSectionsSound);
            tabBtns.Controls.Add(cboxFeatureNudge);
            tabBtns.Controls.Add(btnRightMenuOrder);
            tabBtns.Controls.Add(cboxAutoStartAgIO);
            tabBtns.Controls.Add(cboxHydLiftSound);
            tabBtns.Controls.Add(cboxTurnSound);
            tabBtns.Controls.Add(cboxSteerSound);
            tabBtns.Controls.Add(cboxFeatureLateral);
            tabBtns.Controls.Add(cboxFeatureUTurn);
            tabBtns.Controls.Add(cboxFeatureOffsetFix);
            tabBtns.Controls.Add(cboxFeatureHideContour);
            tabBtns.Controls.Add(cboxFeatureABSmooth);
            tabBtns.Controls.Add(cboxFeatureRecPath);
            tabBtns.Controls.Add(cboxFeatureBoundary);
            tabBtns.Controls.Add(cboxFeatureHeadland);
            tabBtns.Controls.Add(cboxFeatureTram);
            tabBtns.Location = new System.Drawing.Point(4, 44);
            tabBtns.Name = "tabBtns";
            tabBtns.Size = new System.Drawing.Size(859, 584);
            tabBtns.TabIndex = 22;
            tabBtns.Text = "fBtns";
            tabBtns.Enter += tabBtns_Enter;
            tabBtns.Leave += tabBtns_Leave;
            // 
            // labelHardwareMessage
            // 
            labelHardwareMessage.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelHardwareMessage.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelHardwareMessage.ForeColor = System.Drawing.Color.Black;
            labelHardwareMessage.Location = new System.Drawing.Point(530, 475);
            labelHardwareMessage.Name = "labelHardwareMessage";
            labelHardwareMessage.Size = new System.Drawing.Size(183, 16);
            labelHardwareMessage.TabIndex = 533;
            labelHardwareMessage.Text = "Hardware Messages";
            labelHardwareMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelPowerLossOnOff
            // 
            labelPowerLossOnOff.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelPowerLossOnOff.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelPowerLossOnOff.ForeColor = System.Drawing.Color.Black;
            labelPowerLossOnOff.Location = new System.Drawing.Point(10, 476);
            labelPowerLossOnOff.Name = "labelPowerLossOnOff";
            labelPowerLossOnOff.Size = new System.Drawing.Size(174, 16);
            labelPowerLossOnOff.TabIndex = 531;
            labelPowerLossOnOff.Text = "Power Loss Shutdown";
            labelPowerLossOnOff.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelOffAgIO
            // 
            labelOffAgIO.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelOffAgIO.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelOffAgIO.ForeColor = System.Drawing.Color.Black;
            labelOffAgIO.Location = new System.Drawing.Point(372, 475);
            labelOffAgIO.Name = "labelOffAgIO";
            labelOffAgIO.Size = new System.Drawing.Size(129, 16);
            labelOffAgIO.TabIndex = 529;
            labelOffAgIO.Text = "Auto Off AgIO?";
            labelOffAgIO.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelSectionSoundOnOff
            // 
            labelSectionSoundOnOff.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelSectionSoundOnOff.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelSectionSoundOnOff.ForeColor = System.Drawing.Color.Black;
            labelSectionSoundOnOff.Location = new System.Drawing.Point(719, 385);
            labelSectionSoundOnOff.Name = "labelSectionSoundOnOff";
            labelSectionSoundOnOff.Size = new System.Drawing.Size(77, 16);
            labelSectionSoundOnOff.TabIndex = 526;
            labelSectionSoundOnOff.Text = "Sections";
            labelSectionSoundOnOff.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelBottomMenu
            // 
            labelBottomMenu.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelBottomMenu.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelBottomMenu.ForeColor = System.Drawing.Color.Black;
            labelBottomMenu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            labelBottomMenu.Location = new System.Drawing.Point(363, 159);
            labelBottomMenu.Name = "labelBottomMenu";
            labelBottomMenu.Size = new System.Drawing.Size(190, 25);
            labelBottomMenu.TabIndex = 524;
            labelBottomMenu.Text = "Bottom Menu";
            labelBottomMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNudgeCtrlOnOff
            // 
            labelNudgeCtrlOnOff.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelNudgeCtrlOnOff.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelNudgeCtrlOnOff.ForeColor = System.Drawing.Color.Black;
            labelNudgeCtrlOnOff.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            labelNudgeCtrlOnOff.Location = new System.Drawing.Point(372, 185);
            labelNudgeCtrlOnOff.Name = "labelNudgeCtrlOnOff";
            labelNudgeCtrlOnOff.Size = new System.Drawing.Size(186, 25);
            labelNudgeCtrlOnOff.TabIndex = 523;
            labelNudgeCtrlOnOff.Text = "Nudge Controls";
            labelNudgeCtrlOnOff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRightMenu
            // 
            labelRightMenu.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelRightMenu.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelRightMenu.ForeColor = System.Drawing.Color.Black;
            labelRightMenu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            labelRightMenu.Location = new System.Drawing.Point(368, 316);
            labelRightMenu.Name = "labelRightMenu";
            labelRightMenu.Size = new System.Drawing.Size(190, 25);
            labelRightMenu.TabIndex = 521;
            labelRightMenu.Text = "Right Menu";
            labelRightMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelStartAgIO
            // 
            labelStartAgIO.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelStartAgIO.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelStartAgIO.ForeColor = System.Drawing.Color.Black;
            labelStartAgIO.Location = new System.Drawing.Point(216, 475);
            labelStartAgIO.Name = "labelStartAgIO";
            labelStartAgIO.Size = new System.Drawing.Size(132, 16);
            labelStartAgIO.TabIndex = 518;
            labelStartAgIO.Text = "Auto Start AgIO?";
            labelStartAgIO.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelHydLiftSoundOnOff
            // 
            labelHydLiftSoundOnOff.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelHydLiftSoundOnOff.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelHydLiftSoundOnOff.ForeColor = System.Drawing.Color.Black;
            labelHydLiftSoundOnOff.Location = new System.Drawing.Point(719, 270);
            labelHydLiftSoundOnOff.Name = "labelHydLiftSoundOnOff";
            labelHydLiftSoundOnOff.Size = new System.Drawing.Size(77, 16);
            labelHydLiftSoundOnOff.TabIndex = 516;
            labelHydLiftSoundOnOff.Text = "Hyd Lift";
            labelHydLiftSoundOnOff.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelAutosteerSoundOnOff
            // 
            labelAutosteerSoundOnOff.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelAutosteerSoundOnOff.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelAutosteerSoundOnOff.ForeColor = System.Drawing.Color.Black;
            labelAutosteerSoundOnOff.Location = new System.Drawing.Point(716, 40);
            labelAutosteerSoundOnOff.Name = "labelAutosteerSoundOnOff";
            labelAutosteerSoundOnOff.Size = new System.Drawing.Size(80, 16);
            labelAutosteerSoundOnOff.TabIndex = 514;
            labelAutosteerSoundOnOff.Text = "Auto Steer";
            labelAutosteerSoundOnOff.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelUturnSoundOnOff
            // 
            labelUturnSoundOnOff.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelUturnSoundOnOff.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelUturnSoundOnOff.ForeColor = System.Drawing.Color.Black;
            labelUturnSoundOnOff.Location = new System.Drawing.Point(719, 155);
            labelUturnSoundOnOff.Name = "labelUturnSoundOnOff";
            labelUturnSoundOnOff.Size = new System.Drawing.Size(77, 16);
            labelUturnSoundOnOff.TabIndex = 513;
            labelUturnSoundOnOff.Text = "You Turn";
            labelUturnSoundOnOff.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelSounds
            // 
            labelSounds.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelSounds.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelSounds.ForeColor = System.Drawing.Color.Black;
            labelSounds.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            labelSounds.Location = new System.Drawing.Point(690, 2);
            labelSounds.Name = "labelSounds";
            labelSounds.Size = new System.Drawing.Size(128, 25);
            labelSounds.TabIndex = 512;
            labelSounds.Text = "Sound";
            labelSounds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelUturnOnOff
            // 
            labelUturnOnOff.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelUturnOnOff.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelUturnOnOff.ForeColor = System.Drawing.Color.Black;
            labelUturnOnOff.Location = new System.Drawing.Point(367, 40);
            labelUturnOnOff.Name = "labelUturnOnOff";
            labelUturnOnOff.Size = new System.Drawing.Size(78, 16);
            labelUturnOnOff.TabIndex = 509;
            labelUturnOnOff.Text = "U-Turn";
            labelUturnOnOff.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelLateralOnOff
            // 
            labelLateralOnOff.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelLateralOnOff.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelLateralOnOff.ForeColor = System.Drawing.Color.Black;
            labelLateralOnOff.Location = new System.Drawing.Point(476, 41);
            labelLateralOnOff.Name = "labelLateralOnOff";
            labelLateralOnOff.Size = new System.Drawing.Size(77, 16);
            labelLateralOnOff.TabIndex = 508;
            labelLateralOnOff.Text = "Lateral";
            labelLateralOnOff.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelOffsetFixOnOff
            // 
            labelOffsetFixOnOff.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelOffsetFixOnOff.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelOffsetFixOnOff.ForeColor = System.Drawing.Color.Black;
            labelOffsetFixOnOff.Location = new System.Drawing.Point(143, 352);
            labelOffsetFixOnOff.Name = "labelOffsetFixOnOff";
            labelOffsetFixOnOff.Size = new System.Drawing.Size(144, 16);
            labelOffsetFixOnOff.TabIndex = 488;
            labelOffsetFixOnOff.Text = "Offset Fix";
            labelOffsetFixOnOff.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelContourOnOff
            // 
            labelContourOnOff.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelContourOnOff.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelContourOnOff.ForeColor = System.Drawing.Color.Black;
            labelContourOnOff.Location = new System.Drawing.Point(143, 144);
            labelContourOnOff.Name = "labelContourOnOff";
            labelContourOnOff.Size = new System.Drawing.Size(144, 16);
            labelContourOnOff.TabIndex = 486;
            labelContourOnOff.Text = "Hide Contour";
            labelContourOnOff.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelABSmoothOnOff
            // 
            labelABSmoothOnOff.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelABSmoothOnOff.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelABSmoothOnOff.ForeColor = System.Drawing.Color.Black;
            labelABSmoothOnOff.Location = new System.Drawing.Point(140, 40);
            labelABSmoothOnOff.Name = "labelABSmoothOnOff";
            labelABSmoothOnOff.Size = new System.Drawing.Size(147, 16);
            labelABSmoothOnOff.TabIndex = 485;
            labelABSmoothOnOff.Text = "AB Smooth";
            labelABSmoothOnOff.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelRecPathOnOff
            // 
            labelRecPathOnOff.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelRecPathOnOff.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelRecPathOnOff.ForeColor = System.Drawing.Color.Black;
            labelRecPathOnOff.Location = new System.Drawing.Point(9, 352);
            labelRecPathOnOff.Name = "labelRecPathOnOff";
            labelRecPathOnOff.Size = new System.Drawing.Size(125, 16);
            labelRecPathOnOff.TabIndex = 484;
            labelRecPathOnOff.Text = "Rec Path";
            labelRecPathOnOff.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelBoundOnOff
            // 
            labelBoundOnOff.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelBoundOnOff.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelBoundOnOff.ForeColor = System.Drawing.Color.Black;
            labelBoundOnOff.Location = new System.Drawing.Point(6, 248);
            labelBoundOnOff.Name = "labelBoundOnOff";
            labelBoundOnOff.Size = new System.Drawing.Size(128, 16);
            labelBoundOnOff.TabIndex = 482;
            labelBoundOnOff.Text = "Boundary";
            labelBoundOnOff.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelTramlineOnOff
            // 
            labelTramlineOnOff.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelTramlineOnOff.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelTramlineOnOff.ForeColor = System.Drawing.Color.Black;
            labelTramlineOnOff.Location = new System.Drawing.Point(3, 40);
            labelTramlineOnOff.Name = "labelTramlineOnOff";
            labelTramlineOnOff.Size = new System.Drawing.Size(131, 16);
            labelTramlineOnOff.TabIndex = 481;
            labelTramlineOnOff.Text = "Tram Lines";
            labelTramlineOnOff.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelHeadlandOnOff
            // 
            labelHeadlandOnOff.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelHeadlandOnOff.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelHeadlandOnOff.ForeColor = System.Drawing.Color.Black;
            labelHeadlandOnOff.Location = new System.Drawing.Point(10, 144);
            labelHeadlandOnOff.Name = "labelHeadlandOnOff";
            labelHeadlandOnOff.Size = new System.Drawing.Size(124, 16);
            labelHeadlandOnOff.TabIndex = 480;
            labelHeadlandOnOff.Text = "Headland";
            labelHeadlandOnOff.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelScreenButtons
            // 
            labelScreenButtons.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelScreenButtons.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelScreenButtons.ForeColor = System.Drawing.Color.Black;
            labelScreenButtons.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            labelScreenButtons.Location = new System.Drawing.Point(323, 2);
            labelScreenButtons.Name = "labelScreenButtons";
            labelScreenButtons.Size = new System.Drawing.Size(284, 25);
            labelScreenButtons.TabIndex = 474;
            labelScreenButtons.Text = "Screen Buttons";
            labelScreenButtons.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelToolsMenu
            // 
            labelToolsMenu.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelToolsMenu.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelToolsMenu.ForeColor = System.Drawing.Color.Black;
            labelToolsMenu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            labelToolsMenu.Location = new System.Drawing.Point(144, 2);
            labelToolsMenu.Name = "labelToolsMenu";
            labelToolsMenu.Size = new System.Drawing.Size(128, 25);
            labelToolsMenu.TabIndex = 468;
            labelToolsMenu.Text = "Tools Menu";
            labelToolsMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFieldMenu
            // 
            labelFieldMenu.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelFieldMenu.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelFieldMenu.ForeColor = System.Drawing.Color.Black;
            labelFieldMenu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            labelFieldMenu.Location = new System.Drawing.Point(6, 2);
            labelFieldMenu.Name = "labelFieldMenu";
            labelFieldMenu.Size = new System.Drawing.Size(128, 25);
            labelFieldMenu.TabIndex = 455;
            labelFieldMenu.Text = "Field Menu";
            labelFieldMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label93
            // 
            label93.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label93.AutoSize = true;
            label93.BackColor = System.Drawing.Color.Transparent;
            label93.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label93.ForeColor = System.Drawing.Color.Black;
            label93.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label93.Location = new System.Drawing.Point(515, 377);
            label93.Name = "label93";
            label93.Size = new System.Drawing.Size(43, 29);
            label93.TabIndex = 455;
            label93.Text = "->";
            label93.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboxHardwareMessages
            // 
            cboxHardwareMessages.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            cboxHardwareMessages.Appearance = System.Windows.Forms.Appearance.Button;
            cboxHardwareMessages.BackColor = System.Drawing.Color.WhiteSmoke;
            cboxHardwareMessages.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            cboxHardwareMessages.FlatAppearance.BorderSize = 2;
            cboxHardwareMessages.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            cboxHardwareMessages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboxHardwareMessages.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cboxHardwareMessages.ForeColor = System.Drawing.Color.Red;
            cboxHardwareMessages.Image = Properties.Resources.HardwareMessage;
            cboxHardwareMessages.Location = new System.Drawing.Point(561, 495);
            cboxHardwareMessages.Name = "cboxHardwareMessages";
            cboxHardwareMessages.Size = new System.Drawing.Size(123, 77);
            cboxHardwareMessages.TabIndex = 532;
            cboxHardwareMessages.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            cboxHardwareMessages.UseVisualStyleBackColor = false;
            // 
            // cboxShutdownWhenNoPower
            // 
            cboxShutdownWhenNoPower.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            cboxShutdownWhenNoPower.Appearance = System.Windows.Forms.Appearance.Button;
            cboxShutdownWhenNoPower.BackColor = System.Drawing.Color.WhiteSmoke;
            cboxShutdownWhenNoPower.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            cboxShutdownWhenNoPower.FlatAppearance.BorderSize = 2;
            cboxShutdownWhenNoPower.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            cboxShutdownWhenNoPower.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboxShutdownWhenNoPower.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cboxShutdownWhenNoPower.ForeColor = System.Drawing.Color.Red;
            cboxShutdownWhenNoPower.Image = Properties.Resources.ChargingNo;
            cboxShutdownWhenNoPower.Location = new System.Drawing.Point(38, 495);
            cboxShutdownWhenNoPower.Name = "cboxShutdownWhenNoPower";
            cboxShutdownWhenNoPower.Size = new System.Drawing.Size(114, 77);
            cboxShutdownWhenNoPower.TabIndex = 530;
            cboxShutdownWhenNoPower.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            cboxShutdownWhenNoPower.UseVisualStyleBackColor = false;
            // 
            // cboxAutoOffAgIO
            // 
            cboxAutoOffAgIO.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            cboxAutoOffAgIO.Appearance = System.Windows.Forms.Appearance.Button;
            cboxAutoOffAgIO.BackColor = System.Drawing.Color.WhiteSmoke;
            cboxAutoOffAgIO.Checked = true;
            cboxAutoOffAgIO.CheckState = System.Windows.Forms.CheckState.Checked;
            cboxAutoOffAgIO.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            cboxAutoOffAgIO.FlatAppearance.BorderSize = 2;
            cboxAutoOffAgIO.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            cboxAutoOffAgIO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboxAutoOffAgIO.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cboxAutoOffAgIO.ForeColor = System.Drawing.Color.Red;
            cboxAutoOffAgIO.Image = Properties.Resources.AgIO;
            cboxAutoOffAgIO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            cboxAutoOffAgIO.Location = new System.Drawing.Point(372, 495);
            cboxAutoOffAgIO.Margin = new System.Windows.Forms.Padding(0);
            cboxAutoOffAgIO.Name = "cboxAutoOffAgIO";
            cboxAutoOffAgIO.Size = new System.Drawing.Size(129, 77);
            cboxAutoOffAgIO.TabIndex = 528;
            cboxAutoOffAgIO.Text = "OFF";
            cboxAutoOffAgIO.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            cboxAutoOffAgIO.UseVisualStyleBackColor = false;
            // 
            // cboxSectionsSound
            // 
            cboxSectionsSound.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            cboxSectionsSound.Appearance = System.Windows.Forms.Appearance.Button;
            cboxSectionsSound.BackColor = System.Drawing.Color.WhiteSmoke;
            cboxSectionsSound.Checked = true;
            cboxSectionsSound.CheckState = System.Windows.Forms.CheckState.Checked;
            cboxSectionsSound.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            cboxSectionsSound.FlatAppearance.BorderSize = 2;
            cboxSectionsSound.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            cboxSectionsSound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboxSectionsSound.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cboxSectionsSound.ForeColor = System.Drawing.SystemColors.ControlText;
            cboxSectionsSound.Image = Properties.Resources.ConF_SoundSections;
            cboxSectionsSound.Location = new System.Drawing.Point(719, 404);
            cboxSectionsSound.Name = "cboxSectionsSound";
            cboxSectionsSound.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            cboxSectionsSound.Size = new System.Drawing.Size(77, 77);
            cboxSectionsSound.TabIndex = 525;
            cboxSectionsSound.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            cboxSectionsSound.UseVisualStyleBackColor = false;
            // 
            // cboxFeatureNudge
            // 
            cboxFeatureNudge.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            cboxFeatureNudge.Appearance = System.Windows.Forms.Appearance.Button;
            cboxFeatureNudge.BackColor = System.Drawing.Color.WhiteSmoke;
            cboxFeatureNudge.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            cboxFeatureNudge.Checked = true;
            cboxFeatureNudge.CheckState = System.Windows.Forms.CheckState.Checked;
            cboxFeatureNudge.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            cboxFeatureNudge.FlatAppearance.BorderSize = 2;
            cboxFeatureNudge.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            cboxFeatureNudge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboxFeatureNudge.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cboxFeatureNudge.ForeColor = System.Drawing.SystemColors.ControlText;
            cboxFeatureNudge.Image = Properties.Resources.SnapToPivot;
            cboxFeatureNudge.Location = new System.Drawing.Point(424, 213);
            cboxFeatureNudge.Name = "cboxFeatureNudge";
            cboxFeatureNudge.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            cboxFeatureNudge.Size = new System.Drawing.Size(77, 77);
            cboxFeatureNudge.TabIndex = 522;
            cboxFeatureNudge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            cboxFeatureNudge.UseVisualStyleBackColor = false;
            // 
            // btnRightMenuOrder
            // 
            btnRightMenuOrder.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnRightMenuOrder.BackColor = System.Drawing.Color.Transparent;
            btnRightMenuOrder.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            btnRightMenuOrder.FlatAppearance.CheckedBackColor = System.Drawing.Color.Teal;
            btnRightMenuOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRightMenuOrder.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnRightMenuOrder.ForeColor = System.Drawing.Color.Black;
            btnRightMenuOrder.Image = Properties.Resources.Con_RightMenuEdit;
            btnRightMenuOrder.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnRightMenuOrder.Location = new System.Drawing.Point(415, 344);
            btnRightMenuOrder.Name = "btnRightMenuOrder";
            btnRightMenuOrder.Size = new System.Drawing.Size(99, 95);
            btnRightMenuOrder.TabIndex = 520;
            btnRightMenuOrder.UseVisualStyleBackColor = false;
            btnRightMenuOrder.Click += btnRightMenuOrder_Click;
            // 
            // cboxAutoStartAgIO
            // 
            cboxAutoStartAgIO.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            cboxAutoStartAgIO.Appearance = System.Windows.Forms.Appearance.Button;
            cboxAutoStartAgIO.BackColor = System.Drawing.Color.WhiteSmoke;
            cboxAutoStartAgIO.Checked = true;
            cboxAutoStartAgIO.CheckState = System.Windows.Forms.CheckState.Checked;
            cboxAutoStartAgIO.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            cboxAutoStartAgIO.FlatAppearance.BorderSize = 2;
            cboxAutoStartAgIO.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            cboxAutoStartAgIO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboxAutoStartAgIO.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cboxAutoStartAgIO.ForeColor = System.Drawing.SystemColors.ControlText;
            cboxAutoStartAgIO.Image = Properties.Resources.AgIO;
            cboxAutoStartAgIO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            cboxAutoStartAgIO.Location = new System.Drawing.Point(219, 495);
            cboxAutoStartAgIO.Name = "cboxAutoStartAgIO";
            cboxAutoStartAgIO.Size = new System.Drawing.Size(129, 77);
            cboxAutoStartAgIO.TabIndex = 517;
            cboxAutoStartAgIO.Text = "ON";
            cboxAutoStartAgIO.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            cboxAutoStartAgIO.UseVisualStyleBackColor = false;
            // 
            // cboxHydLiftSound
            // 
            cboxHydLiftSound.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            cboxHydLiftSound.Appearance = System.Windows.Forms.Appearance.Button;
            cboxHydLiftSound.BackColor = System.Drawing.Color.WhiteSmoke;
            cboxHydLiftSound.Checked = true;
            cboxHydLiftSound.CheckState = System.Windows.Forms.CheckState.Checked;
            cboxHydLiftSound.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            cboxHydLiftSound.FlatAppearance.BorderSize = 2;
            cboxHydLiftSound.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            cboxHydLiftSound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboxHydLiftSound.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cboxHydLiftSound.ForeColor = System.Drawing.SystemColors.ControlText;
            cboxHydLiftSound.Image = Properties.Resources.ConF_HydLiftSound;
            cboxHydLiftSound.Location = new System.Drawing.Point(719, 289);
            cboxHydLiftSound.Name = "cboxHydLiftSound";
            cboxHydLiftSound.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            cboxHydLiftSound.Size = new System.Drawing.Size(77, 77);
            cboxHydLiftSound.TabIndex = 515;
            cboxHydLiftSound.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            cboxHydLiftSound.UseVisualStyleBackColor = false;
            // 
            // cboxTurnSound
            // 
            cboxTurnSound.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            cboxTurnSound.Appearance = System.Windows.Forms.Appearance.Button;
            cboxTurnSound.BackColor = System.Drawing.Color.WhiteSmoke;
            cboxTurnSound.Checked = true;
            cboxTurnSound.CheckState = System.Windows.Forms.CheckState.Checked;
            cboxTurnSound.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            cboxTurnSound.FlatAppearance.BorderSize = 2;
            cboxTurnSound.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            cboxTurnSound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboxTurnSound.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cboxTurnSound.ForeColor = System.Drawing.SystemColors.ControlText;
            cboxTurnSound.Image = Properties.Resources.ConF_TurnSound;
            cboxTurnSound.Location = new System.Drawing.Point(719, 174);
            cboxTurnSound.Name = "cboxTurnSound";
            cboxTurnSound.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            cboxTurnSound.Size = new System.Drawing.Size(77, 77);
            cboxTurnSound.TabIndex = 511;
            cboxTurnSound.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            cboxTurnSound.UseVisualStyleBackColor = false;
            // 
            // cboxSteerSound
            // 
            cboxSteerSound.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            cboxSteerSound.Appearance = System.Windows.Forms.Appearance.Button;
            cboxSteerSound.BackColor = System.Drawing.Color.WhiteSmoke;
            cboxSteerSound.Checked = true;
            cboxSteerSound.CheckState = System.Windows.Forms.CheckState.Checked;
            cboxSteerSound.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            cboxSteerSound.FlatAppearance.BorderSize = 2;
            cboxSteerSound.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            cboxSteerSound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboxSteerSound.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cboxSteerSound.ForeColor = System.Drawing.SystemColors.ControlText;
            cboxSteerSound.Image = Properties.Resources.ConF_SteerSound;
            cboxSteerSound.Location = new System.Drawing.Point(719, 59);
            cboxSteerSound.Name = "cboxSteerSound";
            cboxSteerSound.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            cboxSteerSound.Size = new System.Drawing.Size(77, 77);
            cboxSteerSound.TabIndex = 510;
            cboxSteerSound.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            cboxSteerSound.UseVisualStyleBackColor = false;
            // 
            // cboxFeatureLateral
            // 
            cboxFeatureLateral.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            cboxFeatureLateral.Appearance = System.Windows.Forms.Appearance.Button;
            cboxFeatureLateral.BackColor = System.Drawing.Color.WhiteSmoke;
            cboxFeatureLateral.BackgroundImage = Properties.Resources.z_LateralManual;
            cboxFeatureLateral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            cboxFeatureLateral.Checked = true;
            cboxFeatureLateral.CheckState = System.Windows.Forms.CheckState.Checked;
            cboxFeatureLateral.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            cboxFeatureLateral.FlatAppearance.BorderSize = 2;
            cboxFeatureLateral.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            cboxFeatureLateral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboxFeatureLateral.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cboxFeatureLateral.ForeColor = System.Drawing.SystemColors.ControlText;
            cboxFeatureLateral.Location = new System.Drawing.Point(476, 59);
            cboxFeatureLateral.Name = "cboxFeatureLateral";
            cboxFeatureLateral.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            cboxFeatureLateral.Size = new System.Drawing.Size(77, 77);
            cboxFeatureLateral.TabIndex = 507;
            cboxFeatureLateral.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            cboxFeatureLateral.UseVisualStyleBackColor = false;
            // 
            // cboxFeatureUTurn
            // 
            cboxFeatureUTurn.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            cboxFeatureUTurn.Appearance = System.Windows.Forms.Appearance.Button;
            cboxFeatureUTurn.BackColor = System.Drawing.Color.WhiteSmoke;
            cboxFeatureUTurn.BackgroundImage = Properties.Resources.z_TurnManual;
            cboxFeatureUTurn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            cboxFeatureUTurn.Checked = true;
            cboxFeatureUTurn.CheckState = System.Windows.Forms.CheckState.Checked;
            cboxFeatureUTurn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            cboxFeatureUTurn.FlatAppearance.BorderSize = 2;
            cboxFeatureUTurn.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            cboxFeatureUTurn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboxFeatureUTurn.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cboxFeatureUTurn.ForeColor = System.Drawing.SystemColors.ControlText;
            cboxFeatureUTurn.Location = new System.Drawing.Point(368, 59);
            cboxFeatureUTurn.Name = "cboxFeatureUTurn";
            cboxFeatureUTurn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            cboxFeatureUTurn.Size = new System.Drawing.Size(77, 77);
            cboxFeatureUTurn.TabIndex = 506;
            cboxFeatureUTurn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            cboxFeatureUTurn.UseVisualStyleBackColor = false;
            // 
            // cboxFeatureOffsetFix
            // 
            cboxFeatureOffsetFix.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            cboxFeatureOffsetFix.Appearance = System.Windows.Forms.Appearance.Button;
            cboxFeatureOffsetFix.BackColor = System.Drawing.Color.WhiteSmoke;
            cboxFeatureOffsetFix.Checked = true;
            cboxFeatureOffsetFix.CheckState = System.Windows.Forms.CheckState.Checked;
            cboxFeatureOffsetFix.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            cboxFeatureOffsetFix.FlatAppearance.BorderSize = 2;
            cboxFeatureOffsetFix.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            cboxFeatureOffsetFix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboxFeatureOffsetFix.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cboxFeatureOffsetFix.ForeColor = System.Drawing.SystemColors.ControlText;
            cboxFeatureOffsetFix.Image = Properties.Resources.YouTurnReverse;
            cboxFeatureOffsetFix.Location = new System.Drawing.Point(174, 371);
            cboxFeatureOffsetFix.Name = "cboxFeatureOffsetFix";
            cboxFeatureOffsetFix.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            cboxFeatureOffsetFix.Size = new System.Drawing.Size(77, 77);
            cboxFeatureOffsetFix.TabIndex = 472;
            cboxFeatureOffsetFix.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            cboxFeatureOffsetFix.UseVisualStyleBackColor = false;
            // 
            // cboxFeatureHideContour
            // 
            cboxFeatureHideContour.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            cboxFeatureHideContour.Appearance = System.Windows.Forms.Appearance.Button;
            cboxFeatureHideContour.BackColor = System.Drawing.Color.WhiteSmoke;
            cboxFeatureHideContour.Checked = true;
            cboxFeatureHideContour.CheckState = System.Windows.Forms.CheckState.Checked;
            cboxFeatureHideContour.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            cboxFeatureHideContour.FlatAppearance.BorderSize = 2;
            cboxFeatureHideContour.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            cboxFeatureHideContour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboxFeatureHideContour.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cboxFeatureHideContour.ForeColor = System.Drawing.SystemColors.ControlText;
            cboxFeatureHideContour.Image = Properties.Resources.Trash;
            cboxFeatureHideContour.Location = new System.Drawing.Point(174, 163);
            cboxFeatureHideContour.Name = "cboxFeatureHideContour";
            cboxFeatureHideContour.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            cboxFeatureHideContour.Size = new System.Drawing.Size(77, 77);
            cboxFeatureHideContour.TabIndex = 470;
            cboxFeatureHideContour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            cboxFeatureHideContour.UseVisualStyleBackColor = false;
            // 
            // cboxFeatureABSmooth
            // 
            cboxFeatureABSmooth.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            cboxFeatureABSmooth.Appearance = System.Windows.Forms.Appearance.Button;
            cboxFeatureABSmooth.BackColor = System.Drawing.Color.WhiteSmoke;
            cboxFeatureABSmooth.Checked = true;
            cboxFeatureABSmooth.CheckState = System.Windows.Forms.CheckState.Checked;
            cboxFeatureABSmooth.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            cboxFeatureABSmooth.FlatAppearance.BorderSize = 2;
            cboxFeatureABSmooth.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            cboxFeatureABSmooth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboxFeatureABSmooth.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cboxFeatureABSmooth.ForeColor = System.Drawing.SystemColors.ControlText;
            cboxFeatureABSmooth.Image = Properties.Resources.ABSmooth;
            cboxFeatureABSmooth.Location = new System.Drawing.Point(174, 59);
            cboxFeatureABSmooth.Name = "cboxFeatureABSmooth";
            cboxFeatureABSmooth.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            cboxFeatureABSmooth.Size = new System.Drawing.Size(77, 77);
            cboxFeatureABSmooth.TabIndex = 469;
            cboxFeatureABSmooth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            cboxFeatureABSmooth.UseVisualStyleBackColor = false;
            // 
            // cboxFeatureRecPath
            // 
            cboxFeatureRecPath.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            cboxFeatureRecPath.Appearance = System.Windows.Forms.Appearance.Button;
            cboxFeatureRecPath.BackColor = System.Drawing.Color.WhiteSmoke;
            cboxFeatureRecPath.Checked = true;
            cboxFeatureRecPath.CheckState = System.Windows.Forms.CheckState.Checked;
            cboxFeatureRecPath.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            cboxFeatureRecPath.FlatAppearance.BorderSize = 2;
            cboxFeatureRecPath.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            cboxFeatureRecPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboxFeatureRecPath.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cboxFeatureRecPath.ForeColor = System.Drawing.SystemColors.ControlText;
            cboxFeatureRecPath.Image = Properties.Resources.RecPath;
            cboxFeatureRecPath.Location = new System.Drawing.Point(33, 371);
            cboxFeatureRecPath.Name = "cboxFeatureRecPath";
            cboxFeatureRecPath.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            cboxFeatureRecPath.Size = new System.Drawing.Size(77, 77);
            cboxFeatureRecPath.TabIndex = 467;
            cboxFeatureRecPath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            cboxFeatureRecPath.UseVisualStyleBackColor = false;
            // 
            // cboxFeatureBoundary
            // 
            cboxFeatureBoundary.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            cboxFeatureBoundary.Appearance = System.Windows.Forms.Appearance.Button;
            cboxFeatureBoundary.BackColor = System.Drawing.Color.WhiteSmoke;
            cboxFeatureBoundary.Checked = true;
            cboxFeatureBoundary.CheckState = System.Windows.Forms.CheckState.Checked;
            cboxFeatureBoundary.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            cboxFeatureBoundary.FlatAppearance.BorderSize = 2;
            cboxFeatureBoundary.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            cboxFeatureBoundary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboxFeatureBoundary.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cboxFeatureBoundary.ForeColor = System.Drawing.SystemColors.ControlText;
            cboxFeatureBoundary.Image = Properties.Resources.Boundary;
            cboxFeatureBoundary.Location = new System.Drawing.Point(33, 267);
            cboxFeatureBoundary.Name = "cboxFeatureBoundary";
            cboxFeatureBoundary.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            cboxFeatureBoundary.Size = new System.Drawing.Size(77, 77);
            cboxFeatureBoundary.TabIndex = 465;
            cboxFeatureBoundary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            cboxFeatureBoundary.UseVisualStyleBackColor = false;
            // 
            // cboxFeatureHeadland
            // 
            cboxFeatureHeadland.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            cboxFeatureHeadland.Appearance = System.Windows.Forms.Appearance.Button;
            cboxFeatureHeadland.BackColor = System.Drawing.Color.WhiteSmoke;
            cboxFeatureHeadland.Checked = true;
            cboxFeatureHeadland.CheckState = System.Windows.Forms.CheckState.Checked;
            cboxFeatureHeadland.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            cboxFeatureHeadland.FlatAppearance.BorderSize = 2;
            cboxFeatureHeadland.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            cboxFeatureHeadland.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboxFeatureHeadland.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cboxFeatureHeadland.ForeColor = System.Drawing.SystemColors.ControlText;
            cboxFeatureHeadland.Image = Properties.Resources.HeadlandOn;
            cboxFeatureHeadland.Location = new System.Drawing.Point(33, 163);
            cboxFeatureHeadland.Name = "cboxFeatureHeadland";
            cboxFeatureHeadland.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            cboxFeatureHeadland.Size = new System.Drawing.Size(77, 77);
            cboxFeatureHeadland.TabIndex = 464;
            cboxFeatureHeadland.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            cboxFeatureHeadland.UseVisualStyleBackColor = false;
            // 
            // cboxFeatureTram
            // 
            cboxFeatureTram.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            cboxFeatureTram.Appearance = System.Windows.Forms.Appearance.Button;
            cboxFeatureTram.BackColor = System.Drawing.Color.WhiteSmoke;
            cboxFeatureTram.Checked = true;
            cboxFeatureTram.CheckState = System.Windows.Forms.CheckState.Checked;
            cboxFeatureTram.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            cboxFeatureTram.FlatAppearance.BorderSize = 2;
            cboxFeatureTram.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            cboxFeatureTram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboxFeatureTram.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cboxFeatureTram.ForeColor = System.Drawing.SystemColors.ControlText;
            cboxFeatureTram.Image = Properties.Resources.TramAll;
            cboxFeatureTram.Location = new System.Drawing.Point(33, 59);
            cboxFeatureTram.Name = "cboxFeatureTram";
            cboxFeatureTram.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            cboxFeatureTram.Size = new System.Drawing.Size(77, 77);
            cboxFeatureTram.TabIndex = 463;
            cboxFeatureTram.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            cboxFeatureTram.UseVisualStyleBackColor = false;
            // 
            // tabDisplay
            // 
            tabDisplay.BackColor = System.Drawing.Color.WhiteSmoke;
            tabDisplay.Controls.Add(lblHeadlandDist);
            tabDisplay.Controls.Add(chkboxHeadlandDist);
            tabDisplay.Controls.Add(labelLineSmoothOnOff);
            tabDisplay.Controls.Add(labelSectionLinesOnOff);
            tabDisplay.Controls.Add(labelDirectionMarkOnOff);
            tabDisplay.Controls.Add(labelElevationOnOff);
            tabDisplay.Controls.Add(unitsGroupBox);
            tabDisplay.Controls.Add(labelSvenArrowOnOff);
            tabDisplay.Controls.Add(labelBrightnessOnOff);
            tabDisplay.Controls.Add(labelFieldTextureOnOff);
            tabDisplay.Controls.Add(labelPolyOnOff);
            tabDisplay.Controls.Add(labelKeyboardOnOff);
            tabDisplay.Controls.Add(labelFullscreenOnOff);
            tabDisplay.Controls.Add(labelSpeedoOnOff);
            tabDisplay.Controls.Add(labelGuideLinesOnOff);
            tabDisplay.Controls.Add(labelGridOnOff);
            tabDisplay.Controls.Add(nudNumGuideLines);
            tabDisplay.Controls.Add(chkLineSmooth);
            tabDisplay.Controls.Add(chkSectionLines);
            tabDisplay.Controls.Add(chkDirectionMarkers);
            tabDisplay.Controls.Add(chkDisplayLogElevation);
            tabDisplay.Controls.Add(chkSvennArrow);
            tabDisplay.Controls.Add(chkDisplayBrightness);
            tabDisplay.Controls.Add(chkDisplayFloor);
            tabDisplay.Controls.Add(chkDisplayKeyboard);
            tabDisplay.Controls.Add(chkDisplayPolygons);
            tabDisplay.Controls.Add(chkDisplayStartFullScreen);
            tabDisplay.Controls.Add(chkDisplayGrid);
            tabDisplay.Controls.Add(chkDisplaySpeedo);
            tabDisplay.Controls.Add(chkDisplayExtraGuides);
            tabDisplay.Location = new System.Drawing.Point(4, 44);
            tabDisplay.Name = "tabDisplay";
            tabDisplay.Padding = new System.Windows.Forms.Padding(3);
            tabDisplay.Size = new System.Drawing.Size(859, 584);
            tabDisplay.TabIndex = 25;
            tabDisplay.Text = "fDisp";
            tabDisplay.Enter += tabDisplay_Enter;
            tabDisplay.Leave += tabDisplay_Leave;
            // 
            // lblHeadlandDist
            // 
            lblHeadlandDist.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblHeadlandDist.BackColor = System.Drawing.Color.Transparent;
            lblHeadlandDist.ForeColor = System.Drawing.Color.Black;
            lblHeadlandDist.Location = new System.Drawing.Point(609, 108);
            lblHeadlandDist.Name = "lblHeadlandDist";
            lblHeadlandDist.Size = new System.Drawing.Size(100, 16);
            lblHeadlandDist.TabIndex = 541;
            lblHeadlandDist.Text = "Headland Dist.";
            lblHeadlandDist.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // chkboxHeadlandDist
            // 
            chkboxHeadlandDist.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            chkboxHeadlandDist.Appearance = System.Windows.Forms.Appearance.Button;
            chkboxHeadlandDist.BackColor = System.Drawing.Color.WhiteSmoke;
            chkboxHeadlandDist.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            chkboxHeadlandDist.FlatAppearance.BorderSize = 2;
            chkboxHeadlandDist.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            chkboxHeadlandDist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            chkboxHeadlandDist.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            chkboxHeadlandDist.ForeColor = System.Drawing.SystemColors.ControlText;
            chkboxHeadlandDist.Image = Properties.Resources.HeadlandDistance;
            chkboxHeadlandDist.Location = new System.Drawing.Point(609, 36);
            chkboxHeadlandDist.Name = "chkboxHeadlandDist";
            chkboxHeadlandDist.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            chkboxHeadlandDist.Size = new System.Drawing.Size(100, 69);
            chkboxHeadlandDist.TabIndex = 540;
            chkboxHeadlandDist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            chkboxHeadlandDist.UseVisualStyleBackColor = false;
            // 
            // labelLineSmoothOnOff
            // 
            labelLineSmoothOnOff.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelLineSmoothOnOff.BackColor = System.Drawing.Color.Transparent;
            labelLineSmoothOnOff.ForeColor = System.Drawing.Color.Black;
            labelLineSmoothOnOff.Location = new System.Drawing.Point(37, 475);
            labelLineSmoothOnOff.Name = "labelLineSmoothOnOff";
            labelLineSmoothOnOff.Size = new System.Drawing.Size(100, 16);
            labelLineSmoothOnOff.TabIndex = 539;
            labelLineSmoothOnOff.Text = "Line Smooth";
            labelLineSmoothOnOff.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelSectionLinesOnOff
            // 
            labelSectionLinesOnOff.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelSectionLinesOnOff.BackColor = System.Drawing.Color.Transparent;
            labelSectionLinesOnOff.ForeColor = System.Drawing.Color.Black;
            labelSectionLinesOnOff.Location = new System.Drawing.Point(398, 475);
            labelSectionLinesOnOff.Name = "labelSectionLinesOnOff";
            labelSectionLinesOnOff.Size = new System.Drawing.Size(159, 16);
            labelSectionLinesOnOff.TabIndex = 537;
            labelSectionLinesOnOff.Text = "Section Lines";
            labelSectionLinesOnOff.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelDirectionMarkOnOff
            // 
            labelDirectionMarkOnOff.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelDirectionMarkOnOff.BackColor = System.Drawing.Color.Transparent;
            labelDirectionMarkOnOff.ForeColor = System.Drawing.Color.Black;
            labelDirectionMarkOnOff.Location = new System.Drawing.Point(207, 475);
            labelDirectionMarkOnOff.Name = "labelDirectionMarkOnOff";
            labelDirectionMarkOnOff.Size = new System.Drawing.Size(157, 16);
            labelDirectionMarkOnOff.TabIndex = 533;
            labelDirectionMarkOnOff.Text = "Direction Markers";
            labelDirectionMarkOnOff.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelElevationOnOff
            // 
            labelElevationOnOff.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelElevationOnOff.BackColor = System.Drawing.Color.Transparent;
            labelElevationOnOff.ForeColor = System.Drawing.Color.Black;
            labelElevationOnOff.Location = new System.Drawing.Point(612, 232);
            labelElevationOnOff.Name = "labelElevationOnOff";
            labelElevationOnOff.Size = new System.Drawing.Size(100, 16);
            labelElevationOnOff.TabIndex = 531;
            labelElevationOnOff.Text = "Elevation";
            labelElevationOnOff.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // unitsGroupBox
            // 
            unitsGroupBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            unitsGroupBox.Controls.Add(rbtnDisplayImperial);
            unitsGroupBox.Controls.Add(rbtnDisplayMetric);
            unitsGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            unitsGroupBox.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            unitsGroupBox.ForeColor = System.Drawing.Color.Black;
            unitsGroupBox.Location = new System.Drawing.Point(595, 448);
            unitsGroupBox.Name = "unitsGroupBox";
            unitsGroupBox.Size = new System.Drawing.Size(250, 129);
            unitsGroupBox.TabIndex = 513;
            unitsGroupBox.TabStop = false;
            unitsGroupBox.Text = "Units";
            // 
            // rbtnDisplayImperial
            // 
            rbtnDisplayImperial.Appearance = System.Windows.Forms.Appearance.Button;
            rbtnDisplayImperial.BackColor = System.Drawing.Color.WhiteSmoke;
            rbtnDisplayImperial.Checked = true;
            rbtnDisplayImperial.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            rbtnDisplayImperial.FlatAppearance.BorderSize = 2;
            rbtnDisplayImperial.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            rbtnDisplayImperial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rbtnDisplayImperial.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            rbtnDisplayImperial.ForeColor = System.Drawing.SystemColors.ControlText;
            rbtnDisplayImperial.Image = Properties.Resources.ConD_Imperial;
            rbtnDisplayImperial.Location = new System.Drawing.Point(130, 37);
            rbtnDisplayImperial.Name = "rbtnDisplayImperial";
            rbtnDisplayImperial.Size = new System.Drawing.Size(112, 64);
            rbtnDisplayImperial.TabIndex = 469;
            rbtnDisplayImperial.TabStop = true;
            rbtnDisplayImperial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            rbtnDisplayImperial.UseVisualStyleBackColor = false;
            rbtnDisplayImperial.Click += rbtnDisplayImperial_Click;
            // 
            // rbtnDisplayMetric
            // 
            rbtnDisplayMetric.Appearance = System.Windows.Forms.Appearance.Button;
            rbtnDisplayMetric.BackColor = System.Drawing.Color.WhiteSmoke;
            rbtnDisplayMetric.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            rbtnDisplayMetric.FlatAppearance.BorderSize = 2;
            rbtnDisplayMetric.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            rbtnDisplayMetric.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rbtnDisplayMetric.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            rbtnDisplayMetric.ForeColor = System.Drawing.SystemColors.ControlText;
            rbtnDisplayMetric.Image = Properties.Resources.ConD_Metric;
            rbtnDisplayMetric.Location = new System.Drawing.Point(8, 37);
            rbtnDisplayMetric.Name = "rbtnDisplayMetric";
            rbtnDisplayMetric.Size = new System.Drawing.Size(112, 64);
            rbtnDisplayMetric.TabIndex = 468;
            rbtnDisplayMetric.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            rbtnDisplayMetric.UseVisualStyleBackColor = false;
            rbtnDisplayMetric.Click += rbtnDisplayMetric_Click;
            // 
            // labelSvenArrowOnOff
            // 
            labelSvenArrowOnOff.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelSvenArrowOnOff.BackColor = System.Drawing.Color.Transparent;
            labelSvenArrowOnOff.ForeColor = System.Drawing.Color.Black;
            labelSvenArrowOnOff.Location = new System.Drawing.Point(231, 232);
            labelSvenArrowOnOff.Name = "labelSvenArrowOnOff";
            labelSvenArrowOnOff.Size = new System.Drawing.Size(100, 16);
            labelSvenArrowOnOff.TabIndex = 529;
            labelSvenArrowOnOff.Text = "Svenn Arrow";
            labelSvenArrowOnOff.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelBrightnessOnOff
            // 
            labelBrightnessOnOff.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelBrightnessOnOff.BackColor = System.Drawing.Color.Transparent;
            labelBrightnessOnOff.ForeColor = System.Drawing.Color.Black;
            labelBrightnessOnOff.Location = new System.Drawing.Point(37, 232);
            labelBrightnessOnOff.Name = "labelBrightnessOnOff";
            labelBrightnessOnOff.Size = new System.Drawing.Size(100, 16);
            labelBrightnessOnOff.TabIndex = 527;
            labelBrightnessOnOff.Text = "Brightness";
            labelBrightnessOnOff.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelFieldTextureOnOff
            // 
            labelFieldTextureOnOff.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            labelFieldTextureOnOff.BackColor = System.Drawing.Color.Transparent;
            labelFieldTextureOnOff.ForeColor = System.Drawing.Color.Black;
            labelFieldTextureOnOff.Location = new System.Drawing.Point(37, 354);
            labelFieldTextureOnOff.Name = "labelFieldTextureOnOff";
            labelFieldTextureOnOff.Size = new System.Drawing.Size(100, 16);
            labelFieldTextureOnOff.TabIndex = 525;
            labelFieldTextureOnOff.Text = "Field Texture";
            labelFieldTextureOnOff.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelPolyOnOff
            // 
            labelPolyOnOff.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelPolyOnOff.BackColor = System.Drawing.Color.Transparent;
            labelPolyOnOff.ForeColor = System.Drawing.Color.Black;
            labelPolyOnOff.Location = new System.Drawing.Point(37, 111);
            labelPolyOnOff.Name = "labelPolyOnOff";
            labelPolyOnOff.Size = new System.Drawing.Size(100, 16);
            labelPolyOnOff.TabIndex = 523;
            labelPolyOnOff.Text = "Polygons";
            labelPolyOnOff.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelKeyboardOnOff
            // 
            labelKeyboardOnOff.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelKeyboardOnOff.BackColor = System.Drawing.Color.Transparent;
            labelKeyboardOnOff.ForeColor = System.Drawing.Color.Black;
            labelKeyboardOnOff.Location = new System.Drawing.Point(425, 111);
            labelKeyboardOnOff.Name = "labelKeyboardOnOff";
            labelKeyboardOnOff.Size = new System.Drawing.Size(100, 16);
            labelKeyboardOnOff.TabIndex = 521;
            labelKeyboardOnOff.Text = "Keyboard";
            labelKeyboardOnOff.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelFullscreenOnOff
            // 
            labelFullscreenOnOff.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelFullscreenOnOff.BackColor = System.Drawing.Color.Transparent;
            labelFullscreenOnOff.ForeColor = System.Drawing.Color.Black;
            labelFullscreenOnOff.Location = new System.Drawing.Point(395, 232);
            labelFullscreenOnOff.Name = "labelFullscreenOnOff";
            labelFullscreenOnOff.Size = new System.Drawing.Size(162, 16);
            labelFullscreenOnOff.TabIndex = 518;
            labelFullscreenOnOff.Text = "Start Fullscreen";
            labelFullscreenOnOff.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelSpeedoOnOff
            // 
            labelSpeedoOnOff.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelSpeedoOnOff.BackColor = System.Drawing.Color.Transparent;
            labelSpeedoOnOff.ForeColor = System.Drawing.Color.Black;
            labelSpeedoOnOff.Location = new System.Drawing.Point(231, 112);
            labelSpeedoOnOff.Name = "labelSpeedoOnOff";
            labelSpeedoOnOff.Size = new System.Drawing.Size(100, 16);
            labelSpeedoOnOff.TabIndex = 516;
            labelSpeedoOnOff.Text = "Speedo";
            labelSpeedoOnOff.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelGuideLinesOnOff
            // 
            labelGuideLinesOnOff.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelGuideLinesOnOff.BackColor = System.Drawing.Color.Transparent;
            labelGuideLinesOnOff.ForeColor = System.Drawing.Color.Black;
            labelGuideLinesOnOff.Location = new System.Drawing.Point(398, 350);
            labelGuideLinesOnOff.Name = "labelGuideLinesOnOff";
            labelGuideLinesOnOff.Size = new System.Drawing.Size(159, 16);
            labelGuideLinesOnOff.TabIndex = 519;
            labelGuideLinesOnOff.Text = "Guidelines";
            labelGuideLinesOnOff.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelGridOnOff
            // 
            labelGridOnOff.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelGridOnOff.BackColor = System.Drawing.Color.Transparent;
            labelGridOnOff.ForeColor = System.Drawing.Color.Black;
            labelGridOnOff.Location = new System.Drawing.Point(231, 354);
            labelGridOnOff.Name = "labelGridOnOff";
            labelGridOnOff.Size = new System.Drawing.Size(100, 16);
            labelGridOnOff.TabIndex = 515;
            labelGridOnOff.Text = "Grid";
            labelGridOnOff.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nudNumGuideLines
            // 
            nudNumGuideLines.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            nudNumGuideLines.BackColor = System.Drawing.Color.AliceBlue;
            nudNumGuideLines.Cursor = System.Windows.Forms.Cursors.IBeam;
            nudNumGuideLines.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            nudNumGuideLines.InterceptArrowKeys = false;
            nudNumGuideLines.Location = new System.Drawing.Point(531, 285);
            nudNumGuideLines.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            nudNumGuideLines.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudNumGuideLines.Name = "nudNumGuideLines";
            nudNumGuideLines.ReadOnly = true;
            nudNumGuideLines.Size = new System.Drawing.Size(100, 52);
            nudNumGuideLines.TabIndex = 534;
            nudNumGuideLines.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudNumGuideLines.Value = new decimal(new int[] { 50, 0, 0, 0 });
            nudNumGuideLines.Click += nudNumGuideLines_Click;
            // 
            // chkLineSmooth
            // 
            chkLineSmooth.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            chkLineSmooth.Appearance = System.Windows.Forms.Appearance.Button;
            chkLineSmooth.BackColor = System.Drawing.Color.WhiteSmoke;
            chkLineSmooth.BackgroundImage = Properties.Resources.ConD_LineSmooth;
            chkLineSmooth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            chkLineSmooth.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            chkLineSmooth.FlatAppearance.BorderSize = 2;
            chkLineSmooth.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            chkLineSmooth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            chkLineSmooth.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            chkLineSmooth.ForeColor = System.Drawing.SystemColors.ControlText;
            chkLineSmooth.Location = new System.Drawing.Point(37, 403);
            chkLineSmooth.Name = "chkLineSmooth";
            chkLineSmooth.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            chkLineSmooth.Size = new System.Drawing.Size(100, 69);
            chkLineSmooth.TabIndex = 538;
            chkLineSmooth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            chkLineSmooth.UseVisualStyleBackColor = false;
            // 
            // chkSectionLines
            // 
            chkSectionLines.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            chkSectionLines.Appearance = System.Windows.Forms.Appearance.Button;
            chkSectionLines.BackColor = System.Drawing.Color.WhiteSmoke;
            chkSectionLines.BackgroundImage = Properties.Resources.ConD_SectionHighlights;
            chkSectionLines.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            chkSectionLines.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            chkSectionLines.FlatAppearance.BorderSize = 2;
            chkSectionLines.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            chkSectionLines.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            chkSectionLines.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            chkSectionLines.ForeColor = System.Drawing.SystemColors.ControlText;
            chkSectionLines.Location = new System.Drawing.Point(425, 403);
            chkSectionLines.Name = "chkSectionLines";
            chkSectionLines.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            chkSectionLines.Size = new System.Drawing.Size(100, 69);
            chkSectionLines.TabIndex = 536;
            chkSectionLines.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            chkSectionLines.UseVisualStyleBackColor = false;
            // 
            // chkDirectionMarkers
            // 
            chkDirectionMarkers.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            chkDirectionMarkers.Appearance = System.Windows.Forms.Appearance.Button;
            chkDirectionMarkers.BackColor = System.Drawing.Color.WhiteSmoke;
            chkDirectionMarkers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            chkDirectionMarkers.Checked = true;
            chkDirectionMarkers.CheckState = System.Windows.Forms.CheckState.Checked;
            chkDirectionMarkers.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            chkDirectionMarkers.FlatAppearance.BorderSize = 2;
            chkDirectionMarkers.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            chkDirectionMarkers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            chkDirectionMarkers.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            chkDirectionMarkers.ForeColor = System.Drawing.SystemColors.ControlText;
            chkDirectionMarkers.Image = Properties.Resources.ConD_DirectionMarker;
            chkDirectionMarkers.Location = new System.Drawing.Point(234, 403);
            chkDirectionMarkers.Name = "chkDirectionMarkers";
            chkDirectionMarkers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            chkDirectionMarkers.Size = new System.Drawing.Size(100, 69);
            chkDirectionMarkers.TabIndex = 532;
            chkDirectionMarkers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            chkDirectionMarkers.UseVisualStyleBackColor = false;
            // 
            // chkDisplayLogElevation
            // 
            chkDisplayLogElevation.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            chkDisplayLogElevation.Appearance = System.Windows.Forms.Appearance.Button;
            chkDisplayLogElevation.BackColor = System.Drawing.Color.WhiteSmoke;
            chkDisplayLogElevation.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            chkDisplayLogElevation.FlatAppearance.BorderSize = 2;
            chkDisplayLogElevation.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            chkDisplayLogElevation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            chkDisplayLogElevation.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            chkDisplayLogElevation.ForeColor = System.Drawing.SystemColors.ControlText;
            chkDisplayLogElevation.Image = Properties.Resources.ConD_LogElevation;
            chkDisplayLogElevation.Location = new System.Drawing.Point(612, 160);
            chkDisplayLogElevation.Name = "chkDisplayLogElevation";
            chkDisplayLogElevation.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            chkDisplayLogElevation.Size = new System.Drawing.Size(100, 69);
            chkDisplayLogElevation.TabIndex = 530;
            chkDisplayLogElevation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            chkDisplayLogElevation.UseVisualStyleBackColor = false;
            // 
            // chkSvennArrow
            // 
            chkSvennArrow.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            chkSvennArrow.Appearance = System.Windows.Forms.Appearance.Button;
            chkSvennArrow.BackColor = System.Drawing.Color.WhiteSmoke;
            chkSvennArrow.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            chkSvennArrow.FlatAppearance.BorderSize = 2;
            chkSvennArrow.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            chkSvennArrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            chkSvennArrow.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            chkSvennArrow.ForeColor = System.Drawing.SystemColors.ControlText;
            chkSvennArrow.Image = Properties.Resources.SvennArrow;
            chkSvennArrow.Location = new System.Drawing.Point(231, 160);
            chkSvennArrow.Name = "chkSvennArrow";
            chkSvennArrow.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            chkSvennArrow.Size = new System.Drawing.Size(100, 69);
            chkSvennArrow.TabIndex = 528;
            chkSvennArrow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            chkSvennArrow.UseVisualStyleBackColor = false;
            // 
            // chkDisplayBrightness
            // 
            chkDisplayBrightness.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            chkDisplayBrightness.Appearance = System.Windows.Forms.Appearance.Button;
            chkDisplayBrightness.BackColor = System.Drawing.Color.WhiteSmoke;
            chkDisplayBrightness.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            chkDisplayBrightness.FlatAppearance.BorderSize = 2;
            chkDisplayBrightness.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            chkDisplayBrightness.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            chkDisplayBrightness.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            chkDisplayBrightness.ForeColor = System.Drawing.SystemColors.ControlText;
            chkDisplayBrightness.Image = Properties.Resources.BrightnessUp;
            chkDisplayBrightness.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            chkDisplayBrightness.Location = new System.Drawing.Point(37, 160);
            chkDisplayBrightness.Name = "chkDisplayBrightness";
            chkDisplayBrightness.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            chkDisplayBrightness.Size = new System.Drawing.Size(100, 69);
            chkDisplayBrightness.TabIndex = 526;
            chkDisplayBrightness.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            chkDisplayBrightness.UseVisualStyleBackColor = false;
            // 
            // chkDisplayFloor
            // 
            chkDisplayFloor.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            chkDisplayFloor.Appearance = System.Windows.Forms.Appearance.Button;
            chkDisplayFloor.BackColor = System.Drawing.Color.WhiteSmoke;
            chkDisplayFloor.Checked = true;
            chkDisplayFloor.CheckState = System.Windows.Forms.CheckState.Checked;
            chkDisplayFloor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            chkDisplayFloor.FlatAppearance.BorderSize = 2;
            chkDisplayFloor.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            chkDisplayFloor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            chkDisplayFloor.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            chkDisplayFloor.ForeColor = System.Drawing.SystemColors.ControlText;
            chkDisplayFloor.Image = Properties.Resources.ConD_FloorTexture;
            chkDisplayFloor.Location = new System.Drawing.Point(37, 282);
            chkDisplayFloor.Name = "chkDisplayFloor";
            chkDisplayFloor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            chkDisplayFloor.Size = new System.Drawing.Size(100, 69);
            chkDisplayFloor.TabIndex = 524;
            chkDisplayFloor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            chkDisplayFloor.UseVisualStyleBackColor = false;
            // 
            // chkDisplayKeyboard
            // 
            chkDisplayKeyboard.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            chkDisplayKeyboard.Appearance = System.Windows.Forms.Appearance.Button;
            chkDisplayKeyboard.BackColor = System.Drawing.Color.WhiteSmoke;
            chkDisplayKeyboard.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            chkDisplayKeyboard.FlatAppearance.BorderSize = 2;
            chkDisplayKeyboard.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            chkDisplayKeyboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            chkDisplayKeyboard.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            chkDisplayKeyboard.ForeColor = System.Drawing.SystemColors.ControlText;
            chkDisplayKeyboard.Image = Properties.Resources.ConD_KeyBoard;
            chkDisplayKeyboard.Location = new System.Drawing.Point(425, 39);
            chkDisplayKeyboard.Name = "chkDisplayKeyboard";
            chkDisplayKeyboard.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            chkDisplayKeyboard.Size = new System.Drawing.Size(100, 69);
            chkDisplayKeyboard.TabIndex = 511;
            chkDisplayKeyboard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            chkDisplayKeyboard.UseVisualStyleBackColor = false;
            // 
            // chkDisplayPolygons
            // 
            chkDisplayPolygons.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            chkDisplayPolygons.Appearance = System.Windows.Forms.Appearance.Button;
            chkDisplayPolygons.BackColor = System.Drawing.Color.WhiteSmoke;
            chkDisplayPolygons.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            chkDisplayPolygons.FlatAppearance.BorderSize = 2;
            chkDisplayPolygons.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            chkDisplayPolygons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            chkDisplayPolygons.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            chkDisplayPolygons.ForeColor = System.Drawing.SystemColors.ControlText;
            chkDisplayPolygons.Image = Properties.Resources.ConD_Poligons;
            chkDisplayPolygons.Location = new System.Drawing.Point(37, 39);
            chkDisplayPolygons.Name = "chkDisplayPolygons";
            chkDisplayPolygons.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            chkDisplayPolygons.Size = new System.Drawing.Size(100, 69);
            chkDisplayPolygons.TabIndex = 510;
            chkDisplayPolygons.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            chkDisplayPolygons.UseVisualStyleBackColor = false;
            // 
            // chkDisplayStartFullScreen
            // 
            chkDisplayStartFullScreen.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            chkDisplayStartFullScreen.Appearance = System.Windows.Forms.Appearance.Button;
            chkDisplayStartFullScreen.BackColor = System.Drawing.Color.WhiteSmoke;
            chkDisplayStartFullScreen.Checked = true;
            chkDisplayStartFullScreen.CheckState = System.Windows.Forms.CheckState.Checked;
            chkDisplayStartFullScreen.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            chkDisplayStartFullScreen.FlatAppearance.BorderSize = 2;
            chkDisplayStartFullScreen.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            chkDisplayStartFullScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            chkDisplayStartFullScreen.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            chkDisplayStartFullScreen.ForeColor = System.Drawing.SystemColors.ControlText;
            chkDisplayStartFullScreen.Image = Properties.Resources.ConD_FullScreenBegin;
            chkDisplayStartFullScreen.Location = new System.Drawing.Point(425, 160);
            chkDisplayStartFullScreen.Name = "chkDisplayStartFullScreen";
            chkDisplayStartFullScreen.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            chkDisplayStartFullScreen.Size = new System.Drawing.Size(100, 69);
            chkDisplayStartFullScreen.TabIndex = 509;
            chkDisplayStartFullScreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            chkDisplayStartFullScreen.UseVisualStyleBackColor = false;
            // 
            // chkDisplayGrid
            // 
            chkDisplayGrid.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            chkDisplayGrid.Appearance = System.Windows.Forms.Appearance.Button;
            chkDisplayGrid.BackColor = System.Drawing.Color.WhiteSmoke;
            chkDisplayGrid.Checked = true;
            chkDisplayGrid.CheckState = System.Windows.Forms.CheckState.Checked;
            chkDisplayGrid.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            chkDisplayGrid.FlatAppearance.BorderSize = 2;
            chkDisplayGrid.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            chkDisplayGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            chkDisplayGrid.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            chkDisplayGrid.ForeColor = System.Drawing.SystemColors.ControlText;
            chkDisplayGrid.Image = Properties.Resources.ConD_Grid;
            chkDisplayGrid.Location = new System.Drawing.Point(231, 282);
            chkDisplayGrid.Name = "chkDisplayGrid";
            chkDisplayGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            chkDisplayGrid.Size = new System.Drawing.Size(100, 69);
            chkDisplayGrid.TabIndex = 506;
            chkDisplayGrid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            chkDisplayGrid.UseVisualStyleBackColor = false;
            // 
            // chkDisplaySpeedo
            // 
            chkDisplaySpeedo.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            chkDisplaySpeedo.Appearance = System.Windows.Forms.Appearance.Button;
            chkDisplaySpeedo.BackColor = System.Drawing.Color.WhiteSmoke;
            chkDisplaySpeedo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            chkDisplaySpeedo.FlatAppearance.BorderSize = 2;
            chkDisplaySpeedo.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            chkDisplaySpeedo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            chkDisplaySpeedo.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            chkDisplaySpeedo.ForeColor = System.Drawing.SystemColors.ControlText;
            chkDisplaySpeedo.Image = Properties.Resources.ConD_Speedometer;
            chkDisplaySpeedo.Location = new System.Drawing.Point(231, 39);
            chkDisplaySpeedo.Name = "chkDisplaySpeedo";
            chkDisplaySpeedo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            chkDisplaySpeedo.Size = new System.Drawing.Size(100, 69);
            chkDisplaySpeedo.TabIndex = 504;
            chkDisplaySpeedo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            chkDisplaySpeedo.UseVisualStyleBackColor = false;
            // 
            // chkDisplayExtraGuides
            // 
            chkDisplayExtraGuides.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            chkDisplayExtraGuides.Appearance = System.Windows.Forms.Appearance.Button;
            chkDisplayExtraGuides.BackColor = System.Drawing.Color.WhiteSmoke;
            chkDisplayExtraGuides.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            chkDisplayExtraGuides.FlatAppearance.BorderSize = 2;
            chkDisplayExtraGuides.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            chkDisplayExtraGuides.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            chkDisplayExtraGuides.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            chkDisplayExtraGuides.ForeColor = System.Drawing.SystemColors.ControlText;
            chkDisplayExtraGuides.Image = Properties.Resources.ConD_ExtraGuides;
            chkDisplayExtraGuides.Location = new System.Drawing.Point(425, 278);
            chkDisplayExtraGuides.Name = "chkDisplayExtraGuides";
            chkDisplayExtraGuides.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            chkDisplayExtraGuides.Size = new System.Drawing.Size(100, 69);
            chkDisplayExtraGuides.TabIndex = 503;
            chkDisplayExtraGuides.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            chkDisplayExtraGuides.UseVisualStyleBackColor = false;
            // 
            // labelCurrentVehicle
            // 
            labelCurrentVehicle.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            labelCurrentVehicle.AutoSize = true;
            labelCurrentVehicle.BackColor = System.Drawing.Color.Transparent;
            labelCurrentVehicle.Font = new System.Drawing.Font("Tahoma", 14.25F);
            labelCurrentVehicle.ForeColor = System.Drawing.Color.Black;
            labelCurrentVehicle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            labelCurrentVehicle.Location = new System.Drawing.Point(21, 4);
            labelCurrentVehicle.Name = "labelCurrentVehicle";
            labelCurrentVehicle.Size = new System.Drawing.Size(138, 23);
            labelCurrentVehicle.TabIndex = 450;
            labelCurrentVehicle.Text = "Current Vehicle";
            labelCurrentVehicle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCurrentTool
            // 
            labelCurrentTool.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            labelCurrentTool.AutoSize = true;
            labelCurrentTool.BackColor = System.Drawing.Color.Transparent;
            labelCurrentTool.Font = new System.Drawing.Font("Tahoma", 14.25F);
            labelCurrentTool.ForeColor = System.Drawing.Color.Black;
            labelCurrentTool.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            labelCurrentTool.Location = new System.Drawing.Point(21, 32);
            labelCurrentTool.Name = "labelCurrentTool";
            labelCurrentTool.Size = new System.Drawing.Size(114, 23);
            labelCurrentTool.TabIndex = 451;
            labelCurrentTool.Text = "Current Tool";
            labelCurrentTool.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblInchesCm
            // 
            lblInchesCm.AutoSize = true;
            lblInchesCm.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblInchesCm.ForeColor = System.Drawing.Color.DarkGreen;
            lblInchesCm.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            lblInchesCm.Location = new System.Drawing.Point(455, 37);
            lblInchesCm.Name = "lblInchesCm";
            lblInchesCm.Size = new System.Drawing.Size(74, 25);
            lblInchesCm.TabIndex = 303;
            lblInchesCm.Text = "Inches";
            // 
            // lblSecTotalWidth
            // 
            lblSecTotalWidth.AutoSize = true;
            lblSecTotalWidth.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblSecTotalWidth.ForeColor = System.Drawing.Color.Black;
            lblSecTotalWidth.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            lblSecTotalWidth.Location = new System.Drawing.Point(632, 32);
            lblSecTotalWidth.Name = "lblSecTotalWidth";
            lblSecTotalWidth.Size = new System.Drawing.Size(32, 25);
            lblSecTotalWidth.TabIndex = 302;
            lblSecTotalWidth.Text = "II";
            // 
            // labelToolWidthBottom
            // 
            labelToolWidthBottom.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelToolWidthBottom.ForeColor = System.Drawing.Color.Black;
            labelToolWidthBottom.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            labelToolWidthBottom.Location = new System.Drawing.Point(583, 4);
            labelToolWidthBottom.Name = "labelToolWidthBottom";
            labelToolWidthBottom.Size = new System.Drawing.Size(128, 25);
            labelToolWidthBottom.TabIndex = 301;
            labelToolWidthBottom.Text = "Tool Width:";
            labelToolWidthBottom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelBottom
            // 
            panelBottom.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            panelBottom.Controls.Add(lblFeetMeters);
            panelBottom.Controls.Add(labelToolWidthBottom);
            panelBottom.Controls.Add(btnOK);
            panelBottom.Controls.Add(lblInchesCm);
            panelBottom.Controls.Add(lblSecTotalWidth);
            panelBottom.Controls.Add(labelCurrentVehicle);
            panelBottom.Controls.Add(labelCurrentTool);
            panelBottom.Controls.Add(labelUnitsBottom);
            panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            panelBottom.ForeColor = System.Drawing.Color.Lime;
            panelBottom.Location = new System.Drawing.Point(124, 645);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new System.Drawing.Size(867, 66);
            panelBottom.TabIndex = 112;
            // 
            // lblFeetMeters
            // 
            lblFeetMeters.AutoSize = true;
            lblFeetMeters.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblFeetMeters.ForeColor = System.Drawing.Color.DarkGreen;
            lblFeetMeters.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            lblFeetMeters.Location = new System.Drawing.Point(455, 9);
            lblFeetMeters.Name = "lblFeetMeters";
            lblFeetMeters.Size = new System.Drawing.Size(52, 25);
            lblFeetMeters.TabIndex = 453;
            lblFeetMeters.Text = "Feet";
            // 
            // btnOK
            // 
            btnOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnOK.FlatAppearance.BorderSize = 0;
            btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnOK.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnOK.ForeColor = System.Drawing.SystemColors.ButtonFace;
            btnOK.Image = Properties.Resources.OK64;
            btnOK.Location = new System.Drawing.Point(782, 1);
            btnOK.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            btnOK.Name = "btnOK";
            btnOK.Size = new System.Drawing.Size(80, 62);
            btnOK.TabIndex = 452;
            btnOK.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // labelUnitsBottom
            // 
            labelUnitsBottom.BackColor = System.Drawing.Color.Transparent;
            labelUnitsBottom.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelUnitsBottom.ForeColor = System.Drawing.Color.Black;
            labelUnitsBottom.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            labelUnitsBottom.Location = new System.Drawing.Point(355, 9);
            labelUnitsBottom.Name = "labelUnitsBottom";
            labelUnitsBottom.Size = new System.Drawing.Size(85, 25);
            labelUnitsBottom.TabIndex = 454;
            labelUnitsBottom.Text = "Units:";
            labelUnitsBottom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormConfig
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            ClientSize = new System.Drawing.Size(995, 715);
            ControlBox = false;
            Controls.Add(tab1);
            Controls.Add(panelBottom);
            Controls.Add(panelLeftSideMenu);
            Font = new System.Drawing.Font("Tahoma", 9.75F);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            HelpButton = true;
            Margin = new System.Windows.Forms.Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormConfig";
            Padding = new System.Windows.Forms.Padding(4);
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Configuration";
            FormClosing += FormConfig_FormClosing;
            Load += FormConfig_Load;
            panelLeftSideMenu.ResumeLayout(false);
            panelArduinoSubMenu.ResumeLayout(false);
            panelDataSourcesSubMenu.ResumeLayout(false);
            panelToolSubMenu.ResumeLayout(false);
            panelVehicleSubMenu.ResumeLayout(false);
            tab1.ResumeLayout(false);
            tabSummary.ResumeLayout(false);
            tabVConfig.ResumeLayout(false);
            tabVAntenna.ResumeLayout(false);
            tabVAntenna.PerformLayout();
            labelAntOffset.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudAntennaOffset).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAntennaHeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAntennaPivot).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxAntenna).EndInit();
            tabVDimensions.ResumeLayout(false);
            tabVDimensions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)HitchLengthBlindBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudTractorHitchLength).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudVehicleTrack).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudWheelbase).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabTConfig.ResumeLayout(false);
            labelBoxAttachmentStyle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pboxConfigHarvester).EndInit();
            tabTHitch.ResumeLayout(false);
            tabTHitch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudTrailingHitchLength).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudDrawbarLength).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudTankHitch).EndInit();
            ((System.ComponentModel.ISupportInitialize)picboxToolHitch).EndInit();
            tabToolOffset.ResumeLayout(false);
            tabToolOffset.PerformLayout();
            labelOverlapGap.ResumeLayout(false);
            labelToolOffset.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudOverlap).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudOffset).EndInit();
            tabToolPivot.ResumeLayout(false);
            tabToolPivot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudTrailingToolToPivotLength).EndInit();
            tabTSections.ResumeLayout(false);
            tabTSections.PerformLayout();
            panelSymmetricSections.ResumeLayout(false);
            panelSymmetricSections.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudZone8To).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudZone7To).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudZone6To).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudZone4To).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudZone1To).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudZone5To).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudZone3To).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudZone2To).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCutoffSpeed).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudDefaultSectionWidth).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMinCoverage).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSection16).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSection15).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSection14).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSection13).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSection12).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSection11).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSection10).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSection09).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSection08).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSection07).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSection06).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSection05).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSection04).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSection03).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSection02).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSection01).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudNumberOfSections).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            tabTSwitches.ResumeLayout(false);
            labelGroupSteerSwitch.ResumeLayout(false);
            labelGroupWorkSwitch.ResumeLayout(false);
            tabTSettings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudLookAheadOff).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudTurnOffDelay).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudLookAhead).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox18).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            tabDHeading.ResumeLayout(false);
            tabDHeading.PerformLayout();
            labelGboxDual.ResumeLayout(false);
            labelGboxDual.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudAutoSwitchDualFixSpeed).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudDualReverseDistance).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudDualHeadingOffset).EndInit();
            labelGboxSingle.ResumeLayout(false);
            labelGboxSingle.PerformLayout();
            headingGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudFixJumpDistance).EndInit();
            tabDRoll.ResumeLayout(false);
            tabDRoll.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            tabUTurn.ResumeLayout(false);
            tabUTurn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudYouTurnRadius).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudTurnDistanceFromBoundary).EndInit();
            tabRelay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pboxSendRelay).EndInit();
            tabAMachine.ResumeLayout(false);
            labelGroupHyd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudHydLiftLookAhead).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudLowerTime).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudRaiseTime).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudUser4).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudUser3).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudUser2).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudUser1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxSendMachine).EndInit();
            tabTram.ResumeLayout(false);
            tabTram.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudTramWidth).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            tabBtns.ResumeLayout(false);
            tabBtns.PerformLayout();
            tabDisplay.ResumeLayout(false);
            unitsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudNumGuideLines).EndInit();
            panelBottom.ResumeLayout(false);
            panelBottom.PerformLayout();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelLeftSideMenu;
        private System.Windows.Forms.Panel panelDataSourcesSubMenu;
        private System.Windows.Forms.Button btnSubHeading;
        private System.Windows.Forms.Button btnSubRoll;
        private System.Windows.Forms.Panel panelToolSubMenu;
        private System.Windows.Forms.Button btnSubSwitches;
        private System.Windows.Forms.Button btnSubSections;
        private System.Windows.Forms.Button btnTool;
        private System.Windows.Forms.Panel panelVehicleSubMenu;
        private System.Windows.Forms.Button btnSubAntenna;
        private System.Windows.Forms.Button btnSubDimensions;
        private System.Windows.Forms.Button btnSubVehicleType;
        private System.Windows.Forms.TabControl tab1;
        private System.Windows.Forms.TabPage tabSummary;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.TabPage tabVConfig;
        private System.Windows.Forms.TabPage tabTHitch;
        private System.Windows.Forms.TabPage tabTSections;
        private System.Windows.Forms.TabPage tabTSwitches;
        private System.Windows.Forms.TabPage tabTSettings;
        private System.Windows.Forms.TabPage tabTConfig;
        private System.Windows.Forms.TabPage tabVAntenna;
        private System.Windows.Forms.TabPage tabVDimensions;
        private System.Windows.Forms.TabPage tabVGuidance;
        private System.Windows.Forms.TabPage tabDHeading;
        private System.Windows.Forms.TabPage tabDRoll;
        private System.Windows.Forms.Button btnVehicle;
        private System.Windows.Forms.Button btnDataSources;
        private System.Windows.Forms.Button btnSubHitch;
        private System.Windows.Forms.Button btnSubToolSettings;
        private System.Windows.Forms.Button btnSubToolType;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox headingGroupBox;
        private System.Windows.Forms.RadioButton rbtnHeadingHDT;
        private System.Windows.Forms.RadioButton rbtnHeadingFix;
        private System.Windows.Forms.Label labelLess;
        private System.Windows.Forms.Label labelMore;
        private System.Windows.Forms.Label lblRollFilterPercent;
        private System.Windows.Forms.Label labelRollFilter;
        private System.Windows.Forms.HScrollBar hsbarRollFilter;
        private System.Windows.Forms.RadioButton rbtnTBT;
        private System.Windows.Forms.RadioButton rbtnFixedRear;
        private System.Windows.Forms.RadioButton rbtnFront;
        private System.Windows.Forms.RadioButton rbtnTrailing;
        private NudlessNumericUpDown nudAntennaHeight;
        private NudlessNumericUpDown nudAntennaPivot;
        private System.Windows.Forms.PictureBox pboxAntenna;
        private System.Windows.Forms.PictureBox picboxToolHitch;
        private NudlessNumericUpDown nudTrailingHitchLength;
        private NudlessNumericUpDown nudDrawbarLength;
        private NudlessNumericUpDown nudTankHitch;
        private System.Windows.Forms.CheckBox chkSetManualSections;
        private System.Windows.Forms.CheckBox chkWorkSwActiveLow;
        private System.Windows.Forms.CheckBox chkSelectWorkSwitch;
        private NudlessNumericUpDown nudLookAheadOff;
        private NudlessNumericUpDown nudTurnOffDelay;
        private NudlessNumericUpDown nudLookAhead;
        private System.Windows.Forms.Label labelCurrentVehicle;
        private System.Windows.Forms.Label labelCurrentTool;
        private System.Windows.Forms.GroupBox labelBoxAttachmentStyle;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private NudlessNumericUpDown nudSection16;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label30;
        private NudlessNumericUpDown nudSection15;
        private NudlessNumericUpDown nudSection14;
        private NudlessNumericUpDown nudSection13;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label48;
        private NudlessNumericUpDown nudSection12;
        private NudlessNumericUpDown nudSection11;
        private NudlessNumericUpDown nudSection10;
        private NudlessNumericUpDown nudSection09;
        private NudlessNumericUpDown nudSection08;
        private NudlessNumericUpDown nudSection07;
        private NudlessNumericUpDown nudSection06;
        private NudlessNumericUpDown nudSection05;
        private NudlessNumericUpDown nudSection04;
        private NudlessNumericUpDown nudSection03;
        private NudlessNumericUpDown nudSection02;
        private NudlessNumericUpDown nudSection01;
        private System.Windows.Forms.Label labelSectionWidth;
        private NudlessNumericUpDown nudDefaultSectionWidth;
        private System.Windows.Forms.ComboBox cboxNumSections;
        private System.Windows.Forms.Label lblVehicleToolWidth;
        private System.Windows.Forms.Label labelCoverage;
        private NudlessNumericUpDown nudMinCoverage;
        private System.Windows.Forms.Label labelNumOfSections;
        private System.Windows.Forms.Label lblSecTotalWidth;
        private System.Windows.Forms.Label labelToolWidthBottom;
        private System.Windows.Forms.Label lblInchesCm;
        private System.Windows.Forms.Button btnRemoveZeroOffset;
        private System.Windows.Forms.Label lblRollZeroOffset;
        private System.Windows.Forms.Button btnResetIMU;
        private NudlessNumericUpDown nudWheelbase;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnUTurn;
        private System.Windows.Forms.Button btnArduino;
        private System.Windows.Forms.Panel panelArduinoSubMenu;
        private System.Windows.Forms.Button btnMachineModule;
        private System.Windows.Forms.TabPage tabUTurn;
        private System.Windows.Forms.TabPage tabAMachine;
        private System.Windows.Forms.Label labelMachineMod;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label58;
        private AgLibrary.Controls.RepeatButton btnDistanceUp;
        private AgLibrary.Controls.RepeatButton btnDistanceDn;
        private System.Windows.Forms.Label lblWhenTrig;
        private System.Windows.Forms.Label lblDistance;
        private AgLibrary.Controls.RepeatButton btnTurnSmoothingUp;
        private AgLibrary.Controls.RepeatButton btnTurnSmoothingDown;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label lblSmoothing;
        private NudlessNumericUpDown nudLowerTime;
        private NudlessNumericUpDown nudRaiseTime;
        private System.Windows.Forms.CheckBox cboxIsHydOn;
        private System.Windows.Forms.CheckBox cboxMachInvertRelays;
        private System.Windows.Forms.Label labelSendSaveHydraulicLift;
        private System.Windows.Forms.Button btnSendMachinePGN;
        private System.Windows.Forms.CheckBox cboxDataInvertRoll;
        private System.Windows.Forms.Label labelHydLiftSec;
        private NudlessNumericUpDown nudHydLiftLookAhead;
        private NudlessNumericUpDown nudVehicleTrack;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button btnZeroRoll;
        private System.Windows.Forms.Label labelOnTime;
        private System.Windows.Forms.Label labelOffTime;
        private System.Windows.Forms.Label labelDelayTime;
        private System.Windows.Forms.Button btnTram;
        private System.Windows.Forms.TabPage tabTram;
        private NudlessNumericUpDown nudTramWidth;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label labelTrack;
        private System.Windows.Forms.Label labelWheelBase2;
        private System.Windows.Forms.Label labelRaiseTime;
        private System.Windows.Forms.Label labelLowTime;
        private System.Windows.Forms.Label labelHydLiftInvert;
        private System.Windows.Forms.Label labelTramWidth;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label labelInvertRoll;
        private System.Windows.Forms.Label labelZeroRoll;
        private System.Windows.Forms.Label labelRemoveOffset;
        private NudlessNumericUpDown nudTurnDistanceFromBoundary;
        private System.Windows.Forms.Label lblFtMUTurn;
        private System.Windows.Forms.Label lblTramWidthUnits;
        private System.Windows.Forms.Label lblFeetMeters;
        private System.Windows.Forms.Label labelUnitsBottom;
        private System.Windows.Forms.Label labelEnable;
        private System.Windows.Forms.GroupBox labelGboxSingle;
        private System.Windows.Forms.CheckBox cboxIsRTK;
        private System.Windows.Forms.PictureBox pboxSendMachine;
        private System.Windows.Forms.GroupBox labelGroupHyd;
        private System.Windows.Forms.Button btnFeatureHides;
        private System.Windows.Forms.TabPage tabBtns;
        private System.Windows.Forms.CheckBox cboxFeatureTram;
        private System.Windows.Forms.CheckBox cboxFeatureHeadland;
        private System.Windows.Forms.CheckBox cboxFeatureBoundary;
        private System.Windows.Forms.Label labelToolsMenu;
        private System.Windows.Forms.CheckBox cboxFeatureABSmooth;
        private System.Windows.Forms.Label labelFieldMenu;
        private System.Windows.Forms.CheckBox cboxFeatureRecPath;
        private System.Windows.Forms.CheckBox cboxFeatureOffsetFix;
        private System.Windows.Forms.CheckBox cboxFeatureHideContour;
        private System.Windows.Forms.Label labelScreenButtons;
        private System.Windows.Forms.Label labelOffsetFixOnOff;
        private System.Windows.Forms.Label labelContourOnOff;
        private System.Windows.Forms.Label labelRecPathOnOff;
        private System.Windows.Forms.Label labelBoundOnOff;
        private System.Windows.Forms.Label labelTramlineOnOff;
        private System.Windows.Forms.Label labelHeadlandOnOff;
        private System.Windows.Forms.CheckBox chkSelectSteerSwitch;
        private System.Windows.Forms.Label labelUturnOnOff;
        private System.Windows.Forms.Label labelLateralOnOff;
        private System.Windows.Forms.CheckBox cboxFeatureLateral;
        private System.Windows.Forms.CheckBox cboxFeatureUTurn;
        private System.Windows.Forms.CheckBox cboxIsReverseOn;
        private System.Windows.Forms.Label lblFusionIMU;
        private System.Windows.Forms.Label lblIMU;
        private System.Windows.Forms.Label lblGPS;
        private System.Windows.Forms.HScrollBar hsbarFusion;
        private System.Windows.Forms.Label lblFusion;
        private System.Windows.Forms.Label labelIMUFusion;
        private System.Windows.Forms.Label labelSounds;
        private System.Windows.Forms.CheckBox cboxTurnSound;
        private System.Windows.Forms.CheckBox cboxSteerSound;
        private System.Windows.Forms.Label labelAutosteerSoundOnOff;
        private System.Windows.Forms.Label labelUturnSoundOnOff;
        private System.Windows.Forms.Label labelHydLiftSoundOnOff;
        private System.Windows.Forms.CheckBox cboxHydLiftSound;
        private System.Windows.Forms.Button btnMachineRelay;
        private System.Windows.Forms.TabPage tabRelay;
        private System.Windows.Forms.Label labelSendandSave;
        private System.Windows.Forms.ComboBox cboxPin0;
        private System.Windows.Forms.Label label123;
        private System.Windows.Forms.PictureBox pboxSendRelay;
        private System.Windows.Forms.Button btnSendRelayConfigPGN;
        private System.Windows.Forms.Label label138;
        private System.Windows.Forms.Label label139;
        private System.Windows.Forms.Label label140;
        private System.Windows.Forms.Label label141;
        private System.Windows.Forms.Label label142;
        private System.Windows.Forms.Label label133;
        private System.Windows.Forms.Label label134;
        private System.Windows.Forms.Label label135;
        private System.Windows.Forms.Label label136;
        private System.Windows.Forms.Label label137;
        private System.Windows.Forms.Label label132;
        private System.Windows.Forms.Label label131;
        private System.Windows.Forms.Label label130;
        private System.Windows.Forms.Label label129;
        private System.Windows.Forms.Label label128;
        private System.Windows.Forms.Label label127;
        private System.Windows.Forms.Label label126;
        private System.Windows.Forms.Label label125;
        private System.Windows.Forms.Label label124;
        private System.Windows.Forms.ComboBox cboxPin4;
        private System.Windows.Forms.ComboBox cboxPin3;
        private System.Windows.Forms.ComboBox cboxPin2;
        private System.Windows.Forms.ComboBox cboxPin1;
        private System.Windows.Forms.Button btnRelaySetDefaultConfig;
        private System.Windows.Forms.Button btnRelayResetConfigToNone;
        private System.Windows.Forms.ComboBox cboxPin19;
        private System.Windows.Forms.ComboBox cboxPin18;
        private System.Windows.Forms.ComboBox cboxPin17;
        private System.Windows.Forms.ComboBox cboxPin16;
        private System.Windows.Forms.ComboBox cboxPin15;
        private System.Windows.Forms.ComboBox cboxPin14;
        private System.Windows.Forms.ComboBox cboxPin13;
        private System.Windows.Forms.ComboBox cboxPin12;
        private System.Windows.Forms.ComboBox cboxPin11;
        private System.Windows.Forms.ComboBox cboxPin10;
        private System.Windows.Forms.ComboBox cboxPin9;
        private System.Windows.Forms.ComboBox cboxPin8;
        private System.Windows.Forms.ComboBox cboxPin7;
        private System.Windows.Forms.ComboBox cboxPin6;
        private System.Windows.Forms.ComboBox cboxPin5;
        private System.Windows.Forms.ComboBox cboxPin23;
        private System.Windows.Forms.ComboBox cboxPin22;
        private System.Windows.Forms.ComboBox cboxPin21;
        private System.Windows.Forms.ComboBox cboxPin20;
        private System.Windows.Forms.Label label143;
        private System.Windows.Forms.Label label144;
        private System.Windows.Forms.Label label145;
        private System.Windows.Forms.Label label146;
        private NudlessNumericUpDown nudUser2;
        private NudlessNumericUpDown nudUser1;
        private System.Windows.Forms.Label labelPlantPop;
        private System.Windows.Forms.Label labelUser4;
        private System.Windows.Forms.Label labelUser3;
        private System.Windows.Forms.Label labelUser2;
        private NudlessNumericUpDown nudUser4;
        private NudlessNumericUpDown nudUser3;
        private System.Windows.Forms.CheckBox chkSetAutoSections;
        private System.Windows.Forms.GroupBox labelGroupWorkSwitch;
        private System.Windows.Forms.Label labelHeadingOffset;
        private NudlessNumericUpDown nudDualHeadingOffset;
        private System.Windows.Forms.GroupBox labelGroupSteerSwitch;
        private System.Windows.Forms.CheckBox chkSetAutoSectionsSteer;
        private System.Windows.Forms.CheckBox chkSetManualSectionsSteer;
        private System.Windows.Forms.Label labelStartAgIO;
        private System.Windows.Forms.CheckBox cboxAutoStartAgIO;
        private System.Windows.Forms.Label lblFtMTurnRadius;
        private NudlessNumericUpDown nudYouTurnRadius;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.Label labelUturnSmooth;
        private System.Windows.Forms.Label labelUturnExtend;
        private System.Windows.Forms.GroupBox labelGboxDual;
        private System.Windows.Forms.Label labelFixAlarm;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.CheckBox cboxIsUnique;
        private NudlessNumericUpDown nudNumberOfSections;
        private System.Windows.Forms.ComboBox cboxNumberOfZones;
        private NudlessNumericUpDown nudZone3To;
        private NudlessNumericUpDown nudZone2To;
        private NudlessNumericUpDown nudZone1To;
        private System.Windows.Forms.Label labelZone6;
        private System.Windows.Forms.Label labelZone2;
        private System.Windows.Forms.Label labelZone3;
        private System.Windows.Forms.Label labelZone4;
        private System.Windows.Forms.Label labelZone5;
        private System.Windows.Forms.Label labelZone1;
        private NudlessNumericUpDown nudZone6To;
        private NudlessNumericUpDown nudZone5To;
        private NudlessNumericUpDown nudZone4To;
        private System.Windows.Forms.Label labelZonesBox;
        private System.Windows.Forms.Label lblZoneStart1;
        private System.Windows.Forms.Panel panelSymmetricSections;
        private System.Windows.Forms.Label lblZoneStart6;
        private System.Windows.Forms.Label lblZoneStart5;
        private System.Windows.Forms.Label lblZoneStart4;
        private System.Windows.Forms.Label lblZoneStart3;
        private System.Windows.Forms.Label lblZoneStart2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label152;
        private System.Windows.Forms.Label label117;
        private System.Windows.Forms.Label label116;
        private System.Windows.Forms.Label label104;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblInchCm2;
        private System.Windows.Forms.Label labelChoose;
        private NudlessNumericUpDown nudZone8To;
        private System.Windows.Forms.Label lblZoneStart8;
        private System.Windows.Forms.Label labelZone8;
        private System.Windows.Forms.Label label158;
        private NudlessNumericUpDown nudZone7To;
        private System.Windows.Forms.Label lblZoneStart7;
        private System.Windows.Forms.Label labelZone7;
        private System.Windows.Forms.Label label155;
        private System.Windows.Forms.CheckBox cboxSectionBoundaryControl;
        private System.Windows.Forms.Label labelBoundary;
        private System.Windows.Forms.Label labelGpsStep;
        private AgLibrary.Controls.RepeatButton btnRollOffsetUp;
        private AgLibrary.Controls.RepeatButton btnRollOffsetDown;
        private System.Windows.Forms.Label labelDefault70;
        private System.Windows.Forms.CheckBox cboxMinGPSStep;
        private System.Windows.Forms.Label labelFix2Fix;
        private System.Windows.Forms.Label lblHeadingDistance;
        private System.Windows.Forms.Label labelOverride;
        private System.Windows.Forms.CheckBox chkBoxOverrideTramControlPos;
        private System.Windows.Forms.TabPage tabDisplay;
        private System.Windows.Forms.Label labelSvenArrowOnOff;
        private System.Windows.Forms.CheckBox chkSvennArrow;
        private System.Windows.Forms.Label labelBrightnessOnOff;
        private System.Windows.Forms.CheckBox chkDisplayBrightness;
        private System.Windows.Forms.Label labelFieldTextureOnOff;
        private System.Windows.Forms.CheckBox chkDisplayFloor;
        private System.Windows.Forms.Label labelPolyOnOff;
        private System.Windows.Forms.Label labelKeyboardOnOff;
        private System.Windows.Forms.Label labelFullscreenOnOff;
        private System.Windows.Forms.Label labelSpeedoOnOff;
        private System.Windows.Forms.GroupBox unitsGroupBox;
        private System.Windows.Forms.RadioButton rbtnDisplayImperial;
        private System.Windows.Forms.RadioButton rbtnDisplayMetric;
        private System.Windows.Forms.CheckBox chkDisplayKeyboard;
        private System.Windows.Forms.CheckBox chkDisplayPolygons;
        private System.Windows.Forms.CheckBox chkDisplayStartFullScreen;
        private System.Windows.Forms.CheckBox chkDisplayGrid;
        private System.Windows.Forms.CheckBox chkDisplaySpeedo;
        private System.Windows.Forms.CheckBox chkDisplayExtraGuides;
        private System.Windows.Forms.Label labelGuideLinesOnOff;
        private System.Windows.Forms.Label labelGridOnOff;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnSubToolOffset;
        private System.Windows.Forms.TabPage tabToolOffset;
        private System.Windows.Forms.Label labelToolLeft;
        private NudlessNumericUpDown nudOverlap;
        private NudlessNumericUpDown nudOffset;
        private System.Windows.Forms.RadioButton rbtnLeftNegative;
        private System.Windows.Forms.RadioButton rbtnToolRightPositive;
        private System.Windows.Forms.GroupBox labelOverlapGap;
        private System.Windows.Forms.RadioButton rbtnToolOverlap;
        private System.Windows.Forms.RadioButton rbtnToolGap;
        private System.Windows.Forms.GroupBox labelToolOffset;
        private System.Windows.Forms.Label labelOverlap2;
        private System.Windows.Forms.Label labelGap;
        private System.Windows.Forms.Label labelToolRight;
        private System.Windows.Forms.TabPage tabToolPivot;
        private System.Windows.Forms.RadioButton rbtnPivotBehindPos;
        private System.Windows.Forms.RadioButton rbtnPivotAheadNeg;
        private NudlessNumericUpDown nudTrailingToolToPivotLength;
        private System.Windows.Forms.Button btnSubPivot;
        private NudlessNumericUpDown nudTractorHitchLength;
        private System.Windows.Forms.Label labelHitchLength;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox18;
        private System.Windows.Forms.PictureBox pboxConfigHarvester;
        private System.Windows.Forms.Label labelLookAheadTiming;
        private System.Windows.Forms.Label labelRightMenu;
        private System.Windows.Forms.Button btnRightMenuOrder;
        private System.Windows.Forms.Label label93;
        private System.Windows.Forms.Label label97;
        private System.Windows.Forms.Label label95;
        private System.Windows.Forms.Label label94;
        private System.Windows.Forms.Label label99;
        private System.Windows.Forms.Label label98;
        private System.Windows.Forms.Label label112;
        private System.Windows.Forms.Label labelTractorUnits;
        private System.Windows.Forms.Label label176;
        private System.Windows.Forms.Label label175;
        private System.Windows.Forms.Label LabelCm;
        private System.Windows.Forms.Label label178;
        private System.Windows.Forms.Button btnZeroToolOffset;
        private System.Windows.Forms.Button btnZeroOverlap;
        private System.Windows.Forms.Button btnPivotOffsetZero;
        private System.Windows.Forms.Label labelNudgeCtrlOnOff;
        private System.Windows.Forms.CheckBox cboxFeatureNudge;
        private System.Windows.Forms.Label labelElevationOnOff;
        private System.Windows.Forms.CheckBox chkDisplayLogElevation;
        private System.Windows.Forms.Label labelBottomMenu;
        private System.Windows.Forms.Label labelSectionSoundOnOff;
        private System.Windows.Forms.CheckBox cboxSectionsSound;
        private System.Windows.Forms.Label labelReverseDistance;
        private NudlessNumericUpDown nudDualReverseDistance;
        private System.Windows.Forms.CheckBox cboxDisplayTramControl;
        private System.Windows.Forms.Label labelDisplay;
        private System.Windows.Forms.Label labelDualPositionOnRight;
        private System.Windows.Forms.Label labelCenter;
        private System.Windows.Forms.GroupBox labelAntOffset;
        private System.Windows.Forms.RadioButton rbtnAntennaCenter;
        private System.Windows.Forms.RadioButton rbtnAntennaRight;
        private System.Windows.Forms.RadioButton rbtnAntennaLeft;
        private System.Windows.Forms.Label labelLeft;
        private System.Windows.Forms.Label labelRight;
        private System.Windows.Forms.Label label100;
        private NudlessNumericUpDown nudAntennaOffset;
        private System.Windows.Forms.Label labelPivotDistance;
        private System.Windows.Forms.Label labelAntHeight;
        private System.Windows.Forms.Label labelOffAgIO;
        private System.Windows.Forms.CheckBox cboxAutoOffAgIO;
        private System.Windows.Forms.Label labelPowerLossOnOff;
        private System.Windows.Forms.CheckBox cboxShutdownWhenNoPower;
        private System.Windows.Forms.Label labelHardwareMessage;
        private System.Windows.Forms.CheckBox cboxHardwareMessages;
        private System.Windows.Forms.Label label113;
        private NudlessNumericUpDown nudFixJumpDistance;
        private System.Windows.Forms.Label label118;
        private System.Windows.Forms.CheckBox cboxIsRTK_KillAutoSteer;
        private System.Windows.Forms.Label labelFixAlarmStop;
        private System.Windows.Forms.Label labelDirectionMarkOnOff;
        private System.Windows.Forms.CheckBox chkDirectionMarkers;
        private NudlessNumericUpDown nudNumGuideLines;
        private System.Windows.Forms.Label labelSectionLinesOnOff;
        private System.Windows.Forms.CheckBox chkSectionLines;
        private System.Windows.Forms.Label labelLineSmoothOnOff;
        private System.Windows.Forms.CheckBox chkLineSmooth;
        private System.Windows.Forms.CheckBox cboxIsAutoSwitchDualFixOn;
        private System.Windows.Forms.Label labelAutoSwitchDualFixSpeed;
        private NudlessNumericUpDown nudAutoSwitchDualFixSpeed;
        private System.Windows.Forms.Label labelUser1;
        private System.Windows.Forms.Label labelABSmoothOnOff;
        private System.Windows.Forms.PictureBox HitchLengthBlindBox;
        private System.Windows.Forms.Label lblHeadlandDist;
        private System.Windows.Forms.CheckBox chkboxHeadlandDist;
        private Forms.Config.ConfigSummaryControl configSummaryControl;
        private Forms.Config.ConfigVehicleControl configVehicleControl;
    }
}
namespace AgOpenGPS
{
    partial class FormHeadAche
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
            oglSelf = new OpenTK.GLControl.GLControl();
            timer1 = new System.Windows.Forms.Timer(components);
            headingGroupBox = new System.Windows.Forms.GroupBox();
            rbtnLine = new System.Windows.Forms.RadioButton();
            rbtnCurve = new System.Windows.Forms.RadioButton();
            cboxToolWidths = new System.Windows.Forms.ComboBox();
            lblToolWidth = new System.Windows.Forms.Label();
            btnAShrink = new System.Windows.Forms.Button();
            btnBShrink = new System.Windows.Forms.Button();
            btnHeadlandOff = new System.Windows.Forms.Button();
            btnCycleBackward = new System.Windows.Forms.Button();
            btnBndLoop = new System.Windows.Forms.Button();
            btnDeleteHeadland = new System.Windows.Forms.Button();
            cboxIsSectionControlled = new System.Windows.Forms.CheckBox();
            btnCycleForward = new System.Windows.Forms.Button();
            btnALength = new System.Windows.Forms.Button();
            btnBLength = new System.Windows.Forms.Button();
            btnDeleteCurve = new System.Windows.Forms.Button();
            btnExit = new System.Windows.Forms.Button();
            cboxIsZoom = new System.Windows.Forms.CheckBox();
            tlp1 = new System.Windows.Forms.TableLayoutPanel();
            btnCancelTouch = new System.Windows.Forms.Button();
            nudSetDistance = new NudlessNumericUpDown();
            tlp1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudSetDistance).BeginInit();
            SuspendLayout();
            // 
            // oglSelf
            // 
            oglSelf.API = OpenTK.Windowing.Common.ContextAPI.OpenGL;
            oglSelf.APIVersion = new System.Version(3, 3, 0, 0);
            oglSelf.BackColor = System.Drawing.Color.Black;
            oglSelf.Cursor = System.Windows.Forms.Cursors.Cross;
            oglSelf.Flags = OpenTK.Windowing.Common.ContextFlags.Default;
            oglSelf.IsEventDriven = true;
            oglSelf.Location = new System.Drawing.Point(0, 1);
            oglSelf.Margin = new System.Windows.Forms.Padding(0);
            oglSelf.Name = "oglSelf";
            oglSelf.Profile = OpenTK.Windowing.Common.ContextProfile.Compatability;
            oglSelf.SharedContext = null;
            oglSelf.Size = new System.Drawing.Size(817, 808);
            oglSelf.TabIndex = 183;
            oglSelf.Load += oglSelf_Load;
            oglSelf.Paint += oglSelf_Paint;
            oglSelf.MouseDown += oglSelf_MouseDown;
            oglSelf.Resize += oglSelf_Resize;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 500;
            timer1.Tick += timer1_Tick;
            // 
            // headingGroupBox
            // 
            headingGroupBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            headingGroupBox.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            headingGroupBox.ForeColor = System.Drawing.Color.Black;
            headingGroupBox.Location = new System.Drawing.Point(1056, 5);
            headingGroupBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            headingGroupBox.Name = "headingGroupBox";
            headingGroupBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            headingGroupBox.Size = new System.Drawing.Size(113, 250);
            headingGroupBox.TabIndex = 438;
            headingGroupBox.TabStop = false;
            // 
            // rbtnLine
            // 
            rbtnLine.Anchor = System.Windows.Forms.AnchorStyles.None;
            rbtnLine.Appearance = System.Windows.Forms.Appearance.Button;
            rbtnLine.BackColor = System.Drawing.Color.AliceBlue;
            tlp1.SetColumnSpan(rbtnLine, 3);
            rbtnLine.FlatAppearance.CheckedBackColor = System.Drawing.Color.PaleTurquoise;
            rbtnLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rbtnLine.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            rbtnLine.ForeColor = System.Drawing.Color.Black;
            rbtnLine.Image = Properties.Resources.ABTrackAB;
            rbtnLine.Location = new System.Drawing.Point(191, 221);
            rbtnLine.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rbtnLine.Name = "rbtnLine";
            rbtnLine.Size = new System.Drawing.Size(140, 83);
            rbtnLine.TabIndex = 2;
            rbtnLine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            rbtnLine.UseVisualStyleBackColor = false;
            // 
            // rbtnCurve
            // 
            rbtnCurve.Anchor = System.Windows.Forms.AnchorStyles.None;
            rbtnCurve.Appearance = System.Windows.Forms.Appearance.Button;
            rbtnCurve.BackColor = System.Drawing.Color.AliceBlue;
            rbtnCurve.Checked = true;
            tlp1.SetColumnSpan(rbtnCurve, 3);
            rbtnCurve.FlatAppearance.CheckedBackColor = System.Drawing.Color.PaleTurquoise;
            rbtnCurve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rbtnCurve.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            rbtnCurve.ForeColor = System.Drawing.Color.Black;
            rbtnCurve.Image = Properties.Resources.ABTrackCurve;
            rbtnCurve.Location = new System.Drawing.Point(17, 221);
            rbtnCurve.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rbtnCurve.Name = "rbtnCurve";
            rbtnCurve.Size = new System.Drawing.Size(140, 83);
            rbtnCurve.TabIndex = 0;
            rbtnCurve.TabStop = true;
            rbtnCurve.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            rbtnCurve.UseVisualStyleBackColor = false;
            // 
            // cboxToolWidths
            // 
            cboxToolWidths.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            cboxToolWidths.BackColor = System.Drawing.Color.Lavender;
            tlp1.SetColumnSpan(cboxToolWidths, 2);
            cboxToolWidths.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboxToolWidths.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cboxToolWidths.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cboxToolWidths.FormattingEnabled = true;
            cboxToolWidths.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            cboxToolWidths.Location = new System.Drawing.Point(238, 350);
            cboxToolWidths.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            cboxToolWidths.Name = "cboxToolWidths";
            cboxToolWidths.Size = new System.Drawing.Size(104, 53);
            cboxToolWidths.TabIndex = 510;
            cboxToolWidths.SelectedIndexChanged += cboxToolWidths_SelectedIndexChanged;
            // 
            // lblToolWidth
            // 
            lblToolWidth.Anchor = System.Windows.Forms.AnchorStyles.None;
            tlp1.SetColumnSpan(lblToolWidth, 6);
            lblToolWidth.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblToolWidth.ForeColor = System.Drawing.Color.Black;
            lblToolWidth.Location = new System.Drawing.Point(4, 411);
            lblToolWidth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblToolWidth.Name = "lblToolWidth";
            lblToolWidth.Size = new System.Drawing.Size(341, 30);
            lblToolWidth.TabIndex = 511;
            lblToolWidth.Text = "3.86";
            lblToolWidth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAShrink
            // 
            btnAShrink.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnAShrink.BackColor = System.Drawing.Color.Transparent;
            btnAShrink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            tlp1.SetColumnSpan(btnAShrink, 2);
            btnAShrink.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            btnAShrink.FlatAppearance.BorderSize = 0;
            btnAShrink.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            btnAShrink.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            btnAShrink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAShrink.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnAShrink.Image = Properties.Resources.APlusMinusA;
            btnAShrink.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnAShrink.Location = new System.Drawing.Point(120, 128);
            btnAShrink.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnAShrink.Name = "btnAShrink";
            btnAShrink.Size = new System.Drawing.Size(107, 60);
            btnAShrink.TabIndex = 525;
            btnAShrink.UseVisualStyleBackColor = false;
            btnAShrink.Click += btnAShrink_Click;
            // 
            // btnBShrink
            // 
            btnBShrink.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnBShrink.BackColor = System.Drawing.Color.Transparent;
            btnBShrink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            tlp1.SetColumnSpan(btnBShrink, 2);
            btnBShrink.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            btnBShrink.FlatAppearance.BorderSize = 0;
            btnBShrink.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            btnBShrink.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            btnBShrink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBShrink.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnBShrink.Image = Properties.Resources.APlusMinusB;
            btnBShrink.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnBShrink.Location = new System.Drawing.Point(120, 24);
            btnBShrink.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnBShrink.Name = "btnBShrink";
            btnBShrink.Size = new System.Drawing.Size(107, 60);
            btnBShrink.TabIndex = 524;
            btnBShrink.UseVisualStyleBackColor = false;
            btnBShrink.Click += btnBShrink_Click;
            // 
            // btnHeadlandOff
            // 
            btnHeadlandOff.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnHeadlandOff.BackColor = System.Drawing.Color.Transparent;
            btnHeadlandOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            tlp1.SetColumnSpan(btnHeadlandOff, 2);
            btnHeadlandOff.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            btnHeadlandOff.FlatAppearance.BorderSize = 0;
            btnHeadlandOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnHeadlandOff.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnHeadlandOff.Image = Properties.Resources.SwitchOff;
            btnHeadlandOff.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnHeadlandOff.Location = new System.Drawing.Point(21, 714);
            btnHeadlandOff.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnHeadlandOff.Name = "btnHeadlandOff";
            btnHeadlandOff.Size = new System.Drawing.Size(74, 81);
            btnHeadlandOff.TabIndex = 519;
            btnHeadlandOff.UseVisualStyleBackColor = false;
            btnHeadlandOff.Click += btnHeadlandOff_Click;
            // 
            // btnCycleBackward
            // 
            btnCycleBackward.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnCycleBackward.BackColor = System.Drawing.Color.Transparent;
            btnCycleBackward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            tlp1.SetColumnSpan(btnCycleBackward, 2);
            btnCycleBackward.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            btnCycleBackward.FlatAppearance.BorderSize = 0;
            btnCycleBackward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCycleBackward.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnCycleBackward.Image = Properties.Resources.ABLineCycleBk;
            btnCycleBackward.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnCycleBackward.Location = new System.Drawing.Point(137, 599);
            btnCycleBackward.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCycleBackward.Name = "btnCycleBackward";
            btnCycleBackward.Size = new System.Drawing.Size(74, 78);
            btnCycleBackward.TabIndex = 507;
            btnCycleBackward.UseVisualStyleBackColor = false;
            btnCycleBackward.Click += btnCycleBackward_Click;
            // 
            // btnBndLoop
            // 
            btnBndLoop.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnBndLoop.BackColor = System.Drawing.Color.Transparent;
            btnBndLoop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            tlp1.SetColumnSpan(btnBndLoop, 3);
            btnBndLoop.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            btnBndLoop.FlatAppearance.BorderSize = 0;
            btnBndLoop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBndLoop.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnBndLoop.Image = Properties.Resources.HeadlandBuild;
            btnBndLoop.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnBndLoop.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnBndLoop.Location = new System.Drawing.Point(37, 450);
            btnBndLoop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnBndLoop.Name = "btnBndLoop";
            btnBndLoop.Size = new System.Drawing.Size(99, 119);
            btnBndLoop.TabIndex = 504;
            btnBndLoop.Text = "Build";
            btnBndLoop.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnBndLoop.UseVisualStyleBackColor = false;
            btnBndLoop.Click += btnBndLoop_Click;
            // 
            // btnDeleteHeadland
            // 
            btnDeleteHeadland.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnDeleteHeadland.BackColor = System.Drawing.Color.Transparent;
            btnDeleteHeadland.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            tlp1.SetColumnSpan(btnDeleteHeadland, 3);
            btnDeleteHeadland.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            btnDeleteHeadland.FlatAppearance.BorderSize = 0;
            btnDeleteHeadland.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDeleteHeadland.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnDeleteHeadland.Image = Properties.Resources.HeadlandReset;
            btnDeleteHeadland.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnDeleteHeadland.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnDeleteHeadland.Location = new System.Drawing.Point(208, 450);
            btnDeleteHeadland.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnDeleteHeadland.Name = "btnDeleteHeadland";
            btnDeleteHeadland.Size = new System.Drawing.Size(107, 119);
            btnDeleteHeadland.TabIndex = 465;
            btnDeleteHeadland.Text = "Reset";
            btnDeleteHeadland.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnDeleteHeadland.UseVisualStyleBackColor = false;
            btnDeleteHeadland.Click += btnDeleteHeadland_Click;
            // 
            // cboxIsSectionControlled
            // 
            cboxIsSectionControlled.Anchor = System.Windows.Forms.AnchorStyles.None;
            cboxIsSectionControlled.Appearance = System.Windows.Forms.Appearance.Button;
            cboxIsSectionControlled.BackColor = System.Drawing.Color.Transparent;
            cboxIsSectionControlled.Checked = true;
            cboxIsSectionControlled.CheckState = System.Windows.Forms.CheckState.Checked;
            tlp1.SetColumnSpan(cboxIsSectionControlled, 2);
            cboxIsSectionControlled.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            cboxIsSectionControlled.FlatAppearance.BorderSize = 0;
            cboxIsSectionControlled.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            cboxIsSectionControlled.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboxIsSectionControlled.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cboxIsSectionControlled.ForeColor = System.Drawing.SystemColors.ButtonFace;
            cboxIsSectionControlled.Image = Properties.Resources.HeadlandSectionOff;
            cboxIsSectionControlled.Location = new System.Drawing.Point(253, 17);
            cboxIsSectionControlled.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cboxIsSectionControlled.Name = "cboxIsSectionControlled";
            cboxIsSectionControlled.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            cboxIsSectionControlled.Size = new System.Drawing.Size(74, 75);
            cboxIsSectionControlled.TabIndex = 467;
            cboxIsSectionControlled.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            cboxIsSectionControlled.UseVisualStyleBackColor = false;
            cboxIsSectionControlled.Click += cboxIsSectionControlled_Click;
            // 
            // btnCycleForward
            // 
            btnCycleForward.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnCycleForward.BackColor = System.Drawing.Color.Transparent;
            btnCycleForward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            tlp1.SetColumnSpan(btnCycleForward, 2);
            btnCycleForward.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            btnCycleForward.FlatAppearance.BorderSize = 0;
            btnCycleForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCycleForward.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnCycleForward.Image = Properties.Resources.ABLineCycle;
            btnCycleForward.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnCycleForward.Location = new System.Drawing.Point(253, 599);
            btnCycleForward.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCycleForward.Name = "btnCycleForward";
            btnCycleForward.Size = new System.Drawing.Size(74, 78);
            btnCycleForward.TabIndex = 5;
            btnCycleForward.UseVisualStyleBackColor = false;
            btnCycleForward.Click += btnCycleForward_Click;
            // 
            // btnALength
            // 
            btnALength.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnALength.BackColor = System.Drawing.Color.Transparent;
            btnALength.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            tlp1.SetColumnSpan(btnALength, 2);
            btnALength.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            btnALength.FlatAppearance.BorderSize = 0;
            btnALength.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            btnALength.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            btnALength.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnALength.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnALength.Image = Properties.Resources.APlusPlusA;
            btnALength.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnALength.Location = new System.Drawing.Point(4, 128);
            btnALength.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnALength.Name = "btnALength";
            btnALength.Size = new System.Drawing.Size(107, 60);
            btnALength.TabIndex = 352;
            btnALength.UseVisualStyleBackColor = false;
            btnALength.Click += btnALength_Click;
            // 
            // btnBLength
            // 
            btnBLength.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnBLength.BackColor = System.Drawing.Color.Transparent;
            btnBLength.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            tlp1.SetColumnSpan(btnBLength, 2);
            btnBLength.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            btnBLength.FlatAppearance.BorderSize = 0;
            btnBLength.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            btnBLength.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            btnBLength.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBLength.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnBLength.Image = Properties.Resources.APlusPlusB;
            btnBLength.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnBLength.Location = new System.Drawing.Point(4, 24);
            btnBLength.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnBLength.Name = "btnBLength";
            btnBLength.Size = new System.Drawing.Size(107, 60);
            btnBLength.TabIndex = 351;
            btnBLength.UseVisualStyleBackColor = false;
            btnBLength.Click += btnBLength_Click;
            // 
            // btnDeleteCurve
            // 
            btnDeleteCurve.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnDeleteCurve.BackColor = System.Drawing.Color.Transparent;
            btnDeleteCurve.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            tlp1.SetColumnSpan(btnDeleteCurve, 2);
            btnDeleteCurve.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            btnDeleteCurve.FlatAppearance.BorderSize = 0;
            btnDeleteCurve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDeleteCurve.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnDeleteCurve.Image = Properties.Resources.Trash;
            btnDeleteCurve.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnDeleteCurve.Location = new System.Drawing.Point(141, 725);
            btnDeleteCurve.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnDeleteCurve.Name = "btnDeleteCurve";
            btnDeleteCurve.Size = new System.Drawing.Size(66, 59);
            btnDeleteCurve.TabIndex = 6;
            btnDeleteCurve.UseVisualStyleBackColor = false;
            btnDeleteCurve.Click += btnDeleteCurve_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnExit.BackColor = System.Drawing.Color.Transparent;
            tlp1.SetColumnSpan(btnExit, 2);
            btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnExit.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnExit.ForeColor = System.Drawing.Color.FromArgb(192, 64, 0);
            btnExit.Image = Properties.Resources.OK64;
            btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnExit.Location = new System.Drawing.Point(253, 714);
            btnExit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(74, 81);
            btnExit.TabIndex = 0;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // cboxIsZoom
            // 
            cboxIsZoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            cboxIsZoom.Appearance = System.Windows.Forms.Appearance.Button;
            cboxIsZoom.BackColor = System.Drawing.Color.WhiteSmoke;
            tlp1.SetColumnSpan(cboxIsZoom, 2);
            cboxIsZoom.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            cboxIsZoom.FlatAppearance.BorderSize = 0;
            cboxIsZoom.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(180, 255, 160);
            cboxIsZoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboxIsZoom.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            cboxIsZoom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            cboxIsZoom.Image = Properties.Resources.ZoomOGL;
            cboxIsZoom.Location = new System.Drawing.Point(4, 578);
            cboxIsZoom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cboxIsZoom.Name = "cboxIsZoom";
            cboxIsZoom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            cboxIsZoom.Size = new System.Drawing.Size(107, 120);
            cboxIsZoom.TabIndex = 564;
            cboxIsZoom.Text = "Zoom";
            cboxIsZoom.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            cboxIsZoom.UseVisualStyleBackColor = false;
            cboxIsZoom.CheckedChanged += cboxIsZoom_CheckedChanged;
            // 
            // tlp1
            // 
            tlp1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
            tlp1.ColumnCount = 6;
            tlp1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            tlp1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            tlp1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            tlp1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            tlp1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            tlp1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            tlp1.Controls.Add(cboxIsZoom, 0, 6);
            tlp1.Controls.Add(btnCancelTouch, 4, 1);
            tlp1.Controls.Add(btnALength, 0, 1);
            tlp1.Controls.Add(btnBLength, 0, 0);
            tlp1.Controls.Add(rbtnCurve, 0, 2);
            tlp1.Controls.Add(rbtnLine, 3, 2);
            tlp1.Controls.Add(btnBShrink, 2, 0);
            tlp1.Controls.Add(btnAShrink, 2, 1);
            tlp1.Controls.Add(cboxToolWidths, 4, 3);
            tlp1.Controls.Add(btnExit, 4, 7);
            tlp1.Controls.Add(cboxIsSectionControlled, 4, 0);
            tlp1.Controls.Add(btnHeadlandOff, 0, 7);
            tlp1.Controls.Add(nudSetDistance, 0, 3);
            tlp1.Controls.Add(btnDeleteCurve, 2, 7);
            tlp1.Controls.Add(lblToolWidth, 0, 4);
            tlp1.Controls.Add(btnCycleBackward, 2, 6);
            tlp1.Controls.Add(btnCycleForward, 4, 6);
            tlp1.Controls.Add(btnBndLoop, 0, 5);
            tlp1.Controls.Add(btnDeleteHeadland, 3, 5);
            tlp1.Location = new System.Drawing.Point(818, 3);
            tlp1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tlp1.Name = "tlp1";
            tlp1.RowCount = 8;
            tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.57143F));
            tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.14286F));
            tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.85714F));
            tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11F));
            tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.142857F));
            tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.57143F));
            tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.57143F));
            tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.85714F));
            tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            tlp1.Size = new System.Drawing.Size(349, 805);
            tlp1.TabIndex = 565;
            // 
            // btnCancelTouch
            // 
            btnCancelTouch.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnCancelTouch.BackColor = System.Drawing.Color.Transparent;
            btnCancelTouch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            tlp1.SetColumnSpan(btnCancelTouch, 2);
            btnCancelTouch.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            btnCancelTouch.FlatAppearance.BorderSize = 0;
            btnCancelTouch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancelTouch.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnCancelTouch.Image = Properties.Resources.HeadlandDeletePoints;
            btnCancelTouch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnCancelTouch.Location = new System.Drawing.Point(248, 124);
            btnCancelTouch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCancelTouch.Name = "btnCancelTouch";
            btnCancelTouch.Size = new System.Drawing.Size(84, 67);
            btnCancelTouch.TabIndex = 565;
            btnCancelTouch.UseVisualStyleBackColor = false;
            btnCancelTouch.Click += btnCancelTouch_Click;
            // 
            // nudSetDistance
            // 
            nudSetDistance.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            nudSetDistance.BackColor = System.Drawing.Color.White;
            tlp1.SetColumnSpan(nudSetDistance, 4);
            nudSetDistance.DecimalPlaces = 1;
            nudSetDistance.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            nudSetDistance.Location = new System.Drawing.Point(22, 351);
            nudSetDistance.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            nudSetDistance.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            nudSetDistance.Name = "nudSetDistance";
            nudSetDistance.ReadOnly = true;
            nudSetDistance.Size = new System.Drawing.Size(188, 52);
            nudSetDistance.TabIndex = 464;
            nudSetDistance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudSetDistance.Value = new decimal(new int[] { 0, 0, 0, 0 });
            nudSetDistance.Click += nudSetDistance_Click;
            // 
            // FormHeadAche
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.WhiteSmoke;
            ClientSize = new System.Drawing.Size(1174, 838);
            ControlBox = false;
            Controls.Add(tlp1);
            Controls.Add(oglSelf);
            Controls.Add(headingGroupBox);
            ForeColor = System.Drawing.Color.Black;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size(1190, 850);
            Name = "FormHeadAche";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Click 2 points on the Boundary to Begin";
            FormClosing += FormHeadLine_FormClosing;
            Load += FormHeadLine_Load;
            ResizeEnd += FormHeadAche_ResizeEnd;
            tlp1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudSetDistance).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private OpenTK.GLControl.GLControl oglSelf;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCycleForward;
        private System.Windows.Forms.Button btnDeleteCurve;
        private System.Windows.Forms.Button btnBLength;
        private System.Windows.Forms.Button btnALength;
        private System.Windows.Forms.GroupBox headingGroupBox;
        private System.Windows.Forms.RadioButton rbtnLine;
        private System.Windows.Forms.RadioButton rbtnCurve;
        private NudlessNumericUpDown nudSetDistance;
        private System.Windows.Forms.Button btnDeleteHeadland;
        private System.Windows.Forms.CheckBox cboxIsSectionControlled;
        private System.Windows.Forms.Button btnBndLoop;
        private System.Windows.Forms.Button btnCycleBackward;
        private System.Windows.Forms.ComboBox cboxToolWidths;
        private System.Windows.Forms.Label lblToolWidth;
        private System.Windows.Forms.Button btnHeadlandOff;
        private System.Windows.Forms.Button btnAShrink;
        private System.Windows.Forms.Button btnBShrink;
        private System.Windows.Forms.CheckBox cboxIsZoom;
        private System.Windows.Forms.TableLayoutPanel tlp1;
        private System.Windows.Forms.Button btnCancelTouch;
    }
}
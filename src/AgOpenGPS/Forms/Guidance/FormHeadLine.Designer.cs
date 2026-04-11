namespace AgOpenGPS
{
    partial class FormHeadLine
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
            lblToolWidth = new System.Windows.Forms.Label();
            cboxToolWidths = new System.Windows.Forms.ComboBox();
            tlp1 = new System.Windows.Forms.TableLayoutPanel();
            btnClipLine = new System.Windows.Forms.Button();
            nudSetDistance = new NudlessNumericUpDown();
            checkBoxZoomIn = new System.Windows.Forms.CheckBox();
            btnDeletePoints = new System.Windows.Forms.Button();
            btnBndLoop = new System.Windows.Forms.Button();
            btnAShrink = new System.Windows.Forms.Button();
            btnBShrink = new System.Windows.Forms.Button();
            btnBLength = new System.Windows.Forms.Button();
            btnExit = new System.Windows.Forms.Button();
            btnALength = new System.Windows.Forms.Button();
            btnHeadlandOff = new System.Windows.Forms.Button();
            cboxIsSectionControlled = new System.Windows.Forms.CheckBox();
            rbtnLine = new System.Windows.Forms.RadioButton();
            rbtnCurve = new System.Windows.Forms.RadioButton();
            btnUndo = new System.Windows.Forms.Button();
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
            oglSelf.Location = new System.Drawing.Point(1, 2);
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
            headingGroupBox.Location = new System.Drawing.Point(1049, 2);
            headingGroupBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            headingGroupBox.Name = "headingGroupBox";
            headingGroupBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            headingGroupBox.Size = new System.Drawing.Size(119, 264);
            headingGroupBox.TabIndex = 438;
            headingGroupBox.TabStop = false;
            // 
            // lblToolWidth
            // 
            lblToolWidth.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tlp1.SetColumnSpan(lblToolWidth, 2);
            lblToolWidth.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblToolWidth.ForeColor = System.Drawing.Color.Black;
            lblToolWidth.Location = new System.Drawing.Point(4, 355);
            lblToolWidth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblToolWidth.Name = "lblToolWidth";
            lblToolWidth.Size = new System.Drawing.Size(340, 30);
            lblToolWidth.TabIndex = 517;
            lblToolWidth.Text = "43.56 m";
            lblToolWidth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboxToolWidths
            // 
            cboxToolWidths.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            cboxToolWidths.BackColor = System.Drawing.Color.Lavender;
            cboxToolWidths.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboxToolWidths.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cboxToolWidths.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cboxToolWidths.FormattingEnabled = true;
            cboxToolWidths.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            cboxToolWidths.Location = new System.Drawing.Point(214, 298);
            cboxToolWidths.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            cboxToolWidths.Name = "cboxToolWidths";
            cboxToolWidths.Size = new System.Drawing.Size(102, 53);
            cboxToolWidths.TabIndex = 516;
            cboxToolWidths.SelectedIndexChanged += cboxToolWidths_SelectedIndexChanged;
            // 
            // tlp1
            // 
            tlp1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            tlp1.ColumnCount = 2;
            tlp1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.30263F));
            tlp1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.69737F));
            tlp1.Controls.Add(btnClipLine, 0, 6);
            tlp1.Controls.Add(nudSetDistance, 0, 3);
            tlp1.Controls.Add(checkBoxZoomIn, 0, 7);
            tlp1.Controls.Add(btnDeletePoints, 1, 5);
            tlp1.Controls.Add(btnBndLoop, 0, 5);
            tlp1.Controls.Add(btnAShrink, 1, 1);
            tlp1.Controls.Add(btnBShrink, 1, 0);
            tlp1.Controls.Add(btnBLength, 0, 0);
            tlp1.Controls.Add(btnExit, 1, 8);
            tlp1.Controls.Add(btnALength, 0, 1);
            tlp1.Controls.Add(btnHeadlandOff, 0, 8);
            tlp1.Controls.Add(cboxIsSectionControlled, 1, 7);
            tlp1.Controls.Add(cboxToolWidths, 1, 3);
            tlp1.Controls.Add(rbtnLine, 1, 2);
            tlp1.Controls.Add(rbtnCurve, 0, 2);
            tlp1.Controls.Add(lblToolWidth, 0, 4);
            tlp1.Controls.Add(btnUndo, 1, 6);
            tlp1.Location = new System.Drawing.Point(820, 1);
            tlp1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tlp1.Name = "tlp1";
            tlp1.RowCount = 9;
            tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.249717F));
            tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.249715F));
            tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.49281F));
            tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.84249F));
            tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.90964F));
            tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.90964F));
            tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.10241F));
            tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.13218F));
            tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            tlp1.Size = new System.Drawing.Size(348, 809);
            tlp1.TabIndex = 565;
            // 
            // btnClipLine
            // 
            btnClipLine.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnClipLine.BackColor = System.Drawing.Color.Transparent;
            btnClipLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            btnClipLine.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            btnClipLine.FlatAppearance.BorderSize = 0;
            btnClipLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClipLine.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnClipLine.Image = Properties.Resources.HeadlandSlice;
            btnClipLine.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnClipLine.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnClipLine.Location = new System.Drawing.Point(4, 505);
            btnClipLine.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnClipLine.Name = "btnClipLine";
            btnClipLine.Size = new System.Drawing.Size(174, 107);
            btnClipLine.TabIndex = 519;
            btnClipLine.Text = "Clip Line";
            btnClipLine.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnClipLine.UseVisualStyleBackColor = false;
            btnClipLine.Click += btnSlice_Click;
            // 
            // nudSetDistance
            // 
            nudSetDistance.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            nudSetDistance.BackColor = System.Drawing.Color.White;
            nudSetDistance.DecimalPlaces = 1;
            nudSetDistance.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            nudSetDistance.Location = new System.Drawing.Point(7, 299);
            nudSetDistance.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            nudSetDistance.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            nudSetDistance.Name = "nudSetDistance";
            nudSetDistance.ReadOnly = true;
            nudSetDistance.Size = new System.Drawing.Size(167, 52);
            nudSetDistance.TabIndex = 464;
            nudSetDistance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudSetDistance.Value = new decimal(new int[] { 0, 0, 0, 0 });
            nudSetDistance.Click += nudSetDistance_Click;
            // 
            // checkBoxZoomIn
            // 
            checkBoxZoomIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            checkBoxZoomIn.Appearance = System.Windows.Forms.Appearance.Button;
            checkBoxZoomIn.BackColor = System.Drawing.Color.WhiteSmoke;
            checkBoxZoomIn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            checkBoxZoomIn.FlatAppearance.BorderSize = 0;
            checkBoxZoomIn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(180, 255, 160);
            checkBoxZoomIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            checkBoxZoomIn.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            checkBoxZoomIn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            checkBoxZoomIn.Image = Properties.Resources.ZoomOGL;
            checkBoxZoomIn.Location = new System.Drawing.Point(30, 620);
            checkBoxZoomIn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            checkBoxZoomIn.Name = "checkBoxZoomIn";
            checkBoxZoomIn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            checkBoxZoomIn.Size = new System.Drawing.Size(121, 93);
            checkBoxZoomIn.TabIndex = 564;
            checkBoxZoomIn.Text = "Zoom In";
            checkBoxZoomIn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            checkBoxZoomIn.UseVisualStyleBackColor = false;
            checkBoxZoomIn.CheckedChanged += cboxIsZoom_CheckedChanged;
            // 
            // btnDeletePoints
            // 
            btnDeletePoints.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnDeletePoints.BackColor = System.Drawing.Color.Transparent;
            btnDeletePoints.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            btnDeletePoints.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            btnDeletePoints.FlatAppearance.BorderSize = 0;
            btnDeletePoints.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDeletePoints.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnDeletePoints.Image = Properties.Resources.HeadlandReset;
            btnDeletePoints.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnDeletePoints.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnDeletePoints.Location = new System.Drawing.Point(204, 390);
            btnDeletePoints.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnDeletePoints.Name = "btnDeletePoints";
            btnDeletePoints.Size = new System.Drawing.Size(121, 107);
            btnDeletePoints.TabIndex = 506;
            btnDeletePoints.Text = "Reset";
            btnDeletePoints.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnDeletePoints.UseVisualStyleBackColor = false;
            btnDeletePoints.Click += btnDeletePoints_Click;
            // 
            // btnBndLoop
            // 
            btnBndLoop.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnBndLoop.BackColor = System.Drawing.Color.Transparent;
            btnBndLoop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            btnBndLoop.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            btnBndLoop.FlatAppearance.BorderSize = 0;
            btnBndLoop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBndLoop.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnBndLoop.Image = Properties.Resources.HeadlandBuild;
            btnBndLoop.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnBndLoop.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnBndLoop.Location = new System.Drawing.Point(8, 390);
            btnBndLoop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnBndLoop.Name = "btnBndLoop";
            btnBndLoop.Size = new System.Drawing.Size(166, 107);
            btnBndLoop.TabIndex = 504;
            btnBndLoop.Text = "Build";
            btnBndLoop.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnBndLoop.UseVisualStyleBackColor = false;
            btnBndLoop.Click += btnBndLoop_Click;
            // 
            // btnAShrink
            // 
            btnAShrink.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnAShrink.BackColor = System.Drawing.Color.Transparent;
            btnAShrink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnAShrink.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            btnAShrink.FlatAppearance.BorderSize = 0;
            btnAShrink.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            btnAShrink.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            btnAShrink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAShrink.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnAShrink.Image = Properties.Resources.APlusMinusA;
            btnAShrink.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnAShrink.Location = new System.Drawing.Point(210, 81);
            btnAShrink.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnAShrink.Name = "btnAShrink";
            btnAShrink.Size = new System.Drawing.Size(110, 50);
            btnAShrink.TabIndex = 529;
            btnAShrink.UseVisualStyleBackColor = false;
            btnAShrink.Click += btnAShrink_Click;
            // 
            // btnBShrink
            // 
            btnBShrink.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnBShrink.BackColor = System.Drawing.Color.Transparent;
            btnBShrink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnBShrink.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            btnBShrink.FlatAppearance.BorderSize = 0;
            btnBShrink.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            btnBShrink.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            btnBShrink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBShrink.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnBShrink.Image = Properties.Resources.APlusMinusB;
            btnBShrink.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnBShrink.Location = new System.Drawing.Point(210, 9);
            btnBShrink.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnBShrink.Name = "btnBShrink";
            btnBShrink.Size = new System.Drawing.Size(110, 52);
            btnBShrink.TabIndex = 528;
            btnBShrink.UseVisualStyleBackColor = false;
            btnBShrink.Click += btnBShrink_Click;
            // 
            // btnBLength
            // 
            btnBLength.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnBLength.BackColor = System.Drawing.Color.Transparent;
            btnBLength.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnBLength.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            btnBLength.FlatAppearance.BorderSize = 0;
            btnBLength.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            btnBLength.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            btnBLength.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBLength.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnBLength.Image = Properties.Resources.APlusPlusB;
            btnBLength.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnBLength.Location = new System.Drawing.Point(36, 9);
            btnBLength.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnBLength.Name = "btnBLength";
            btnBLength.Size = new System.Drawing.Size(110, 52);
            btnBLength.TabIndex = 351;
            btnBLength.UseVisualStyleBackColor = false;
            btnBLength.Click += btnBLength_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnExit.BackColor = System.Drawing.Color.Transparent;
            btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnExit.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnExit.ForeColor = System.Drawing.Color.FromArgb(192, 64, 0);
            btnExit.Image = Properties.Resources.OK64;
            btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnExit.Location = new System.Drawing.Point(191, 726);
            btnExit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(147, 74);
            btnExit.TabIndex = 0;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnALength
            // 
            btnALength.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnALength.BackColor = System.Drawing.Color.Transparent;
            btnALength.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnALength.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            btnALength.FlatAppearance.BorderSize = 0;
            btnALength.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            btnALength.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            btnALength.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnALength.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnALength.Image = Properties.Resources.APlusPlusA;
            btnALength.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnALength.Location = new System.Drawing.Point(36, 81);
            btnALength.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnALength.Name = "btnALength";
            btnALength.Size = new System.Drawing.Size(110, 50);
            btnALength.TabIndex = 352;
            btnALength.UseVisualStyleBackColor = false;
            btnALength.Click += btnALength_Click;
            // 
            // btnHeadlandOff
            // 
            btnHeadlandOff.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnHeadlandOff.BackColor = System.Drawing.Color.Transparent;
            btnHeadlandOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            btnHeadlandOff.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            btnHeadlandOff.FlatAppearance.BorderSize = 0;
            btnHeadlandOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnHeadlandOff.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnHeadlandOff.Image = Properties.Resources.SwitchOff;
            btnHeadlandOff.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnHeadlandOff.Location = new System.Drawing.Point(31, 730);
            btnHeadlandOff.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnHeadlandOff.Name = "btnHeadlandOff";
            btnHeadlandOff.Size = new System.Drawing.Size(120, 66);
            btnHeadlandOff.TabIndex = 518;
            btnHeadlandOff.UseVisualStyleBackColor = false;
            btnHeadlandOff.Click += btnHeadlandOff_Click;
            // 
            // cboxIsSectionControlled
            // 
            cboxIsSectionControlled.Anchor = System.Windows.Forms.AnchorStyles.None;
            cboxIsSectionControlled.Appearance = System.Windows.Forms.Appearance.Button;
            cboxIsSectionControlled.BackColor = System.Drawing.Color.Transparent;
            cboxIsSectionControlled.Checked = true;
            cboxIsSectionControlled.CheckState = System.Windows.Forms.CheckState.Checked;
            cboxIsSectionControlled.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            cboxIsSectionControlled.FlatAppearance.BorderSize = 0;
            cboxIsSectionControlled.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            cboxIsSectionControlled.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboxIsSectionControlled.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cboxIsSectionControlled.ForeColor = System.Drawing.SystemColors.ButtonFace;
            cboxIsSectionControlled.Image = Properties.Resources.HeadlandSectionOn;
            cboxIsSectionControlled.Location = new System.Drawing.Point(207, 625);
            cboxIsSectionControlled.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cboxIsSectionControlled.Name = "cboxIsSectionControlled";
            cboxIsSectionControlled.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            cboxIsSectionControlled.Size = new System.Drawing.Size(115, 82);
            cboxIsSectionControlled.TabIndex = 467;
            cboxIsSectionControlled.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            cboxIsSectionControlled.UseVisualStyleBackColor = false;
            cboxIsSectionControlled.Click += cboxIsSectionControlled_Click;
            // 
            // rbtnLine
            // 
            rbtnLine.Anchor = System.Windows.Forms.AnchorStyles.None;
            rbtnLine.Appearance = System.Windows.Forms.Appearance.Button;
            rbtnLine.BackColor = System.Drawing.Color.AliceBlue;
            rbtnLine.FlatAppearance.CheckedBackColor = System.Drawing.Color.PaleTurquoise;
            rbtnLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rbtnLine.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            rbtnLine.ForeColor = System.Drawing.Color.Black;
            rbtnLine.Image = Properties.Resources.ABTrackAB;
            rbtnLine.Location = new System.Drawing.Point(204, 157);
            rbtnLine.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rbtnLine.Name = "rbtnLine";
            rbtnLine.Size = new System.Drawing.Size(121, 98);
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
            rbtnCurve.FlatAppearance.CheckedBackColor = System.Drawing.Color.PaleTurquoise;
            rbtnCurve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rbtnCurve.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            rbtnCurve.ForeColor = System.Drawing.Color.Black;
            rbtnCurve.Image = Properties.Resources.ABTrackCurve;
            rbtnCurve.Location = new System.Drawing.Point(30, 157);
            rbtnCurve.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rbtnCurve.Name = "rbtnCurve";
            rbtnCurve.Size = new System.Drawing.Size(121, 98);
            rbtnCurve.TabIndex = 0;
            rbtnCurve.TabStop = true;
            rbtnCurve.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            rbtnCurve.UseVisualStyleBackColor = false;
            // 
            // btnUndo
            // 
            btnUndo.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnUndo.BackColor = System.Drawing.Color.Transparent;
            btnUndo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            btnUndo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            btnUndo.FlatAppearance.BorderSize = 0;
            btnUndo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnUndo.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnUndo.Image = Properties.Resources.back_button;
            btnUndo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnUndo.Location = new System.Drawing.Point(207, 525);
            btnUndo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnUndo.Name = "btnUndo";
            btnUndo.Size = new System.Drawing.Size(115, 66);
            btnUndo.TabIndex = 514;
            btnUndo.UseVisualStyleBackColor = false;
            btnUndo.Click += btnUndo_Click;
            // 
            // FormHeadLine
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.WhiteSmoke;
            ClientSize = new System.Drawing.Size(1174, 838);
            ControlBox = false;
            Controls.Add(tlp1);
            Controls.Add(headingGroupBox);
            Controls.Add(oglSelf);
            ForeColor = System.Drawing.Color.Black;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size(1190, 850);
            Name = "FormHeadLine";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Click 2 points on the Boundary to Begin";
            FormClosing += FormHeadLine_FormClosing;
            Load += FormHeadLine_Load;
            ResizeEnd += FormHeadLine_ResizeEnd;
            tlp1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudSetDistance).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private OpenTK.GLControl.GLControl oglSelf;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBLength;
        private System.Windows.Forms.Button btnALength;
        private System.Windows.Forms.GroupBox headingGroupBox;
        private System.Windows.Forms.RadioButton rbtnLine;
        private System.Windows.Forms.RadioButton rbtnCurve;
        private NudlessNumericUpDown nudSetDistance;
        private System.Windows.Forms.CheckBox cboxIsSectionControlled;
        private System.Windows.Forms.Button btnBndLoop;
        private System.Windows.Forms.Button btnDeletePoints;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Label lblToolWidth;
        private System.Windows.Forms.ComboBox cboxToolWidths;
        private System.Windows.Forms.Button btnHeadlandOff;
        private System.Windows.Forms.Button btnClipLine;
        private System.Windows.Forms.Button btnAShrink;
        private System.Windows.Forms.Button btnBShrink;
        private System.Windows.Forms.CheckBox checkBoxZoomIn;
        private System.Windows.Forms.TableLayoutPanel tlp1;
    }
}
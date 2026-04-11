namespace AgOpenGPS
{
    partial class FormABDraw
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
            lblCurveSelected = new System.Windows.Forms.Label();
            tboxNameCurve = new System.Windows.Forms.TextBox();
            tlp1 = new System.Windows.Forms.TableLayoutPanel();
            btnBLength = new System.Windows.Forms.Button();
            btnDrawSections = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            btnALength = new System.Windows.Forms.Button();
            btnExit = new System.Windows.Forms.Button();
            btnDeleteCurve = new System.Windows.Forms.Button();
            btnMakeCurve = new System.Windows.Forms.Button();
            btnMakeABLine = new System.Windows.Forms.Button();
            cboxIsZoom = new System.Windows.Forms.CheckBox();
            cboxIsVisible = new System.Windows.Forms.CheckBox();
            btnMakeBoundaryCurve = new System.Windows.Forms.Button();
            btnCancelTouch = new System.Windows.Forms.Button();
            btnSelectCurveBk = new System.Windows.Forms.Button();
            btnSelectCurve = new System.Windows.Forms.Button();
            btnAddTime = new System.Windows.Forms.Button();
            tlp1.SuspendLayout();
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
            oglSelf.Location = new System.Drawing.Point(2, 2);
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
            // lblCurveSelected
            // 
            lblCurveSelected.Anchor = System.Windows.Forms.AnchorStyles.None;
            lblCurveSelected.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblCurveSelected.ForeColor = System.Drawing.Color.Black;
            lblCurveSelected.Location = new System.Drawing.Point(11, 659);
            lblCurveSelected.Margin = new System.Windows.Forms.Padding(0);
            lblCurveSelected.Name = "lblCurveSelected";
            lblCurveSelected.Size = new System.Drawing.Size(152, 30);
            lblCurveSelected.TabIndex = 329;
            lblCurveSelected.Text = "1";
            lblCurveSelected.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tboxNameCurve
            // 
            tboxNameCurve.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tboxNameCurve.BackColor = System.Drawing.SystemColors.ControlLight;
            tboxNameCurve.CausesValidation = false;
            tlp1.SetColumnSpan(tboxNameCurve, 2);
            tboxNameCurve.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            tboxNameCurve.Location = new System.Drawing.Point(0, 603);
            tboxNameCurve.Margin = new System.Windows.Forms.Padding(0);
            tboxNameCurve.MaxLength = 100;
            tboxNameCurve.Name = "tboxNameCurve";
            tboxNameCurve.Size = new System.Drawing.Size(349, 36);
            tboxNameCurve.TabIndex = 10;
            tboxNameCurve.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            tboxNameCurve.Enter += tboxNameCurve_Enter;
            tboxNameCurve.Leave += tboxNameCurve_Leave;
            // 
            // tlp1
            // 
            tlp1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            tlp1.ColumnCount = 2;
            tlp1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlp1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlp1.Controls.Add(btnBLength, 0, 0);
            tlp1.Controls.Add(btnDrawSections, 1, 0);
            tlp1.Controls.Add(btnCancel, 0, 8);
            tlp1.Controls.Add(btnALength, 0, 1);
            tlp1.Controls.Add(btnExit, 1, 8);
            tlp1.Controls.Add(btnDeleteCurve, 1, 3);
            tlp1.Controls.Add(btnMakeCurve, 0, 4);
            tlp1.Controls.Add(btnMakeABLine, 1, 4);
            tlp1.Controls.Add(cboxIsZoom, 0, 3);
            tlp1.Controls.Add(cboxIsVisible, 0, 2);
            tlp1.Controls.Add(btnMakeBoundaryCurve, 1, 2);
            tlp1.Controls.Add(btnCancelTouch, 1, 1);
            tlp1.Controls.Add(btnSelectCurveBk, 0, 5);
            tlp1.Controls.Add(btnSelectCurve, 1, 5);
            tlp1.Controls.Add(lblCurveSelected, 0, 7);
            tlp1.Controls.Add(btnAddTime, 1, 7);
            tlp1.Controls.Add(tboxNameCurve, 0, 6);
            tlp1.Location = new System.Drawing.Point(820, 2);
            tlp1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tlp1.Name = "tlp1";
            tlp1.RowCount = 9;
            tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.14701F));
            tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.47011F));
            tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.7706F));
            tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.50888F));
            tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.34733F));
            tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.37803F));
            tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.37803F));
            tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            tlp1.Size = new System.Drawing.Size(349, 808);
            tlp1.TabIndex = 564;
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
            btnBLength.Location = new System.Drawing.Point(23, 14);
            btnBLength.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnBLength.Name = "btnBLength";
            btnBLength.Size = new System.Drawing.Size(128, 50);
            btnBLength.TabIndex = 351;
            btnBLength.UseVisualStyleBackColor = false;
            btnBLength.Click += btnBLength_Click;
            // 
            // btnDrawSections
            // 
            btnDrawSections.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnDrawSections.BackColor = System.Drawing.Color.Transparent;
            btnDrawSections.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            btnDrawSections.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            btnDrawSections.FlatAppearance.BorderSize = 0;
            btnDrawSections.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDrawSections.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnDrawSections.Image = Properties.Resources.MappingOff;
            btnDrawSections.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnDrawSections.Location = new System.Drawing.Point(219, 4);
            btnDrawSections.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnDrawSections.Name = "btnDrawSections";
            btnDrawSections.Size = new System.Drawing.Size(84, 70);
            btnDrawSections.TabIndex = 11;
            btnDrawSections.UseVisualStyleBackColor = false;
            btnDrawSections.Click += btnDrawSections_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnCancel.BackColor = System.Drawing.Color.Transparent;
            btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancel.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnCancel.Image = Properties.Resources.Cancel64;
            btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnCancel.Location = new System.Drawing.Point(35, 723);
            btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(103, 65);
            btnCancel.TabIndex = 469;
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
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
            btnALength.Location = new System.Drawing.Point(23, 93);
            btnALength.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnALength.Name = "btnALength";
            btnALength.Size = new System.Drawing.Size(128, 50);
            btnALength.TabIndex = 352;
            btnALength.UseVisualStyleBackColor = false;
            btnALength.Click += btnALength_Click;
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
            btnExit.Location = new System.Drawing.Point(210, 723);
            btnExit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(103, 65);
            btnExit.TabIndex = 0;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnDeleteCurve
            // 
            btnDeleteCurve.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnDeleteCurve.BackColor = System.Drawing.Color.Transparent;
            btnDeleteCurve.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnDeleteCurve.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            btnDeleteCurve.FlatAppearance.BorderSize = 0;
            btnDeleteCurve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDeleteCurve.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnDeleteCurve.Image = Properties.Resources.Trash;
            btnDeleteCurve.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnDeleteCurve.Location = new System.Drawing.Point(219, 306);
            btnDeleteCurve.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnDeleteCurve.Name = "btnDeleteCurve";
            btnDeleteCurve.Size = new System.Drawing.Size(84, 60);
            btnDeleteCurve.TabIndex = 6;
            btnDeleteCurve.UseVisualStyleBackColor = false;
            btnDeleteCurve.Click += btnDeleteCurve_Click;
            // 
            // btnMakeCurve
            // 
            btnMakeCurve.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnMakeCurve.BackColor = System.Drawing.Color.Transparent;
            btnMakeCurve.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnMakeCurve.Enabled = false;
            btnMakeCurve.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            btnMakeCurve.FlatAppearance.BorderSize = 0;
            btnMakeCurve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnMakeCurve.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnMakeCurve.Image = Properties.Resources.ABTrackCurve;
            btnMakeCurve.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnMakeCurve.Location = new System.Drawing.Point(34, 398);
            btnMakeCurve.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnMakeCurve.Name = "btnMakeCurve";
            btnMakeCurve.Size = new System.Drawing.Size(105, 92);
            btnMakeCurve.TabIndex = 2;
            btnMakeCurve.UseVisualStyleBackColor = false;
            btnMakeCurve.Click += BtnMakeCurve_Click;
            // 
            // btnMakeABLine
            // 
            btnMakeABLine.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnMakeABLine.BackColor = System.Drawing.Color.Transparent;
            btnMakeABLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnMakeABLine.Enabled = false;
            btnMakeABLine.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            btnMakeABLine.FlatAppearance.BorderSize = 0;
            btnMakeABLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnMakeABLine.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnMakeABLine.Image = Properties.Resources.ABTrackAB;
            btnMakeABLine.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnMakeABLine.Location = new System.Drawing.Point(209, 398);
            btnMakeABLine.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnMakeABLine.Name = "btnMakeABLine";
            btnMakeABLine.Size = new System.Drawing.Size(105, 92);
            btnMakeABLine.TabIndex = 3;
            btnMakeABLine.UseVisualStyleBackColor = false;
            btnMakeABLine.Click += BtnMakeABLine_Click;
            // 
            // cboxIsZoom
            // 
            cboxIsZoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            cboxIsZoom.Appearance = System.Windows.Forms.Appearance.Button;
            cboxIsZoom.BackColor = System.Drawing.Color.WhiteSmoke;
            cboxIsZoom.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            cboxIsZoom.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(180, 255, 160);
            cboxIsZoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboxIsZoom.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cboxIsZoom.ForeColor = System.Drawing.SystemColors.ButtonFace;
            cboxIsZoom.Image = Properties.Resources.ZoomOGL;
            cboxIsZoom.Location = new System.Drawing.Point(45, 297);
            cboxIsZoom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cboxIsZoom.Name = "cboxIsZoom";
            cboxIsZoom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            cboxIsZoom.Size = new System.Drawing.Size(84, 78);
            cboxIsZoom.TabIndex = 563;
            cboxIsZoom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            cboxIsZoom.UseVisualStyleBackColor = false;
            cboxIsZoom.CheckedChanged += cboxIsZoom_CheckedChanged;
            // 
            // cboxIsVisible
            // 
            cboxIsVisible.Anchor = System.Windows.Forms.AnchorStyles.None;
            cboxIsVisible.Appearance = System.Windows.Forms.Appearance.Button;
            cboxIsVisible.BackColor = System.Drawing.Color.FromArgb(255, 200, 200);
            cboxIsVisible.Checked = true;
            cboxIsVisible.CheckState = System.Windows.Forms.CheckState.Checked;
            cboxIsVisible.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            cboxIsVisible.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(220, 250, 220);
            cboxIsVisible.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboxIsVisible.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cboxIsVisible.ForeColor = System.Drawing.SystemColors.ButtonFace;
            cboxIsVisible.Image = Properties.Resources.TrackVisible;
            cboxIsVisible.Location = new System.Drawing.Point(45, 181);
            cboxIsVisible.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cboxIsVisible.Name = "cboxIsVisible";
            cboxIsVisible.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            cboxIsVisible.Size = new System.Drawing.Size(84, 78);
            cboxIsVisible.TabIndex = 468;
            cboxIsVisible.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            cboxIsVisible.UseVisualStyleBackColor = false;
            cboxIsVisible.Click += cboxIsVisible_Click;
            // 
            // btnMakeBoundaryCurve
            // 
            btnMakeBoundaryCurve.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnMakeBoundaryCurve.BackColor = System.Drawing.Color.Transparent;
            btnMakeBoundaryCurve.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnMakeBoundaryCurve.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            btnMakeBoundaryCurve.FlatAppearance.BorderSize = 0;
            btnMakeBoundaryCurve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnMakeBoundaryCurve.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnMakeBoundaryCurve.Image = Properties.Resources.BoundaryCurveLine;
            btnMakeBoundaryCurve.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnMakeBoundaryCurve.Location = new System.Drawing.Point(203, 181);
            btnMakeBoundaryCurve.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnMakeBoundaryCurve.Name = "btnMakeBoundaryCurve";
            btnMakeBoundaryCurve.Size = new System.Drawing.Size(117, 78);
            btnMakeBoundaryCurve.TabIndex = 4;
            btnMakeBoundaryCurve.UseVisualStyleBackColor = false;
            btnMakeBoundaryCurve.Click += btnMakeBoundaryCurve_Click;
            // 
            // btnCancelTouch
            // 
            btnCancelTouch.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnCancelTouch.BackColor = System.Drawing.Color.Transparent;
            btnCancelTouch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnCancelTouch.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            btnCancelTouch.FlatAppearance.BorderSize = 0;
            btnCancelTouch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancelTouch.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnCancelTouch.Image = Properties.Resources.HeadlandDeletePoints;
            btnCancelTouch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnCancelTouch.Location = new System.Drawing.Point(219, 81);
            btnCancelTouch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCancelTouch.Name = "btnCancelTouch";
            btnCancelTouch.Size = new System.Drawing.Size(84, 73);
            btnCancelTouch.TabIndex = 470;
            btnCancelTouch.UseVisualStyleBackColor = false;
            btnCancelTouch.Click += btnCancelTouch_Click;
            // 
            // btnSelectCurveBk
            // 
            btnSelectCurveBk.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnSelectCurveBk.BackColor = System.Drawing.Color.Transparent;
            btnSelectCurveBk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnSelectCurveBk.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            btnSelectCurveBk.FlatAppearance.BorderSize = 0;
            btnSelectCurveBk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSelectCurveBk.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnSelectCurveBk.Image = Properties.Resources.ABLineCycleBk;
            btnSelectCurveBk.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnSelectCurveBk.Location = new System.Drawing.Point(12, 509);
            btnSelectCurveBk.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSelectCurveBk.Name = "btnSelectCurveBk";
            btnSelectCurveBk.Size = new System.Drawing.Size(149, 78);
            btnSelectCurveBk.TabIndex = 472;
            btnSelectCurveBk.UseVisualStyleBackColor = false;
            btnSelectCurveBk.Click += btnSelectCurveBk_Click;
            // 
            // btnSelectCurve
            // 
            btnSelectCurve.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnSelectCurve.BackColor = System.Drawing.Color.Transparent;
            btnSelectCurve.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnSelectCurve.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            btnSelectCurve.FlatAppearance.BorderSize = 0;
            btnSelectCurve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSelectCurve.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnSelectCurve.Image = Properties.Resources.ABLineCycle;
            btnSelectCurve.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnSelectCurve.Location = new System.Drawing.Point(187, 509);
            btnSelectCurve.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSelectCurve.Name = "btnSelectCurve";
            btnSelectCurve.Size = new System.Drawing.Size(149, 78);
            btnSelectCurve.TabIndex = 5;
            btnSelectCurve.UseVisualStyleBackColor = false;
            btnSelectCurve.Click += btnSelectCurve_Click;
            // 
            // btnAddTime
            // 
            btnAddTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnAddTime.BackColor = System.Drawing.Color.Transparent;
            btnAddTime.BackgroundImage = Properties.Resources.JobNameTime;
            btnAddTime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnAddTime.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            btnAddTime.FlatAppearance.BorderSize = 0;
            btnAddTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAddTime.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnAddTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnAddTime.Location = new System.Drawing.Point(178, 650);
            btnAddTime.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnAddTime.Name = "btnAddTime";
            btnAddTime.Size = new System.Drawing.Size(167, 48);
            btnAddTime.TabIndex = 356;
            btnAddTime.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnAddTime.UseVisualStyleBackColor = false;
            btnAddTime.Click += btnAddTime_Click;
            // 
            // FormABDraw
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.WhiteSmoke;
            ClientSize = new System.Drawing.Size(1174, 838);
            ControlBox = false;
            Controls.Add(tlp1);
            Controls.Add(oglSelf);
            ForeColor = System.Drawing.Color.Black;
            HelpButton = true;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size(1190, 850);
            Name = "FormABDraw";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Draw AB - Click 2 points on the Boundary to Begin";
            FormClosing += FormABDraw_FormClosing;
            Load += FormABDraw_Load;
            ResizeEnd += FormABDraw_ResizeEnd;
            tlp1.ResumeLayout(false);
            tlp1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private OpenTK.GLControl.GLControl oglSelf;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMakeABLine;
        private System.Windows.Forms.Button btnMakeCurve;
        private System.Windows.Forms.Button btnSelectCurve;
        private System.Windows.Forms.Button btnDeleteCurve;
        private System.Windows.Forms.Label lblCurveSelected;
        private System.Windows.Forms.Button btnDrawSections;
        private System.Windows.Forms.Button btnMakeBoundaryCurve;
        private System.Windows.Forms.TextBox tboxNameCurve;
        private System.Windows.Forms.Button btnBLength;
        private System.Windows.Forms.Button btnALength;
        private System.Windows.Forms.Button btnAddTime;
        private System.Windows.Forms.CheckBox cboxIsVisible;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCancelTouch;
        private System.Windows.Forms.Button btnSelectCurveBk;
        private System.Windows.Forms.CheckBox cboxIsZoom;
        private System.Windows.Forms.TableLayoutPanel tlp1;
    }
}
namespace AgOpenGPS
{
    partial class FormTramLine
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
            tlp1 = new System.Windows.Forms.TableLayoutPanel();
            btnDnAlpha = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            btnSave = new System.Windows.Forms.Button();
            labelAlpha = new System.Windows.Forms.Label();
            cboxIsOuter = new System.Windows.Forms.CheckBox();
            btnDeleteAllTrams = new System.Windows.Forms.Button();
            btnCancelTouch = new System.Windows.Forms.Button();
            btnSwapAB = new System.Windows.Forms.Button();
            lblNumPasses = new System.Windows.Forms.Label();
            btnSelectCurveBk = new System.Windows.Forms.Button();
            btnSelectCurve = new System.Windows.Forms.Button();
            btnAddLines = new System.Windows.Forms.Button();
            lblAplha = new System.Windows.Forms.Label();
            btnUpAlpha = new System.Windows.Forms.Button();
            btnDnTrams = new System.Windows.Forms.Button();
            btnDnStartTram = new System.Windows.Forms.Button();
            btnUpStartTram = new System.Windows.Forms.Button();
            btnUpTrams = new System.Windows.Forms.Button();
            btnResize = new System.Windows.Forms.Button();
            lblStartPass = new System.Windows.Forms.Label();
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
            oglSelf.Location = new System.Drawing.Point(1, 0);
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
            lblCurveSelected.Location = new System.Drawing.Point(127, 330);
            lblCurveSelected.Margin = new System.Windows.Forms.Padding(0);
            lblCurveSelected.Name = "lblCurveSelected";
            lblCurveSelected.Size = new System.Drawing.Size(91, 30);
            lblCurveSelected.TabIndex = 329;
            lblCurveSelected.Text = "1";
            lblCurveSelected.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlp1
            // 
            tlp1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            tlp1.BackColor = System.Drawing.Color.Transparent;
            tlp1.ColumnCount = 3;
            tlp1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            tlp1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.66667F));
            tlp1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            tlp1.Controls.Add(btnDnAlpha, 0, 0);
            tlp1.Controls.Add(btnCancel, 0, 8);
            tlp1.Controls.Add(btnSave, 2, 8);
            tlp1.Controls.Add(labelAlpha, 1, 0);
            tlp1.Controls.Add(cboxIsOuter, 2, 3);
            tlp1.Controls.Add(btnDeleteAllTrams, 1, 2);
            tlp1.Controls.Add(btnCancelTouch, 0, 3);
            tlp1.Controls.Add(btnSwapAB, 0, 2);
            tlp1.Controls.Add(lblNumPasses, 1, 6);
            tlp1.Controls.Add(btnSelectCurveBk, 0, 4);
            tlp1.Controls.Add(lblCurveSelected, 1, 4);
            tlp1.Controls.Add(btnSelectCurve, 2, 4);
            tlp1.Controls.Add(btnAddLines, 1, 7);
            tlp1.Controls.Add(lblAplha, 1, 1);
            tlp1.Controls.Add(btnUpAlpha, 2, 0);
            tlp1.Controls.Add(btnDnTrams, 0, 6);
            tlp1.Controls.Add(btnDnStartTram, 0, 5);
            tlp1.Controls.Add(btnUpStartTram, 2, 5);
            tlp1.Controls.Add(btnUpTrams, 2, 6);
            tlp1.Controls.Add(btnResize, 2, 2);
            tlp1.Controls.Add(lblStartPass, 1, 5);
            tlp1.Location = new System.Drawing.Point(820, 0);
            tlp1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tlp1.Name = "tlp1";
            tlp1.RowCount = 9;
            tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.10334F));
            tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.30843F));
            tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.83148F));
            tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.62639F));
            tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.85215F));
            tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.7186F));
            tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.55962F));
            tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            tlp1.Size = new System.Drawing.Size(350, 809);
            tlp1.TabIndex = 564;
            // 
            // btnDnAlpha
            // 
            btnDnAlpha.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnDnAlpha.BackColor = System.Drawing.Color.Transparent;
            btnDnAlpha.FlatAppearance.BorderSize = 0;
            btnDnAlpha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDnAlpha.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnDnAlpha.ForeColor = System.Drawing.Color.White;
            btnDnAlpha.Image = Properties.Resources.IncrementMinus;
            btnDnAlpha.Location = new System.Drawing.Point(16, 5);
            btnDnAlpha.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnDnAlpha.Name = "btnDnAlpha";
            tlp1.SetRowSpan(btnDnAlpha, 2);
            btnDnAlpha.Size = new System.Drawing.Size(84, 72);
            btnDnAlpha.TabIndex = 584;
            btnDnAlpha.UseVisualStyleBackColor = false;
            btnDnAlpha.Click += btnDnAlpha_Click;
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
            btnCancel.Image = Properties.Resources.SwitchOff;
            btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnCancel.Location = new System.Drawing.Point(6, 721);
            btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(103, 81);
            btnCancel.TabIndex = 469;
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnSave.BackColor = System.Drawing.Color.Transparent;
            btnSave.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSave.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnSave.ForeColor = System.Drawing.Color.FromArgb(192, 64, 0);
            btnSave.Image = Properties.Resources.FileSave;
            btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnSave.Location = new System.Drawing.Point(238, 721);
            btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(103, 81);
            btnSave.TabIndex = 0;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnExit_Click;
            // 
            // labelAlpha
            // 
            labelAlpha.Anchor = System.Windows.Forms.AnchorStyles.None;
            labelAlpha.AutoSize = true;
            labelAlpha.BackColor = System.Drawing.Color.WhiteSmoke;
            labelAlpha.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelAlpha.ForeColor = System.Drawing.Color.Black;
            labelAlpha.Location = new System.Drawing.Point(144, 4);
            labelAlpha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelAlpha.Name = "labelAlpha";
            labelAlpha.Size = new System.Drawing.Size(57, 23);
            labelAlpha.TabIndex = 571;
            labelAlpha.Text = "Alpha";
            labelAlpha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboxIsOuter
            // 
            cboxIsOuter.Anchor = System.Windows.Forms.AnchorStyles.None;
            cboxIsOuter.Appearance = System.Windows.Forms.Appearance.Button;
            cboxIsOuter.BackColor = System.Drawing.Color.Transparent;
            cboxIsOuter.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            cboxIsOuter.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(220, 250, 220);
            cboxIsOuter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboxIsOuter.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cboxIsOuter.ForeColor = System.Drawing.SystemColors.ButtonFace;
            cboxIsOuter.Image = Properties.Resources.TramOuter;
            cboxIsOuter.Location = new System.Drawing.Point(239, 204);
            cboxIsOuter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cboxIsOuter.Name = "cboxIsOuter";
            cboxIsOuter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            cboxIsOuter.Size = new System.Drawing.Size(102, 78);
            cboxIsOuter.TabIndex = 579;
            cboxIsOuter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            cboxIsOuter.UseVisualStyleBackColor = false;
            cboxIsOuter.Click += cboxIsOuter_Click;
            // 
            // btnDeleteAllTrams
            // 
            btnDeleteAllTrams.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnDeleteAllTrams.BackColor = System.Drawing.Color.Transparent;
            btnDeleteAllTrams.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnDeleteAllTrams.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            btnDeleteAllTrams.FlatAppearance.BorderSize = 0;
            btnDeleteAllTrams.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDeleteAllTrams.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnDeleteAllTrams.Image = Properties.Resources.Trash;
            btnDeleteAllTrams.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnDeleteAllTrams.Location = new System.Drawing.Point(130, 107);
            btnDeleteAllTrams.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnDeleteAllTrams.Name = "btnDeleteAllTrams";
            btnDeleteAllTrams.Size = new System.Drawing.Size(85, 60);
            btnDeleteAllTrams.TabIndex = 6;
            btnDeleteAllTrams.UseVisualStyleBackColor = false;
            btnDeleteAllTrams.Click += btnDeleteAllTrams_Click;
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
            btnCancelTouch.Location = new System.Drawing.Point(16, 210);
            btnCancelTouch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCancelTouch.Name = "btnCancelTouch";
            btnCancelTouch.Size = new System.Drawing.Size(84, 67);
            btnCancelTouch.TabIndex = 575;
            btnCancelTouch.UseVisualStyleBackColor = false;
            btnCancelTouch.Click += btnCancelTouch_Click;
            // 
            // btnSwapAB
            // 
            btnSwapAB.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnSwapAB.BackColor = System.Drawing.Color.Transparent;
            btnSwapAB.FlatAppearance.BorderSize = 0;
            btnSwapAB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSwapAB.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnSwapAB.ForeColor = System.Drawing.Color.White;
            btnSwapAB.Image = Properties.Resources.ABSwapPoints;
            btnSwapAB.Location = new System.Drawing.Point(16, 101);
            btnSwapAB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSwapAB.Name = "btnSwapAB";
            btnSwapAB.Size = new System.Drawing.Size(84, 72);
            btnSwapAB.TabIndex = 568;
            btnSwapAB.UseVisualStyleBackColor = false;
            btnSwapAB.Click += btnSwapAB_Click;
            // 
            // lblNumPasses
            // 
            lblNumPasses.Anchor = System.Windows.Forms.AnchorStyles.None;
            lblNumPasses.AutoSize = true;
            lblNumPasses.BackColor = System.Drawing.Color.WhiteSmoke;
            lblNumPasses.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblNumPasses.ForeColor = System.Drawing.Color.DarkOliveGreen;
            lblNumPasses.Location = new System.Drawing.Point(129, 533);
            lblNumPasses.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblNumPasses.Name = "lblNumPasses";
            lblNumPasses.Size = new System.Drawing.Size(87, 58);
            lblNumPasses.TabIndex = 581;
            lblNumPasses.Text = "12";
            lblNumPasses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            btnSelectCurveBk.Location = new System.Drawing.Point(4, 307);
            btnSelectCurveBk.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSelectCurveBk.Name = "btnSelectCurveBk";
            btnSelectCurveBk.Size = new System.Drawing.Size(108, 75);
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
            btnSelectCurve.Location = new System.Drawing.Point(234, 307);
            btnSelectCurve.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSelectCurve.Name = "btnSelectCurve";
            btnSelectCurve.Size = new System.Drawing.Size(112, 75);
            btnSelectCurve.TabIndex = 5;
            btnSelectCurve.UseVisualStyleBackColor = false;
            btnSelectCurve.Click += btnSelectCurve_Click;
            // 
            // btnAddLines
            // 
            btnAddLines.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnAddLines.BackColor = System.Drawing.Color.Transparent;
            btnAddLines.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnAddLines.FlatAppearance.BorderSize = 0;
            btnAddLines.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAddLines.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnAddLines.ForeColor = System.Drawing.Color.White;
            btnAddLines.Image = Properties.Resources.AddNew;
            btnAddLines.Location = new System.Drawing.Point(132, 635);
            btnAddLines.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnAddLines.Name = "btnAddLines";
            btnAddLines.Size = new System.Drawing.Size(82, 68);
            btnAddLines.TabIndex = 574;
            btnAddLines.UseVisualStyleBackColor = false;
            btnAddLines.Click += btnAddLines_Click;
            // 
            // lblAplha
            // 
            lblAplha.Anchor = System.Windows.Forms.AnchorStyles.None;
            lblAplha.AutoSize = true;
            lblAplha.BackColor = System.Drawing.Color.WhiteSmoke;
            lblAplha.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblAplha.ForeColor = System.Drawing.Color.Black;
            lblAplha.Location = new System.Drawing.Point(138, 45);
            lblAplha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblAplha.Name = "lblAplha";
            lblAplha.Size = new System.Drawing.Size(69, 23);
            lblAplha.TabIndex = 570;
            lblAplha.Text = "100%";
            lblAplha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnUpAlpha
            // 
            btnUpAlpha.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnUpAlpha.BackColor = System.Drawing.Color.Transparent;
            btnUpAlpha.FlatAppearance.BorderSize = 0;
            btnUpAlpha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnUpAlpha.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnUpAlpha.ForeColor = System.Drawing.Color.White;
            btnUpAlpha.Image = Properties.Resources.IncrementPlus;
            btnUpAlpha.Location = new System.Drawing.Point(248, 5);
            btnUpAlpha.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnUpAlpha.Name = "btnUpAlpha";
            tlp1.SetRowSpan(btnUpAlpha, 2);
            btnUpAlpha.Size = new System.Drawing.Size(84, 72);
            btnUpAlpha.TabIndex = 583;
            btnUpAlpha.UseVisualStyleBackColor = false;
            btnUpAlpha.Click += btnUpAlpha_Click;
            // 
            // btnDnTrams
            // 
            btnDnTrams.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnDnTrams.BackColor = System.Drawing.Color.Transparent;
            btnDnTrams.FlatAppearance.BorderSize = 0;
            btnDnTrams.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDnTrams.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnDnTrams.ForeColor = System.Drawing.Color.White;
            btnDnTrams.Image = Properties.Resources.IncrementMinus;
            btnDnTrams.Location = new System.Drawing.Point(16, 526);
            btnDnTrams.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnDnTrams.Name = "btnDnTrams";
            btnDnTrams.Size = new System.Drawing.Size(84, 72);
            btnDnTrams.TabIndex = 565;
            btnDnTrams.UseVisualStyleBackColor = false;
            btnDnTrams.Click += btnDnTrams_Click;
            // 
            // btnDnStartTram
            // 
            btnDnStartTram.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnDnStartTram.BackColor = System.Drawing.Color.Transparent;
            btnDnStartTram.FlatAppearance.BorderSize = 0;
            btnDnStartTram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDnStartTram.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnDnStartTram.ForeColor = System.Drawing.Color.White;
            btnDnStartTram.Image = Properties.Resources.IncrementMinus;
            btnDnStartTram.Location = new System.Drawing.Point(16, 412);
            btnDnStartTram.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnDnStartTram.Name = "btnDnStartTram";
            btnDnStartTram.Size = new System.Drawing.Size(84, 72);
            btnDnStartTram.TabIndex = 576;
            btnDnStartTram.UseVisualStyleBackColor = false;
            btnDnStartTram.Click += btnDnStartTram_Click;
            // 
            // btnUpStartTram
            // 
            btnUpStartTram.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnUpStartTram.BackColor = System.Drawing.Color.Transparent;
            btnUpStartTram.FlatAppearance.BorderSize = 0;
            btnUpStartTram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnUpStartTram.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnUpStartTram.ForeColor = System.Drawing.Color.White;
            btnUpStartTram.Image = Properties.Resources.IncrementPlus;
            btnUpStartTram.Location = new System.Drawing.Point(248, 412);
            btnUpStartTram.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnUpStartTram.Name = "btnUpStartTram";
            btnUpStartTram.Size = new System.Drawing.Size(84, 72);
            btnUpStartTram.TabIndex = 577;
            btnUpStartTram.UseVisualStyleBackColor = false;
            btnUpStartTram.Click += btnUpStartTram_Click;
            // 
            // btnUpTrams
            // 
            btnUpTrams.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnUpTrams.BackColor = System.Drawing.Color.Transparent;
            btnUpTrams.FlatAppearance.BorderSize = 0;
            btnUpTrams.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnUpTrams.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnUpTrams.ForeColor = System.Drawing.Color.White;
            btnUpTrams.Image = Properties.Resources.IncrementPlus;
            btnUpTrams.Location = new System.Drawing.Point(248, 526);
            btnUpTrams.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnUpTrams.Name = "btnUpTrams";
            btnUpTrams.Size = new System.Drawing.Size(84, 72);
            btnUpTrams.TabIndex = 566;
            btnUpTrams.UseVisualStyleBackColor = false;
            btnUpTrams.Click += btnUpTrams_Click;
            // 
            // btnResize
            // 
            btnResize.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnResize.BackColor = System.Drawing.Color.Transparent;
            btnResize.FlatAppearance.BorderSize = 0;
            btnResize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnResize.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnResize.ForeColor = System.Drawing.Color.White;
            btnResize.Image = Properties.Resources.ConD_FullScreenBegin;
            btnResize.Location = new System.Drawing.Point(248, 101);
            btnResize.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnResize.Name = "btnResize";
            btnResize.Size = new System.Drawing.Size(84, 72);
            btnResize.TabIndex = 582;
            btnResize.UseVisualStyleBackColor = false;
            btnResize.Click += btnResize_Click;
            // 
            // lblStartPass
            // 
            lblStartPass.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblStartPass.BackColor = System.Drawing.Color.WhiteSmoke;
            lblStartPass.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblStartPass.ForeColor = System.Drawing.Color.Black;
            lblStartPass.Location = new System.Drawing.Point(120, 395);
            lblStartPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblStartPass.Name = "lblStartPass";
            lblStartPass.Size = new System.Drawing.Size(106, 106);
            lblStartPass.TabIndex = 580;
            lblStartPass.Text = "Start\r\n 12";
            lblStartPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormTramLine
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.WhiteSmoke;
            ClientSize = new System.Drawing.Size(1171, 809);
            ControlBox = false;
            Controls.Add(tlp1);
            Controls.Add(oglSelf);
            ForeColor = System.Drawing.Color.Black;
            HelpButton = true;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormTramLine";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Draw AB - Click 2 points on the Boundary to Begin";
            FormClosing += FormTramLine_FormClosing;
            Load += FormTramLine_Load;
            ResizeEnd += FormTramLine_ResizeEnd;
            tlp1.ResumeLayout(false);
            tlp1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private OpenTK.GLControl.GLControl oglSelf;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSelectCurve;
        private System.Windows.Forms.Button btnDeleteAllTrams;
        private System.Windows.Forms.Label lblCurveSelected;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSelectCurveBk;
        private System.Windows.Forms.TableLayoutPanel tlp1;
        private System.Windows.Forms.Button btnDnTrams;
        private System.Windows.Forms.Button btnUpTrams;
        private System.Windows.Forms.Button btnSwapAB;
        private System.Windows.Forms.Label lblAplha;
        private System.Windows.Forms.Label labelAlpha;
        private System.Windows.Forms.Button btnAddLines;
        private System.Windows.Forms.Button btnCancelTouch;
        private System.Windows.Forms.Button btnUpStartTram;
        private System.Windows.Forms.Button btnDnStartTram;
        private System.Windows.Forms.CheckBox cboxIsOuter;
        private System.Windows.Forms.Label lblStartPass;
        private System.Windows.Forms.Label lblNumPasses;
        private System.Windows.Forms.Button btnResize;
        private System.Windows.Forms.Button btnDnAlpha;
        private System.Windows.Forms.Button btnUpAlpha;
    }
}
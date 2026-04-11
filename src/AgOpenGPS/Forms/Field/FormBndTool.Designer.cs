namespace AgOpenGPS
{
    partial class FormBndTool
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
            cboxPointDistance = new System.Windows.Forms.ComboBox();
            cboxSmooth = new System.Windows.Forms.ComboBox();
            labelSpacing = new System.Windows.Forms.Label();
            labelSmooth = new System.Windows.Forms.Label();
            cboxIsZoom = new System.Windows.Forms.CheckBox();
            btnCenterOGL = new System.Windows.Forms.Button();
            btnSlice = new System.Windows.Forms.Button();
            btnAddBoundary = new System.Windows.Forms.Button();
            btnStartStop = new System.Windows.Forms.Button();
            btnCancelTouch = new System.Windows.Forms.Button();
            btnExit = new System.Windows.Forms.Button();
            btnZoomOut = new System.Windows.Forms.Button();
            btnZoomIn = new System.Windows.Forms.Button();
            tlp1 = new System.Windows.Forms.TableLayoutPanel();
            label3 = new System.Windows.Forms.Label();
            labelReset = new System.Windows.Forms.Label();
            btnMoveUp = new System.Windows.Forms.Button();
            btnMoveLeft = new System.Windows.Forms.Button();
            btnMoveRight = new System.Windows.Forms.Button();
            btnMoveDn = new System.Windows.Forms.Button();
            labelCreate = new System.Windows.Forms.Label();
            btnAddPoints = new System.Windows.Forms.Button();
            btnResetReduce = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            labelPleaseWait = new System.Windows.Forms.Label();
            lblPointToProcess = new System.Windows.Forms.Label();
            labelPointsToProcess = new System.Windows.Forms.Label();
            lblI = new System.Windows.Forms.Label();
            labelPoints = new System.Windows.Forms.Label();
            tlp1.SuspendLayout();
            panel1.SuspendLayout();
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
            oglSelf.Location = new System.Drawing.Point(0, 0);
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
            // cboxPointDistance
            // 
            cboxPointDistance.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            cboxPointDistance.BackColor = System.Drawing.Color.Lavender;
            tlp1.SetColumnSpan(cboxPointDistance, 3);
            cboxPointDistance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboxPointDistance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboxPointDistance.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cboxPointDistance.FormattingEnabled = true;
            cboxPointDistance.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "?" });
            cboxPointDistance.Location = new System.Drawing.Point(31, 27);
            cboxPointDistance.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            cboxPointDistance.Name = "cboxPointDistance";
            cboxPointDistance.Size = new System.Drawing.Size(117, 53);
            cboxPointDistance.TabIndex = 541;
            cboxPointDistance.SelectedIndexChanged += cboxPointDistance_SelectedIndexChanged;
            // 
            // cboxSmooth
            // 
            cboxSmooth.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            cboxSmooth.BackColor = System.Drawing.Color.Lavender;
            tlp1.SetColumnSpan(cboxSmooth, 3);
            cboxSmooth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboxSmooth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboxSmooth.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cboxSmooth.FormattingEnabled = true;
            cboxSmooth.Items.AddRange(new object[] { "0", "4", "8", "16", "32", "64", "?" });
            cboxSmooth.Location = new System.Drawing.Point(205, 27);
            cboxSmooth.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            cboxSmooth.Name = "cboxSmooth";
            cboxSmooth.Size = new System.Drawing.Size(117, 53);
            cboxSmooth.TabIndex = 547;
            cboxSmooth.SelectedIndexChanged += cboxSmooth_SelectedIndexChanged;
            // 
            // labelSpacing
            // 
            labelSpacing.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            tlp1.SetColumnSpan(labelSpacing, 3);
            labelSpacing.Enabled = false;
            labelSpacing.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelSpacing.ForeColor = System.Drawing.Color.Black;
            labelSpacing.Location = new System.Drawing.Point(13, 92);
            labelSpacing.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelSpacing.Name = "labelSpacing";
            labelSpacing.Size = new System.Drawing.Size(152, 29);
            labelSpacing.TabIndex = 562;
            labelSpacing.Text = "Spacing (m)";
            labelSpacing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSmooth
            // 
            labelSmooth.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            labelSmooth.AutoSize = true;
            tlp1.SetColumnSpan(labelSmooth, 3);
            labelSmooth.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelSmooth.ForeColor = System.Drawing.Color.Black;
            labelSmooth.Location = new System.Drawing.Point(228, 102);
            labelSmooth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelSmooth.Name = "labelSmooth";
            labelSmooth.Size = new System.Drawing.Size(71, 19);
            labelSmooth.TabIndex = 569;
            labelSmooth.Text = "Smooth";
            labelSmooth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboxIsZoom
            // 
            cboxIsZoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            cboxIsZoom.Appearance = System.Windows.Forms.Appearance.Button;
            cboxIsZoom.BackColor = System.Drawing.Color.WhiteSmoke;
            tlp1.SetColumnSpan(cboxIsZoom, 3);
            cboxIsZoom.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            cboxIsZoom.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(180, 255, 160);
            cboxIsZoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboxIsZoom.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cboxIsZoom.ForeColor = System.Drawing.SystemColors.ButtonFace;
            cboxIsZoom.Image = Properties.Resources.ZoomOGL;
            cboxIsZoom.Location = new System.Drawing.Point(219, 526);
            cboxIsZoom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cboxIsZoom.Name = "cboxIsZoom";
            cboxIsZoom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            cboxIsZoom.Size = new System.Drawing.Size(89, 82);
            cboxIsZoom.TabIndex = 561;
            cboxIsZoom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            cboxIsZoom.UseVisualStyleBackColor = false;
            // 
            // btnCenterOGL
            // 
            btnCenterOGL.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnCenterOGL.BackColor = System.Drawing.Color.White;
            btnCenterOGL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            tlp1.SetColumnSpan(btnCenterOGL, 3);
            btnCenterOGL.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            btnCenterOGL.FlatAppearance.BorderSize = 0;
            btnCenterOGL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCenterOGL.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnCenterOGL.Image = Properties.Resources.ConS_SourceFix;
            btnCenterOGL.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnCenterOGL.Location = new System.Drawing.Point(45, 526);
            btnCenterOGL.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCenterOGL.Name = "btnCenterOGL";
            btnCenterOGL.Size = new System.Drawing.Size(89, 82);
            btnCenterOGL.TabIndex = 560;
            btnCenterOGL.UseVisualStyleBackColor = false;
            btnCenterOGL.Click += btnCenterOGL_Click;
            // 
            // btnSlice
            // 
            btnSlice.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnSlice.BackColor = System.Drawing.Color.WhiteSmoke;
            btnSlice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            tlp1.SetColumnSpan(btnSlice, 3);
            btnSlice.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            btnSlice.FlatAppearance.BorderSize = 0;
            btnSlice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSlice.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnSlice.Image = Properties.Resources.BoundaryMakeLine;
            btnSlice.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnSlice.Location = new System.Drawing.Point(219, 405);
            btnSlice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSlice.Name = "btnSlice";
            btnSlice.Size = new System.Drawing.Size(89, 82);
            btnSlice.TabIndex = 548;
            btnSlice.UseVisualStyleBackColor = false;
            btnSlice.Click += btnSlice_Click;
            // 
            // btnAddBoundary
            // 
            btnAddBoundary.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            btnAddBoundary.BackColor = System.Drawing.Color.WhiteSmoke;
            btnAddBoundary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            tlp1.SetColumnSpan(btnAddBoundary, 3);
            btnAddBoundary.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            btnAddBoundary.FlatAppearance.BorderSize = 0;
            btnAddBoundary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAddBoundary.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnAddBoundary.Image = Properties.Resources.BoundaryOuter;
            btnAddBoundary.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnAddBoundary.Location = new System.Drawing.Point(200, 271);
            btnAddBoundary.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnAddBoundary.Name = "btnAddBoundary";
            btnAddBoundary.Size = new System.Drawing.Size(128, 78);
            btnAddBoundary.TabIndex = 545;
            btnAddBoundary.UseVisualStyleBackColor = false;
            btnAddBoundary.Click += btnAddBoundary_Click;
            // 
            // btnStartStop
            // 
            btnStartStop.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            btnStartStop.BackColor = System.Drawing.Color.WhiteSmoke;
            btnStartStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            tlp1.SetColumnSpan(btnStartStop, 3);
            btnStartStop.Enabled = false;
            btnStartStop.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            btnStartStop.FlatAppearance.BorderSize = 0;
            btnStartStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnStartStop.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnStartStop.Image = Properties.Resources.BoundaryReduce;
            btnStartStop.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnStartStop.Location = new System.Drawing.Point(22, 279);
            btnStartStop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnStartStop.Name = "btnStartStop";
            btnStartStop.Size = new System.Drawing.Size(134, 70);
            btnStartStop.TabIndex = 544;
            btnStartStop.UseVisualStyleBackColor = false;
            btnStartStop.Click += btnStartStop_Click;
            // 
            // btnCancelTouch
            // 
            btnCancelTouch.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnCancelTouch.BackColor = System.Drawing.Color.WhiteSmoke;
            btnCancelTouch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            tlp1.SetColumnSpan(btnCancelTouch, 3);
            btnCancelTouch.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            btnCancelTouch.FlatAppearance.BorderSize = 0;
            btnCancelTouch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancelTouch.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnCancelTouch.Image = Properties.Resources.HeadlandDeletePoints;
            btnCancelTouch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnCancelTouch.Location = new System.Drawing.Point(45, 405);
            btnCancelTouch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCancelTouch.Name = "btnCancelTouch";
            btnCancelTouch.Size = new System.Drawing.Size(89, 82);
            btnCancelTouch.TabIndex = 470;
            btnCancelTouch.UseVisualStyleBackColor = false;
            btnCancelTouch.Click += btnCancelTouch_Click;
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
            btnExit.Location = new System.Drawing.Point(267, 720);
            btnExit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(74, 81);
            btnExit.TabIndex = 0;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnZoomOut
            // 
            btnZoomOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnZoomOut.BackColor = System.Drawing.Color.White;
            btnZoomOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            tlp1.SetColumnSpan(btnZoomOut, 2);
            btnZoomOut.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            btnZoomOut.FlatAppearance.BorderSize = 0;
            btnZoomOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnZoomOut.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnZoomOut.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnZoomOut.Location = new System.Drawing.Point(17, 726);
            btnZoomOut.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnZoomOut.Name = "btnZoomOut";
            btnZoomOut.Size = new System.Drawing.Size(64, 69);
            btnZoomOut.TabIndex = 570;
            btnZoomOut.Text = "-";
            btnZoomOut.UseVisualStyleBackColor = false;
            btnZoomOut.Click += btnZoomOut_Click;
            // 
            // btnZoomIn
            // 
            btnZoomIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnZoomIn.BackColor = System.Drawing.Color.White;
            btnZoomIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            tlp1.SetColumnSpan(btnZoomIn, 2);
            btnZoomIn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            btnZoomIn.FlatAppearance.BorderSize = 0;
            btnZoomIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnZoomIn.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnZoomIn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnZoomIn.Location = new System.Drawing.Point(147, 726);
            btnZoomIn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnZoomIn.Name = "btnZoomIn";
            btnZoomIn.Size = new System.Drawing.Size(64, 69);
            btnZoomIn.TabIndex = 571;
            btnZoomIn.Text = "+";
            btnZoomIn.UseVisualStyleBackColor = false;
            btnZoomIn.Click += btnZoomIn_Click;
            // 
            // tlp1
            // 
            tlp1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
            tlp1.BackColor = System.Drawing.Color.WhiteSmoke;
            tlp1.ColumnCount = 6;
            tlp1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.83893F));
            tlp1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.684564F));
            tlp1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.15436F));
            tlp1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.15436F));
            tlp1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.684564F));
            tlp1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.48323F));
            tlp1.Controls.Add(label3, 0, 5);
            tlp1.Controls.Add(labelReset, 0, 3);
            tlp1.Controls.Add(btnMoveUp, 2, 8);
            tlp1.Controls.Add(btnMoveLeft, 3, 8);
            tlp1.Controls.Add(btnMoveRight, 5, 8);
            tlp1.Controls.Add(cboxIsZoom, 3, 7);
            tlp1.Controls.Add(btnMoveDn, 0, 8);
            tlp1.Controls.Add(btnStartStop, 0, 4);
            tlp1.Controls.Add(cboxPointDistance, 0, 0);
            tlp1.Controls.Add(cboxSmooth, 3, 0);
            tlp1.Controls.Add(btnSlice, 3, 6);
            tlp1.Controls.Add(btnCenterOGL, 0, 7);
            tlp1.Controls.Add(labelSpacing, 0, 1);
            tlp1.Controls.Add(btnAddBoundary, 3, 4);
            tlp1.Controls.Add(labelCreate, 3, 3);
            tlp1.Controls.Add(btnZoomOut, 0, 9);
            tlp1.Controls.Add(btnZoomIn, 2, 9);
            tlp1.Controls.Add(btnExit, 4, 9);
            tlp1.Controls.Add(btnAddPoints, 3, 2);
            tlp1.Controls.Add(btnResetReduce, 0, 2);
            tlp1.Controls.Add(labelSmooth, 3, 1);
            tlp1.Controls.Add(label2, 3, 5);
            tlp1.Controls.Add(btnCancelTouch, 0, 6);
            tlp1.Location = new System.Drawing.Point(818, 0);
            tlp1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tlp1.Name = "tlp1";
            tlp1.RowCount = 10;
            tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.00456F));
            tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.506683F));
            tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.71025F));
            tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.003683F));
            tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.8699F));
            tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.21404F));
            tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.8345F));
            tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.8564F));
            tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            tlp1.Size = new System.Drawing.Size(349, 808);
            tlp1.TabIndex = 572;
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            label3.AutoSize = true;
            tlp1.SetColumnSpan(label3, 3);
            label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.ForeColor = System.Drawing.Color.Black;
            label3.Location = new System.Drawing.Point(64, 357);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(50, 19);
            label3.TabIndex = 581;
            label3.Text = "Build";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelReset
            // 
            labelReset.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            labelReset.AutoSize = true;
            tlp1.SetColumnSpan(labelReset, 3);
            labelReset.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelReset.ForeColor = System.Drawing.Color.Black;
            labelReset.Location = new System.Drawing.Point(61, 237);
            labelReset.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelReset.Name = "labelReset";
            labelReset.Size = new System.Drawing.Size(56, 19);
            labelReset.TabIndex = 579;
            labelReset.Text = "Reset";
            labelReset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMoveUp
            // 
            btnMoveUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnMoveUp.BackColor = System.Drawing.Color.White;
            btnMoveUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            btnMoveUp.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            btnMoveUp.FlatAppearance.BorderSize = 0;
            btnMoveUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnMoveUp.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnMoveUp.Image = Properties.Resources.UpArrow64;
            btnMoveUp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnMoveUp.Location = new System.Drawing.Point(107, 631);
            btnMoveUp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnMoveUp.Name = "btnMoveUp";
            btnMoveUp.Size = new System.Drawing.Size(64, 69);
            btnMoveUp.TabIndex = 575;
            btnMoveUp.UseVisualStyleBackColor = false;
            btnMoveUp.Click += btnMoveUp_Click;
            // 
            // btnMoveLeft
            // 
            btnMoveLeft.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnMoveLeft.BackColor = System.Drawing.Color.White;
            btnMoveLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            btnMoveLeft.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            btnMoveLeft.FlatAppearance.BorderSize = 0;
            btnMoveLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnMoveLeft.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnMoveLeft.Image = Properties.Resources.ArrowLeft;
            btnMoveLeft.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnMoveLeft.Location = new System.Drawing.Point(187, 631);
            btnMoveLeft.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnMoveLeft.Name = "btnMoveLeft";
            btnMoveLeft.Size = new System.Drawing.Size(64, 69);
            btnMoveLeft.TabIndex = 576;
            btnMoveLeft.UseVisualStyleBackColor = false;
            btnMoveLeft.Click += btnMoveLeft_Click;
            // 
            // btnMoveRight
            // 
            btnMoveRight.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnMoveRight.BackColor = System.Drawing.Color.White;
            btnMoveRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            btnMoveRight.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            btnMoveRight.FlatAppearance.BorderSize = 0;
            btnMoveRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnMoveRight.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnMoveRight.Image = Properties.Resources.ArrowRight;
            btnMoveRight.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnMoveRight.Location = new System.Drawing.Point(276, 631);
            btnMoveRight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnMoveRight.Name = "btnMoveRight";
            btnMoveRight.Size = new System.Drawing.Size(64, 69);
            btnMoveRight.TabIndex = 577;
            btnMoveRight.UseVisualStyleBackColor = false;
            btnMoveRight.Click += btnMoveRight_Click;
            // 
            // btnMoveDn
            // 
            btnMoveDn.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnMoveDn.BackColor = System.Drawing.Color.White;
            btnMoveDn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            btnMoveDn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            btnMoveDn.FlatAppearance.BorderSize = 0;
            btnMoveDn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnMoveDn.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnMoveDn.Image = Properties.Resources.DnArrow64;
            btnMoveDn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnMoveDn.Location = new System.Drawing.Point(13, 631);
            btnMoveDn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnMoveDn.Name = "btnMoveDn";
            btnMoveDn.Size = new System.Drawing.Size(64, 69);
            btnMoveDn.TabIndex = 574;
            btnMoveDn.UseVisualStyleBackColor = false;
            btnMoveDn.Click += btnMoveDn_Click;
            // 
            // labelCreate
            // 
            labelCreate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            labelCreate.AutoSize = true;
            tlp1.SetColumnSpan(labelCreate, 3);
            labelCreate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelCreate.ForeColor = System.Drawing.Color.Black;
            labelCreate.Location = new System.Drawing.Point(215, 237);
            labelCreate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelCreate.Name = "labelCreate";
            labelCreate.Size = new System.Drawing.Size(97, 19);
            labelCreate.TabIndex = 572;
            labelCreate.Text = "Add Points";
            labelCreate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddPoints
            // 
            btnAddPoints.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            btnAddPoints.BackColor = System.Drawing.Color.WhiteSmoke;
            btnAddPoints.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            tlp1.SetColumnSpan(btnAddPoints, 3);
            btnAddPoints.Enabled = false;
            btnAddPoints.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            btnAddPoints.FlatAppearance.BorderSize = 0;
            btnAddPoints.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAddPoints.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnAddPoints.Image = Properties.Resources.PointAdd;
            btnAddPoints.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnAddPoints.Location = new System.Drawing.Point(221, 148);
            btnAddPoints.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnAddPoints.Name = "btnAddPoints";
            btnAddPoints.Size = new System.Drawing.Size(86, 78);
            btnAddPoints.TabIndex = 574;
            btnAddPoints.UseVisualStyleBackColor = false;
            btnAddPoints.Click += btnAddPoints_Click;
            // 
            // btnResetReduce
            // 
            btnResetReduce.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            btnResetReduce.BackColor = System.Drawing.Color.WhiteSmoke;
            btnResetReduce.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            tlp1.SetColumnSpan(btnResetReduce, 3);
            btnResetReduce.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            btnResetReduce.FlatAppearance.BorderSize = 0;
            btnResetReduce.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnResetReduce.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnResetReduce.Image = Properties.Resources.back_button;
            btnResetReduce.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnResetReduce.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnResetReduce.Location = new System.Drawing.Point(45, 147);
            btnResetReduce.Margin = new System.Windows.Forms.Padding(0);
            btnResetReduce.Name = "btnResetReduce";
            btnResetReduce.Size = new System.Drawing.Size(89, 82);
            btnResetReduce.TabIndex = 578;
            btnResetReduce.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            btnResetReduce.UseVisualStyleBackColor = false;
            btnResetReduce.Click += btnResetReduce_Click_1;
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            label2.AutoSize = true;
            tlp1.SetColumnSpan(label2, 3);
            label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.ForeColor = System.Drawing.Color.Black;
            label2.Location = new System.Drawing.Point(240, 357);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(48, 19);
            label2.TabIndex = 580;
            label2.Text = "Save";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.MistyRose;
            panel1.Controls.Add(labelPleaseWait);
            panel1.Controls.Add(lblPointToProcess);
            panel1.Controls.Add(labelPointsToProcess);
            panel1.Controls.Add(lblI);
            panel1.Controls.Add(labelPoints);
            panel1.Location = new System.Drawing.Point(160, 209);
            panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(519, 352);
            panel1.TabIndex = 573;
            // 
            // labelPleaseWait
            // 
            labelPleaseWait.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelPleaseWait.ForeColor = System.Drawing.Color.Black;
            labelPleaseWait.Location = new System.Drawing.Point(186, 82);
            labelPleaseWait.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelPleaseWait.Name = "labelPleaseWait";
            labelPleaseWait.Size = new System.Drawing.Size(188, 29);
            labelPleaseWait.TabIndex = 529;
            labelPleaseWait.Text = "Please Wait";
            labelPleaseWait.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPointToProcess
            // 
            lblPointToProcess.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblPointToProcess.ForeColor = System.Drawing.Color.Black;
            lblPointToProcess.Location = new System.Drawing.Point(303, 175);
            lblPointToProcess.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPointToProcess.Name = "lblPointToProcess";
            lblPointToProcess.Size = new System.Drawing.Size(114, 29);
            lblPointToProcess.TabIndex = 527;
            lblPointToProcess.Text = "100,000";
            lblPointToProcess.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelPointsToProcess
            // 
            labelPointsToProcess.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelPointsToProcess.ForeColor = System.Drawing.Color.Black;
            labelPointsToProcess.Location = new System.Drawing.Point(98, 174);
            labelPointsToProcess.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelPointsToProcess.Name = "labelPointsToProcess";
            labelPointsToProcess.Size = new System.Drawing.Size(210, 29);
            labelPointsToProcess.TabIndex = 526;
            labelPointsToProcess.Text = "Points to Process: ";
            labelPointsToProcess.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblI
            // 
            lblI.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblI.ForeColor = System.Drawing.Color.Black;
            lblI.Location = new System.Drawing.Point(239, 233);
            lblI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblI.Name = "lblI";
            lblI.Size = new System.Drawing.Size(162, 29);
            lblI.TabIndex = 525;
            lblI.Text = "Points";
            lblI.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelPoints
            // 
            labelPoints.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelPoints.ForeColor = System.Drawing.Color.Black;
            labelPoints.Location = new System.Drawing.Point(154, 232);
            labelPoints.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelPoints.Name = "labelPoints";
            labelPoints.Size = new System.Drawing.Size(96, 29);
            labelPoints.TabIndex = 528;
            labelPoints.Text = "Points:";
            labelPoints.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormBndTool
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.LightGray;
            ClientSize = new System.Drawing.Size(1174, 838);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(tlp1);
            Controls.Add(oglSelf);
            ForeColor = System.Drawing.Color.Black;
            HelpButton = true;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size(1190, 850);
            Name = "FormBndTool";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Create Boundary From Mapping";
            FormClosing += FormBndTool_FormClosing;
            Load += FormBndTool_Load;
            ResizeEnd += FormBndTool_ResizeEnd;
            tlp1.ResumeLayout(false);
            tlp1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private OpenTK.GLControl.GLControl oglSelf;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCancelTouch;
        private System.Windows.Forms.ComboBox cboxPointDistance;
        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.Button btnAddBoundary;
        private System.Windows.Forms.ComboBox cboxSmooth;
        private System.Windows.Forms.Button btnSlice;
        private System.Windows.Forms.Button btnCenterOGL;
        private System.Windows.Forms.CheckBox cboxIsZoom;
        private System.Windows.Forms.Label labelSpacing;
        private System.Windows.Forms.Label labelSmooth;
        private System.Windows.Forms.Button btnZoomOut;
        private System.Windows.Forms.Button btnZoomIn;
        private System.Windows.Forms.TableLayoutPanel tlp1;
        private System.Windows.Forms.Label labelCreate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblI;
        private System.Windows.Forms.Label lblPointToProcess;
        private System.Windows.Forms.Label labelPointsToProcess;
        private System.Windows.Forms.Label labelPoints;
        private System.Windows.Forms.Label labelPleaseWait;
        private System.Windows.Forms.Button btnAddPoints;
        private System.Windows.Forms.Button btnMoveDn;
        private System.Windows.Forms.Button btnMoveUp;
        private System.Windows.Forms.Button btnMoveLeft;
        private System.Windows.Forms.Button btnMoveRight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelReset;
        private System.Windows.Forms.Button btnResetReduce;
        private System.Windows.Forms.Label label2;
    }
}
namespace AgOpenGPS
{
    partial class FormMap
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
            timer1 = new System.Windows.Forms.Timer(components);
            lblPoints = new System.Windows.Forms.Label();
            lblBnds = new System.Windows.Forms.Label();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            labelNewBoundary = new System.Windows.Forms.Label();
            btnZoomIn = new System.Windows.Forms.Button();
            btnZoomOut = new System.Windows.Forms.Button();
            btnExit = new System.Windows.Forms.Button();
            btnGo = new System.Windows.Forms.Button();
            cboxEnableLineDraw = new System.Windows.Forms.CheckBox();
            btnDeleteAll = new System.Windows.Forms.Button();
            labelBackground = new System.Windows.Forms.Label();
            btnAddFence = new System.Windows.Forms.Button();
            btnDeletePoint = new System.Windows.Forms.Button();
            labelBoundary = new System.Windows.Forms.Label();
            cboxDrawMap = new System.Windows.Forms.CheckBox();
            gMapControl = new GMap.NET.WindowsForms.GMapControl();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // lblPoints
            // 
            lblPoints.Anchor = System.Windows.Forms.AnchorStyles.Left;
            lblPoints.BackColor = System.Drawing.Color.Transparent;
            tableLayoutPanel1.SetColumnSpan(lblPoints, 2);
            lblPoints.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblPoints.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lblPoints.Location = new System.Drawing.Point(126, 195);
            lblPoints.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPoints.Name = "lblPoints";
            lblPoints.Size = new System.Drawing.Size(136, 27);
            lblPoints.TabIndex = 476;
            lblPoints.Text = "Points: 12";
            lblPoints.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBnds
            // 
            lblBnds.Anchor = System.Windows.Forms.AnchorStyles.None;
            lblBnds.BackColor = System.Drawing.Color.Transparent;
            tableLayoutPanel1.SetColumnSpan(lblBnds, 2);
            lblBnds.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblBnds.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lblBnds.Location = new System.Drawing.Point(126, 315);
            lblBnds.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblBnds.Name = "lblBnds";
            lblBnds.Size = new System.Drawing.Size(151, 92);
            lblBnds.TabIndex = 489;
            lblBnds.Text = "2";
            lblBnds.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.57143F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.64286F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.78571F));
            tableLayoutPanel1.Controls.Add(labelNewBoundary, 0, 1);
            tableLayoutPanel1.Controls.Add(btnZoomIn, 2, 8);
            tableLayoutPanel1.Controls.Add(btnZoomOut, 0, 8);
            tableLayoutPanel1.Controls.Add(btnExit, 2, 9);
            tableLayoutPanel1.Controls.Add(btnGo, 0, 9);
            tableLayoutPanel1.Controls.Add(cboxEnableLineDraw, 0, 0);
            tableLayoutPanel1.Controls.Add(btnDeleteAll, 2, 0);
            tableLayoutPanel1.Controls.Add(labelBackground, 0, 7);
            tableLayoutPanel1.Controls.Add(btnAddFence, 0, 4);
            tableLayoutPanel1.Controls.Add(btnDeletePoint, 0, 2);
            tableLayoutPanel1.Controls.Add(labelBoundary, 1, 3);
            tableLayoutPanel1.Controls.Add(lblBnds, 1, 4);
            tableLayoutPanel1.Controls.Add(lblPoints, 1, 2);
            tableLayoutPanel1.Controls.Add(cboxDrawMap, 0, 6);
            tableLayoutPanel1.Location = new System.Drawing.Point(1034, 3);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 10;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.12066F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.351676F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.38177F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.54257F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.12066F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.12066F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.12066F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.12066F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.12066F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            tableLayoutPanel1.Size = new System.Drawing.Size(281, 895);
            tableLayoutPanel1.TabIndex = 491;
            // 
            // labelNewBoundary
            // 
            labelNewBoundary.Anchor = System.Windows.Forms.AnchorStyles.Top;
            labelNewBoundary.BackColor = System.Drawing.Color.Transparent;
            labelNewBoundary.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelNewBoundary.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            labelNewBoundary.Location = new System.Drawing.Point(4, 94);
            labelNewBoundary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelNewBoundary.Name = "labelNewBoundary";
            labelNewBoundary.Size = new System.Drawing.Size(114, 27);
            labelNewBoundary.TabIndex = 491;
            labelNewBoundary.Text = "New Bnd";
            labelNewBoundary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnZoomIn
            // 
            btnZoomIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnZoomIn.BackColor = System.Drawing.Color.Transparent;
            btnZoomIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnZoomIn.FlatAppearance.BorderSize = 0;
            btnZoomIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnZoomIn.Image = Properties.Resources.ZoomOGL;
            btnZoomIn.Location = new System.Drawing.Point(189, 715);
            btnZoomIn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnZoomIn.Name = "btnZoomIn";
            btnZoomIn.Size = new System.Drawing.Size(80, 65);
            btnZoomIn.TabIndex = 484;
            btnZoomIn.UseVisualStyleBackColor = false;
            btnZoomIn.Click += btnZoomIn_Click;
            // 
            // btnZoomOut
            // 
            btnZoomOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnZoomOut.BackColor = System.Drawing.Color.Transparent;
            btnZoomOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnZoomOut.FlatAppearance.BorderSize = 0;
            btnZoomOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnZoomOut.Image = Properties.Resources.ZoomOut;
            btnZoomOut.Location = new System.Drawing.Point(23, 711);
            btnZoomOut.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnZoomOut.Name = "btnZoomOut";
            btnZoomOut.Size = new System.Drawing.Size(75, 73);
            btnZoomOut.TabIndex = 485;
            btnZoomOut.UseVisualStyleBackColor = false;
            btnZoomOut.Click += btnZoomOut_Click;
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
            btnExit.Location = new System.Drawing.Point(193, 808);
            btnExit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(71, 73);
            btnExit.TabIndex = 234;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnGo
            // 
            btnGo.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnGo.BackColor = System.Drawing.Color.Transparent;
            btnGo.FlatAppearance.BorderSize = 0;
            btnGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnGo.Image = Properties.Resources.FlagGrn;
            btnGo.Location = new System.Drawing.Point(24, 812);
            btnGo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnGo.Name = "btnGo";
            btnGo.Size = new System.Drawing.Size(74, 66);
            btnGo.TabIndex = 465;
            btnGo.UseVisualStyleBackColor = false;
            btnGo.Click += btnGo_Click;
            // 
            // cboxEnableLineDraw
            // 
            cboxEnableLineDraw.Anchor = System.Windows.Forms.AnchorStyles.None;
            cboxEnableLineDraw.Appearance = System.Windows.Forms.Appearance.Button;
            cboxEnableLineDraw.BackColor = System.Drawing.Color.Transparent;
            cboxEnableLineDraw.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            cboxEnableLineDraw.FlatAppearance.CheckedBackColor = System.Drawing.Color.MediumAquamarine;
            cboxEnableLineDraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboxEnableLineDraw.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            cboxEnableLineDraw.ForeColor = System.Drawing.SystemColors.ControlText;
            cboxEnableLineDraw.Image = Properties.Resources.BoundaryOuter;
            cboxEnableLineDraw.Location = new System.Drawing.Point(12, 5);
            cboxEnableLineDraw.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cboxEnableLineDraw.Name = "cboxEnableLineDraw";
            cboxEnableLineDraw.Size = new System.Drawing.Size(97, 83);
            cboxEnableLineDraw.TabIndex = 472;
            cboxEnableLineDraw.UseVisualStyleBackColor = false;
            cboxEnableLineDraw.Click += cboxEnableLineDraw_Click;
            // 
            // btnDeleteAll
            // 
            btnDeleteAll.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnDeleteAll.BackColor = System.Drawing.Color.Transparent;
            btnDeleteAll.Enabled = false;
            btnDeleteAll.FlatAppearance.BorderSize = 0;
            btnDeleteAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDeleteAll.Image = Properties.Resources.Trash;
            btnDeleteAll.Location = new System.Drawing.Point(193, 13);
            btnDeleteAll.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnDeleteAll.Name = "btnDeleteAll";
            btnDeleteAll.Size = new System.Drawing.Size(71, 68);
            btnDeleteAll.TabIndex = 471;
            btnDeleteAll.UseVisualStyleBackColor = false;
            btnDeleteAll.Click += btnDeleteAll_Click;
            // 
            // labelBackground
            // 
            labelBackground.Anchor = System.Windows.Forms.AnchorStyles.Top;
            labelBackground.BackColor = System.Drawing.Color.Transparent;
            tableLayoutPanel1.SetColumnSpan(labelBackground, 3);
            labelBackground.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelBackground.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            labelBackground.Location = new System.Drawing.Point(18, 607);
            labelBackground.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelBackground.Name = "labelBackground";
            labelBackground.Size = new System.Drawing.Size(245, 36);
            labelBackground.TabIndex = 490;
            labelBackground.Text = "Background ";
            labelBackground.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddFence
            // 
            btnAddFence.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnAddFence.BackColor = System.Drawing.Color.Transparent;
            btnAddFence.Enabled = false;
            btnAddFence.FlatAppearance.BorderSize = 0;
            btnAddFence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAddFence.Image = Properties.Resources.AddNew;
            btnAddFence.Location = new System.Drawing.Point(25, 326);
            btnAddFence.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnAddFence.Name = "btnAddFence";
            btnAddFence.Size = new System.Drawing.Size(71, 70);
            btnAddFence.TabIndex = 470;
            btnAddFence.UseVisualStyleBackColor = false;
            btnAddFence.Click += btnAddFence_Click;
            // 
            // btnDeletePoint
            // 
            btnDeletePoint.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnDeletePoint.BackColor = System.Drawing.Color.Transparent;
            btnDeletePoint.Enabled = false;
            btnDeletePoint.FlatAppearance.BorderSize = 0;
            btnDeletePoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDeletePoint.Image = Properties.Resources.PointDelete;
            btnDeletePoint.Location = new System.Drawing.Point(10, 163);
            btnDeletePoint.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnDeletePoint.Name = "btnDeletePoint";
            btnDeletePoint.Size = new System.Drawing.Size(102, 90);
            btnDeletePoint.TabIndex = 468;
            btnDeletePoint.UseVisualStyleBackColor = false;
            btnDeletePoint.Click += btnDeletePoint_Click;
            // 
            // labelBoundary
            // 
            labelBoundary.Anchor = System.Windows.Forms.AnchorStyles.Left;
            labelBoundary.BackColor = System.Drawing.Color.Transparent;
            tableLayoutPanel1.SetColumnSpan(labelBoundary, 2);
            labelBoundary.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelBoundary.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            labelBoundary.Location = new System.Drawing.Point(126, 269);
            labelBoundary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelBoundary.Name = "labelBoundary";
            labelBoundary.Size = new System.Drawing.Size(151, 27);
            labelBoundary.TabIndex = 492;
            labelBoundary.Text = "Boundary";
            labelBoundary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboxDrawMap
            // 
            cboxDrawMap.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            cboxDrawMap.Appearance = System.Windows.Forms.Appearance.Button;
            cboxDrawMap.BackColor = System.Drawing.Color.Transparent;
            tableLayoutPanel1.SetColumnSpan(cboxDrawMap, 3);
            cboxDrawMap.FlatAppearance.BorderSize = 0;
            cboxDrawMap.FlatAppearance.CheckedBackColor = System.Drawing.Color.MediumAquamarine;
            cboxDrawMap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboxDrawMap.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            cboxDrawMap.ForeColor = System.Drawing.SystemColors.ControlText;
            cboxDrawMap.Image = Properties.Resources.MappingOff;
            cboxDrawMap.Location = new System.Drawing.Point(95, 516);
            cboxDrawMap.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cboxDrawMap.Name = "cboxDrawMap";
            cboxDrawMap.Size = new System.Drawing.Size(91, 88);
            cboxDrawMap.TabIndex = 482;
            cboxDrawMap.UseVisualStyleBackColor = false;
            cboxDrawMap.Click += cboxDrawMap_Click;
            // 
            // gMapControl
            // 
            gMapControl.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            gMapControl.BackColor = System.Drawing.Color.White;
            gMapControl.Bearing = 0F;
            gMapControl.CanDragMap = true;
            gMapControl.Cursor = System.Windows.Forms.Cursors.Cross;
            gMapControl.EmptyTileColor = System.Drawing.Color.FromArgb(224, 224, 224);
            gMapControl.ForeColor = System.Drawing.Color.Black;
            gMapControl.GrayScaleMode = false;
            gMapControl.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            gMapControl.LevelsKeepInMemory = 5;
            gMapControl.Location = new System.Drawing.Point(4, 3);
            gMapControl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gMapControl.MarkersEnabled = true;
            gMapControl.MaxZoom = 19;
            gMapControl.MinZoom = 1;
            gMapControl.MouseWheelZoomEnabled = true;
            gMapControl.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            gMapControl.Name = "gMapControl";
            gMapControl.NegativeMode = false;
            gMapControl.PolygonsEnabled = true;
            gMapControl.RetryLoadTile = 0;
            gMapControl.RoutesEnabled = true;
            gMapControl.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            gMapControl.SelectedAreaFillColor = System.Drawing.Color.FromArgb(33, 65, 105, 225);
            gMapControl.ShowTileGridLines = false;
            gMapControl.Size = new System.Drawing.Size(1027, 895);
            gMapControl.TabIndex = 492;
            gMapControl.Zoom = 2D;
            gMapControl.OnMapClick += gMapControl_OnMapClick;
            gMapControl.MouseMove += gMapControl_MouseMove;
            gMapControl.MouseWheel += gMapControl_MouseWheel;
            // 
            // FormMap
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = System.Drawing.Color.WhiteSmoke;
            ClientSize = new System.Drawing.Size(1318, 900);
            ControlBox = false;
            Controls.Add(gMapControl);
            Controls.Add(tableLayoutPanel1);
            HelpButton = true;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size(1183, 863);
            Name = "FormMap";
            ShowInTaskbar = false;
            Text = "Bing Maps for Background";
            FormClosing += FormMap_FormClosing;
            Load += FormMap_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnDeletePoint;
        private System.Windows.Forms.Button btnAddFence;
        private System.Windows.Forms.Button btnDeleteAll;
        private System.Windows.Forms.CheckBox cboxEnableLineDraw;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.CheckBox cboxDrawMap;
        private System.Windows.Forms.Button btnZoomIn;
        private System.Windows.Forms.Button btnZoomOut;
        private System.Windows.Forms.Label lblBnds;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelBackground;
        private System.Windows.Forms.Label labelNewBoundary;
        private System.Windows.Forms.Label labelBoundary;
        private GMap.NET.WindowsForms.GMapControl gMapControl;
    }
}
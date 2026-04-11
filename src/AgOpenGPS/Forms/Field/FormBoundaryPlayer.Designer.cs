namespace AgOpenGPS
{
    partial class FormBoundaryPlayer
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
            label1 = new System.Windows.Forms.Label();
            timer1 = new System.Windows.Forms.Timer(components);
            lblArea = new System.Windows.Forms.Label();
            lblMetersInches = new System.Windows.Forms.Label();
            cboxIsRecBoundaryWhenSectionOn = new System.Windows.Forms.CheckBox();
            btnAntennaTool = new System.Windows.Forms.Button();
            btnAddPoint = new System.Windows.Forms.Button();
            btnLeftRight = new System.Windows.Forms.Button();
            btnStop = new System.Windows.Forms.Button();
            btnPausePlay = new System.Windows.Forms.Button();
            btnRestart = new System.Windows.Forms.Button();
            btnDeleteLast = new System.Windows.Forms.Button();
            nudOffset = new NudlessNumericUpDown();
            lblPoints = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)nudOffset).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label1.Location = new System.Drawing.Point(2, 458);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(55, 23);
            label1.TabIndex = 141;
            label1.Text = "Area:";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.BackColor = System.Drawing.Color.Transparent;
            lblArea.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblArea.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lblArea.Location = new System.Drawing.Point(56, 458);
            lblArea.Name = "lblArea";
            lblArea.Size = new System.Drawing.Size(46, 23);
            lblArea.TabIndex = 142;
            lblArea.Text = "999";
            lblArea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMetersInches
            // 
            lblMetersInches.BackColor = System.Drawing.Color.Transparent;
            lblMetersInches.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblMetersInches.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lblMetersInches.Location = new System.Drawing.Point(137, 14);
            lblMetersInches.Name = "lblMetersInches";
            lblMetersInches.Size = new System.Drawing.Size(102, 23);
            lblMetersInches.TabIndex = 151;
            lblMetersInches.Text = "cm";
            lblMetersInches.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cboxIsRecBoundaryWhenSectionOn
            // 
            cboxIsRecBoundaryWhenSectionOn.Appearance = System.Windows.Forms.Appearance.Button;
            cboxIsRecBoundaryWhenSectionOn.BackColor = System.Drawing.Color.Transparent;
            cboxIsRecBoundaryWhenSectionOn.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            cboxIsRecBoundaryWhenSectionOn.FlatAppearance.BorderSize = 2;
            cboxIsRecBoundaryWhenSectionOn.FlatAppearance.CheckedBackColor = System.Drawing.Color.PaleTurquoise;
            cboxIsRecBoundaryWhenSectionOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboxIsRecBoundaryWhenSectionOn.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cboxIsRecBoundaryWhenSectionOn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            cboxIsRecBoundaryWhenSectionOn.Image = Properties.Resources.BoundarySectionControlOnOff;
            cboxIsRecBoundaryWhenSectionOn.Location = new System.Drawing.Point(155, 54);
            cboxIsRecBoundaryWhenSectionOn.Name = "cboxIsRecBoundaryWhenSectionOn";
            cboxIsRecBoundaryWhenSectionOn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            cboxIsRecBoundaryWhenSectionOn.Size = new System.Drawing.Size(80, 84);
            cboxIsRecBoundaryWhenSectionOn.TabIndex = 468;
            cboxIsRecBoundaryWhenSectionOn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            cboxIsRecBoundaryWhenSectionOn.UseVisualStyleBackColor = false;
            cboxIsRecBoundaryWhenSectionOn.Click += cboxIsRecBoundaryWhenSectionOn_Click;
            // 
            // btnAntennaTool
            // 
            btnAntennaTool.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            btnAntennaTool.FlatAppearance.BorderSize = 0;
            btnAntennaTool.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAntennaTool.Image = Properties.Resources.BoundaryRecordTool;
            btnAntennaTool.Location = new System.Drawing.Point(16, 291);
            btnAntennaTool.Name = "btnAntennaTool";
            btnAntennaTool.Size = new System.Drawing.Size(80, 64);
            btnAntennaTool.TabIndex = 155;
            btnAntennaTool.UseVisualStyleBackColor = true;
            btnAntennaTool.Click += btnAntennaTool_Click;
            // 
            // btnAddPoint
            // 
            btnAddPoint.BackColor = System.Drawing.Color.Transparent;
            btnAddPoint.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            btnAddPoint.FlatAppearance.BorderSize = 0;
            btnAddPoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAddPoint.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            btnAddPoint.Image = Properties.Resources.PointAdd;
            btnAddPoint.Location = new System.Drawing.Point(155, 290);
            btnAddPoint.Name = "btnAddPoint";
            btnAddPoint.Size = new System.Drawing.Size(80, 64);
            btnAddPoint.TabIndex = 143;
            btnAddPoint.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnAddPoint.UseVisualStyleBackColor = false;
            btnAddPoint.Click += btnAddPoint_Click;
            // 
            // btnLeftRight
            // 
            btnLeftRight.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            btnLeftRight.FlatAppearance.BorderSize = 0;
            btnLeftRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLeftRight.Image = Properties.Resources.BoundaryLeft;
            btnLeftRight.Location = new System.Drawing.Point(5, 175);
            btnLeftRight.Name = "btnLeftRight";
            btnLeftRight.Size = new System.Drawing.Size(80, 64);
            btnLeftRight.TabIndex = 68;
            btnLeftRight.UseVisualStyleBackColor = true;
            btnLeftRight.Click += btnLeftRight_Click;
            // 
            // btnStop
            // 
            btnStop.BackColor = System.Drawing.Color.Transparent;
            btnStop.FlatAppearance.BorderSize = 0;
            btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnStop.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            btnStop.Image = Properties.Resources.OK64;
            btnStop.Location = new System.Drawing.Point(5, 395);
            btnStop.Name = "btnStop";
            btnStop.Size = new System.Drawing.Size(80, 78);
            btnStop.TabIndex = 140;
            btnStop.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnStop.UseVisualStyleBackColor = false;
            btnStop.Click += btnStop_Click;
            // 
            // btnPausePlay
            // 
            btnPausePlay.BackColor = System.Drawing.Color.Transparent;
            btnPausePlay.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            btnPausePlay.FlatAppearance.BorderSize = 0;
            btnPausePlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPausePlay.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            btnPausePlay.Image = Properties.Resources.BoundaryRecord;
            btnPausePlay.Location = new System.Drawing.Point(155, 409);
            btnPausePlay.Name = "btnPausePlay";
            btnPausePlay.Size = new System.Drawing.Size(80, 64);
            btnPausePlay.TabIndex = 139;
            btnPausePlay.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnPausePlay.UseVisualStyleBackColor = false;
            btnPausePlay.Click += btnPausePlay_Click;
            // 
            // btnRestart
            // 
            btnRestart.BackColor = System.Drawing.Color.Transparent;
            btnRestart.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            btnRestart.FlatAppearance.BorderSize = 0;
            btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRestart.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            btnRestart.Image = Properties.Resources.Trash;
            btnRestart.Location = new System.Drawing.Point(21, 77);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new System.Drawing.Size(52, 52);
            btnRestart.TabIndex = 147;
            btnRestart.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnRestart.UseVisualStyleBackColor = false;
            btnRestart.Click += btnRestart_Click;
            // 
            // btnDeleteLast
            // 
            btnDeleteLast.BackColor = System.Drawing.Color.Transparent;
            btnDeleteLast.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            btnDeleteLast.FlatAppearance.BorderSize = 0;
            btnDeleteLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDeleteLast.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            btnDeleteLast.Image = Properties.Resources.PointDelete;
            btnDeleteLast.Location = new System.Drawing.Point(155, 172);
            btnDeleteLast.Name = "btnDeleteLast";
            btnDeleteLast.Size = new System.Drawing.Size(80, 64);
            btnDeleteLast.TabIndex = 144;
            btnDeleteLast.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnDeleteLast.UseVisualStyleBackColor = false;
            btnDeleteLast.Click += btnDeleteLast_Click;
            // 
            // nudOffset
            // 
            nudOffset.BackColor = System.Drawing.Color.AliceBlue;
            nudOffset.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            nudOffset.Location = new System.Drawing.Point(11, 5);
            nudOffset.Maximum = new decimal(new int[] { 4999, 0, 0, 0 });
            nudOffset.Name = "nudOffset";
            nudOffset.ReadOnly = true;
            nudOffset.Size = new System.Drawing.Size(125, 46);
            nudOffset.TabIndex = 149;
            nudOffset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudOffset.Value = new decimal(new int[] { 4999, 0, 0, 0 });
            nudOffset.Click += nudOffset_Click;
            // 
            // lblPoints
            // 
            lblPoints.AutoSize = true;
            lblPoints.BackColor = System.Drawing.Color.Transparent;
            lblPoints.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblPoints.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lblPoints.Location = new System.Drawing.Point(62, 370);
            lblPoints.Name = "lblPoints";
            lblPoints.Size = new System.Drawing.Size(46, 23);
            lblPoints.TabIndex = 469;
            lblPoints.Text = "999";
            lblPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label2.Location = new System.Drawing.Point(1, 369);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(66, 23);
            label2.TabIndex = 470;
            label2.Text = "Points:";
            // 
            // FormBoundaryPlayer
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.WhiteSmoke;
            ClientSize = new System.Drawing.Size(249, 483);
            ControlBox = false;
            Controls.Add(lblPoints);
            Controls.Add(label2);
            Controls.Add(cboxIsRecBoundaryWhenSectionOn);
            Controls.Add(btnAntennaTool);
            Controls.Add(btnAddPoint);
            Controls.Add(btnLeftRight);
            Controls.Add(btnPausePlay);
            Controls.Add(lblArea);
            Controls.Add(btnRestart);
            Controls.Add(btnDeleteLast);
            Controls.Add(label1);
            Controls.Add(nudOffset);
            Controls.Add(lblMetersInches);
            Controls.Add(btnStop);
            Font = new System.Drawing.Font("Tahoma", 14F);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            HelpButton = true;
            Margin = new System.Windows.Forms.Padding(5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormBoundaryPlayer";
            Padding = new System.Windows.Forms.Padding(2);
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Stop Record Pause Boundary";
            FormClosing += FormBoundaryPlayer_FormClosing;
            Load += FormBoundaryPlayer_Load;
            ((System.ComponentModel.ISupportInitialize)nudOffset).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPausePlay;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Button btnAddPoint;
        private System.Windows.Forms.Button btnDeleteLast;
        private System.Windows.Forms.Button btnRestart;
        private NudlessNumericUpDown nudOffset;
        private System.Windows.Forms.Button btnLeftRight;
        private System.Windows.Forms.Label lblMetersInches;
        private System.Windows.Forms.Button btnAntennaTool;
        private System.Windows.Forms.CheckBox cboxIsRecBoundaryWhenSectionOn;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Label label2;
    }
}
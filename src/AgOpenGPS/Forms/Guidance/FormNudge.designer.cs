namespace AgOpenGPS
{
    partial class FormNudge
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
            btnSnapToPivot = new System.Windows.Forms.Button();
            bthOK = new System.Windows.Forms.Button();
            btnAdjLeft = new System.Windows.Forms.Button();
            btnAdjRight = new System.Windows.Forms.Button();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            nudSnapDistance = new NudlessNumericUpDown();
            btnZeroMove = new System.Windows.Forms.Button();
            btnHalfToolRight = new System.Windows.Forms.Button();
            btnHalfToolLeft = new System.Windows.Forms.Button();
            lblOffset = new System.Windows.Forms.Label();
            timer1 = new System.Windows.Forms.Timer(components);
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudSnapDistance).BeginInit();
            SuspendLayout();
            // 
            // btnSnapToPivot
            // 
            btnSnapToPivot.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnSnapToPivot.BackColor = System.Drawing.Color.Transparent;
            btnSnapToPivot.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            btnSnapToPivot.FlatAppearance.BorderSize = 0;
            btnSnapToPivot.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            btnSnapToPivot.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            btnSnapToPivot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            btnSnapToPivot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSnapToPivot.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnSnapToPivot.Image = Properties.Resources.SnapToPivot;
            btnSnapToPivot.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnSnapToPivot.Location = new System.Drawing.Point(105, 12);
            btnSnapToPivot.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSnapToPivot.Name = "btnSnapToPivot";
            btnSnapToPivot.Size = new System.Drawing.Size(80, 67);
            btnSnapToPivot.TabIndex = 6;
            btnSnapToPivot.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnSnapToPivot.UseVisualStyleBackColor = false;
            btnSnapToPivot.Click += btnSnapToPivot_Click;
            // 
            // bthOK
            // 
            bthOK.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            bthOK.BackColor = System.Drawing.Color.Transparent;
            bthOK.BackgroundImage = Properties.Resources.OK64;
            bthOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            bthOK.DialogResult = System.Windows.Forms.DialogResult.Yes;
            bthOK.FlatAppearance.BorderSize = 0;
            bthOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            bthOK.Font = new System.Drawing.Font("Tahoma", 14.25F);
            bthOK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            bthOK.Location = new System.Drawing.Point(68, 399);
            bthOK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            bthOK.Name = "bthOK";
            bthOK.Size = new System.Drawing.Size(75, 65);
            bthOK.TabIndex = 1;
            bthOK.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            bthOK.UseVisualStyleBackColor = false;
            bthOK.Click += bntOk_Click;
            // 
            // btnAdjLeft
            // 
            btnAdjLeft.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnAdjLeft.BackColor = System.Drawing.Color.Transparent;
            btnAdjLeft.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            btnAdjLeft.FlatAppearance.BorderSize = 0;
            btnAdjLeft.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            btnAdjLeft.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            btnAdjLeft.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            btnAdjLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAdjLeft.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnAdjLeft.Image = Properties.Resources.SnapLeft;
            btnAdjLeft.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnAdjLeft.Location = new System.Drawing.Point(8, 104);
            btnAdjLeft.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnAdjLeft.Name = "btnAdjLeft";
            btnAdjLeft.Size = new System.Drawing.Size(80, 67);
            btnAdjLeft.TabIndex = 4;
            btnAdjLeft.UseVisualStyleBackColor = false;
            btnAdjLeft.Click += btnAdjLeft_Click;
            // 
            // btnAdjRight
            // 
            btnAdjRight.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnAdjRight.BackColor = System.Drawing.Color.Transparent;
            btnAdjRight.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            btnAdjRight.FlatAppearance.BorderSize = 0;
            btnAdjRight.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            btnAdjRight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            btnAdjRight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            btnAdjRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAdjRight.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnAdjRight.Image = Properties.Resources.SnapRight;
            btnAdjRight.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnAdjRight.Location = new System.Drawing.Point(105, 104);
            btnAdjRight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnAdjRight.Name = "btnAdjRight";
            btnAdjRight.Size = new System.Drawing.Size(80, 67);
            btnAdjRight.TabIndex = 5;
            btnAdjRight.UseVisualStyleBackColor = false;
            btnAdjRight.Click += btnAdjRight_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tableLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btnAdjLeft, 0, 1);
            tableLayoutPanel1.Controls.Add(btnAdjRight, 1, 1);
            tableLayoutPanel1.Controls.Add(nudSnapDistance, 0, 2);
            tableLayoutPanel1.Controls.Add(btnZeroMove, 0, 0);
            tableLayoutPanel1.Controls.Add(btnHalfToolRight, 1, 3);
            tableLayoutPanel1.Controls.Add(btnHalfToolLeft, 0, 3);
            tableLayoutPanel1.Controls.Add(btnSnapToPivot, 1, 0);
            tableLayoutPanel1.Location = new System.Drawing.Point(8, 44);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel1.MinimumSize = new System.Drawing.Size(175, 312);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.2963F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.66667F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.03704F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.62963F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            tableLayoutPanel1.Size = new System.Drawing.Size(194, 348);
            tableLayoutPanel1.TabIndex = 416;
            // 
            // nudSnapDistance
            // 
            nudSnapDistance.Anchor = System.Windows.Forms.AnchorStyles.None;
            tableLayoutPanel1.SetColumnSpan(nudSnapDistance, 2);
            nudSnapDistance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            nudSnapDistance.Location = new System.Drawing.Point(59, 195);
            nudSnapDistance.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            nudSnapDistance.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudSnapDistance.Name = "nudSnapDistance";
            nudSnapDistance.ReadOnly = true;
            nudSnapDistance.Size = new System.Drawing.Size(75, 36);
            nudSnapDistance.TabIndex = 415;
            nudSnapDistance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudSnapDistance.Value = new decimal(new int[] { 800, 0, 0, 0 });
            nudSnapDistance.Click += nudSnapDistance_Click;
            // 
            // btnZeroMove
            // 
            btnZeroMove.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnZeroMove.BackColor = System.Drawing.Color.Transparent;
            btnZeroMove.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            btnZeroMove.FlatAppearance.BorderSize = 0;
            btnZeroMove.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            btnZeroMove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            btnZeroMove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            btnZeroMove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnZeroMove.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnZeroMove.Image = Properties.Resources.SteerZero;
            btnZeroMove.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnZeroMove.Location = new System.Drawing.Point(8, 12);
            btnZeroMove.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnZeroMove.Name = "btnZeroMove";
            btnZeroMove.Size = new System.Drawing.Size(80, 67);
            btnZeroMove.TabIndex = 534;
            btnZeroMove.UseVisualStyleBackColor = false;
            btnZeroMove.Click += btnZeroMove_Click;
            // 
            // btnHalfToolRight
            // 
            btnHalfToolRight.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnHalfToolRight.BackColor = System.Drawing.Color.Transparent;
            btnHalfToolRight.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            btnHalfToolRight.FlatAppearance.BorderSize = 0;
            btnHalfToolRight.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            btnHalfToolRight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            btnHalfToolRight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            btnHalfToolRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnHalfToolRight.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnHalfToolRight.Image = Properties.Resources.SnapRightHalf;
            btnHalfToolRight.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnHalfToolRight.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnHalfToolRight.Location = new System.Drawing.Point(105, 262);
            btnHalfToolRight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnHalfToolRight.Name = "btnHalfToolRight";
            btnHalfToolRight.Size = new System.Drawing.Size(80, 67);
            btnHalfToolRight.TabIndex = 418;
            btnHalfToolRight.UseVisualStyleBackColor = false;
            btnHalfToolRight.Click += btnHalfToolRight_Click;
            // 
            // btnHalfToolLeft
            // 
            btnHalfToolLeft.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnHalfToolLeft.BackColor = System.Drawing.Color.Transparent;
            btnHalfToolLeft.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            btnHalfToolLeft.FlatAppearance.BorderSize = 0;
            btnHalfToolLeft.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            btnHalfToolLeft.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            btnHalfToolLeft.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            btnHalfToolLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnHalfToolLeft.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnHalfToolLeft.Image = Properties.Resources.SnapLeftHalf;
            btnHalfToolLeft.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnHalfToolLeft.Location = new System.Drawing.Point(8, 262);
            btnHalfToolLeft.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnHalfToolLeft.Name = "btnHalfToolLeft";
            btnHalfToolLeft.Size = new System.Drawing.Size(80, 67);
            btnHalfToolLeft.TabIndex = 418;
            btnHalfToolLeft.UseVisualStyleBackColor = false;
            btnHalfToolLeft.Click += btnHalfToolLeft_Click;
            // 
            // lblOffset
            // 
            lblOffset.AutoSize = true;
            lblOffset.BackColor = System.Drawing.Color.Transparent;
            lblOffset.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblOffset.ForeColor = System.Drawing.Color.Black;
            lblOffset.Location = new System.Drawing.Point(5, 12);
            lblOffset.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblOffset.Name = "lblOffset";
            lblOffset.Size = new System.Drawing.Size(74, 23);
            lblOffset.TabIndex = 417;
            lblOffset.Text = "0.35 >";
            lblOffset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 3000;
            timer1.Tick += timer1_Tick;
            // 
            // FormNudge
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.LightSteelBlue;
            ClientSize = new System.Drawing.Size(210, 473);
            Controls.Add(lblOffset);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(bthOK);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(210, 473);
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size(210, 473);
            Name = "FormNudge";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            FormClosing += FormEditTrack_FormClosing;
            Load += FormEditTrack_Load;
            MouseEnter += FormEditTrack_MouseEnter;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudSnapDistance).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAdjRight;
        private System.Windows.Forms.Button btnAdjLeft;
        private System.Windows.Forms.Button bthOK;
        public System.Windows.Forms.Button btnSnapToPivot;
        private NudlessNumericUpDown nudSnapDistance;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnZeroMove;
        private System.Windows.Forms.Label lblOffset;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnHalfToolLeft;
        private System.Windows.Forms.Button btnHalfToolRight;
    }
}
namespace AgOpenGPS
{
    partial class FormTram
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
            labelSprayWidth = new System.Windows.Forms.Label();
            labelPasses = new System.Windows.Forms.Label();
            btnMode = new System.Windows.Forms.Button();
            btnSwapAB = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            btnExit = new System.Windows.Forms.Button();
            lblTrack = new System.Windows.Forms.Label();
            labelTrack = new System.Windows.Forms.Label();
            lblTramWidth = new System.Windows.Forms.Label();
            labelSeed = new System.Windows.Forms.Label();
            lblSeedWidth = new System.Windows.Forms.Label();
            labelMode = new System.Windows.Forms.Label();
            btnDnTrams = new System.Windows.Forms.Button();
            btnUpTrams = new System.Windows.Forms.Button();
            tbarTramAlpha = new System.Windows.Forms.TrackBar();
            lblAplha = new System.Windows.Forms.Label();
            labelAlpha = new System.Windows.Forms.Label();
            nudPasses = new NudlessNumericUpDown();
            ((System.ComponentModel.ISupportInitialize)tbarTramAlpha).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPasses).BeginInit();
            SuspendLayout();
            // 
            // labelSprayWidth
            // 
            labelSprayWidth.AutoSize = true;
            labelSprayWidth.BackColor = System.Drawing.Color.WhiteSmoke;
            labelSprayWidth.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelSprayWidth.ForeColor = System.Drawing.Color.Black;
            labelSprayWidth.Location = new System.Drawing.Point(102, 344);
            labelSprayWidth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelSprayWidth.Name = "labelSprayWidth";
            labelSprayWidth.Size = new System.Drawing.Size(49, 19);
            labelSprayWidth.TabIndex = 424;
            labelSprayWidth.Text = "Spray";
            labelSprayWidth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPasses
            // 
            labelPasses.BackColor = System.Drawing.Color.WhiteSmoke;
            labelPasses.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelPasses.ForeColor = System.Drawing.Color.Black;
            labelPasses.Location = new System.Drawing.Point(71, 166);
            labelPasses.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelPasses.Name = "labelPasses";
            labelPasses.Size = new System.Drawing.Size(187, 28);
            labelPasses.TabIndex = 435;
            labelPasses.Text = "Passes";
            labelPasses.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnMode
            // 
            btnMode.BackColor = System.Drawing.Color.Transparent;
            btnMode.BackgroundImage = Properties.Resources.TramAll;
            btnMode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnMode.FlatAppearance.BorderSize = 0;
            btnMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnMode.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnMode.ForeColor = System.Drawing.Color.White;
            btnMode.Location = new System.Drawing.Point(158, 22);
            btnMode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnMode.Name = "btnMode";
            btnMode.Size = new System.Drawing.Size(100, 102);
            btnMode.TabIndex = 460;
            btnMode.UseVisualStyleBackColor = false;
            btnMode.Click += btnMode_Click;
            // 
            // btnSwapAB
            // 
            btnSwapAB.BackColor = System.Drawing.Color.Transparent;
            btnSwapAB.FlatAppearance.BorderSize = 0;
            btnSwapAB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSwapAB.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnSwapAB.ForeColor = System.Drawing.Color.White;
            btnSwapAB.Image = Properties.Resources.ABSwapPoints;
            btnSwapAB.Location = new System.Drawing.Point(1, 37);
            btnSwapAB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSwapAB.Name = "btnSwapAB";
            btnSwapAB.Size = new System.Drawing.Size(84, 72);
            btnSwapAB.TabIndex = 438;
            btnSwapAB.UseVisualStyleBackColor = false;
            btnSwapAB.Click += btnSwapAB_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = System.Drawing.Color.Transparent;
            btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancel.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnCancel.ForeColor = System.Drawing.Color.White;
            btnCancel.Image = Properties.Resources.SwitchOff;
            btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnCancel.Location = new System.Drawing.Point(4, 300);
            btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(91, 77);
            btnCancel.TabIndex = 421;
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = System.Drawing.Color.Transparent;
            btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnExit.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnExit.ForeColor = System.Drawing.Color.White;
            btnExit.Image = Properties.Resources.FileSave;
            btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnExit.Location = new System.Drawing.Point(299, 317);
            btnExit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(114, 77);
            btnExit.TabIndex = 234;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // lblTrack
            // 
            lblTrack.AutoSize = true;
            lblTrack.BackColor = System.Drawing.Color.WhiteSmoke;
            lblTrack.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblTrack.ForeColor = System.Drawing.Color.Black;
            lblTrack.Location = new System.Drawing.Point(223, 375);
            lblTrack.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTrack.Name = "lblTrack";
            lblTrack.Size = new System.Drawing.Size(68, 23);
            lblTrack.TabIndex = 465;
            lblTrack.Text = "10 cm";
            lblTrack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTrack
            // 
            labelTrack.AutoSize = true;
            labelTrack.BackColor = System.Drawing.Color.WhiteSmoke;
            labelTrack.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelTrack.ForeColor = System.Drawing.Color.Black;
            labelTrack.Location = new System.Drawing.Point(100, 378);
            labelTrack.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelTrack.Name = "labelTrack";
            labelTrack.Size = new System.Drawing.Size(48, 19);
            labelTrack.TabIndex = 464;
            labelTrack.Text = "Track";
            labelTrack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTramWidth
            // 
            lblTramWidth.AutoSize = true;
            lblTramWidth.BackColor = System.Drawing.Color.WhiteSmoke;
            lblTramWidth.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblTramWidth.ForeColor = System.Drawing.Color.Black;
            lblTramWidth.Location = new System.Drawing.Point(223, 340);
            lblTramWidth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTramWidth.Name = "lblTramWidth";
            lblTramWidth.Size = new System.Drawing.Size(68, 23);
            lblTramWidth.TabIndex = 462;
            lblTramWidth.Text = "10 cm";
            lblTramWidth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSeed
            // 
            labelSeed.AutoSize = true;
            labelSeed.BackColor = System.Drawing.Color.WhiteSmoke;
            labelSeed.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelSeed.ForeColor = System.Drawing.Color.Black;
            labelSeed.Location = new System.Drawing.Point(102, 308);
            labelSeed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelSeed.Name = "labelSeed";
            labelSeed.Size = new System.Drawing.Size(43, 19);
            labelSeed.TabIndex = 466;
            labelSeed.Text = "Seed";
            labelSeed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSeedWidth
            // 
            lblSeedWidth.AutoSize = true;
            lblSeedWidth.BackColor = System.Drawing.Color.WhiteSmoke;
            lblSeedWidth.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblSeedWidth.ForeColor = System.Drawing.Color.Black;
            lblSeedWidth.Location = new System.Drawing.Point(223, 305);
            lblSeedWidth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblSeedWidth.Name = "lblSeedWidth";
            lblSeedWidth.Size = new System.Drawing.Size(68, 23);
            lblSeedWidth.TabIndex = 467;
            lblSeedWidth.Text = "10 cm";
            lblSeedWidth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelMode
            // 
            labelMode.AutoSize = true;
            labelMode.BackColor = System.Drawing.Color.WhiteSmoke;
            labelMode.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelMode.ForeColor = System.Drawing.Color.Black;
            labelMode.Location = new System.Drawing.Point(181, 3);
            labelMode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelMode.Name = "labelMode";
            labelMode.Size = new System.Drawing.Size(47, 19);
            labelMode.TabIndex = 468;
            labelMode.Text = "Mode";
            labelMode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnDnTrams
            // 
            btnDnTrams.BackColor = System.Drawing.Color.Transparent;
            btnDnTrams.FlatAppearance.BorderSize = 0;
            btnDnTrams.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDnTrams.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnDnTrams.ForeColor = System.Drawing.Color.White;
            btnDnTrams.Image = Properties.Resources.DnArrow64;
            btnDnTrams.Location = new System.Drawing.Point(-4, 179);
            btnDnTrams.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnDnTrams.Name = "btnDnTrams";
            btnDnTrams.Size = new System.Drawing.Size(84, 72);
            btnDnTrams.TabIndex = 469;
            btnDnTrams.UseVisualStyleBackColor = false;
            btnDnTrams.Click += btnDnTrams_Click;
            // 
            // btnUpTrams
            // 
            btnUpTrams.BackColor = System.Drawing.Color.Transparent;
            btnUpTrams.FlatAppearance.BorderSize = 0;
            btnUpTrams.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnUpTrams.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnUpTrams.ForeColor = System.Drawing.Color.White;
            btnUpTrams.Image = Properties.Resources.UpArrow64;
            btnUpTrams.Location = new System.Drawing.Point(239, 179);
            btnUpTrams.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnUpTrams.Name = "btnUpTrams";
            btnUpTrams.Size = new System.Drawing.Size(84, 72);
            btnUpTrams.TabIndex = 470;
            btnUpTrams.UseVisualStyleBackColor = false;
            btnUpTrams.Click += btnUpTrams_Click;
            // 
            // tbarTramAlpha
            // 
            tbarTramAlpha.LargeChange = 10;
            tbarTramAlpha.Location = new System.Drawing.Point(354, 29);
            tbarTramAlpha.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tbarTramAlpha.Maximum = 100;
            tbarTramAlpha.Minimum = 10;
            tbarTramAlpha.Name = "tbarTramAlpha";
            tbarTramAlpha.Orientation = System.Windows.Forms.Orientation.Vertical;
            tbarTramAlpha.Size = new System.Drawing.Size(45, 249);
            tbarTramAlpha.SmallChange = 10;
            tbarTramAlpha.TabIndex = 471;
            tbarTramAlpha.Value = 60;
            tbarTramAlpha.Scroll += tbarTramAlpha_Scroll;
            // 
            // lblAplha
            // 
            lblAplha.AutoSize = true;
            lblAplha.BackColor = System.Drawing.Color.WhiteSmoke;
            lblAplha.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblAplha.ForeColor = System.Drawing.Color.Black;
            lblAplha.Location = new System.Drawing.Point(335, 273);
            lblAplha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblAplha.Name = "lblAplha";
            lblAplha.Size = new System.Drawing.Size(52, 19);
            lblAplha.TabIndex = 472;
            lblAplha.Text = "100%";
            lblAplha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelAlpha
            // 
            labelAlpha.AutoSize = true;
            labelAlpha.BackColor = System.Drawing.Color.WhiteSmoke;
            labelAlpha.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelAlpha.ForeColor = System.Drawing.Color.Black;
            labelAlpha.Location = new System.Drawing.Point(338, 3);
            labelAlpha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelAlpha.Name = "labelAlpha";
            labelAlpha.Size = new System.Drawing.Size(50, 19);
            labelAlpha.TabIndex = 473;
            labelAlpha.Text = "Alpha";
            labelAlpha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nudPasses
            // 
            nudPasses.BackColor = System.Drawing.Color.White;
            nudPasses.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            nudPasses.InterceptArrowKeys = false;
            nudPasses.Location = new System.Drawing.Point(108, 197);
            nudPasses.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            nudPasses.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            nudPasses.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudPasses.Name = "nudPasses";
            nudPasses.ReadOnly = true;
            nudPasses.RightToLeft = System.Windows.Forms.RightToLeft.No;
            nudPasses.Size = new System.Drawing.Size(107, 46);
            nudPasses.TabIndex = 433;
            nudPasses.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudPasses.Value = new decimal(new int[] { 777, 0, 0, 0 });
            nudPasses.Click += nudPasses_Click;
            // 
            // FormTram
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.WhiteSmoke;
            ClientSize = new System.Drawing.Size(412, 408);
            ControlBox = false;
            Controls.Add(lblAplha);
            Controls.Add(labelAlpha);
            Controls.Add(tbarTramAlpha);
            Controls.Add(btnUpTrams);
            Controls.Add(btnDnTrams);
            Controls.Add(labelMode);
            Controls.Add(labelSeed);
            Controls.Add(lblSeedWidth);
            Controls.Add(nudPasses);
            Controls.Add(lblTrack);
            Controls.Add(labelPasses);
            Controls.Add(btnSwapAB);
            Controls.Add(btnExit);
            Controls.Add(labelTrack);
            Controls.Add(labelSprayWidth);
            Controls.Add(lblTramWidth);
            Controls.Add(btnMode);
            Controls.Add(btnCancel);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            HelpButton = true;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormTram";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "AB Line Tramline";
            FormClosing += FormTram_FormClosing;
            Load += FormTram_Load;
            ((System.ComponentModel.ISupportInitialize)tbarTramAlpha).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPasses).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label labelSprayWidth;
        private NudlessNumericUpDown nudPasses;
        private System.Windows.Forms.Label labelPasses;
        private System.Windows.Forms.Button btnSwapAB;
        private System.Windows.Forms.Button btnMode;
        private System.Windows.Forms.Label lblTramWidth;
        private System.Windows.Forms.Label lblTrack;
        private System.Windows.Forms.Label labelTrack;
        private System.Windows.Forms.Label labelSeed;
        private System.Windows.Forms.Label lblSeedWidth;
        private System.Windows.Forms.Label labelMode;
        private System.Windows.Forms.Button btnDnTrams;
        private System.Windows.Forms.Button btnUpTrams;
        private System.Windows.Forms.TrackBar tbarTramAlpha;
        private System.Windows.Forms.Label lblAplha;
        private System.Windows.Forms.Label labelAlpha;
    }
}
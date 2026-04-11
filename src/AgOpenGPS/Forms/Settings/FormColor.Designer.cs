namespace AgOpenGPS
{
    partial class FormColor
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
            bntOK = new System.Windows.Forms.Button();
            btnFrameDay = new System.Windows.Forms.Button();
            btnFrameNight = new System.Windows.Forms.Button();
            btnFieldNight = new System.Windows.Forms.Button();
            btnFieldDay = new System.Windows.Forms.Button();
            btnSwap = new System.Windows.Forms.Button();
            btnDayText = new System.Windows.Forms.Button();
            btnNightText = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            lblSmoothCam = new System.Windows.Forms.Label();
            labelSmooth = new System.Windows.Forms.Label();
            hsbarSmooth = new System.Windows.Forms.HScrollBar();
            labelDirect = new System.Windows.Forms.Label();
            labelCameraBehavior = new System.Windows.Forms.Label();
            btnReset = new System.Windows.Forms.Button();
            labelReset = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 500;
            // 
            // bntOK
            // 
            bntOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            bntOK.FlatAppearance.BorderSize = 0;
            bntOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            bntOK.Font = new System.Drawing.Font("Tahoma", 14.25F);
            bntOK.Image = Properties.Resources.OK64;
            bntOK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            bntOK.Location = new System.Drawing.Point(587, 319);
            bntOK.Name = "bntOK";
            bntOK.Size = new System.Drawing.Size(66, 65);
            bntOK.TabIndex = 0;
            bntOK.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            bntOK.UseVisualStyleBackColor = true;
            bntOK.Click += bntOK_Click;
            // 
            // btnFrameDay
            // 
            btnFrameDay.BackColor = System.Drawing.Color.Transparent;
            btnFrameDay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnFrameDay.FlatAppearance.BorderSize = 0;
            btnFrameDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnFrameDay.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnFrameDay.Image = Properties.Resources.ColourPick;
            btnFrameDay.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnFrameDay.Location = new System.Drawing.Point(247, 12);
            btnFrameDay.Name = "btnFrameDay";
            btnFrameDay.Size = new System.Drawing.Size(59, 57);
            btnFrameDay.TabIndex = 4;
            btnFrameDay.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            btnFrameDay.UseVisualStyleBackColor = false;
            btnFrameDay.Click += btnFrameDay_Click;
            // 
            // btnFrameNight
            // 
            btnFrameNight.BackColor = System.Drawing.Color.Transparent;
            btnFrameNight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnFrameNight.FlatAppearance.BorderSize = 0;
            btnFrameNight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnFrameNight.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnFrameNight.Image = Properties.Resources.ColourPick;
            btnFrameNight.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnFrameNight.Location = new System.Drawing.Point(247, 181);
            btnFrameNight.Name = "btnFrameNight";
            btnFrameNight.Size = new System.Drawing.Size(59, 57);
            btnFrameNight.TabIndex = 5;
            btnFrameNight.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            btnFrameNight.UseVisualStyleBackColor = false;
            btnFrameNight.Click += btnFrameNight_Click;
            // 
            // btnFieldNight
            // 
            btnFieldNight.BackColor = System.Drawing.Color.Transparent;
            btnFieldNight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnFieldNight.FlatAppearance.BorderSize = 0;
            btnFieldNight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnFieldNight.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnFieldNight.Image = Properties.Resources.ColourPick;
            btnFieldNight.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnFieldNight.Location = new System.Drawing.Point(164, 280);
            btnFieldNight.Name = "btnFieldNight";
            btnFieldNight.Size = new System.Drawing.Size(59, 57);
            btnFieldNight.TabIndex = 7;
            btnFieldNight.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            btnFieldNight.UseVisualStyleBackColor = false;
            btnFieldNight.Click += btnFieldNight_Click;
            // 
            // btnFieldDay
            // 
            btnFieldDay.BackColor = System.Drawing.Color.Transparent;
            btnFieldDay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnFieldDay.FlatAppearance.BorderSize = 0;
            btnFieldDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnFieldDay.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnFieldDay.Image = Properties.Resources.ColourPick;
            btnFieldDay.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnFieldDay.Location = new System.Drawing.Point(164, 94);
            btnFieldDay.Name = "btnFieldDay";
            btnFieldDay.Size = new System.Drawing.Size(59, 57);
            btnFieldDay.TabIndex = 6;
            btnFieldDay.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            btnFieldDay.UseVisualStyleBackColor = false;
            btnFieldDay.Click += btnFieldDay_Click;
            // 
            // btnSwap
            // 
            btnSwap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnSwap.FlatAppearance.BorderSize = 0;
            btnSwap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSwap.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnSwap.Image = Properties.Resources.ConD_AutoDayNight;
            btnSwap.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnSwap.Location = new System.Drawing.Point(396, 181);
            btnSwap.Name = "btnSwap";
            btnSwap.Size = new System.Drawing.Size(121, 65);
            btnSwap.TabIndex = 10;
            btnSwap.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            btnSwap.UseVisualStyleBackColor = true;
            btnSwap.Click += btnSwap_Click;
            // 
            // btnDayText
            // 
            btnDayText.BackColor = System.Drawing.Color.Transparent;
            btnDayText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnDayText.FlatAppearance.BorderSize = 0;
            btnDayText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDayText.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnDayText.Image = Properties.Resources.ColourPick;
            btnDayText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnDayText.Location = new System.Drawing.Point(12, 38);
            btnDayText.Name = "btnDayText";
            btnDayText.Size = new System.Drawing.Size(59, 57);
            btnDayText.TabIndex = 11;
            btnDayText.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            btnDayText.UseVisualStyleBackColor = false;
            btnDayText.Click += btnDayText_Click;
            // 
            // btnNightText
            // 
            btnNightText.BackColor = System.Drawing.Color.Transparent;
            btnNightText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnNightText.FlatAppearance.BorderSize = 0;
            btnNightText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNightText.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnNightText.Image = Properties.Resources.ColourPick;
            btnNightText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnNightText.Location = new System.Drawing.Point(12, 224);
            btnNightText.Name = "btnNightText";
            btnNightText.Size = new System.Drawing.Size(59, 57);
            btnNightText.TabIndex = 12;
            btnNightText.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            btnNightText.UseVisualStyleBackColor = false;
            btnNightText.Click += btnNightText_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.FromArgb(60, 60, 80);
            label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label1.Location = new System.Drawing.Point(17, 204);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(85, 23);
            label1.TabIndex = 13;
            label1.Text = "ABC123";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.White;
            label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label2.Location = new System.Drawing.Point(17, 17);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(85, 23);
            label2.TabIndex = 14;
            label2.Text = "ABC123";
            // 
            // lblSmoothCam
            // 
            lblSmoothCam.AutoSize = true;
            lblSmoothCam.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblSmoothCam.ForeColor = System.Drawing.Color.Black;
            lblSmoothCam.Location = new System.Drawing.Point(468, 80);
            lblSmoothCam.Name = "lblSmoothCam";
            lblSmoothCam.Size = new System.Drawing.Size(63, 25);
            lblSmoothCam.TabIndex = 465;
            lblSmoothCam.Text = "65%";
            // 
            // labelSmooth
            // 
            labelSmooth.AutoSize = true;
            labelSmooth.Location = new System.Drawing.Point(368, 89);
            labelSmooth.Name = "labelSmooth";
            labelSmooth.Size = new System.Drawing.Size(51, 16);
            labelSmooth.TabIndex = 464;
            labelSmooth.Text = "Smooth";
            // 
            // hsbarSmooth
            // 
            hsbarSmooth.LargeChange = 1;
            hsbarSmooth.Location = new System.Drawing.Point(366, 108);
            hsbarSmooth.Minimum = 2;
            hsbarSmooth.Name = "hsbarSmooth";
            hsbarSmooth.Size = new System.Drawing.Size(262, 43);
            hsbarSmooth.TabIndex = 463;
            hsbarSmooth.Value = 50;
            hsbarSmooth.ValueChanged += hsbarSmooth_ValueChanged;
            // 
            // labelDirect
            // 
            labelDirect.AutoSize = true;
            labelDirect.Location = new System.Drawing.Point(585, 89);
            labelDirect.Name = "labelDirect";
            labelDirect.Size = new System.Drawing.Size(40, 16);
            labelDirect.TabIndex = 466;
            labelDirect.Text = "Direct";
            // 
            // labelCameraBehavior
            // 
            labelCameraBehavior.AutoSize = true;
            labelCameraBehavior.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelCameraBehavior.ForeColor = System.Drawing.Color.Black;
            labelCameraBehavior.Location = new System.Drawing.Point(400, 38);
            labelCameraBehavior.Name = "labelCameraBehavior";
            labelCameraBehavior.Size = new System.Drawing.Size(204, 25);
            labelCameraBehavior.TabIndex = 467;
            labelCameraBehavior.Text = "Camera Behaviour";
            // 
            // btnReset
            // 
            btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnReset.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnReset.Image = Properties.Resources.ResetColors;
            btnReset.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnReset.Location = new System.Drawing.Point(396, 272);
            btnReset.Name = "btnReset";
            btnReset.Size = new System.Drawing.Size(121, 65);
            btnReset.TabIndex = 468;
            btnReset.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // labelReset
            // 
            labelReset.AutoSize = true;
            labelReset.Location = new System.Drawing.Point(411, 340);
            labelReset.Name = "labelReset";
            labelReset.Size = new System.Drawing.Size(98, 16);
            labelReset.TabIndex = 469;
            labelReset.Text = "Reset to Default";
            // 
            // FormColor
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            AutoScroll = true;
            BackColor = System.Drawing.Color.LightGray;
            BackgroundImage = Properties.Resources.ColorBackGnd;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            ClientSize = new System.Drawing.Size(665, 396);
            ControlBox = false;
            Controls.Add(labelReset);
            Controls.Add(btnReset);
            Controls.Add(labelCameraBehavior);
            Controls.Add(labelDirect);
            Controls.Add(lblSmoothCam);
            Controls.Add(labelSmooth);
            Controls.Add(hsbarSmooth);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnNightText);
            Controls.Add(btnDayText);
            Controls.Add(btnSwap);
            Controls.Add(btnFieldNight);
            Controls.Add(btnFieldDay);
            Controls.Add(btnFrameNight);
            Controls.Add(btnFrameDay);
            Controls.Add(bntOK);
            DoubleBuffered = true;
            Font = new System.Drawing.Font("Tahoma", 9.75F);
            Margin = new System.Windows.Forms.Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormColor";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Color Set";
            Load += FormDisplaySettings_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button bntOK;
        private System.Windows.Forms.Button btnFrameDay;
        private System.Windows.Forms.Button btnFrameNight;
        private System.Windows.Forms.Button btnFieldNight;
        private System.Windows.Forms.Button btnFieldDay;
        private System.Windows.Forms.Button btnSwap;
        private System.Windows.Forms.Button btnDayText;
        private System.Windows.Forms.Button btnNightText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSmoothCam;
        private System.Windows.Forms.Label labelSmooth;
        private System.Windows.Forms.HScrollBar hsbarSmooth;
        private System.Windows.Forms.Label labelDirect;
        private System.Windows.Forms.Label labelCameraBehavior;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label labelReset;
    }
}
namespace AgOpenGPS
{
    partial class FormGraphSteer
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
            label5 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            lblPWM = new System.Windows.Forms.Label();
            lblSteerAng = new System.Windows.Forms.Label();
            btnGainUp = new System.Windows.Forms.Button();
            btnGainDown = new System.Windows.Forms.Button();
            btnGainAuto = new System.Windows.Forms.Button();
            lblMin = new System.Windows.Forms.Label();
            lblMax = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 200;
            timer1.Tick += timer1_Tick;
            // 
            // label5
            // 
            label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label5.AutoEllipsis = true;
            label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label5.Location = new System.Drawing.Point(86, 330);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(103, 27);
            label5.TabIndex = 196;
            label5.Text = "SetPoint";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label1.AutoEllipsis = true;
            label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label1.Location = new System.Drawing.Point(276, 330);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(83, 27);
            label1.TabIndex = 195;
            label1.Text = "Actual";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPWM
            // 
            lblPWM.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblPWM.AutoSize = true;
            lblPWM.BackColor = System.Drawing.SystemColors.ControlText;
            lblPWM.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblPWM.ForeColor = System.Drawing.Color.Lime;
            lblPWM.Location = new System.Drawing.Point(190, 330);
            lblPWM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPWM.Name = "lblPWM";
            lblPWM.Size = new System.Drawing.Size(68, 23);
            lblPWM.TabIndex = 194;
            lblPWM.Text = "label5";
            lblPWM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSteerAng
            // 
            lblSteerAng.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblSteerAng.AutoSize = true;
            lblSteerAng.BackColor = System.Drawing.SystemColors.ControlText;
            lblSteerAng.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblSteerAng.ForeColor = System.Drawing.Color.OrangeRed;
            lblSteerAng.Location = new System.Drawing.Point(366, 330);
            lblSteerAng.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblSteerAng.Name = "lblSteerAng";
            lblSteerAng.Size = new System.Drawing.Size(68, 23);
            lblSteerAng.TabIndex = 193;
            lblSteerAng.Text = "label1";
            lblSteerAng.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnGainUp
            // 
            btnGainUp.BackColor = System.Drawing.Color.Transparent;
            btnGainUp.FlatAppearance.BorderSize = 2;
            btnGainUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnGainUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnGainUp.ForeColor = System.Drawing.Color.White;
            btnGainUp.Location = new System.Drawing.Point(4, 15);
            btnGainUp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnGainUp.Name = "btnGainUp";
            btnGainUp.Size = new System.Drawing.Size(56, 63);
            btnGainUp.TabIndex = 197;
            btnGainUp.Text = "+";
            btnGainUp.UseVisualStyleBackColor = false;
            btnGainUp.Click += btnGainUp_Click;
            // 
            // btnGainDown
            // 
            btnGainDown.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnGainDown.BackColor = System.Drawing.Color.Transparent;
            btnGainDown.FlatAppearance.BorderSize = 2;
            btnGainDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnGainDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnGainDown.ForeColor = System.Drawing.Color.White;
            btnGainDown.Location = new System.Drawing.Point(4, 253);
            btnGainDown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnGainDown.Name = "btnGainDown";
            btnGainDown.Size = new System.Drawing.Size(56, 63);
            btnGainDown.TabIndex = 198;
            btnGainDown.Text = "-";
            btnGainDown.UseVisualStyleBackColor = false;
            btnGainDown.Click += btnGainDown_Click;
            // 
            // btnGainAuto
            // 
            btnGainAuto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            btnGainAuto.BackColor = System.Drawing.Color.Transparent;
            btnGainAuto.FlatAppearance.BorderSize = 2;
            btnGainAuto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnGainAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnGainAuto.ForeColor = System.Drawing.Color.White;
            btnGainAuto.Location = new System.Drawing.Point(4, 130);
            btnGainAuto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnGainAuto.Name = "btnGainAuto";
            btnGainAuto.Size = new System.Drawing.Size(56, 63);
            btnGainAuto.TabIndex = 199;
            btnGainAuto.Text = "A";
            btnGainAuto.UseVisualStyleBackColor = false;
            btnGainAuto.Click += btnGainAuto_Click;
            // 
            // lblMin
            // 
            lblMin.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            lblMin.BackColor = System.Drawing.SystemColors.ControlText;
            lblMin.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblMin.ForeColor = System.Drawing.Color.White;
            lblMin.Location = new System.Drawing.Point(509, 330);
            lblMin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblMin.Name = "lblMin";
            lblMin.Size = new System.Drawing.Size(62, 27);
            lblMin.TabIndex = 200;
            lblMin.Text = "10";
            lblMin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMax
            // 
            lblMax.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lblMax.BackColor = System.Drawing.SystemColors.ControlText;
            lblMax.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblMax.ForeColor = System.Drawing.Color.White;
            lblMax.Location = new System.Drawing.Point(504, 1);
            lblMax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblMax.Name = "lblMax";
            lblMax.Size = new System.Drawing.Size(66, 27);
            lblMax.TabIndex = 201;
            lblMax.Text = "Auto";
            lblMax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.SystemColors.ControlText;
            label2.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.ForeColor = System.Drawing.Color.Lime;
            label2.Location = new System.Drawing.Point(551, 143);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(37, 33);
            label2.TabIndex = 203;
            label2.Text = "<";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormGraphSteer
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            ClientSize = new System.Drawing.Size(581, 360);
            Controls.Add(label2);
            Controls.Add(lblMax);
            Controls.Add(lblMin);
            Controls.Add(btnGainAuto);
            Controls.Add(btnGainDown);
            Controls.Add(btnGainUp);
            Controls.Add(lblPWM);
            Controls.Add(lblSteerAng);
            Controls.Add(label5);
            Controls.Add(label1);
            Location = new System.Drawing.Point(30, 30);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormGraphSteer";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "AutoSteer Graph";
            Load += FormSteerGraph_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart unoChart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPWM;
        private System.Windows.Forms.Label lblSteerAng;
        private System.Windows.Forms.Button btnGainUp;
        private System.Windows.Forms.Button btnGainDown;
        private System.Windows.Forms.Button btnGainAuto;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label label2;
    }
}
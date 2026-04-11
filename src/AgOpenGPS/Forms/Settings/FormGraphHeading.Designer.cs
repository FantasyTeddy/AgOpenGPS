namespace AgOpenGPS
{
    partial class FormGraphHeading
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
            lblDiff = new System.Windows.Forms.Label();
            lblPWM = new System.Windows.Forms.Label();
            lblSteerAng = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // lblDiff
            // 
            lblDiff.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            lblDiff.AutoSize = true;
            lblDiff.BackColor = System.Drawing.SystemColors.ControlText;
            lblDiff.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblDiff.ForeColor = System.Drawing.Color.Cyan;
            lblDiff.Location = new System.Drawing.Point(451, 115);
            lblDiff.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDiff.Name = "lblDiff";
            lblDiff.Size = new System.Drawing.Size(85, 29);
            lblDiff.TabIndex = 245;
            lblDiff.Text = "label5";
            lblDiff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPWM
            // 
            lblPWM.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            lblPWM.AutoSize = true;
            lblPWM.BackColor = System.Drawing.SystemColors.ControlText;
            lblPWM.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblPWM.ForeColor = System.Drawing.Color.Lime;
            lblPWM.Location = new System.Drawing.Point(322, 115);
            lblPWM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPWM.Name = "lblPWM";
            lblPWM.Size = new System.Drawing.Size(85, 29);
            lblPWM.TabIndex = 247;
            lblPWM.Text = "label5";
            lblPWM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSteerAng
            // 
            lblSteerAng.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            lblSteerAng.AutoSize = true;
            lblSteerAng.BackColor = System.Drawing.SystemColors.ControlText;
            lblSteerAng.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblSteerAng.ForeColor = System.Drawing.Color.OrangeRed;
            lblSteerAng.Location = new System.Drawing.Point(128, 115);
            lblSteerAng.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblSteerAng.Name = "lblSteerAng";
            lblSteerAng.Size = new System.Drawing.Size(85, 29);
            lblSteerAng.TabIndex = 246;
            lblSteerAng.Text = "label1";
            lblSteerAng.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            label5.AutoEllipsis = true;
            label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label5.ForeColor = System.Drawing.Color.Chartreuse;
            label5.Location = new System.Drawing.Point(260, 120);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(64, 27);
            label5.TabIndex = 249;
            label5.Text = "IMU";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            label1.AutoEllipsis = true;
            label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.OrangeRed;
            label1.Location = new System.Drawing.Point(44, 120);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(86, 27);
            label1.TabIndex = 248;
            label1.Text = "Fix2Fix";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label2.AutoEllipsis = true;
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label2.Location = new System.Drawing.Point(-2, 164);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(44, 23);
            label2.TabIndex = 250;
            label2.Text = "+10";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label3.AutoEllipsis = true;
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label3.Location = new System.Drawing.Point(6, 490);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(37, 23);
            label3.TabIndex = 251;
            label3.Text = "-10";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label4.AutoEllipsis = true;
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label4.Location = new System.Drawing.Point(14, 315);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(20, 23);
            label4.TabIndex = 252;
            label4.Text = "0";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormGraphHeading
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            ClientSize = new System.Drawing.Size(578, 542);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblPWM);
            Controls.Add(lblSteerAng);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(lblDiff);
            Location = new System.Drawing.Point(30, 30);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "FormGraphHeading";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Heading Chart";
            Load += FormSteerGraph_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart unoChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart rollChart;
        private System.Windows.Forms.Label lblDiff;
        private System.Windows.Forms.Label lblPWM;
        private System.Windows.Forms.Label lblSteerAng;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
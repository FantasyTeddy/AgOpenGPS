namespace AgOpenGPS
{
    partial class FormCorrection 
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
            lblCorrectionDistance = new System.Windows.Forms.Label();
            lblEast = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            lblOst = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            lblRollDegrees = new System.Windows.Forms.Label();
            lblEastOnGraph = new System.Windows.Forms.Label();
            btnScroll = new System.Windows.Forms.Button();
            btnPoleOrMoving = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // lblCorrectionDistance
            // 
            lblCorrectionDistance.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            lblCorrectionDistance.AutoSize = true;
            lblCorrectionDistance.BackColor = System.Drawing.SystemColors.ControlText;
            lblCorrectionDistance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblCorrectionDistance.ForeColor = System.Drawing.Color.Red;
            lblCorrectionDistance.Location = new System.Drawing.Point(622, 445);
            lblCorrectionDistance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblCorrectionDistance.Name = "lblCorrectionDistance";
            lblCorrectionDistance.Size = new System.Drawing.Size(85, 29);
            lblCorrectionDistance.TabIndex = 245;
            lblCorrectionDistance.Text = "label5";
            lblCorrectionDistance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEast
            // 
            lblEast.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            lblEast.AutoSize = true;
            lblEast.BackColor = System.Drawing.SystemColors.ControlText;
            lblEast.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblEast.ForeColor = System.Drawing.Color.Lime;
            lblEast.Location = new System.Drawing.Point(360, 445);
            lblEast.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblEast.Name = "lblEast";
            lblEast.Size = new System.Drawing.Size(85, 29);
            lblEast.TabIndex = 247;
            lblEast.Text = "label5";
            lblEast.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            label5.AutoEllipsis = true;
            label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label5.ForeColor = System.Drawing.Color.Chartreuse;
            label5.Location = new System.Drawing.Point(250, 429);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(114, 63);
            label5.TabIndex = 249;
            label5.Text = "Corrected Easting";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            label1.AutoEllipsis = true;
            label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.Red;
            label1.Location = new System.Drawing.Point(511, 433);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(113, 53);
            label1.TabIndex = 250;
            label1.Text = "Correction Distance";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOst
            // 
            lblOst.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            lblOst.AutoSize = true;
            lblOst.BackColor = System.Drawing.SystemColors.ControlText;
            lblOst.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblOst.ForeColor = System.Drawing.Color.Cyan;
            lblOst.Location = new System.Drawing.Point(119, 447);
            lblOst.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblOst.Name = "lblOst";
            lblOst.Size = new System.Drawing.Size(85, 29);
            lblOst.TabIndex = 251;
            lblOst.Text = "label5";
            lblOst.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            label3.AutoEllipsis = true;
            label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label3.ForeColor = System.Drawing.Color.Cyan;
            label3.Location = new System.Drawing.Point(26, 447);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(98, 33);
            label3.TabIndex = 252;
            label3.Text = "Antenna";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            label6.AutoEllipsis = true;
            label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label6.ForeColor = System.Drawing.Color.LightSalmon;
            label6.Location = new System.Drawing.Point(749, 434);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(99, 54);
            label6.TabIndex = 256;
            label6.Text = "Roll Degrees";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRollDegrees
            // 
            lblRollDegrees.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            lblRollDegrees.AutoSize = true;
            lblRollDegrees.BackColor = System.Drawing.SystemColors.ControlText;
            lblRollDegrees.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblRollDegrees.ForeColor = System.Drawing.Color.LightSalmon;
            lblRollDegrees.Location = new System.Drawing.Point(846, 443);
            lblRollDegrees.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblRollDegrees.Name = "lblRollDegrees";
            lblRollDegrees.Size = new System.Drawing.Size(85, 29);
            lblRollDegrees.TabIndex = 255;
            lblRollDegrees.Text = "label5";
            lblRollDegrees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEastOnGraph
            // 
            lblEastOnGraph.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lblEastOnGraph.BackColor = System.Drawing.SystemColors.ControlText;
            lblEastOnGraph.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblEastOnGraph.ForeColor = System.Drawing.Color.Lime;
            lblEastOnGraph.Location = new System.Drawing.Point(822, 5);
            lblEastOnGraph.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblEastOnGraph.Name = "lblEastOnGraph";
            lblEastOnGraph.Size = new System.Drawing.Size(122, 33);
            lblEastOnGraph.TabIndex = 257;
            lblEastOnGraph.Text = "-88";
            lblEastOnGraph.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnScroll
            // 
            btnScroll.BackColor = System.Drawing.Color.Transparent;
            btnScroll.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            btnScroll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnScroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnScroll.ForeColor = System.Drawing.Color.Lime;
            btnScroll.Location = new System.Drawing.Point(14, 14);
            btnScroll.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnScroll.Name = "btnScroll";
            btnScroll.Size = new System.Drawing.Size(107, 69);
            btnScroll.TabIndex = 258;
            btnScroll.Text = "Scroll On Off";
            btnScroll.UseVisualStyleBackColor = false;
            btnScroll.Click += btnScroll_Click_1;
            // 
            // btnPoleOrMoving
            // 
            btnPoleOrMoving.BackColor = System.Drawing.Color.Transparent;
            btnPoleOrMoving.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            btnPoleOrMoving.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPoleOrMoving.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnPoleOrMoving.ForeColor = System.Drawing.Color.Lime;
            btnPoleOrMoving.Location = new System.Drawing.Point(16, 347);
            btnPoleOrMoving.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnPoleOrMoving.Name = "btnPoleOrMoving";
            btnPoleOrMoving.Size = new System.Drawing.Size(107, 69);
            btnPoleOrMoving.TabIndex = 259;
            btnPoleOrMoving.Text = "Pole";
            btnPoleOrMoving.UseVisualStyleBackColor = false;
            btnPoleOrMoving.Click += btnPoleOrMoving_Click;
            // 
            // FormCorrection
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            ClientSize = new System.Drawing.Size(944, 489);
            Controls.Add(btnPoleOrMoving);
            Controls.Add(btnScroll);
            Controls.Add(lblEastOnGraph);
            Controls.Add(label6);
            Controls.Add(lblRollDegrees);
            Controls.Add(lblOst);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(lblEast);
            Controls.Add(label5);
            Controls.Add(lblCorrectionDistance);
            Location = new System.Drawing.Point(30, 30);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "FormCorrection";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Roll Correction Chart";
            Load += FormSteerGraph_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart rollChart;
        private System.Windows.Forms.Label lblCorrectionDistance;
        private System.Windows.Forms.Label lblEast;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOst;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblRollDegrees;
        private System.Windows.Forms.Label lblEastOnGraph;
        private System.Windows.Forms.Button btnScroll;
        private System.Windows.Forms.Button btnPoleOrMoving;
    }
}
namespace AgOpenGPS
{
    partial class FormFieldData
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
            lblTimeRemaining = new System.Windows.Forms.Label();
            labelRemain = new System.Windows.Forms.Label();
            lblAreaRemain = new System.Windows.Forms.Label();
            lblWorkRate = new System.Windows.Forms.Label();
            labelRate = new System.Windows.Forms.Label();
            lblTotalArea = new System.Windows.Forms.Label();
            labelTotal = new System.Windows.Forms.Label();
            lblApplied = new System.Windows.Forms.Label();
            labelApplied = new System.Windows.Forms.Label();
            lblRemainPercent = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            lblActualLessOverlap = new System.Windows.Forms.Label();
            labelApplied2 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            lblOverlapPercent = new System.Windows.Forms.Label();
            labelOverlap = new System.Windows.Forms.Label();
            labelActual = new System.Windows.Forms.Label();
            labelWorked = new System.Windows.Forms.Label();
            lblActualRemain = new System.Windows.Forms.Label();
            labelRemain2 = new System.Windows.Forms.Label();
            labelAreaValue = new System.Windows.Forms.Label();
            labelArea = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            labelDistance = new System.Windows.Forms.Label();
            labelDistanceDriven = new System.Windows.Forms.Label();
            labelTrip = new System.Windows.Forms.Label();
            btnTripReset = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // lblTimeRemaining
            // 
            lblTimeRemaining.AutoSize = true;
            lblTimeRemaining.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblTimeRemaining.ForeColor = System.Drawing.Color.White;
            lblTimeRemaining.Location = new System.Drawing.Point(114, 153);
            lblTimeRemaining.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            lblTimeRemaining.Name = "lblTimeRemaining";
            lblTimeRemaining.Size = new System.Drawing.Size(18, 23);
            lblTimeRemaining.TabIndex = 479;
            lblTimeRemaining.Text = "-";
            // 
            // labelRemain
            // 
            labelRemain.AutoSize = true;
            labelRemain.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelRemain.ForeColor = System.Drawing.Color.White;
            labelRemain.Location = new System.Drawing.Point(12, 95);
            labelRemain.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            labelRemain.Name = "labelRemain";
            labelRemain.Size = new System.Drawing.Size(80, 23);
            labelRemain.TabIndex = 478;
            labelRemain.Text = "Remain:";
            // 
            // lblAreaRemain
            // 
            lblAreaRemain.AutoSize = true;
            lblAreaRemain.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblAreaRemain.ForeColor = System.Drawing.Color.White;
            lblAreaRemain.Location = new System.Drawing.Point(114, 95);
            lblAreaRemain.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            lblAreaRemain.Name = "lblAreaRemain";
            lblAreaRemain.Size = new System.Drawing.Size(18, 23);
            lblAreaRemain.TabIndex = 480;
            lblAreaRemain.Text = "-";
            // 
            // lblWorkRate
            // 
            lblWorkRate.AutoSize = true;
            lblWorkRate.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblWorkRate.ForeColor = System.Drawing.Color.White;
            lblWorkRate.Location = new System.Drawing.Point(101, 325);
            lblWorkRate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            lblWorkRate.Name = "lblWorkRate";
            lblWorkRate.Size = new System.Drawing.Size(18, 23);
            lblWorkRate.TabIndex = 482;
            lblWorkRate.Text = "-";
            // 
            // labelRate
            // 
            labelRate.AutoSize = true;
            labelRate.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelRate.ForeColor = System.Drawing.Color.White;
            labelRate.Location = new System.Drawing.Point(10, 325);
            labelRate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            labelRate.Name = "labelRate";
            labelRate.Size = new System.Drawing.Size(55, 23);
            labelRate.TabIndex = 481;
            labelRate.Text = "Rate:";
            // 
            // lblTotalArea
            // 
            lblTotalArea.AutoSize = true;
            lblTotalArea.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblTotalArea.ForeColor = System.Drawing.Color.White;
            lblTotalArea.Location = new System.Drawing.Point(99, 0);
            lblTotalArea.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            lblTotalArea.Name = "lblTotalArea";
            lblTotalArea.Size = new System.Drawing.Size(18, 23);
            lblTotalArea.TabIndex = 484;
            lblTotalArea.Text = "-";
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelTotal.ForeColor = System.Drawing.Color.White;
            labelTotal.Location = new System.Drawing.Point(13, 0);
            labelTotal.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new System.Drawing.Size(58, 23);
            labelTotal.TabIndex = 483;
            labelTotal.Text = "Total:";
            // 
            // lblApplied
            // 
            lblApplied.AutoSize = true;
            lblApplied.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblApplied.ForeColor = System.Drawing.Color.White;
            lblApplied.Location = new System.Drawing.Point(114, 66);
            lblApplied.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            lblApplied.Name = "lblApplied";
            lblApplied.Size = new System.Drawing.Size(18, 23);
            lblApplied.TabIndex = 486;
            lblApplied.Text = "-";
            // 
            // labelApplied
            // 
            labelApplied.AutoSize = true;
            labelApplied.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelApplied.ForeColor = System.Drawing.Color.White;
            labelApplied.Location = new System.Drawing.Point(13, 66);
            labelApplied.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            labelApplied.Name = "labelApplied";
            labelApplied.Size = new System.Drawing.Size(79, 23);
            labelApplied.TabIndex = 485;
            labelApplied.Text = "Applied:";
            // 
            // lblRemainPercent
            // 
            lblRemainPercent.AutoSize = true;
            lblRemainPercent.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblRemainPercent.ForeColor = System.Drawing.Color.White;
            lblRemainPercent.Location = new System.Drawing.Point(114, 123);
            lblRemainPercent.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            lblRemainPercent.Name = "lblRemainPercent";
            lblRemainPercent.Size = new System.Drawing.Size(18, 23);
            lblRemainPercent.TabIndex = 487;
            lblRemainPercent.Text = "-";
            lblRemainPercent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(4, 38);
            label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(189, 19);
            label1.TabIndex = 488;
            label1.Text = "____________________";
            // 
            // lblActualLessOverlap
            // 
            lblActualLessOverlap.AutoSize = true;
            lblActualLessOverlap.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblActualLessOverlap.ForeColor = System.Drawing.Color.White;
            lblActualLessOverlap.Location = new System.Drawing.Point(112, 229);
            lblActualLessOverlap.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            lblActualLessOverlap.Name = "lblActualLessOverlap";
            lblActualLessOverlap.Size = new System.Drawing.Size(18, 23);
            lblActualLessOverlap.TabIndex = 490;
            lblActualLessOverlap.Text = "-";
            // 
            // labelApplied2
            // 
            labelApplied2.AutoSize = true;
            labelApplied2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelApplied2.ForeColor = System.Drawing.Color.White;
            labelApplied2.Location = new System.Drawing.Point(9, 229);
            labelApplied2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            labelApplied2.Name = "labelApplied2";
            labelApplied2.Size = new System.Drawing.Size(79, 23);
            labelApplied2.TabIndex = 489;
            labelApplied2.Text = "Applied:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label7.ForeColor = System.Drawing.Color.White;
            label7.Location = new System.Drawing.Point(4, 203);
            label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(189, 19);
            label7.TabIndex = 491;
            label7.Text = "____________________";
            // 
            // lblOverlapPercent
            // 
            lblOverlapPercent.AutoSize = true;
            lblOverlapPercent.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblOverlapPercent.ForeColor = System.Drawing.Color.White;
            lblOverlapPercent.Location = new System.Drawing.Point(113, 287);
            lblOverlapPercent.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            lblOverlapPercent.Name = "lblOverlapPercent";
            lblOverlapPercent.Size = new System.Drawing.Size(18, 23);
            lblOverlapPercent.TabIndex = 493;
            lblOverlapPercent.Text = "-";
            // 
            // labelOverlap
            // 
            labelOverlap.AutoSize = true;
            labelOverlap.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelOverlap.ForeColor = System.Drawing.Color.White;
            labelOverlap.Location = new System.Drawing.Point(9, 287);
            labelOverlap.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            labelOverlap.Name = "labelOverlap";
            labelOverlap.Size = new System.Drawing.Size(81, 23);
            labelOverlap.TabIndex = 492;
            labelOverlap.Text = "Overlap:";
            // 
            // labelActual
            // 
            labelActual.AutoSize = true;
            labelActual.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelActual.ForeColor = System.Drawing.Color.White;
            labelActual.Location = new System.Drawing.Point(71, 189);
            labelActual.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            labelActual.Name = "labelActual";
            labelActual.Size = new System.Drawing.Size(61, 23);
            labelActual.TabIndex = 494;
            labelActual.Text = "Actual";
            // 
            // labelWorked
            // 
            labelWorked.AutoSize = true;
            labelWorked.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelWorked.ForeColor = System.Drawing.Color.White;
            labelWorked.Location = new System.Drawing.Point(71, 29);
            labelWorked.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            labelWorked.Name = "labelWorked";
            labelWorked.Size = new System.Drawing.Size(74, 23);
            labelWorked.TabIndex = 495;
            labelWorked.Text = "Worked";
            // 
            // lblActualRemain
            // 
            lblActualRemain.AutoSize = true;
            lblActualRemain.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblActualRemain.ForeColor = System.Drawing.Color.White;
            lblActualRemain.Location = new System.Drawing.Point(113, 258);
            lblActualRemain.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            lblActualRemain.Name = "lblActualRemain";
            lblActualRemain.Size = new System.Drawing.Size(18, 23);
            lblActualRemain.TabIndex = 497;
            lblActualRemain.Text = "-";
            // 
            // labelRemain2
            // 
            labelRemain2.AutoSize = true;
            labelRemain2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelRemain2.ForeColor = System.Drawing.Color.White;
            labelRemain2.Location = new System.Drawing.Point(10, 258);
            labelRemain2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            labelRemain2.Name = "labelRemain2";
            labelRemain2.Size = new System.Drawing.Size(80, 23);
            labelRemain2.TabIndex = 496;
            labelRemain2.Text = "Remain:";
            // 
            // labelAreaValue
            // 
            labelAreaValue.AutoSize = true;
            labelAreaValue.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelAreaValue.ForeColor = System.Drawing.Color.White;
            labelAreaValue.Location = new System.Drawing.Point(102, 382);
            labelAreaValue.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            labelAreaValue.Name = "labelAreaValue";
            labelAreaValue.Size = new System.Drawing.Size(17, 21);
            labelAreaValue.TabIndex = 499;
            labelAreaValue.Text = "-";
            // 
            // labelArea
            // 
            labelArea.AutoSize = true;
            labelArea.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelArea.ForeColor = System.Drawing.Color.White;
            labelArea.Location = new System.Drawing.Point(10, 382);
            labelArea.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            labelArea.Name = "labelArea";
            labelArea.Size = new System.Drawing.Size(55, 23);
            labelArea.TabIndex = 498;
            labelArea.Text = "Area:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(7, 364);
            label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(189, 19);
            label2.TabIndex = 501;
            label2.Text = "____________________";
            // 
            // labelDistance
            // 
            labelDistance.AutoSize = true;
            labelDistance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelDistance.ForeColor = System.Drawing.Color.White;
            labelDistance.Location = new System.Drawing.Point(10, 407);
            labelDistance.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            labelDistance.Name = "labelDistance";
            labelDistance.Size = new System.Drawing.Size(48, 23);
            labelDistance.TabIndex = 502;
            labelDistance.Text = "Dist:";
            // 
            // labelDistanceDriven
            // 
            labelDistanceDriven.AutoSize = true;
            labelDistanceDriven.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelDistanceDriven.ForeColor = System.Drawing.Color.White;
            labelDistanceDriven.Location = new System.Drawing.Point(102, 407);
            labelDistanceDriven.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            labelDistanceDriven.Name = "labelDistanceDriven";
            labelDistanceDriven.Size = new System.Drawing.Size(17, 21);
            labelDistanceDriven.TabIndex = 503;
            labelDistanceDriven.Text = "-";
            // 
            // labelTrip
            // 
            labelTrip.AutoSize = true;
            labelTrip.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelTrip.ForeColor = System.Drawing.Color.White;
            labelTrip.Location = new System.Drawing.Point(59, 357);
            labelTrip.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            labelTrip.Name = "labelTrip";
            labelTrip.Size = new System.Drawing.Size(43, 23);
            labelTrip.TabIndex = 504;
            labelTrip.Text = "Trip";
            // 
            // btnTripReset
            // 
            btnTripReset.Image = Properties.Resources.back_button;
            btnTripReset.Location = new System.Drawing.Point(63, 436);
            btnTripReset.Name = "btnTripReset";
            btnTripReset.Size = new System.Drawing.Size(76, 44);
            btnTripReset.TabIndex = 500;
            btnTripReset.UseVisualStyleBackColor = true;
            btnTripReset.Click += btnTripReset_Click;
            // 
            // FormFieldData
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            BackColor = System.Drawing.Color.Black;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            ClientSize = new System.Drawing.Size(197, 483);
            Controls.Add(labelTrip);
            Controls.Add(labelDistanceDriven);
            Controls.Add(labelDistance);
            Controls.Add(btnTripReset);
            Controls.Add(labelAreaValue);
            Controls.Add(labelArea);
            Controls.Add(lblWorkRate);
            Controls.Add(lblActualRemain);
            Controls.Add(labelRemain2);
            Controls.Add(labelWorked);
            Controls.Add(labelActual);
            Controls.Add(lblOverlapPercent);
            Controls.Add(labelOverlap);
            Controls.Add(label7);
            Controls.Add(lblActualLessOverlap);
            Controls.Add(labelApplied2);
            Controls.Add(lblRemainPercent);
            Controls.Add(lblApplied);
            Controls.Add(labelApplied);
            Controls.Add(lblTotalArea);
            Controls.Add(labelTotal);
            Controls.Add(labelRate);
            Controls.Add(lblAreaRemain);
            Controls.Add(lblTimeRemaining);
            Controls.Add(labelRemain);
            Controls.Add(label1);
            Controls.Add(label2);
            Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormFieldData";
            ShowInTaskbar = false;
            Text = "System Data";
            Load += FormFieldData_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTimeRemaining;
        private System.Windows.Forms.Label labelRemain;
        private System.Windows.Forms.Label lblAreaRemain;
        private System.Windows.Forms.Label lblWorkRate;
        private System.Windows.Forms.Label labelRate;
        private System.Windows.Forms.Label lblTotalArea;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label lblApplied;
        private System.Windows.Forms.Label labelApplied;
        private System.Windows.Forms.Label lblRemainPercent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblActualLessOverlap;
        private System.Windows.Forms.Label labelApplied2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblOverlapPercent;
        private System.Windows.Forms.Label labelOverlap;
        private System.Windows.Forms.Label labelActual;
        private System.Windows.Forms.Label labelWorked;
        private System.Windows.Forms.Label lblActualRemain;
        private System.Windows.Forms.Label labelRemain2;
        private System.Windows.Forms.Label labelAreaValue;
        private System.Windows.Forms.Label labelArea;
        private System.Windows.Forms.Button btnTripReset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelDistance;
        private System.Windows.Forms.Label labelDistanceDriven;
        private System.Windows.Forms.Label labelTrip;
    }
}
namespace AgIO.Forms
{
    partial class FormAdvancedSettings
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
            cboxStartMinimized = new System.Windows.Forms.CheckBox();
            cboxAutoRunGPS_Out = new System.Windows.Forms.CheckBox();
            cboxShowOnWarning = new System.Windows.Forms.CheckBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            btnClose = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // cboxStartMinimized
            // 
            cboxStartMinimized.Appearance = System.Windows.Forms.Appearance.Button;
            cboxStartMinimized.BackColor = System.Drawing.Color.Transparent;
            cboxStartMinimized.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            cboxStartMinimized.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(180, 255, 180);
            cboxStartMinimized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboxStartMinimized.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cboxStartMinimized.Image = Properties.Resources.MinimizeIcon;
            cboxStartMinimized.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            cboxStartMinimized.Location = new System.Drawing.Point(14, 14);
            cboxStartMinimized.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cboxStartMinimized.Name = "cboxStartMinimized";
            cboxStartMinimized.Size = new System.Drawing.Size(167, 148);
            cboxStartMinimized.TabIndex = 530;
            cboxStartMinimized.UseVisualStyleBackColor = false;
            cboxStartMinimized.CheckedChanged += cboxStartMinimized_CheckedChanged;
            // 
            // cboxAutoRunGPS_Out
            // 
            cboxAutoRunGPS_Out.Appearance = System.Windows.Forms.Appearance.Button;
            cboxAutoRunGPS_Out.BackColor = System.Drawing.Color.Transparent;
            cboxAutoRunGPS_Out.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            cboxAutoRunGPS_Out.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(180, 255, 180);
            cboxAutoRunGPS_Out.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboxAutoRunGPS_Out.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cboxAutoRunGPS_Out.Image = Properties.Resources.GPS_Out;
            cboxAutoRunGPS_Out.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            cboxAutoRunGPS_Out.Location = new System.Drawing.Point(14, 218);
            cboxAutoRunGPS_Out.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cboxAutoRunGPS_Out.Name = "cboxAutoRunGPS_Out";
            cboxAutoRunGPS_Out.Size = new System.Drawing.Size(167, 148);
            cboxAutoRunGPS_Out.TabIndex = 529;
            cboxAutoRunGPS_Out.Text = "Auto\r\nRun";
            cboxAutoRunGPS_Out.UseVisualStyleBackColor = false;
            cboxAutoRunGPS_Out.CheckedChanged += cboxAutoRunGPS_Out_CheckedChanged;
            // 
            // cboxShowOnWarning
            // 
            cboxShowOnWarning.Appearance = System.Windows.Forms.Appearance.Button;
            cboxShowOnWarning.BackColor = System.Drawing.Color.Transparent;
            cboxShowOnWarning.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            cboxShowOnWarning.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(180, 255, 180);
            cboxShowOnWarning.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboxShowOnWarning.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cboxShowOnWarning.Image = Properties.Resources.ConSt_Mandatory;
            cboxShowOnWarning.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            cboxShowOnWarning.Location = new System.Drawing.Point(14, 421);
            cboxShowOnWarning.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cboxShowOnWarning.Name = "cboxShowOnWarning";
            cboxShowOnWarning.Size = new System.Drawing.Size(167, 148);
            cboxShowOnWarning.TabIndex = 534;
            cboxShowOnWarning.Text = "Show\r\nOn\r\nWarn";
            cboxShowOnWarning.UseVisualStyleBackColor = false;
            cboxShowOnWarning.CheckedChanged += cboxShowOnWarning_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(188, 67);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(215, 31);
            label1.TabIndex = 531;
            label1.Text = "Start Minimized";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(188, 271);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(270, 31);
            label2.TabIndex = 532;
            label2.Text = "Auto Start GPS-Out";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(188, 474);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(292, 31);
            label3.TabIndex = 535;
            label3.Text = "PopUp AgIO on Warn";
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClose.Image = Properties.Resources.OK64;
            btnClose.Location = new System.Drawing.Point(428, 600);
            btnClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(75, 74);
            btnClose.TabIndex = 533;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // FormAdvancedSettings
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(560, 688);
            ControlBox = false;
            Controls.Add(btnClose);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cboxShowOnWarning);
            Controls.Add(cboxStartMinimized);
            Controls.Add(cboxAutoRunGPS_Out);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximumSize = new System.Drawing.Size(580, 731);
            MinimumSize = new System.Drawing.Size(580, 731);
            Name = "FormAdvancedSettings";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Advanced Settings";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cboxAutoRunGPS_Out;
        private System.Windows.Forms.CheckBox cboxStartMinimized;
        private System.Windows.Forms.CheckBox cboxShowOnWarning;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClose;
    }
}
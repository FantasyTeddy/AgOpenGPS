namespace AgOpenGPS
{
    partial class FormFieldKML
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
            tboxFieldName = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            btnLoadKML = new System.Windows.Forms.Button();
            btnSave = new System.Windows.Forms.Button();
            btnSerialCancel = new System.Windows.Forms.Button();
            labelFieldname = new System.Windows.Forms.Label();
            btnAddDate = new System.Windows.Forms.Button();
            btnAddTime = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // tboxFieldName
            // 
            tboxFieldName.BackColor = System.Drawing.Color.AliceBlue;
            tboxFieldName.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            tboxFieldName.Location = new System.Drawing.Point(15, 38);
            tboxFieldName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            tboxFieldName.Name = "tboxFieldName";
            tboxFieldName.Size = new System.Drawing.Size(565, 36);
            tboxFieldName.TabIndex = 0;
            tboxFieldName.Click += tboxFieldName_Click;
            tboxFieldName.TextChanged += tboxFieldName_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label3.Location = new System.Drawing.Point(172, 153);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(24, 23);
            label3.TabIndex = 150;
            label3.Text = "+";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label2.Location = new System.Drawing.Point(22, 152);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(24, 23);
            label2.TabIndex = 149;
            label2.Text = "+";
            // 
            // btnLoadKML
            // 
            btnLoadKML.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnLoadKML.BackColor = System.Drawing.Color.Transparent;
            btnLoadKML.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            btnLoadKML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLoadKML.ForeColor = System.Drawing.SystemColors.ButtonFace;
            btnLoadKML.Image = Properties.Resources.BoundaryLoadFromGE;
            btnLoadKML.Location = new System.Drawing.Point(53, 238);
            btnLoadKML.Name = "btnLoadKML";
            btnLoadKML.Size = new System.Drawing.Size(83, 79);
            btnLoadKML.TabIndex = 3;
            btnLoadKML.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnLoadKML.UseVisualStyleBackColor = false;
            btnLoadKML.Click += btnLoadKML_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnSave.BackColor = System.Drawing.Color.Transparent;
            btnSave.Enabled = false;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            btnSave.Image = Properties.Resources.OK64;
            btnSave.Location = new System.Drawing.Point(520, 248);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(83, 79);
            btnSave.TabIndex = 3;
            btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnSerialCancel
            // 
            btnSerialCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnSerialCancel.BackColor = System.Drawing.Color.Transparent;
            btnSerialCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnSerialCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnSerialCancel.FlatAppearance.BorderSize = 0;
            btnSerialCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSerialCancel.Font = new System.Drawing.Font("Tahoma", 12F);
            btnSerialCancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            btnSerialCancel.Image = Properties.Resources.Cancel64;
            btnSerialCancel.Location = new System.Drawing.Point(376, 247);
            btnSerialCancel.Name = "btnSerialCancel";
            btnSerialCancel.Size = new System.Drawing.Size(77, 79);
            btnSerialCancel.TabIndex = 4;
            btnSerialCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnSerialCancel.UseVisualStyleBackColor = false;
            btnSerialCancel.Click += btnSerialCancel_Click;
            // 
            // labelFieldname
            // 
            labelFieldname.AutoSize = true;
            labelFieldname.BackColor = System.Drawing.Color.Transparent;
            labelFieldname.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelFieldname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            labelFieldname.Location = new System.Drawing.Point(18, 11);
            labelFieldname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelFieldname.Name = "labelFieldname";
            labelFieldname.Size = new System.Drawing.Size(174, 23);
            labelFieldname.TabIndex = 4;
            labelFieldname.Text = "Enter Field Name";
            // 
            // btnAddDate
            // 
            btnAddDate.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnAddDate.BackColor = System.Drawing.Color.Transparent;
            btnAddDate.FlatAppearance.BorderSize = 0;
            btnAddDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAddDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            btnAddDate.Image = Properties.Resources.JobNameCalendar;
            btnAddDate.Location = new System.Drawing.Point(46, 125);
            btnAddDate.Name = "btnAddDate";
            btnAddDate.Size = new System.Drawing.Size(83, 79);
            btnAddDate.TabIndex = 154;
            btnAddDate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnAddDate.UseVisualStyleBackColor = false;
            btnAddDate.Click += btnAddDate_Click;
            // 
            // btnAddTime
            // 
            btnAddTime.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnAddTime.BackColor = System.Drawing.Color.Transparent;
            btnAddTime.FlatAppearance.BorderSize = 0;
            btnAddTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAddTime.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            btnAddTime.Image = Properties.Resources.JobNameTime;
            btnAddTime.Location = new System.Drawing.Point(203, 126);
            btnAddTime.Name = "btnAddTime";
            btnAddTime.Size = new System.Drawing.Size(83, 79);
            btnAddTime.TabIndex = 153;
            btnAddTime.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnAddTime.UseVisualStyleBackColor = false;
            btnAddTime.Click += btnAddTime_Click;
            // 
            // FormFieldKML
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            BackColor = System.Drawing.Color.Gainsboro;
            ClientSize = new System.Drawing.Size(608, 332);
            ControlBox = false;
            Controls.Add(btnAddDate);
            Controls.Add(btnAddTime);
            Controls.Add(label3);
            Controls.Add(labelFieldname);
            Controls.Add(label2);
            Controls.Add(tboxFieldName);
            Controls.Add(btnLoadKML);
            Controls.Add(btnSave);
            Controls.Add(btnSerialCancel);
            Font = new System.Drawing.Font("Tahoma", 14.25F);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "FormFieldKML";
            Padding = new System.Windows.Forms.Padding(2);
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Create New Field ";
            Load += FormFieldDir_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tboxFieldName;
        private System.Windows.Forms.Button btnSerialCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelFieldname;
        private System.Windows.Forms.Button btnLoadKML;
        private System.Windows.Forms.Button btnAddDate;
        private System.Windows.Forms.Button btnAddTime;
    }
}
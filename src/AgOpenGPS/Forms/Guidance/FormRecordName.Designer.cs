
namespace AgOpenGPS.Forms
{
    partial class FormRecordName
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
            labelFilename = new System.Windows.Forms.Label();
            labelEnterRecordName = new System.Windows.Forms.Label();
            tboxFieldName = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            checkBoxRecordAddTime = new System.Windows.Forms.CheckBox();
            buttonSave = new System.Windows.Forms.Button();
            checkBoxRecordAddDate = new System.Windows.Forms.CheckBox();
            buttonRecordCancel = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // labelFilename
            // 
            labelFilename.AutoSize = true;
            labelFilename.BackColor = System.Drawing.Color.Transparent;
            labelFilename.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelFilename.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            labelFilename.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            labelFilename.Location = new System.Drawing.Point(31, 86);
            labelFilename.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelFilename.Name = "labelFilename";
            labelFilename.Size = new System.Drawing.Size(83, 19);
            labelFilename.TabIndex = 153;
            labelFilename.Text = "Filename";
            // 
            // labelEnterRecordName
            // 
            labelEnterRecordName.AutoSize = true;
            labelEnterRecordName.BackColor = System.Drawing.Color.Transparent;
            labelEnterRecordName.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelEnterRecordName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            labelEnterRecordName.Location = new System.Drawing.Point(31, 22);
            labelEnterRecordName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelEnterRecordName.Name = "labelEnterRecordName";
            labelEnterRecordName.Size = new System.Drawing.Size(175, 23);
            labelEnterRecordName.TabIndex = 152;
            labelEnterRecordName.Text = "Enter Record Name";
            // 
            // tboxFieldName
            // 
            tboxFieldName.BackColor = System.Drawing.Color.AliceBlue;
            tboxFieldName.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            tboxFieldName.Location = new System.Drawing.Point(24, 45);
            tboxFieldName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            tboxFieldName.Name = "tboxFieldName";
            tboxFieldName.Size = new System.Drawing.Size(634, 36);
            tboxFieldName.TabIndex = 151;
            tboxFieldName.Click += tboxFieldName_Click;
            tboxFieldName.TextChanged += tboxFieldName_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.Transparent;
            label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label4.Location = new System.Drawing.Point(188, 166);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(24, 23);
            label4.TabIndex = 150;
            label4.Text = "+";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.Transparent;
            label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label5.Location = new System.Drawing.Point(31, 166);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(24, 23);
            label5.TabIndex = 149;
            label5.Text = "+";
            // 
            // checkBoxRecordAddTime
            // 
            checkBoxRecordAddTime.Appearance = System.Windows.Forms.Appearance.Button;
            checkBoxRecordAddTime.BackColor = System.Drawing.Color.Transparent;
            checkBoxRecordAddTime.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            checkBoxRecordAddTime.FlatAppearance.CheckedBackColor = System.Drawing.Color.MediumAquamarine;
            checkBoxRecordAddTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            checkBoxRecordAddTime.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            checkBoxRecordAddTime.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            checkBoxRecordAddTime.Image = Properties.Resources.JobNameTime;
            checkBoxRecordAddTime.Location = new System.Drawing.Point(219, 142);
            checkBoxRecordAddTime.Name = "checkBoxRecordAddTime";
            checkBoxRecordAddTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            checkBoxRecordAddTime.Size = new System.Drawing.Size(86, 70);
            checkBoxRecordAddTime.TabIndex = 2;
            checkBoxRecordAddTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            checkBoxRecordAddTime.UseVisualStyleBackColor = false;
            // 
            // buttonSave
            // 
            buttonSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            buttonSave.BackColor = System.Drawing.Color.Transparent;
            buttonSave.FlatAppearance.BorderSize = 0;
            buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            buttonSave.Image = Properties.Resources.OK64;
            buttonSave.Location = new System.Drawing.Point(579, 144);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new System.Drawing.Size(83, 79);
            buttonSave.TabIndex = 3;
            buttonSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // checkBoxRecordAddDate
            // 
            checkBoxRecordAddDate.Appearance = System.Windows.Forms.Appearance.Button;
            checkBoxRecordAddDate.BackColor = System.Drawing.Color.Transparent;
            checkBoxRecordAddDate.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            checkBoxRecordAddDate.FlatAppearance.CheckedBackColor = System.Drawing.Color.MediumAquamarine;
            checkBoxRecordAddDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            checkBoxRecordAddDate.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            checkBoxRecordAddDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            checkBoxRecordAddDate.Image = Properties.Resources.JobNameCalendar;
            checkBoxRecordAddDate.Location = new System.Drawing.Point(62, 142);
            checkBoxRecordAddDate.Name = "checkBoxRecordAddDate";
            checkBoxRecordAddDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            checkBoxRecordAddDate.Size = new System.Drawing.Size(86, 70);
            checkBoxRecordAddDate.TabIndex = 1;
            checkBoxRecordAddDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            checkBoxRecordAddDate.UseVisualStyleBackColor = false;
            // 
            // buttonRecordCancel
            // 
            buttonRecordCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            buttonRecordCancel.BackColor = System.Drawing.Color.Transparent;
            buttonRecordCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            buttonRecordCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            buttonRecordCancel.FlatAppearance.BorderSize = 0;
            buttonRecordCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonRecordCancel.Font = new System.Drawing.Font("Tahoma", 12F);
            buttonRecordCancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            buttonRecordCancel.Image = Properties.Resources.Cancel64;
            buttonRecordCancel.Location = new System.Drawing.Point(458, 143);
            buttonRecordCancel.Name = "buttonRecordCancel";
            buttonRecordCancel.Size = new System.Drawing.Size(77, 79);
            buttonRecordCancel.TabIndex = 4;
            buttonRecordCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            buttonRecordCancel.UseVisualStyleBackColor = false;
            buttonRecordCancel.Click += buttonRecordCancel_Click;
            // 
            // FormRecordName
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            BackColor = System.Drawing.Color.Gainsboro;
            ClientSize = new System.Drawing.Size(676, 234);
            ControlBox = false;
            Controls.Add(labelFilename);
            Controls.Add(label4);
            Controls.Add(labelEnterRecordName);
            Controls.Add(tboxFieldName);
            Controls.Add(label5);
            Controls.Add(checkBoxRecordAddTime);
            Controls.Add(buttonRecordCancel);
            Controls.Add(buttonSave);
            Controls.Add(checkBoxRecordAddDate);
            Font = new System.Drawing.Font("Tahoma", 14.25F);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(5);
            Name = "FormRecordName";
            Padding = new System.Windows.Forms.Padding(2);
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Create New Record";
            Load += FormRecordName_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelFilename;
        private System.Windows.Forms.Label labelEnterRecordName;
        private System.Windows.Forms.TextBox tboxFieldName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBoxRecordAddTime;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.CheckBox checkBoxRecordAddDate;
        private System.Windows.Forms.Button buttonRecordCancel;
    }
}
namespace AgOpenGPS
{
    partial class FormFieldIsoXml
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
            labelFieldname = new System.Windows.Forms.Label();
            btnSerialCancel = new System.Windows.Forms.Button();
            labelField = new System.Windows.Forms.Label();
            tboxFieldName = new System.Windows.Forms.TextBox();
            btnBuildFields = new System.Windows.Forms.Button();
            tree = new System.Windows.Forms.TreeView();
            btnAddDate = new System.Windows.Forms.Button();
            btnAddTime = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // labelFieldname
            // 
            labelFieldname.BackColor = System.Drawing.Color.Transparent;
            labelFieldname.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelFieldname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            labelFieldname.Location = new System.Drawing.Point(6, 54);
            labelFieldname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelFieldname.Name = "labelFieldname";
            labelFieldname.Size = new System.Drawing.Size(296, 23);
            labelFieldname.TabIndex = 4;
            labelFieldname.Text = "Field Name";
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
            btnSerialCancel.Location = new System.Drawing.Point(524, 303);
            btnSerialCancel.Name = "btnSerialCancel";
            btnSerialCancel.Size = new System.Drawing.Size(83, 79);
            btnSerialCancel.TabIndex = 4;
            btnSerialCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnSerialCancel.UseVisualStyleBackColor = false;
            btnSerialCancel.Click += btnSerialCancel_Click;
            // 
            // labelField
            // 
            labelField.AutoSize = true;
            labelField.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelField.Location = new System.Drawing.Point(5, 140);
            labelField.Name = "labelField";
            labelField.Size = new System.Drawing.Size(119, 25);
            labelField.TabIndex = 155;
            labelField.Text = "Fieldname";
            // 
            // tboxFieldName
            // 
            tboxFieldName.Enabled = false;
            tboxFieldName.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            tboxFieldName.Location = new System.Drawing.Point(5, 15);
            tboxFieldName.Name = "tboxFieldName";
            tboxFieldName.Size = new System.Drawing.Size(602, 33);
            tboxFieldName.TabIndex = 156;
            tboxFieldName.Click += tboxFieldName_Click;
            tboxFieldName.TextChanged += tboxFieldName_TextChanged;
            // 
            // btnBuildFields
            // 
            btnBuildFields.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnBuildFields.BackColor = System.Drawing.Color.Transparent;
            btnBuildFields.Enabled = false;
            btnBuildFields.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            btnBuildFields.FlatAppearance.BorderSize = 0;
            btnBuildFields.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBuildFields.ForeColor = System.Drawing.SystemColors.ButtonFace;
            btnBuildFields.Image = Properties.Resources.FileSave;
            btnBuildFields.Location = new System.Drawing.Point(524, 414);
            btnBuildFields.Name = "btnBuildFields";
            btnBuildFields.Size = new System.Drawing.Size(83, 79);
            btnBuildFields.TabIndex = 158;
            btnBuildFields.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnBuildFields.UseVisualStyleBackColor = false;
            btnBuildFields.Click += btnBuildFields_Click;
            // 
            // tree
            // 
            tree.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tree.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            tree.Location = new System.Drawing.Point(7, 166);
            tree.Name = "tree";
            tree.Size = new System.Drawing.Size(499, 328);
            tree.TabIndex = 161;
            tree.AfterSelect += tree_AfterSelect;
            // 
            // btnAddDate
            // 
            btnAddDate.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnAddDate.BackColor = System.Drawing.Color.Transparent;
            btnAddDate.Enabled = false;
            btnAddDate.FlatAppearance.BorderSize = 0;
            btnAddDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAddDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            btnAddDate.Image = Properties.Resources.JobNameCalendar;
            btnAddDate.Location = new System.Drawing.Point(358, 54);
            btnAddDate.Name = "btnAddDate";
            btnAddDate.Size = new System.Drawing.Size(83, 66);
            btnAddDate.TabIndex = 163;
            btnAddDate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnAddDate.UseVisualStyleBackColor = false;
            btnAddDate.Click += btnAddDate_Click;
            // 
            // btnAddTime
            // 
            btnAddTime.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnAddTime.BackColor = System.Drawing.Color.Transparent;
            btnAddTime.Enabled = false;
            btnAddTime.FlatAppearance.BorderSize = 0;
            btnAddTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAddTime.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            btnAddTime.Image = Properties.Resources.JobNameTime;
            btnAddTime.Location = new System.Drawing.Point(524, 54);
            btnAddTime.Name = "btnAddTime";
            btnAddTime.Size = new System.Drawing.Size(83, 66);
            btnAddTime.TabIndex = 162;
            btnAddTime.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnAddTime.UseVisualStyleBackColor = false;
            btnAddTime.Click += btnAddTime_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label2.Location = new System.Drawing.Point(336, 76);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(24, 23);
            label2.TabIndex = 164;
            label2.Text = "+";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label3.Location = new System.Drawing.Point(506, 76);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(24, 23);
            label3.TabIndex = 165;
            label3.Text = "+";
            // 
            // FormFieldIsoXml
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            BackColor = System.Drawing.Color.Gainsboro;
            ClientSize = new System.Drawing.Size(614, 524);
            ControlBox = false;
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnAddDate);
            Controls.Add(btnAddTime);
            Controls.Add(tree);
            Controls.Add(btnBuildFields);
            Controls.Add(tboxFieldName);
            Controls.Add(labelField);
            Controls.Add(labelFieldname);
            Controls.Add(btnSerialCancel);
            Font = new System.Drawing.Font("Tahoma", 14.25F);
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            MinimumSize = new System.Drawing.Size(630, 540);
            Name = "FormFieldIsoXml";
            Padding = new System.Windows.Forms.Padding(2);
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Create New Field From ISO-XML";
            Load += FormFieldIsoXml_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSerialCancel;
        private System.Windows.Forms.Label labelFieldname;
        private System.Windows.Forms.Label labelField;
        private System.Windows.Forms.TextBox tboxFieldName;
        private System.Windows.Forms.Button btnBuildFields;
        private System.Windows.Forms.TreeView tree;
        private System.Windows.Forms.Button btnAddDate;
        private System.Windows.Forms.Button btnAddTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
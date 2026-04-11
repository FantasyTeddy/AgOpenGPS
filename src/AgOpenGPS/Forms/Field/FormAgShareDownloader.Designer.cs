namespace AgOpenGPS.Forms.Field
{
    partial class FormAgShareDownloader
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
            lbFields = new System.Windows.Forms.ListView();
            chName = new System.Windows.Forms.ColumnHeader();
            glControl1 = new OpenTK.GLControl.GLControl();
            lblSelectedField = new System.Windows.Forms.Label();
            progressBarDownloadAll = new System.Windows.Forms.ProgressBar();
            chkForceOverwrite = new System.Windows.Forms.CheckBox();
            btnGetSelected = new System.Windows.Forms.Button();
            btnClose = new System.Windows.Forms.Button();
            btnSaveAll = new System.Windows.Forms.Button();
            lblDownloading = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // lbFields
            // 
            lbFields.BackColor = System.Drawing.Color.LightGreen;
            lbFields.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { chName });
            lbFields.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lbFields.FullRowSelect = true;
            lbFields.GridLines = true;
            lbFields.ImeMode = System.Windows.Forms.ImeMode.Off;
            lbFields.Location = new System.Drawing.Point(14, 14);
            lbFields.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            lbFields.MultiSelect = false;
            lbFields.Name = "lbFields";
            lbFields.Size = new System.Drawing.Size(573, 654);
            lbFields.Sorting = System.Windows.Forms.SortOrder.Ascending;
            lbFields.TabIndex = 1;
            lbFields.UseCompatibleStateImageBehavior = false;
            lbFields.View = System.Windows.Forms.View.Details;
            lbFields.SelectedIndexChanged += lbFields_SelectedIndexChanged;
            // 
            // chName
            // 
            chName.Text = "Field";
            chName.Width = 480;
            // 
            // glControl1
            // 
            glControl1.API = OpenTK.Windowing.Common.ContextAPI.OpenGL;
            glControl1.APIVersion = new System.Version(3, 3, 0, 0);
            glControl1.BackColor = System.Drawing.Color.DarkGray;
            glControl1.Flags = OpenTK.Windowing.Common.ContextFlags.Default;
            glControl1.IsEventDriven = true;
            glControl1.Location = new System.Drawing.Point(595, 14);
            glControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            glControl1.Name = "glControl1";
            glControl1.Profile = OpenTK.Windowing.Common.ContextProfile.Compatability;
            glControl1.SharedContext = null;
            glControl1.Size = new System.Drawing.Size(763, 654);
            glControl1.TabIndex = 3;
            glControl1.Load += glControl1_Load;
            // 
            // lblSelectedField
            // 
            lblSelectedField.AutoEllipsis = true;
            lblSelectedField.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblSelectedField.Location = new System.Drawing.Point(14, 683);
            lblSelectedField.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblSelectedField.Name = "lblSelectedField";
            lblSelectedField.Size = new System.Drawing.Size(537, 29);
            lblSelectedField.TabIndex = 5;
            lblSelectedField.Text = "Selected Field:";
            // 
            // progressBarDownloadAll
            // 
            progressBarDownloadAll.Location = new System.Drawing.Point(797, 725);
            progressBarDownloadAll.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            progressBarDownloadAll.Name = "progressBarDownloadAll";
            progressBarDownloadAll.Size = new System.Drawing.Size(337, 27);
            progressBarDownloadAll.TabIndex = 7;
            // 
            // chkForceOverwrite
            // 
            chkForceOverwrite.Appearance = System.Windows.Forms.Appearance.Button;
            chkForceOverwrite.BackColor = System.Drawing.Color.Transparent;
            chkForceOverwrite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            chkForceOverwrite.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            chkForceOverwrite.FlatAppearance.BorderSize = 0;
            chkForceOverwrite.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSalmon;
            chkForceOverwrite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            chkForceOverwrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            chkForceOverwrite.Image = Properties.Resources.ForceOverwrite;
            chkForceOverwrite.Location = new System.Drawing.Point(562, 675);
            chkForceOverwrite.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chkForceOverwrite.Name = "chkForceOverwrite";
            chkForceOverwrite.Size = new System.Drawing.Size(107, 121);
            chkForceOverwrite.TabIndex = 8;
            chkForceOverwrite.Text = "Overwrite";
            chkForceOverwrite.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            chkForceOverwrite.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            chkForceOverwrite.UseVisualStyleBackColor = false;
            // 
            // btnGetSelected
            // 
            btnGetSelected.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnGetSelected.FlatAppearance.BorderSize = 0;
            btnGetSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnGetSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnGetSelected.Image = Properties.Resources.DownloadAndUse;
            btnGetSelected.Location = new System.Drawing.Point(1141, 675);
            btnGetSelected.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnGetSelected.Name = "btnGetSelected";
            btnGetSelected.Size = new System.Drawing.Size(97, 121);
            btnGetSelected.TabIndex = 6;
            btnGetSelected.Text = "Get Selected";
            btnGetSelected.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnGetSelected.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnGetSelected.UseVisualStyleBackColor = true;
            btnGetSelected.Click += btnOpen_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClose.Image = Properties.Resources.OK64;
            btnClose.Location = new System.Drawing.Point(1245, 688);
            btnClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(97, 97);
            btnClose.TabIndex = 4;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnSaveAll
            // 
            btnSaveAll.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnSaveAll.FlatAppearance.BorderSize = 0;
            btnSaveAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSaveAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnSaveAll.Image = Properties.Resources.DownloadAll;
            btnSaveAll.Location = new System.Drawing.Point(680, 675);
            btnSaveAll.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSaveAll.Name = "btnSaveAll";
            btnSaveAll.Size = new System.Drawing.Size(110, 121);
            btnSaveAll.TabIndex = 2;
            btnSaveAll.Text = "Get All";
            btnSaveAll.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnSaveAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnSaveAll.UseVisualStyleBackColor = true;
            btnSaveAll.Click += BtnDownloadAll_Click;
            // 
            // lblDownloading
            // 
            lblDownloading.AutoSize = true;
            lblDownloading.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblDownloading.Location = new System.Drawing.Point(791, 683);
            lblDownloading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDownloading.Name = "lblDownloading";
            lblDownloading.Size = new System.Drawing.Size(259, 24);
            lblDownloading.TabIndex = 9;
            lblDownloading.Text = "Downloading...Please Wait";
            // 
            // FormAgShareDownloader
            // 
            AllowDrop = true;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            ClientSize = new System.Drawing.Size(1345, 795);
            ControlBox = false;
            Controls.Add(lblDownloading);
            Controls.Add(chkForceOverwrite);
            Controls.Add(progressBarDownloadAll);
            Controls.Add(btnGetSelected);
            Controls.Add(lblSelectedField);
            Controls.Add(btnClose);
            Controls.Add(glControl1);
            Controls.Add(btnSaveAll);
            Controls.Add(lbFields);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            ImeMode = System.Windows.Forms.ImeMode.Disable;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAgShareDownloader";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Download Fields From AgShare";
            Load += FormAgShareDownloader_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lbFields;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.Button btnSaveAll;
        private OpenTK.GLControl.GLControl glControl1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblSelectedField;
        private System.Windows.Forms.Button btnGetSelected;
        private System.Windows.Forms.ProgressBar progressBarDownloadAll;
        private System.Windows.Forms.CheckBox chkForceOverwrite;
        private System.Windows.Forms.Label lblDownloading;
    }
}
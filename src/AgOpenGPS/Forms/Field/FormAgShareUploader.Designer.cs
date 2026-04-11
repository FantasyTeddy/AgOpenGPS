namespace AgOpenGPS.Forms
{
    partial class FormAgShareUploader
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
            panel1 = new System.Windows.Forms.Panel();
            btnClose = new System.Windows.Forms.Button();
            btnUpload = new System.Windows.Forms.Button();
            btnDeselectAll = new System.Windows.Forms.Button();
            btnSelectAll = new System.Windows.Forms.Button();
            lblStatus = new System.Windows.Forms.Label();
            progressBar = new System.Windows.Forms.ProgressBar();
            flpFieldList = new System.Windows.Forms.FlowLayoutPanel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.LightGray;
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(btnUpload);
            panel1.Controls.Add(btnDeselectAll);
            panel1.Controls.Add(btnSelectAll);
            panel1.Controls.Add(lblStatus);
            panel1.Controls.Add(progressBar);
            panel1.Controls.Add(flpFieldList);
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(12, 12);
            panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1143, 853);
            panel1.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.BackColor = System.Drawing.Color.Transparent;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClose.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnClose.Image = Properties.Resources.OK64;
            btnClose.Location = new System.Drawing.Point(915, 662);
            btnClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(198, 106);
            btnClose.TabIndex = 8;
            btnClose.Text = "Close";
            btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnUpload
            // 
            btnUpload.BackColor = System.Drawing.Color.Transparent;
            btnUpload.FlatAppearance.BorderSize = 0;
            btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnUpload.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnUpload.Image = Properties.Resources.SaveToCloud;
            btnUpload.Location = new System.Drawing.Point(698, 662);
            btnUpload.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new System.Drawing.Size(210, 106);
            btnUpload.TabIndex = 7;
            btnUpload.Text = "Upload Selected";
            btnUpload.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnUpload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnUpload.UseVisualStyleBackColor = false;
            btnUpload.Click += btnUpload_Click;
            // 
            // btnDeselectAll
            // 
            btnDeselectAll.BackColor = System.Drawing.Color.Transparent;
            btnDeselectAll.FlatAppearance.BorderSize = 0;
            btnDeselectAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDeselectAll.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnDeselectAll.Image = Properties.Resources.DeselectAll;
            btnDeselectAll.Location = new System.Drawing.Point(247, 646);
            btnDeselectAll.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnDeselectAll.Name = "btnDeselectAll";
            btnDeselectAll.Size = new System.Drawing.Size(138, 105);
            btnDeselectAll.TabIndex = 6;
            btnDeselectAll.Text = "Deselect All";
            btnDeselectAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnDeselectAll.UseVisualStyleBackColor = false;
            btnDeselectAll.Click += btnDeselectAll_Click;
            // 
            // btnSelectAll
            // 
            btnSelectAll.BackColor = System.Drawing.Color.Transparent;
            btnSelectAll.FlatAppearance.BorderSize = 0;
            btnSelectAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSelectAll.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnSelectAll.Image = Properties.Resources.SelectAll;
            btnSelectAll.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnSelectAll.Location = new System.Drawing.Point(51, 646);
            btnSelectAll.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSelectAll.Name = "btnSelectAll";
            btnSelectAll.Size = new System.Drawing.Size(138, 105);
            btnSelectAll.TabIndex = 5;
            btnSelectAll.Text = "Select All";
            btnSelectAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnSelectAll.UseVisualStyleBackColor = false;
            btnSelectAll.Click += btnSelectAll_Click;
            // 
            // lblStatus
            // 
            lblStatus.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblStatus.Location = new System.Drawing.Point(23, 755);
            lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new System.Drawing.Size(863, 29);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "Ready";
            lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // progressBar
            // 
            progressBar.Location = new System.Drawing.Point(23, 789);
            progressBar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            progressBar.Name = "progressBar";
            progressBar.Size = new System.Drawing.Size(863, 46);
            progressBar.TabIndex = 3;
            // 
            // flpFieldList
            // 
            flpFieldList.AutoScroll = true;
            flpFieldList.BackColor = System.Drawing.Color.LightGreen;
            flpFieldList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            flpFieldList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flpFieldList.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            flpFieldList.Location = new System.Drawing.Point(23, 22);
            flpFieldList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            flpFieldList.Name = "flpFieldList";
            flpFieldList.Size = new System.Drawing.Size(1089, 617);
            flpFieldList.TabIndex = 1;
            flpFieldList.WrapContents = false;
            // 
            // FormAgShareUploader
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Gainsboro;
            ClientSize = new System.Drawing.Size(1167, 877);
            ControlBox = false;
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "FormAgShareUploader";
            Padding = new System.Windows.Forms.Padding(12, 12, 12, 12);
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "AgShare Upload";
            Load += FormAgShareBulkUploader_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flpFieldList;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.Button btnDeselectAll;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnClose;
    }
}

namespace AgOpenGPS
{
    partial class FormJob
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
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            btnAgShareBulkUpload = new System.Windows.Forms.Button();
            btnJobAgShare = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            btnFromKML = new System.Windows.Forms.Button();
            btnFromISOXML = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            btnJobOpen = new System.Windows.Forms.Button();
            btnJobClose = new System.Windows.Forms.Button();
            btnInField = new System.Windows.Forms.Button();
            btnJobResume = new System.Windows.Forms.Button();
            btnFromExisting = new System.Windows.Forms.Button();
            btnJobNew = new System.Windows.Forms.Button();
            lblResumeField = new System.Windows.Forms.Label();
            btnDeleteAB = new System.Windows.Forms.Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tableLayoutPanel1.BackColor = System.Drawing.Color.Gainsboro;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btnAgShareBulkUpload, 2, 4);
            tableLayoutPanel1.Controls.Add(btnJobAgShare, 0, 4);
            tableLayoutPanel1.Controls.Add(label4, 1, 3);
            tableLayoutPanel1.Controls.Add(label3, 1, 2);
            tableLayoutPanel1.Controls.Add(label2, 1, 1);
            tableLayoutPanel1.Controls.Add(btnFromKML, 0, 1);
            tableLayoutPanel1.Controls.Add(btnFromISOXML, 0, 0);
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Controls.Add(btnJobOpen, 2, 2);
            tableLayoutPanel1.Controls.Add(btnJobClose, 2, 0);
            tableLayoutPanel1.Controls.Add(btnInField, 2, 1);
            tableLayoutPanel1.Controls.Add(btnJobResume, 2, 3);
            tableLayoutPanel1.Controls.Add(btnFromExisting, 0, 2);
            tableLayoutPanel1.Controls.Add(btnJobNew, 0, 3);
            tableLayoutPanel1.Location = new System.Drawing.Point(9, 7);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new System.Drawing.Size(605, 469);
            tableLayoutPanel1.TabIndex = 106;
            // 
            // btnAgShareBulkUpload
            // 
            btnAgShareBulkUpload.BackColor = System.Drawing.Color.FromArgb(240, 248, 255);
            btnAgShareBulkUpload.Cursor = System.Windows.Forms.Cursors.Hand;
            btnAgShareBulkUpload.Dock = System.Windows.Forms.DockStyle.Fill;
            btnAgShareBulkUpload.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(100, 149, 237);
            btnAgShareBulkUpload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(227, 242, 253);
            btnAgShareBulkUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAgShareBulkUpload.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnAgShareBulkUpload.ForeColor = System.Drawing.Color.Black;
            btnAgShareBulkUpload.Image = Properties.Resources.AgShare;
            btnAgShareBulkUpload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnAgShareBulkUpload.Location = new System.Drawing.Point(320, 377);
            btnAgShareBulkUpload.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            btnAgShareBulkUpload.Name = "btnAgShareBulkUpload";
            btnAgShareBulkUpload.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            btnAgShareBulkUpload.Size = new System.Drawing.Size(279, 87);
            btnAgShareBulkUpload.TabIndex = 114;
            btnAgShareBulkUpload.Text = "AgShare Upload";
            btnAgShareBulkUpload.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnAgShareBulkUpload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnAgShareBulkUpload.UseVisualStyleBackColor = false;
            btnAgShareBulkUpload.Click += btnAgShareBulkUpload_Click;
            // 
            // btnJobAgShare
            // 
            btnJobAgShare.BackColor = System.Drawing.Color.FromArgb(240, 248, 255);
            btnJobAgShare.Cursor = System.Windows.Forms.Cursors.Hand;
            btnJobAgShare.Dock = System.Windows.Forms.DockStyle.Fill;
            btnJobAgShare.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(100, 149, 237);
            btnJobAgShare.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(227, 242, 253);
            btnJobAgShare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnJobAgShare.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnJobAgShare.ForeColor = System.Drawing.Color.Black;
            btnJobAgShare.Image = Properties.Resources.AgShare;
            btnJobAgShare.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnJobAgShare.Location = new System.Drawing.Point(6, 377);
            btnJobAgShare.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            btnJobAgShare.Name = "btnJobAgShare";
            btnJobAgShare.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            btnJobAgShare.Size = new System.Drawing.Size(279, 87);
            btnJobAgShare.TabIndex = 112;
            btnJobAgShare.Text = "AgShare Download";
            btnJobAgShare.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnJobAgShare.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnJobAgShare.UseVisualStyleBackColor = false;
            btnJobAgShare.Click += btnJobAgShare_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.Gainsboro;
            label4.Dock = System.Windows.Forms.DockStyle.Fill;
            label4.Location = new System.Drawing.Point(294, 279);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(17, 93);
            label4.TabIndex = 111;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Gainsboro;
            label3.Dock = System.Windows.Forms.DockStyle.Fill;
            label3.Location = new System.Drawing.Point(294, 186);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(17, 93);
            label3.TabIndex = 110;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Gainsboro;
            label2.Dock = System.Windows.Forms.DockStyle.Fill;
            label2.Location = new System.Drawing.Point(294, 93);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(17, 93);
            label2.TabIndex = 109;
            // 
            // btnFromKML
            // 
            btnFromKML.BackColor = System.Drawing.Color.FromArgb(240, 248, 255);
            btnFromKML.Cursor = System.Windows.Forms.Cursors.Hand;
            btnFromKML.Dock = System.Windows.Forms.DockStyle.Fill;
            btnFromKML.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(100, 149, 237);
            btnFromKML.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(227, 242, 253);
            btnFromKML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnFromKML.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnFromKML.ForeColor = System.Drawing.Color.Black;
            btnFromKML.Image = Properties.Resources.BoundaryLoadFromGE;
            btnFromKML.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnFromKML.Location = new System.Drawing.Point(6, 98);
            btnFromKML.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            btnFromKML.Name = "btnFromKML";
            btnFromKML.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            btnFromKML.Size = new System.Drawing.Size(279, 83);
            btnFromKML.TabIndex = 91;
            btnFromKML.Text = "From KML";
            btnFromKML.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnFromKML.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnFromKML.UseVisualStyleBackColor = false;
            btnFromKML.Click += btnFromKML_Click;
            // 
            // btnFromISOXML
            // 
            btnFromISOXML.BackColor = System.Drawing.Color.FromArgb(240, 248, 255);
            btnFromISOXML.Cursor = System.Windows.Forms.Cursors.Hand;
            btnFromISOXML.Dock = System.Windows.Forms.DockStyle.Fill;
            btnFromISOXML.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(100, 149, 237);
            btnFromISOXML.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(227, 242, 253);
            btnFromISOXML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnFromISOXML.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnFromISOXML.ForeColor = System.Drawing.Color.Black;
            btnFromISOXML.Image = Properties.Resources.ISOXML;
            btnFromISOXML.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnFromISOXML.Location = new System.Drawing.Point(6, 5);
            btnFromISOXML.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            btnFromISOXML.Name = "btnFromISOXML";
            btnFromISOXML.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            btnFromISOXML.Size = new System.Drawing.Size(279, 83);
            btnFromISOXML.TabIndex = 107;
            btnFromISOXML.Text = "ISO-XML";
            btnFromISOXML.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnFromISOXML.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnFromISOXML.UseVisualStyleBackColor = false;
            btnFromISOXML.Click += btnFromISOXML_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Gainsboro;
            label1.Dock = System.Windows.Forms.DockStyle.Fill;
            label1.Location = new System.Drawing.Point(294, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(17, 93);
            label1.TabIndex = 108;
            // 
            // btnJobOpen
            // 
            btnJobOpen.BackColor = System.Drawing.Color.FromArgb(240, 248, 255);
            btnJobOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            btnJobOpen.Dock = System.Windows.Forms.DockStyle.Fill;
            btnJobOpen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(100, 149, 237);
            btnJobOpen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(227, 242, 253);
            btnJobOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnJobOpen.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnJobOpen.ForeColor = System.Drawing.Color.Black;
            btnJobOpen.Image = Properties.Resources.FileOpen;
            btnJobOpen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnJobOpen.Location = new System.Drawing.Point(320, 191);
            btnJobOpen.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            btnJobOpen.Name = "btnJobOpen";
            btnJobOpen.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            btnJobOpen.Size = new System.Drawing.Size(279, 83);
            btnJobOpen.TabIndex = 3;
            btnJobOpen.Text = "Open";
            btnJobOpen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnJobOpen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnJobOpen.UseVisualStyleBackColor = false;
            btnJobOpen.Click += btnJobOpen_Click;
            // 
            // btnJobClose
            // 
            btnJobClose.AllowDrop = true;
            btnJobClose.BackColor = System.Drawing.Color.FromArgb(240, 248, 255);
            btnJobClose.Cursor = System.Windows.Forms.Cursors.Hand;
            btnJobClose.Dock = System.Windows.Forms.DockStyle.Fill;
            btnJobClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(100, 149, 237);
            btnJobClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(227, 242, 253);
            btnJobClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnJobClose.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnJobClose.ForeColor = System.Drawing.Color.Black;
            btnJobClose.Image = Properties.Resources.FileClose;
            btnJobClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnJobClose.Location = new System.Drawing.Point(320, 5);
            btnJobClose.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            btnJobClose.Name = "btnJobClose";
            btnJobClose.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            btnJobClose.Size = new System.Drawing.Size(279, 83);
            btnJobClose.TabIndex = 105;
            btnJobClose.Text = "Close";
            btnJobClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnJobClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnJobClose.UseVisualStyleBackColor = false;
            btnJobClose.Click += btnJobClose_Click;
            // 
            // btnInField
            // 
            btnInField.BackColor = System.Drawing.Color.FromArgb(240, 248, 255);
            btnInField.Cursor = System.Windows.Forms.Cursors.Hand;
            btnInField.Dock = System.Windows.Forms.DockStyle.Fill;
            btnInField.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(100, 149, 237);
            btnInField.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(227, 242, 253);
            btnInField.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnInField.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnInField.ForeColor = System.Drawing.Color.Black;
            btnInField.Image = Properties.Resources.AutoManualIsAuto;
            btnInField.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnInField.Location = new System.Drawing.Point(320, 98);
            btnInField.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            btnInField.Name = "btnInField";
            btnInField.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            btnInField.Size = new System.Drawing.Size(279, 83);
            btnInField.TabIndex = 89;
            btnInField.Text = "Drive In";
            btnInField.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnInField.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnInField.UseVisualStyleBackColor = false;
            btnInField.Click += btnInField_Click;
            // 
            // btnJobResume
            // 
            btnJobResume.BackColor = System.Drawing.Color.FromArgb(240, 248, 255);
            btnJobResume.Cursor = System.Windows.Forms.Cursors.Hand;
            btnJobResume.Dock = System.Windows.Forms.DockStyle.Fill;
            btnJobResume.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(100, 149, 237);
            btnJobResume.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(227, 242, 253);
            btnJobResume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnJobResume.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnJobResume.ForeColor = System.Drawing.Color.Black;
            btnJobResume.Image = Properties.Resources.FilePrevious;
            btnJobResume.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnJobResume.Location = new System.Drawing.Point(320, 284);
            btnJobResume.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            btnJobResume.Name = "btnJobResume";
            btnJobResume.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            btnJobResume.Size = new System.Drawing.Size(279, 83);
            btnJobResume.TabIndex = 1;
            btnJobResume.Text = "Resume";
            btnJobResume.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnJobResume.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnJobResume.UseVisualStyleBackColor = false;
            btnJobResume.Click += btnJobResume_Click;
            // 
            // btnFromExisting
            // 
            btnFromExisting.BackColor = System.Drawing.Color.FromArgb(240, 248, 255);
            btnFromExisting.Cursor = System.Windows.Forms.Cursors.Hand;
            btnFromExisting.Dock = System.Windows.Forms.DockStyle.Fill;
            btnFromExisting.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(100, 149, 237);
            btnFromExisting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(227, 242, 253);
            btnFromExisting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnFromExisting.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnFromExisting.ForeColor = System.Drawing.Color.Black;
            btnFromExisting.Image = Properties.Resources.FileExisting;
            btnFromExisting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnFromExisting.Location = new System.Drawing.Point(6, 191);
            btnFromExisting.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            btnFromExisting.Name = "btnFromExisting";
            btnFromExisting.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            btnFromExisting.Size = new System.Drawing.Size(279, 83);
            btnFromExisting.TabIndex = 104;
            btnFromExisting.Text = "Existing";
            btnFromExisting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnFromExisting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnFromExisting.UseVisualStyleBackColor = false;
            btnFromExisting.Click += btnFromExisting_Click;
            // 
            // btnJobNew
            // 
            btnJobNew.BackColor = System.Drawing.Color.FromArgb(240, 248, 255);
            btnJobNew.Cursor = System.Windows.Forms.Cursors.Hand;
            btnJobNew.Dock = System.Windows.Forms.DockStyle.Fill;
            btnJobNew.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(100, 149, 237);
            btnJobNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(227, 242, 253);
            btnJobNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnJobNew.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnJobNew.ForeColor = System.Drawing.Color.Black;
            btnJobNew.Image = Properties.Resources.FileNew;
            btnJobNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnJobNew.Location = new System.Drawing.Point(6, 284);
            btnJobNew.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            btnJobNew.Name = "btnJobNew";
            btnJobNew.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            btnJobNew.Size = new System.Drawing.Size(279, 83);
            btnJobNew.TabIndex = 2;
            btnJobNew.Text = "New Field";
            btnJobNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnJobNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnJobNew.UseVisualStyleBackColor = false;
            btnJobNew.Click += btnJobNew_Click;
            // 
            // lblResumeField
            // 
            lblResumeField.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblResumeField.BackColor = System.Drawing.Color.Transparent;
            lblResumeField.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblResumeField.ForeColor = System.Drawing.Color.Black;
            lblResumeField.Location = new System.Drawing.Point(9, 508);
            lblResumeField.Name = "lblResumeField";
            lblResumeField.Size = new System.Drawing.Size(468, 28);
            lblResumeField.TabIndex = 106;
            lblResumeField.Text = "Previous Field";
            lblResumeField.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnDeleteAB
            // 
            btnDeleteAB.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnDeleteAB.BackColor = System.Drawing.Color.Transparent;
            btnDeleteAB.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnDeleteAB.FlatAppearance.BorderSize = 0;
            btnDeleteAB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDeleteAB.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            btnDeleteAB.ForeColor = System.Drawing.SystemColors.ButtonFace;
            btnDeleteAB.Image = Properties.Resources.Cancel64;
            btnDeleteAB.Location = new System.Drawing.Point(486, 495);
            btnDeleteAB.Name = "btnDeleteAB";
            btnDeleteAB.Size = new System.Drawing.Size(129, 57);
            btnDeleteAB.TabIndex = 4;
            btnDeleteAB.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnDeleteAB.UseVisualStyleBackColor = false;
            btnDeleteAB.Click += btnDeleteAB_Click;
            // 
            // FormJob
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            BackColor = System.Drawing.Color.Gainsboro;
            ClientSize = new System.Drawing.Size(638, 559);
            ControlBox = false;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(btnDeleteAB);
            Controls.Add(lblResumeField);
            Font = new System.Drawing.Font("Tahoma", 14.25F);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Location = new System.Drawing.Point(200, 200);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormJob";
            Padding = new System.Windows.Forms.Padding(4);
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            FormClosing += FormJob_FormClosing;
            Load += FormJob_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnJobOpen;
        private System.Windows.Forms.Button btnJobClose;
        private System.Windows.Forms.Button btnJobResume;
        private System.Windows.Forms.Label lblResumeField;
        private System.Windows.Forms.Button btnFromExisting;
        private System.Windows.Forms.Button btnJobNew;
        private System.Windows.Forms.Button btnInField;
        private System.Windows.Forms.Button btnFromKML;
        private System.Windows.Forms.Button btnFromISOXML;
        private System.Windows.Forms.Button btnDeleteAB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnJobAgShare;
        private System.Windows.Forms.Button btnAgShareBulkUpload;
    }
}
namespace AgOpenGPS.Forms.Field
{
    partial class FormCopyTracks
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
            lblTracksHeader = new System.Windows.Forms.Label();
            lblFieldsHeader = new System.Windows.Forms.Label();
            btnClose = new System.Windows.Forms.Button();
            btnCopyToCurrentField = new System.Windows.Forms.Button();
            btnDeselectAllTracks = new System.Windows.Forms.Button();
            btnSelectAllTracks = new System.Windows.Forms.Button();
            lblStatus = new System.Windows.Forms.Label();
            flpTrackList = new System.Windows.Forms.FlowLayoutPanel();
            lbFields = new System.Windows.Forms.ListView();
            chName = new System.Windows.Forms.ColumnHeader();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.LightGray;
            panel1.Controls.Add(lblTracksHeader);
            panel1.Controls.Add(lblFieldsHeader);
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(btnCopyToCurrentField);
            panel1.Controls.Add(btnDeselectAllTracks);
            panel1.Controls.Add(btnSelectAllTracks);
            panel1.Controls.Add(lblStatus);
            panel1.Controls.Add(flpTrackList);
            panel1.Controls.Add(lbFields);
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(12, 12);
            panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1376, 792);
            panel1.TabIndex = 0;
            // 
            // lblTracksHeader
            // 
            lblTracksHeader.AutoSize = true;
            lblTracksHeader.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblTracksHeader.Location = new System.Drawing.Point(712, 12);
            lblTracksHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTracksHeader.Name = "lblTracksHeader";
            lblTracksHeader.Size = new System.Drawing.Size(183, 25);
            lblTracksHeader.TabIndex = 13;
            lblTracksHeader.Text = "Available Tracks";
            // 
            // lblFieldsHeader
            // 
            lblFieldsHeader.AutoSize = true;
            lblFieldsHeader.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblFieldsHeader.Location = new System.Drawing.Point(29, 12);
            lblFieldsHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblFieldsHeader.Name = "lblFieldsHeader";
            lblFieldsHeader.Size = new System.Drawing.Size(173, 25);
            lblFieldsHeader.TabIndex = 12;
            lblFieldsHeader.Text = "Available Fields";
            // 
            // btnClose
            // 
            btnClose.BackColor = System.Drawing.Color.Transparent;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClose.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnClose.Image = Properties.Resources.OK64;
            btnClose.Location = new System.Drawing.Point(1213, 621);
            btnClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(140, 138);
            btnClose.TabIndex = 11;
            btnClose.Text = "Close";
            btnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnCopyToCurrentField
            // 
            btnCopyToCurrentField.BackColor = System.Drawing.Color.Transparent;
            btnCopyToCurrentField.FlatAppearance.BorderSize = 0;
            btnCopyToCurrentField.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCopyToCurrentField.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnCopyToCurrentField.Image = Properties.Resources.FileNew;
            btnCopyToCurrentField.Location = new System.Drawing.Point(1066, 621);
            btnCopyToCurrentField.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCopyToCurrentField.Name = "btnCopyToCurrentField";
            btnCopyToCurrentField.Size = new System.Drawing.Size(140, 138);
            btnCopyToCurrentField.TabIndex = 10;
            btnCopyToCurrentField.Text = "Copy To Current Field";
            btnCopyToCurrentField.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnCopyToCurrentField.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnCopyToCurrentField.UseVisualStyleBackColor = false;
            btnCopyToCurrentField.Click += btnCopyToCurrentField_Click;
            // 
            // btnDeselectAllTracks
            // 
            btnDeselectAllTracks.BackColor = System.Drawing.Color.Transparent;
            btnDeselectAllTracks.FlatAppearance.BorderSize = 0;
            btnDeselectAllTracks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDeselectAllTracks.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnDeselectAllTracks.Image = Properties.Resources.DeselectAll;
            btnDeselectAllTracks.Location = new System.Drawing.Point(866, 624);
            btnDeselectAllTracks.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnDeselectAllTracks.Name = "btnDeselectAllTracks";
            btnDeselectAllTracks.Size = new System.Drawing.Size(140, 138);
            btnDeselectAllTracks.TabIndex = 9;
            btnDeselectAllTracks.Text = "Deselect All";
            btnDeselectAllTracks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnDeselectAllTracks.UseVisualStyleBackColor = false;
            btnDeselectAllTracks.Click += btnDeselectAllTracks_Click;
            // 
            // btnSelectAllTracks
            // 
            btnSelectAllTracks.BackColor = System.Drawing.Color.Transparent;
            btnSelectAllTracks.FlatAppearance.BorderSize = 0;
            btnSelectAllTracks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSelectAllTracks.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnSelectAllTracks.Image = Properties.Resources.SelectAll;
            btnSelectAllTracks.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnSelectAllTracks.Location = new System.Drawing.Point(694, 632);
            btnSelectAllTracks.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSelectAllTracks.Name = "btnSelectAllTracks";
            btnSelectAllTracks.Size = new System.Drawing.Size(140, 138);
            btnSelectAllTracks.TabIndex = 8;
            btnSelectAllTracks.Text = "Select All";
            btnSelectAllTracks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnSelectAllTracks.UseVisualStyleBackColor = false;
            btnSelectAllTracks.Click += btnSelectAllTracks_Click;
            // 
            // lblStatus
            // 
            lblStatus.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblStatus.Location = new System.Drawing.Point(23, 750);
            lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new System.Drawing.Size(1330, 29);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "Select a field from the left, then select tracks to copy";
            lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flpTrackList
            // 
            flpTrackList.AutoScroll = true;
            flpTrackList.BackColor = System.Drawing.Color.LightYellow;
            flpTrackList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            flpTrackList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flpTrackList.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            flpTrackList.Location = new System.Drawing.Point(694, 52);
            flpTrackList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            flpTrackList.Name = "flpTrackList";
            flpTrackList.Size = new System.Drawing.Size(658, 565);
            flpTrackList.TabIndex = 2;
            flpTrackList.WrapContents = false;
            // 
            // lbFields
            // 
            lbFields.BackColor = System.Drawing.Color.WhiteSmoke;
            lbFields.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { chName });
            lbFields.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lbFields.FullRowSelect = true;
            lbFields.GridLines = true;
            lbFields.Location = new System.Drawing.Point(23, 52);
            lbFields.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            lbFields.MultiSelect = false;
            lbFields.Name = "lbFields";
            lbFields.Size = new System.Drawing.Size(658, 669);
            lbFields.Sorting = System.Windows.Forms.SortOrder.Ascending;
            lbFields.TabIndex = 1;
            lbFields.UseCompatibleStateImageBehavior = false;
            lbFields.View = System.Windows.Forms.View.Details;
            lbFields.SelectedIndexChanged += lbFields_SelectedIndexChanged;
            // 
            // chName
            // 
            chName.Text = "Field Name";
            chName.Width = 550;
            // 
            // FormCopyTracks
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Gainsboro;
            ClientSize = new System.Drawing.Size(1400, 816);
            ControlBox = false;
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "FormCopyTracks";
            Padding = new System.Windows.Forms.Padding(12, 12, 12, 12);
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Import Tracks From Another Field";
            Load += FormCopyTracks_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lbFields;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.FlowLayoutPanel flpTrackList;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnSelectAllTracks;
        private System.Windows.Forms.Button btnDeselectAllTracks;
        private System.Windows.Forms.Button btnCopyToCurrentField;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblFieldsHeader;
        private System.Windows.Forms.Label lblTracksHeader;
    }
}

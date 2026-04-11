namespace AgOpenGPS.Forms.Profiles
{
    partial class FormLoadProfile
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
            listViewProfiles = new System.Windows.Forms.ListView();
            columnHeaderProfile = new System.Windows.Forms.ColumnHeader();
            buttonCancel = new System.Windows.Forms.Button();
            buttonLoad = new System.Windows.Forms.Button();
            labelLoadProfile = new System.Windows.Forms.Label();
            buttonProfileDelete = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // listViewProfiles
            // 
            listViewProfiles.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            listViewProfiles.BackColor = System.Drawing.SystemColors.InactiveCaption;
            listViewProfiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeaderProfile });
            listViewProfiles.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            listViewProfiles.FullRowSelect = true;
            listViewProfiles.GridLines = true;
            listViewProfiles.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            listViewProfiles.ImeMode = System.Windows.Forms.ImeMode.Off;
            listViewProfiles.LabelWrap = false;
            listViewProfiles.Location = new System.Drawing.Point(9, 63);
            listViewProfiles.Margin = new System.Windows.Forms.Padding(0);
            listViewProfiles.MultiSelect = false;
            listViewProfiles.Name = "listViewProfiles";
            listViewProfiles.Size = new System.Drawing.Size(534, 254);
            listViewProfiles.TabIndex = 507;
            listViewProfiles.TileSize = new System.Drawing.Size(490, 35);
            listViewProfiles.UseCompatibleStateImageBehavior = false;
            listViewProfiles.View = System.Windows.Forms.View.Details;
            listViewProfiles.SelectedIndexChanged += listViewProfiles_SelectedIndexChanged;
            // 
            // columnHeaderProfile
            // 
            columnHeaderProfile.Text = "Environments";
            columnHeaderProfile.Width = 500;
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            buttonCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            buttonCancel.FlatAppearance.BorderSize = 0;
            buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonCancel.Font = new System.Drawing.Font("Tahoma", 14.25F);
            buttonCancel.Image = Properties.Resources.Cancel64;
            buttonCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            buttonCancel.Location = new System.Drawing.Point(461, 333);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new System.Drawing.Size(80, 92);
            buttonCancel.TabIndex = 509;
            buttonCancel.Text = "Cancel";
            buttonCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            buttonCancel.UseVisualStyleBackColor = false;
            // 
            // buttonLoad
            // 
            buttonLoad.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            buttonLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            buttonLoad.DialogResult = System.Windows.Forms.DialogResult.OK;
            buttonLoad.Enabled = false;
            buttonLoad.FlatAppearance.BorderSize = 0;
            buttonLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonLoad.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            buttonLoad.Image = Properties.Resources.OK64;
            buttonLoad.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            buttonLoad.Location = new System.Drawing.Point(546, 333);
            buttonLoad.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new System.Drawing.Size(80, 92);
            buttonLoad.TabIndex = 508;
            buttonLoad.Text = "Load";
            buttonLoad.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            buttonLoad.Click += buttonOK_Click;
            // 
            // labelLoadProfile
            // 
            labelLoadProfile.BackColor = System.Drawing.Color.Transparent;
            labelLoadProfile.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelLoadProfile.ForeColor = System.Drawing.Color.Black;
            labelLoadProfile.Location = new System.Drawing.Point(31, 26);
            labelLoadProfile.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            labelLoadProfile.Name = "labelLoadProfile";
            labelLoadProfile.Size = new System.Drawing.Size(198, 23);
            labelLoadProfile.TabIndex = 510;
            labelLoadProfile.Text = "Load Environment:";
            labelLoadProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonProfileDelete
            // 
            buttonProfileDelete.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            buttonProfileDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            buttonProfileDelete.Enabled = false;
            buttonProfileDelete.FlatAppearance.BorderSize = 0;
            buttonProfileDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonProfileDelete.Font = new System.Drawing.Font("Tahoma", 14.25F);
            buttonProfileDelete.Image = Properties.Resources.Trash;
            buttonProfileDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            buttonProfileDelete.Location = new System.Drawing.Point(546, 63);
            buttonProfileDelete.Name = "buttonProfileDelete";
            buttonProfileDelete.Size = new System.Drawing.Size(80, 92);
            buttonProfileDelete.TabIndex = 511;
            buttonProfileDelete.Text = "Delete";
            buttonProfileDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            buttonProfileDelete.UseVisualStyleBackColor = false;
            buttonProfileDelete.Click += buttonProfileDelete_Click;
            // 
            // FormLoadProfile
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.WhiteSmoke;
            ClientSize = new System.Drawing.Size(639, 437);
            ControlBox = false;
            Controls.Add(buttonProfileDelete);
            Controls.Add(labelLoadProfile);
            Controls.Add(buttonCancel);
            Controls.Add(buttonLoad);
            Controls.Add(listViewProfiles);
            Font = new System.Drawing.Font("Tahoma", 14.25F);
            Margin = new System.Windows.Forms.Padding(5);
            MinimumSize = new System.Drawing.Size(650, 360);
            Name = "FormLoadProfile";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Load Environment";
            Load += FormLoadProfile_Load;
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewProfiles;
        private System.Windows.Forms.ColumnHeader columnHeaderProfile;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Label labelLoadProfile;
        private System.Windows.Forms.Button buttonProfileDelete;
    }
}
namespace AgOpenGPS.Forms.Profiles
{
    partial class FormNewProfile
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
            textBoxName = new System.Windows.Forms.TextBox();
            labelName = new System.Windows.Forms.Label();
            buttonCreate = new System.Windows.Forms.Button();
            buttonCancel = new System.Windows.Forms.Button();
            listViewProfiles = new System.Windows.Forms.ListView();
            columnHeaderProfile = new System.Windows.Forms.ColumnHeader();
            columnHeaderCurrent = new System.Windows.Forms.ColumnHeader();
            labelCopyFrom = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            textBoxName.BackColor = System.Drawing.Color.White;
            textBoxName.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            textBoxName.Location = new System.Drawing.Point(160, 20);
            textBoxName.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new System.Drawing.Size(435, 33);
            textBoxName.TabIndex = 498;
            textBoxName.Click += textBoxName_Click;
            textBoxName.TextChanged += textBoxName_TextChanged;
            // 
            // labelName
            // 
            labelName.BackColor = System.Drawing.Color.Transparent;
            labelName.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelName.ForeColor = System.Drawing.Color.Black;
            labelName.Location = new System.Drawing.Point(15, 25);
            labelName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            labelName.Name = "labelName";
            labelName.Size = new System.Drawing.Size(135, 23);
            labelName.TabIndex = 499;
            labelName.Text = "Name:";
            labelName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonCreate
            // 
            buttonCreate.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            buttonCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            buttonCreate.DialogResult = System.Windows.Forms.DialogResult.OK;
            buttonCreate.Enabled = false;
            buttonCreate.FlatAppearance.BorderSize = 0;
            buttonCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonCreate.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            buttonCreate.Image = Properties.Resources.OK64;
            buttonCreate.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            buttonCreate.Location = new System.Drawing.Point(546, 268);
            buttonCreate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new System.Drawing.Size(80, 92);
            buttonCreate.TabIndex = 500;
            buttonCreate.Text = "Create";
            buttonCreate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            buttonCreate.Click += buttonOK_Click;
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
            buttonCancel.Location = new System.Drawing.Point(461, 268);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new System.Drawing.Size(80, 92);
            buttonCancel.TabIndex = 501;
            buttonCancel.Text = "Cancel";
            buttonCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            buttonCancel.UseVisualStyleBackColor = false;
            // 
            // listViewProfiles
            // 
            listViewProfiles.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            listViewProfiles.BackColor = System.Drawing.SystemColors.InactiveCaption;
            listViewProfiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeaderProfile, columnHeaderCurrent });
            listViewProfiles.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            listViewProfiles.FullRowSelect = true;
            listViewProfiles.GridLines = true;
            listViewProfiles.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            listViewProfiles.ImeMode = System.Windows.Forms.ImeMode.Off;
            listViewProfiles.LabelWrap = false;
            listViewProfiles.Location = new System.Drawing.Point(13, 102);
            listViewProfiles.Margin = new System.Windows.Forms.Padding(0);
            listViewProfiles.MultiSelect = false;
            listViewProfiles.Name = "listViewProfiles";
            listViewProfiles.Size = new System.Drawing.Size(611, 166);
            listViewProfiles.TabIndex = 506;
            listViewProfiles.TileSize = new System.Drawing.Size(490, 35);
            listViewProfiles.UseCompatibleStateImageBehavior = false;
            listViewProfiles.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderProfile
            // 
            columnHeaderProfile.Text = "Profiles";
            columnHeaderProfile.Width = 450;
            // 
            // columnHeaderCurrent
            // 
            columnHeaderCurrent.Width = 150;
            // 
            // labelCopyFrom
            // 
            labelCopyFrom.BackColor = System.Drawing.Color.Transparent;
            labelCopyFrom.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelCopyFrom.ForeColor = System.Drawing.Color.Black;
            labelCopyFrom.Location = new System.Drawing.Point(15, 68);
            labelCopyFrom.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            labelCopyFrom.Name = "labelCopyFrom";
            labelCopyFrom.Size = new System.Drawing.Size(135, 23);
            labelCopyFrom.TabIndex = 507;
            labelCopyFrom.Text = "Copy from:";
            labelCopyFrom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormNewProfile
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.WhiteSmoke;
            ClientSize = new System.Drawing.Size(637, 390);
            ControlBox = false;
            Controls.Add(labelCopyFrom);
            Controls.Add(listViewProfiles);
            Controls.Add(buttonCancel);
            Controls.Add(buttonCreate);
            Controls.Add(textBoxName);
            Controls.Add(labelName);
            Font = new System.Drawing.Font("Tahoma", 14.25F);
            Margin = new System.Windows.Forms.Padding(4);
            MinimumSize = new System.Drawing.Size(650, 370);
            Name = "FormNewProfile";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Create New Profile";
            Load += FormNewProfile_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ListView listViewProfiles;
        private System.Windows.Forms.ColumnHeader columnHeaderProfile;
        private System.Windows.Forms.ColumnHeader columnHeaderCurrent;
        private System.Windows.Forms.Label labelCopyFrom;
    }
}
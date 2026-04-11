namespace AgIO
{
    partial class FormProfiles
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
            cboxOverWrite = new System.Windows.Forms.ComboBox();
            tboxCreateNew = new System.Windows.Forms.TextBox();
            btnSaveNewProfile = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            btnSerialCancel = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            tboxSaveAs = new System.Windows.Forms.TextBox();
            btnSaveAs = new System.Windows.Forms.Button();
            lblCurrentProfile = new System.Windows.Forms.Label();
            lblLast = new System.Windows.Forms.Label();
            cboxChooseExisting = new System.Windows.Forms.ComboBox();
            label3 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // cboxOverWrite
            // 
            cboxOverWrite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboxOverWrite.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cboxOverWrite.FormattingEnabled = true;
            cboxOverWrite.Location = new System.Drawing.Point(728, 122);
            cboxOverWrite.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cboxOverWrite.Name = "cboxOverWrite";
            cboxOverWrite.Size = new System.Drawing.Size(511, 43);
            cboxOverWrite.TabIndex = 212;
            cboxOverWrite.SelectedIndexChanged += cboxOverWrite_SelectedIndexChanged;
            // 
            // tboxCreateNew
            // 
            tboxCreateNew.BackColor = System.Drawing.Color.White;
            tboxCreateNew.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tboxCreateNew.Location = new System.Drawing.Point(14, 107);
            tboxCreateNew.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            tboxCreateNew.Name = "tboxCreateNew";
            tboxCreateNew.Size = new System.Drawing.Size(511, 36);
            tboxCreateNew.TabIndex = 214;
            tboxCreateNew.Click += tboxNewProfile_Click;
            tboxCreateNew.TextChanged += tboxNewProfile_TextChanged;
            // 
            // btnSaveNewProfile
            // 
            btnSaveNewProfile.FlatAppearance.BorderSize = 0;
            btnSaveNewProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSaveNewProfile.Font = new System.Drawing.Font("Tahoma", 15.75F);
            btnSaveNewProfile.Image = Properties.Resources.VehFileSave;
            btnSaveNewProfile.Location = new System.Drawing.Point(567, 75);
            btnSaveNewProfile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSaveNewProfile.Name = "btnSaveNewProfile";
            btnSaveNewProfile.Size = new System.Drawing.Size(98, 87);
            btnSaveNewProfile.TabIndex = 215;
            btnSaveNewProfile.UseVisualStyleBackColor = true;
            btnSaveNewProfile.Click += btnSaveNewProfile_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(18, 76);
            label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(60, 23);
            label1.TabIndex = 216;
            label1.Text = "New:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(732, 92);
            label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(226, 23);
            label2.TabIndex = 217;
            label2.Text = "Overwrite This Profile:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSerialCancel
            // 
            btnSerialCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnSerialCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnSerialCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnSerialCancel.FlatAppearance.BorderSize = 0;
            btnSerialCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSerialCancel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnSerialCancel.Image = Properties.Resources.Cancel64;
            btnSerialCancel.Location = new System.Drawing.Point(567, 363);
            btnSerialCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSerialCancel.Name = "btnSerialCancel";
            btnSerialCancel.Size = new System.Drawing.Size(98, 87);
            btnSerialCancel.TabIndex = 218;
            btnSerialCancel.UseVisualStyleBackColor = true;
            btnSerialCancel.Click += btnSerialCancel_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label4.Location = new System.Drawing.Point(18, 187);
            label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(91, 23);
            label4.TabIndex = 221;
            label4.Text = "Save As:";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tboxSaveAs
            // 
            tboxSaveAs.BackColor = System.Drawing.Color.White;
            tboxSaveAs.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tboxSaveAs.Location = new System.Drawing.Point(14, 219);
            tboxSaveAs.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            tboxSaveAs.Name = "tboxSaveAs";
            tboxSaveAs.Size = new System.Drawing.Size(511, 36);
            tboxSaveAs.TabIndex = 220;
            tboxSaveAs.Click += tboxSaveAs_Click;
            tboxSaveAs.TextChanged += tboxSaveAs_TextChanged;
            // 
            // btnSaveAs
            // 
            btnSaveAs.FlatAppearance.BorderSize = 0;
            btnSaveAs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSaveAs.Font = new System.Drawing.Font("Tahoma", 15.75F);
            btnSaveAs.Image = Properties.Resources.FileSaveAs;
            btnSaveAs.Location = new System.Drawing.Point(567, 188);
            btnSaveAs.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSaveAs.Name = "btnSaveAs";
            btnSaveAs.Size = new System.Drawing.Size(98, 87);
            btnSaveAs.TabIndex = 222;
            btnSaveAs.UseVisualStyleBackColor = true;
            btnSaveAs.Click += btnSaveAs_Click;
            // 
            // lblCurrentProfile
            // 
            lblCurrentProfile.AutoSize = true;
            lblCurrentProfile.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblCurrentProfile.Location = new System.Drawing.Point(122, 187);
            lblCurrentProfile.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            lblCurrentProfile.Name = "lblCurrentProfile";
            lblCurrentProfile.Size = new System.Drawing.Size(150, 23);
            lblCurrentProfile.TabIndex = 223;
            lblCurrentProfile.Text = "Current Profile";
            lblCurrentProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLast
            // 
            lblLast.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblLast.Location = new System.Drawing.Point(22, 3);
            lblLast.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            lblLast.Name = "lblLast";
            lblLast.Size = new System.Drawing.Size(643, 33);
            lblLast.TabIndex = 225;
            lblLast.Text = "Curent Profile";
            lblLast.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboxChooseExisting
            // 
            cboxChooseExisting.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboxChooseExisting.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cboxChooseExisting.FormattingEnabled = true;
            cboxChooseExisting.Location = new System.Drawing.Point(14, 331);
            cboxChooseExisting.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cboxChooseExisting.Name = "cboxChooseExisting";
            cboxChooseExisting.Size = new System.Drawing.Size(511, 43);
            cboxChooseExisting.TabIndex = 224;
            cboxChooseExisting.SelectedIndexChanged += cboxChooseExisting_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(22, 301);
            label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(67, 23);
            label3.TabIndex = 226;
            label3.Text = "Open:";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormProfiles
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Gainsboro;
            ClientSize = new System.Drawing.Size(672, 455);
            Controls.Add(label3);
            Controls.Add(lblLast);
            Controls.Add(cboxChooseExisting);
            Controls.Add(lblCurrentProfile);
            Controls.Add(btnSaveAs);
            Controls.Add(label4);
            Controls.Add(tboxSaveAs);
            Controls.Add(btnSerialCancel);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSaveNewProfile);
            Controls.Add(tboxCreateNew);
            Controls.Add(cboxOverWrite);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "FormProfiles";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "AgIO: Manage Profiles";
            Load += FormCommSaver_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cboxOverWrite;
        private System.Windows.Forms.TextBox tboxCreateNew;
        private System.Windows.Forms.Button btnSaveNewProfile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSerialCancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tboxSaveAs;
        private System.Windows.Forms.Button btnSaveAs;
        private System.Windows.Forms.Label lblCurrentProfile;
        private System.Windows.Forms.Label lblLast;
        private System.Windows.Forms.ComboBox cboxChooseExisting;
        private System.Windows.Forms.Label label3;
    }
}
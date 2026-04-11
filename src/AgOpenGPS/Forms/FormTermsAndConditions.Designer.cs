namespace AgOpenGPS
{
    partial class FormTermsAndConditions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTermsAndConditions));
            labelTermsAndConditions = new System.Windows.Forms.Label();
            labelTerms = new System.Windows.Forms.Label();
            textBoxLicense = new System.Windows.Forms.TextBox();
            buttonYouTube = new System.Windows.Forms.Button();
            buttonDiscourse = new System.Windows.Forms.Button();
            buttonGitHub = new System.Windows.Forms.Button();
            labelDisagree = new System.Windows.Forms.Button();
            labelAgree = new System.Windows.Forms.Button();
            pictureBoxWarning = new System.Windows.Forms.PictureBox();
            labelVersion = new System.Windows.Forms.Label();
            labelVersionActual = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxWarning).BeginInit();
            SuspendLayout();
            // 
            // labelTermsAndConditions
            // 
            labelTermsAndConditions.BackColor = System.Drawing.Color.Transparent;
            labelTermsAndConditions.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelTermsAndConditions.Location = new System.Drawing.Point(443, 35);
            labelTermsAndConditions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelTermsAndConditions.Name = "labelTermsAndConditions";
            labelTermsAndConditions.Size = new System.Drawing.Size(677, 52);
            labelTermsAndConditions.TabIndex = 34;
            labelTermsAndConditions.Text = "Terms and Conditions";
            labelTermsAndConditions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTerms
            // 
            labelTerms.BackColor = System.Drawing.Color.Transparent;
            labelTerms.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelTerms.Location = new System.Drawing.Point(210, 156);
            labelTerms.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelTerms.Name = "labelTerms";
            labelTerms.Size = new System.Drawing.Size(910, 265);
            labelTerms.TabIndex = 132;
            labelTerms.Text = resources.GetString("labelTerms.Text");
            labelTerms.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxLicense
            // 
            textBoxLicense.BackColor = System.Drawing.Color.White;
            textBoxLicense.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            textBoxLicense.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            textBoxLicense.Location = new System.Drawing.Point(210, 444);
            textBoxLicense.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBoxLicense.Multiline = true;
            textBoxLicense.Name = "textBoxLicense";
            textBoxLicense.ReadOnly = true;
            textBoxLicense.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            textBoxLicense.Size = new System.Drawing.Size(910, 155);
            textBoxLicense.TabIndex = 147;
            textBoxLicense.Text = resources.GetString("textBoxLicense.Text");
            // 
            // buttonYouTube
            // 
            buttonYouTube.BackColor = System.Drawing.Color.Transparent;
            buttonYouTube.FlatAppearance.BorderSize = 0;
            buttonYouTube.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            buttonYouTube.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonYouTube.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            buttonYouTube.Image = Properties.Resources.YouTube;
            buttonYouTube.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            buttonYouTube.Location = new System.Drawing.Point(35, 475);
            buttonYouTube.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonYouTube.Name = "buttonYouTube";
            buttonYouTube.Size = new System.Drawing.Size(140, 127);
            buttonYouTube.TabIndex = 146;
            buttonYouTube.Text = "YouTube Tutorials";
            buttonYouTube.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            buttonYouTube.UseVisualStyleBackColor = false;
            buttonYouTube.Click += buttonYouTube_Click;
            // 
            // buttonDiscourse
            // 
            buttonDiscourse.BackColor = System.Drawing.Color.Transparent;
            buttonDiscourse.FlatAppearance.BorderSize = 0;
            buttonDiscourse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            buttonDiscourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonDiscourse.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            buttonDiscourse.Image = Properties.Resources.Discourse;
            buttonDiscourse.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            buttonDiscourse.Location = new System.Drawing.Point(35, 323);
            buttonDiscourse.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonDiscourse.Name = "buttonDiscourse";
            buttonDiscourse.Size = new System.Drawing.Size(140, 138);
            buttonDiscourse.TabIndex = 145;
            buttonDiscourse.Text = "Discourse Forum";
            buttonDiscourse.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            buttonDiscourse.UseVisualStyleBackColor = false;
            buttonDiscourse.Click += buttonDiscourse_Click;
            // 
            // buttonGitHub
            // 
            buttonGitHub.BackColor = System.Drawing.Color.Transparent;
            buttonGitHub.FlatAppearance.BorderSize = 0;
            buttonGitHub.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            buttonGitHub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonGitHub.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            buttonGitHub.Image = Properties.Resources.GitHub;
            buttonGitHub.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            buttonGitHub.Location = new System.Drawing.Point(35, 162);
            buttonGitHub.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonGitHub.Name = "buttonGitHub";
            buttonGitHub.Size = new System.Drawing.Size(140, 138);
            buttonGitHub.TabIndex = 144;
            buttonGitHub.Text = "Check for Updates";
            buttonGitHub.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            buttonGitHub.UseVisualStyleBackColor = false;
            buttonGitHub.Click += buttonGitHub_Click;
            // 
            // labelDisagree
            // 
            labelDisagree.BackColor = System.Drawing.Color.Transparent;
            labelDisagree.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            labelDisagree.FlatAppearance.BorderSize = 0;
            labelDisagree.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            labelDisagree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            labelDisagree.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelDisagree.Image = Properties.Resources.Cancel64;
            labelDisagree.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            labelDisagree.Location = new System.Drawing.Point(799, 617);
            labelDisagree.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            labelDisagree.Name = "labelDisagree";
            labelDisagree.Size = new System.Drawing.Size(158, 104);
            labelDisagree.TabIndex = 39;
            labelDisagree.Text = "Disagree";
            labelDisagree.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            labelDisagree.UseVisualStyleBackColor = false;
            // 
            // labelAgree
            // 
            labelAgree.BackColor = System.Drawing.Color.Transparent;
            labelAgree.DialogResult = System.Windows.Forms.DialogResult.OK;
            labelAgree.FlatAppearance.BorderSize = 0;
            labelAgree.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            labelAgree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            labelAgree.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelAgree.Image = Properties.Resources.OK64;
            labelAgree.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            labelAgree.Location = new System.Drawing.Point(962, 617);
            labelAgree.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            labelAgree.Name = "labelAgree";
            labelAgree.Size = new System.Drawing.Size(158, 104);
            labelAgree.TabIndex = 10;
            labelAgree.Text = "Agree";
            labelAgree.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            labelAgree.UseVisualStyleBackColor = false;
            // 
            // pictureBoxWarning
            // 
            pictureBoxWarning.BackColor = System.Drawing.Color.Transparent;
            pictureBoxWarning.Image = Properties.Resources.Warning;
            pictureBoxWarning.Location = new System.Drawing.Point(350, 23);
            pictureBoxWarning.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pictureBoxWarning.Name = "pictureBoxWarning";
            pictureBoxWarning.Size = new System.Drawing.Size(75, 74);
            pictureBoxWarning.TabIndex = 148;
            pictureBoxWarning.TabStop = false;
            // 
            // labelVersion
            // 
            labelVersion.BackColor = System.Drawing.Color.Transparent;
            labelVersion.Font = new System.Drawing.Font("Tahoma", 11F);
            labelVersion.Location = new System.Drawing.Point(443, 87);
            labelVersion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelVersion.Name = "labelVersion";
            labelVersion.Size = new System.Drawing.Size(140, 29);
            labelVersion.TabIndex = 149;
            labelVersion.Text = "Version:";
            labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelVersionActual
            // 
            labelVersionActual.BackColor = System.Drawing.Color.Transparent;
            labelVersionActual.Font = new System.Drawing.Font("Tahoma", 11F);
            labelVersionActual.Location = new System.Drawing.Point(589, 87);
            labelVersionActual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelVersionActual.Name = "labelVersionActual";
            labelVersionActual.Size = new System.Drawing.Size(408, 29);
            labelVersionActual.TabIndex = 150;
            labelVersionActual.Text = "x.y.z";
            labelVersionActual.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormTermsAndConditions
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Lavender;
            ClientSize = new System.Drawing.Size(1167, 738);
            Controls.Add(pictureBoxWarning);
            Controls.Add(labelTermsAndConditions);
            Controls.Add(labelVersion);
            Controls.Add(labelVersionActual);
            Controls.Add(labelTerms);
            Controls.Add(textBoxLicense);
            Controls.Add(labelAgree);
            Controls.Add(labelDisagree);
            Controls.Add(buttonGitHub);
            Controls.Add(buttonDiscourse);
            Controls.Add(buttonYouTube);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "FormTermsAndConditions";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            TopMost = true;
            Load += Form_About_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxWarning).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button labelAgree;
        private System.Windows.Forms.Label labelTermsAndConditions;
        private System.Windows.Forms.Button labelDisagree;
        private System.Windows.Forms.Label labelTerms;
        private System.Windows.Forms.Button buttonGitHub;
        private System.Windows.Forms.Button buttonDiscourse;
        private System.Windows.Forms.Button buttonYouTube;
        private System.Windows.Forms.TextBox textBoxLicense;
        private System.Windows.Forms.PictureBox pictureBoxWarning;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelVersionActual;
    }
}
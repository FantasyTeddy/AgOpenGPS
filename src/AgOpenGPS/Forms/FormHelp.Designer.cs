namespace AgOpenGPS
{
    partial class FormHelp
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
            buttonClose = new System.Windows.Forms.Button();
            buttonGitHub = new System.Windows.Forms.Button();
            buttonDiscourse = new System.Windows.Forms.Button();
            buttonYouTube = new System.Windows.Forms.Button();
            pictureBoxQRGitHub = new System.Windows.Forms.PictureBox();
            pictureBoxQRDiscourse = new System.Windows.Forms.PictureBox();
            pictureBoxQRYouTube = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxQRGitHub).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxQRDiscourse).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxQRYouTube).BeginInit();
            SuspendLayout();
            // 
            // buttonClose
            // 
            buttonClose.BackColor = System.Drawing.Color.Transparent;
            buttonClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            buttonClose.FlatAppearance.BorderSize = 0;
            buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonClose.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            buttonClose.Image = Properties.Resources.OK64;
            buttonClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            buttonClose.Location = new System.Drawing.Point(735, 438);
            buttonClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new System.Drawing.Size(105, 104);
            buttonClose.TabIndex = 10;
            buttonClose.Text = "Close";
            buttonClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            buttonClose.UseVisualStyleBackColor = false;
            // 
            // buttonGitHub
            // 
            buttonGitHub.BackColor = System.Drawing.Color.Transparent;
            buttonGitHub.FlatAppearance.BorderSize = 0;
            buttonGitHub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonGitHub.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            buttonGitHub.Image = Properties.Resources.GitHub;
            buttonGitHub.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            buttonGitHub.Location = new System.Drawing.Point(23, 300);
            buttonGitHub.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonGitHub.Name = "buttonGitHub";
            buttonGitHub.Size = new System.Drawing.Size(257, 127);
            buttonGitHub.TabIndex = 560;
            buttonGitHub.Text = "Check for Updates";
            buttonGitHub.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            buttonGitHub.UseVisualStyleBackColor = false;
            buttonGitHub.Click += buttonGitHub_Click;
            // 
            // buttonDiscourse
            // 
            buttonDiscourse.BackColor = System.Drawing.Color.Transparent;
            buttonDiscourse.FlatAppearance.BorderSize = 0;
            buttonDiscourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonDiscourse.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            buttonDiscourse.Image = Properties.Resources.Discourse;
            buttonDiscourse.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            buttonDiscourse.Location = new System.Drawing.Point(303, 300);
            buttonDiscourse.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonDiscourse.Name = "buttonDiscourse";
            buttonDiscourse.Size = new System.Drawing.Size(257, 127);
            buttonDiscourse.TabIndex = 561;
            buttonDiscourse.Text = "Discourse Forum";
            buttonDiscourse.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            buttonDiscourse.UseVisualStyleBackColor = false;
            buttonDiscourse.Click += buttonDiscourse_Click;
            // 
            // buttonYouTube
            // 
            buttonYouTube.BackColor = System.Drawing.Color.Transparent;
            buttonYouTube.FlatAppearance.BorderSize = 0;
            buttonYouTube.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonYouTube.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            buttonYouTube.Image = Properties.Resources.YouTube;
            buttonYouTube.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            buttonYouTube.Location = new System.Drawing.Point(583, 300);
            buttonYouTube.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonYouTube.Name = "buttonYouTube";
            buttonYouTube.Size = new System.Drawing.Size(257, 127);
            buttonYouTube.TabIndex = 562;
            buttonYouTube.Text = "YouTube Tutorials";
            buttonYouTube.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            buttonYouTube.UseVisualStyleBackColor = false;
            buttonYouTube.Click += buttonYouTube_Click;
            // 
            // pictureBoxQRGitHub
            // 
            pictureBoxQRGitHub.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pictureBoxQRGitHub.Image = Properties.Resources.QRGitHub;
            pictureBoxQRGitHub.Location = new System.Drawing.Point(23, 23);
            pictureBoxQRGitHub.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pictureBoxQRGitHub.Name = "pictureBoxQRGitHub";
            pictureBoxQRGitHub.Size = new System.Drawing.Size(256, 254);
            pictureBoxQRGitHub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBoxQRGitHub.TabIndex = 563;
            pictureBoxQRGitHub.TabStop = false;
            // 
            // pictureBoxQRDiscourse
            // 
            pictureBoxQRDiscourse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pictureBoxQRDiscourse.Image = Properties.Resources.QRDiscourse;
            pictureBoxQRDiscourse.Location = new System.Drawing.Point(303, 23);
            pictureBoxQRDiscourse.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pictureBoxQRDiscourse.Name = "pictureBoxQRDiscourse";
            pictureBoxQRDiscourse.Size = new System.Drawing.Size(256, 254);
            pictureBoxQRDiscourse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBoxQRDiscourse.TabIndex = 564;
            pictureBoxQRDiscourse.TabStop = false;
            // 
            // pictureBoxQRYouTube
            // 
            pictureBoxQRYouTube.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pictureBoxQRYouTube.Image = Properties.Resources.QRYouTube;
            pictureBoxQRYouTube.Location = new System.Drawing.Point(583, 23);
            pictureBoxQRYouTube.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pictureBoxQRYouTube.Name = "pictureBoxQRYouTube";
            pictureBoxQRYouTube.Size = new System.Drawing.Size(256, 254);
            pictureBoxQRYouTube.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBoxQRYouTube.TabIndex = 565;
            pictureBoxQRYouTube.TabStop = false;
            // 
            // FormHelp
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Control;
            ClientSize = new System.Drawing.Size(862, 554);
            ControlBox = false;
            Controls.Add(pictureBoxQRGitHub);
            Controls.Add(pictureBoxQRDiscourse);
            Controls.Add(pictureBoxQRYouTube);
            Controls.Add(buttonGitHub);
            Controls.Add(buttonDiscourse);
            Controls.Add(buttonYouTube);
            Controls.Add(buttonClose);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MinimizeBox = false;
            Name = "FormHelp";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Help";
            Load += FormHelp_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxQRGitHub).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxQRDiscourse).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxQRYouTube).EndInit();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonGitHub;
        private System.Windows.Forms.Button buttonDiscourse;
        private System.Windows.Forms.Button buttonYouTube;
        private System.Windows.Forms.PictureBox pictureBoxQRGitHub;
        private System.Windows.Forms.PictureBox pictureBoxQRDiscourse;
        private System.Windows.Forms.PictureBox pictureBoxQRYouTube;
    }
}
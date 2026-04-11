namespace AgOpenGPS.Updater.Forms
{
    partial class FormUpdate
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
            panelHeader = new System.Windows.Forms.Panel();
            lblGitHubStatus = new System.Windows.Forms.Label();
            lblTitle = new System.Windows.Forms.Label();
            panelMain = new System.Windows.Forms.Panel();
            btnViewReleaseNotes = new System.Windows.Forms.Button();
            lblProgressPercent = new System.Windows.Forms.Label();
            progressBar1 = new System.Windows.Forms.ProgressBar();
            lblStatus = new System.Windows.Forms.Label();
            btnToggleSource = new System.Windows.Forms.Button();
            lblSourceInfo = new System.Windows.Forms.Label();
            btnCheckForUpdates = new System.Windows.Forms.Button();
            chkIncludePrerelease = new System.Windows.Forms.CheckBox();
            lblLatestVersion = new System.Windows.Forms.Label();
            lblCurrentVersion = new System.Windows.Forms.Label();
            panelButtons = new System.Windows.Forms.Panel();
            btnClose = new System.Windows.Forms.Button();
            btnInstallUpdate = new System.Windows.Forms.Button();
            panelHeader.SuspendLayout();
            panelMain.SuspendLayout();
            panelButtons.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = System.Drawing.Color.FromArgb(27, 151, 160);
            panelHeader.Controls.Add(lblGitHubStatus);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            panelHeader.Location = new System.Drawing.Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new System.Drawing.Size(750, 90);
            panelHeader.TabIndex = 0;
            // 
            // lblGitHubStatus
            // 
            lblGitHubStatus.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lblGitHubStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblGitHubStatus.ForeColor = System.Drawing.Color.FromArgb(180, 180, 180);
            lblGitHubStatus.Location = new System.Drawing.Point(630, 35);
            lblGitHubStatus.Name = "lblGitHubStatus";
            lblGitHubStatus.Size = new System.Drawing.Size(110, 40);
            lblGitHubStatus.TabIndex = 1;
            lblGitHubStatus.Text = "🔒 Anonymous";
            lblGitHubStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            lblTitle.ForeColor = System.Drawing.Color.White;
            lblTitle.Location = new System.Drawing.Point(30, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(368, 47);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "AgOpenGPS Updater";
            // 
            // panelMain
            // 
            panelMain.BackColor = System.Drawing.Color.FromArgb(210, 210, 230);
            panelMain.Controls.Add(btnViewReleaseNotes);
            panelMain.Controls.Add(lblProgressPercent);
            panelMain.Controls.Add(progressBar1);
            panelMain.Controls.Add(lblStatus);
            panelMain.Controls.Add(btnToggleSource);
            panelMain.Controls.Add(lblSourceInfo);
            panelMain.Controls.Add(btnCheckForUpdates);
            panelMain.Controls.Add(chkIncludePrerelease);
            panelMain.Controls.Add(lblLatestVersion);
            panelMain.Controls.Add(lblCurrentVersion);
            panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            panelMain.Location = new System.Drawing.Point(0, 90);
            panelMain.Name = "panelMain";
            panelMain.Padding = new System.Windows.Forms.Padding(30);
            panelMain.Size = new System.Drawing.Size(750, 540);
            panelMain.TabIndex = 1;
            // 
            // btnViewReleaseNotes
            // 
            btnViewReleaseNotes.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnViewReleaseNotes.BackColor = System.Drawing.Color.FromArgb(100, 100, 100);
            btnViewReleaseNotes.Enabled = false;
            btnViewReleaseNotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnViewReleaseNotes.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            btnViewReleaseNotes.ForeColor = System.Drawing.Color.White;
            btnViewReleaseNotes.Location = new System.Drawing.Point(400, 210);
            btnViewReleaseNotes.Name = "btnViewReleaseNotes";
            btnViewReleaseNotes.Size = new System.Drawing.Size(320, 70);
            btnViewReleaseNotes.TabIndex = 6;
            btnViewReleaseNotes.Text = "View Release Notes";
            btnViewReleaseNotes.UseVisualStyleBackColor = false;
            btnViewReleaseNotes.Click += BtnViewReleaseNotes_Click;
            // 
            // lblProgressPercent
            // 
            lblProgressPercent.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblProgressPercent.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold);
            lblProgressPercent.ForeColor = System.Drawing.Color.FromArgb(27, 151, 160);
            lblProgressPercent.Location = new System.Drawing.Point(30, 420);
            lblProgressPercent.Name = "lblProgressPercent";
            lblProgressPercent.Size = new System.Drawing.Size(690, 80);
            lblProgressPercent.TabIndex = 9;
            lblProgressPercent.Text = "0%";
            lblProgressPercent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblProgressPercent.Visible = false;
            // 
            // progressBar1
            // 
            progressBar1.Location = new System.Drawing.Point(30, 370);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new System.Drawing.Size(690, 40);
            progressBar1.TabIndex = 8;
            progressBar1.Visible = false;
            // 
            // lblStatus
            // 
            lblStatus.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblStatus.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            lblStatus.ForeColor = System.Drawing.Color.FromArgb(27, 151, 160);
            lblStatus.Location = new System.Drawing.Point(30, 300);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new System.Drawing.Size(690, 60);
            lblStatus.TabIndex = 7;
            lblStatus.Text = "Ready...";
            lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnToggleSource
            // 
            btnToggleSource.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnToggleSource.BackColor = System.Drawing.Color.FromArgb(100, 100, 100);
            btnToggleSource.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnToggleSource.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            btnToggleSource.ForeColor = System.Drawing.Color.White;
            btnToggleSource.Location = new System.Drawing.Point(550, 25);
            btnToggleSource.Name = "btnToggleSource";
            btnToggleSource.Size = new System.Drawing.Size(170, 40);
            btnToggleSource.TabIndex = 3;
            btnToggleSource.Text = "Use USB";
            btnToggleSource.UseVisualStyleBackColor = false;
            btnToggleSource.Click += BtnToggleSource_Click;
            // 
            // lblSourceInfo
            // 
            lblSourceInfo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Italic);
            lblSourceInfo.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
            lblSourceInfo.Location = new System.Drawing.Point(30, 160);
            lblSourceInfo.Name = "lblSourceInfo";
            lblSourceInfo.Size = new System.Drawing.Size(690, 60);
            lblSourceInfo.TabIndex = 4;
            lblSourceInfo.Text = "Local: Place AgOpenGPS.zip in root of USB drive";
            lblSourceInfo.Visible = false;
            // 
            // btnCheckForUpdates
            // 
            btnCheckForUpdates.BackColor = System.Drawing.Color.FromArgb(27, 151, 160);
            btnCheckForUpdates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCheckForUpdates.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            btnCheckForUpdates.ForeColor = System.Drawing.Color.White;
            btnCheckForUpdates.Location = new System.Drawing.Point(30, 210);
            btnCheckForUpdates.Name = "btnCheckForUpdates";
            btnCheckForUpdates.Size = new System.Drawing.Size(350, 70);
            btnCheckForUpdates.TabIndex = 5;
            btnCheckForUpdates.Text = "Check for Updates";
            btnCheckForUpdates.UseVisualStyleBackColor = false;
            btnCheckForUpdates.Click += BtnCheckForUpdates_Click;
            // 
            // chkIncludePrerelease
            // 
            chkIncludePrerelease.AutoSize = true;
            chkIncludePrerelease.Font = new System.Drawing.Font("Segoe UI", 14F);
            chkIncludePrerelease.ForeColor = System.Drawing.Color.FromArgb(10, 10, 20);
            chkIncludePrerelease.Location = new System.Drawing.Point(30, 125);
            chkIncludePrerelease.Name = "chkIncludePrerelease";
            chkIncludePrerelease.Size = new System.Drawing.Size(194, 29);
            chkIncludePrerelease.TabIndex = 2;
            chkIncludePrerelease.Text = "Include pre-release";
            chkIncludePrerelease.UseVisualStyleBackColor = true;
            // 
            // lblLatestVersion
            // 
            lblLatestVersion.AutoSize = true;
            lblLatestVersion.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            lblLatestVersion.ForeColor = System.Drawing.Color.FromArgb(10, 10, 20);
            lblLatestVersion.Location = new System.Drawing.Point(30, 70);
            lblLatestVersion.Name = "lblLatestVersion";
            lblLatestVersion.Size = new System.Drawing.Size(197, 32);
            lblLatestVersion.TabIndex = 1;
            lblLatestVersion.Text = "Latest Version: -";
            // 
            // lblCurrentVersion
            // 
            lblCurrentVersion.AutoSize = true;
            lblCurrentVersion.Font = new System.Drawing.Font("Segoe UI", 16F);
            lblCurrentVersion.ForeColor = System.Drawing.Color.FromArgb(10, 10, 20);
            lblCurrentVersion.Location = new System.Drawing.Point(30, 30);
            lblCurrentVersion.Name = "lblCurrentVersion";
            lblCurrentVersion.Size = new System.Drawing.Size(184, 30);
            lblCurrentVersion.TabIndex = 0;
            lblCurrentVersion.Text = "Current Version: -";
            // 
            // panelButtons
            // 
            panelButtons.BackColor = System.Drawing.Color.FromArgb(180, 180, 200);
            panelButtons.Controls.Add(btnClose);
            panelButtons.Controls.Add(btnInstallUpdate);
            panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            panelButtons.Location = new System.Drawing.Point(0, 520);
            panelButtons.Name = "panelButtons";
            panelButtons.Padding = new System.Windows.Forms.Padding(30);
            panelButtons.Size = new System.Drawing.Size(750, 110);
            panelButtons.TabIndex = 2;
            // 
            // btnClose
            // 
            btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnClose.BackColor = System.Drawing.Color.FromArgb(220, 80, 80);
            btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClose.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            btnClose.ForeColor = System.Drawing.Color.White;
            btnClose.Location = new System.Drawing.Point(30, 20);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(250, 70);
            btnClose.TabIndex = 1;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += BtnCancel_Click;
            // 
            // btnInstallUpdate
            // 
            btnInstallUpdate.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnInstallUpdate.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            btnInstallUpdate.Enabled = false;
            btnInstallUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnInstallUpdate.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            btnInstallUpdate.ForeColor = System.Drawing.Color.White;
            btnInstallUpdate.Location = new System.Drawing.Point(420, 20);
            btnInstallUpdate.Name = "btnInstallUpdate";
            btnInstallUpdate.Size = new System.Drawing.Size(300, 70);
            btnInstallUpdate.TabIndex = 0;
            btnInstallUpdate.Text = "Install Update";
            btnInstallUpdate.UseVisualStyleBackColor = false;
            btnInstallUpdate.Click += BtnInstallUpdate_Click;
            // 
            // FormUpdate
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            CancelButton = btnClose;
            ClientSize = new System.Drawing.Size(750, 630);
            ControlBox = false;
            Controls.Add(panelButtons);
            Controls.Add(panelMain);
            Controls.Add(panelHeader);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormUpdate";
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "AgOpenGPS Updater";
            Load += FormUpdate_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            panelButtons.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblGitHubStatus;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lblCurrentVersion;
        private System.Windows.Forms.Label lblLatestVersion;
        private System.Windows.Forms.CheckBox chkIncludePrerelease;
        private System.Windows.Forms.Button btnCheckForUpdates;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblProgressPercent;
        private System.Windows.Forms.Button btnToggleSource;
        private System.Windows.Forms.Label lblSourceInfo;
        private System.Windows.Forms.Button btnInstallUpdate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnViewReleaseNotes;
    }
}

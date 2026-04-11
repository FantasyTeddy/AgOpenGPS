namespace AgOpenGPS.Updater.Forms
{
    partial class FormReleaseNotes
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
            lblTitle = new System.Windows.Forms.Label();
            panelMain = new System.Windows.Forms.Panel();
            txtNotes = new System.Windows.Forms.TextBox();
            panelButtons = new System.Windows.Forms.Panel();
            btnClose = new System.Windows.Forms.Button();
            panelHeader.SuspendLayout();
            panelMain.SuspendLayout();
            panelButtons.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = System.Drawing.Color.FromArgb(27, 151, 160);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            panelHeader.Location = new System.Drawing.Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new System.Drawing.Size(700, 70);
            panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            lblTitle.ForeColor = System.Drawing.Color.White;
            lblTitle.Location = new System.Drawing.Point(25, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(197, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Release Notes";
            // 
            // panelMain
            // 
            panelMain.BackColor = System.Drawing.Color.FromArgb(210, 210, 230);
            panelMain.Controls.Add(txtNotes);
            panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            panelMain.Location = new System.Drawing.Point(0, 70);
            panelMain.Name = "panelMain";
            panelMain.Padding = new System.Windows.Forms.Padding(20);
            panelMain.Size = new System.Drawing.Size(700, 510);
            panelMain.TabIndex = 1;
            // 
            // txtNotes
            // 
            txtNotes.BackColor = System.Drawing.Color.White;
            txtNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            txtNotes.Font = new System.Drawing.Font("Segoe UI", 11F);
            txtNotes.Location = new System.Drawing.Point(20, 20);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.ReadOnly = true;
            txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            txtNotes.Size = new System.Drawing.Size(660, 470);
            txtNotes.TabIndex = 0;
            txtNotes.Text = "Release notes will appear here.";
            // 
            // panelButtons
            // 
            panelButtons.BackColor = System.Drawing.Color.FromArgb(180, 180, 200);
            panelButtons.Controls.Add(btnClose);
            panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            panelButtons.Location = new System.Drawing.Point(0, 500);
            panelButtons.Name = "panelButtons";
            panelButtons.Padding = new System.Windows.Forms.Padding(20);
            panelButtons.Size = new System.Drawing.Size(700, 80);
            panelButtons.TabIndex = 2;
            // 
            // btnClose
            // 
            btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnClose.BackColor = System.Drawing.Color.FromArgb(27, 151, 160);
            btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClose.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            btnClose.ForeColor = System.Drawing.Color.White;
            btnClose.Location = new System.Drawing.Point(520, 15);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(160, 50);
            btnClose.TabIndex = 0;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += BtnClose_Click;
            // 
            // FormReleaseNotes
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            ClientSize = new System.Drawing.Size(700, 580);
            ControlBox = false;
            Controls.Add(panelButtons);
            Controls.Add(panelMain);
            Controls.Add(panelHeader);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormReleaseNotes";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Release Notes";
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
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnClose;
    }
}

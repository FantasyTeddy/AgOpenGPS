namespace AgOpenGPS.Updater.Forms
{
    partial class FormDialog
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
            panelMain = new System.Windows.Forms.Panel();
            lblMessage = new System.Windows.Forms.Label();
            panelIcon = new System.Windows.Forms.Panel();
            lblIcon = new System.Windows.Forms.Label();
            panelButtons = new System.Windows.Forms.Panel();
            btnCancel = new System.Windows.Forms.Button();
            btnOK = new System.Windows.Forms.Button();
            panelMain.SuspendLayout();
            panelIcon.SuspendLayout();
            panelButtons.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.BackColor = System.Drawing.Color.FromArgb(210, 210, 230);
            panelMain.Controls.Add(lblMessage);
            panelMain.Controls.Add(panelIcon);
            panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            panelMain.Location = new System.Drawing.Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Padding = new System.Windows.Forms.Padding(30);
            panelMain.Size = new System.Drawing.Size(600, 320);
            panelMain.TabIndex = 0;
            // 
            // lblMessage
            // 
            lblMessage.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblMessage.Font = new System.Drawing.Font("Segoe UI", 14F);
            lblMessage.ForeColor = System.Drawing.Color.FromArgb(10, 10, 20);
            lblMessage.Location = new System.Drawing.Point(80, 20);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new System.Drawing.Size(490, 260);
            lblMessage.TabIndex = 0;
            lblMessage.Text = "Message text goes here";
            // 
            // panelIcon
            // 
            panelIcon.BackColor = System.Drawing.Color.FromArgb(27, 151, 160);
            panelIcon.Controls.Add(lblIcon);
            panelIcon.Location = new System.Drawing.Point(30, 30);
            panelIcon.Name = "panelIcon";
            panelIcon.Size = new System.Drawing.Size(40, 40);
            panelIcon.TabIndex = 1;
            // 
            // lblIcon
            // 
            lblIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            lblIcon.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            lblIcon.ForeColor = System.Drawing.Color.White;
            lblIcon.Location = new System.Drawing.Point(0, 0);
            lblIcon.Name = "lblIcon";
            lblIcon.Size = new System.Drawing.Size(40, 40);
            lblIcon.TabIndex = 0;
            lblIcon.Text = "!";
            lblIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelButtons
            // 
            panelButtons.BackColor = System.Drawing.Color.FromArgb(180, 180, 200);
            panelButtons.Controls.Add(btnCancel);
            panelButtons.Controls.Add(btnOK);
            panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            panelButtons.Location = new System.Drawing.Point(0, 240);
            panelButtons.Name = "panelButtons";
            panelButtons.Padding = new System.Windows.Forms.Padding(20);
            panelButtons.Size = new System.Drawing.Size(600, 80);
            panelButtons.TabIndex = 1;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnCancel.BackColor = System.Drawing.Color.FromArgb(220, 80, 80);
            btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            btnCancel.ForeColor = System.Drawing.Color.White;
            btnCancel.Location = new System.Drawing.Point(380, 15);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(200, 50);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += BtnCancel_Click;
            // 
            // btnOK
            // 
            btnOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnOK.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnOK.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            btnOK.ForeColor = System.Drawing.Color.White;
            btnOK.Location = new System.Drawing.Point(120, 15);
            btnOK.Name = "btnOK";
            btnOK.Size = new System.Drawing.Size(200, 50);
            btnOK.TabIndex = 0;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = false;
            btnOK.Click += BtnOK_Click;
            // 
            // FormDialog
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            ClientSize = new System.Drawing.Size(600, 320);
            ControlBox = false;
            Controls.Add(panelButtons);
            Controls.Add(panelMain);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormDialog";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "AgOpenGPS Updater";
            panelMain.ResumeLayout(false);
            panelIcon.ResumeLayout(false);
            panelButtons.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Panel panelIcon;
        private System.Windows.Forms.Label lblIcon;
    }
}

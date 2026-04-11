namespace AgOpenGPS
{
    partial class FormAgShareSettings
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
            textBoxApiKey = new System.Windows.Forms.TextBox();
            buttonTestConnection = new System.Windows.Forms.Button();
            labelStatus = new System.Windows.Forms.Label();
            labelApiKey = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            textBoxServer = new System.Windows.Forms.TextBox();
            btnPaste = new System.Windows.Forms.Button();
            linkRegister = new System.Windows.Forms.LinkLabel();
            label2 = new System.Windows.Forms.Label();
            btnDevelop = new System.Windows.Forms.Button();
            btnAutoUpload = new System.Windows.Forms.Button();
            btnToggleUpload = new System.Windows.Forms.Button();
            buttonCancel = new System.Windows.Forms.Button();
            buttonSave = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // textBoxApiKey
            // 
            textBoxApiKey.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            textBoxApiKey.BackColor = System.Drawing.Color.White;
            textBoxApiKey.Location = new System.Drawing.Point(122, 59);
            textBoxApiKey.Name = "textBoxApiKey";
            textBoxApiKey.Size = new System.Drawing.Size(441, 30);
            textBoxApiKey.TabIndex = 0;
            // 
            // buttonTestConnection
            // 
            buttonTestConnection.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            buttonTestConnection.Location = new System.Drawing.Point(343, 96);
            buttonTestConnection.Name = "buttonTestConnection";
            buttonTestConnection.Size = new System.Drawing.Size(220, 35);
            buttonTestConnection.TabIndex = 1;
            buttonTestConnection.Text = "Test Connection";
            buttonTestConnection.UseVisualStyleBackColor = true;
            buttonTestConnection.Click += buttonTestConnection_Click;
            // 
            // labelStatus
            // 
            labelStatus.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            labelStatus.ForeColor = System.Drawing.Color.DarkRed;
            labelStatus.Location = new System.Drawing.Point(20, 141);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new System.Drawing.Size(543, 25);
            labelStatus.TabIndex = 4;
            labelStatus.Text = "Enter Details Above and Tick Test Connection";
            labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelApiKey
            // 
            labelApiKey.BackColor = System.Drawing.Color.Transparent;
            labelApiKey.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelApiKey.ForeColor = System.Drawing.Color.Black;
            labelApiKey.Location = new System.Drawing.Point(16, 62);
            labelApiKey.Name = "labelApiKey";
            labelApiKey.Size = new System.Drawing.Size(100, 23);
            labelApiKey.TabIndex = 5;
            labelApiKey.Text = "API Key:";
            labelApiKey.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.Black;
            label1.Location = new System.Drawing.Point(16, 26);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(100, 23);
            label1.TabIndex = 6;
            label1.Text = "Server:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxServer
            // 
            textBoxServer.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            textBoxServer.BackColor = System.Drawing.Color.White;
            textBoxServer.Location = new System.Drawing.Point(122, 23);
            textBoxServer.Name = "textBoxServer";
            textBoxServer.Size = new System.Drawing.Size(441, 30);
            textBoxServer.TabIndex = 7;
            textBoxServer.Click += textBoxServer_Click;
            // 
            // btnPaste
            // 
            btnPaste.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnPaste.Location = new System.Drawing.Point(122, 96);
            btnPaste.Name = "btnPaste";
            btnPaste.Size = new System.Drawing.Size(192, 35);
            btnPaste.TabIndex = 9;
            btnPaste.Text = "Paste from Clipboard";
            btnPaste.UseVisualStyleBackColor = true;
            btnPaste.Click += btnPaste_Click;
            // 
            // linkRegister
            // 
            linkRegister.AutoSize = true;
            linkRegister.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            linkRegister.Location = new System.Drawing.Point(147, 341);
            linkRegister.Name = "linkRegister";
            linkRegister.Size = new System.Drawing.Size(280, 23);
            linkRegister.TabIndex = 10;
            linkRegister.TabStop = true;
            linkRegister.Text = "https://agshare.agopengps.com";
            linkRegister.LinkClicked += linkRegister_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(158, 318);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(256, 23);
            label2.TabIndex = 11;
            label2.Text = "Register here to use AgShare";
            // 
            // btnDevelop
            // 
            btnDevelop.BackColor = System.Drawing.Color.Transparent;
            btnDevelop.FlatAppearance.BorderSize = 0;
            btnDevelop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDevelop.Location = new System.Drawing.Point(12, 338);
            btnDevelop.Name = "btnDevelop";
            btnDevelop.Size = new System.Drawing.Size(22, 23);
            btnDevelop.TabIndex = 12;
            btnDevelop.UseVisualStyleBackColor = false;
            btnDevelop.Click += btnDevelop_Click;
            // 
            // btnAutoUpload
            // 
            btnAutoUpload.FlatAppearance.BorderSize = 0;
            btnAutoUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAutoUpload.Image = Properties.Resources.AutoUploadOn;
            btnAutoUpload.Location = new System.Drawing.Point(12, 173);
            btnAutoUpload.Name = "btnAutoUpload";
            btnAutoUpload.Size = new System.Drawing.Size(128, 128);
            btnAutoUpload.TabIndex = 13;
            btnAutoUpload.Text = "Auto-Upload";
            btnAutoUpload.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnAutoUpload.UseVisualStyleBackColor = true;
            btnAutoUpload.Click += btnAutoUpload_Click;
            // 
            // btnToggleUpload
            // 
            btnToggleUpload.FlatAppearance.BorderSize = 0;
            btnToggleUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnToggleUpload.Image = Properties.Resources.UploadOff;
            btnToggleUpload.Location = new System.Drawing.Point(224, 173);
            btnToggleUpload.Name = "btnToggleUpload";
            btnToggleUpload.Size = new System.Drawing.Size(128, 128);
            btnToggleUpload.TabIndex = 8;
            btnToggleUpload.Text = "Activate";
            btnToggleUpload.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnToggleUpload.UseVisualStyleBackColor = true;
            btnToggleUpload.Click += btnToggleUpload_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            buttonCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            buttonCancel.FlatAppearance.BorderSize = 0;
            buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonCancel.Image = Properties.Resources.Cancel64;
            buttonCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            buttonCancel.Location = new System.Drawing.Point(406, 209);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new System.Drawing.Size(80, 92);
            buttonCancel.TabIndex = 3;
            buttonCancel.Text = "Cancel";
            buttonCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            buttonCancel.UseVisualStyleBackColor = false;
            // 
            // buttonSave
            // 
            buttonSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            buttonSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            buttonSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            buttonSave.Enabled = false;
            buttonSave.FlatAppearance.BorderSize = 0;
            buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonSave.Image = Properties.Resources.OK64;
            buttonSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            buttonSave.Location = new System.Drawing.Point(492, 209);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new System.Drawing.Size(80, 92);
            buttonSave.TabIndex = 2;
            buttonSave.Text = "Save";
            buttonSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // FormAgShareSettings
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.WhiteSmoke;
            ClientSize = new System.Drawing.Size(584, 373);
            ControlBox = false;
            Controls.Add(btnAutoUpload);
            Controls.Add(btnDevelop);
            Controls.Add(label2);
            Controls.Add(linkRegister);
            Controls.Add(btnPaste);
            Controls.Add(btnToggleUpload);
            Controls.Add(textBoxServer);
            Controls.Add(label1);
            Controls.Add(labelApiKey);
            Controls.Add(labelStatus);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(buttonTestConnection);
            Controls.Add(textBoxApiKey);
            Font = new System.Drawing.Font("Tahoma", 14.25F);
            MinimumSize = new System.Drawing.Size(550, 340);
            Name = "FormAgShareSettings";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "AgShare Settings";
            Load += FormAgShareSettings_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonTestConnection;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelApiKey;
        private System.Windows.Forms.TextBox textBoxApiKey;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxServer;
        private System.Windows.Forms.Button btnToggleUpload;
        private System.Windows.Forms.Button btnPaste;
        private System.Windows.Forms.LinkLabel linkRegister;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDevelop;
        private System.Windows.Forms.Button btnAutoUpload;
    }
}
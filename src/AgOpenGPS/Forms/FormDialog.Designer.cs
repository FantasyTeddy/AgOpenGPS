namespace AgOpenGPS.Forms
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
            labelMessage = new System.Windows.Forms.Label();
            labelTitle = new System.Windows.Forms.Label();
            buttonCancel = new System.Windows.Forms.Button();
            buttonOK = new System.Windows.Forms.Button();
            pictureBoxIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).BeginInit();
            SuspendLayout();
            // 
            // labelMessage
            // 
            labelMessage.BackColor = System.Drawing.Color.Transparent;
            labelMessage.Font = new System.Drawing.Font("Tahoma", 20F);
            labelMessage.Location = new System.Drawing.Point(142, 127);
            labelMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelMessage.Name = "labelMessage";
            labelMessage.Size = new System.Drawing.Size(660, 213);
            labelMessage.TabIndex = 2;
            labelMessage.Text = "Message";
            labelMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTitle
            // 
            labelTitle.BackColor = System.Drawing.Color.Transparent;
            labelTitle.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            labelTitle.Location = new System.Drawing.Point(135, 10);
            labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new System.Drawing.Size(667, 117);
            labelTitle.TabIndex = 99;
            labelTitle.Text = "Title";
            labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            buttonCancel.BackColor = System.Drawing.Color.Transparent;
            buttonCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            buttonCancel.FlatAppearance.BorderSize = 0;
            buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonCancel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            buttonCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            buttonCancel.Image = Properties.Resources.Cancel64;
            buttonCancel.Location = new System.Drawing.Point(551, 361);
            buttonCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new System.Drawing.Size(122, 87);
            buttonCancel.TabIndex = 98;
            buttonCancel.UseVisualStyleBackColor = false;
            // 
            // buttonOK
            // 
            buttonOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            buttonOK.BackColor = System.Drawing.Color.Transparent;
            buttonOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            buttonOK.FlatAppearance.BorderSize = 0;
            buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonOK.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            buttonOK.ForeColor = System.Drawing.SystemColors.ControlText;
            buttonOK.Image = Properties.Resources.OK64;
            buttonOK.Location = new System.Drawing.Point(680, 361);
            buttonOK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new System.Drawing.Size(122, 87);
            buttonOK.TabIndex = 97;
            buttonOK.UseVisualStyleBackColor = false;
            // 
            // pictureBoxIcon
            // 
            pictureBoxIcon.Image = Properties.Resources.Error;
            pictureBoxIcon.Location = new System.Drawing.Point(36, 32);
            pictureBoxIcon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pictureBoxIcon.Name = "pictureBoxIcon";
            pictureBoxIcon.Size = new System.Drawing.Size(75, 74);
            pictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBoxIcon.TabIndex = 100;
            pictureBoxIcon.TabStop = false;
            pictureBoxIcon.Visible = false;
            // 
            // FormDialog
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Lavender;
            ClientSize = new System.Drawing.Size(817, 462);
            ControlBox = false;
            Controls.Add(pictureBoxIcon);
            Controls.Add(buttonOK);
            Controls.Add(buttonCancel);
            Controls.Add(labelTitle);
            Controls.Add(labelMessage);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "FormDialog";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "FormDialog";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.PictureBox pictureBoxIcon;
    }
}
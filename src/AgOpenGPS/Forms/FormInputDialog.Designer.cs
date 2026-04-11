namespace AgOpenGPS.Forms
{
    partial class FormInputDialog
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            labelTitle = new System.Windows.Forms.Label();
            labelPrompt = new System.Windows.Forms.Label();
            textBoxInput = new System.Windows.Forms.TextBox();
            buttonOK = new System.Windows.Forms.Button();
            buttonCancel = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.BackColor = System.Drawing.Color.Transparent;
            labelTitle.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            labelTitle.Location = new System.Drawing.Point(23, 17);
            labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new System.Drawing.Size(770, 75);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Title";
            labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelPrompt
            // 
            labelPrompt.BackColor = System.Drawing.Color.Transparent;
            labelPrompt.Font = new System.Drawing.Font("Tahoma", 14F);
            labelPrompt.Location = new System.Drawing.Point(23, 102);
            labelPrompt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelPrompt.Name = "labelPrompt";
            labelPrompt.Size = new System.Drawing.Size(770, 40);
            labelPrompt.TabIndex = 1;
            labelPrompt.Text = "Prompt";
            labelPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxInput
            // 
            textBoxInput.Font = new System.Drawing.Font("Tahoma", 18F);
            textBoxInput.Location = new System.Drawing.Point(23, 153);
            textBoxInput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new System.Drawing.Size(769, 36);
            textBoxInput.TabIndex = 2;
            // 
            // buttonOK
            // 
            buttonOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            buttonOK.BackColor = System.Drawing.Color.Transparent;
            buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            buttonOK.FlatAppearance.BorderSize = 0;
            buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonOK.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            buttonOK.ForeColor = System.Drawing.SystemColors.ControlText;
            buttonOK.Image = Properties.Resources.OK64;
            buttonOK.Location = new System.Drawing.Point(680, 260);
            buttonOK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new System.Drawing.Size(122, 87);
            buttonOK.TabIndex = 3;
            buttonOK.UseVisualStyleBackColor = false;
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            buttonCancel.BackColor = System.Drawing.Color.Transparent;
            buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            buttonCancel.FlatAppearance.BorderSize = 0;
            buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonCancel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            buttonCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            buttonCancel.Image = Properties.Resources.Cancel64;
            buttonCancel.Location = new System.Drawing.Point(551, 260);
            buttonCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new System.Drawing.Size(122, 87);
            buttonCancel.TabIndex = 4;
            buttonCancel.UseVisualStyleBackColor = false;
            // 
            // FormInputDialog
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Lavender;
            ClientSize = new System.Drawing.Size(817, 360);
            ControlBox = false;
            Controls.Add(labelTitle);
            Controls.Add(labelPrompt);
            Controls.Add(textBoxInput);
            Controls.Add(buttonOK);
            Controls.Add(buttonCancel);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "FormInputDialog";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "FormInputDialog";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelPrompt;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
    }
}

namespace AgIO
{
    partial class FormYes
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
            lblMessage2 = new System.Windows.Forms.Label();
            btnSerialOK = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lblMessage2
            // 
            lblMessage2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            lblMessage2.Location = new System.Drawing.Point(46, 23);
            lblMessage2.Name = "lblMessage2";
            lblMessage2.Size = new System.Drawing.Size(528, 280);
            lblMessage2.TabIndex = 1;
            lblMessage2.Text = "Message 2";
            lblMessage2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSerialOK
            // 
            btnSerialOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnSerialOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnSerialOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnSerialOK.FlatAppearance.BorderSize = 0;
            btnSerialOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSerialOK.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnSerialOK.ForeColor = System.Drawing.SystemColors.ControlText;
            btnSerialOK.Image = Properties.Resources.OK64;
            btnSerialOK.Location = new System.Drawing.Point(490, 266);
            btnSerialOK.Name = "btnSerialOK";
            btnSerialOK.Size = new System.Drawing.Size(105, 90);
            btnSerialOK.TabIndex = 96;
            btnSerialOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnSerialOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            btnCancel.Image = Properties.Resources.Cancel64;
            btnCancel.Location = new System.Drawing.Point(363, 266);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(105, 90);
            btnCancel.TabIndex = 97;
            btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Visible = false;
            // 
            // FormYes
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(240, 200, 200);
            ClientSize = new System.Drawing.Size(594, 348);
            ControlBox = false;
            Controls.Add(btnCancel);
            Controls.Add(btnSerialOK);
            Controls.Add(lblMessage2);
            Font = new System.Drawing.Font("Tahoma", 14.25F);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(6);
            Name = "FormYes";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "AgIO Message";
            TopMost = true;
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblMessage2;
        private System.Windows.Forms.Button btnSerialOK;
        private System.Windows.Forms.Button btnCancel;
    }
}
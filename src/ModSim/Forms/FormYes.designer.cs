namespace ModSim
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
            SuspendLayout();
            // 
            // lblMessage2
            // 
            lblMessage2.AutoSize = true;
            lblMessage2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            lblMessage2.Location = new System.Drawing.Point(46, 71);
            lblMessage2.Name = "lblMessage2";
            lblMessage2.Size = new System.Drawing.Size(137, 29);
            lblMessage2.TabIndex = 1;
            lblMessage2.Text = "Message 2";
            // 
            // btnSerialOK
            // 
            btnSerialOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnSerialOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnSerialOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnSerialOK.FlatAppearance.BorderSize = 2;
            btnSerialOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSerialOK.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnSerialOK.ForeColor = System.Drawing.SystemColors.ControlText;
            btnSerialOK.Location = new System.Drawing.Point(136, 161);
            btnSerialOK.Name = "btnSerialOK";
            btnSerialOK.Size = new System.Drawing.Size(105, 64);
            btnSerialOK.TabIndex = 96;
            btnSerialOK.Text = "Ok";
            btnSerialOK.UseVisualStyleBackColor = true;
            // 
            // FormYes
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(240, 200, 200);
            ClientSize = new System.Drawing.Size(237, 221);
            ControlBox = false;
            Controls.Add(btnSerialOK);
            Controls.Add(lblMessage2);
            Font = new System.Drawing.Font("Tahoma", 14.25F);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(6);
            Name = "FormYes";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "AgTwo Message";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMessage2;
        private System.Windows.Forms.Button btnSerialOK;
    }
}
namespace AgIO
{
    partial class FormPGN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPGN));
            lblMessage2 = new System.Windows.Forms.Label();
            btnSerialOK = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // lblMessage2
            // 
            lblMessage2.AutoSize = true;
            lblMessage2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblMessage2.Location = new System.Drawing.Point(12, 9);
            lblMessage2.Name = "lblMessage2";
            lblMessage2.Size = new System.Drawing.Size(40, 19);
            lblMessage2.TabIndex = 1;
            lblMessage2.Text = "PGN";
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
            btnSerialOK.Location = new System.Drawing.Point(234, 446);
            btnSerialOK.Name = "btnSerialOK";
            btnSerialOK.Size = new System.Drawing.Size(57, 64);
            btnSerialOK.TabIndex = 96;
            btnSerialOK.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            btnSerialOK.UseVisualStyleBackColor = true;
            btnSerialOK.Click += btnSerialOK_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(71, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(88, 19);
            label1.TabIndex = 97;
            label1.Text = "Description";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(12, 42);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(36, 475);
            label2.TabIndex = 98;
            label2.Text = "254\r\n253\r\n252\r\n251\r\n250\r\n\r\n239\r\n238\r\n237\r\n236\r\n235\r\n234\r\n229\r\n\r\n203\r\n202\r\n201\r\n\r\n200\r\n126\r\n123\r\n121\r\n120\r\n\r\n\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(56, 41);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(181, 437);
            label3.TabIndex = 99;
            label3.Text = resources.GetString("label3.Text");
            // 
            // FormPGN
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(287, 506);
            ControlBox = false;
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSerialOK);
            Controls.Add(lblMessage2);
            Font = new System.Drawing.Font("Tahoma", 14.25F);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(6);
            Name = "FormPGN";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "PGN Guide";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMessage2;
        private System.Windows.Forms.Button btnSerialOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
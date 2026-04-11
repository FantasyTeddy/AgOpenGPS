namespace AgOpenGPS
{
    partial class FormTimedMessage
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
            components = new System.ComponentModel.Container();
            lblMessage = new System.Windows.Forms.Label();
            timer1 = new System.Windows.Forms.Timer(components);
            lblMessage2 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            lblMessage.Location = new System.Drawing.Point(3, 0);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new System.Drawing.Size(115, 29);
            lblMessage.TabIndex = 0;
            lblMessage.Text = "Message";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 3000;
            timer1.Tick += timer1_Tick;
            // 
            // lblMessage2
            // 
            lblMessage2.AutoSize = true;
            lblMessage2.Font = new System.Drawing.Font("Tahoma", 18F);
            lblMessage2.Location = new System.Drawing.Point(43, 52);
            lblMessage2.Name = "lblMessage2";
            lblMessage2.Size = new System.Drawing.Size(127, 29);
            lblMessage2.TabIndex = 1;
            lblMessage2.Text = "Message 2";
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.OldLace;
            panel1.Controls.Add(lblMessage2);
            panel1.Controls.Add(lblMessage);
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(7, 7);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(262, 120);
            panel1.TabIndex = 2;
            // 
            // FormTimedMessage
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Red;
            ClientSize = new System.Drawing.Size(276, 134);
            ControlBox = false;
            Controls.Add(panel1);
            Font = new System.Drawing.Font("Tahoma", 14.25F);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(6);
            Name = "FormTimedMessage";
            Padding = new System.Windows.Forms.Padding(7);
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            Text = "AgOpenGPS Message";
            TopMost = true;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblMessage2;
        private System.Windows.Forms.Panel panel1;
    }
}
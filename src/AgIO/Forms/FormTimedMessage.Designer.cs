namespace AgIO
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
            lblTitle = new System.Windows.Forms.Label();
            timer1 = new System.Windows.Forms.Timer(components);
            lblMessage2 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            lblTitle.Location = new System.Drawing.Point(12, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(115, 29);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Message";
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
            lblMessage2.Location = new System.Drawing.Point(75, 71);
            lblMessage2.Name = "lblMessage2";
            lblMessage2.Size = new System.Drawing.Size(127, 29);
            lblMessage2.TabIndex = 1;
            lblMessage2.Text = "Message 2";
            // 
            // FormTimedMessage
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.LightSalmon;
            ClientSize = new System.Drawing.Size(264, 143);
            ControlBox = false;
            Controls.Add(lblMessage2);
            Controls.Add(lblTitle);
            Font = new System.Drawing.Font("Tahoma", 14.25F);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(6);
            Name = "FormTimedMessage";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "AgIO Message";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblMessage2;
    }
}
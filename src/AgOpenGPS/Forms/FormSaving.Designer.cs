namespace AgOpenGPS
{
    partial class FormSaving
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
            panel1 = new System.Windows.Forms.Panel();
            labelBeer = new System.Windows.Forms.Label();
            progressBar = new System.Windows.Forms.ProgressBar();
            listViewSteps = new System.Windows.Forms.ListView();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(255, 192, 128);
            panel1.Controls.Add(labelBeer);
            panel1.Controls.Add(progressBar);
            panel1.Controls.Add(listViewSteps);
            panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            panel1.Location = new System.Drawing.Point(14, 14);
            panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1060, 539);
            panel1.TabIndex = 0;
            // 
            // labelBeer
            // 
            labelBeer.AutoSize = true;
            labelBeer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelBeer.ForeColor = System.Drawing.Color.Green;
            labelBeer.Location = new System.Drawing.Point(268, 423);
            labelBeer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelBeer.Name = "labelBeer";
            labelBeer.Size = new System.Drawing.Size(344, 37);
            labelBeer.TabIndex = 4;
            labelBeer.Text = "✔ See you next time!";
            labelBeer.Visible = false;
            // 
            // progressBar
            // 
            progressBar.Location = new System.Drawing.Point(212, 432);
            progressBar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            progressBar.MarqueeAnimationSpeed = 40;
            progressBar.Name = "progressBar";
            progressBar.Size = new System.Drawing.Size(660, 32);
            progressBar.Step = 20;
            progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            progressBar.TabIndex = 1;
            // 
            // listViewSteps
            // 
            listViewSteps.BackColor = System.Drawing.Color.FromArgb(255, 192, 128);
            listViewSteps.BorderStyle = System.Windows.Forms.BorderStyle.None;
            listViewSteps.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            listViewSteps.ForeColor = System.Drawing.SystemColors.Menu;
            listViewSteps.Location = new System.Drawing.Point(78, 25);
            listViewSteps.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            listViewSteps.Name = "listViewSteps";
            listViewSteps.Size = new System.Drawing.Size(899, 384);
            listViewSteps.TabIndex = 3;
            listViewSteps.UseCompatibleStateImageBehavior = false;
            listViewSteps.View = System.Windows.Forms.View.List;
            // 
            // FormSaving
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(0, 192, 0);
            ClientSize = new System.Drawing.Size(1088, 567);
            ControlBox = false;
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "FormSaving";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "FormSaving";
            TopMost = true;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.ListView listViewSteps;
        private System.Windows.Forms.Label labelBeer;
    }
}
namespace AgIO
{
    partial class FormNumeric
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
            tboxNumber = new System.Windows.Forms.TextBox();
            lblMax = new System.Windows.Forms.Label();
            lblMin = new System.Windows.Forms.Label();
            keypad1 = new Keypad.NumKeypad();
            btnDistanceUp = new AgLibrary.Controls.RepeatButton();
            btnDistanceDn = new AgLibrary.Controls.RepeatButton();
            SuspendLayout();
            // 
            // tboxNumber
            // 
            tboxNumber.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            tboxNumber.Location = new System.Drawing.Point(208, 7);
            tboxNumber.Name = "tboxNumber";
            tboxNumber.ReadOnly = true;
            tboxNumber.Size = new System.Drawing.Size(246, 52);
            tboxNumber.TabIndex = 1;
            tboxNumber.Text = "234.5643";
            tboxNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblMax
            // 
            lblMax.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblMax.Location = new System.Drawing.Point(332, 62);
            lblMax.Name = "lblMax";
            lblMax.Size = new System.Drawing.Size(125, 36);
            lblMax.TabIndex = 6;
            lblMax.Text = "88.8";
            lblMax.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblMin
            // 
            lblMin.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblMin.Location = new System.Drawing.Point(205, 62);
            lblMin.Name = "lblMin";
            lblMin.Size = new System.Drawing.Size(125, 36);
            lblMin.TabIndex = 7;
            lblMin.Text = "-22.8";
            lblMin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // keypad1
            // 
            keypad1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            keypad1.Location = new System.Drawing.Point(0, 112);
            keypad1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            keypad1.Name = "keypad1";
            keypad1.Size = new System.Drawing.Size(454, 429);
            keypad1.TabIndex = 5;
            keypad1.ButtonPressed += RegisterKeypad1_ButtonPressed;
            // 
            // btnDistanceUp
            // 
            btnDistanceUp.BackColor = System.Drawing.SystemColors.Control;
            btnDistanceUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnDistanceUp.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            btnDistanceUp.FlatAppearance.BorderSize = 2;
            btnDistanceUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDistanceUp.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnDistanceUp.Image = Properties.Resources.UpArrow64;
            btnDistanceUp.Location = new System.Drawing.Point(112, 3);
            btnDistanceUp.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            btnDistanceUp.Name = "btnDistanceUp";
            btnDistanceUp.Size = new System.Drawing.Size(91, 92);
            btnDistanceUp.TabIndex = 148;
            btnDistanceUp.UseVisualStyleBackColor = false;
            btnDistanceUp.MouseDown += BtnDistanceUp_MouseDown;
            // 
            // btnDistanceDn
            // 
            btnDistanceDn.BackColor = System.Drawing.SystemColors.Control;
            btnDistanceDn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnDistanceDn.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            btnDistanceDn.FlatAppearance.BorderSize = 2;
            btnDistanceDn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDistanceDn.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnDistanceDn.Image = Properties.Resources.DnArrow64;
            btnDistanceDn.Location = new System.Drawing.Point(4, 3);
            btnDistanceDn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            btnDistanceDn.Name = "btnDistanceDn";
            btnDistanceDn.Size = new System.Drawing.Size(91, 92);
            btnDistanceDn.TabIndex = 147;
            btnDistanceDn.UseVisualStyleBackColor = false;
            btnDistanceDn.MouseDown += BtnDistanceDn_MouseDown;
            // 
            // FormNumeric
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ActiveCaption;
            ClientSize = new System.Drawing.Size(460, 545);
            ControlBox = false;
            Controls.Add(btnDistanceUp);
            Controls.Add(btnDistanceDn);
            Controls.Add(tboxNumber);
            Controls.Add(keypad1);
            Controls.Add(lblMin);
            Controls.Add(lblMax);
            Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormNumeric";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Enter a Value";
            Load += FormNumeric_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tboxNumber;
        private Keypad.NumKeypad keypad1;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblMin;
        private AgLibrary.Controls.RepeatButton btnDistanceUp;
        private AgLibrary.Controls.RepeatButton btnDistanceDn;
    }
}
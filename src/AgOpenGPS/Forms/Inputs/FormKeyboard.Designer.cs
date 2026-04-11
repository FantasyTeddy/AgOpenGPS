namespace AgOpenGPS
{
    partial class FormKeyboard
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
            keyboardString = new System.Windows.Forms.TextBox();
            keyboard1 = new Keypad.Keyboard();
            btnCharLeft = new System.Windows.Forms.Button();
            btnCharRight = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // keyboardString
            // 
            keyboardString.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            keyboardString.Location = new System.Drawing.Point(13, 5);
            keyboardString.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            keyboardString.Name = "keyboardString";
            keyboardString.Size = new System.Drawing.Size(876, 46);
            keyboardString.TabIndex = 0;
            // 
            // keyboard1
            // 
            keyboard1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            keyboard1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            keyboard1.Location = new System.Drawing.Point(6, 63);
            keyboard1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            keyboard1.Name = "keyboard1";
            keyboard1.Size = new System.Drawing.Size(1084, 457);
            keyboard1.TabIndex = 2;
            keyboard1.ButtonPressed += RegisterKeyboard1_ButtonPressed;
            // 
            // btnCharLeft
            // 
            btnCharLeft.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnCharLeft.BackColor = System.Drawing.Color.WhiteSmoke;
            btnCharLeft.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            btnCharLeft.FlatAppearance.BorderSize = 0;
            btnCharLeft.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Turquoise;
            btnCharLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCharLeft.Font = new System.Drawing.Font("Tahoma", 15.75F);
            btnCharLeft.Image = Properties.Resources.ArrowLeft;
            btnCharLeft.Location = new System.Drawing.Point(906, 5);
            btnCharLeft.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCharLeft.Name = "btnCharLeft";
            btnCharLeft.Size = new System.Drawing.Size(85, 52);
            btnCharLeft.TabIndex = 457;
            btnCharLeft.UseVisualStyleBackColor = false;
            btnCharLeft.Click += btnCharLeft_Click;
            // 
            // btnCharRight
            // 
            btnCharRight.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnCharRight.BackColor = System.Drawing.Color.WhiteSmoke;
            btnCharRight.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            btnCharRight.FlatAppearance.BorderSize = 0;
            btnCharRight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Turquoise;
            btnCharRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCharRight.Font = new System.Drawing.Font("Tahoma", 15.75F);
            btnCharRight.Image = Properties.Resources.ArrowRight;
            btnCharRight.Location = new System.Drawing.Point(1003, 5);
            btnCharRight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCharRight.Name = "btnCharRight";
            btnCharRight.Size = new System.Drawing.Size(85, 52);
            btnCharRight.TabIndex = 458;
            btnCharRight.UseVisualStyleBackColor = false;
            btnCharRight.Click += btnCharRight_Click;
            // 
            // FormKeyboard
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ActiveCaption;
            ClientSize = new System.Drawing.Size(1099, 524);
            ControlBox = false;
            Controls.Add(btnCharRight);
            Controls.Add(btnCharLeft);
            Controls.Add(keyboard1);
            Controls.Add(keyboardString);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Location = new System.Drawing.Point(250, 250);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormKeyboard";
            ShowInTaskbar = false;
            Text = "Keyboard";
            Load += FormKeyboard_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox keyboardString;
        private Keypad.Keyboard keyboard1;
        private System.Windows.Forms.Button btnCharLeft;
        private System.Windows.Forms.Button btnCharRight;
    }
}
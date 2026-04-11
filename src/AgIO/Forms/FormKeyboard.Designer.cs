namespace AgIO
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
            SuspendLayout();
            // 
            // keyboardString
            // 
            keyboardString.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            keyboardString.Location = new System.Drawing.Point(114, 5);
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
            keyboard1.Size = new System.Drawing.Size(1085, 457);
            keyboard1.TabIndex = 1;
            keyboard1.ButtonPressed += RegisterKeyboard1_ButtonPressed;
            // 
            // FormKeyboard
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ActiveCaption;
            ClientSize = new System.Drawing.Size(1097, 531);
            ControlBox = false;
            Controls.Add(keyboard1);
            Controls.Add(keyboardString);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Location = new System.Drawing.Point(250, 250);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "FormKeyboard";
            Text = "Keyboard";
            Load += FormKeyboard_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox keyboardString;
        private Keypad.Keyboard keyboard1;
    }
}
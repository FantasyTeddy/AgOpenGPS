namespace AgOpenGPS
{
    partial class FormSimCoords
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
            btnCancel = new System.Windows.Forms.Button();
            bntOK = new System.Windows.Forms.Button();
            nudLongitude = new NudlessNumericUpDown();
            nudLatitude = new NudlessNumericUpDown();
            label18 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)nudLongitude).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudLatitude).BeginInit();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnCancel.BackColor = System.Drawing.Color.Transparent;
            btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancel.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnCancel.Image = Properties.Resources.Cancel64;
            btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnCancel.Location = new System.Drawing.Point(783, 530);
            btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(111, 92);
            btnCancel.TabIndex = 5;
            btnCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // bntOK
            // 
            bntOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            bntOK.BackColor = System.Drawing.Color.Transparent;
            bntOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            bntOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            bntOK.FlatAppearance.BorderSize = 0;
            bntOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            bntOK.Font = new System.Drawing.Font("Tahoma", 14.25F);
            bntOK.Image = Properties.Resources.OK64;
            bntOK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            bntOK.Location = new System.Drawing.Point(913, 530);
            bntOK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            bntOK.Name = "bntOK";
            bntOK.Size = new System.Drawing.Size(159, 92);
            bntOK.TabIndex = 4;
            bntOK.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            bntOK.UseVisualStyleBackColor = false;
            bntOK.Click += bntOK_Click;
            // 
            // nudLongitude
            // 
            nudLongitude.BackColor = System.Drawing.Color.White;
            nudLongitude.DecimalPlaces = 7;
            nudLongitude.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            nudLongitude.Location = new System.Drawing.Point(397, 557);
            nudLongitude.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            nudLongitude.Maximum = new decimal(new int[] { 180, 0, 0, 0 });
            nudLongitude.Minimum = new decimal(new int[] { 180, 0, 0, int.MinValue });
            nudLongitude.Name = "nudLongitude";
            nudLongitude.ReadOnly = true;
            nudLongitude.Size = new System.Drawing.Size(348, 52);
            nudLongitude.TabIndex = 48;
            nudLongitude.Value = new decimal(new int[] { 1781234567, 0, 0, -2147024896 });
            nudLongitude.Click += nud_Click;
            // 
            // nudLatitude
            // 
            nudLatitude.BackColor = System.Drawing.Color.White;
            nudLatitude.DecimalPlaces = 7;
            nudLatitude.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            nudLatitude.Location = new System.Drawing.Point(34, 557);
            nudLatitude.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            nudLatitude.Maximum = new decimal(new int[] { 90, 0, 0, 0 });
            nudLatitude.Minimum = new decimal(new int[] { 90, 0, 0, int.MinValue });
            nudLatitude.Name = "nudLatitude";
            nudLatitude.ReadOnly = true;
            nudLatitude.Size = new System.Drawing.Size(320, 52);
            nudLatitude.TabIndex = 49;
            nudLatitude.Value = new decimal(new int[] { 881234567, 0, 0, -2147024896 });
            nudLatitude.Click += nud_Click;
            // 
            // label18
            // 
            label18.Font = new System.Drawing.Font("Tahoma", 15.75F);
            label18.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label18.Location = new System.Drawing.Point(43, 496);
            label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label18.Name = "label18";
            label18.Size = new System.Drawing.Size(294, 29);
            label18.TabIndex = 178;
            label18.Text = "Latitude";
            label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new System.Drawing.Font("Tahoma", 15.75F);
            label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label1.Location = new System.Drawing.Point(407, 496);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(314, 29);
            label1.TabIndex = 179;
            label1.Text = "Longitude";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Tahoma", 15.75F);
            label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label8.Location = new System.Drawing.Point(107, 525);
            label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(134, 25);
            label8.TabIndex = 195;
            label8.Text = "( +90 to -90)";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Tahoma", 15.75F);
            label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label9.Location = new System.Drawing.Point(469, 525);
            label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(163, 25);
            label9.TabIndex = 196;
            label9.Text = "( +180 to -180 )";
            // 
            // label2
            // 
            label2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label2.Location = new System.Drawing.Point(65, 67);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(41, 295);
            label2.TabIndex = 197;
            label2.Text = "L\r\na\r\nt\r\ni\r\nt\r\nu\r\nd\r\ne";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label3.Location = new System.Drawing.Point(316, 357);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(314, 42);
            label3.TabIndex = 198;
            label3.Text = "Longitude";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormSimCoords
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Gainsboro;
            BackgroundImage = Properties.Resources.LatLon;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            ClientSize = new System.Drawing.Size(1086, 636);
            ControlBox = false;
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label1);
            Controls.Add(label18);
            Controls.Add(nudLatitude);
            Controls.Add(nudLongitude);
            Controls.Add(btnCancel);
            Controls.Add(bntOK);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "FormSimCoords";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Enter Coordinates For Simulator";
            Load += FormSimCoords_Load;
            ((System.ComponentModel.ISupportInitialize)nudLongitude).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudLatitude).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button bntOK;
        private NudlessNumericUpDown nudLongitude;
        private NudlessNumericUpDown nudLatitude;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
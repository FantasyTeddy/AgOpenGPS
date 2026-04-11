namespace AgOpenGPS
{
    partial class FormEnterFlag
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
            label9 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label18 = new System.Windows.Forms.Label();
            labelPoint = new System.Windows.Forms.Label();
            btnCancel = new System.Windows.Forms.Button();
            btnYellow = new System.Windows.Forms.Button();
            btnRed = new System.Windows.Forms.Button();
            btnGreen = new System.Windows.Forms.Button();
            btnImportFlags = new System.Windows.Forms.Button();
            btnExportFlags = new System.Windows.Forms.Button();
            nudLatitude = new NudlessNumericUpDown();
            nudLongitude = new NudlessNumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nudLatitude).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudLongitude).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Tahoma", 15.75F);
            label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label9.Location = new System.Drawing.Point(595, 46);
            label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(163, 25);
            label9.TabIndex = 202;
            label9.Text = "( +180 to -180 )";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Tahoma", 15.75F);
            label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label8.Location = new System.Drawing.Point(251, 46);
            label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(134, 25);
            label8.TabIndex = 201;
            label8.Text = "( +90 to -90)";
            // 
            // label1
            // 
            label1.Font = new System.Drawing.Font("Tahoma", 15.75F);
            label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label1.Location = new System.Drawing.Point(533, 17);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(314, 29);
            label1.TabIndex = 200;
            label1.Text = "Longitude";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            label18.Font = new System.Drawing.Font("Tahoma", 15.75F);
            label18.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label18.Location = new System.Drawing.Point(187, 17);
            label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label18.Name = "label18";
            label18.Size = new System.Drawing.Size(294, 29);
            label18.TabIndex = 199;
            label18.Text = "Latitude";
            label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPoint
            // 
            labelPoint.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelPoint.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            labelPoint.Location = new System.Drawing.Point(26, 88);
            labelPoint.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelPoint.Name = "labelPoint";
            labelPoint.Size = new System.Drawing.Size(146, 39);
            labelPoint.TabIndex = 205;
            labelPoint.Text = "Point A";
            labelPoint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = System.Drawing.Color.Transparent;
            btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancel.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnCancel.Image = Properties.Resources.Cancel64;
            btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnCancel.Location = new System.Drawing.Point(482, 217);
            btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(102, 67);
            btnCancel.TabIndex = 430;
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnYellow
            // 
            btnYellow.BackColor = System.Drawing.Color.Transparent;
            btnYellow.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            btnYellow.FlatAppearance.BorderSize = 0;
            btnYellow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnYellow.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnYellow.Image = Properties.Resources.FlagYel;
            btnYellow.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnYellow.Location = new System.Drawing.Point(601, 222);
            btnYellow.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnYellow.Name = "btnYellow";
            btnYellow.Size = new System.Drawing.Size(102, 67);
            btnYellow.TabIndex = 431;
            btnYellow.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnYellow.UseVisualStyleBackColor = false;
            btnYellow.Click += btnRed_Click;
            // 
            // btnRed
            // 
            btnRed.BackColor = System.Drawing.Color.Transparent;
            btnRed.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            btnRed.FlatAppearance.BorderSize = 0;
            btnRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRed.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnRed.Image = Properties.Resources.FlagRed;
            btnRed.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnRed.Location = new System.Drawing.Point(784, 223);
            btnRed.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnRed.Name = "btnRed";
            btnRed.Size = new System.Drawing.Size(102, 67);
            btnRed.TabIndex = 432;
            btnRed.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnRed.UseVisualStyleBackColor = false;
            btnRed.Click += btnRed_Click;
            // 
            // btnGreen
            // 
            btnGreen.BackColor = System.Drawing.Color.Transparent;
            btnGreen.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            btnGreen.FlatAppearance.BorderSize = 0;
            btnGreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnGreen.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnGreen.Image = Properties.Resources.FlagGrn;
            btnGreen.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnGreen.Location = new System.Drawing.Point(696, 222);
            btnGreen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnGreen.Name = "btnGreen";
            btnGreen.Size = new System.Drawing.Size(102, 67);
            btnGreen.TabIndex = 433;
            btnGreen.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnGreen.UseVisualStyleBackColor = false;
            btnGreen.Click += btnRed_Click;
            // 
            // btnImportFlags
            // 
            btnImportFlags.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            btnImportFlags.Location = new System.Drawing.Point(15, 207);
            btnImportFlags.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            btnImportFlags.Name = "btnImportFlags";
            btnImportFlags.Size = new System.Drawing.Size(206, 82);
            btnImportFlags.TabIndex = 434;
            btnImportFlags.Text = "Import Flags";
            btnImportFlags.UseVisualStyleBackColor = true;
            btnImportFlags.Click += btnImportFlags_Click;
            // 
            // btnExportFlags
            // 
            btnExportFlags.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            btnExportFlags.Location = new System.Drawing.Point(246, 208);
            btnExportFlags.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            btnExportFlags.Name = "btnExportFlags";
            btnExportFlags.Size = new System.Drawing.Size(200, 82);
            btnExportFlags.TabIndex = 435;
            btnExportFlags.Text = "Export Flags";
            btnExportFlags.UseVisualStyleBackColor = true;
            btnExportFlags.Click += btnExportFlags_Click;
            // 
            // nudLatitude
            // 
            nudLatitude.BackColor = System.Drawing.Color.AliceBlue;
            nudLatitude.DecimalPlaces = 7;
            nudLatitude.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            nudLatitude.Location = new System.Drawing.Point(177, 78);
            nudLatitude.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            nudLatitude.Maximum = new decimal(new int[] { 90, 0, 0, 0 });
            nudLatitude.Minimum = new decimal(new int[] { 90, 0, 0, int.MinValue });
            nudLatitude.Name = "nudLatitude";
            nudLatitude.Size = new System.Drawing.Size(320, 52);
            nudLatitude.TabIndex = 198;
            nudLatitude.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudLatitude.Value = new decimal(new int[] { 0, 0, 0, 0 });
            nudLatitude.Click += nudLatitude_Click;
            // 
            // nudLongitude
            // 
            nudLongitude.BackColor = System.Drawing.Color.AliceBlue;
            nudLongitude.DecimalPlaces = 7;
            nudLongitude.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            nudLongitude.Location = new System.Drawing.Point(523, 78);
            nudLongitude.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            nudLongitude.Maximum = new decimal(new int[] { 180, 0, 0, 0 });
            nudLongitude.Minimum = new decimal(new int[] { 180, 0, 0, int.MinValue });
            nudLongitude.Name = "nudLongitude";
            nudLongitude.Size = new System.Drawing.Size(348, 52);
            nudLongitude.TabIndex = 197;
            nudLongitude.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudLongitude.Value = new decimal(new int[] { 0, 0, 0, 0 });
            nudLongitude.Click += nudLongitude_Click;
            // 
            // FormEnterFlag
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.WhiteSmoke;
            ClientSize = new System.Drawing.Size(899, 307);
            ControlBox = false;
            Controls.Add(btnExportFlags);
            Controls.Add(btnImportFlags);
            Controls.Add(btnGreen);
            Controls.Add(btnRed);
            Controls.Add(btnYellow);
            Controls.Add(btnCancel);
            Controls.Add(labelPoint);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label1);
            Controls.Add(label18);
            Controls.Add(nudLatitude);
            Controls.Add(nudLongitude);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "FormEnterFlag";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Enter AB or A+";
            Load += FormEnterAB_Load;
            ((System.ComponentModel.ISupportInitialize)nudLatitude).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudLongitude).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label18;
        private NudlessNumericUpDown nudLatitude;
        private NudlessNumericUpDown nudLongitude;
        private System.Windows.Forms.Label labelPoint;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnYellow;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnGreen;
        private System.Windows.Forms.Button btnImportFlags;
        private System.Windows.Forms.Button btnExportFlags;
    }
}
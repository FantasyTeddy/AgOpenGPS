namespace AgOpenGPS
{
    partial class FormShiftPos
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
            nudNorth = new NudlessNumericUpDown();
            nudEast = new NudlessNumericUpDown();
            label27 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            btnSouth = new AgLibrary.Controls.RepeatButton();
            btnNorth = new AgLibrary.Controls.RepeatButton();
            btnEast = new AgLibrary.Controls.RepeatButton();
            btnWest = new AgLibrary.Controls.RepeatButton();
            bntOK = new System.Windows.Forms.Button();
            btnZero = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            chkOffsetsOn = new System.Windows.Forms.CheckBox();
            label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)nudNorth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudEast).BeginInit();
            SuspendLayout();
            // 
            // nudNorth
            // 
            nudNorth.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold);
            nudNorth.Location = new System.Drawing.Point(71, 295);
            nudNorth.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            nudNorth.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            nudNorth.Minimum = new decimal(new int[] { 9999, 0, 0, int.MinValue });
            nudNorth.Name = "nudNorth";
            nudNorth.RightToLeft = System.Windows.Forms.RightToLeft.No;
            nudNorth.Size = new System.Drawing.Size(216, 65);
            nudNorth.TabIndex = 154;
            nudNorth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudNorth.ThousandsSeparator = true;
            nudNorth.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            nudNorth.Value = new decimal(new int[] { 9999, 0, 0, int.MinValue });
            nudNorth.Click += nudNorth_Click;
            // 
            // nudEast
            // 
            nudEast.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold);
            nudEast.Location = new System.Drawing.Point(451, 295);
            nudEast.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            nudEast.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            nudEast.Minimum = new decimal(new int[] { 9999, 0, 0, int.MinValue });
            nudEast.Name = "nudEast";
            nudEast.RightToLeft = System.Windows.Forms.RightToLeft.No;
            nudEast.Size = new System.Drawing.Size(216, 65);
            nudEast.TabIndex = 155;
            nudEast.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudEast.ThousandsSeparator = true;
            nudEast.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            nudEast.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nudEast.Click += nudEast_Click;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label27.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label27.Location = new System.Drawing.Point(107, 171);
            label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label27.Name = "label27";
            label27.Size = new System.Drawing.Size(115, 25);
            label27.TabIndex = 156;
            label27.Text = "North (+)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label2.Location = new System.Drawing.Point(500, 171);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(101, 25);
            label2.TabIndex = 158;
            label2.Text = "West (-)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label3.Location = new System.Drawing.Point(503, 473);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(101, 25);
            label3.TabIndex = 159;
            label3.Text = "East (+)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label4.Location = new System.Drawing.Point(106, 473);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(108, 25);
            label4.TabIndex = 160;
            label4.Text = "South (-)";
            // 
            // btnSouth
            // 
            btnSouth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnSouth.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            btnSouth.Image = Properties.Resources.DnArrow64;
            btnSouth.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnSouth.Location = new System.Drawing.Point(120, 387);
            btnSouth.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSouth.Name = "btnSouth";
            btnSouth.Size = new System.Drawing.Size(84, 83);
            btnSouth.TabIndex = 192;
            btnSouth.UseVisualStyleBackColor = true;
            btnSouth.MouseDown += btnSouth_MouseDown;
            // 
            // btnNorth
            // 
            btnNorth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnNorth.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            btnNorth.Image = Properties.Resources.UpArrow64;
            btnNorth.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnNorth.Location = new System.Drawing.Point(120, 201);
            btnNorth.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnNorth.Name = "btnNorth";
            btnNorth.Size = new System.Drawing.Size(84, 83);
            btnNorth.TabIndex = 193;
            btnNorth.UseVisualStyleBackColor = true;
            btnNorth.MouseDown += btnNorth_MouseDown;
            // 
            // btnEast
            // 
            btnEast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnEast.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            btnEast.Image = Properties.Resources.ArrowRight;
            btnEast.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnEast.Location = new System.Drawing.Point(511, 387);
            btnEast.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnEast.Name = "btnEast";
            btnEast.Size = new System.Drawing.Size(84, 83);
            btnEast.TabIndex = 194;
            btnEast.UseVisualStyleBackColor = true;
            btnEast.MouseDown += btnEast_MouseDown;
            // 
            // btnWest
            // 
            btnWest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnWest.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            btnWest.Image = Properties.Resources.ArrowLeft;
            btnWest.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnWest.Location = new System.Drawing.Point(511, 201);
            btnWest.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnWest.Name = "btnWest";
            btnWest.Size = new System.Drawing.Size(84, 83);
            btnWest.TabIndex = 195;
            btnWest.UseVisualStyleBackColor = true;
            btnWest.MouseDown += btnWest_MouseDown;
            // 
            // bntOK
            // 
            bntOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            bntOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            bntOK.Font = new System.Drawing.Font("Tahoma", 14.25F);
            bntOK.Image = Properties.Resources.OK64;
            bntOK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            bntOK.Location = new System.Drawing.Point(586, 688);
            bntOK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            bntOK.Name = "bntOK";
            bntOK.Size = new System.Drawing.Size(168, 76);
            bntOK.TabIndex = 196;
            bntOK.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            bntOK.UseVisualStyleBackColor = true;
            bntOK.Click += bntOK_Click;
            // 
            // btnZero
            // 
            btnZero.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnZero.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnZero.Location = new System.Drawing.Point(29, 688);
            btnZero.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnZero.Name = "btnZero";
            btnZero.Size = new System.Drawing.Size(108, 76);
            btnZero.TabIndex = 227;
            btnZero.Text = "> 0 <";
            btnZero.UseVisualStyleBackColor = true;
            btnZero.Click += btnZero_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label1.Location = new System.Drawing.Point(290, 322);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(57, 33);
            label1.TabIndex = 228;
            label1.Text = "CM";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label5.Location = new System.Drawing.Point(670, 322);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(57, 33);
            label5.TabIndex = 229;
            label5.Text = "CM";
            // 
            // label6
            // 
            label6.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label6.Location = new System.Drawing.Point(82, 10);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(604, 132);
            label6.TabIndex = 230;
            label6.Text = "This offset distance is added to Lat and Lon and saved in FIELD.KML file when closing the field.";
            // 
            // chkOffsetsOn
            // 
            chkOffsetsOn.Appearance = System.Windows.Forms.Appearance.Button;
            chkOffsetsOn.BackColor = System.Drawing.Color.AliceBlue;
            chkOffsetsOn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            chkOffsetsOn.FlatAppearance.CheckedBackColor = System.Drawing.Color.MediumAquamarine;
            chkOffsetsOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            chkOffsetsOn.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            chkOffsetsOn.ForeColor = System.Drawing.SystemColors.ControlText;
            chkOffsetsOn.Location = new System.Drawing.Point(108, 540);
            chkOffsetsOn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chkOffsetsOn.Name = "chkOffsetsOn";
            chkOffsetsOn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            chkOffsetsOn.Size = new System.Drawing.Size(127, 90);
            chkOffsetsOn.TabIndex = 491;
            chkOffsetsOn.Text = "Off";
            chkOffsetsOn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            chkOffsetsOn.UseVisualStyleBackColor = false;
            chkOffsetsOn.Click += chkOffsetsOn_Click;
            // 
            // label7
            // 
            label7.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label7.Location = new System.Drawing.Point(243, 548);
            label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(394, 82);
            label7.TabIndex = 492;
            label7.Text = "Keep offset even after field is closed?";
            // 
            // FormShiftPos
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(768, 778);
            ControlBox = false;
            Controls.Add(label7);
            Controls.Add(chkOffsetsOn);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(btnZero);
            Controls.Add(bntOK);
            Controls.Add(btnEast);
            Controls.Add(btnWest);
            Controls.Add(btnSouth);
            Controls.Add(btnNorth);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label27);
            Controls.Add(nudEast);
            Controls.Add(nudNorth);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormShiftPos";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Shift GPS Position (cm)";
            Load += FormShiftPos_Load;
            ((System.ComponentModel.ISupportInitialize)nudNorth).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudEast).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private NudlessNumericUpDown nudNorth;
        private NudlessNumericUpDown nudEast;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private AgLibrary.Controls.RepeatButton btnSouth;
        private AgLibrary.Controls.RepeatButton btnNorth;
        private AgLibrary.Controls.RepeatButton btnEast;
        private AgLibrary.Controls.RepeatButton btnWest;
        private System.Windows.Forms.Button bntOK;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkOffsetsOn;
        private System.Windows.Forms.Label label7;
    }
}
namespace AgIO
{
    partial class FormEthernet
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
            groupBox3 = new System.Windows.Forms.GroupBox();
            nudFourthIP = new System.Windows.Forms.NumericUpDown();
            nudThirdIP = new System.Windows.Forms.NumericUpDown();
            nudFirstIP = new System.Windows.Forms.NumericUpDown();
            nudSecndIP = new System.Windows.Forms.NumericUpDown();
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            cboxIsUDPOn = new System.Windows.Forms.CheckBox();
            btnSerialCancel = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudFourthIP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudThirdIP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudFirstIP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSecndIP).BeginInit();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(nudFourthIP);
            groupBox3.Controls.Add(nudThirdIP);
            groupBox3.Controls.Add(nudFirstIP);
            groupBox3.Controls.Add(nudSecndIP);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            groupBox3.Location = new System.Drawing.Point(12, 54);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(401, 119);
            groupBox3.TabIndex = 94;
            groupBox3.TabStop = false;
            groupBox3.Text = "Linux Only !";
            // 
            // nudFourthIP
            // 
            nudFourthIP.BackColor = System.Drawing.Color.AliceBlue;
            nudFourthIP.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            nudFourthIP.Location = new System.Drawing.Point(303, 53);
            nudFourthIP.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            nudFourthIP.Name = "nudFourthIP";
            nudFourthIP.Size = new System.Drawing.Size(77, 33);
            nudFourthIP.TabIndex = 530;
            nudFourthIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudFourthIP.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            nudFourthIP.Value = new decimal(new int[] { 255, 0, 0, 0 });
            nudFourthIP.Click += nudFirstIP_Click;
            // 
            // nudThirdIP
            // 
            nudThirdIP.BackColor = System.Drawing.Color.AliceBlue;
            nudThirdIP.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            nudThirdIP.Location = new System.Drawing.Point(215, 53);
            nudThirdIP.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            nudThirdIP.Name = "nudThirdIP";
            nudThirdIP.Size = new System.Drawing.Size(77, 33);
            nudThirdIP.TabIndex = 527;
            nudThirdIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudThirdIP.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            nudThirdIP.Value = new decimal(new int[] { 255, 0, 0, 0 });
            nudThirdIP.Click += nudFirstIP_Click;
            // 
            // nudFirstIP
            // 
            nudFirstIP.BackColor = System.Drawing.Color.AliceBlue;
            nudFirstIP.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            nudFirstIP.Location = new System.Drawing.Point(30, 53);
            nudFirstIP.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            nudFirstIP.Name = "nudFirstIP";
            nudFirstIP.Size = new System.Drawing.Size(77, 33);
            nudFirstIP.TabIndex = 525;
            nudFirstIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudFirstIP.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            nudFirstIP.Value = new decimal(new int[] { 127, 0, 0, 0 });
            nudFirstIP.Click += nudFirstIP_Click;
            // 
            // nudSecndIP
            // 
            nudSecndIP.BackColor = System.Drawing.Color.AliceBlue;
            nudSecndIP.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            nudSecndIP.Location = new System.Drawing.Point(122, 53);
            nudSecndIP.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            nudSecndIP.Name = "nudSecndIP";
            nudSecndIP.Size = new System.Drawing.Size(77, 33);
            nudSecndIP.TabIndex = 526;
            nudSecndIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudSecndIP.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            nudSecndIP.Value = new decimal(new int[] { 255, 0, 0, 0 });
            nudSecndIP.Click += nudFirstIP_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(288, 47);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(18, 25);
            label1.TabIndex = 531;
            label1.Text = ".";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(198, 47);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(18, 25);
            label3.TabIndex = 529;
            label3.Text = ".";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(105, 47);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(18, 25);
            label2.TabIndex = 528;
            label2.Text = ".";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboxIsUDPOn
            // 
            cboxIsUDPOn.Appearance = System.Windows.Forms.Appearance.Button;
            cboxIsUDPOn.BackColor = System.Drawing.Color.LightSalmon;
            cboxIsUDPOn.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            cboxIsUDPOn.FlatAppearance.CheckedBackColor = System.Drawing.Color.PaleGreen;
            cboxIsUDPOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboxIsUDPOn.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            cboxIsUDPOn.Location = new System.Drawing.Point(573, 65);
            cboxIsUDPOn.Name = "cboxIsUDPOn";
            cboxIsUDPOn.Size = new System.Drawing.Size(181, 61);
            cboxIsUDPOn.TabIndex = 92;
            cboxIsUDPOn.Text = "UDP Is Off";
            cboxIsUDPOn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            cboxIsUDPOn.UseVisualStyleBackColor = false;
            cboxIsUDPOn.Click += cboxIsUDPOn_Click;
            // 
            // btnSerialCancel
            // 
            btnSerialCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnSerialCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnSerialCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnSerialCancel.FlatAppearance.BorderSize = 0;
            btnSerialCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSerialCancel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnSerialCancel.Image = Properties.Resources.OK64;
            btnSerialCancel.Location = new System.Drawing.Point(624, 163);
            btnSerialCancel.Name = "btnSerialCancel";
            btnSerialCancel.Size = new System.Drawing.Size(92, 79);
            btnSerialCancel.TabIndex = 71;
            btnSerialCancel.UseVisualStyleBackColor = true;
            btnSerialCancel.Click += btnSerialCancel_Click;
            // 
            // label4
            // 
            label4.BackColor = System.Drawing.Color.White;
            label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label4.Location = new System.Drawing.Point(589, 10);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(146, 50);
            label4.TabIndex = 532;
            label4.Text = "Turn UDP On And Hit OK";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormEthernet
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(772, 254);
            ControlBox = false;
            Controls.Add(label4);
            Controls.Add(cboxIsUDPOn);
            Controls.Add(groupBox3);
            Controls.Add(btnSerialCancel);
            Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormEthernet";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Ethernet Configuration";
            Load += FormUDp_Load;
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudFourthIP).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudThirdIP).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudFirstIP).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSecndIP).EndInit();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSerialCancel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cboxIsUDPOn;
        private System.Windows.Forms.NumericUpDown nudThirdIP;
        private System.Windows.Forms.NumericUpDown nudSecndIP;
        private System.Windows.Forms.NumericUpDown nudFirstIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudFourthIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}
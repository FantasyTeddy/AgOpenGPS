
namespace AgIO
{
    partial class FormRadioChannel
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
            labelName = new System.Windows.Forms.Label();
            tbName = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            tbFrequency = new System.Windows.Forms.TextBox();
            labelLat = new System.Windows.Forms.Label();
            tbLat = new System.Windows.Forms.TextBox();
            btnSerialCancel = new System.Windows.Forms.Button();
            btnSerialOK = new System.Windows.Forms.Button();
            tbId = new System.Windows.Forms.TextBox();
            labelId = new System.Windows.Forms.Label();
            tbLon = new System.Windows.Forms.TextBox();
            labelLon = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelName.Location = new System.Drawing.Point(40, 59);
            labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelName.Name = "labelName";
            labelName.Size = new System.Drawing.Size(48, 16);
            labelName.TabIndex = 7;
            labelName.Text = "Name";
            // 
            // tbName
            // 
            tbName.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tbName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tbName.Location = new System.Drawing.Point(103, 55);
            tbName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tbName.MinimumSize = new System.Drawing.Size(284, 20);
            tbName.Name = "tbName";
            tbName.Size = new System.Drawing.Size(417, 23);
            tbName.TabIndex = 1;
            tbName.Click += tbox_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(2, 100);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(80, 16);
            label1.TabIndex = 8;
            label1.Text = "Frequency";
            // 
            // tbFrequency
            // 
            tbFrequency.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tbFrequency.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tbFrequency.Location = new System.Drawing.Point(103, 97);
            tbFrequency.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tbFrequency.MinimumSize = new System.Drawing.Size(284, 20);
            tbFrequency.Name = "tbFrequency";
            tbFrequency.Size = new System.Drawing.Size(417, 23);
            tbFrequency.TabIndex = 2;
            tbFrequency.Click += tbox_Click;
            // 
            // labelLat
            // 
            labelLat.AutoSize = true;
            labelLat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelLat.Location = new System.Drawing.Point(23, 144);
            labelLat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelLat.Name = "labelLat";
            labelLat.Size = new System.Drawing.Size(62, 16);
            labelLat.TabIndex = 9;
            labelLat.Text = "Latitude";
            // 
            // tbLat
            // 
            tbLat.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tbLat.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tbLat.Location = new System.Drawing.Point(103, 141);
            tbLat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tbLat.MinimumSize = new System.Drawing.Size(284, 20);
            tbLat.Name = "tbLat";
            tbLat.Size = new System.Drawing.Size(417, 23);
            tbLat.TabIndex = 3;
            tbLat.Click += tbox_Click;
            // 
            // btnSerialCancel
            // 
            btnSerialCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnSerialCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnSerialCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnSerialCancel.FlatAppearance.BorderSize = 0;
            btnSerialCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSerialCancel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnSerialCancel.Image = Properties.Resources.Cancel64;
            btnSerialCancel.Location = new System.Drawing.Point(251, 225);
            btnSerialCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSerialCancel.Name = "btnSerialCancel";
            btnSerialCancel.Size = new System.Drawing.Size(103, 72);
            btnSerialCancel.TabIndex = 5;
            btnSerialCancel.UseVisualStyleBackColor = true;
            // 
            // btnSerialOK
            // 
            btnSerialOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnSerialOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnSerialOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnSerialOK.FlatAppearance.BorderSize = 0;
            btnSerialOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSerialOK.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnSerialOK.ForeColor = System.Drawing.SystemColors.ControlText;
            btnSerialOK.Image = Properties.Resources.OK64;
            btnSerialOK.Location = new System.Drawing.Point(399, 225);
            btnSerialOK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSerialOK.Name = "btnSerialOK";
            btnSerialOK.Size = new System.Drawing.Size(103, 72);
            btnSerialOK.TabIndex = 4;
            btnSerialOK.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            btnSerialOK.UseVisualStyleBackColor = true;
            btnSerialOK.Click += btnSerialOK_Click;
            // 
            // tbId
            // 
            tbId.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tbId.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tbId.Location = new System.Drawing.Point(103, 14);
            tbId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tbId.MinimumSize = new System.Drawing.Size(284, 20);
            tbId.Name = "tbId";
            tbId.Size = new System.Drawing.Size(417, 23);
            tbId.TabIndex = 0;
            tbId.Click += tbox_Click;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelId.Location = new System.Drawing.Point(72, 17);
            labelId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelId.Name = "labelId";
            labelId.Size = new System.Drawing.Size(20, 16);
            labelId.TabIndex = 6;
            labelId.Text = "Id";
            // 
            // tbLon
            // 
            tbLon.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tbLon.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tbLon.Location = new System.Drawing.Point(103, 182);
            tbLon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tbLon.MinimumSize = new System.Drawing.Size(284, 20);
            tbLon.Name = "tbLon";
            tbLon.Size = new System.Drawing.Size(417, 23);
            tbLon.TabIndex = 10;
            // 
            // labelLon
            // 
            labelLon.AutoSize = true;
            labelLon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelLon.Location = new System.Drawing.Point(8, 186);
            labelLon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelLon.Name = "labelLon";
            labelLon.Size = new System.Drawing.Size(75, 16);
            labelLon.TabIndex = 11;
            labelLon.Text = "Longitude";
            // 
            // FormRadioChannel
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(524, 339);
            ControlBox = false;
            Controls.Add(tbLon);
            Controls.Add(labelLon);
            Controls.Add(tbId);
            Controls.Add(labelId);
            Controls.Add(btnSerialCancel);
            Controls.Add(btnSerialOK);
            Controls.Add(tbLat);
            Controls.Add(labelLat);
            Controls.Add(tbFrequency);
            Controls.Add(label1);
            Controls.Add(tbName);
            Controls.Add(labelName);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MinimumSize = new System.Drawing.Size(540, 352);
            Name = "FormRadioChannel";
            ShowIcon = false;
            Text = "Radio Channel";
            Load += FormRadioChannel_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFrequency;
        private System.Windows.Forms.Label labelLat;
        private System.Windows.Forms.TextBox tbLat;
        private System.Windows.Forms.Button btnSerialCancel;
        private System.Windows.Forms.Button btnSerialOK;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox tbLon;
        private System.Windows.Forms.Label labelLon;
    }
}
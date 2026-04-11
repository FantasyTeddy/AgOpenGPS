namespace AgOpenGPS
{
    partial class FormSmoothAB
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
            btnSouth = new AgLibrary.Controls.RepeatButton();
            btnNorth = new AgLibrary.Controls.RepeatButton();
            bntOK = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            btnSave = new System.Windows.Forms.Button();
            lblSmooth = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // btnSouth
            // 
            btnSouth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnSouth.FlatAppearance.BorderSize = 0;
            btnSouth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSouth.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            btnSouth.Image = Properties.Resources.DnArrow64;
            btnSouth.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnSouth.Location = new System.Drawing.Point(38, 14);
            btnSouth.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSouth.Name = "btnSouth";
            btnSouth.Size = new System.Drawing.Size(84, 83);
            btnSouth.TabIndex = 195;
            btnSouth.UseVisualStyleBackColor = true;
            btnSouth.MouseDown += btnSouth_MouseDown;
            // 
            // btnNorth
            // 
            btnNorth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnNorth.FlatAppearance.BorderSize = 0;
            btnNorth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNorth.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            btnNorth.Image = Properties.Resources.UpArrow64;
            btnNorth.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnNorth.Location = new System.Drawing.Point(152, 14);
            btnNorth.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnNorth.Name = "btnNorth";
            btnNorth.Size = new System.Drawing.Size(84, 83);
            btnNorth.TabIndex = 196;
            btnNorth.UseVisualStyleBackColor = true;
            btnNorth.MouseDown += btnNorth_MouseDown;
            // 
            // bntOK
            // 
            bntOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            bntOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            bntOK.FlatAppearance.BorderSize = 0;
            bntOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            bntOK.Font = new System.Drawing.Font("Tahoma", 14.25F);
            bntOK.Image = Properties.Resources.FileDontSave;
            bntOK.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            bntOK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            bntOK.Location = new System.Drawing.Point(14, 207);
            bntOK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            bntOK.Name = "bntOK";
            bntOK.Size = new System.Drawing.Size(108, 107);
            bntOK.TabIndex = 197;
            bntOK.Text = "For Now";
            bntOK.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            bntOK.UseVisualStyleBackColor = true;
            bntOK.Click += bntOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnCancel.Image = Properties.Resources.Cancel64;
            btnCancel.Location = new System.Drawing.Point(152, 344);
            btnCancel.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(108, 95);
            btnCancel.TabIndex = 198;
            btnCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSave.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnSave.Image = Properties.Resources.FileSave;
            btnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnSave.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnSave.Location = new System.Drawing.Point(152, 207);
            btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(108, 107);
            btnSave.TabIndex = 199;
            btnSave.Text = "To File";
            btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lblSmooth
            // 
            lblSmooth.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lblSmooth.AutoSize = true;
            lblSmooth.BackColor = System.Drawing.Color.Transparent;
            lblSmooth.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblSmooth.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            lblSmooth.Location = new System.Drawing.Point(85, 111);
            lblSmooth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblSmooth.Name = "lblSmooth";
            lblSmooth.Size = new System.Drawing.Size(87, 58);
            lblSmooth.TabIndex = 200;
            lblSmooth.Text = "99";
            // 
            // FormSmoothAB
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.WhiteSmoke;
            ClientSize = new System.Drawing.Size(270, 453);
            ControlBox = false;
            Controls.Add(lblSmooth);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(bntOK);
            Controls.Add(btnSouth);
            Controls.Add(btnNorth);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "FormSmoothAB";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Smooth AB Curve";
            Load += FormSmoothAB_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private AgLibrary.Controls.RepeatButton btnSouth;
        private AgLibrary.Controls.RepeatButton btnNorth;
        private System.Windows.Forms.Button bntOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblSmooth;
    }
}
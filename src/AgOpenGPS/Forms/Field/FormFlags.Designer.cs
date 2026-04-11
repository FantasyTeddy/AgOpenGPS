namespace AgOpenGPS
{
    partial class FormFlags
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
            components = new System.ComponentModel.Container();
            btnSouth = new AgLibrary.Controls.RepeatButton();
            btnNorth = new AgLibrary.Controls.RepeatButton();
            lblFlagSelected = new System.Windows.Forms.Label();
            lblLonStart = new System.Windows.Forms.Label();
            lblLatStart = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            lblEasting = new System.Windows.Forms.Label();
            lblNorthing = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            tboxFlagNotes = new System.Windows.Forms.TextBox();
            btnExit = new System.Windows.Forms.Button();
            btnDeleteFlag = new System.Windows.Forms.Button();
            lblHeading = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            timer1 = new System.Windows.Forms.Timer(components);
            labelDistanceToFlag = new System.Windows.Forms.Label();
            lblDistanceToFlag = new System.Windows.Forms.Label();
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
            btnSouth.Location = new System.Drawing.Point(224, 6);
            btnSouth.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSouth.Name = "btnSouth";
            btnSouth.Size = new System.Drawing.Size(110, 68);
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
            btnNorth.Location = new System.Drawing.Point(76, 6);
            btnNorth.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnNorth.Name = "btnNorth";
            btnNorth.Size = new System.Drawing.Size(110, 68);
            btnNorth.TabIndex = 196;
            btnNorth.UseVisualStyleBackColor = true;
            btnNorth.MouseDown += btnNorth_MouseDown;
            // 
            // lblFlagSelected
            // 
            lblFlagSelected.AutoSize = true;
            lblFlagSelected.BackColor = System.Drawing.Color.Transparent;
            lblFlagSelected.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblFlagSelected.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            lblFlagSelected.Location = new System.Drawing.Point(6, 21);
            lblFlagSelected.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblFlagSelected.Name = "lblFlagSelected";
            lblFlagSelected.Size = new System.Drawing.Size(57, 39);
            lblFlagSelected.TabIndex = 200;
            lblFlagSelected.Text = "99";
            // 
            // lblLonStart
            // 
            lblLonStart.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblLonStart.AutoSize = true;
            lblLonStart.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblLonStart.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            lblLonStart.Location = new System.Drawing.Point(212, 197);
            lblLonStart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblLonStart.Name = "lblLonStart";
            lblLonStart.Size = new System.Drawing.Size(101, 19);
            lblLonStart.TabIndex = 204;
            lblLonStart.Text = "-188.888888";
            // 
            // lblLatStart
            // 
            lblLatStart.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblLatStart.AutoSize = true;
            lblLatStart.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblLatStart.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            lblLatStart.Location = new System.Drawing.Point(43, 197);
            lblLatStart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblLatStart.Name = "lblLatStart";
            lblLatStart.Size = new System.Drawing.Size(92, 19);
            lblLatStart.TabIndex = 203;
            lblLatStart.Text = "-99.999999";
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label4.Location = new System.Drawing.Point(170, 196);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(41, 19);
            label4.TabIndex = 202;
            label4.Text = "Lon:";
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label3.Location = new System.Drawing.Point(6, 196);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(36, 19);
            label3.TabIndex = 201;
            label3.Text = "Lat:";
            // 
            // lblEasting
            // 
            lblEasting.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblEasting.AutoSize = true;
            lblEasting.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblEasting.ForeColor = System.Drawing.SystemColors.ControlText;
            lblEasting.Location = new System.Drawing.Point(152, 226);
            lblEasting.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            lblEasting.Name = "lblEasting";
            lblEasting.Size = new System.Drawing.Size(60, 19);
            lblEasting.TabIndex = 208;
            lblEasting.Text = "Easting";
            // 
            // lblNorthing
            // 
            lblNorthing.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblNorthing.AutoSize = true;
            lblNorthing.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblNorthing.ForeColor = System.Drawing.SystemColors.ControlText;
            lblNorthing.Location = new System.Drawing.Point(34, 226);
            lblNorthing.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            lblNorthing.Name = "lblNorthing";
            lblNorthing.Size = new System.Drawing.Size(71, 19);
            lblNorthing.TabIndex = 207;
            lblNorthing.Text = "Northing";
            // 
            // label5
            // 
            label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label5.ForeColor = System.Drawing.SystemColors.ControlText;
            label5.Location = new System.Drawing.Point(130, 226);
            label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(24, 19);
            label5.TabIndex = 206;
            label5.Text = "E:";
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.SystemColors.ControlText;
            label1.Location = new System.Drawing.Point(9, 226);
            label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(26, 19);
            label1.TabIndex = 205;
            label1.Text = "N:";
            // 
            // tboxFlagNotes
            // 
            tboxFlagNotes.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tboxFlagNotes.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tboxFlagNotes.Location = new System.Drawing.Point(8, 81);
            tboxFlagNotes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tboxFlagNotes.Multiline = true;
            tboxFlagNotes.Name = "tboxFlagNotes";
            tboxFlagNotes.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            tboxFlagNotes.Size = new System.Drawing.Size(327, 79);
            tboxFlagNotes.TabIndex = 209;
            tboxFlagNotes.Text = "Default";
            tboxFlagNotes.Click += tboxFlagNotes_Click;
            tboxFlagNotes.KeyPress += tboxFlagNotes_KeyPress;
            tboxFlagNotes.Leave += tboxFlagNotes_Leave;
            // 
            // btnExit
            // 
            btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnExit.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnExit.Image = Properties.Resources.OK64;
            btnExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnExit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnExit.Location = new System.Drawing.Point(245, 262);
            btnExit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(91, 91);
            btnExit.TabIndex = 210;
            btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnDeleteFlag
            // 
            btnDeleteFlag.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnDeleteFlag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnDeleteFlag.FlatAppearance.BorderSize = 0;
            btnDeleteFlag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDeleteFlag.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnDeleteFlag.Image = Properties.Resources.FlagDelete;
            btnDeleteFlag.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnDeleteFlag.Location = new System.Drawing.Point(8, 260);
            btnDeleteFlag.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnDeleteFlag.Name = "btnDeleteFlag";
            btnDeleteFlag.Size = new System.Drawing.Size(82, 91);
            btnDeleteFlag.TabIndex = 211;
            btnDeleteFlag.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnDeleteFlag.UseVisualStyleBackColor = true;
            btnDeleteFlag.Click += btnDeleteFlag_Click;
            // 
            // lblHeading
            // 
            lblHeading.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblHeading.AutoSize = true;
            lblHeading.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblHeading.ForeColor = System.Drawing.SystemColors.ControlText;
            lblHeading.Location = new System.Drawing.Point(271, 226);
            lblHeading.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new System.Drawing.Size(50, 19);
            lblHeading.TabIndex = 214;
            lblHeading.Text = "359.8";
            // 
            // label6
            // 
            label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label6.ForeColor = System.Drawing.SystemColors.ControlText;
            label6.Location = new System.Drawing.Point(248, 226);
            label6.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(26, 19);
            label6.TabIndex = 213;
            label6.Text = "H:";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // labelDistanceToFlag
            // 
            labelDistanceToFlag.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelDistanceToFlag.AutoSize = true;
            labelDistanceToFlag.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelDistanceToFlag.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            labelDistanceToFlag.Location = new System.Drawing.Point(34, 165);
            labelDistanceToFlag.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelDistanceToFlag.Name = "labelDistanceToFlag";
            labelDistanceToFlag.Size = new System.Drawing.Size(132, 19);
            labelDistanceToFlag.TabIndex = 215;
            labelDistanceToFlag.Text = "Distance To Flag:";
            // 
            // lblDistanceToFlag
            // 
            lblDistanceToFlag.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblDistanceToFlag.AutoSize = true;
            lblDistanceToFlag.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblDistanceToFlag.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            lblDistanceToFlag.Location = new System.Drawing.Point(183, 164);
            lblDistanceToFlag.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDistanceToFlag.Name = "lblDistanceToFlag";
            lblDistanceToFlag.Size = new System.Drawing.Size(120, 23);
            lblDistanceToFlag.TabIndex = 216;
            lblDistanceToFlag.Text = "-99.999999";
            // 
            // FormFlags
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Gainsboro;
            ClientSize = new System.Drawing.Size(350, 367);
            ControlBox = false;
            Controls.Add(lblDistanceToFlag);
            Controls.Add(labelDistanceToFlag);
            Controls.Add(lblHeading);
            Controls.Add(label6);
            Controls.Add(btnDeleteFlag);
            Controls.Add(btnExit);
            Controls.Add(tboxFlagNotes);
            Controls.Add(lblEasting);
            Controls.Add(lblNorthing);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(lblLonStart);
            Controls.Add(lblLatStart);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblFlagSelected);
            Controls.Add(btnSouth);
            Controls.Add(btnNorth);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "FormFlags";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Flags";
            Load += FormFlags_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private AgLibrary.Controls.RepeatButton btnSouth;
        private AgLibrary.Controls.RepeatButton btnNorth;
        private System.Windows.Forms.Label lblFlagSelected;
        private System.Windows.Forms.Label lblLonStart;
        private System.Windows.Forms.Label lblLatStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblEasting;
        private System.Windows.Forms.Label lblNorthing;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxFlagNotes;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDeleteFlag;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelDistanceToFlag;
        private System.Windows.Forms.Label lblDistanceToFlag;
    }
}
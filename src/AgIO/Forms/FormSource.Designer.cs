namespace AgIO
{
    partial class FormSource
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
            lvLines = new System.Windows.Forms.ListView();
            chDistance = new System.Windows.Forms.ColumnHeader();
            chName = new System.Windows.Forms.ColumnHeader();
            chLat = new System.Windows.Forms.ColumnHeader();
            chLon = new System.Windows.Forms.ColumnHeader();
            chFormat = new System.Windows.Forms.ColumnHeader();
            chNetwork = new System.Windows.Forms.ColumnHeader();
            tboxMount = new System.Windows.Forms.TextBox();
            lblCurrentAutoSteerPort = new System.Windows.Forms.Label();
            btnSort = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            btnUseMount = new System.Windows.Forms.Button();
            btnSite = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lvLines
            // 
            lvLines.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lvLines.BackColor = System.Drawing.SystemColors.InactiveCaption;
            lvLines.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { chDistance, chName, chLat, chLon, chFormat, chNetwork });
            lvLines.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lvLines.FullRowSelect = true;
            lvLines.GridLines = true;
            lvLines.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            lvLines.ImeMode = System.Windows.Forms.ImeMode.Off;
            lvLines.LabelWrap = false;
            lvLines.Location = new System.Drawing.Point(4, 3);
            lvLines.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            lvLines.MultiSelect = false;
            lvLines.Name = "lvLines";
            lvLines.Size = new System.Drawing.Size(1131, 591);
            lvLines.Sorting = System.Windows.Forms.SortOrder.Ascending;
            lvLines.TabIndex = 97;
            lvLines.UseCompatibleStateImageBehavior = false;
            lvLines.View = System.Windows.Forms.View.Details;
            lvLines.SelectedIndexChanged += lvLines_SelectedIndexChanged;
            // 
            // chDistance
            // 
            chDistance.Text = "Distance";
            chDistance.Width = 150;
            // 
            // chName
            // 
            chName.Text = "Mount Point";
            chName.Width = 250;
            // 
            // chLat
            // 
            chLat.Text = "Lat";
            chLat.Width = 100;
            // 
            // chLon
            // 
            chLon.Text = "Lon";
            chLon.Width = 100;
            // 
            // chFormat
            // 
            chFormat.Text = "Format";
            chFormat.Width = 150;
            // 
            // chNetwork
            // 
            chNetwork.Text = "Network";
            chNetwork.Width = 300;
            // 
            // tboxMount
            // 
            tboxMount.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            tboxMount.BackColor = System.Drawing.SystemColors.Window;
            tboxMount.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            tboxMount.Location = new System.Drawing.Point(245, 639);
            tboxMount.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            tboxMount.Name = "tboxMount";
            tboxMount.ReadOnly = true;
            tboxMount.Size = new System.Drawing.Size(284, 33);
            tboxMount.TabIndex = 98;
            // 
            // lblCurrentAutoSteerPort
            // 
            lblCurrentAutoSteerPort.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblCurrentAutoSteerPort.AutoSize = true;
            lblCurrentAutoSteerPort.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblCurrentAutoSteerPort.Location = new System.Drawing.Point(170, 647);
            lblCurrentAutoSteerPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblCurrentAutoSteerPort.Name = "lblCurrentAutoSteerPort";
            lblCurrentAutoSteerPort.Size = new System.Drawing.Size(59, 18);
            lblCurrentAutoSteerPort.TabIndex = 99;
            lblCurrentAutoSteerPort.Text = "Mount:";
            lblCurrentAutoSteerPort.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSort
            // 
            btnSort.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnSort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnSort.FlatAppearance.BorderSize = 0;
            btnSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSort.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnSort.Image = Properties.Resources.Sort;
            btnSort.Location = new System.Drawing.Point(14, 620);
            btnSort.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSort.Name = "btnSort";
            btnSort.Size = new System.Drawing.Size(112, 74);
            btnSort.TabIndex = 102;
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click;
            // 
            // button1
            // 
            button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            button1.BackgroundImage = Properties.Resources.Cancel64;
            button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            button1.Location = new System.Drawing.Point(979, 622);
            button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(106, 74);
            button1.TabIndex = 101;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnUseMount
            // 
            btnUseMount.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnUseMount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnUseMount.FlatAppearance.BorderSize = 0;
            btnUseMount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnUseMount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnUseMount.Image = Properties.Resources.OK64;
            btnUseMount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnUseMount.Location = new System.Drawing.Point(560, 621);
            btnUseMount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnUseMount.Name = "btnUseMount";
            btnUseMount.Size = new System.Drawing.Size(118, 74);
            btnUseMount.TabIndex = 100;
            btnUseMount.UseVisualStyleBackColor = true;
            btnUseMount.Click += btnUseMount_Click;
            // 
            // btnSite
            // 
            btnSite.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnSite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnSite.FlatAppearance.BorderSize = 0;
            btnSite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSite.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnSite.Image = Properties.Resources.www;
            btnSite.Location = new System.Drawing.Point(752, 620);
            btnSite.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSite.Name = "btnSite";
            btnSite.Size = new System.Drawing.Size(183, 74);
            btnSite.TabIndex = 100;
            btnSite.UseVisualStyleBackColor = true;
            btnSite.Click += btnSite_Click;
            // 
            // FormSource
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1149, 704);
            Controls.Add(btnSort);
            Controls.Add(button1);
            Controls.Add(btnUseMount);
            Controls.Add(btnSite);
            Controls.Add(lblCurrentAutoSteerPort);
            Controls.Add(tboxMount);
            Controls.Add(lvLines);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "FormSource";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Source Data";
            Load += FormSource_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lvLines;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chLat;
        private System.Windows.Forms.ColumnHeader chLon;
        private System.Windows.Forms.TextBox tboxMount;
        private System.Windows.Forms.ColumnHeader chDistance;
        private System.Windows.Forms.Label lblCurrentAutoSteerPort;
        private System.Windows.Forms.Button btnSite;
        private System.Windows.Forms.ColumnHeader chFormat;
        private System.Windows.Forms.ColumnHeader chNetwork;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnUseMount;
        private System.Windows.Forms.Button btnSort;
    }
}
namespace AgOpenGPS
{
    partial class FormDrivePicker
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
            lvLines = new System.Windows.Forms.ListView();
            chName = new System.Windows.Forms.ColumnHeader();
            chDistance = new System.Windows.Forms.ColumnHeader();
            timer1 = new System.Windows.Forms.Timer(components);
            btnOpenExistingLv = new System.Windows.Forms.Button();
            btnDeleteAB = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lvLines
            // 
            lvLines.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lvLines.BackColor = System.Drawing.SystemColors.InactiveCaption;
            lvLines.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { chName, chDistance });
            lvLines.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lvLines.FullRowSelect = true;
            lvLines.GridLines = true;
            lvLines.ImeMode = System.Windows.Forms.ImeMode.Off;
            lvLines.Location = new System.Drawing.Point(5, 12);
            lvLines.MultiSelect = false;
            lvLines.Name = "lvLines";
            lvLines.Size = new System.Drawing.Size(966, 279);
            lvLines.Sorting = System.Windows.Forms.SortOrder.Ascending;
            lvLines.TabIndex = 86;
            lvLines.UseCompatibleStateImageBehavior = false;
            lvLines.View = System.Windows.Forms.View.Details;
            // 
            // chName
            // 
            chName.Text = "Field Name";
            chName.Width = 750;
            // 
            // chDistance
            // 
            chDistance.Text = "Distance (km)";
            chDistance.Width = 200;
            // 
            // timer1
            // 
            timer1.Interval = 300;
            // 
            // btnOpenExistingLv
            // 
            btnOpenExistingLv.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnOpenExistingLv.BackColor = System.Drawing.Color.Transparent;
            btnOpenExistingLv.DialogResult = System.Windows.Forms.DialogResult.Yes;
            btnOpenExistingLv.FlatAppearance.BorderSize = 0;
            btnOpenExistingLv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnOpenExistingLv.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnOpenExistingLv.Image = Properties.Resources.FileOpen;
            btnOpenExistingLv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnOpenExistingLv.Location = new System.Drawing.Point(669, 330);
            btnOpenExistingLv.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            btnOpenExistingLv.Name = "btnOpenExistingLv";
            btnOpenExistingLv.Size = new System.Drawing.Size(288, 63);
            btnOpenExistingLv.TabIndex = 92;
            btnOpenExistingLv.Text = " Use Selected";
            btnOpenExistingLv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnOpenExistingLv.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnOpenExistingLv.UseVisualStyleBackColor = false;
            btnOpenExistingLv.Click += btnOpenExistingLv_Click;
            // 
            // btnDeleteAB
            // 
            btnDeleteAB.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnDeleteAB.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnDeleteAB.FlatAppearance.BorderSize = 0;
            btnDeleteAB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDeleteAB.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            btnDeleteAB.ForeColor = System.Drawing.SystemColors.ControlText;
            btnDeleteAB.Image = Properties.Resources.Cancel64;
            btnDeleteAB.Location = new System.Drawing.Point(30, 329);
            btnDeleteAB.Name = "btnDeleteAB";
            btnDeleteAB.Size = new System.Drawing.Size(227, 63);
            btnDeleteAB.TabIndex = 91;
            btnDeleteAB.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnDeleteAB.Click += btnDeleteAB_Click;
            // 
            // FormDrivePicker
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.WhiteSmoke;
            ClientSize = new System.Drawing.Size(971, 407);
            ControlBox = false;
            Controls.Add(btnOpenExistingLv);
            Controls.Add(btnDeleteAB);
            Controls.Add(lvLines);
            Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Margin = new System.Windows.Forms.Padding(5);
            Name = "FormDrivePicker";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "FormFilePicker";
            Load += FormFilePicker_Load;
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvLines;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chDistance;
        private System.Windows.Forms.Button btnOpenExistingLv;
        private System.Windows.Forms.Button btnDeleteAB;
        private System.Windows.Forms.Timer timer1;
    }
}
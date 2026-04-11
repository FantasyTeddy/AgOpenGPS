namespace AgOpenGPS
{
    partial class FormFilePicker
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
            chArea = new System.Windows.Forms.ColumnHeader();
            timer1 = new System.Windows.Forms.Timer(components);
            btnByDistance = new System.Windows.Forms.Button();
            btnOpenExistingLv = new System.Windows.Forms.Button();
            btnDeleteAB = new System.Windows.Forms.Button();
            btnDeleteField = new System.Windows.Forms.Button();
            labelDeleteField = new System.Windows.Forms.Label();
            labelCancel = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // lvLines
            // 
            lvLines.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lvLines.BackColor = System.Drawing.SystemColors.InactiveCaption;
            lvLines.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { chName, chDistance, chArea });
            lvLines.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lvLines.FullRowSelect = true;
            lvLines.GridLines = true;
            lvLines.ImeMode = System.Windows.Forms.ImeMode.Off;
            lvLines.Location = new System.Drawing.Point(5, 12);
            lvLines.MultiSelect = false;
            lvLines.Name = "lvLines";
            lvLines.Size = new System.Drawing.Size(986, 459);
            lvLines.Sorting = System.Windows.Forms.SortOrder.Ascending;
            lvLines.TabIndex = 86;
            lvLines.UseCompatibleStateImageBehavior = false;
            lvLines.View = System.Windows.Forms.View.Details;
            // 
            // chName
            // 
            chName.Text = "Field";
            chName.Width = 680;
            // 
            // chDistance
            // 
            chDistance.Text = "Distance";
            chDistance.Width = 140;
            // 
            // chArea
            // 
            chArea.Text = "Area";
            chArea.Width = 140;
            // 
            // timer1
            // 
            timer1.Interval = 300;
            // 
            // btnByDistance
            // 
            btnByDistance.BackColor = System.Drawing.Color.Transparent;
            btnByDistance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnByDistance.Image = Properties.Resources.Sort;
            btnByDistance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnByDistance.Location = new System.Drawing.Point(210, 507);
            btnByDistance.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            btnByDistance.Name = "btnByDistance";
            btnByDistance.Size = new System.Drawing.Size(147, 63);
            btnByDistance.TabIndex = 93;
            btnByDistance.Text = "Sort";
            btnByDistance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnByDistance.UseVisualStyleBackColor = false;
            btnByDistance.Click += btnByDistance_Click;
            // 
            // btnOpenExistingLv
            // 
            btnOpenExistingLv.BackColor = System.Drawing.Color.Transparent;
            btnOpenExistingLv.DialogResult = System.Windows.Forms.DialogResult.Yes;
            btnOpenExistingLv.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnOpenExistingLv.Image = Properties.Resources.FileOpen;
            btnOpenExistingLv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnOpenExistingLv.Location = new System.Drawing.Point(697, 507);
            btnOpenExistingLv.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            btnOpenExistingLv.Name = "btnOpenExistingLv";
            btnOpenExistingLv.Size = new System.Drawing.Size(261, 63);
            btnOpenExistingLv.TabIndex = 92;
            btnOpenExistingLv.Text = "Use Selected";
            btnOpenExistingLv.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnOpenExistingLv.UseVisualStyleBackColor = false;
            btnOpenExistingLv.Click += btnOpenExistingLv_Click;
            // 
            // btnDeleteAB
            // 
            btnDeleteAB.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnDeleteAB.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            btnDeleteAB.ForeColor = System.Drawing.SystemColors.ControlText;
            btnDeleteAB.Image = Properties.Resources.Cancel64;
            btnDeleteAB.Location = new System.Drawing.Point(502, 507);
            btnDeleteAB.Name = "btnDeleteAB";
            btnDeleteAB.Size = new System.Drawing.Size(71, 63);
            btnDeleteAB.TabIndex = 91;
            btnDeleteAB.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnDeleteAB.Click += btnDeleteAB_Click;
            // 
            // btnDeleteField
            // 
            btnDeleteField.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            btnDeleteField.ForeColor = System.Drawing.SystemColors.ControlText;
            btnDeleteField.Image = Properties.Resources.Trash;
            btnDeleteField.Location = new System.Drawing.Point(46, 507);
            btnDeleteField.Name = "btnDeleteField";
            btnDeleteField.Size = new System.Drawing.Size(71, 63);
            btnDeleteField.TabIndex = 94;
            btnDeleteField.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnDeleteField.Click += btnDeleteField_Click;
            // 
            // labelDeleteField
            // 
            labelDeleteField.AutoSize = true;
            labelDeleteField.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelDeleteField.Location = new System.Drawing.Point(43, 488);
            labelDeleteField.Name = "labelDeleteField";
            labelDeleteField.Size = new System.Drawing.Size(74, 16);
            labelDeleteField.TabIndex = 95;
            labelDeleteField.Text = "Delete Field";
            // 
            // labelCancel
            // 
            labelCancel.AutoSize = true;
            labelCancel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelCancel.Location = new System.Drawing.Point(515, 488);
            labelCancel.Name = "labelCancel";
            labelCancel.Size = new System.Drawing.Size(45, 16);
            labelCancel.TabIndex = 96;
            labelCancel.Text = "Cancel";
            // 
            // FormFilePicker
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.WhiteSmoke;
            ClientSize = new System.Drawing.Size(991, 578);
            ControlBox = false;
            Controls.Add(labelCancel);
            Controls.Add(labelDeleteField);
            Controls.Add(btnDeleteField);
            Controls.Add(btnByDistance);
            Controls.Add(btnOpenExistingLv);
            Controls.Add(btnDeleteAB);
            Controls.Add(lvLines);
            Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Margin = new System.Windows.Forms.Padding(5);
            Name = "FormFilePicker";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "FormFilePicker";
            Load += FormFilePicker_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvLines;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chDistance;
        private System.Windows.Forms.Button btnByDistance;
        private System.Windows.Forms.Button btnOpenExistingLv;
        private System.Windows.Forms.Button btnDeleteAB;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ColumnHeader chArea;
        private System.Windows.Forms.Button btnDeleteField;
        private System.Windows.Forms.Label labelDeleteField;
        private System.Windows.Forms.Label labelCancel;
    }
}

namespace AgOpenGPS.Forms.Pickers
{
    partial class FormRecordPicker
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
            chName = new System.Windows.Forms.ColumnHeader();
            btnDeleteField = new System.Windows.Forms.Button();
            labelDeleteRecord = new System.Windows.Forms.Label();
            btnDeleteAB = new System.Windows.Forms.Button();
            labelCancel = new System.Windows.Forms.Label();
            buttonOpenExistingLv = new System.Windows.Forms.Button();
            btnTurnOffRecPath = new System.Windows.Forms.Button();
            labelPathOff = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // lvLines
            // 
            lvLines.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lvLines.BackColor = System.Drawing.SystemColors.InactiveCaption;
            lvLines.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { chName });
            lvLines.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lvLines.FullRowSelect = true;
            lvLines.GridLines = true;
            lvLines.ImeMode = System.Windows.Forms.ImeMode.Off;
            lvLines.Location = new System.Drawing.Point(5, 12);
            lvLines.MultiSelect = false;
            lvLines.Name = "lvLines";
            lvLines.Size = new System.Drawing.Size(967, 459);
            lvLines.Sorting = System.Windows.Forms.SortOrder.Ascending;
            lvLines.TabIndex = 87;
            lvLines.UseCompatibleStateImageBehavior = false;
            lvLines.View = System.Windows.Forms.View.Details;
            // 
            // chName
            // 
            chName.Text = "Record Name";
            chName.Width = 680;
            // 
            // btnDeleteField
            // 
            btnDeleteField.FlatAppearance.BorderSize = 0;
            btnDeleteField.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDeleteField.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            btnDeleteField.ForeColor = System.Drawing.SystemColors.ControlText;
            btnDeleteField.Image = Properties.Resources.Trash;
            btnDeleteField.Location = new System.Drawing.Point(47, 503);
            btnDeleteField.Name = "btnDeleteField";
            btnDeleteField.Size = new System.Drawing.Size(71, 63);
            btnDeleteField.TabIndex = 95;
            btnDeleteField.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnDeleteField.Click += btnDeleteField_Click;
            // 
            // labelDeleteRecord
            // 
            labelDeleteRecord.AutoSize = true;
            labelDeleteRecord.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelDeleteRecord.Location = new System.Drawing.Point(41, 489);
            labelDeleteRecord.Name = "labelDeleteRecord";
            labelDeleteRecord.Size = new System.Drawing.Size(87, 16);
            labelDeleteRecord.TabIndex = 96;
            labelDeleteRecord.Text = "Delete Record";
            // 
            // btnDeleteAB
            // 
            btnDeleteAB.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnDeleteAB.FlatAppearance.BorderSize = 0;
            btnDeleteAB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDeleteAB.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            btnDeleteAB.ForeColor = System.Drawing.SystemColors.ControlText;
            btnDeleteAB.Image = Properties.Resources.Cancel64;
            btnDeleteAB.Location = new System.Drawing.Point(565, 503);
            btnDeleteAB.Name = "btnDeleteAB";
            btnDeleteAB.Size = new System.Drawing.Size(71, 63);
            btnDeleteAB.TabIndex = 97;
            btnDeleteAB.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // labelCancel
            // 
            labelCancel.AutoSize = true;
            labelCancel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelCancel.Location = new System.Drawing.Point(576, 489);
            labelCancel.Name = "labelCancel";
            labelCancel.Size = new System.Drawing.Size(45, 16);
            labelCancel.TabIndex = 98;
            labelCancel.Text = "Cancel";
            // 
            // buttonOpenExistingLv
            // 
            buttonOpenExistingLv.BackColor = System.Drawing.Color.Transparent;
            buttonOpenExistingLv.DialogResult = System.Windows.Forms.DialogResult.Yes;
            buttonOpenExistingLv.FlatAppearance.BorderSize = 0;
            buttonOpenExistingLv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonOpenExistingLv.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            buttonOpenExistingLv.Image = Properties.Resources.FileOpen;
            buttonOpenExistingLv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonOpenExistingLv.Location = new System.Drawing.Point(702, 502);
            buttonOpenExistingLv.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            buttonOpenExistingLv.Name = "buttonOpenExistingLv";
            buttonOpenExistingLv.Size = new System.Drawing.Size(261, 63);
            buttonOpenExistingLv.TabIndex = 99;
            buttonOpenExistingLv.Text = " Use Selected";
            buttonOpenExistingLv.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            buttonOpenExistingLv.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            buttonOpenExistingLv.UseVisualStyleBackColor = false;
            buttonOpenExistingLv.Click += btnOpenExistingLv_Click;
            // 
            // btnTurnOffRecPath
            // 
            btnTurnOffRecPath.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnTurnOffRecPath.FlatAppearance.BorderSize = 0;
            btnTurnOffRecPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnTurnOffRecPath.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            btnTurnOffRecPath.ForeColor = System.Drawing.SystemColors.ControlText;
            btnTurnOffRecPath.Image = Properties.Resources.SwitchOff;
            btnTurnOffRecPath.Location = new System.Drawing.Point(223, 502);
            btnTurnOffRecPath.Name = "btnTurnOffRecPath";
            btnTurnOffRecPath.Size = new System.Drawing.Size(71, 63);
            btnTurnOffRecPath.TabIndex = 100;
            btnTurnOffRecPath.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnTurnOffRecPath.Click += btnTurnOffRecPath_Click;
            // 
            // labelPathOff
            // 
            labelPathOff.AutoSize = true;
            labelPathOff.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelPathOff.Location = new System.Drawing.Point(230, 489);
            labelPathOff.Name = "labelPathOff";
            labelPathOff.Size = new System.Drawing.Size(53, 16);
            labelPathOff.TabIndex = 101;
            labelPathOff.Text = "Path Off";
            // 
            // FormRecordPicker
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(972, 578);
            ControlBox = false;
            Controls.Add(labelPathOff);
            Controls.Add(btnTurnOffRecPath);
            Controls.Add(buttonOpenExistingLv);
            Controls.Add(labelCancel);
            Controls.Add(btnDeleteAB);
            Controls.Add(labelDeleteRecord);
            Controls.Add(btnDeleteField);
            Controls.Add(lvLines);
            Font = new System.Drawing.Font("Tahoma", 14.25F);
            Margin = new System.Windows.Forms.Padding(5);
            Name = "FormRecordPicker";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "FormRecordPicker";
            Load += FormRecordPicker_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvLines;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.Button btnDeleteField;
        private System.Windows.Forms.Label labelDeleteRecord;
        private System.Windows.Forms.Button btnDeleteAB;
        private System.Windows.Forms.Label labelCancel;
        private System.Windows.Forms.Button buttonOpenExistingLv;
        private System.Windows.Forms.Button btnTurnOffRecPath;
        private System.Windows.Forms.Label labelPathOff;
    }
}
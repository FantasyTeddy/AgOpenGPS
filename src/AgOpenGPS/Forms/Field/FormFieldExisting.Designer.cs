namespace AgOpenGPS
{
    partial class FormFieldExisting
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
            label1 = new System.Windows.Forms.Label();
            tboxFieldName = new System.Windows.Forms.TextBox();
            btnSerialCancel = new System.Windows.Forms.Button();
            btnSave = new System.Windows.Forms.Button();
            chkApplied = new System.Windows.Forms.CheckBox();
            chkHeadland = new System.Windows.Forms.CheckBox();
            chkGuidanceLines = new System.Windows.Forms.CheckBox();
            chkFlags = new System.Windows.Forms.CheckBox();
            label4 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            btnAddDate = new System.Windows.Forms.Button();
            btnAddTime = new System.Windows.Forms.Button();
            btnSort = new System.Windows.Forms.Button();
            timer1 = new System.Windows.Forms.Timer(components);
            lvLines = new System.Windows.Forms.ListView();
            chName = new System.Windows.Forms.ColumnHeader();
            chDistance = new System.Windows.Forms.ColumnHeader();
            chArea = new System.Windows.Forms.ColumnHeader();
            label3 = new System.Windows.Forms.Label();
            btnAddVehicleName = new System.Windows.Forms.Button();
            btnBackSpace = new AgLibrary.Controls.RepeatButton();
            lblTemplateChosen = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label1.Location = new System.Drawing.Point(4, 527);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(142, 23);
            label1.TabIndex = 4;
            label1.Text = "Edit Field Name";
            // 
            // tboxFieldName
            // 
            tboxFieldName.BackColor = System.Drawing.Color.White;
            tboxFieldName.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            tboxFieldName.Location = new System.Drawing.Point(6, 486);
            tboxFieldName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            tboxFieldName.Name = "tboxFieldName";
            tboxFieldName.Size = new System.Drawing.Size(657, 36);
            tboxFieldName.TabIndex = 0;
            tboxFieldName.Click += tboxFieldName_Click;
            tboxFieldName.TextChanged += tboxFieldName_TextChanged;
            // 
            // btnSerialCancel
            // 
            btnSerialCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnSerialCancel.BackColor = System.Drawing.Color.Transparent;
            btnSerialCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnSerialCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnSerialCancel.FlatAppearance.BorderSize = 0;
            btnSerialCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSerialCancel.Font = new System.Drawing.Font("Tahoma", 12F);
            btnSerialCancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            btnSerialCancel.Image = Properties.Resources.Cancel64;
            btnSerialCancel.Location = new System.Drawing.Point(814, 582);
            btnSerialCancel.Name = "btnSerialCancel";
            btnSerialCancel.Size = new System.Drawing.Size(88, 77);
            btnSerialCancel.TabIndex = 4;
            btnSerialCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnSerialCancel.UseVisualStyleBackColor = false;
            btnSerialCancel.Click += btnSerialCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnSave.BackColor = System.Drawing.Color.Transparent;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            btnSave.Image = Properties.Resources.OK64;
            btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnSave.Location = new System.Drawing.Point(911, 580);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(86, 79);
            btnSave.TabIndex = 3;
            btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // chkApplied
            // 
            chkApplied.Appearance = System.Windows.Forms.Appearance.Button;
            chkApplied.BackColor = System.Drawing.Color.Transparent;
            chkApplied.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            chkApplied.FlatAppearance.CheckedBackColor = System.Drawing.Color.MediumAquamarine;
            chkApplied.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            chkApplied.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            chkApplied.ForeColor = System.Drawing.Color.White;
            chkApplied.Image = Properties.Resources.SectionMasterOff;
            chkApplied.Location = new System.Drawing.Point(485, 575);
            chkApplied.Name = "chkApplied";
            chkApplied.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            chkApplied.Size = new System.Drawing.Size(76, 74);
            chkApplied.TabIndex = 257;
            chkApplied.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            chkApplied.UseVisualStyleBackColor = false;
            // 
            // chkHeadland
            // 
            chkHeadland.Appearance = System.Windows.Forms.Appearance.Button;
            chkHeadland.BackColor = System.Drawing.Color.Transparent;
            chkHeadland.Checked = true;
            chkHeadland.CheckState = System.Windows.Forms.CheckState.Checked;
            chkHeadland.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            chkHeadland.FlatAppearance.CheckedBackColor = System.Drawing.Color.MediumAquamarine;
            chkHeadland.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            chkHeadland.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            chkHeadland.ForeColor = System.Drawing.Color.White;
            chkHeadland.Image = Properties.Resources.HeadlandMenu;
            chkHeadland.Location = new System.Drawing.Point(590, 575);
            chkHeadland.Name = "chkHeadland";
            chkHeadland.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            chkHeadland.Size = new System.Drawing.Size(76, 74);
            chkHeadland.TabIndex = 258;
            chkHeadland.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            chkHeadland.UseVisualStyleBackColor = false;
            // 
            // chkGuidanceLines
            // 
            chkGuidanceLines.Appearance = System.Windows.Forms.Appearance.Button;
            chkGuidanceLines.BackColor = System.Drawing.Color.Transparent;
            chkGuidanceLines.Checked = true;
            chkGuidanceLines.CheckState = System.Windows.Forms.CheckState.Checked;
            chkGuidanceLines.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            chkGuidanceLines.FlatAppearance.CheckedBackColor = System.Drawing.Color.MediumAquamarine;
            chkGuidanceLines.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            chkGuidanceLines.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            chkGuidanceLines.ForeColor = System.Drawing.Color.White;
            chkGuidanceLines.Image = Properties.Resources.ABTrackAB;
            chkGuidanceLines.Location = new System.Drawing.Point(695, 575);
            chkGuidanceLines.Name = "chkGuidanceLines";
            chkGuidanceLines.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            chkGuidanceLines.Size = new System.Drawing.Size(76, 74);
            chkGuidanceLines.TabIndex = 259;
            chkGuidanceLines.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            chkGuidanceLines.UseVisualStyleBackColor = false;
            // 
            // chkFlags
            // 
            chkFlags.Appearance = System.Windows.Forms.Appearance.Button;
            chkFlags.BackColor = System.Drawing.Color.Transparent;
            chkFlags.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            chkFlags.FlatAppearance.CheckedBackColor = System.Drawing.Color.MediumAquamarine;
            chkFlags.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            chkFlags.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            chkFlags.ForeColor = System.Drawing.Color.White;
            chkFlags.Image = Properties.Resources.FlagRed;
            chkFlags.Location = new System.Drawing.Point(380, 575);
            chkFlags.Name = "chkFlags";
            chkFlags.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            chkFlags.Size = new System.Drawing.Size(76, 74);
            chkFlags.TabIndex = 260;
            chkFlags.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            chkFlags.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.Transparent;
            label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label4.Location = new System.Drawing.Point(233, 591);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(24, 23);
            label4.TabIndex = 265;
            label4.Text = "+";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label2.Location = new System.Drawing.Point(120, 591);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(24, 23);
            label2.TabIndex = 264;
            label2.Text = "+";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.Transparent;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label5.Location = new System.Drawing.Point(602, 651);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(53, 13);
            label5.TabIndex = 266;
            label5.Text = "Headland";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = System.Drawing.Color.Transparent;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label6.Location = new System.Drawing.Point(722, 651);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(32, 13);
            label6.TabIndex = 267;
            label6.Text = "Lines";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = System.Drawing.Color.Transparent;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label7.Location = new System.Drawing.Point(499, 651);
            label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(48, 13);
            label7.TabIndex = 268;
            label7.Text = "Mapping";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = System.Drawing.Color.Transparent;
            label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label8.Location = new System.Drawing.Point(403, 651);
            label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(32, 13);
            label8.TabIndex = 269;
            label8.Text = "Flags";
            // 
            // btnAddDate
            // 
            btnAddDate.BackColor = System.Drawing.Color.Transparent;
            btnAddDate.FlatAppearance.BorderSize = 0;
            btnAddDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAddDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            btnAddDate.Image = Properties.Resources.JobNameCalendar;
            btnAddDate.Location = new System.Drawing.Point(138, 568);
            btnAddDate.Name = "btnAddDate";
            btnAddDate.Size = new System.Drawing.Size(76, 74);
            btnAddDate.TabIndex = 271;
            btnAddDate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnAddDate.UseVisualStyleBackColor = false;
            btnAddDate.Click += btnAddDate_Click;
            // 
            // btnAddTime
            // 
            btnAddTime.BackColor = System.Drawing.Color.Transparent;
            btnAddTime.FlatAppearance.BorderSize = 0;
            btnAddTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAddTime.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            btnAddTime.Image = Properties.Resources.JobNameTime;
            btnAddTime.Location = new System.Drawing.Point(249, 568);
            btnAddTime.Name = "btnAddTime";
            btnAddTime.Size = new System.Drawing.Size(76, 74);
            btnAddTime.TabIndex = 270;
            btnAddTime.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnAddTime.UseVisualStyleBackColor = false;
            btnAddTime.Click += btnAddTime_Click;
            // 
            // btnSort
            // 
            btnSort.BackColor = System.Drawing.Color.Transparent;
            btnSort.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnSort.Image = Properties.Resources.Sort;
            btnSort.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnSort.Location = new System.Drawing.Point(834, 470);
            btnSort.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            btnSort.Name = "btnSort";
            btnSort.Size = new System.Drawing.Size(147, 63);
            btnSort.TabIndex = 273;
            btnSort.Text = "Sort";
            btnSort.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnSort.UseVisualStyleBackColor = false;
            btnSort.Click += btnSort_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 300;
            timer1.Tick += timer1_Tick;
            // 
            // lvLines
            // 
            lvLines.BackColor = System.Drawing.SystemColors.InactiveCaption;
            lvLines.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { chName, chDistance, chArea });
            lvLines.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lvLines.FullRowSelect = true;
            lvLines.GridLines = true;
            lvLines.ImeMode = System.Windows.Forms.ImeMode.Off;
            lvLines.Location = new System.Drawing.Point(6, 5);
            lvLines.MultiSelect = false;
            lvLines.Name = "lvLines";
            lvLines.Size = new System.Drawing.Size(993, 445);
            lvLines.Sorting = System.Windows.Forms.SortOrder.Ascending;
            lvLines.TabIndex = 274;
            lvLines.UseCompatibleStateImageBehavior = false;
            lvLines.View = System.Windows.Forms.View.Details;
            lvLines.SelectedIndexChanged += lvLines_SelectedIndexChanged;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label3.Location = new System.Drawing.Point(4, 591);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(24, 23);
            label3.TabIndex = 275;
            label3.Text = "+";
            // 
            // btnAddVehicleName
            // 
            btnAddVehicleName.BackColor = System.Drawing.Color.Transparent;
            btnAddVehicleName.FlatAppearance.BorderSize = 0;
            btnAddVehicleName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAddVehicleName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            btnAddVehicleName.Image = Properties.Resources.Con_VehicleMenu;
            btnAddVehicleName.Location = new System.Drawing.Point(22, 568);
            btnAddVehicleName.Name = "btnAddVehicleName";
            btnAddVehicleName.Size = new System.Drawing.Size(76, 74);
            btnAddVehicleName.TabIndex = 276;
            btnAddVehicleName.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnAddVehicleName.UseVisualStyleBackColor = false;
            btnAddVehicleName.Click += btnAddVehicleName_Click;
            // 
            // btnBackSpace
            // 
            btnBackSpace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnBackSpace.FlatAppearance.BorderSize = 0;
            btnBackSpace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBackSpace.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnBackSpace.ForeColor = System.Drawing.SystemColors.ButtonFace;
            btnBackSpace.Image = Properties.Resources.BackSpace;
            btnBackSpace.Location = new System.Drawing.Point(669, 478);
            btnBackSpace.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            btnBackSpace.Name = "btnBackSpace";
            btnBackSpace.Size = new System.Drawing.Size(71, 51);
            btnBackSpace.TabIndex = 457;
            btnBackSpace.UseVisualStyleBackColor = true;
            btnBackSpace.MouseDown += btnBackSpace_MouseDown;
            // 
            // lblTemplateChosen
            // 
            lblTemplateChosen.AutoSize = true;
            lblTemplateChosen.BackColor = System.Drawing.Color.Transparent;
            lblTemplateChosen.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblTemplateChosen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lblTemplateChosen.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            lblTemplateChosen.Location = new System.Drawing.Point(8, 453);
            lblTemplateChosen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTemplateChosen.Name = "lblTemplateChosen";
            lblTemplateChosen.Size = new System.Drawing.Size(34, 23);
            lblTemplateChosen.TabIndex = 458;
            lblTemplateChosen.Text = "---";
            // 
            // FormFieldExisting
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            BackColor = System.Drawing.Color.Gainsboro;
            ClientSize = new System.Drawing.Size(1004, 670);
            ControlBox = false;
            Controls.Add(lblTemplateChosen);
            Controls.Add(btnBackSpace);
            Controls.Add(label3);
            Controls.Add(btnAddVehicleName);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(lvLines);
            Controls.Add(btnSort);
            Controls.Add(btnAddDate);
            Controls.Add(btnAddTime);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(tboxFieldName);
            Controls.Add(chkHeadland);
            Controls.Add(chkGuidanceLines);
            Controls.Add(btnSave);
            Controls.Add(chkFlags);
            Controls.Add(btnSerialCancel);
            Controls.Add(chkApplied);
            Font = new System.Drawing.Font("Tahoma", 14.25F);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "FormFieldExisting";
            Padding = new System.Windows.Forms.Padding(2);
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Field Save As";
            Load += FormFieldExisting_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxFieldName;
        private System.Windows.Forms.Button btnSerialCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox chkApplied;
        private System.Windows.Forms.CheckBox chkHeadland;
        private System.Windows.Forms.CheckBox chkGuidanceLines;
        private System.Windows.Forms.CheckBox chkFlags;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAddDate;
        private System.Windows.Forms.Button btnAddTime;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListView lvLines;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chDistance;
        private System.Windows.Forms.ColumnHeader chArea;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddVehicleName;
        private AgLibrary.Controls.RepeatButton btnBackSpace;
        private System.Windows.Forms.Label lblTemplateChosen;
    }
}
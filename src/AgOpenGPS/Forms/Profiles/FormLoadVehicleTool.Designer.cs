namespace AgOpenGPS.Forms.Profiles
{
    partial class FormLoadVehicleTool
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            listViewVehicles = new System.Windows.Forms.ListView();
            columnHeaderVehicle = new System.Windows.Forms.ColumnHeader();
            listViewTools = new System.Windows.Forms.ListView();
            columnHeaderTool = new System.Windows.Forms.ColumnHeader();
            lblCurrentVehicle = new System.Windows.Forms.Label();
            lblCurrentTool = new System.Windows.Forms.Label();
            lblSelectedVehicle = new System.Windows.Forms.Label();
            lblSelectedTool = new System.Windows.Forms.Label();
            lblVehType = new System.Windows.Forms.Label();
            lblVehWheelbase = new System.Windows.Forms.Label();
            lblVehAntPivot = new System.Windows.Forms.Label();
            lblVehAntOffset = new System.Windows.Forms.Label();
            lblVehTrackWidth = new System.Windows.Forms.Label();
            lblToolWidth = new System.Windows.Forms.Label();
            lblToolOverlap = new System.Windows.Forms.Label();
            lblToolOffset = new System.Windows.Forms.Label();
            lblToolSections = new System.Windows.Forms.Label();
            lblToolAttach = new System.Windows.Forms.Label();
            lblToolHitch = new System.Windows.Forms.Label();
            buttonLoad = new System.Windows.Forms.Button();
            buttonCancel = new System.Windows.Forms.Button();
            buttonNewVehicle = new System.Windows.Forms.Button();
            buttonNewTool = new System.Windows.Forms.Button();
            buttonDeleteVehicle = new System.Windows.Forms.Button();
            buttonDeleteTool = new System.Windows.Forms.Button();
            buttonRenameVehicle = new System.Windows.Forms.Button();
            buttonRenameTool = new System.Windows.Forms.Button();
            buttonResetVehicle = new System.Windows.Forms.Button();
            buttonResetTool = new System.Windows.Forms.Button();
            buttonConvertOld = new System.Windows.Forms.Button();
            lblVehHitch = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // listViewVehicles
            // 
            listViewVehicles.BackColor = System.Drawing.SystemColors.InactiveCaption;
            listViewVehicles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeaderVehicle });
            listViewVehicles.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            listViewVehicles.FullRowSelect = true;
            listViewVehicles.GridLines = true;
            listViewVehicles.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            listViewVehicles.LabelWrap = false;
            listViewVehicles.Location = new System.Drawing.Point(12, 35);
            listViewVehicles.MultiSelect = false;
            listViewVehicles.Name = "listViewVehicles";
            listViewVehicles.Size = new System.Drawing.Size(400, 320);
            listViewVehicles.TabIndex = 1;
            listViewVehicles.UseCompatibleStateImageBehavior = false;
            listViewVehicles.View = System.Windows.Forms.View.Details;
            listViewVehicles.SelectedIndexChanged += listViewVehicles_SelectedIndexChanged;
            // 
            // columnHeaderVehicle
            // 
            columnHeaderVehicle.Width = 375;
            // 
            // listViewTools
            // 
            listViewTools.BackColor = System.Drawing.SystemColors.InactiveCaption;
            listViewTools.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeaderTool });
            listViewTools.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            listViewTools.FullRowSelect = true;
            listViewTools.GridLines = true;
            listViewTools.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            listViewTools.LabelWrap = false;
            listViewTools.Location = new System.Drawing.Point(500, 35);
            listViewTools.MultiSelect = false;
            listViewTools.Name = "listViewTools";
            listViewTools.Size = new System.Drawing.Size(400, 320);
            listViewTools.TabIndex = 2;
            listViewTools.UseCompatibleStateImageBehavior = false;
            listViewTools.View = System.Windows.Forms.View.Details;
            listViewTools.SelectedIndexChanged += listViewTools_SelectedIndexChanged;
            // 
            // columnHeaderTool
            // 
            columnHeaderTool.Width = 375;
            // 
            // lblCurrentVehicle
            // 
            lblCurrentVehicle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            lblCurrentVehicle.ForeColor = System.Drawing.Color.DarkOrange;
            lblCurrentVehicle.Location = new System.Drawing.Point(12, 8);
            lblCurrentVehicle.Name = "lblCurrentVehicle";
            lblCurrentVehicle.Size = new System.Drawing.Size(400, 24);
            lblCurrentVehicle.TabIndex = 0;
            lblCurrentVehicle.Text = "Current: -";
            // 
            // lblCurrentTool
            // 
            lblCurrentTool.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            lblCurrentTool.ForeColor = System.Drawing.Color.DarkOrange;
            lblCurrentTool.Location = new System.Drawing.Point(500, 8);
            lblCurrentTool.Name = "lblCurrentTool";
            lblCurrentTool.Size = new System.Drawing.Size(400, 24);
            lblCurrentTool.TabIndex = 12;
            lblCurrentTool.Text = "Current: -";
            // 
            // lblSelectedVehicle
            // 
            lblSelectedVehicle.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Italic);
            lblSelectedVehicle.ForeColor = System.Drawing.Color.DarkGreen;
            lblSelectedVehicle.Location = new System.Drawing.Point(12, 359);
            lblSelectedVehicle.Name = "lblSelectedVehicle";
            lblSelectedVehicle.Size = new System.Drawing.Size(400, 22);
            lblSelectedVehicle.TabIndex = 5;
            lblSelectedVehicle.Text = "Selected: -";
            // 
            // lblSelectedTool
            // 
            lblSelectedTool.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Italic);
            lblSelectedTool.ForeColor = System.Drawing.Color.DarkGreen;
            lblSelectedTool.Location = new System.Drawing.Point(500, 359);
            lblSelectedTool.Name = "lblSelectedTool";
            lblSelectedTool.Size = new System.Drawing.Size(400, 22);
            lblSelectedTool.TabIndex = 16;
            lblSelectedTool.Text = "Selected: -";
            // 
            // lblVehType
            // 
            lblVehType.Font = new System.Drawing.Font("Tahoma", 10F);
            lblVehType.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
            lblVehType.Location = new System.Drawing.Point(12, 385);
            lblVehType.Name = "lblVehType";
            lblVehType.Size = new System.Drawing.Size(220, 20);
            lblVehType.TabIndex = 6;
            lblVehType.Text = "Type:";
            // 
            // lblVehWheelbase
            // 
            lblVehWheelbase.Font = new System.Drawing.Font("Tahoma", 10F);
            lblVehWheelbase.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
            lblVehWheelbase.Location = new System.Drawing.Point(12, 407);
            lblVehWheelbase.Name = "lblVehWheelbase";
            lblVehWheelbase.Size = new System.Drawing.Size(220, 20);
            lblVehWheelbase.TabIndex = 7;
            lblVehWheelbase.Text = "Wheelbase:";
            // 
            // lblVehAntPivot
            // 
            lblVehAntPivot.Font = new System.Drawing.Font("Tahoma", 10F);
            lblVehAntPivot.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
            lblVehAntPivot.Location = new System.Drawing.Point(12, 429);
            lblVehAntPivot.Name = "lblVehAntPivot";
            lblVehAntPivot.Size = new System.Drawing.Size(220, 20);
            lblVehAntPivot.TabIndex = 8;
            lblVehAntPivot.Text = "Ant. Pivot:";
            // 
            // lblVehAntOffset
            // 
            lblVehAntOffset.Font = new System.Drawing.Font("Tahoma", 10F);
            lblVehAntOffset.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
            lblVehAntOffset.Location = new System.Drawing.Point(242, 385);
            lblVehAntOffset.Name = "lblVehAntOffset";
            lblVehAntOffset.Size = new System.Drawing.Size(220, 20);
            lblVehAntOffset.TabIndex = 9;
            lblVehAntOffset.Text = "Ant. Offset:";
            // 
            // lblVehTrackWidth
            // 
            lblVehTrackWidth.Font = new System.Drawing.Font("Tahoma", 10F);
            lblVehTrackWidth.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
            lblVehTrackWidth.Location = new System.Drawing.Point(242, 407);
            lblVehTrackWidth.Name = "lblVehTrackWidth";
            lblVehTrackWidth.Size = new System.Drawing.Size(220, 20);
            lblVehTrackWidth.TabIndex = 10;
            lblVehTrackWidth.Text = "Track Width:";
            // 
            // lblToolWidth
            // 
            lblToolWidth.Font = new System.Drawing.Font("Tahoma", 10F);
            lblToolWidth.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
            lblToolWidth.Location = new System.Drawing.Point(500, 385);
            lblToolWidth.Name = "lblToolWidth";
            lblToolWidth.Size = new System.Drawing.Size(220, 20);
            lblToolWidth.TabIndex = 17;
            lblToolWidth.Text = "Width:";
            // 
            // lblToolOverlap
            // 
            lblToolOverlap.Font = new System.Drawing.Font("Tahoma", 10F);
            lblToolOverlap.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
            lblToolOverlap.Location = new System.Drawing.Point(500, 407);
            lblToolOverlap.Name = "lblToolOverlap";
            lblToolOverlap.Size = new System.Drawing.Size(220, 20);
            lblToolOverlap.TabIndex = 18;
            lblToolOverlap.Text = "Overlap:";
            // 
            // lblToolOffset
            // 
            lblToolOffset.Font = new System.Drawing.Font("Tahoma", 10F);
            lblToolOffset.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
            lblToolOffset.Location = new System.Drawing.Point(500, 429);
            lblToolOffset.Name = "lblToolOffset";
            lblToolOffset.Size = new System.Drawing.Size(220, 20);
            lblToolOffset.TabIndex = 19;
            lblToolOffset.Text = "Offset:";
            // 
            // lblToolSections
            // 
            lblToolSections.Font = new System.Drawing.Font("Tahoma", 10F);
            lblToolSections.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
            lblToolSections.Location = new System.Drawing.Point(730, 385);
            lblToolSections.Name = "lblToolSections";
            lblToolSections.Size = new System.Drawing.Size(220, 20);
            lblToolSections.TabIndex = 20;
            lblToolSections.Text = "Sections:";
            // 
            // lblToolAttach
            // 
            lblToolAttach.Font = new System.Drawing.Font("Tahoma", 10F);
            lblToolAttach.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
            lblToolAttach.Location = new System.Drawing.Point(730, 407);
            lblToolAttach.Name = "lblToolAttach";
            lblToolAttach.Size = new System.Drawing.Size(220, 20);
            lblToolAttach.TabIndex = 21;
            lblToolAttach.Text = "Attach:";
            // 
            // lblToolHitch
            // 
            lblToolHitch.Font = new System.Drawing.Font("Tahoma", 10F);
            lblToolHitch.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
            lblToolHitch.Location = new System.Drawing.Point(730, 429);
            lblToolHitch.Name = "lblToolHitch";
            lblToolHitch.Size = new System.Drawing.Size(220, 20);
            lblToolHitch.TabIndex = 22;
            lblToolHitch.Text = "Trail Hitch:";
            // 
            // buttonLoad
            // 
            buttonLoad.Enabled = false;
            buttonLoad.FlatAppearance.BorderSize = 0;
            buttonLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonLoad.Font = new System.Drawing.Font("Tahoma", 14.25F);
            buttonLoad.Image = Properties.Resources.OK64;
            buttonLoad.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            buttonLoad.Location = new System.Drawing.Point(924, 450);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new System.Drawing.Size(80, 98);
            buttonLoad.TabIndex = 25;
            buttonLoad.Text = "Load";
            buttonLoad.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            buttonLoad.Click += buttonLoad_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            buttonCancel.FlatAppearance.BorderSize = 0;
            buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonCancel.Font = new System.Drawing.Font("Tahoma", 14.25F);
            buttonCancel.Image = Properties.Resources.Cancel64;
            buttonCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            buttonCancel.Location = new System.Drawing.Point(838, 450);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new System.Drawing.Size(80, 98);
            buttonCancel.TabIndex = 24;
            buttonCancel.Text = "Cancel";
            buttonCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // buttonNewVehicle
            // 
            buttonNewVehicle.FlatAppearance.BorderSize = 0;
            buttonNewVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonNewVehicle.Font = new System.Drawing.Font("Tahoma", 9F);
            buttonNewVehicle.Image = Properties.Resources.AddNew;
            buttonNewVehicle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            buttonNewVehicle.Location = new System.Drawing.Point(424, 115);
            buttonNewVehicle.Name = "buttonNewVehicle";
            buttonNewVehicle.Size = new System.Drawing.Size(65, 70);
            buttonNewVehicle.TabIndex = 3;
            buttonNewVehicle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            buttonNewVehicle.Click += buttonNewVehicle_Click;
            // 
            // buttonNewTool
            // 
            buttonNewTool.FlatAppearance.BorderSize = 0;
            buttonNewTool.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonNewTool.Font = new System.Drawing.Font("Tahoma", 9F);
            buttonNewTool.Image = Properties.Resources.AddNew;
            buttonNewTool.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            buttonNewTool.Location = new System.Drawing.Point(918, 115);
            buttonNewTool.Name = "buttonNewTool";
            buttonNewTool.Size = new System.Drawing.Size(65, 70);
            buttonNewTool.TabIndex = 14;
            buttonNewTool.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            buttonNewTool.Click += buttonNewTool_Click;
            // 
            // buttonDeleteVehicle
            // 
            buttonDeleteVehicle.Enabled = false;
            buttonDeleteVehicle.FlatAppearance.BorderSize = 0;
            buttonDeleteVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonDeleteVehicle.Font = new System.Drawing.Font("Tahoma", 9F);
            buttonDeleteVehicle.Image = Properties.Resources.Trash;
            buttonDeleteVehicle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            buttonDeleteVehicle.Location = new System.Drawing.Point(424, 35);
            buttonDeleteVehicle.Name = "buttonDeleteVehicle";
            buttonDeleteVehicle.Size = new System.Drawing.Size(65, 70);
            buttonDeleteVehicle.TabIndex = 2;
            buttonDeleteVehicle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            buttonDeleteVehicle.Click += buttonDeleteVehicle_Click;
            // 
            // buttonDeleteTool
            // 
            buttonDeleteTool.Enabled = false;
            buttonDeleteTool.FlatAppearance.BorderSize = 0;
            buttonDeleteTool.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonDeleteTool.Font = new System.Drawing.Font("Tahoma", 9F);
            buttonDeleteTool.Image = Properties.Resources.Trash;
            buttonDeleteTool.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            buttonDeleteTool.Location = new System.Drawing.Point(918, 35);
            buttonDeleteTool.Name = "buttonDeleteTool";
            buttonDeleteTool.Size = new System.Drawing.Size(65, 70);
            buttonDeleteTool.TabIndex = 13;
            buttonDeleteTool.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            buttonDeleteTool.Click += buttonDeleteTool_Click;
            // 
            // buttonRenameVehicle
            // 
            buttonRenameVehicle.Enabled = false;
            buttonRenameVehicle.FlatAppearance.BorderSize = 0;
            buttonRenameVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonRenameVehicle.Font = new System.Drawing.Font("Tahoma", 9F);
            buttonRenameVehicle.Image = Properties.Resources.FileEditName;
            buttonRenameVehicle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            buttonRenameVehicle.Location = new System.Drawing.Point(424, 195);
            buttonRenameVehicle.Name = "buttonRenameVehicle";
            buttonRenameVehicle.Size = new System.Drawing.Size(65, 70);
            buttonRenameVehicle.TabIndex = 27;
            buttonRenameVehicle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            buttonRenameVehicle.Click += buttonRenameVehicle_Click;
            // 
            // buttonRenameTool
            // 
            buttonRenameTool.Enabled = false;
            buttonRenameTool.FlatAppearance.BorderSize = 0;
            buttonRenameTool.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonRenameTool.Font = new System.Drawing.Font("Tahoma", 9F);
            buttonRenameTool.Image = Properties.Resources.FileEditName;
            buttonRenameTool.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            buttonRenameTool.Location = new System.Drawing.Point(918, 195);
            buttonRenameTool.Name = "buttonRenameTool";
            buttonRenameTool.Size = new System.Drawing.Size(65, 70);
            buttonRenameTool.TabIndex = 28;
            buttonRenameTool.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            buttonRenameTool.Click += buttonRenameTool_Click;
            // 
            // buttonResetVehicle
            // 
            buttonResetVehicle.FlatAppearance.BorderSize = 0;
            buttonResetVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonResetVehicle.Font = new System.Drawing.Font("Tahoma", 9F);
            buttonResetVehicle.Image = Properties.Resources.Reset_Default;
            buttonResetVehicle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            buttonResetVehicle.Location = new System.Drawing.Point(424, 275);
            buttonResetVehicle.Name = "buttonResetVehicle";
            buttonResetVehicle.Size = new System.Drawing.Size(65, 70);
            buttonResetVehicle.TabIndex = 29;
            buttonResetVehicle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            buttonResetVehicle.Click += buttonResetVehicle_Click;
            // 
            // buttonResetTool
            // 
            buttonResetTool.FlatAppearance.BorderSize = 0;
            buttonResetTool.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonResetTool.Font = new System.Drawing.Font("Tahoma", 9F);
            buttonResetTool.Image = Properties.Resources.Reset_Default;
            buttonResetTool.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            buttonResetTool.Location = new System.Drawing.Point(918, 275);
            buttonResetTool.Name = "buttonResetTool";
            buttonResetTool.Size = new System.Drawing.Size(65, 70);
            buttonResetTool.TabIndex = 30;
            buttonResetTool.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            buttonResetTool.Click += buttonResetTool_Click;
            // 
            // buttonConvertOld
            // 
            buttonConvertOld.BackColor = System.Drawing.Color.LightSalmon;
            buttonConvertOld.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonConvertOld.Font = new System.Drawing.Font("Tahoma", 11F);
            buttonConvertOld.Location = new System.Drawing.Point(12, 481);
            buttonConvertOld.Name = "buttonConvertOld";
            buttonConvertOld.Size = new System.Drawing.Size(161, 49);
            buttonConvertOld.TabIndex = 23;
            buttonConvertOld.Text = "Convert Old profiles";
            buttonConvertOld.UseVisualStyleBackColor = false;
            buttonConvertOld.Click += buttonConvertOld_Click;
            // 
            // lblVehHitch
            // 
            lblVehHitch.Font = new System.Drawing.Font("Tahoma", 10F);
            lblVehHitch.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
            lblVehHitch.Location = new System.Drawing.Point(501, 449);
            lblVehHitch.Name = "lblVehHitch";
            lblVehHitch.Size = new System.Drawing.Size(220, 20);
            lblVehHitch.TabIndex = 26;
            lblVehHitch.Text = "Hitch:";
            // 
            // FormLoadVehicleTool
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.WhiteSmoke;
            ClientSize = new System.Drawing.Size(1008, 545);
            ControlBox = false;
            Controls.Add(lblVehHitch);
            Controls.Add(lblCurrentVehicle);
            Controls.Add(listViewVehicles);
            Controls.Add(buttonDeleteVehicle);
            Controls.Add(buttonNewVehicle);
            Controls.Add(buttonRenameVehicle);
            Controls.Add(buttonResetVehicle);
            Controls.Add(lblSelectedVehicle);
            Controls.Add(lblVehType);
            Controls.Add(lblVehWheelbase);
            Controls.Add(lblVehAntPivot);
            Controls.Add(lblVehAntOffset);
            Controls.Add(lblVehTrackWidth);
            Controls.Add(lblCurrentTool);
            Controls.Add(listViewTools);
            Controls.Add(buttonDeleteTool);
            Controls.Add(buttonNewTool);
            Controls.Add(buttonRenameTool);
            Controls.Add(buttonResetTool);
            Controls.Add(lblSelectedTool);
            Controls.Add(lblToolWidth);
            Controls.Add(lblToolOverlap);
            Controls.Add(lblToolOffset);
            Controls.Add(lblToolSections);
            Controls.Add(lblToolAttach);
            Controls.Add(lblToolHitch);
            Controls.Add(buttonConvertOld);
            Controls.Add(buttonCancel);
            Controls.Add(buttonLoad);
            Font = new System.Drawing.Font("Tahoma", 14.25F);
            MaximumSize = new System.Drawing.Size(1024, 768);
            Name = "FormLoadVehicleTool";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Vehicle / Tool";
            Load += FormLoadVehicleTool_Load;
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewVehicles;
        private System.Windows.Forms.ColumnHeader columnHeaderVehicle;
        private System.Windows.Forms.ListView listViewTools;
        private System.Windows.Forms.ColumnHeader columnHeaderTool;
        private System.Windows.Forms.Label lblCurrentVehicle;
        private System.Windows.Forms.Label lblCurrentTool;
        private System.Windows.Forms.Label lblSelectedVehicle;
        private System.Windows.Forms.Label lblSelectedTool;
        private System.Windows.Forms.Label lblVehType;
        private System.Windows.Forms.Label lblVehWheelbase;
        private System.Windows.Forms.Label lblVehAntPivot;
        private System.Windows.Forms.Label lblVehAntOffset;
        private System.Windows.Forms.Label lblVehTrackWidth;
        private System.Windows.Forms.Label lblToolWidth;
        private System.Windows.Forms.Label lblToolOverlap;
        private System.Windows.Forms.Label lblToolOffset;
        private System.Windows.Forms.Label lblToolSections;
        private System.Windows.Forms.Label lblToolAttach;
        private System.Windows.Forms.Label lblToolHitch;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonNewVehicle;
        private System.Windows.Forms.Button buttonNewTool;
        private System.Windows.Forms.Button buttonDeleteVehicle;
        private System.Windows.Forms.Button buttonDeleteTool;
        private System.Windows.Forms.Button buttonRenameVehicle;
        private System.Windows.Forms.Button buttonRenameTool;
        private System.Windows.Forms.Button buttonResetVehicle;
        private System.Windows.Forms.Button buttonResetTool;
        private System.Windows.Forms.Button buttonConvertOld;
        private System.Windows.Forms.Label lblVehHitch;
    }
}

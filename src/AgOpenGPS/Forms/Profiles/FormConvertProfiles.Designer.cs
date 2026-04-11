namespace AgOpenGPS.Forms.Profiles
{
    partial class FormConvertProfiles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConvertProfiles));
            listViewFiles = new System.Windows.Forms.ListView();
            columnHeaderName = new System.Windows.Forms.ColumnHeader();
            labelTitle = new System.Windows.Forms.Label();
            labelStatus = new System.Windows.Forms.Label();
            buttonConvert = new System.Windows.Forms.Button();
            buttonClose = new System.Windows.Forms.Button();
            panelDetails = new System.Windows.Forms.Panel();
            labelStep2 = new System.Windows.Forms.Label();
            panelTool = new System.Windows.Forms.Panel();
            btnToggleTool = new System.Windows.Forms.Button();
            textBoxToolName = new System.Windows.Forms.TextBox();
            labelToolName = new System.Windows.Forms.Label();
            panelVehicle = new System.Windows.Forms.Panel();
            textBoxVehicleName = new System.Windows.Forms.TextBox();
            labelVehicleName = new System.Windows.Forms.Label();
            btnToggleVehicle = new System.Windows.Forms.Button();
            labelStep1 = new System.Windows.Forms.Label();
            labelExplanation = new System.Windows.Forms.Label();
            panelDetails.SuspendLayout();
            panelTool.SuspendLayout();
            panelVehicle.SuspendLayout();
            SuspendLayout();
            // 
            // listViewFiles
            // 
            listViewFiles.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            listViewFiles.BackColor = System.Drawing.SystemColors.InactiveCaption;
            listViewFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeaderName });
            listViewFiles.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            listViewFiles.FullRowSelect = true;
            listViewFiles.GridLines = true;
            listViewFiles.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            listViewFiles.LabelWrap = false;
            listViewFiles.Location = new System.Drawing.Point(20, 130);
            listViewFiles.Margin = new System.Windows.Forms.Padding(0);
            listViewFiles.MultiSelect = false;
            listViewFiles.Name = "listViewFiles";
            listViewFiles.Size = new System.Drawing.Size(430, 380);
            listViewFiles.TabIndex = 1;
            listViewFiles.UseCompatibleStateImageBehavior = false;
            listViewFiles.View = System.Windows.Forms.View.Details;
            listViewFiles.SelectedIndexChanged += listViewFiles_SelectedIndexChanged;
            // 
            // columnHeaderName
            // 
            columnHeaderName.Text = "File Name";
            columnHeaderName.Width = 280;
            // 
            // labelTitle
            // 
            labelTitle.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            labelTitle.Location = new System.Drawing.Point(20, 15);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new System.Drawing.Size(860, 35);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Convert Old Profile Files to New Format";
            labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelStatus
            // 
            labelStatus.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelStatus.AutoSize = true;
            labelStatus.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic);
            labelStatus.Location = new System.Drawing.Point(20, 520);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new System.Drawing.Size(85, 19);
            labelStatus.TabIndex = 3;
            labelStatus.Text = "labelStatus";
            labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonConvert
            // 
            buttonConvert.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            buttonConvert.Enabled = false;
            buttonConvert.FlatAppearance.BorderSize = 0;
            buttonConvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonConvert.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            buttonConvert.Image = Properties.Resources.boundaryPlay;
            buttonConvert.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            buttonConvert.Location = new System.Drawing.Point(741, 539);
            buttonConvert.Name = "buttonConvert";
            buttonConvert.Size = new System.Drawing.Size(120, 99);
            buttonConvert.TabIndex = 4;
            buttonConvert.Text = "Convert";
            buttonConvert.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            buttonConvert.Click += buttonConvert_Click;
            // 
            // buttonClose
            // 
            buttonClose.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            buttonClose.FlatAppearance.BorderSize = 0;
            buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonClose.Font = new System.Drawing.Font("Tahoma", 14F);
            buttonClose.Image = (System.Drawing.Image)resources.GetObject("buttonClose.Image");
            buttonClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            buttonClose.Location = new System.Drawing.Point(905, 539);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new System.Drawing.Size(91, 99);
            buttonClose.TabIndex = 5;
            buttonClose.Text = "Close";
            buttonClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // panelDetails
            // 
            panelDetails.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            panelDetails.Controls.Add(labelStep2);
            panelDetails.Controls.Add(panelTool);
            panelDetails.Controls.Add(panelVehicle);
            panelDetails.Enabled = false;
            panelDetails.Location = new System.Drawing.Point(468, 130);
            panelDetails.Name = "panelDetails";
            panelDetails.Size = new System.Drawing.Size(520, 300);
            panelDetails.TabIndex = 2;
            // 
            // labelStep2
            // 
            labelStep2.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            labelStep2.Location = new System.Drawing.Point(10, 5);
            labelStep2.Name = "labelStep2";
            labelStep2.Size = new System.Drawing.Size(500, 25);
            labelStep2.TabIndex = 8;
            labelStep2.Text = "Step 2: Select to convert (Vehicle and/or Tool):";
            // 
            // panelTool
            // 
            panelTool.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelTool.Controls.Add(btnToggleTool);
            panelTool.Controls.Add(textBoxToolName);
            panelTool.Controls.Add(labelToolName);
            panelTool.Location = new System.Drawing.Point(10, 172);
            panelTool.Name = "panelTool";
            panelTool.Size = new System.Drawing.Size(500, 100);
            panelTool.TabIndex = 6;
            // 
            // btnToggleTool
            // 
            btnToggleTool.BackColor = System.Drawing.Color.LightGreen;
            btnToggleTool.FlatAppearance.BorderSize = 0;
            btnToggleTool.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnToggleTool.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            btnToggleTool.ForeColor = System.Drawing.Color.Black;
            btnToggleTool.Location = new System.Drawing.Point(10, 10);
            btnToggleTool.Name = "btnToggleTool";
            btnToggleTool.Size = new System.Drawing.Size(125, 80);
            btnToggleTool.TabIndex = 0;
            btnToggleTool.Text = "Convert Tool";
            btnToggleTool.UseVisualStyleBackColor = false;
            btnToggleTool.Click += btnToggleTool_Click;
            // 
            // textBoxToolName
            // 
            textBoxToolName.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            textBoxToolName.Location = new System.Drawing.Point(145, 48);
            textBoxToolName.Name = "textBoxToolName";
            textBoxToolName.Size = new System.Drawing.Size(345, 36);
            textBoxToolName.TabIndex = 2;
            textBoxToolName.Click += TextBox_Click;
            textBoxToolName.TextChanged += textBoxName_TextChanged;
            // 
            // labelToolName
            // 
            labelToolName.Font = new System.Drawing.Font("Tahoma", 11F);
            labelToolName.Location = new System.Drawing.Point(145, 10);
            labelToolName.Name = "labelToolName";
            labelToolName.Size = new System.Drawing.Size(345, 30);
            labelToolName.TabIndex = 1;
            labelToolName.Text = "Tool profile name:";
            // 
            // panelVehicle
            // 
            panelVehicle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelVehicle.Controls.Add(textBoxVehicleName);
            panelVehicle.Controls.Add(labelVehicleName);
            panelVehicle.Controls.Add(btnToggleVehicle);
            panelVehicle.Location = new System.Drawing.Point(10, 48);
            panelVehicle.Name = "panelVehicle";
            panelVehicle.Size = new System.Drawing.Size(500, 100);
            panelVehicle.TabIndex = 5;
            // 
            // textBoxVehicleName
            // 
            textBoxVehicleName.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            textBoxVehicleName.Location = new System.Drawing.Point(145, 48);
            textBoxVehicleName.Name = "textBoxVehicleName";
            textBoxVehicleName.Size = new System.Drawing.Size(345, 36);
            textBoxVehicleName.TabIndex = 2;
            textBoxVehicleName.Click += TextBox_Click;
            textBoxVehicleName.TextChanged += textBoxName_TextChanged;
            // 
            // labelVehicleName
            // 
            labelVehicleName.Font = new System.Drawing.Font("Tahoma", 11F);
            labelVehicleName.Location = new System.Drawing.Point(145, 10);
            labelVehicleName.Name = "labelVehicleName";
            labelVehicleName.Size = new System.Drawing.Size(345, 30);
            labelVehicleName.TabIndex = 1;
            labelVehicleName.Text = "Vehicle profile name:";
            // 
            // btnToggleVehicle
            // 
            btnToggleVehicle.BackColor = System.Drawing.Color.LightGreen;
            btnToggleVehicle.FlatAppearance.BorderSize = 0;
            btnToggleVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnToggleVehicle.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            btnToggleVehicle.ForeColor = System.Drawing.Color.Black;
            btnToggleVehicle.Location = new System.Drawing.Point(10, 10);
            btnToggleVehicle.Name = "btnToggleVehicle";
            btnToggleVehicle.Size = new System.Drawing.Size(125, 80);
            btnToggleVehicle.TabIndex = 0;
            btnToggleVehicle.Text = "Convert Vehicle";
            btnToggleVehicle.UseVisualStyleBackColor = false;
            btnToggleVehicle.Click += btnToggleVehicle_Click;
            // 
            // labelStep1
            // 
            labelStep1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            labelStep1.Location = new System.Drawing.Point(20, 100);
            labelStep1.Name = "labelStep1";
            labelStep1.Size = new System.Drawing.Size(320, 25);
            labelStep1.TabIndex = 20;
            labelStep1.Text = "Step 1: Select an old profile file:";
            // 
            // labelExplanation
            // 
            labelExplanation.Font = new System.Drawing.Font("Tahoma", 11F);
            labelExplanation.Location = new System.Drawing.Point(20, 55);
            labelExplanation.Name = "labelExplanation";
            labelExplanation.Size = new System.Drawing.Size(860, 40);
            labelExplanation.TabIndex = 21;
            labelExplanation.Text = "Old profiles contained all settings in one file. New format separates Vehicle, Tool, and Environment. Select what you want to extract.";
            // 
            // FormConvertProfiles
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.WhiteSmoke;
            ClientSize = new System.Drawing.Size(1008, 650);
            ControlBox = false;
            Controls.Add(labelExplanation);
            Controls.Add(buttonConvert);
            Controls.Add(buttonClose);
            Controls.Add(labelStatus);
            Controls.Add(panelDetails);
            Controls.Add(listViewFiles);
            Controls.Add(labelStep1);
            Controls.Add(labelTitle);
            Font = new System.Drawing.Font("Tahoma", 11F);
            MinimumSize = new System.Drawing.Size(900, 650);
            Name = "FormConvertProfiles";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Convert Old Profiles";
            Load += FormConvertProfiles_Load;
            panelDetails.ResumeLayout(false);
            panelTool.ResumeLayout(false);
            panelTool.PerformLayout();
            panelVehicle.ResumeLayout(false);
            panelVehicle.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewFiles;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Panel panelDetails;
        private System.Windows.Forms.Button btnToggleVehicle;
        private System.Windows.Forms.Button btnToggleTool;
        private System.Windows.Forms.TextBox textBoxVehicleName;
        private System.Windows.Forms.TextBox textBoxToolName;
        private System.Windows.Forms.Label labelStep1;
        private System.Windows.Forms.Label labelStep2;
        private System.Windows.Forms.Label labelVehicleName;
        private System.Windows.Forms.Label labelToolName;
        private System.Windows.Forms.Label labelExplanation;
        private System.Windows.Forms.Panel panelVehicle;
        private System.Windows.Forms.Panel panelTool;
    }
}

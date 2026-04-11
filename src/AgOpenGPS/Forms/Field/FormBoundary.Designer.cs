namespace AgOpenGPS
{
    partial class FormBoundary
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
            labelBounds = new System.Windows.Forms.Label();
            Thru = new System.Windows.Forms.Label();
            Area = new System.Windows.Forms.Label();
            panelMain = new System.Windows.Forms.Panel();
            btnBuildBoundaryFromTracks = new System.Windows.Forms.Button();
            flp1 = new System.Windows.Forms.FlowLayoutPanel();
            btnBingMaps = new System.Windows.Forms.Button();
            btnAdd = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            btnOpenGoogleEarth = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            panelChoose = new System.Windows.Forms.Panel();
            btnCancelChoose = new System.Windows.Forms.Button();
            btnGetKML = new System.Windows.Forms.Button();
            btnDriveOrExt = new System.Windows.Forms.Button();
            panelKML = new System.Windows.Forms.Panel();
            label5 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            btnCancelKML = new System.Windows.Forms.Button();
            btnLoadBoundaryFromGE = new System.Windows.Forms.Button();
            btnLoadMultiBoundaryFromGE = new System.Windows.Forms.Button();
            panelMain.SuspendLayout();
            panelChoose.SuspendLayout();
            panelKML.SuspendLayout();
            SuspendLayout();
            // 
            // labelBounds
            // 
            labelBounds.BackColor = System.Drawing.Color.Transparent;
            labelBounds.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelBounds.ForeColor = System.Drawing.Color.Black;
            labelBounds.Location = new System.Drawing.Point(33, 85);
            labelBounds.Name = "labelBounds";
            labelBounds.Size = new System.Drawing.Size(177, 32);
            labelBounds.TabIndex = 203;
            labelBounds.Text = "Bounds";
            labelBounds.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Thru
            // 
            Thru.BackColor = System.Drawing.Color.Transparent;
            Thru.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Thru.ForeColor = System.Drawing.Color.Black;
            Thru.Location = new System.Drawing.Point(410, 85);
            Thru.Name = "Thru";
            Thru.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Thru.Size = new System.Drawing.Size(145, 32);
            Thru.TabIndex = 202;
            Thru.Text = "Thru?";
            Thru.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Area
            // 
            Area.BackColor = System.Drawing.Color.Transparent;
            Area.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Area.ForeColor = System.Drawing.Color.Black;
            Area.Location = new System.Drawing.Point(229, 85);
            Area.Name = "Area";
            Area.Size = new System.Drawing.Size(177, 32);
            Area.TabIndex = 201;
            Area.Text = "Area";
            Area.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // panelMain
            // 
            panelMain.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            panelMain.BackColor = System.Drawing.Color.WhiteSmoke;
            panelMain.Controls.Add(btnBuildBoundaryFromTracks);
            panelMain.Controls.Add(flp1);
            panelMain.Controls.Add(btnBingMaps);
            panelMain.Controls.Add(btnAdd);
            panelMain.Controls.Add(btnCancel);
            panelMain.Controls.Add(Area);
            panelMain.Controls.Add(Thru);
            panelMain.Controls.Add(labelBounds);
            panelMain.Controls.Add(btnOpenGoogleEarth);
            panelMain.Controls.Add(btnDelete);
            panelMain.Location = new System.Drawing.Point(4, 6);
            panelMain.Name = "panelMain";
            panelMain.Size = new System.Drawing.Size(608, 299);
            panelMain.TabIndex = 417;
            // 
            // btnBuildBoundaryFromTracks
            // 
            btnBuildBoundaryFromTracks.FlatAppearance.BorderSize = 0;
            btnBuildBoundaryFromTracks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBuildBoundaryFromTracks.Image = Properties.Resources.BoundaryFromTracks;
            btnBuildBoundaryFromTracks.Location = new System.Drawing.Point(286, 10);
            btnBuildBoundaryFromTracks.Name = "btnBuildBoundaryFromTracks";
            btnBuildBoundaryFromTracks.Size = new System.Drawing.Size(64, 64);
            btnBuildBoundaryFromTracks.TabIndex = 219;
            btnBuildBoundaryFromTracks.UseVisualStyleBackColor = true;
            btnBuildBoundaryFromTracks.Click += btnBuildBoundaryFromTracks_Click;
            // 
            // flp1
            // 
            flp1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            flp1.AutoScroll = true;
            flp1.Location = new System.Drawing.Point(11, 120);
            flp1.Name = "flp1";
            flp1.Size = new System.Drawing.Size(586, 166);
            flp1.TabIndex = 218;
            // 
            // btnBingMaps
            // 
            btnBingMaps.DialogResult = System.Windows.Forms.DialogResult.Yes;
            btnBingMaps.FlatAppearance.BorderSize = 0;
            btnBingMaps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBingMaps.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnBingMaps.Image = Properties.Resources.bing1;
            btnBingMaps.Location = new System.Drawing.Point(190, 10);
            btnBingMaps.Name = "btnBingMaps";
            btnBingMaps.Size = new System.Drawing.Size(62, 63);
            btnBingMaps.TabIndex = 217;
            btnBingMaps.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnBingMaps.UseVisualStyleBackColor = true;
            btnBingMaps.Click += btnBingMaps_Click;
            // 
            // btnAdd
            // 
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAdd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnAdd.Image = Properties.Resources.AddNew;
            btnAdd.Location = new System.Drawing.Point(396, 10);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(62, 63);
            btnAdd.TabIndex = 214;
            btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancel.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnCancel.Image = Properties.Resources.OK64;
            btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnCancel.Location = new System.Drawing.Point(512, 10);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(62, 63);
            btnCancel.TabIndex = 206;
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnReturn_Click;
            // 
            // btnOpenGoogleEarth
            // 
            btnOpenGoogleEarth.FlatAppearance.BorderSize = 0;
            btnOpenGoogleEarth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnOpenGoogleEarth.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnOpenGoogleEarth.Image = Properties.Resources.GoogleEarth;
            btnOpenGoogleEarth.Location = new System.Drawing.Point(96, 10);
            btnOpenGoogleEarth.Name = "btnOpenGoogleEarth";
            btnOpenGoogleEarth.Size = new System.Drawing.Size(62, 63);
            btnOpenGoogleEarth.TabIndex = 213;
            btnOpenGoogleEarth.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnOpenGoogleEarth.UseVisualStyleBackColor = true;
            btnOpenGoogleEarth.Click += btnOpenGoogleEarth_Click;
            // 
            // btnDelete
            // 
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDelete.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnDelete.Image = Properties.Resources.Trash;
            btnDelete.Location = new System.Drawing.Point(11, 10);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(62, 63);
            btnDelete.TabIndex = 65;
            btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // panelChoose
            // 
            panelChoose.BackColor = System.Drawing.Color.WhiteSmoke;
            panelChoose.Controls.Add(btnCancelChoose);
            panelChoose.Controls.Add(btnGetKML);
            panelChoose.Controls.Add(btnDriveOrExt);
            panelChoose.Location = new System.Drawing.Point(619, 6);
            panelChoose.Name = "panelChoose";
            panelChoose.Size = new System.Drawing.Size(217, 298);
            panelChoose.TabIndex = 419;
            // 
            // btnCancelChoose
            // 
            btnCancelChoose.BackColor = System.Drawing.Color.Transparent;
            btnCancelChoose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnCancelChoose.FlatAppearance.BorderSize = 0;
            btnCancelChoose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancelChoose.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnCancelChoose.Image = Properties.Resources.Cancel64;
            btnCancelChoose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnCancelChoose.Location = new System.Drawing.Point(141, 237);
            btnCancelChoose.Name = "btnCancelChoose";
            btnCancelChoose.Size = new System.Drawing.Size(68, 58);
            btnCancelChoose.TabIndex = 425;
            btnCancelChoose.UseVisualStyleBackColor = false;
            btnCancelChoose.Click += btnReturn_Click;
            // 
            // btnGetKML
            // 
            btnGetKML.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            btnGetKML.FlatAppearance.BorderSize = 0;
            btnGetKML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnGetKML.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnGetKML.Image = Properties.Resources.BoundaryLoadFromGE;
            btnGetKML.Location = new System.Drawing.Point(41, 16);
            btnGetKML.Name = "btnGetKML";
            btnGetKML.Size = new System.Drawing.Size(81, 78);
            btnGetKML.TabIndex = 213;
            btnGetKML.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnGetKML.UseVisualStyleBackColor = true;
            btnGetKML.Click += btnGetKML_Click;
            // 
            // btnDriveOrExt
            // 
            btnDriveOrExt.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnDriveOrExt.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            btnDriveOrExt.FlatAppearance.BorderSize = 0;
            btnDriveOrExt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDriveOrExt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnDriveOrExt.Image = Properties.Resources.SteerRight;
            btnDriveOrExt.Location = new System.Drawing.Point(41, 139);
            btnDriveOrExt.Name = "btnDriveOrExt";
            btnDriveOrExt.Size = new System.Drawing.Size(81, 78);
            btnDriveOrExt.TabIndex = 212;
            btnDriveOrExt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnDriveOrExt.UseVisualStyleBackColor = true;
            btnDriveOrExt.Click += btnDriveOrExt_Click;
            // 
            // panelKML
            // 
            panelKML.BackColor = System.Drawing.Color.WhiteSmoke;
            panelKML.Controls.Add(label5);
            panelKML.Controls.Add(label3);
            panelKML.Controls.Add(btnCancelKML);
            panelKML.Controls.Add(btnLoadBoundaryFromGE);
            panelKML.Controls.Add(btnLoadMultiBoundaryFromGE);
            panelKML.Location = new System.Drawing.Point(848, 6);
            panelKML.Name = "panelKML";
            panelKML.Size = new System.Drawing.Size(229, 298);
            panelKML.TabIndex = 419;
            // 
            // label5
            // 
            label5.BackColor = System.Drawing.Color.Transparent;
            label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label5.ForeColor = System.Drawing.Color.Black;
            label5.Location = new System.Drawing.Point(149, 34);
            label5.Name = "label5";
            label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            label5.Size = new System.Drawing.Size(31, 27);
            label5.TabIndex = 428;
            label5.Text = "+";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label3.ForeColor = System.Drawing.Color.Black;
            label3.Location = new System.Drawing.Point(136, 166);
            label3.Name = "label3";
            label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            label3.Size = new System.Drawing.Size(52, 27);
            label3.TabIndex = 427;
            label3.Text = "+++";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancelKML
            // 
            btnCancelKML.BackColor = System.Drawing.Color.Transparent;
            btnCancelKML.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnCancelKML.FlatAppearance.BorderSize = 0;
            btnCancelKML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancelKML.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnCancelKML.Image = Properties.Resources.Cancel64;
            btnCancelKML.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnCancelKML.Location = new System.Drawing.Point(153, 237);
            btnCancelKML.Name = "btnCancelKML";
            btnCancelKML.Size = new System.Drawing.Size(68, 58);
            btnCancelKML.TabIndex = 426;
            btnCancelKML.UseVisualStyleBackColor = false;
            btnCancelKML.Click += btnReturn_Click;
            // 
            // btnLoadBoundaryFromGE
            // 
            btnLoadBoundaryFromGE.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            btnLoadBoundaryFromGE.FlatAppearance.BorderSize = 0;
            btnLoadBoundaryFromGE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLoadBoundaryFromGE.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnLoadBoundaryFromGE.Image = Properties.Resources.BoundaryLoadFromGE;
            btnLoadBoundaryFromGE.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnLoadBoundaryFromGE.Location = new System.Drawing.Point(49, 16);
            btnLoadBoundaryFromGE.Name = "btnLoadBoundaryFromGE";
            btnLoadBoundaryFromGE.Size = new System.Drawing.Size(81, 78);
            btnLoadBoundaryFromGE.TabIndex = 210;
            btnLoadBoundaryFromGE.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnLoadBoundaryFromGE.UseVisualStyleBackColor = true;
            btnLoadBoundaryFromGE.Click += btnLoadBoundaryFromGE_Click;
            // 
            // btnLoadMultiBoundaryFromGE
            // 
            btnLoadMultiBoundaryFromGE.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            btnLoadMultiBoundaryFromGE.FlatAppearance.BorderSize = 0;
            btnLoadMultiBoundaryFromGE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLoadMultiBoundaryFromGE.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnLoadMultiBoundaryFromGE.Image = Properties.Resources.BoundaryLoadMultiFromGE;
            btnLoadMultiBoundaryFromGE.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnLoadMultiBoundaryFromGE.Location = new System.Drawing.Point(49, 137);
            btnLoadMultiBoundaryFromGE.Name = "btnLoadMultiBoundaryFromGE";
            btnLoadMultiBoundaryFromGE.Size = new System.Drawing.Size(81, 78);
            btnLoadMultiBoundaryFromGE.TabIndex = 211;
            btnLoadMultiBoundaryFromGE.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnLoadMultiBoundaryFromGE.UseVisualStyleBackColor = true;
            btnLoadMultiBoundaryFromGE.Click += btnLoadBoundaryFromGE_Click;
            // 
            // FormBoundary
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Cyan;
            ClientSize = new System.Drawing.Size(1084, 310);
            ControlBox = false;
            Controls.Add(panelChoose);
            Controls.Add(panelKML);
            Controls.Add(panelMain);
            Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            HelpButton = true;
            Margin = new System.Windows.Forms.Padding(5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormBoundary";
            Padding = new System.Windows.Forms.Padding(2);
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Boundary";
            FormClosing += FormBoundary_FormClosing;
            Load += FormBoundary_Load;
            ResizeEnd += FormBoundary_ResizeEnd;
            panelMain.ResumeLayout(false);
            panelChoose.ResumeLayout(false);
            panelKML.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label labelBounds;
        private System.Windows.Forms.Label Thru;
        private System.Windows.Forms.Label Area;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnLoadMultiBoundaryFromGE;
        private System.Windows.Forms.Button btnLoadBoundaryFromGE;
        private System.Windows.Forms.Button btnDriveOrExt;
        private System.Windows.Forms.Button btnOpenGoogleEarth;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelKML;
        private System.Windows.Forms.Panel panelChoose;
        private System.Windows.Forms.Button btnGetKML;
        private System.Windows.Forms.Button btnCancelKML;
        private System.Windows.Forms.Button btnCancelChoose;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBingMaps;
        private System.Windows.Forms.FlowLayoutPanel flp1;
        private System.Windows.Forms.Button btnBuildBoundaryFromTracks;
    }
}
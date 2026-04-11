namespace AgOpenGPS
{
    partial class FormAllSettings
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panelHeader = new System.Windows.Forms.Panel();
            lblVehicleName = new System.Windows.Forms.Label();
            lblToolName = new System.Windows.Forms.Label();
            lblEnvironmentName = new System.Windows.Forms.Label();
            tabControl = new System.Windows.Forms.TabControl();
            tabVehicle = new System.Windows.Forms.TabPage();
            tableLayoutPanelVehicle = new System.Windows.Forms.TableLayoutPanel();
            dgvVehicleL = new System.Windows.Forms.DataGridView();
            dgvVehicleM = new System.Windows.Forms.DataGridView();
            dgvVehicleR = new System.Windows.Forms.DataGridView();
            tabTool = new System.Windows.Forms.TabPage();
            tableLayoutPanelTool = new System.Windows.Forms.TableLayoutPanel();
            dgvToolL = new System.Windows.Forms.DataGridView();
            dgvToolM = new System.Windows.Forms.DataGridView();
            dgvToolR = new System.Windows.Forms.DataGridView();
            tabEnvironment = new System.Windows.Forms.TabPage();
            tableLayoutPanelEnvironment = new System.Windows.Forms.TableLayoutPanel();
            dgvEnvironmentL = new System.Windows.Forms.DataGridView();
            dgvEnvironmentM = new System.Windows.Forms.DataGridView();
            dgvEnvironmentR = new System.Windows.Forms.DataGridView();
            tabSystem = new System.Windows.Forms.TabPage();
            dgvSystem = new System.Windows.Forms.DataGridView();
            btnClose = new System.Windows.Forms.Button();
            btnExportCSV = new System.Windows.Forms.Button();
            btnScreenShot = new System.Windows.Forms.Button();
            btnCreatePNG = new System.Windows.Forms.Button();
            timer1 = new System.Windows.Forms.Timer(components);
            panelHeader.SuspendLayout();
            tabControl.SuspendLayout();
            tabVehicle.SuspendLayout();
            tableLayoutPanelVehicle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVehicleL).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvVehicleM).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvVehicleR).BeginInit();
            tabTool.SuspendLayout();
            tableLayoutPanelTool.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvToolL).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvToolM).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvToolR).BeginInit();
            tabEnvironment.SuspendLayout();
            tableLayoutPanelEnvironment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEnvironmentL).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEnvironmentM).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEnvironmentR).BeginInit();
            tabSystem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSystem).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = System.Drawing.Color.SteelBlue;
            panelHeader.Controls.Add(lblVehicleName);
            panelHeader.Controls.Add(lblToolName);
            panelHeader.Controls.Add(lblEnvironmentName);
            panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            panelHeader.Location = new System.Drawing.Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new System.Drawing.Size(1188, 52);
            panelHeader.TabIndex = 0;
            // 
            // lblVehicleName
            // 
            lblVehicleName.BackColor = System.Drawing.Color.Transparent;
            lblVehicleName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            lblVehicleName.ForeColor = System.Drawing.Color.White;
            lblVehicleName.Location = new System.Drawing.Point(6, 6);
            lblVehicleName.Name = "lblVehicleName";
            lblVehicleName.Size = new System.Drawing.Size(380, 38);
            lblVehicleName.TabIndex = 0;
            lblVehicleName.Text = "Vehicle: -";
            lblVehicleName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblToolName
            // 
            lblToolName.BackColor = System.Drawing.Color.Transparent;
            lblToolName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            lblToolName.ForeColor = System.Drawing.Color.White;
            lblToolName.Location = new System.Drawing.Point(400, 6);
            lblToolName.Name = "lblToolName";
            lblToolName.Size = new System.Drawing.Size(380, 38);
            lblToolName.TabIndex = 1;
            lblToolName.Text = "Tool: -";
            lblToolName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEnvironmentName
            // 
            lblEnvironmentName.BackColor = System.Drawing.Color.Transparent;
            lblEnvironmentName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            lblEnvironmentName.ForeColor = System.Drawing.Color.White;
            lblEnvironmentName.Location = new System.Drawing.Point(794, 6);
            lblEnvironmentName.Name = "lblEnvironmentName";
            lblEnvironmentName.Size = new System.Drawing.Size(388, 38);
            lblEnvironmentName.TabIndex = 2;
            lblEnvironmentName.Text = "Environment: -";
            lblEnvironmentName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabControl
            // 
            tabControl.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tabControl.Controls.Add(tabVehicle);
            tabControl.Controls.Add(tabTool);
            tabControl.Controls.Add(tabEnvironment);
            tabControl.Controls.Add(tabSystem);
            tabControl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            tabControl.ItemSize = new System.Drawing.Size(220, 44);
            tabControl.Location = new System.Drawing.Point(0, 55);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new System.Drawing.Size(1188, 538);
            tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            tabControl.TabIndex = 1;
            // 
            // tabVehicle
            // 
            tabVehicle.Controls.Add(tableLayoutPanelVehicle);
            tabVehicle.Location = new System.Drawing.Point(4, 48);
            tabVehicle.Name = "tabVehicle";
            tabVehicle.Padding = new System.Windows.Forms.Padding(3);
            tabVehicle.Size = new System.Drawing.Size(1180, 486);
            tabVehicle.TabIndex = 0;
            tabVehicle.Text = "Vehicle";
            tabVehicle.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelVehicle
            // 
            tableLayoutPanelVehicle.ColumnCount = 3;
            tableLayoutPanelVehicle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            tableLayoutPanelVehicle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            tableLayoutPanelVehicle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            tableLayoutPanelVehicle.Controls.Add(dgvVehicleL, 0, 0);
            tableLayoutPanelVehicle.Controls.Add(dgvVehicleM, 1, 0);
            tableLayoutPanelVehicle.Controls.Add(dgvVehicleR, 2, 0);
            tableLayoutPanelVehicle.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanelVehicle.Location = new System.Drawing.Point(3, 3);
            tableLayoutPanelVehicle.Name = "tableLayoutPanelVehicle";
            tableLayoutPanelVehicle.RowCount = 1;
            tableLayoutPanelVehicle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanelVehicle.Size = new System.Drawing.Size(1174, 480);
            tableLayoutPanelVehicle.TabIndex = 0;
            // 
            // dgvVehicleL
            // 
            dgvVehicleL.AllowUserToAddRows = false;
            dgvVehicleL.AllowUserToDeleteRows = false;
            dgvVehicleL.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dgvVehicleL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvVehicleL.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dgvVehicleL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVehicleL.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvVehicleL.Font = new System.Drawing.Font("Tahoma", 10F);
            dgvVehicleL.Location = new System.Drawing.Point(3, 3);
            dgvVehicleL.Name = "dgvVehicleL";
            dgvVehicleL.ReadOnly = true;
            dgvVehicleL.RowHeadersVisible = false;
            dgvVehicleL.Size = new System.Drawing.Size(385, 474);
            dgvVehicleL.TabIndex = 0;
            // 
            // dgvVehicleM
            // 
            dgvVehicleM.AllowUserToAddRows = false;
            dgvVehicleM.AllowUserToDeleteRows = false;
            dgvVehicleM.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dgvVehicleM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvVehicleM.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dgvVehicleM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVehicleM.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvVehicleM.Font = new System.Drawing.Font("Tahoma", 10F);
            dgvVehicleM.Location = new System.Drawing.Point(394, 3);
            dgvVehicleM.Name = "dgvVehicleM";
            dgvVehicleM.ReadOnly = true;
            dgvVehicleM.RowHeadersVisible = false;
            dgvVehicleM.Size = new System.Drawing.Size(385, 474);
            dgvVehicleM.TabIndex = 1;
            // 
            // dgvVehicleR
            // 
            dgvVehicleR.AllowUserToAddRows = false;
            dgvVehicleR.AllowUserToDeleteRows = false;
            dgvVehicleR.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dgvVehicleR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvVehicleR.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dgvVehicleR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVehicleR.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvVehicleR.Font = new System.Drawing.Font("Tahoma", 10F);
            dgvVehicleR.Location = new System.Drawing.Point(785, 3);
            dgvVehicleR.Name = "dgvVehicleR";
            dgvVehicleR.ReadOnly = true;
            dgvVehicleR.RowHeadersVisible = false;
            dgvVehicleR.Size = new System.Drawing.Size(386, 474);
            dgvVehicleR.TabIndex = 2;
            // 
            // tabTool
            // 
            tabTool.Controls.Add(tableLayoutPanelTool);
            tabTool.Location = new System.Drawing.Point(4, 48);
            tabTool.Name = "tabTool";
            tabTool.Padding = new System.Windows.Forms.Padding(3);
            tabTool.Size = new System.Drawing.Size(1180, 486);
            tabTool.TabIndex = 1;
            tabTool.Text = "Tool";
            tabTool.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelTool
            // 
            tableLayoutPanelTool.ColumnCount = 3;
            tableLayoutPanelTool.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            tableLayoutPanelTool.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            tableLayoutPanelTool.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            tableLayoutPanelTool.Controls.Add(dgvToolL, 0, 0);
            tableLayoutPanelTool.Controls.Add(dgvToolM, 1, 0);
            tableLayoutPanelTool.Controls.Add(dgvToolR, 2, 0);
            tableLayoutPanelTool.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanelTool.Location = new System.Drawing.Point(3, 3);
            tableLayoutPanelTool.Name = "tableLayoutPanelTool";
            tableLayoutPanelTool.RowCount = 1;
            tableLayoutPanelTool.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanelTool.Size = new System.Drawing.Size(1174, 480);
            tableLayoutPanelTool.TabIndex = 0;
            // 
            // dgvToolL
            // 
            dgvToolL.AllowUserToAddRows = false;
            dgvToolL.AllowUserToDeleteRows = false;
            dgvToolL.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dgvToolL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvToolL.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dgvToolL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvToolL.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvToolL.Font = new System.Drawing.Font("Tahoma", 10F);
            dgvToolL.Location = new System.Drawing.Point(3, 3);
            dgvToolL.Name = "dgvToolL";
            dgvToolL.ReadOnly = true;
            dgvToolL.RowHeadersVisible = false;
            dgvToolL.Size = new System.Drawing.Size(385, 474);
            dgvToolL.TabIndex = 0;
            // 
            // dgvToolM
            // 
            dgvToolM.AllowUserToAddRows = false;
            dgvToolM.AllowUserToDeleteRows = false;
            dgvToolM.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dgvToolM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvToolM.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dgvToolM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvToolM.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvToolM.Font = new System.Drawing.Font("Tahoma", 10F);
            dgvToolM.Location = new System.Drawing.Point(394, 3);
            dgvToolM.Name = "dgvToolM";
            dgvToolM.ReadOnly = true;
            dgvToolM.RowHeadersVisible = false;
            dgvToolM.Size = new System.Drawing.Size(385, 474);
            dgvToolM.TabIndex = 1;
            // 
            // dgvToolR
            // 
            dgvToolR.AllowUserToAddRows = false;
            dgvToolR.AllowUserToDeleteRows = false;
            dgvToolR.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dgvToolR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvToolR.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dgvToolR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvToolR.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvToolR.Font = new System.Drawing.Font("Tahoma", 10F);
            dgvToolR.Location = new System.Drawing.Point(785, 3);
            dgvToolR.Name = "dgvToolR";
            dgvToolR.ReadOnly = true;
            dgvToolR.RowHeadersVisible = false;
            dgvToolR.Size = new System.Drawing.Size(386, 474);
            dgvToolR.TabIndex = 2;
            // 
            // tabEnvironment
            // 
            tabEnvironment.Controls.Add(tableLayoutPanelEnvironment);
            tabEnvironment.Location = new System.Drawing.Point(4, 48);
            tabEnvironment.Name = "tabEnvironment";
            tabEnvironment.Padding = new System.Windows.Forms.Padding(3);
            tabEnvironment.Size = new System.Drawing.Size(1180, 486);
            tabEnvironment.TabIndex = 2;
            tabEnvironment.Text = "Environment";
            tabEnvironment.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelEnvironment
            // 
            tableLayoutPanelEnvironment.ColumnCount = 3;
            tableLayoutPanelEnvironment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            tableLayoutPanelEnvironment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            tableLayoutPanelEnvironment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            tableLayoutPanelEnvironment.Controls.Add(dgvEnvironmentL, 0, 0);
            tableLayoutPanelEnvironment.Controls.Add(dgvEnvironmentM, 1, 0);
            tableLayoutPanelEnvironment.Controls.Add(dgvEnvironmentR, 2, 0);
            tableLayoutPanelEnvironment.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanelEnvironment.Location = new System.Drawing.Point(3, 3);
            tableLayoutPanelEnvironment.Name = "tableLayoutPanelEnvironment";
            tableLayoutPanelEnvironment.RowCount = 1;
            tableLayoutPanelEnvironment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanelEnvironment.Size = new System.Drawing.Size(1174, 480);
            tableLayoutPanelEnvironment.TabIndex = 0;
            // 
            // dgvEnvironmentL
            // 
            dgvEnvironmentL.AllowUserToAddRows = false;
            dgvEnvironmentL.AllowUserToDeleteRows = false;
            dgvEnvironmentL.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dgvEnvironmentL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvEnvironmentL.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dgvEnvironmentL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEnvironmentL.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvEnvironmentL.Font = new System.Drawing.Font("Tahoma", 10F);
            dgvEnvironmentL.Location = new System.Drawing.Point(3, 3);
            dgvEnvironmentL.Name = "dgvEnvironmentL";
            dgvEnvironmentL.ReadOnly = true;
            dgvEnvironmentL.RowHeadersVisible = false;
            dgvEnvironmentL.Size = new System.Drawing.Size(385, 474);
            dgvEnvironmentL.TabIndex = 0;
            // 
            // dgvEnvironmentM
            // 
            dgvEnvironmentM.AllowUserToAddRows = false;
            dgvEnvironmentM.AllowUserToDeleteRows = false;
            dgvEnvironmentM.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dgvEnvironmentM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvEnvironmentM.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dgvEnvironmentM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEnvironmentM.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvEnvironmentM.Font = new System.Drawing.Font("Tahoma", 10F);
            dgvEnvironmentM.Location = new System.Drawing.Point(394, 3);
            dgvEnvironmentM.Name = "dgvEnvironmentM";
            dgvEnvironmentM.ReadOnly = true;
            dgvEnvironmentM.RowHeadersVisible = false;
            dgvEnvironmentM.Size = new System.Drawing.Size(385, 474);
            dgvEnvironmentM.TabIndex = 1;
            // 
            // dgvEnvironmentR
            // 
            dgvEnvironmentR.AllowUserToAddRows = false;
            dgvEnvironmentR.AllowUserToDeleteRows = false;
            dgvEnvironmentR.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dgvEnvironmentR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvEnvironmentR.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dgvEnvironmentR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEnvironmentR.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvEnvironmentR.Font = new System.Drawing.Font("Tahoma", 10F);
            dgvEnvironmentR.Location = new System.Drawing.Point(785, 3);
            dgvEnvironmentR.Name = "dgvEnvironmentR";
            dgvEnvironmentR.ReadOnly = true;
            dgvEnvironmentR.RowHeadersVisible = false;
            dgvEnvironmentR.Size = new System.Drawing.Size(386, 474);
            dgvEnvironmentR.TabIndex = 2;
            // 
            // tabSystem
            // 
            tabSystem.Controls.Add(dgvSystem);
            tabSystem.Location = new System.Drawing.Point(4, 48);
            tabSystem.Name = "tabSystem";
            tabSystem.Padding = new System.Windows.Forms.Padding(3);
            tabSystem.Size = new System.Drawing.Size(1180, 486);
            tabSystem.TabIndex = 3;
            tabSystem.Text = "System / GPS";
            tabSystem.UseVisualStyleBackColor = true;
            // 
            // dgvSystem
            // 
            dgvSystem.AllowUserToAddRows = false;
            dgvSystem.AllowUserToDeleteRows = false;
            dgvSystem.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dgvSystem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvSystem.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dgvSystem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSystem.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvSystem.Font = new System.Drawing.Font("Tahoma", 10F);
            dgvSystem.Location = new System.Drawing.Point(3, 3);
            dgvSystem.Name = "dgvSystem";
            dgvSystem.ReadOnly = true;
            dgvSystem.RowHeadersVisible = false;
            dgvSystem.Size = new System.Drawing.Size(1174, 480);
            dgvSystem.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.BackColor = System.Drawing.Color.Transparent;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClose.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            btnClose.ForeColor = System.Drawing.Color.White;
            btnClose.Image = Properties.Resources.Cancel64;
            btnClose.Location = new System.Drawing.Point(1112, 600);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(64, 64);
            btnClose.TabIndex = 4;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnExportCSV
            // 
            btnExportCSV.BackColor = System.Drawing.Color.Transparent;
            btnExportCSV.FlatAppearance.BorderSize = 0;
            btnExportCSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnExportCSV.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            btnExportCSV.ForeColor = System.Drawing.Color.DarkSlateGray;
            btnExportCSV.Location = new System.Drawing.Point(6, 599);
            btnExportCSV.Name = "btnExportCSV";
            btnExportCSV.Size = new System.Drawing.Size(80, 65);
            btnExportCSV.TabIndex = 5;
            btnExportCSV.Text = "CSV";
            btnExportCSV.UseVisualStyleBackColor = false;
            btnExportCSV.Click += btnExportCSV_Click;
            // 
            // btnScreenShot
            // 
            btnScreenShot.FlatAppearance.BorderSize = 0;
            btnScreenShot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnScreenShot.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnScreenShot.Image = Properties.Resources.ScreenShot;
            btnScreenShot.Location = new System.Drawing.Point(980, 599);
            btnScreenShot.Name = "btnScreenShot";
            btnScreenShot.Size = new System.Drawing.Size(80, 65);
            btnScreenShot.TabIndex = 2;
            btnScreenShot.UseVisualStyleBackColor = true;
            btnScreenShot.Click += btnScreenShot_Click;
            // 
            // btnCreatePNG
            // 
            btnCreatePNG.FlatAppearance.BorderSize = 0;
            btnCreatePNG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCreatePNG.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnCreatePNG.Image = Properties.Resources.Screen2PNG;
            btnCreatePNG.Location = new System.Drawing.Point(878, 599);
            btnCreatePNG.Name = "btnCreatePNG";
            btnCreatePNG.Size = new System.Drawing.Size(80, 65);
            btnCreatePNG.TabIndex = 3;
            btnCreatePNG.UseVisualStyleBackColor = true;
            btnCreatePNG.Click += btnCreatePNG_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // FormAllSettings
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            BackColor = System.Drawing.Color.Gainsboro;
            ClientSize = new System.Drawing.Size(1188, 671);
            ControlBox = false;
            Controls.Add(panelHeader);
            Controls.Add(tabControl);
            Controls.Add(btnClose);
            Controls.Add(btnExportCSV);
            Controls.Add(btnScreenShot);
            Controls.Add(btnCreatePNG);
            Font = new System.Drawing.Font("Tahoma", 9.75F);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Name = "FormAllSettings";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "All Settings";
            panelHeader.ResumeLayout(false);
            tabControl.ResumeLayout(false);
            tabVehicle.ResumeLayout(false);
            tableLayoutPanelVehicle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVehicleL).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvVehicleM).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvVehicleR).EndInit();
            tabTool.ResumeLayout(false);
            tableLayoutPanelTool.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvToolL).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvToolM).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvToolR).EndInit();
            tabEnvironment.ResumeLayout(false);
            tableLayoutPanelEnvironment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEnvironmentL).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEnvironmentM).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEnvironmentR).EndInit();
            tabSystem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSystem).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblVehicleName;
        private System.Windows.Forms.Label lblToolName;
        private System.Windows.Forms.Label lblEnvironmentName;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabVehicle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelVehicle;
        private System.Windows.Forms.DataGridView dgvVehicleL;
        private System.Windows.Forms.DataGridView dgvVehicleM;
        private System.Windows.Forms.DataGridView dgvVehicleR;
        private System.Windows.Forms.TabPage tabTool;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTool;
        private System.Windows.Forms.DataGridView dgvToolL;
        private System.Windows.Forms.DataGridView dgvToolM;
        private System.Windows.Forms.DataGridView dgvToolR;
        private System.Windows.Forms.TabPage tabEnvironment;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelEnvironment;
        private System.Windows.Forms.DataGridView dgvEnvironmentL;
        private System.Windows.Forms.DataGridView dgvEnvironmentM;
        private System.Windows.Forms.DataGridView dgvEnvironmentR;
        private System.Windows.Forms.TabPage tabSystem;
        private System.Windows.Forms.DataGridView dgvSystem;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnExportCSV;
        private System.Windows.Forms.Button btnScreenShot;
        private System.Windows.Forms.Button btnCreatePNG;
        private System.Windows.Forms.Timer timer1;
    }
}

namespace AgOpenGPS
{
    partial class FormQuickAB
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
            lblCurveExists = new System.Windows.Forms.Label();
            labelStatus = new System.Windows.Forms.Label();
            panelName = new System.Windows.Forms.Panel();
            labelAddName = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            btnAddTime = new System.Windows.Forms.Button();
            btnAdd = new System.Windows.Forms.Button();
            textBox1 = new System.Windows.Forms.TextBox();
            panelCurve = new System.Windows.Forms.Panel();
            labelCurve = new System.Windows.Forms.Label();
            btnRefSideCurve = new System.Windows.Forms.Button();
            btnCancel_Curve = new System.Windows.Forms.Button();
            btnACurve = new System.Windows.Forms.Button();
            btnBCurve = new System.Windows.Forms.Button();
            btnPausePlay = new System.Windows.Forms.Button();
            panelChoose = new System.Windows.Forms.Panel();
            btnCancelChoose = new System.Windows.Forms.Button();
            btnzAPlus = new System.Windows.Forms.Button();
            btnzABLine = new System.Windows.Forms.Button();
            btnzABCurve = new System.Windows.Forms.Button();
            panelABLine = new System.Windows.Forms.Panel();
            btnRefSideAB = new System.Windows.Forms.Button();
            labelABLine = new System.Windows.Forms.Label();
            btnCancel_ABLine = new System.Windows.Forms.Button();
            btnEnter_AB = new System.Windows.Forms.Button();
            btnALine = new System.Windows.Forms.Button();
            btnBLine = new System.Windows.Forms.Button();
            panelAPlus = new System.Windows.Forms.Panel();
            btnRefSideAPlus = new System.Windows.Forms.Button();
            labelAPlus = new System.Windows.Forms.Label();
            btnCancel_APlus = new System.Windows.Forms.Button();
            btnEnter_APlus = new System.Windows.Forms.Button();
            nudHeading = new NudlessNumericUpDown();
            btnAPlus = new System.Windows.Forms.Button();
            timer1 = new System.Windows.Forms.Timer(components);
            panelName.SuspendLayout();
            panelCurve.SuspendLayout();
            panelChoose.SuspendLayout();
            panelABLine.SuspendLayout();
            panelAPlus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudHeading).BeginInit();
            SuspendLayout();
            // 
            // lblCurveExists
            // 
            lblCurveExists.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lblCurveExists.AutoSize = true;
            lblCurveExists.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblCurveExists.ForeColor = System.Drawing.Color.Black;
            lblCurveExists.Location = new System.Drawing.Point(130, 225);
            lblCurveExists.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblCurveExists.Name = "lblCurveExists";
            lblCurveExists.Size = new System.Drawing.Size(91, 23);
            lblCurveExists.TabIndex = 87;
            lblCurveExists.Text = "> OFF <";
            lblCurveExists.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelStatus
            // 
            labelStatus.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            labelStatus.AutoSize = true;
            labelStatus.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelStatus.ForeColor = System.Drawing.Color.Black;
            labelStatus.Location = new System.Drawing.Point(42, 225);
            labelStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new System.Drawing.Size(84, 23);
            labelStatus.TabIndex = 148;
            labelStatus.Text = "Status: ";
            labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelName
            // 
            panelName.BackColor = System.Drawing.Color.WhiteSmoke;
            panelName.Controls.Add(labelAddName);
            panelName.Controls.Add(label1);
            panelName.Controls.Add(btnAddTime);
            panelName.Controls.Add(btnAdd);
            panelName.Controls.Add(textBox1);
            panelName.Location = new System.Drawing.Point(9, 388);
            panelName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panelName.Name = "panelName";
            panelName.Size = new System.Drawing.Size(281, 358);
            panelName.TabIndex = 434;
            // 
            // labelAddName
            // 
            labelAddName.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            labelAddName.AutoSize = true;
            labelAddName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelAddName.ForeColor = System.Drawing.Color.Black;
            labelAddName.Location = new System.Drawing.Point(19, 16);
            labelAddName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelAddName.Name = "labelAddName";
            labelAddName.Size = new System.Drawing.Size(66, 16);
            labelAddName.TabIndex = 450;
            labelAddName.Text = "Add Name";
            labelAddName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.Black;
            label1.Location = new System.Drawing.Point(56, 178);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(33, 29);
            label1.TabIndex = 424;
            label1.Text = "+";
            // 
            // btnAddTime
            // 
            btnAddTime.BackColor = System.Drawing.Color.Transparent;
            btnAddTime.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            btnAddTime.FlatAppearance.BorderSize = 0;
            btnAddTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAddTime.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnAddTime.Image = Properties.Resources.JobNameTime;
            btnAddTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnAddTime.Location = new System.Drawing.Point(102, 153);
            btnAddTime.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnAddTime.Name = "btnAddTime";
            btnAddTime.Size = new System.Drawing.Size(79, 80);
            btnAddTime.TabIndex = 150;
            btnAddTime.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnAddTime.UseVisualStyleBackColor = false;
            btnAddTime.Click += btnAddTime_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = System.Drawing.Color.Transparent;
            btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAdd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnAdd.Image = Properties.Resources.OK64;
            btnAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnAdd.Location = new System.Drawing.Point(164, 269);
            btnAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(103, 81);
            btnAdd.TabIndex = 150;
            btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = System.Drawing.Color.LightCyan;
            textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            textBox1.CausesValidation = false;
            textBox1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            textBox1.Location = new System.Drawing.Point(20, 43);
            textBox1.Margin = new System.Windows.Forms.Padding(0);
            textBox1.MaxLength = 100;
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(238, 89);
            textBox1.TabIndex = 145;
            textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            textBox1.Click += textBox_Click;
            // 
            // panelCurve
            // 
            panelCurve.BackColor = System.Drawing.Color.WhiteSmoke;
            panelCurve.Controls.Add(labelCurve);
            panelCurve.Controls.Add(btnRefSideCurve);
            panelCurve.Controls.Add(btnCancel_Curve);
            panelCurve.Controls.Add(btnACurve);
            panelCurve.Controls.Add(btnBCurve);
            panelCurve.Controls.Add(btnPausePlay);
            panelCurve.Controls.Add(lblCurveExists);
            panelCurve.Controls.Add(labelStatus);
            panelCurve.Location = new System.Drawing.Point(298, 388);
            panelCurve.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panelCurve.Name = "panelCurve";
            panelCurve.Size = new System.Drawing.Size(281, 358);
            panelCurve.TabIndex = 436;
            // 
            // labelCurve
            // 
            labelCurve.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            labelCurve.AutoSize = true;
            labelCurve.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelCurve.ForeColor = System.Drawing.Color.Black;
            labelCurve.Location = new System.Drawing.Point(5, 5);
            labelCurve.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelCurve.Name = "labelCurve";
            labelCurve.Size = new System.Drawing.Size(40, 16);
            labelCurve.TabIndex = 449;
            labelCurve.Text = "Curve";
            labelCurve.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRefSideCurve
            // 
            btnRefSideCurve.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnRefSideCurve.BackColor = System.Drawing.Color.Transparent;
            btnRefSideCurve.FlatAppearance.BorderSize = 0;
            btnRefSideCurve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRefSideCurve.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnRefSideCurve.Image = Properties.Resources.BoundaryRight;
            btnRefSideCurve.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnRefSideCurve.Location = new System.Drawing.Point(103, 2);
            btnRefSideCurve.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnRefSideCurve.Name = "btnRefSideCurve";
            btnRefSideCurve.Size = new System.Drawing.Size(82, 69);
            btnRefSideCurve.TabIndex = 426;
            btnRefSideCurve.UseVisualStyleBackColor = false;
            btnRefSideCurve.Click += btnRefSideCurve_Click;
            // 
            // btnCancel_Curve
            // 
            btnCancel_Curve.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnCancel_Curve.BackColor = System.Drawing.Color.Transparent;
            btnCancel_Curve.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnCancel_Curve.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancel_Curve.FlatAppearance.BorderSize = 0;
            btnCancel_Curve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancel_Curve.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnCancel_Curve.Image = Properties.Resources.Cancel64;
            btnCancel_Curve.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnCancel_Curve.Location = new System.Drawing.Point(8, 269);
            btnCancel_Curve.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCancel_Curve.Name = "btnCancel_Curve";
            btnCancel_Curve.Size = new System.Drawing.Size(103, 81);
            btnCancel_Curve.TabIndex = 423;
            btnCancel_Curve.UseVisualStyleBackColor = false;
            btnCancel_Curve.Click += btnCancelCurve_Click;
            // 
            // btnACurve
            // 
            btnACurve.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnACurve.BackColor = System.Drawing.Color.Transparent;
            btnACurve.FlatAppearance.BorderSize = 0;
            btnACurve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnACurve.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnACurve.Image = Properties.Resources.LetterABlue;
            btnACurve.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnACurve.Location = new System.Drawing.Point(8, 112);
            btnACurve.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnACurve.Name = "btnACurve";
            btnACurve.Size = new System.Drawing.Size(103, 81);
            btnACurve.TabIndex = 63;
            btnACurve.UseVisualStyleBackColor = false;
            btnACurve.Click += btnACurve_Click;
            // 
            // btnBCurve
            // 
            btnBCurve.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnBCurve.BackColor = System.Drawing.Color.Transparent;
            btnBCurve.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnBCurve.FlatAppearance.BorderSize = 0;
            btnBCurve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBCurve.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnBCurve.Image = Properties.Resources.OK64;
            btnBCurve.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnBCurve.Location = new System.Drawing.Point(168, 269);
            btnBCurve.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnBCurve.Name = "btnBCurve";
            btnBCurve.Size = new System.Drawing.Size(103, 81);
            btnBCurve.TabIndex = 64;
            btnBCurve.UseVisualStyleBackColor = false;
            btnBCurve.Click += btnBCurve_Click;
            // 
            // btnPausePlay
            // 
            btnPausePlay.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnPausePlay.BackColor = System.Drawing.Color.Transparent;
            btnPausePlay.Enabled = false;
            btnPausePlay.FlatAppearance.BorderSize = 0;
            btnPausePlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPausePlay.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnPausePlay.Image = Properties.Resources.boundaryPause;
            btnPausePlay.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnPausePlay.Location = new System.Drawing.Point(168, 112);
            btnPausePlay.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnPausePlay.Name = "btnPausePlay";
            btnPausePlay.Size = new System.Drawing.Size(103, 81);
            btnPausePlay.TabIndex = 140;
            btnPausePlay.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnPausePlay.UseVisualStyleBackColor = false;
            btnPausePlay.Click += btnPausePlayCurve_Click;
            // 
            // panelChoose
            // 
            panelChoose.BackColor = System.Drawing.Color.Gainsboro;
            panelChoose.Controls.Add(btnCancelChoose);
            panelChoose.Controls.Add(btnzAPlus);
            panelChoose.Controls.Add(btnzABLine);
            panelChoose.Controls.Add(btnzABCurve);
            panelChoose.Location = new System.Drawing.Point(76, 6);
            panelChoose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panelChoose.Name = "panelChoose";
            panelChoose.Size = new System.Drawing.Size(281, 358);
            panelChoose.TabIndex = 441;
            // 
            // btnCancelChoose
            // 
            btnCancelChoose.BackColor = System.Drawing.Color.Transparent;
            btnCancelChoose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnCancelChoose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancelChoose.FlatAppearance.BorderSize = 0;
            btnCancelChoose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancelChoose.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnCancelChoose.Image = Properties.Resources.Cancel64;
            btnCancelChoose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnCancelChoose.Location = new System.Drawing.Point(14, 257);
            btnCancelChoose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCancelChoose.Name = "btnCancelChoose";
            btnCancelChoose.Size = new System.Drawing.Size(76, 81);
            btnCancelChoose.TabIndex = 423;
            btnCancelChoose.UseVisualStyleBackColor = false;
            btnCancelChoose.Click += btnCancelCurve_Click;
            // 
            // btnzAPlus
            // 
            btnzAPlus.BackColor = System.Drawing.Color.White;
            btnzAPlus.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            btnzAPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnzAPlus.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnzAPlus.Image = Properties.Resources.ABTrackA_;
            btnzAPlus.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnzAPlus.Location = new System.Drawing.Point(10, 33);
            btnzAPlus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnzAPlus.Name = "btnzAPlus";
            btnzAPlus.Size = new System.Drawing.Size(112, 113);
            btnzAPlus.TabIndex = 444;
            btnzAPlus.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnzAPlus.UseVisualStyleBackColor = false;
            btnzAPlus.Click += btnzAPlus_Click;
            // 
            // btnzABLine
            // 
            btnzABLine.BackColor = System.Drawing.Color.White;
            btnzABLine.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            btnzABLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnzABLine.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnzABLine.Image = Properties.Resources.ABTrackAB;
            btnzABLine.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnzABLine.Location = new System.Drawing.Point(161, 33);
            btnzABLine.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnzABLine.Name = "btnzABLine";
            btnzABLine.Size = new System.Drawing.Size(112, 113);
            btnzABLine.TabIndex = 444;
            btnzABLine.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnzABLine.UseVisualStyleBackColor = false;
            btnzABLine.Click += btnzABLine_Click;
            // 
            // btnzABCurve
            // 
            btnzABCurve.BackColor = System.Drawing.Color.White;
            btnzABCurve.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            btnzABCurve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnzABCurve.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnzABCurve.Image = Properties.Resources.ABTrackCurve;
            btnzABCurve.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnzABCurve.Location = new System.Drawing.Point(161, 225);
            btnzABCurve.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnzABCurve.Name = "btnzABCurve";
            btnzABCurve.Size = new System.Drawing.Size(112, 113);
            btnzABCurve.TabIndex = 443;
            btnzABCurve.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnzABCurve.UseVisualStyleBackColor = false;
            btnzABCurve.Click += btnzABCurve_Click;
            // 
            // panelABLine
            // 
            panelABLine.BackColor = System.Drawing.Color.Transparent;
            panelABLine.Controls.Add(btnRefSideAB);
            panelABLine.Controls.Add(labelABLine);
            panelABLine.Controls.Add(btnCancel_ABLine);
            panelABLine.Controls.Add(btnEnter_AB);
            panelABLine.Controls.Add(btnALine);
            panelABLine.Controls.Add(btnBLine);
            panelABLine.Location = new System.Drawing.Point(587, 388);
            panelABLine.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panelABLine.Name = "panelABLine";
            panelABLine.Size = new System.Drawing.Size(281, 358);
            panelABLine.TabIndex = 442;
            // 
            // btnRefSideAB
            // 
            btnRefSideAB.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnRefSideAB.BackColor = System.Drawing.Color.Transparent;
            btnRefSideAB.FlatAppearance.BorderSize = 0;
            btnRefSideAB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRefSideAB.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnRefSideAB.Image = Properties.Resources.BoundaryRight;
            btnRefSideAB.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnRefSideAB.Location = new System.Drawing.Point(105, 3);
            btnRefSideAB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnRefSideAB.Name = "btnRefSideAB";
            btnRefSideAB.Size = new System.Drawing.Size(82, 69);
            btnRefSideAB.TabIndex = 427;
            btnRefSideAB.UseVisualStyleBackColor = false;
            btnRefSideAB.Click += btnRefSideAB_Click;
            // 
            // labelABLine
            // 
            labelABLine.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            labelABLine.AutoSize = true;
            labelABLine.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelABLine.ForeColor = System.Drawing.Color.Black;
            labelABLine.Location = new System.Drawing.Point(6, 5);
            labelABLine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelABLine.Name = "labelABLine";
            labelABLine.Size = new System.Drawing.Size(49, 16);
            labelABLine.TabIndex = 447;
            labelABLine.Text = "AB Line";
            labelABLine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancel_ABLine
            // 
            btnCancel_ABLine.BackColor = System.Drawing.Color.Transparent;
            btnCancel_ABLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnCancel_ABLine.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancel_ABLine.FlatAppearance.BorderSize = 0;
            btnCancel_ABLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancel_ABLine.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnCancel_ABLine.Image = Properties.Resources.Cancel64;
            btnCancel_ABLine.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnCancel_ABLine.Location = new System.Drawing.Point(9, 269);
            btnCancel_ABLine.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCancel_ABLine.Name = "btnCancel_ABLine";
            btnCancel_ABLine.Size = new System.Drawing.Size(103, 81);
            btnCancel_ABLine.TabIndex = 428;
            btnCancel_ABLine.UseVisualStyleBackColor = false;
            btnCancel_ABLine.Click += btnCancelCurve_Click;
            // 
            // btnEnter_AB
            // 
            btnEnter_AB.BackColor = System.Drawing.Color.Transparent;
            btnEnter_AB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnEnter_AB.DialogResult = System.Windows.Forms.DialogResult.Yes;
            btnEnter_AB.FlatAppearance.BorderSize = 0;
            btnEnter_AB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEnter_AB.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnEnter_AB.Image = Properties.Resources.OK64;
            btnEnter_AB.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnEnter_AB.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnEnter_AB.Location = new System.Drawing.Point(166, 269);
            btnEnter_AB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnEnter_AB.Name = "btnEnter_AB";
            btnEnter_AB.Size = new System.Drawing.Size(103, 81);
            btnEnter_AB.TabIndex = 427;
            btnEnter_AB.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            btnEnter_AB.UseVisualStyleBackColor = false;
            btnEnter_AB.Click += btnEnter_AB_Click;
            // 
            // btnALine
            // 
            btnALine.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnALine.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            btnALine.FlatAppearance.BorderSize = 0;
            btnALine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnALine.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnALine.Image = Properties.Resources.LetterABlue;
            btnALine.Location = new System.Drawing.Point(15, 119);
            btnALine.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            btnALine.Name = "btnALine";
            btnALine.Size = new System.Drawing.Size(93, 90);
            btnALine.TabIndex = 57;
            btnALine.UseVisualStyleBackColor = true;
            btnALine.Click += btnALine_Click;
            // 
            // btnBLine
            // 
            btnBLine.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnBLine.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            btnBLine.FlatAppearance.BorderSize = 0;
            btnBLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBLine.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnBLine.Image = Properties.Resources.LetterBBlue;
            btnBLine.Location = new System.Drawing.Point(182, 119);
            btnBLine.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            btnBLine.Name = "btnBLine";
            btnBLine.Size = new System.Drawing.Size(93, 90);
            btnBLine.TabIndex = 58;
            btnBLine.UseVisualStyleBackColor = true;
            btnBLine.Click += btnBLine_Click;
            // 
            // panelAPlus
            // 
            panelAPlus.BackColor = System.Drawing.Color.Transparent;
            panelAPlus.Controls.Add(btnRefSideAPlus);
            panelAPlus.Controls.Add(labelAPlus);
            panelAPlus.Controls.Add(btnCancel_APlus);
            panelAPlus.Controls.Add(btnEnter_APlus);
            panelAPlus.Controls.Add(nudHeading);
            panelAPlus.Controls.Add(btnAPlus);
            panelAPlus.Location = new System.Drawing.Point(410, 6);
            panelAPlus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panelAPlus.Name = "panelAPlus";
            panelAPlus.Size = new System.Drawing.Size(281, 358);
            panelAPlus.TabIndex = 448;
            // 
            // btnRefSideAPlus
            // 
            btnRefSideAPlus.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnRefSideAPlus.BackColor = System.Drawing.Color.Transparent;
            btnRefSideAPlus.FlatAppearance.BorderSize = 0;
            btnRefSideAPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRefSideAPlus.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnRefSideAPlus.Image = Properties.Resources.BoundaryRight;
            btnRefSideAPlus.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnRefSideAPlus.Location = new System.Drawing.Point(30, 72);
            btnRefSideAPlus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnRefSideAPlus.Name = "btnRefSideAPlus";
            btnRefSideAPlus.Size = new System.Drawing.Size(82, 69);
            btnRefSideAPlus.TabIndex = 448;
            btnRefSideAPlus.UseVisualStyleBackColor = false;
            btnRefSideAPlus.Click += btnRefSideAPlus_Click;
            // 
            // labelAPlus
            // 
            labelAPlus.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            labelAPlus.AutoSize = true;
            labelAPlus.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelAPlus.ForeColor = System.Drawing.Color.Black;
            labelAPlus.Location = new System.Drawing.Point(7, 5);
            labelAPlus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelAPlus.Name = "labelAPlus";
            labelAPlus.Size = new System.Drawing.Size(23, 16);
            labelAPlus.TabIndex = 447;
            labelAPlus.Text = "A+";
            labelAPlus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancel_APlus
            // 
            btnCancel_APlus.BackColor = System.Drawing.Color.Transparent;
            btnCancel_APlus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnCancel_APlus.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancel_APlus.FlatAppearance.BorderSize = 0;
            btnCancel_APlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancel_APlus.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnCancel_APlus.Image = Properties.Resources.Cancel64;
            btnCancel_APlus.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnCancel_APlus.Location = new System.Drawing.Point(9, 275);
            btnCancel_APlus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCancel_APlus.Name = "btnCancel_APlus";
            btnCancel_APlus.Size = new System.Drawing.Size(103, 81);
            btnCancel_APlus.TabIndex = 428;
            btnCancel_APlus.UseVisualStyleBackColor = false;
            btnCancel_APlus.Click += btnCancelCurve_Click;
            // 
            // btnEnter_APlus
            // 
            btnEnter_APlus.BackColor = System.Drawing.Color.Transparent;
            btnEnter_APlus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnEnter_APlus.DialogResult = System.Windows.Forms.DialogResult.Yes;
            btnEnter_APlus.FlatAppearance.BorderSize = 0;
            btnEnter_APlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEnter_APlus.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnEnter_APlus.Image = Properties.Resources.OK64;
            btnEnter_APlus.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnEnter_APlus.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnEnter_APlus.Location = new System.Drawing.Point(166, 275);
            btnEnter_APlus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnEnter_APlus.Name = "btnEnter_APlus";
            btnEnter_APlus.Size = new System.Drawing.Size(103, 81);
            btnEnter_APlus.TabIndex = 427;
            btnEnter_APlus.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            btnEnter_APlus.UseVisualStyleBackColor = false;
            btnEnter_APlus.Click += btnEnter_APlus_Click;
            // 
            // nudHeading
            // 
            nudHeading.BackColor = System.Drawing.Color.LightCyan;
            nudHeading.DecimalPlaces = 4;
            nudHeading.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            nudHeading.InterceptArrowKeys = false;
            nudHeading.Location = new System.Drawing.Point(29, 201);
            nudHeading.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            nudHeading.Maximum = new decimal(new int[] { 360, 0, 0, 0 });
            nudHeading.Name = "nudHeading";
            nudHeading.ReadOnly = true;
            nudHeading.RightToLeft = System.Windows.Forms.RightToLeft.No;
            nudHeading.Size = new System.Drawing.Size(227, 46);
            nudHeading.TabIndex = 413;
            nudHeading.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudHeading.Value = new decimal(new int[] { 0, 0, 0, 0 });
            nudHeading.Click += nudHeading_Click;
            // 
            // btnAPlus
            // 
            btnAPlus.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnAPlus.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            btnAPlus.FlatAppearance.BorderSize = 0;
            btnAPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAPlus.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnAPlus.Image = Properties.Resources.LetterABlue;
            btnAPlus.Location = new System.Drawing.Point(163, 61);
            btnAPlus.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            btnAPlus.Name = "btnAPlus";
            btnAPlus.Size = new System.Drawing.Size(93, 90);
            btnAPlus.TabIndex = 57;
            btnAPlus.UseVisualStyleBackColor = true;
            btnAPlus.Click += btnAPlus_Click;
            // 
            // timer1
            // 
            timer1.Interval = 500;
            timer1.Tick += timer1_Tick;
            // 
            // FormQuickAB
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.WhiteSmoke;
            ClientSize = new System.Drawing.Size(890, 755);
            ControlBox = false;
            Controls.Add(panelAPlus);
            Controls.Add(panelABLine);
            Controls.Add(panelChoose);
            Controls.Add(panelCurve);
            Controls.Add(panelName);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormQuickAB";
            Padding = new System.Windows.Forms.Padding(2);
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Tracks";
            FormClosing += FormQuickAB_FormClosing;
            Load += FormQuickAB_Load;
            panelName.ResumeLayout(false);
            panelName.PerformLayout();
            panelCurve.ResumeLayout(false);
            panelCurve.PerformLayout();
            panelChoose.ResumeLayout(false);
            panelABLine.ResumeLayout(false);
            panelABLine.PerformLayout();
            panelAPlus.ResumeLayout(false);
            panelAPlus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudHeading).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBCurve;
        private System.Windows.Forms.Button btnACurve;
        private System.Windows.Forms.Label lblCurveExists;
        private System.Windows.Forms.Button btnPausePlay;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Button btnCancel_Curve;
        private System.Windows.Forms.Panel panelName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddTime;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panelCurve;
        private System.Windows.Forms.Panel panelChoose;
        private System.Windows.Forms.Button btnCancelChoose;
        private System.Windows.Forms.Button btnzABLine;
        private System.Windows.Forms.Button btnzABCurve;
        private System.Windows.Forms.Button btnzAPlus;
        private System.Windows.Forms.Label labelAddName;
        private System.Windows.Forms.Panel panelABLine;
        private System.Windows.Forms.Label labelABLine;
        private System.Windows.Forms.Button btnCancel_ABLine;
        private System.Windows.Forms.Button btnEnter_AB;
        private System.Windows.Forms.Button btnALine;
        private System.Windows.Forms.Button btnBLine;
        private NudlessNumericUpDown nudHeading;
        private System.Windows.Forms.Panel panelAPlus;
        private System.Windows.Forms.Label labelAPlus;
        private System.Windows.Forms.Button btnCancel_APlus;
        private System.Windows.Forms.Button btnEnter_APlus;
        private System.Windows.Forms.Button btnAPlus;
        private System.Windows.Forms.Button btnRefSideCurve;
        private System.Windows.Forms.Button btnRefSideAB;
        private System.Windows.Forms.Button btnRefSideAPlus;
        private System.Windows.Forms.Label labelCurve;
        private System.Windows.Forms.Timer timer1;
    }
}

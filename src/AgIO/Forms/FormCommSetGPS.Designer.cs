namespace AgIO
{
    partial class FormCommSetGPS
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
            timer1 = new System.Windows.Forms.Timer(components);
            groupBox1 = new System.Windows.Forms.GroupBox();
            label3 = new System.Windows.Forms.Label();
            btnCloseRTCM = new System.Windows.Forms.Button();
            btnOpenRTCM = new System.Windows.Forms.Button();
            labelDifferentRtcmPort = new System.Windows.Forms.Label();
            cboxRtcmPort = new System.Windows.Forms.ComboBox();
            cboxRtcmBaud = new System.Windows.Forms.ComboBox();
            labelRtcmPort = new System.Windows.Forms.Label();
            labelRtcmBaud = new System.Windows.Forms.Label();
            cboxPort = new System.Windows.Forms.ComboBox();
            cboxBaud = new System.Windows.Forms.ComboBox();
            lblCurrentPort = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            pictureBox4 = new System.Windows.Forms.PictureBox();
            lblCurrentBaud = new System.Windows.Forms.Label();
            btnCloseSerial = new System.Windows.Forms.Button();
            textBoxRcv = new System.Windows.Forms.TextBox();
            btnOpenSerial = new System.Windows.Forms.Button();
            groupBox2 = new System.Windows.Forms.GroupBox();
            cboxPort2 = new System.Windows.Forms.ComboBox();
            cboxBaud2 = new System.Windows.Forms.ComboBox();
            lblCurrentPort2 = new System.Windows.Forms.Label();
            lblCurrentBaud2 = new System.Windows.Forms.Label();
            btnCloseSerial2 = new System.Windows.Forms.Button();
            textBoxRcv2 = new System.Windows.Forms.TextBox();
            btnOpenSerial2 = new System.Windows.Forms.Button();
            groupBox3 = new System.Windows.Forms.GroupBox();
            cboxSteerModulePort = new System.Windows.Forms.ComboBox();
            lblCurrentSteerModulePort = new System.Windows.Forms.Label();
            btnOpenSerialSteerModule = new System.Windows.Forms.Button();
            btnCloseSerialSteerModule = new System.Windows.Forms.Button();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            groupBox4 = new System.Windows.Forms.GroupBox();
            cboxMachineModulePort = new System.Windows.Forms.ComboBox();
            lblCurrentMachineModulePort = new System.Windows.Forms.Label();
            btnOpenSerialMachineModule = new System.Windows.Forms.Button();
            btnCloseSerialMachineModule = new System.Windows.Forms.Button();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            groupBox5 = new System.Windows.Forms.GroupBox();
            lblCurrentModule3Port = new System.Windows.Forms.Label();
            cboxModule3Port = new System.Windows.Forms.ComboBox();
            btnOpenSerialModule3 = new System.Windows.Forms.Button();
            btnCloseSerialModule3 = new System.Windows.Forms.Button();
            groupBox6 = new System.Windows.Forms.GroupBox();
            lblCurrentIMU = new System.Windows.Forms.Label();
            cboxIMU = new System.Windows.Forms.ComboBox();
            btnCloseIMU = new System.Windows.Forms.Button();
            btnOpenIMU = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            btnRescan = new System.Windows.Forms.Button();
            btnSerialOK = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            lblIMU = new System.Windows.Forms.Label();
            lblSteer = new System.Windows.Forms.Label();
            lblMachine = new System.Windows.Forms.Label();
            lblGPS = new System.Windows.Forms.Label();
            lblFromGPS = new System.Windows.Forms.Label();
            lblFromMU = new System.Windows.Forms.Label();
            lblFromSteerModule = new System.Windows.Forms.Label();
            lblFromMachineModule = new System.Windows.Forms.Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 500;
            timer1.Tick += timer1_Tick;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            groupBox1.BackColor = System.Drawing.Color.Transparent;
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnCloseRTCM);
            groupBox1.Controls.Add(btnOpenRTCM);
            groupBox1.Controls.Add(labelDifferentRtcmPort);
            groupBox1.Controls.Add(cboxRtcmPort);
            groupBox1.Controls.Add(cboxRtcmBaud);
            groupBox1.Controls.Add(labelRtcmPort);
            groupBox1.Controls.Add(labelRtcmBaud);
            groupBox1.Controls.Add(cboxPort);
            groupBox1.Controls.Add(cboxBaud);
            groupBox1.Controls.Add(lblCurrentPort);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(pictureBox4);
            groupBox1.Controls.Add(lblCurrentBaud);
            groupBox1.Controls.Add(btnCloseSerial);
            groupBox1.Controls.Add(textBoxRcv);
            groupBox1.Controls.Add(btnOpenSerial);
            groupBox1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            groupBox1.Location = new System.Drawing.Point(43, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(759, 247);
            groupBox1.TabIndex = 64;
            groupBox1.TabStop = false;
            groupBox1.Text = "GPS";
            groupBox1.Paint += groupBox1_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(154, 130);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(82, 29);
            label3.TabIndex = 97;
            label3.Text = "RTCM";
            // 
            // btnCloseRTCM
            // 
            btnCloseRTCM.BackColor = System.Drawing.Color.Transparent;
            btnCloseRTCM.FlatAppearance.BorderSize = 0;
            btnCloseRTCM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCloseRTCM.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnCloseRTCM.Image = Properties.Resources.USB_Disconnect;
            btnCloseRTCM.Location = new System.Drawing.Point(673, 112);
            btnCloseRTCM.Name = "btnCloseRTCM";
            btnCloseRTCM.Size = new System.Drawing.Size(56, 58);
            btnCloseRTCM.TabIndex = 95;
            btnCloseRTCM.UseVisualStyleBackColor = false;
            btnCloseRTCM.Click += btnCloseRTCM_Click;
            // 
            // btnOpenRTCM
            // 
            btnOpenRTCM.BackColor = System.Drawing.Color.Transparent;
            btnOpenRTCM.FlatAppearance.BorderSize = 0;
            btnOpenRTCM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnOpenRTCM.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnOpenRTCM.Image = Properties.Resources.USB_Connect;
            btnOpenRTCM.Location = new System.Drawing.Point(572, 112);
            btnOpenRTCM.Name = "btnOpenRTCM";
            btnOpenRTCM.Size = new System.Drawing.Size(58, 58);
            btnOpenRTCM.TabIndex = 96;
            btnOpenRTCM.UseVisualStyleBackColor = false;
            btnOpenRTCM.Click += btnOpenRTCM_Click;
            // 
            // labelDifferentRtcmPort
            // 
            labelDifferentRtcmPort.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelDifferentRtcmPort.Location = new System.Drawing.Point(22, 127);
            labelDifferentRtcmPort.Name = "labelDifferentRtcmPort";
            labelDifferentRtcmPort.Size = new System.Drawing.Size(128, 43);
            labelDifferentRtcmPort.TabIndex = 94;
            labelDifferentRtcmPort.Text = "Different Port Then GPS ?";
            labelDifferentRtcmPort.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboxRtcmPort
            // 
            cboxRtcmPort.BackColor = System.Drawing.SystemColors.ControlLightLight;
            cboxRtcmPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboxRtcmPort.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            cboxRtcmPort.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            cboxRtcmPort.FormattingEnabled = true;
            cboxRtcmPort.Location = new System.Drawing.Point(244, 127);
            cboxRtcmPort.Name = "cboxRtcmPort";
            cboxRtcmPort.Size = new System.Drawing.Size(124, 37);
            cboxRtcmPort.TabIndex = 54;
            cboxRtcmPort.SelectedIndexChanged += cboxRtcmPort_SelectedIndexChanged;
            // 
            // cboxRtcmBaud
            // 
            cboxRtcmBaud.BackColor = System.Drawing.SystemColors.ControlLightLight;
            cboxRtcmBaud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboxRtcmBaud.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            cboxRtcmBaud.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            cboxRtcmBaud.FormattingEnabled = true;
            cboxRtcmBaud.Items.AddRange(new object[] { "4800", "9600", "19200", "38400", "57600", "115200", "128000", "256000" });
            cboxRtcmBaud.Location = new System.Drawing.Point(395, 127);
            cboxRtcmBaud.Name = "cboxRtcmBaud";
            cboxRtcmBaud.Size = new System.Drawing.Size(127, 37);
            cboxRtcmBaud.TabIndex = 53;
            cboxRtcmBaud.SelectedIndexChanged += cboxRtcmBaud_SelectedIndexChanged;
            // 
            // labelRtcmPort
            // 
            labelRtcmPort.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelRtcmPort.Location = new System.Drawing.Point(244, 106);
            labelRtcmPort.Name = "labelRtcmPort";
            labelRtcmPort.Size = new System.Drawing.Size(121, 18);
            labelRtcmPort.TabIndex = 52;
            labelRtcmPort.Text = "RTCM Port";
            labelRtcmPort.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRtcmBaud
            // 
            labelRtcmBaud.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelRtcmBaud.Location = new System.Drawing.Point(395, 106);
            labelRtcmBaud.Name = "labelRtcmBaud";
            labelRtcmBaud.Size = new System.Drawing.Size(124, 18);
            labelRtcmBaud.TabIndex = 51;
            labelRtcmBaud.Text = "RTCM Baud";
            labelRtcmBaud.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboxPort
            // 
            cboxPort.BackColor = System.Drawing.SystemColors.ControlLightLight;
            cboxPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboxPort.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            cboxPort.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            cboxPort.FormattingEnabled = true;
            cboxPort.Location = new System.Drawing.Point(244, 37);
            cboxPort.Name = "cboxPort";
            cboxPort.Size = new System.Drawing.Size(124, 37);
            cboxPort.TabIndex = 50;
            cboxPort.SelectedIndexChanged += cboxPort_SelectedIndexChanged_1;
            // 
            // cboxBaud
            // 
            cboxBaud.BackColor = System.Drawing.SystemColors.ControlLightLight;
            cboxBaud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboxBaud.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            cboxBaud.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            cboxBaud.FormattingEnabled = true;
            cboxBaud.Items.AddRange(new object[] { "4800", "9600", "19200", "38400", "57600", "115200", "460800" });
            cboxBaud.Location = new System.Drawing.Point(395, 37);
            cboxBaud.Name = "cboxBaud";
            cboxBaud.Size = new System.Drawing.Size(127, 37);
            cboxBaud.TabIndex = 49;
            cboxBaud.SelectedIndexChanged += cboxBaud_SelectedIndexChanged_1;
            // 
            // lblCurrentPort
            // 
            lblCurrentPort.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblCurrentPort.Location = new System.Drawing.Point(244, 16);
            lblCurrentPort.Name = "lblCurrentPort";
            lblCurrentPort.Size = new System.Drawing.Size(121, 18);
            lblCurrentPort.TabIndex = 47;
            lblCurrentPort.Text = "GPS Port";
            lblCurrentPort.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(174, 39);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(62, 29);
            label2.TabIndex = 74;
            label2.Text = "GPS";
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = Properties.Resources.satellite;
            pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pictureBox4.Location = new System.Drawing.Point(12, 23);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new System.Drawing.Size(84, 92);
            pictureBox4.TabIndex = 72;
            pictureBox4.TabStop = false;
            // 
            // lblCurrentBaud
            // 
            lblCurrentBaud.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblCurrentBaud.Location = new System.Drawing.Point(395, 16);
            lblCurrentBaud.Name = "lblCurrentBaud";
            lblCurrentBaud.Size = new System.Drawing.Size(124, 18);
            lblCurrentBaud.TabIndex = 46;
            lblCurrentBaud.Text = "GPS Baud";
            lblCurrentBaud.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCloseSerial
            // 
            btnCloseSerial.BackColor = System.Drawing.Color.Transparent;
            btnCloseSerial.FlatAppearance.BorderSize = 0;
            btnCloseSerial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCloseSerial.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnCloseSerial.Image = Properties.Resources.USB_Disconnect;
            btnCloseSerial.Location = new System.Drawing.Point(673, 23);
            btnCloseSerial.Name = "btnCloseSerial";
            btnCloseSerial.Size = new System.Drawing.Size(56, 58);
            btnCloseSerial.TabIndex = 44;
            btnCloseSerial.UseVisualStyleBackColor = false;
            btnCloseSerial.Click += btnCloseSerial_Click;
            // 
            // textBoxRcv
            // 
            textBoxRcv.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            textBoxRcv.BackColor = System.Drawing.Color.Gainsboro;
            textBoxRcv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBoxRcv.Font = new System.Drawing.Font("Tahoma", 9.75F);
            textBoxRcv.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            textBoxRcv.Location = new System.Drawing.Point(122, 178);
            textBoxRcv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            textBoxRcv.Multiline = true;
            textBoxRcv.Name = "textBoxRcv";
            textBoxRcv.ReadOnly = true;
            textBoxRcv.Size = new System.Drawing.Size(607, 53);
            textBoxRcv.TabIndex = 40;
            textBoxRcv.Text = "GPS";
            // 
            // btnOpenSerial
            // 
            btnOpenSerial.BackColor = System.Drawing.Color.Transparent;
            btnOpenSerial.FlatAppearance.BorderSize = 0;
            btnOpenSerial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnOpenSerial.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnOpenSerial.Image = Properties.Resources.USB_Connect;
            btnOpenSerial.Location = new System.Drawing.Point(572, 23);
            btnOpenSerial.Name = "btnOpenSerial";
            btnOpenSerial.Size = new System.Drawing.Size(58, 58);
            btnOpenSerial.TabIndex = 45;
            btnOpenSerial.UseVisualStyleBackColor = false;
            btnOpenSerial.Click += btnOpenSerial_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = System.Drawing.SystemColors.Control;
            groupBox2.Controls.Add(cboxPort2);
            groupBox2.Controls.Add(cboxBaud2);
            groupBox2.Controls.Add(lblCurrentPort2);
            groupBox2.Controls.Add(lblCurrentBaud2);
            groupBox2.Controls.Add(btnCloseSerial2);
            groupBox2.Controls.Add(textBoxRcv2);
            groupBox2.Controls.Add(btnOpenSerial2);
            groupBox2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            groupBox2.Location = new System.Drawing.Point(1118, 46);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(401, 120);
            groupBox2.TabIndex = 65;
            groupBox2.TabStop = false;
            groupBox2.Text = "GPS Port 2";
            // 
            // cboxPort2
            // 
            cboxPort2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            cboxPort2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboxPort2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            cboxPort2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            cboxPort2.FormattingEnabled = true;
            cboxPort2.Location = new System.Drawing.Point(10, 37);
            cboxPort2.Name = "cboxPort2";
            cboxPort2.Size = new System.Drawing.Size(169, 37);
            cboxPort2.TabIndex = 50;
            cboxPort2.SelectedIndexChanged += cboxPort2_SelectedIndexChanged;
            // 
            // cboxBaud2
            // 
            cboxBaud2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            cboxBaud2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboxBaud2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            cboxBaud2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            cboxBaud2.FormattingEnabled = true;
            cboxBaud2.Items.AddRange(new object[] { "4800", "9600", "19200", "38400", "57600", "115200", "460800" });
            cboxBaud2.Location = new System.Drawing.Point(198, 37);
            cboxBaud2.Name = "cboxBaud2";
            cboxBaud2.Size = new System.Drawing.Size(127, 37);
            cboxBaud2.TabIndex = 49;
            cboxBaud2.SelectedIndexChanged += cboxBaud2_SelectedIndexChanged;
            // 
            // lblCurrentPort2
            // 
            lblCurrentPort2.AutoSize = true;
            lblCurrentPort2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblCurrentPort2.Location = new System.Drawing.Point(139, 16);
            lblCurrentPort2.Name = "lblCurrentPort2";
            lblCurrentPort2.Size = new System.Drawing.Size(40, 18);
            lblCurrentPort2.TabIndex = 47;
            lblCurrentPort2.Text = "Port";
            // 
            // lblCurrentBaud2
            // 
            lblCurrentBaud2.AutoSize = true;
            lblCurrentBaud2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblCurrentBaud2.Location = new System.Drawing.Point(280, 16);
            lblCurrentBaud2.Name = "lblCurrentBaud2";
            lblCurrentBaud2.Size = new System.Drawing.Size(45, 18);
            lblCurrentBaud2.TabIndex = 46;
            lblCurrentBaud2.Text = "Baud";
            // 
            // btnCloseSerial2
            // 
            btnCloseSerial2.BackColor = System.Drawing.Color.Transparent;
            btnCloseSerial2.FlatAppearance.BorderSize = 0;
            btnCloseSerial2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCloseSerial2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnCloseSerial2.Location = new System.Drawing.Point(313, 37);
            btnCloseSerial2.Name = "btnCloseSerial2";
            btnCloseSerial2.Size = new System.Drawing.Size(101, 58);
            btnCloseSerial2.TabIndex = 44;
            btnCloseSerial2.UseVisualStyleBackColor = false;
            btnCloseSerial2.Click += btnCloseSerial2_Click;
            // 
            // textBoxRcv2
            // 
            textBoxRcv2.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            textBoxRcv2.BackColor = System.Drawing.SystemColors.Window;
            textBoxRcv2.Font = new System.Drawing.Font("Tahoma", 9.75F);
            textBoxRcv2.Location = new System.Drawing.Point(-355, 81);
            textBoxRcv2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            textBoxRcv2.Multiline = true;
            textBoxRcv2.Name = "textBoxRcv2";
            textBoxRcv2.ReadOnly = true;
            textBoxRcv2.Size = new System.Drawing.Size(176, 31);
            textBoxRcv2.TabIndex = 40;
            // 
            // btnOpenSerial2
            // 
            btnOpenSerial2.BackColor = System.Drawing.Color.Transparent;
            btnOpenSerial2.FlatAppearance.BorderSize = 0;
            btnOpenSerial2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnOpenSerial2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnOpenSerial2.Location = new System.Drawing.Point(224, 54);
            btnOpenSerial2.Name = "btnOpenSerial2";
            btnOpenSerial2.Size = new System.Drawing.Size(101, 58);
            btnOpenSerial2.TabIndex = 45;
            btnOpenSerial2.UseVisualStyleBackColor = false;
            btnOpenSerial2.Click += btnOpenSerial2_Click;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = System.Drawing.Color.Transparent;
            groupBox3.Controls.Add(cboxSteerModulePort);
            groupBox3.Controls.Add(lblCurrentSteerModulePort);
            groupBox3.Controls.Add(btnOpenSerialSteerModule);
            groupBox3.Controls.Add(btnCloseSerialSteerModule);
            groupBox3.Controls.Add(pictureBox2);
            groupBox3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            groupBox3.Location = new System.Drawing.Point(43, 410);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(526, 130);
            groupBox3.TabIndex = 66;
            groupBox3.TabStop = false;
            groupBox3.Text = "Steer";
            groupBox3.Paint += groupBox1_Paint;
            // 
            // cboxSteerModulePort
            // 
            cboxSteerModulePort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboxSteerModulePort.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            cboxSteerModulePort.FormattingEnabled = true;
            cboxSteerModulePort.Location = new System.Drawing.Point(173, 55);
            cboxSteerModulePort.Name = "cboxSteerModulePort";
            cboxSteerModulePort.Size = new System.Drawing.Size(124, 37);
            cboxSteerModulePort.TabIndex = 64;
            cboxSteerModulePort.SelectedIndexChanged += cboxSteerModule_SelectedIndexChanged;
            // 
            // lblCurrentSteerModulePort
            // 
            lblCurrentSteerModulePort.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblCurrentSteerModulePort.Location = new System.Drawing.Point(179, 34);
            lblCurrentSteerModulePort.Name = "lblCurrentSteerModulePort";
            lblCurrentSteerModulePort.Size = new System.Drawing.Size(112, 18);
            lblCurrentSteerModulePort.TabIndex = 69;
            lblCurrentSteerModulePort.Text = "Port";
            lblCurrentSteerModulePort.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOpenSerialSteerModule
            // 
            btnOpenSerialSteerModule.BackColor = System.Drawing.Color.Transparent;
            btnOpenSerialSteerModule.FlatAppearance.BorderSize = 0;
            btnOpenSerialSteerModule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnOpenSerialSteerModule.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnOpenSerialSteerModule.Image = Properties.Resources.USB_Connect;
            btnOpenSerialSteerModule.Location = new System.Drawing.Point(324, 45);
            btnOpenSerialSteerModule.Name = "btnOpenSerialSteerModule";
            btnOpenSerialSteerModule.Size = new System.Drawing.Size(101, 58);
            btnOpenSerialSteerModule.TabIndex = 53;
            btnOpenSerialSteerModule.UseVisualStyleBackColor = false;
            btnOpenSerialSteerModule.Click += btnOpenSerialSteerModule_Click;
            // 
            // btnCloseSerialSteerModule
            // 
            btnCloseSerialSteerModule.BackColor = System.Drawing.Color.Transparent;
            btnCloseSerialSteerModule.FlatAppearance.BorderSize = 0;
            btnCloseSerialSteerModule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCloseSerialSteerModule.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnCloseSerialSteerModule.Image = Properties.Resources.USB_Disconnect;
            btnCloseSerialSteerModule.Location = new System.Drawing.Point(425, 45);
            btnCloseSerialSteerModule.Name = "btnCloseSerialSteerModule";
            btnCloseSerialSteerModule.Size = new System.Drawing.Size(101, 58);
            btnCloseSerialSteerModule.TabIndex = 52;
            btnCloseSerialSteerModule.UseVisualStyleBackColor = false;
            btnCloseSerialSteerModule.Click += btnCloseSerialSteerModule_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.Com_AutosteerModule;
            pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pictureBox2.Location = new System.Drawing.Point(4, 29);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(108, 88);
            pictureBox2.TabIndex = 70;
            pictureBox2.TabStop = false;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = System.Drawing.Color.Transparent;
            groupBox4.Controls.Add(cboxMachineModulePort);
            groupBox4.Controls.Add(lblCurrentMachineModulePort);
            groupBox4.Controls.Add(btnOpenSerialMachineModule);
            groupBox4.Controls.Add(btnCloseSerialMachineModule);
            groupBox4.Controls.Add(pictureBox3);
            groupBox4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            groupBox4.Location = new System.Drawing.Point(43, 558);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new System.Drawing.Size(526, 130);
            groupBox4.TabIndex = 67;
            groupBox4.TabStop = false;
            groupBox4.Text = "Machine";
            groupBox4.Paint += groupBox1_Paint;
            // 
            // cboxMachineModulePort
            // 
            cboxMachineModulePort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboxMachineModulePort.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            cboxMachineModulePort.FormattingEnabled = true;
            cboxMachineModulePort.Location = new System.Drawing.Point(173, 55);
            cboxMachineModulePort.Name = "cboxMachineModulePort";
            cboxMachineModulePort.Size = new System.Drawing.Size(124, 37);
            cboxMachineModulePort.TabIndex = 64;
            cboxMachineModulePort.SelectedIndexChanged += cboxMachineModulePort_SelectedIndexChanged;
            // 
            // lblCurrentMachineModulePort
            // 
            lblCurrentMachineModulePort.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblCurrentMachineModulePort.Location = new System.Drawing.Point(179, 34);
            lblCurrentMachineModulePort.Name = "lblCurrentMachineModulePort";
            lblCurrentMachineModulePort.Size = new System.Drawing.Size(112, 18);
            lblCurrentMachineModulePort.TabIndex = 70;
            lblCurrentMachineModulePort.Text = "Port";
            lblCurrentMachineModulePort.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOpenSerialMachineModule
            // 
            btnOpenSerialMachineModule.BackColor = System.Drawing.Color.Transparent;
            btnOpenSerialMachineModule.FlatAppearance.BorderSize = 0;
            btnOpenSerialMachineModule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnOpenSerialMachineModule.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnOpenSerialMachineModule.Image = Properties.Resources.USB_Connect;
            btnOpenSerialMachineModule.Location = new System.Drawing.Point(324, 45);
            btnOpenSerialMachineModule.Name = "btnOpenSerialMachineModule";
            btnOpenSerialMachineModule.Size = new System.Drawing.Size(101, 58);
            btnOpenSerialMachineModule.TabIndex = 53;
            btnOpenSerialMachineModule.UseVisualStyleBackColor = false;
            btnOpenSerialMachineModule.Click += btnOpenSerialMachineModule_Click;
            // 
            // btnCloseSerialMachineModule
            // 
            btnCloseSerialMachineModule.BackColor = System.Drawing.Color.Transparent;
            btnCloseSerialMachineModule.FlatAppearance.BorderSize = 0;
            btnCloseSerialMachineModule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCloseSerialMachineModule.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnCloseSerialMachineModule.Image = Properties.Resources.USB_Disconnect;
            btnCloseSerialMachineModule.Location = new System.Drawing.Point(425, 45);
            btnCloseSerialMachineModule.Name = "btnCloseSerialMachineModule";
            btnCloseSerialMachineModule.Size = new System.Drawing.Size(101, 58);
            btnCloseSerialMachineModule.TabIndex = 52;
            btnCloseSerialMachineModule.UseVisualStyleBackColor = false;
            btnCloseSerialMachineModule.Click += btnCloseSerialMachineModule_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.Com_Module2;
            pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pictureBox3.Location = new System.Drawing.Point(6, 29);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(108, 88);
            pictureBox3.TabIndex = 71;
            pictureBox3.TabStop = false;
            // 
            // groupBox5
            // 
            groupBox5.BackColor = System.Drawing.SystemColors.Control;
            groupBox5.Controls.Add(lblCurrentModule3Port);
            groupBox5.Controls.Add(cboxModule3Port);
            groupBox5.Controls.Add(btnOpenSerialModule3);
            groupBox5.Controls.Add(btnCloseSerialModule3);
            groupBox5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            groupBox5.Location = new System.Drawing.Point(1164, 222);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new System.Drawing.Size(368, 90);
            groupBox5.TabIndex = 68;
            groupBox5.TabStop = false;
            groupBox5.Text = "Module 3";
            // 
            // lblCurrentModule3Port
            // 
            lblCurrentModule3Port.AutoSize = true;
            lblCurrentModule3Port.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblCurrentModule3Port.Location = new System.Drawing.Point(115, 19);
            lblCurrentModule3Port.Name = "lblCurrentModule3Port";
            lblCurrentModule3Port.Size = new System.Drawing.Size(40, 18);
            lblCurrentModule3Port.TabIndex = 71;
            lblCurrentModule3Port.Text = "Port";
            // 
            // cboxModule3Port
            // 
            cboxModule3Port.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboxModule3Port.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            cboxModule3Port.FormattingEnabled = true;
            cboxModule3Port.Location = new System.Drawing.Point(10, 42);
            cboxModule3Port.Name = "cboxModule3Port";
            cboxModule3Port.Size = new System.Drawing.Size(124, 37);
            cboxModule3Port.TabIndex = 64;
            cboxModule3Port.SelectedIndexChanged += cboxModule3Port_SelectedIndexChanged;
            // 
            // btnOpenSerialModule3
            // 
            btnOpenSerialModule3.BackColor = System.Drawing.Color.Transparent;
            btnOpenSerialModule3.FlatAppearance.BorderSize = 0;
            btnOpenSerialModule3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnOpenSerialModule3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnOpenSerialModule3.Location = new System.Drawing.Point(161, 21);
            btnOpenSerialModule3.Name = "btnOpenSerialModule3";
            btnOpenSerialModule3.Size = new System.Drawing.Size(101, 58);
            btnOpenSerialModule3.TabIndex = 53;
            btnOpenSerialModule3.UseVisualStyleBackColor = false;
            btnOpenSerialModule3.Click += btnOpenSerialModule3_Click;
            // 
            // btnCloseSerialModule3
            // 
            btnCloseSerialModule3.BackColor = System.Drawing.Color.Transparent;
            btnCloseSerialModule3.FlatAppearance.BorderSize = 0;
            btnCloseSerialModule3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCloseSerialModule3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnCloseSerialModule3.Location = new System.Drawing.Point(268, 19);
            btnCloseSerialModule3.Name = "btnCloseSerialModule3";
            btnCloseSerialModule3.Size = new System.Drawing.Size(101, 58);
            btnCloseSerialModule3.TabIndex = 52;
            btnCloseSerialModule3.UseVisualStyleBackColor = false;
            btnCloseSerialModule3.Click += btnCloseSerialModule3_Click;
            // 
            // groupBox6
            // 
            groupBox6.BackColor = System.Drawing.Color.Transparent;
            groupBox6.Controls.Add(lblCurrentIMU);
            groupBox6.Controls.Add(cboxIMU);
            groupBox6.Controls.Add(btnCloseIMU);
            groupBox6.Controls.Add(btnOpenIMU);
            groupBox6.Controls.Add(pictureBox1);
            groupBox6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            groupBox6.Location = new System.Drawing.Point(43, 261);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new System.Drawing.Size(526, 130);
            groupBox6.TabIndex = 68;
            groupBox6.TabStop = false;
            groupBox6.Text = "IMU";
            groupBox6.Paint += groupBox1_Paint;
            // 
            // lblCurrentIMU
            // 
            lblCurrentIMU.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblCurrentIMU.Location = new System.Drawing.Point(179, 36);
            lblCurrentIMU.Name = "lblCurrentIMU";
            lblCurrentIMU.Size = new System.Drawing.Size(112, 18);
            lblCurrentIMU.TabIndex = 51;
            lblCurrentIMU.Text = "Port";
            lblCurrentIMU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboxIMU
            // 
            cboxIMU.BackColor = System.Drawing.SystemColors.ControlLightLight;
            cboxIMU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboxIMU.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            cboxIMU.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            cboxIMU.FormattingEnabled = true;
            cboxIMU.Location = new System.Drawing.Point(173, 57);
            cboxIMU.Name = "cboxIMU";
            cboxIMU.Size = new System.Drawing.Size(124, 37);
            cboxIMU.TabIndex = 50;
            cboxIMU.SelectedIndexChanged += cboxIMU_SelectedIndexChanged;
            // 
            // btnCloseIMU
            // 
            btnCloseIMU.BackColor = System.Drawing.Color.Transparent;
            btnCloseIMU.FlatAppearance.BorderSize = 0;
            btnCloseIMU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCloseIMU.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnCloseIMU.Image = Properties.Resources.USB_Disconnect;
            btnCloseIMU.Location = new System.Drawing.Point(425, 44);
            btnCloseIMU.Name = "btnCloseIMU";
            btnCloseIMU.Size = new System.Drawing.Size(101, 58);
            btnCloseIMU.TabIndex = 44;
            btnCloseIMU.UseVisualStyleBackColor = false;
            btnCloseIMU.Click += btnCloseIMU_Click;
            // 
            // btnOpenIMU
            // 
            btnOpenIMU.BackColor = System.Drawing.Color.Transparent;
            btnOpenIMU.FlatAppearance.BorderSize = 0;
            btnOpenIMU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnOpenIMU.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnOpenIMU.Image = Properties.Resources.USB_Connect;
            btnOpenIMU.Location = new System.Drawing.Point(324, 44);
            btnOpenIMU.Name = "btnOpenIMU";
            btnOpenIMU.Size = new System.Drawing.Size(101, 58);
            btnOpenIMU.TabIndex = 45;
            btnOpenIMU.UseVisualStyleBackColor = false;
            btnOpenIMU.Click += btnOpenIMU_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Com_IMUModule;
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pictureBox1.Location = new System.Drawing.Point(4, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(108, 88);
            pictureBox1.TabIndex = 69;
            pictureBox1.TabStop = false;
            // 
            // btnRescan
            // 
            btnRescan.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnRescan.BackColor = System.Drawing.Color.Transparent;
            btnRescan.FlatAppearance.BorderSize = 0;
            btnRescan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRescan.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnRescan.ForeColor = System.Drawing.SystemColors.ControlText;
            btnRescan.Image = Properties.Resources.ScanPorts;
            btnRescan.Location = new System.Drawing.Point(665, 620);
            btnRescan.Name = "btnRescan";
            btnRescan.Size = new System.Drawing.Size(89, 63);
            btnRescan.TabIndex = 58;
            btnRescan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnRescan.UseVisualStyleBackColor = false;
            btnRescan.Click += btnRescan_Click;
            // 
            // btnSerialOK
            // 
            btnSerialOK.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnSerialOK.BackColor = System.Drawing.Color.Transparent;
            btnSerialOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnSerialOK.FlatAppearance.BorderSize = 0;
            btnSerialOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSerialOK.Font = new System.Drawing.Font("Tahoma", 12F);
            btnSerialOK.ForeColor = System.Drawing.SystemColors.ControlText;
            btnSerialOK.Image = Properties.Resources.OK64;
            btnSerialOK.Location = new System.Drawing.Point(826, 619);
            btnSerialOK.Name = "btnSerialOK";
            btnSerialOK.Size = new System.Drawing.Size(91, 63);
            btnSerialOK.TabIndex = 59;
            btnSerialOK.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            btnSerialOK.UseVisualStyleBackColor = false;
            btnSerialOK.Click += btnSerialOK_Click;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            label1.Location = new System.Drawing.Point(671, 327);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(55, 23);
            label1.TabIndex = 73;
            label1.Text = "GPS:";
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            label4.Location = new System.Drawing.Point(630, 456);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(96, 23);
            label4.TabIndex = 76;
            label4.Text = "Machine:";
            // 
            // label5
            // 
            label5.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            label5.Location = new System.Drawing.Point(659, 414);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(67, 23);
            label5.TabIndex = 77;
            label5.Text = "Steer:";
            // 
            // label6
            // 
            label6.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            label6.Location = new System.Drawing.Point(669, 371);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(57, 23);
            label6.TabIndex = 78;
            label6.Text = "IMU:";
            // 
            // lblIMU
            // 
            lblIMU.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lblIMU.AutoSize = true;
            lblIMU.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblIMU.Location = new System.Drawing.Point(725, 371);
            lblIMU.Name = "lblIMU";
            lblIMU.Size = new System.Drawing.Size(50, 23);
            lblIMU.TabIndex = 83;
            lblIMU.Text = "IMU";
            // 
            // lblSteer
            // 
            lblSteer.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lblSteer.AutoSize = true;
            lblSteer.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblSteer.Location = new System.Drawing.Point(725, 414);
            lblSteer.Name = "lblSteer";
            lblSteer.Size = new System.Drawing.Size(60, 23);
            lblSteer.TabIndex = 82;
            lblSteer.Text = "Steer";
            // 
            // lblMachine
            // 
            lblMachine.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lblMachine.AutoSize = true;
            lblMachine.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblMachine.Location = new System.Drawing.Point(725, 456);
            lblMachine.Name = "lblMachine";
            lblMachine.Size = new System.Drawing.Size(60, 23);
            lblMachine.TabIndex = 81;
            lblMachine.Text = "Mach";
            // 
            // lblGPS
            // 
            lblGPS.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lblGPS.AutoSize = true;
            lblGPS.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblGPS.Location = new System.Drawing.Point(725, 327);
            lblGPS.Name = "lblGPS";
            lblGPS.Size = new System.Drawing.Size(48, 23);
            lblGPS.TabIndex = 79;
            lblGPS.Text = "GPS";
            // 
            // lblFromGPS
            // 
            lblFromGPS.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lblFromGPS.BackColor = System.Drawing.Color.Transparent;
            lblFromGPS.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblFromGPS.ForeColor = System.Drawing.Color.Black;
            lblFromGPS.Location = new System.Drawing.Point(804, 325);
            lblFromGPS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblFromGPS.Name = "lblFromGPS";
            lblFromGPS.Size = new System.Drawing.Size(64, 27);
            lblFromGPS.TabIndex = 172;
            lblFromGPS.Text = "---";
            lblFromGPS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFromMU
            // 
            lblFromMU.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lblFromMU.BackColor = System.Drawing.Color.Transparent;
            lblFromMU.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblFromMU.ForeColor = System.Drawing.Color.Black;
            lblFromMU.Location = new System.Drawing.Point(804, 368);
            lblFromMU.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblFromMU.Name = "lblFromMU";
            lblFromMU.Size = new System.Drawing.Size(64, 27);
            lblFromMU.TabIndex = 175;
            lblFromMU.Text = "---";
            lblFromMU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFromSteerModule
            // 
            lblFromSteerModule.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lblFromSteerModule.BackColor = System.Drawing.Color.Transparent;
            lblFromSteerModule.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblFromSteerModule.ForeColor = System.Drawing.Color.Black;
            lblFromSteerModule.Location = new System.Drawing.Point(804, 412);
            lblFromSteerModule.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblFromSteerModule.Name = "lblFromSteerModule";
            lblFromSteerModule.Size = new System.Drawing.Size(64, 27);
            lblFromSteerModule.TabIndex = 173;
            lblFromSteerModule.Text = "---";
            lblFromSteerModule.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFromMachineModule
            // 
            lblFromMachineModule.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lblFromMachineModule.BackColor = System.Drawing.Color.Transparent;
            lblFromMachineModule.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblFromMachineModule.ForeColor = System.Drawing.Color.Black;
            lblFromMachineModule.Location = new System.Drawing.Point(804, 454);
            lblFromMachineModule.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblFromMachineModule.Name = "lblFromMachineModule";
            lblFromMachineModule.Size = new System.Drawing.Size(64, 27);
            lblFromMachineModule.TabIndex = 174;
            lblFromMachineModule.Text = "---";
            lblFromMachineModule.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormCommSetGPS
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            BackColor = System.Drawing.Color.Gainsboro;
            ClientSize = new System.Drawing.Size(929, 696);
            ControlBox = false;
            Controls.Add(lblFromGPS);
            Controls.Add(lblFromMU);
            Controls.Add(lblFromSteerModule);
            Controls.Add(lblFromMachineModule);
            Controls.Add(lblIMU);
            Controls.Add(lblSteer);
            Controls.Add(lblMachine);
            Controls.Add(lblGPS);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(groupBox6);
            Controls.Add(groupBox4);
            Controls.Add(groupBox5);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(btnRescan);
            Controls.Add(btnSerialOK);
            Controls.Add(groupBox1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Name = "FormCommSetGPS";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Connect GPS";
            Load += FormCommSet_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnRescan;
        private System.Windows.Forms.Button btnSerialOK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCurrentPort;
        private System.Windows.Forms.Label lblCurrentBaud;
        private System.Windows.Forms.Button btnCloseSerial;
        private System.Windows.Forms.TextBox textBoxRcv;
        private System.Windows.Forms.Button btnOpenSerial;
        private System.Windows.Forms.ComboBox cboxBaud;
        private System.Windows.Forms.ComboBox cboxPort;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboxPort2;
        private System.Windows.Forms.ComboBox cboxBaud2;
        private System.Windows.Forms.Label lblCurrentPort2;
        private System.Windows.Forms.Label lblCurrentBaud2;
        private System.Windows.Forms.Button btnCloseSerial2;
        private System.Windows.Forms.TextBox textBoxRcv2;
        private System.Windows.Forms.Button btnOpenSerial2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cboxSteerModulePort;
        private System.Windows.Forms.Button btnOpenSerialSteerModule;
        private System.Windows.Forms.Button btnCloseSerialSteerModule;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cboxMachineModulePort;
        private System.Windows.Forms.Button btnOpenSerialMachineModule;
        private System.Windows.Forms.Button btnCloseSerialMachineModule;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cboxModule3Port;
        private System.Windows.Forms.Button btnOpenSerialModule3;
        private System.Windows.Forms.Button btnCloseSerialModule3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox cboxIMU;
        private System.Windows.Forms.Button btnCloseIMU;
        private System.Windows.Forms.Button btnOpenIMU;
        private System.Windows.Forms.Label lblCurrentSteerModulePort;
        private System.Windows.Forms.Label lblCurrentMachineModulePort;
        private System.Windows.Forms.Label lblCurrentModule3Port;
        private System.Windows.Forms.Label lblCurrentIMU;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblIMU;
        private System.Windows.Forms.Label lblSteer;
        private System.Windows.Forms.Label lblMachine;
        private System.Windows.Forms.Label lblGPS;
        private System.Windows.Forms.Label lblFromGPS;
        private System.Windows.Forms.Label lblFromMU;
        private System.Windows.Forms.Label lblFromSteerModule;
        private System.Windows.Forms.Label lblFromMachineModule;
        private System.Windows.Forms.ComboBox cboxRtcmPort;
        private System.Windows.Forms.ComboBox cboxRtcmBaud;
        private System.Windows.Forms.Label labelRtcmPort;
        private System.Windows.Forms.Label labelRtcmBaud;
        private System.Windows.Forms.Label labelDifferentRtcmPort;
        private System.Windows.Forms.Button btnCloseRTCM;
        private System.Windows.Forms.Button btnOpenRTCM;
        private System.Windows.Forms.Label label3;
    }
}
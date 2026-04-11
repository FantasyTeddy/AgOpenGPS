namespace AgIO
{
    partial class FormISOBUS
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
            btnIsobusOK = new System.Windows.Forms.Button();
            btnCloseIsobus = new System.Windows.Forms.Button();
            btnOpenIsobus = new System.Windows.Forms.Button();
            cboxRadioAdapter = new System.Windows.Forms.ComboBox();
            lblCurrentAdapter = new System.Windows.Forms.Label();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            flowLayoutCANAdapter = new System.Windows.Forms.FlowLayoutPanel();
            flowLayoutChannel = new System.Windows.Forms.FlowLayoutPanel();
            lblChannel = new System.Windows.Forms.Label();
            cboxRadioChannel = new System.Windows.Forms.ComboBox();
            flowLayoutDownloadIsobus = new System.Windows.Forms.FlowLayoutPanel();
            lblDownloadIsobus = new System.Windows.Forms.Label();
            linkDownloadIsobus = new System.Windows.Forms.LinkLabel();
            textBoxRcv = new System.Windows.Forms.TextBox();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutCANAdapter.SuspendLayout();
            flowLayoutChannel.SuspendLayout();
            flowLayoutDownloadIsobus.SuspendLayout();
            SuspendLayout();
            // 
            // btnIsobusOK
            // 
            btnIsobusOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnIsobusOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnIsobusOK.FlatAppearance.BorderSize = 0;
            btnIsobusOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnIsobusOK.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnIsobusOK.ForeColor = System.Drawing.SystemColors.ControlText;
            btnIsobusOK.Image = Properties.Resources.OK64;
            btnIsobusOK.Location = new System.Drawing.Point(635, 519);
            btnIsobusOK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnIsobusOK.Name = "btnIsobusOK";
            btnIsobusOK.Size = new System.Drawing.Size(103, 74);
            btnIsobusOK.TabIndex = 71;
            btnIsobusOK.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            btnIsobusOK.UseVisualStyleBackColor = true;
            btnIsobusOK.Click += btnIsobusOK_Click;
            // 
            // btnCloseIsobus
            // 
            btnCloseIsobus.BackColor = System.Drawing.Color.Transparent;
            btnCloseIsobus.FlatAppearance.BorderSize = 0;
            btnCloseIsobus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCloseIsobus.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnCloseIsobus.Image = Properties.Resources.USB_Disconnect;
            btnCloseIsobus.Location = new System.Drawing.Point(583, 3);
            btnCloseIsobus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCloseIsobus.Name = "btnCloseIsobus";
            btnCloseIsobus.Size = new System.Drawing.Size(127, 67);
            btnCloseIsobus.TabIndex = 177;
            btnCloseIsobus.UseVisualStyleBackColor = false;
            btnCloseIsobus.Visible = false;
            btnCloseIsobus.Click += btnCloseIsobus_Click;
            // 
            // btnOpenIsobus
            // 
            btnOpenIsobus.BackColor = System.Drawing.Color.Transparent;
            btnOpenIsobus.FlatAppearance.BorderSize = 0;
            btnOpenIsobus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnOpenIsobus.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnOpenIsobus.Image = Properties.Resources.USB_Connect;
            btnOpenIsobus.Location = new System.Drawing.Point(457, 3);
            btnOpenIsobus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnOpenIsobus.Name = "btnOpenIsobus";
            btnOpenIsobus.Size = new System.Drawing.Size(118, 67);
            btnOpenIsobus.TabIndex = 178;
            btnOpenIsobus.UseVisualStyleBackColor = false;
            btnOpenIsobus.Visible = false;
            btnOpenIsobus.Click += btnOpenIsobus_Click;
            // 
            // cboxRadioAdapter
            // 
            cboxRadioAdapter.CausesValidation = false;
            cboxRadioAdapter.DisplayMember = "0";
            cboxRadioAdapter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboxRadioAdapter.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            cboxRadioAdapter.FormattingEnabled = true;
            cboxRadioAdapter.Items.AddRange(new object[] { "PEAK-PCAN", "InnoMaker-USB2CAN", "Rusoku-TouCAN", "SYS-TEC-USB2CAN" });
            cboxRadioAdapter.Location = new System.Drawing.Point(4, 24);
            cboxRadioAdapter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cboxRadioAdapter.Name = "cboxRadioAdapter";
            cboxRadioAdapter.Size = new System.Drawing.Size(257, 37);
            cboxRadioAdapter.TabIndex = 179;
            cboxRadioAdapter.SelectedIndexChanged += cboxRadioAdapter_SelectedIndexChanged;
            // 
            // lblCurrentAdapter
            // 
            lblCurrentAdapter.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblCurrentAdapter.Location = new System.Drawing.Point(4, 0);
            lblCurrentAdapter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblCurrentAdapter.Name = "lblCurrentAdapter";
            lblCurrentAdapter.Size = new System.Drawing.Size(161, 21);
            lblCurrentAdapter.TabIndex = 180;
            lblCurrentAdapter.Text = "CANbus Adapter";
            lblCurrentAdapter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblCurrentAdapter.UseCompatibleTextRendering = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(flowLayoutCANAdapter);
            flowLayoutPanel1.Controls.Add(flowLayoutChannel);
            flowLayoutPanel1.Controls.Add(btnOpenIsobus);
            flowLayoutPanel1.Controls.Add(btnCloseIsobus);
            flowLayoutPanel1.Controls.Add(flowLayoutDownloadIsobus);
            flowLayoutPanel1.Location = new System.Drawing.Point(14, 14);
            flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(715, 89);
            flowLayoutPanel1.TabIndex = 181;
            // 
            // flowLayoutCANAdapter
            // 
            flowLayoutCANAdapter.Controls.Add(lblCurrentAdapter);
            flowLayoutCANAdapter.Controls.Add(cboxRadioAdapter);
            flowLayoutCANAdapter.Location = new System.Drawing.Point(4, 3);
            flowLayoutCANAdapter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            flowLayoutCANAdapter.Name = "flowLayoutCANAdapter";
            flowLayoutCANAdapter.Size = new System.Drawing.Size(282, 80);
            flowLayoutCANAdapter.TabIndex = 181;
            flowLayoutCANAdapter.Visible = false;
            // 
            // flowLayoutChannel
            // 
            flowLayoutChannel.Controls.Add(lblChannel);
            flowLayoutChannel.Controls.Add(cboxRadioChannel);
            flowLayoutChannel.Location = new System.Drawing.Point(294, 3);
            flowLayoutChannel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            flowLayoutChannel.Name = "flowLayoutChannel";
            flowLayoutChannel.Size = new System.Drawing.Size(155, 80);
            flowLayoutChannel.TabIndex = 182;
            flowLayoutChannel.Visible = false;
            // 
            // lblChannel
            // 
            lblChannel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblChannel.Location = new System.Drawing.Point(4, 0);
            lblChannel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblChannel.Name = "lblChannel";
            lblChannel.Size = new System.Drawing.Size(89, 21);
            lblChannel.TabIndex = 180;
            lblChannel.Text = "Channel";
            lblChannel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblChannel.UseCompatibleTextRendering = true;
            // 
            // cboxRadioChannel
            // 
            cboxRadioChannel.CausesValidation = false;
            cboxRadioChannel.DisplayMember = "0";
            cboxRadioChannel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboxRadioChannel.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            cboxRadioChannel.FormattingEnabled = true;
            cboxRadioChannel.Items.AddRange(new object[] { "PCAN-USB" });
            cboxRadioChannel.Location = new System.Drawing.Point(4, 24);
            cboxRadioChannel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cboxRadioChannel.Name = "cboxRadioChannel";
            cboxRadioChannel.Size = new System.Drawing.Size(135, 37);
            cboxRadioChannel.TabIndex = 179;
            cboxRadioChannel.SelectedIndexChanged += cboxRadioChannel_SelectedIndexChanged;
            // 
            // flowLayoutDownloadIsobus
            // 
            flowLayoutDownloadIsobus.Controls.Add(lblDownloadIsobus);
            flowLayoutDownloadIsobus.Controls.Add(linkDownloadIsobus);
            flowLayoutDownloadIsobus.Location = new System.Drawing.Point(4, 89);
            flowLayoutDownloadIsobus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            flowLayoutDownloadIsobus.Name = "flowLayoutDownloadIsobus";
            flowLayoutDownloadIsobus.Size = new System.Drawing.Size(643, 51);
            flowLayoutDownloadIsobus.TabIndex = 183;
            // 
            // lblDownloadIsobus
            // 
            lblDownloadIsobus.AutoSize = true;
            lblDownloadIsobus.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            lblDownloadIsobus.Location = new System.Drawing.Point(4, 0);
            lblDownloadIsobus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDownloadIsobus.Name = "lblDownloadIsobus";
            lblDownloadIsobus.Size = new System.Drawing.Size(433, 18);
            lblDownloadIsobus.TabIndex = 183;
            lblDownloadIsobus.Text = "AOG-TaskController not installed, please download from:";
            // 
            // linkDownloadIsobus
            // 
            linkDownloadIsobus.AutoSize = true;
            linkDownloadIsobus.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            linkDownloadIsobus.Location = new System.Drawing.Point(4, 18);
            linkDownloadIsobus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            linkDownloadIsobus.Name = "linkDownloadIsobus";
            linkDownloadIsobus.Size = new System.Drawing.Size(390, 18);
            linkDownloadIsobus.TabIndex = 182;
            linkDownloadIsobus.TabStop = true;
            linkDownloadIsobus.Text = "https://github.com/GwnDaan/AOG-TaskController";
            linkDownloadIsobus.LinkClicked += linkDownloadIsobus_LinkClicked;
            // 
            // textBoxRcv
            // 
            textBoxRcv.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            textBoxRcv.BackColor = System.Drawing.SystemColors.Window;
            textBoxRcv.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            textBoxRcv.Location = new System.Drawing.Point(14, 112);
            textBoxRcv.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            textBoxRcv.MinimumSize = new System.Drawing.Size(116, 230);
            textBoxRcv.Multiline = true;
            textBoxRcv.Name = "textBoxRcv";
            textBoxRcv.ReadOnly = true;
            textBoxRcv.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            textBoxRcv.Size = new System.Drawing.Size(722, 397);
            textBoxRcv.TabIndex = 540;
            textBoxRcv.Visible = false;
            textBoxRcv.WordWrap = false;
            // 
            // FormISOBUS
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Gainsboro;
            ClientSize = new System.Drawing.Size(751, 607);
            ControlBox = false;
            Controls.Add(flowLayoutPanel1);
            Controls.Add(btnIsobusOK);
            Controls.Add(textBoxRcv);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "FormISOBUS";
            Text = "ISOBUS Settings";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutCANAdapter.ResumeLayout(false);
            flowLayoutChannel.ResumeLayout(false);
            flowLayoutDownloadIsobus.ResumeLayout(false);
            flowLayoutDownloadIsobus.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIsobusOK;
        private System.Windows.Forms.Button btnCloseIsobus;
        private System.Windows.Forms.Button btnOpenIsobus;
        private System.Windows.Forms.Label lblCurrentAdapter;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutCANAdapter;
        private System.Windows.Forms.LinkLabel linkDownloadIsobus;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutDownloadIsobus;
        private System.Windows.Forms.Label lblDownloadIsobus;
        private System.Windows.Forms.TextBox textBoxRcv;
        private System.Windows.Forms.ComboBox cboxRadioAdapter;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutChannel;
        private System.Windows.Forms.Label lblChannel;
        private System.Windows.Forms.ComboBox cboxRadioChannel;
    }
}
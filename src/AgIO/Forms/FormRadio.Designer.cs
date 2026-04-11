
namespace AgIO
{
    partial class FormRadio
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
            cboxRadioPort = new System.Windows.Forms.ComboBox();
            lblCurrentPort = new System.Windows.Forms.Label();
            cboxBaud = new System.Windows.Forms.ComboBox();
            lblCurrentBaud = new System.Windows.Forms.Label();
            lvChannels = new System.Windows.Forms.ListView();
            columnHeaderId = new System.Windows.Forms.ColumnHeader();
            columnHeaderName = new System.Windows.Forms.ColumnHeader();
            columnHeaderFreq = new System.Windows.Forms.ColumnHeader();
            columnHeaderDist = new System.Windows.Forms.ColumnHeader();
            tbCommand = new System.Windows.Forms.TextBox();
            lblCommand = new System.Windows.Forms.Label();
            tbResponse = new System.Windows.Forms.TextBox();
            lbResponse = new System.Windows.Forms.Label();
            cboxIsRadioOn = new System.Windows.Forms.CheckBox();
            btnEditChannel = new System.Windows.Forms.Button();
            btnDeleteChannel = new System.Windows.Forms.Button();
            btnSetChannel = new System.Windows.Forms.Button();
            btnRescan = new System.Windows.Forms.Button();
            btnCloseSerial = new System.Windows.Forms.Button();
            btnOpenSerial = new System.Windows.Forms.Button();
            btnRadioCancel = new System.Windows.Forms.Button();
            btnRadioOK = new System.Windows.Forms.Button();
            btnSendCommand = new System.Windows.Forms.Button();
            btnAddChannel = new System.Windows.Forms.Button();
            labelChannels = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // cboxRadioPort
            // 
            cboxRadioPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboxRadioPort.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            cboxRadioPort.FormattingEnabled = true;
            cboxRadioPort.Location = new System.Drawing.Point(74, 44);
            cboxRadioPort.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cboxRadioPort.Name = "cboxRadioPort";
            cboxRadioPort.Size = new System.Drawing.Size(144, 37);
            cboxRadioPort.TabIndex = 98;
            // 
            // lblCurrentPort
            // 
            lblCurrentPort.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblCurrentPort.Location = new System.Drawing.Point(82, 20);
            lblCurrentPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblCurrentPort.Name = "lblCurrentPort";
            lblCurrentPort.Size = new System.Drawing.Size(139, 21);
            lblCurrentPort.TabIndex = 99;
            lblCurrentPort.Text = "Port";
            lblCurrentPort.TextAlign = System.Drawing.ContentAlignment.TopRight;
            lblCurrentPort.UseCompatibleTextRendering = true;
            // 
            // cboxBaud
            // 
            cboxBaud.BackColor = System.Drawing.SystemColors.ControlLightLight;
            cboxBaud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboxBaud.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            cboxBaud.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            cboxBaud.FormattingEnabled = true;
            cboxBaud.Items.AddRange(new object[] { "4800", "9600", "19200", "38400", "57600", "115200", "128000", "256000" });
            cboxBaud.Location = new System.Drawing.Point(254, 44);
            cboxBaud.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cboxBaud.Name = "cboxBaud";
            cboxBaud.Size = new System.Drawing.Size(148, 37);
            cboxBaud.TabIndex = 101;
            // 
            // lblCurrentBaud
            // 
            lblCurrentBaud.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblCurrentBaud.Location = new System.Drawing.Point(254, 20);
            lblCurrentBaud.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblCurrentBaud.Name = "lblCurrentBaud";
            lblCurrentBaud.Size = new System.Drawing.Size(148, 21);
            lblCurrentBaud.TabIndex = 100;
            lblCurrentBaud.Text = "Baud";
            lblCurrentBaud.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lvChannels
            // 
            lvChannels.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lvChannels.BackColor = System.Drawing.SystemColors.InactiveCaption;
            lvChannels.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeaderId, columnHeaderName, columnHeaderFreq, columnHeaderDist });
            lvChannels.Font = new System.Drawing.Font("Tahoma", 21.75F);
            lvChannels.FullRowSelect = true;
            lvChannels.GridLines = true;
            lvChannels.Location = new System.Drawing.Point(14, 121);
            lvChannels.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            lvChannels.MultiSelect = false;
            lvChannels.Name = "lvChannels";
            lvChannels.Size = new System.Drawing.Size(798, 376);
            lvChannels.TabIndex = 104;
            lvChannels.UseCompatibleStateImageBehavior = false;
            lvChannels.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderId
            // 
            columnHeaderId.Text = "Id";
            // 
            // columnHeaderName
            // 
            columnHeaderName.Text = "Name";
            columnHeaderName.Width = 189;
            // 
            // columnHeaderFreq
            // 
            columnHeaderFreq.Text = "Frequency";
            columnHeaderFreq.Width = 220;
            // 
            // columnHeaderDist
            // 
            columnHeaderDist.Text = "Distance";
            columnHeaderDist.Width = 133;
            // 
            // tbCommand
            // 
            tbCommand.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            tbCommand.Location = new System.Drawing.Point(14, 540);
            tbCommand.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tbCommand.Name = "tbCommand";
            tbCommand.Size = new System.Drawing.Size(697, 30);
            tbCommand.TabIndex = 107;
            tbCommand.Click += tbox_Click;
            // 
            // lblCommand
            // 
            lblCommand.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblCommand.AutoSize = true;
            lblCommand.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblCommand.Location = new System.Drawing.Point(13, 516);
            lblCommand.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblCommand.Name = "lblCommand";
            lblCommand.Size = new System.Drawing.Size(80, 18);
            lblCommand.TabIndex = 108;
            lblCommand.Text = "Command";
            // 
            // tbResponse
            // 
            tbResponse.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            tbResponse.Location = new System.Drawing.Point(14, 602);
            tbResponse.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tbResponse.Name = "tbResponse";
            tbResponse.ReadOnly = true;
            tbResponse.Size = new System.Drawing.Size(697, 30);
            tbResponse.TabIndex = 110;
            // 
            // lbResponse
            // 
            lbResponse.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lbResponse.AutoSize = true;
            lbResponse.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lbResponse.Location = new System.Drawing.Point(14, 578);
            lbResponse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbResponse.Name = "lbResponse";
            lbResponse.Size = new System.Drawing.Size(80, 18);
            lbResponse.TabIndex = 111;
            lbResponse.Text = "Response";
            // 
            // cboxIsRadioOn
            // 
            cboxIsRadioOn.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            cboxIsRadioOn.Appearance = System.Windows.Forms.Appearance.Button;
            cboxIsRadioOn.BackColor = System.Drawing.Color.Salmon;
            cboxIsRadioOn.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            cboxIsRadioOn.Checked = true;
            cboxIsRadioOn.CheckState = System.Windows.Forms.CheckState.Checked;
            cboxIsRadioOn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(128, 255, 128);
            cboxIsRadioOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboxIsRadioOn.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            cboxIsRadioOn.Location = new System.Drawing.Point(462, 657);
            cboxIsRadioOn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cboxIsRadioOn.Name = "cboxIsRadioOn";
            cboxIsRadioOn.Size = new System.Drawing.Size(175, 58);
            cboxIsRadioOn.TabIndex = 112;
            cboxIsRadioOn.Text = "Radio";
            cboxIsRadioOn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            cboxIsRadioOn.UseVisualStyleBackColor = false;
            // 
            // btnEditChannel
            // 
            btnEditChannel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnEditChannel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnEditChannel.FlatAppearance.BorderSize = 0;
            btnEditChannel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEditChannel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnEditChannel.Image = Properties.Resources.Edit;
            btnEditChannel.Location = new System.Drawing.Point(820, 331);
            btnEditChannel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnEditChannel.Name = "btnEditChannel";
            btnEditChannel.Size = new System.Drawing.Size(122, 74);
            btnEditChannel.TabIndex = 114;
            btnEditChannel.UseVisualStyleBackColor = true;
            btnEditChannel.Click += btnEditChannel_Click;
            // 
            // btnDeleteChannel
            // 
            btnDeleteChannel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnDeleteChannel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnDeleteChannel.FlatAppearance.BorderSize = 0;
            btnDeleteChannel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDeleteChannel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnDeleteChannel.Image = Properties.Resources.Trash;
            btnDeleteChannel.Location = new System.Drawing.Point(820, 436);
            btnDeleteChannel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnDeleteChannel.Name = "btnDeleteChannel";
            btnDeleteChannel.Size = new System.Drawing.Size(122, 74);
            btnDeleteChannel.TabIndex = 113;
            btnDeleteChannel.UseVisualStyleBackColor = true;
            btnDeleteChannel.Click += btnDeleteChannel_Click;
            // 
            // btnSetChannel
            // 
            btnSetChannel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnSetChannel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnSetChannel.FlatAppearance.BorderSize = 0;
            btnSetChannel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSetChannel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnSetChannel.Image = Properties.Resources.ArrowRight;
            btnSetChannel.Location = new System.Drawing.Point(820, 121);
            btnSetChannel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSetChannel.Name = "btnSetChannel";
            btnSetChannel.Size = new System.Drawing.Size(122, 74);
            btnSetChannel.TabIndex = 106;
            btnSetChannel.UseVisualStyleBackColor = true;
            btnSetChannel.Click += btnSetChannel_Click;
            // 
            // btnRescan
            // 
            btnRescan.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnRescan.BackColor = System.Drawing.Color.Transparent;
            btnRescan.FlatAppearance.BorderSize = 0;
            btnRescan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRescan.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnRescan.ForeColor = System.Drawing.SystemColors.ControlText;
            btnRescan.Image = Properties.Resources.ScanPorts;
            btnRescan.Location = new System.Drawing.Point(820, 541);
            btnRescan.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnRescan.Name = "btnRescan";
            btnRescan.Size = new System.Drawing.Size(122, 73);
            btnRescan.TabIndex = 105;
            btnRescan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnRescan.UseVisualStyleBackColor = false;
            btnRescan.Click += btnRescan_Click;
            // 
            // btnCloseSerial
            // 
            btnCloseSerial.BackColor = System.Drawing.Color.Transparent;
            btnCloseSerial.FlatAppearance.BorderSize = 0;
            btnCloseSerial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCloseSerial.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnCloseSerial.Image = Properties.Resources.USB_Disconnect;
            btnCloseSerial.Location = new System.Drawing.Point(567, 28);
            btnCloseSerial.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCloseSerial.Name = "btnCloseSerial";
            btnCloseSerial.Size = new System.Drawing.Size(118, 67);
            btnCloseSerial.TabIndex = 102;
            btnCloseSerial.UseVisualStyleBackColor = false;
            btnCloseSerial.Click += btnCloseSerial_Click;
            // 
            // btnOpenSerial
            // 
            btnOpenSerial.BackColor = System.Drawing.Color.Transparent;
            btnOpenSerial.FlatAppearance.BorderSize = 0;
            btnOpenSerial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnOpenSerial.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnOpenSerial.Image = Properties.Resources.USB_Connect;
            btnOpenSerial.Location = new System.Drawing.Point(426, 28);
            btnOpenSerial.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnOpenSerial.Name = "btnOpenSerial";
            btnOpenSerial.Size = new System.Drawing.Size(118, 67);
            btnOpenSerial.TabIndex = 103;
            btnOpenSerial.UseVisualStyleBackColor = false;
            btnOpenSerial.Click += btnOpenSerial_Click;
            // 
            // btnRadioCancel
            // 
            btnRadioCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnRadioCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnRadioCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnRadioCancel.FlatAppearance.BorderSize = 0;
            btnRadioCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRadioCancel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnRadioCancel.Image = Properties.Resources.Cancel64;
            btnRadioCancel.Location = new System.Drawing.Point(701, 646);
            btnRadioCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnRadioCancel.Name = "btnRadioCancel";
            btnRadioCancel.Size = new System.Drawing.Size(122, 74);
            btnRadioCancel.TabIndex = 97;
            btnRadioCancel.UseVisualStyleBackColor = true;
            // 
            // btnRadioOK
            // 
            btnRadioOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnRadioOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnRadioOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnRadioOK.FlatAppearance.BorderSize = 0;
            btnRadioOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRadioOK.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnRadioOK.ForeColor = System.Drawing.SystemColors.ControlText;
            btnRadioOK.Image = Properties.Resources.OK64;
            btnRadioOK.Location = new System.Drawing.Point(820, 646);
            btnRadioOK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnRadioOK.Name = "btnRadioOK";
            btnRadioOK.Size = new System.Drawing.Size(122, 74);
            btnRadioOK.TabIndex = 96;
            btnRadioOK.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            btnRadioOK.UseVisualStyleBackColor = true;
            btnRadioOK.Click += btnRadioOK_Click;
            // 
            // btnSendCommand
            // 
            btnSendCommand.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnSendCommand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnSendCommand.FlatAppearance.BorderSize = 0;
            btnSendCommand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSendCommand.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnSendCommand.Image = Properties.Resources.ArrowRight;
            btnSendCommand.Location = new System.Drawing.Point(691, 525);
            btnSendCommand.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSendCommand.Name = "btnSendCommand";
            btnSendCommand.Size = new System.Drawing.Size(122, 74);
            btnSendCommand.TabIndex = 109;
            btnSendCommand.UseVisualStyleBackColor = true;
            btnSendCommand.Click += btnSendCommand_Click;
            // 
            // btnAddChannel
            // 
            btnAddChannel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnAddChannel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnAddChannel.FlatAppearance.BorderSize = 0;
            btnAddChannel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAddChannel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnAddChannel.Image = Properties.Resources.AddNew;
            btnAddChannel.Location = new System.Drawing.Point(820, 226);
            btnAddChannel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnAddChannel.Name = "btnAddChannel";
            btnAddChannel.Size = new System.Drawing.Size(122, 74);
            btnAddChannel.TabIndex = 114;
            btnAddChannel.UseVisualStyleBackColor = true;
            btnAddChannel.Click += btnAddChannel_Click;
            // 
            // labelChannels
            // 
            labelChannels.AutoSize = true;
            labelChannels.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelChannels.Location = new System.Drawing.Point(13, 97);
            labelChannels.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelChannels.Name = "labelChannels";
            labelChannels.Size = new System.Drawing.Size(76, 18);
            labelChannels.TabIndex = 115;
            labelChannels.Text = "Channels";
            // 
            // FormRadio
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(959, 752);
            ControlBox = false;
            Controls.Add(labelChannels);
            Controls.Add(btnAddChannel);
            Controls.Add(btnEditChannel);
            Controls.Add(btnDeleteChannel);
            Controls.Add(cboxIsRadioOn);
            Controls.Add(lbResponse);
            Controls.Add(tbResponse);
            Controls.Add(lblCommand);
            Controls.Add(tbCommand);
            Controls.Add(btnSetChannel);
            Controls.Add(btnRescan);
            Controls.Add(lvChannels);
            Controls.Add(btnCloseSerial);
            Controls.Add(btnOpenSerial);
            Controls.Add(cboxBaud);
            Controls.Add(lblCurrentBaud);
            Controls.Add(cboxRadioPort);
            Controls.Add(btnRadioCancel);
            Controls.Add(btnRadioOK);
            Controls.Add(btnSendCommand);
            Controls.Add(lblCurrentPort);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MinimumSize = new System.Drawing.Size(975, 765);
            Name = "FormRadio";
            Text = "Radio Settings";
            Load += FormRadio_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRadioCancel;
        private System.Windows.Forms.Button btnRadioOK;
        private System.Windows.Forms.ComboBox cboxRadioPort;
        private System.Windows.Forms.Label lblCurrentPort;
        private System.Windows.Forms.ComboBox cboxBaud;
        private System.Windows.Forms.Label lblCurrentBaud;
        private System.Windows.Forms.Button btnCloseSerial;
        private System.Windows.Forms.Button btnOpenSerial;
        private System.Windows.Forms.ListView lvChannels;
        private System.Windows.Forms.ColumnHeader columnHeaderId;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderFreq;
        private System.Windows.Forms.Button btnRescan;
        private System.Windows.Forms.Button btnSetChannel;
        private System.Windows.Forms.TextBox tbCommand;
        private System.Windows.Forms.Label lblCommand;
        private System.Windows.Forms.Button btnSendCommand;
        private System.Windows.Forms.TextBox tbResponse;
        private System.Windows.Forms.Label lbResponse;
        private System.Windows.Forms.CheckBox cboxIsRadioOn;
        private System.Windows.Forms.Button btnDeleteChannel;
        private System.Windows.Forms.Button btnEditChannel;
        private System.Windows.Forms.Button btnAddChannel;
        private System.Windows.Forms.Label labelChannels;
        private System.Windows.Forms.ColumnHeader columnHeaderDist;
    }
}
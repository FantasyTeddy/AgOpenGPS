namespace AgOpenGPS
{
    partial class FormGrid
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
            oglSelf = new OpenTK.GLControl.GLControl();
            timer1 = new System.Windows.Forms.Timer(components);
            tlp1 = new System.Windows.Forms.TableLayoutPanel();
            btnAlignToTrack = new System.Windows.Forms.Button();
            btnCancelTouch = new System.Windows.Forms.Button();
            btnExit = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            tlp1.SuspendLayout();
            SuspendLayout();
            // 
            // oglSelf
            // 
            oglSelf.API = OpenTK.Windowing.Common.ContextAPI.OpenGL;
            oglSelf.APIVersion = new System.Version(3, 3, 0, 0);
            oglSelf.BackColor = System.Drawing.Color.Black;
            oglSelf.Cursor = System.Windows.Forms.Cursors.Cross;
            oglSelf.Flags = OpenTK.Windowing.Common.ContextFlags.Default;
            oglSelf.IsEventDriven = true;
            oglSelf.Location = new System.Drawing.Point(2, 2);
            oglSelf.Margin = new System.Windows.Forms.Padding(0);
            oglSelf.Name = "oglSelf";
            oglSelf.Profile = OpenTK.Windowing.Common.ContextProfile.Compatability;
            oglSelf.SharedContext = null;
            oglSelf.Size = new System.Drawing.Size(583, 577);
            oglSelf.TabIndex = 183;
            oglSelf.Load += oglSelf_Load;
            oglSelf.Paint += oglSelf_Paint;
            oglSelf.MouseDown += oglSelf_MouseDown;
            oglSelf.Resize += oglSelf_Resize;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 500;
            timer1.Tick += timer1_Tick;
            // 
            // tlp1
            // 
            tlp1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            tlp1.ColumnCount = 1;
            tlp1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlp1.Controls.Add(btnAlignToTrack, 0, 1);
            tlp1.Controls.Add(btnCancelTouch, 0, 0);
            tlp1.Controls.Add(btnExit, 0, 3);
            tlp1.Controls.Add(btnCancel, 0, 2);
            tlp1.Location = new System.Drawing.Point(589, 2);
            tlp1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tlp1.Name = "tlp1";
            tlp1.RowCount = 4;
            tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 126F));
            tlp1.Size = new System.Drawing.Size(115, 571);
            tlp1.TabIndex = 564;
            // 
            // btnAlignToTrack
            // 
            btnAlignToTrack.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnAlignToTrack.BackColor = System.Drawing.Color.Transparent;
            btnAlignToTrack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnAlignToTrack.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            btnAlignToTrack.FlatAppearance.BorderSize = 0;
            btnAlignToTrack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAlignToTrack.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnAlignToTrack.Image = Properties.Resources.ABTrackAB;
            btnAlignToTrack.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnAlignToTrack.Location = new System.Drawing.Point(26, 175);
            btnAlignToTrack.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnAlignToTrack.Name = "btnAlignToTrack";
            btnAlignToTrack.Size = new System.Drawing.Size(63, 93);
            btnAlignToTrack.TabIndex = 471;
            btnAlignToTrack.UseVisualStyleBackColor = false;
            btnAlignToTrack.Click += btnAlignToTrack_Click;
            // 
            // btnCancelTouch
            // 
            btnCancelTouch.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnCancelTouch.BackColor = System.Drawing.Color.Transparent;
            btnCancelTouch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnCancelTouch.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            btnCancelTouch.FlatAppearance.BorderSize = 0;
            btnCancelTouch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancelTouch.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnCancelTouch.Image = Properties.Resources.HeadlandDeletePoints;
            btnCancelTouch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnCancelTouch.Location = new System.Drawing.Point(26, 41);
            btnCancelTouch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCancelTouch.Name = "btnCancelTouch";
            btnCancelTouch.Size = new System.Drawing.Size(63, 65);
            btnCancelTouch.TabIndex = 470;
            btnCancelTouch.UseVisualStyleBackColor = false;
            btnCancelTouch.Click += btnCancelTouch_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnExit.BackColor = System.Drawing.Color.Transparent;
            btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnExit.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnExit.ForeColor = System.Drawing.Color.FromArgb(192, 64, 0);
            btnExit.Image = Properties.Resources.OK64;
            btnExit.Location = new System.Drawing.Point(26, 475);
            btnExit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(63, 65);
            btnExit.TabIndex = 0;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnCancel.BackColor = System.Drawing.Color.Transparent;
            btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancel.Font = new System.Drawing.Font("Tahoma", 14.25F);
            btnCancel.Image = Properties.Resources.Cancel64;
            btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnCancel.Location = new System.Drawing.Point(26, 337);
            btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(63, 65);
            btnCancel.TabIndex = 469;
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // FormGrid
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.WhiteSmoke;
            ClientSize = new System.Drawing.Size(706, 578);
            ControlBox = false;
            Controls.Add(oglSelf);
            Controls.Add(tlp1);
            ForeColor = System.Drawing.Color.Black;
            HelpButton = true;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormGrid";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "2 Points - Align Grid";
            FormClosing += FormABDraw_FormClosing;
            Load += FormABDraw_Load;
            ResizeEnd += FormABDraw_ResizeEnd;
            tlp1.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private OpenTK.GLControl.GLControl oglSelf;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCancelTouch;
        private System.Windows.Forms.TableLayoutPanel tlp1;
        private System.Windows.Forms.Button btnAlignToTrack;
    }
}
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace AgOpenGPS.Forms.Field
{
    partial class FormBuildBoundaryFromTracks
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
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            using (var pen = new Pen(Color.DarkGray, 15))
            {
                var rect = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
                e.Graphics.DrawRectangle(pen, rect);
            }
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            glControlPreview = new OpenTK.GLControl.GLControl();
            flpTrackList = new FlowLayoutPanel();
            lblList = new Label();
            btnSave = new Button();
            btnShrinkB = new Button();
            btnShrinkA = new Button();
            btnExtendForward = new Button();
            btnExtendBackward = new Button();
            btnSelectNext = new Button();
            btnSelectPrevious = new Button();
            btnClose = new Button();
            btnBuildBoundary = new Button();
            btnResetPreview = new Button();
            btnAutoFind = new Button();
            SuspendLayout();
            // 
            // glControlPreview
            // 
            glControlPreview.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            glControlPreview.API = OpenTK.Windowing.Common.ContextAPI.OpenGL;
            glControlPreview.APIVersion = new System.Version(3, 3, 0, 0);
            glControlPreview.BackColor = Color.Black;
            glControlPreview.Flags = OpenTK.Windowing.Common.ContextFlags.Default;
            glControlPreview.IsEventDriven = true;
            glControlPreview.Location = new Point(9, 9);
            glControlPreview.Margin = new Padding(4, 3, 4, 3);
            glControlPreview.Name = "glControlPreview";
            glControlPreview.Profile = OpenTK.Windowing.Common.ContextProfile.Compatability;
            glControlPreview.SharedContext = null;
            glControlPreview.Size = new Size(659, 825);
            glControlPreview.TabIndex = 0;
            glControlPreview.Load += glControlPreview_Load;
            glControlPreview.Paint += glControlPreview_Paint;
            glControlPreview.Resize += glControlPreview_Resize;
            // 
            // flpTrackList
            // 
            flpTrackList.AutoScroll = true;
            flpTrackList.BackColor = Color.Transparent;
            flpTrackList.BorderStyle = BorderStyle.Fixed3D;
            flpTrackList.FlowDirection = FlowDirection.TopDown;
            flpTrackList.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            flpTrackList.Location = new Point(686, 44);
            flpTrackList.Margin = new Padding(4, 3, 4, 3);
            flpTrackList.Name = "flpTrackList";
            flpTrackList.Size = new Size(465, 426);
            flpTrackList.TabIndex = 12;
            flpTrackList.WrapContents = false;
            // 
            // lblList
            // 
            lblList.AutoSize = true;
            lblList.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblList.Location = new Point(680, 12);
            lblList.Margin = new Padding(4, 0, 4, 0);
            lblList.Name = "lblList";
            lblList.Size = new Size(273, 25);
            lblList.TabIndex = 13;
            lblList.Text = "(De)Select Tracks to use";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Transparent;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Image = Properties.Resources.FileSave;
            btnSave.Location = new Point(933, 719);
            btnSave.Margin = new Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(111, 110);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save";
            btnSave.TextAlign = ContentAlignment.BottomCenter;
            btnSave.TextImageRelation = TextImageRelation.ImageAboveText;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnShrinkB
            // 
            btnShrinkB.BackColor = Color.Transparent;
            btnShrinkB.FlatAppearance.BorderSize = 0;
            btnShrinkB.FlatStyle = FlatStyle.Flat;
            btnShrinkB.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShrinkB.Image = Properties.Resources.APlusMinusB;
            btnShrinkB.Location = new Point(931, 590);
            btnShrinkB.Margin = new Padding(4, 3, 4, 3);
            btnShrinkB.Name = "btnShrinkB";
            btnShrinkB.Size = new Size(111, 110);
            btnShrinkB.TabIndex = 10;
            btnShrinkB.Text = "Shrink B";
            btnShrinkB.TextAlign = ContentAlignment.BottomCenter;
            btnShrinkB.UseVisualStyleBackColor = false;
            btnShrinkB.Click += btnShrinkB_Click;
            // 
            // btnShrinkA
            // 
            btnShrinkA.BackColor = Color.Transparent;
            btnShrinkA.FlatAppearance.BorderSize = 0;
            btnShrinkA.FlatStyle = FlatStyle.Flat;
            btnShrinkA.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShrinkA.Image = Properties.Resources.APlusMinusA;
            btnShrinkA.Location = new Point(800, 590);
            btnShrinkA.Margin = new Padding(4, 3, 4, 3);
            btnShrinkA.Name = "btnShrinkA";
            btnShrinkA.Size = new Size(111, 110);
            btnShrinkA.TabIndex = 9;
            btnShrinkA.Text = "Shrink A";
            btnShrinkA.TextAlign = ContentAlignment.BottomCenter;
            btnShrinkA.UseVisualStyleBackColor = false;
            btnShrinkA.Click += btnShrinkA_Click;
            // 
            // btnExtendForward
            // 
            btnExtendForward.BackColor = Color.Transparent;
            btnExtendForward.FlatAppearance.BorderSize = 0;
            btnExtendForward.FlatStyle = FlatStyle.Flat;
            btnExtendForward.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExtendForward.Image = Properties.Resources.APlusPlusB;
            btnExtendForward.Location = new Point(1049, 590);
            btnExtendForward.Margin = new Padding(4, 3, 4, 3);
            btnExtendForward.Name = "btnExtendForward";
            btnExtendForward.Size = new Size(111, 110);
            btnExtendForward.TabIndex = 8;
            btnExtendForward.Text = "Extend B";
            btnExtendForward.TextAlign = ContentAlignment.BottomCenter;
            btnExtendForward.UseVisualStyleBackColor = false;
            btnExtendForward.Click += btnExtendForward_Click;
            // 
            // btnExtendBackward
            // 
            btnExtendBackward.BackColor = Color.Transparent;
            btnExtendBackward.FlatAppearance.BorderSize = 0;
            btnExtendBackward.FlatStyle = FlatStyle.Flat;
            btnExtendBackward.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExtendBackward.Image = Properties.Resources.APlusPlusA;
            btnExtendBackward.Location = new Point(672, 590);
            btnExtendBackward.Margin = new Padding(4, 3, 4, 3);
            btnExtendBackward.Name = "btnExtendBackward";
            btnExtendBackward.Size = new Size(111, 110);
            btnExtendBackward.TabIndex = 7;
            btnExtendBackward.Text = "Extend A";
            btnExtendBackward.TextAlign = ContentAlignment.BottomCenter;
            btnExtendBackward.UseVisualStyleBackColor = false;
            btnExtendBackward.Click += btnExtendBackward_Click;
            // 
            // btnSelectNext
            // 
            btnSelectNext.BackColor = Color.Transparent;
            btnSelectNext.FlatAppearance.BorderSize = 0;
            btnSelectNext.FlatStyle = FlatStyle.Flat;
            btnSelectNext.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSelectNext.Image = Properties.Resources.ArrowRight;
            btnSelectNext.Location = new Point(1049, 473);
            btnSelectNext.Margin = new Padding(4, 3, 4, 3);
            btnSelectNext.Name = "btnSelectNext";
            btnSelectNext.Size = new Size(111, 110);
            btnSelectNext.TabIndex = 6;
            btnSelectNext.Text = "Next";
            btnSelectNext.TextAlign = ContentAlignment.BottomCenter;
            btnSelectNext.TextImageRelation = TextImageRelation.ImageAboveText;
            btnSelectNext.UseVisualStyleBackColor = false;
            btnSelectNext.Click += btnSelectNext_Click;
            // 
            // btnSelectPrevious
            // 
            btnSelectPrevious.BackColor = Color.Transparent;
            btnSelectPrevious.FlatAppearance.BorderSize = 0;
            btnSelectPrevious.FlatStyle = FlatStyle.Flat;
            btnSelectPrevious.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSelectPrevious.Image = Properties.Resources.ArrowLeft;
            btnSelectPrevious.Location = new Point(918, 473);
            btnSelectPrevious.Margin = new Padding(4, 3, 4, 3);
            btnSelectPrevious.Name = "btnSelectPrevious";
            btnSelectPrevious.Size = new Size(111, 110);
            btnSelectPrevious.TabIndex = 5;
            btnSelectPrevious.Text = "Previous";
            btnSelectPrevious.TextAlign = ContentAlignment.BottomCenter;
            btnSelectPrevious.TextImageRelation = TextImageRelation.ImageAboveText;
            btnSelectPrevious.UseVisualStyleBackColor = false;
            btnSelectPrevious.Click += btnSelectPrevious_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Image = Properties.Resources.OK64;
            btnClose.Location = new Point(1051, 719);
            btnClose.Margin = new Padding(4, 3, 4, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(111, 110);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.TextAlign = ContentAlignment.BottomCenter;
            btnClose.TextImageRelation = TextImageRelation.ImageAboveText;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnBuildBoundary
            // 
            btnBuildBoundary.BackColor = Color.Transparent;
            btnBuildBoundary.FlatAppearance.BorderSize = 0;
            btnBuildBoundary.FlatStyle = FlatStyle.Flat;
            btnBuildBoundary.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuildBoundary.Image = Properties.Resources.Boundary;
            btnBuildBoundary.Location = new Point(803, 720);
            btnBuildBoundary.Margin = new Padding(4, 3, 4, 3);
            btnBuildBoundary.Name = "btnBuildBoundary";
            btnBuildBoundary.Size = new Size(111, 110);
            btnBuildBoundary.TabIndex = 3;
            btnBuildBoundary.Text = "Build";
            btnBuildBoundary.TextAlign = ContentAlignment.BottomCenter;
            btnBuildBoundary.TextImageRelation = TextImageRelation.ImageAboveText;
            btnBuildBoundary.UseVisualStyleBackColor = false;
            btnBuildBoundary.Click += btnBuildBoundary_Click;
            // 
            // btnResetPreview
            // 
            btnResetPreview.BackColor = Color.Transparent;
            btnResetPreview.FlatAppearance.BorderSize = 0;
            btnResetPreview.FlatStyle = FlatStyle.Flat;
            btnResetPreview.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnResetPreview.Image = Properties.Resources.Reset_Default;
            btnResetPreview.Location = new Point(674, 719);
            btnResetPreview.Margin = new Padding(4, 3, 4, 3);
            btnResetPreview.Name = "btnResetPreview";
            btnResetPreview.Size = new Size(111, 110);
            btnResetPreview.TabIndex = 2;
            btnResetPreview.Text = "Reset";
            btnResetPreview.TextAlign = ContentAlignment.BottomCenter;
            btnResetPreview.TextImageRelation = TextImageRelation.ImageAboveText;
            btnResetPreview.UseVisualStyleBackColor = false;
            btnResetPreview.Click += btnResetPreview_Click;
            // 
            // btnAutoFind
            // 
            btnAutoFind.BackColor = Color.Transparent;
            btnAutoFind.FlatAppearance.BorderSize = 0;
            btnAutoFind.FlatStyle = FlatStyle.Flat;
            btnAutoFind.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAutoFind.Image = Properties.Resources.ABDraw;
            btnAutoFind.Location = new Point(738, 478);
            btnAutoFind.Margin = new Padding(4, 3, 4, 3);
            btnAutoFind.Name = "btnAutoFind";
            btnAutoFind.Size = new Size(111, 110);
            btnAutoFind.TabIndex = 14;
            btnAutoFind.Text = "Auto Find";
            btnAutoFind.TextAlign = ContentAlignment.BottomCenter;
            btnAutoFind.UseVisualStyleBackColor = false;
            btnAutoFind.Click += btnAutofind_click;
            // 
            // FormBuildBoundaryFromTracks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1176, 841);
            ControlBox = false;
            Controls.Add(btnAutoFind);
            Controls.Add(lblList);
            Controls.Add(flpTrackList);
            Controls.Add(btnSave);
            Controls.Add(btnShrinkB);
            Controls.Add(btnShrinkA);
            Controls.Add(btnExtendForward);
            Controls.Add(btnExtendBackward);
            Controls.Add(btnSelectNext);
            Controls.Add(btnSelectPrevious);
            Controls.Add(btnClose);
            Controls.Add(btnBuildBoundary);
            Controls.Add(btnResetPreview);
            Controls.Add(glControlPreview);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormBuildBoundaryFromTracks";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Build Boundary From Tracks";
            Load += FormBuildBoundaryFromTracks_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private OpenTK.GLControl.GLControl glControlPreview;
        private System.Windows.Forms.Button btnResetPreview;
        private System.Windows.Forms.Button btnBuildBoundary;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSelectPrevious;
        private System.Windows.Forms.Button btnSelectNext;
        private System.Windows.Forms.Button btnExtendBackward;
        private System.Windows.Forms.Button btnExtendForward;
        private System.Windows.Forms.Button btnShrinkA;
        private System.Windows.Forms.Button btnShrinkB;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.FlowLayoutPanel flpTrackList;
        private System.Windows.Forms.Label lblList;
        private Button btnAutoFind;
    }
}
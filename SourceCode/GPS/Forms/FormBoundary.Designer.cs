﻿namespace AgOpenGPS
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Around = new System.Windows.Forms.Label();
            this.Boundary = new System.Windows.Forms.Label();
            this.Thru = new System.Windows.Forms.Label();
            this.Area = new System.Windows.Forms.Label();
            this.btnLeftRight = new System.Windows.Forms.Button();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnDriveOrExt = new System.Windows.Forms.Button();
            this.btnLoadMultiBoundaryFromGE = new System.Windows.Forms.Button();
            this.btnLoadBoundaryFromGE = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSerialCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 142F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 66);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(530, 363);
            this.tableLayoutPanel1.TabIndex = 205;
            // 
            // Around
            // 
            this.Around.BackColor = System.Drawing.Color.Transparent;
            this.Around.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Around.Location = new System.Drawing.Point(441, 14);
            this.Around.Margin = new System.Windows.Forms.Padding(0);
            this.Around.Name = "Around";
            this.Around.Size = new System.Drawing.Size(90, 49);
            this.Around.TabIndex = 204;
            this.Around.Text = "Around?";
            this.Around.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Boundary
            // 
            this.Boundary.BackColor = System.Drawing.Color.Transparent;
            this.Boundary.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boundary.Location = new System.Drawing.Point(18, 14);
            this.Boundary.Name = "Boundary";
            this.Boundary.Size = new System.Drawing.Size(150, 49);
            this.Boundary.TabIndex = 203;
            this.Boundary.Text = "Bounds";
            this.Boundary.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Thru
            // 
            this.Thru.BackColor = System.Drawing.Color.Transparent;
            this.Thru.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thru.Location = new System.Drawing.Point(340, 14);
            this.Thru.Name = "Thru";
            this.Thru.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Thru.Size = new System.Drawing.Size(80, 49);
            this.Thru.TabIndex = 202;
            this.Thru.Text = "Thru?";
            this.Thru.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Area
            // 
            this.Area.BackColor = System.Drawing.Color.Transparent;
            this.Area.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Area.Location = new System.Drawing.Point(176, 14);
            this.Area.Name = "Area";
            this.Area.Size = new System.Drawing.Size(116, 49);
            this.Area.TabIndex = 201;
            this.Area.Text = "Area";
            this.Area.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnLeftRight
            // 
            this.btnLeftRight.Enabled = false;
            this.btnLeftRight.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnLeftRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeftRight.Image = global::AgOpenGPS.Properties.Resources.BoundaryLeft;
            this.btnLeftRight.Location = new System.Drawing.Point(193, 451);
            this.btnLeftRight.Name = "btnLeftRight";
            this.btnLeftRight.Size = new System.Drawing.Size(91, 84);
            this.btnLeftRight.TabIndex = 67;
            this.btnLeftRight.UseVisualStyleBackColor = true;
            this.btnLeftRight.Click += new System.EventHandler(this.btnLeftRight_Click);
            // 
            // btnGo
            // 
            this.btnGo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGo.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGo.Enabled = false;
            this.btnGo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGo.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGo.Image = global::AgOpenGPS.Properties.Resources.AutoGo;
            this.btnGo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGo.Location = new System.Drawing.Point(368, 451);
            this.btnGo.Margin = new System.Windows.Forms.Padding(5);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(91, 84);
            this.btnGo.TabIndex = 63;
            this.btnGo.Text = "Go";
            this.btnGo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGo.UseVisualStyleBackColor = true;
            // 
            // btnDriveOrExt
            // 
            this.btnDriveOrExt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDriveOrExt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDriveOrExt.Image = global::AgOpenGPS.Properties.Resources.BoundaryDriveOrLoad;
            this.btnDriveOrExt.Location = new System.Drawing.Point(12, 451);
            this.btnDriveOrExt.Name = "btnDriveOrExt";
            this.btnDriveOrExt.Size = new System.Drawing.Size(91, 84);
            this.btnDriveOrExt.TabIndex = 212;
            this.btnDriveOrExt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDriveOrExt.UseVisualStyleBackColor = true;
            this.btnDriveOrExt.Click += new System.EventHandler(this.btnDriveOrExt_Click);
            // 
            // btnLoadMultiBoundaryFromGE
            // 
            this.btnLoadMultiBoundaryFromGE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadMultiBoundaryFromGE.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadMultiBoundaryFromGE.Image = global::AgOpenGPS.Properties.Resources.BoundaryLoadMultiFromGE;
            this.btnLoadMultiBoundaryFromGE.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLoadMultiBoundaryFromGE.Location = new System.Drawing.Point(351, 452);
            this.btnLoadMultiBoundaryFromGE.Name = "btnLoadMultiBoundaryFromGE";
            this.btnLoadMultiBoundaryFromGE.Size = new System.Drawing.Size(91, 84);
            this.btnLoadMultiBoundaryFromGE.TabIndex = 211;
            this.btnLoadMultiBoundaryFromGE.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLoadMultiBoundaryFromGE.UseVisualStyleBackColor = true;
            this.btnLoadMultiBoundaryFromGE.Visible = false;
            this.btnLoadMultiBoundaryFromGE.Click += new System.EventHandler(this.btnLoadBoundaryFromGE_Click);
            // 
            // btnLoadBoundaryFromGE
            // 
            this.btnLoadBoundaryFromGE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadBoundaryFromGE.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadBoundaryFromGE.Image = global::AgOpenGPS.Properties.Resources.BoundaryLoadFromGE;
            this.btnLoadBoundaryFromGE.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLoadBoundaryFromGE.Location = new System.Drawing.Point(177, 451);
            this.btnLoadBoundaryFromGE.Name = "btnLoadBoundaryFromGE";
            this.btnLoadBoundaryFromGE.Size = new System.Drawing.Size(91, 84);
            this.btnLoadBoundaryFromGE.TabIndex = 210;
            this.btnLoadBoundaryFromGE.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLoadBoundaryFromGE.UseVisualStyleBackColor = true;
            this.btnLoadBoundaryFromGE.Visible = false;
            this.btnLoadBoundaryFromGE.Click += new System.EventHandler(this.btnLoadBoundaryFromGE_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.btnCancel.Image = global::AgOpenGPS.Properties.Resources.Cancel64;
            this.btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCancel.Location = new System.Drawing.Point(567, 345);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 84);
            this.btnCancel.TabIndex = 206;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAll.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAll.Image = global::AgOpenGPS.Properties.Resources.BoundaryDeleteAll;
            this.btnDeleteAll.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDeleteAll.Location = new System.Drawing.Point(580, 66);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(78, 68);
            this.btnDeleteAll.TabIndex = 100;
            this.btnDeleteAll.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDeleteAll.UseVisualStyleBackColor = true;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Image = global::AgOpenGPS.Properties.Resources.BoundaryDelete;
            this.btnDelete.Location = new System.Drawing.Point(580, 207);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(78, 68);
            this.btnDelete.TabIndex = 65;
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSerialCancel
            // 
            this.btnSerialCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSerialCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSerialCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSerialCancel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSerialCancel.Image = global::AgOpenGPS.Properties.Resources.OK64;
            this.btnSerialCancel.Location = new System.Drawing.Point(537, 452);
            this.btnSerialCancel.Margin = new System.Windows.Forms.Padding(5);
            this.btnSerialCancel.Name = "btnSerialCancel";
            this.btnSerialCancel.Size = new System.Drawing.Size(121, 84);
            this.btnSerialCancel.TabIndex = 64;
            this.btnSerialCancel.UseVisualStyleBackColor = true;
            this.btnSerialCancel.Click += new System.EventHandler(this.btnSerialCancel_Click);
            // 
            // FormBoundary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(674, 559);
            this.ControlBox = false;
            this.Controls.Add(this.btnLeftRight);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.btnDriveOrExt);
            this.Controls.Add(this.btnLoadMultiBoundaryFromGE);
            this.Controls.Add(this.btnLoadBoundaryFromGE);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.Around);
            this.Controls.Add(this.Boundary);
            this.Controls.Add(this.Thru);
            this.Controls.Add(this.Area);
            this.Controls.Add(this.btnDeleteAll);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSerialCancel);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormBoundary";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Start or Delete A Boundary";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormBoundary_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSerialCancel;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnLeftRight;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDeleteAll;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Around;
        private System.Windows.Forms.Label Boundary;
        private System.Windows.Forms.Label Thru;
        private System.Windows.Forms.Label Area;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnLoadMultiBoundaryFromGE;
        private System.Windows.Forms.Button btnLoadBoundaryFromGE;
        private System.Windows.Forms.Button btnDriveOrExt;
    }
}
namespace AgOpenGPS.Forms.Config
{
    partial class ConfigVehicleControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblOpacityPercent = new System.Windows.Forms.Label();
            labelVehicleGroupBox = new System.Windows.Forms.GroupBox();
            rbtnHarvester = new System.Windows.Forms.RadioButton();
            rbtnArticulated = new System.Windows.Forms.RadioButton();
            rbtnTractor = new System.Windows.Forms.RadioButton();
            panelArticulatedBrands = new System.Windows.Forms.Panel();
            rbtnBrandAHolder = new System.Windows.Forms.RadioButton();
            rbtnBrandAAgOpenGPS = new System.Windows.Forms.RadioButton();
            rbtnBrandAChallenger = new System.Windows.Forms.RadioButton();
            rbtnBrandACase = new System.Windows.Forms.RadioButton();
            rbtnBrandANH = new System.Windows.Forms.RadioButton();
            rbtnBrandAJDeere = new System.Windows.Forms.RadioButton();
            labelOpacity = new System.Windows.Forms.Label();
            panelHarvesterBrands = new System.Windows.Forms.Panel();
            rbtnBrandHAgOpenGPS = new System.Windows.Forms.RadioButton();
            rbtnBrandHCase = new System.Windows.Forms.RadioButton();
            rbtnBrandHClaas = new System.Windows.Forms.RadioButton();
            rbtnBrandHJDeere = new System.Windows.Forms.RadioButton();
            rbtnBrandHNH = new System.Windows.Forms.RadioButton();
            panelTractorBrands = new System.Windows.Forms.Panel();
            rbtnBrandTJCB = new System.Windows.Forms.RadioButton();
            rbtnBrandTAgOpenGPS = new System.Windows.Forms.RadioButton();
            rbtnBrandTCase = new System.Windows.Forms.RadioButton();
            rbtnBrandTClaas = new System.Windows.Forms.RadioButton();
            rbtnBrandTDeutz = new System.Windows.Forms.RadioButton();
            rbtnBrandTFendt = new System.Windows.Forms.RadioButton();
            rbtnBrandTJDeere = new System.Windows.Forms.RadioButton();
            rbtnBrandTKubota = new System.Windows.Forms.RadioButton();
            rbtnBrandTMassey = new System.Windows.Forms.RadioButton();
            rbtnBrandTNH = new System.Windows.Forms.RadioButton();
            rbtnBrandTSame = new System.Windows.Forms.RadioButton();
            rbtnBrandTSteyr = new System.Windows.Forms.RadioButton();
            rbtnBrandTValtra = new System.Windows.Forms.RadioButton();
            rbtnBrandTUrsus = new System.Windows.Forms.RadioButton();
            btnOpacityDn = new System.Windows.Forms.Button();
            panelOpacity = new System.Windows.Forms.Panel();
            pboxAlpha = new System.Windows.Forms.PictureBox();
            btnOpacityUp = new System.Windows.Forms.Button();
            cboxIsImage = new System.Windows.Forms.CheckBox();
            labelImage = new System.Windows.Forms.Label();
            labelVehicleGroupBox.SuspendLayout();
            panelArticulatedBrands.SuspendLayout();
            panelHarvesterBrands.SuspendLayout();
            panelTractorBrands.SuspendLayout();
            panelOpacity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pboxAlpha).BeginInit();
            SuspendLayout();
            // 
            // lblOpacityPercent
            // 
            lblOpacityPercent.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblOpacityPercent.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblOpacityPercent.ForeColor = System.Drawing.Color.Black;
            lblOpacityPercent.Location = new System.Drawing.Point(631, 453);
            lblOpacityPercent.Name = "lblOpacityPercent";
            lblOpacityPercent.Size = new System.Drawing.Size(139, 45);
            lblOpacityPercent.TabIndex = 541;
            lblOpacityPercent.Text = "100%";
            lblOpacityPercent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelVehicleGroupBox
            // 
            labelVehicleGroupBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelVehicleGroupBox.BackColor = System.Drawing.Color.Transparent;
            labelVehicleGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            labelVehicleGroupBox.Controls.Add(rbtnHarvester);
            labelVehicleGroupBox.Controls.Add(rbtnArticulated);
            labelVehicleGroupBox.Controls.Add(rbtnTractor);
            labelVehicleGroupBox.ForeColor = System.Drawing.Color.Black;
            labelVehicleGroupBox.Location = new System.Drawing.Point(24, -9);
            labelVehicleGroupBox.Name = "labelVehicleGroupBox";
            labelVehicleGroupBox.Size = new System.Drawing.Size(516, 122);
            labelVehicleGroupBox.TabIndex = 536;
            labelVehicleGroupBox.TabStop = false;
            labelVehicleGroupBox.Text = "Choose Vehicle Type";
            // 
            // rbtnHarvester
            // 
            rbtnHarvester.Appearance = System.Windows.Forms.Appearance.Button;
            rbtnHarvester.BackgroundImage = Properties.Resources.vehiclePageHarvester;
            rbtnHarvester.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            rbtnHarvester.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            rbtnHarvester.FlatAppearance.BorderSize = 0;
            rbtnHarvester.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            rbtnHarvester.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rbtnHarvester.Location = new System.Drawing.Point(16, 27);
            rbtnHarvester.Name = "rbtnHarvester";
            rbtnHarvester.Size = new System.Drawing.Size(127, 83);
            rbtnHarvester.TabIndex = 253;
            rbtnHarvester.UseVisualStyleBackColor = true;
            rbtnHarvester.Click += rbtnHarvester_Click;
            // 
            // rbtnArticulated
            // 
            rbtnArticulated.Appearance = System.Windows.Forms.Appearance.Button;
            rbtnArticulated.BackgroundImage = Properties.Resources.vehiclePageArticulated;
            rbtnArticulated.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            rbtnArticulated.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            rbtnArticulated.FlatAppearance.BorderSize = 0;
            rbtnArticulated.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            rbtnArticulated.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rbtnArticulated.Location = new System.Drawing.Point(366, 27);
            rbtnArticulated.Name = "rbtnArticulated";
            rbtnArticulated.Size = new System.Drawing.Size(127, 83);
            rbtnArticulated.TabIndex = 252;
            rbtnArticulated.UseVisualStyleBackColor = true;
            rbtnArticulated.Click += rbtnArticulated_Click;
            // 
            // rbtnTractor
            // 
            rbtnTractor.Appearance = System.Windows.Forms.Appearance.Button;
            rbtnTractor.BackgroundImage = Properties.Resources.vehiclePageTractor;
            rbtnTractor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            rbtnTractor.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            rbtnTractor.Checked = true;
            rbtnTractor.FlatAppearance.BorderSize = 0;
            rbtnTractor.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            rbtnTractor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rbtnTractor.Location = new System.Drawing.Point(192, 27);
            rbtnTractor.Name = "rbtnTractor";
            rbtnTractor.Size = new System.Drawing.Size(127, 83);
            rbtnTractor.TabIndex = 112;
            rbtnTractor.TabStop = true;
            rbtnTractor.UseVisualStyleBackColor = true;
            rbtnTractor.Click += rbtnTractor_Click;
            // 
            // panelArticulatedBrands
            // 
            panelArticulatedBrands.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            panelArticulatedBrands.Controls.Add(rbtnBrandAHolder);
            panelArticulatedBrands.Controls.Add(rbtnBrandAAgOpenGPS);
            panelArticulatedBrands.Controls.Add(rbtnBrandAChallenger);
            panelArticulatedBrands.Controls.Add(rbtnBrandACase);
            panelArticulatedBrands.Controls.Add(rbtnBrandANH);
            panelArticulatedBrands.Controls.Add(rbtnBrandAJDeere);
            panelArticulatedBrands.Location = new System.Drawing.Point(412, 115);
            panelArticulatedBrands.Name = "panelArticulatedBrands";
            panelArticulatedBrands.Size = new System.Drawing.Size(80, 467);
            panelArticulatedBrands.TabIndex = 539;
            // 
            // rbtnBrandAHolder
            // 
            rbtnBrandAHolder.Appearance = System.Windows.Forms.Appearance.Button;
            rbtnBrandAHolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            rbtnBrandAHolder.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            rbtnBrandAHolder.Checked = true;
            rbtnBrandAHolder.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            rbtnBrandAHolder.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            rbtnBrandAHolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rbtnBrandAHolder.Image = ResourcesBrands.BrandImages.BrandHolder;
            rbtnBrandAHolder.Location = new System.Drawing.Point(8, 395);
            rbtnBrandAHolder.Name = "rbtnBrandAHolder";
            rbtnBrandAHolder.Size = new System.Drawing.Size(64, 64);
            rbtnBrandAHolder.TabIndex = 136;
            rbtnBrandAHolder.TabStop = true;
            rbtnBrandAHolder.Tag = Core.Models.ArticulatedBrand.Holder;
            rbtnBrandAHolder.UseVisualStyleBackColor = true;
            rbtnBrandAHolder.CheckedChanged += rbtnArticulatedBrand_CheckedChanged;
            // 
            // rbtnBrandAAgOpenGPS
            // 
            rbtnBrandAAgOpenGPS.Appearance = System.Windows.Forms.Appearance.Button;
            rbtnBrandAAgOpenGPS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            rbtnBrandAAgOpenGPS.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            rbtnBrandAAgOpenGPS.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            rbtnBrandAAgOpenGPS.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            rbtnBrandAAgOpenGPS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rbtnBrandAAgOpenGPS.Image = ResourcesBrands.BrandImages.BrandAoG;
            rbtnBrandAAgOpenGPS.Location = new System.Drawing.Point(8, 6);
            rbtnBrandAAgOpenGPS.Name = "rbtnBrandAAgOpenGPS";
            rbtnBrandAAgOpenGPS.Size = new System.Drawing.Size(64, 64);
            rbtnBrandAAgOpenGPS.TabIndex = 131;
            rbtnBrandAAgOpenGPS.Tag = Core.Models.ArticulatedBrand.AgOpenGPS;
            rbtnBrandAAgOpenGPS.UseVisualStyleBackColor = true;
            rbtnBrandAAgOpenGPS.CheckedChanged += rbtnArticulatedBrand_CheckedChanged;
            // 
            // rbtnBrandAChallenger
            // 
            rbtnBrandAChallenger.Appearance = System.Windows.Forms.Appearance.Button;
            rbtnBrandAChallenger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            rbtnBrandAChallenger.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            rbtnBrandAChallenger.Checked = true;
            rbtnBrandAChallenger.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            rbtnBrandAChallenger.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            rbtnBrandAChallenger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rbtnBrandAChallenger.Image = ResourcesBrands.BrandImages.BrandChallenger;
            rbtnBrandAChallenger.Location = new System.Drawing.Point(8, 84);
            rbtnBrandAChallenger.Name = "rbtnBrandAChallenger";
            rbtnBrandAChallenger.Size = new System.Drawing.Size(64, 64);
            rbtnBrandAChallenger.TabIndex = 132;
            rbtnBrandAChallenger.TabStop = true;
            rbtnBrandAChallenger.Tag = Core.Models.ArticulatedBrand.Challenger;
            rbtnBrandAChallenger.UseVisualStyleBackColor = true;
            rbtnBrandAChallenger.CheckedChanged += rbtnArticulatedBrand_CheckedChanged;
            // 
            // rbtnBrandACase
            // 
            rbtnBrandACase.Appearance = System.Windows.Forms.Appearance.Button;
            rbtnBrandACase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            rbtnBrandACase.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            rbtnBrandACase.Checked = true;
            rbtnBrandACase.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            rbtnBrandACase.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            rbtnBrandACase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rbtnBrandACase.Image = ResourcesBrands.BrandImages.BrandCase;
            rbtnBrandACase.Location = new System.Drawing.Point(8, 162);
            rbtnBrandACase.Name = "rbtnBrandACase";
            rbtnBrandACase.Size = new System.Drawing.Size(64, 64);
            rbtnBrandACase.TabIndex = 133;
            rbtnBrandACase.TabStop = true;
            rbtnBrandACase.Tag = Core.Models.ArticulatedBrand.Case;
            rbtnBrandACase.UseVisualStyleBackColor = true;
            rbtnBrandACase.CheckedChanged += rbtnArticulatedBrand_CheckedChanged;
            // 
            // rbtnBrandANH
            // 
            rbtnBrandANH.Appearance = System.Windows.Forms.Appearance.Button;
            rbtnBrandANH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            rbtnBrandANH.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            rbtnBrandANH.Checked = true;
            rbtnBrandANH.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            rbtnBrandANH.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            rbtnBrandANH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rbtnBrandANH.Image = ResourcesBrands.BrandImages.BrandNewHolland;
            rbtnBrandANH.Location = new System.Drawing.Point(8, 318);
            rbtnBrandANH.Name = "rbtnBrandANH";
            rbtnBrandANH.Size = new System.Drawing.Size(64, 64);
            rbtnBrandANH.TabIndex = 135;
            rbtnBrandANH.TabStop = true;
            rbtnBrandANH.Tag = Core.Models.ArticulatedBrand.NewHolland;
            rbtnBrandANH.UseVisualStyleBackColor = true;
            rbtnBrandANH.CheckedChanged += rbtnArticulatedBrand_CheckedChanged;
            // 
            // rbtnBrandAJDeere
            // 
            rbtnBrandAJDeere.Appearance = System.Windows.Forms.Appearance.Button;
            rbtnBrandAJDeere.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            rbtnBrandAJDeere.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            rbtnBrandAJDeere.Checked = true;
            rbtnBrandAJDeere.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            rbtnBrandAJDeere.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            rbtnBrandAJDeere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rbtnBrandAJDeere.Image = ResourcesBrands.BrandImages.BrandJohnDeere;
            rbtnBrandAJDeere.Location = new System.Drawing.Point(8, 240);
            rbtnBrandAJDeere.Name = "rbtnBrandAJDeere";
            rbtnBrandAJDeere.Size = new System.Drawing.Size(64, 64);
            rbtnBrandAJDeere.TabIndex = 134;
            rbtnBrandAJDeere.TabStop = true;
            rbtnBrandAJDeere.Tag = Core.Models.ArticulatedBrand.JohnDeere;
            rbtnBrandAJDeere.UseVisualStyleBackColor = true;
            rbtnBrandAJDeere.CheckedChanged += rbtnArticulatedBrand_CheckedChanged;
            // 
            // labelOpacity
            // 
            labelOpacity.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelOpacity.AutoSize = true;
            labelOpacity.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelOpacity.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            labelOpacity.Location = new System.Drawing.Point(665, 422);
            labelOpacity.Name = "labelOpacity";
            labelOpacity.Size = new System.Drawing.Size(70, 19);
            labelOpacity.TabIndex = 540;
            labelOpacity.Text = "Opacity";
            // 
            // panelHarvesterBrands
            // 
            panelHarvesterBrands.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            panelHarvesterBrands.Controls.Add(rbtnBrandHAgOpenGPS);
            panelHarvesterBrands.Controls.Add(rbtnBrandHCase);
            panelHarvesterBrands.Controls.Add(rbtnBrandHClaas);
            panelHarvesterBrands.Controls.Add(rbtnBrandHJDeere);
            panelHarvesterBrands.Controls.Add(rbtnBrandHNH);
            panelHarvesterBrands.Location = new System.Drawing.Point(59, 115);
            panelHarvesterBrands.Name = "panelHarvesterBrands";
            panelHarvesterBrands.Size = new System.Drawing.Size(80, 467);
            panelHarvesterBrands.TabIndex = 538;
            // 
            // rbtnBrandHAgOpenGPS
            // 
            rbtnBrandHAgOpenGPS.Appearance = System.Windows.Forms.Appearance.Button;
            rbtnBrandHAgOpenGPS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            rbtnBrandHAgOpenGPS.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            rbtnBrandHAgOpenGPS.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            rbtnBrandHAgOpenGPS.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            rbtnBrandHAgOpenGPS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rbtnBrandHAgOpenGPS.Image = ResourcesBrands.BrandImages.BrandAoG;
            rbtnBrandHAgOpenGPS.Location = new System.Drawing.Point(8, 6);
            rbtnBrandHAgOpenGPS.Name = "rbtnBrandHAgOpenGPS";
            rbtnBrandHAgOpenGPS.Size = new System.Drawing.Size(64, 64);
            rbtnBrandHAgOpenGPS.TabIndex = 127;
            rbtnBrandHAgOpenGPS.Tag = Core.Models.HarvesterBrand.AgOpenGPS;
            rbtnBrandHAgOpenGPS.UseVisualStyleBackColor = true;
            rbtnBrandHAgOpenGPS.CheckedChanged += rbtnHarvesterBrand_CheckedChanged;
            // 
            // rbtnBrandHCase
            // 
            rbtnBrandHCase.Appearance = System.Windows.Forms.Appearance.Button;
            rbtnBrandHCase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            rbtnBrandHCase.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            rbtnBrandHCase.Checked = true;
            rbtnBrandHCase.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            rbtnBrandHCase.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            rbtnBrandHCase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rbtnBrandHCase.Image = ResourcesBrands.BrandImages.BrandCase;
            rbtnBrandHCase.Location = new System.Drawing.Point(8, 102);
            rbtnBrandHCase.Name = "rbtnBrandHCase";
            rbtnBrandHCase.Size = new System.Drawing.Size(64, 64);
            rbtnBrandHCase.TabIndex = 114;
            rbtnBrandHCase.TabStop = true;
            rbtnBrandHCase.Tag = Core.Models.HarvesterBrand.Case;
            rbtnBrandHCase.UseVisualStyleBackColor = true;
            rbtnBrandHCase.CheckedChanged += rbtnHarvesterBrand_CheckedChanged;
            // 
            // rbtnBrandHClaas
            // 
            rbtnBrandHClaas.Appearance = System.Windows.Forms.Appearance.Button;
            rbtnBrandHClaas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            rbtnBrandHClaas.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            rbtnBrandHClaas.Checked = true;
            rbtnBrandHClaas.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            rbtnBrandHClaas.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            rbtnBrandHClaas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rbtnBrandHClaas.Image = ResourcesBrands.BrandImages.BrandClaas;
            rbtnBrandHClaas.Location = new System.Drawing.Point(8, 198);
            rbtnBrandHClaas.Name = "rbtnBrandHClaas";
            rbtnBrandHClaas.Size = new System.Drawing.Size(64, 64);
            rbtnBrandHClaas.TabIndex = 116;
            rbtnBrandHClaas.TabStop = true;
            rbtnBrandHClaas.Tag = Core.Models.HarvesterBrand.Claas;
            rbtnBrandHClaas.UseVisualStyleBackColor = true;
            rbtnBrandHClaas.CheckedChanged += rbtnHarvesterBrand_CheckedChanged;
            // 
            // rbtnBrandHJDeere
            // 
            rbtnBrandHJDeere.Appearance = System.Windows.Forms.Appearance.Button;
            rbtnBrandHJDeere.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            rbtnBrandHJDeere.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            rbtnBrandHJDeere.Checked = true;
            rbtnBrandHJDeere.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            rbtnBrandHJDeere.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            rbtnBrandHJDeere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rbtnBrandHJDeere.Image = ResourcesBrands.BrandImages.BrandJohnDeere;
            rbtnBrandHJDeere.Location = new System.Drawing.Point(8, 294);
            rbtnBrandHJDeere.Name = "rbtnBrandHJDeere";
            rbtnBrandHJDeere.Size = new System.Drawing.Size(64, 64);
            rbtnBrandHJDeere.TabIndex = 129;
            rbtnBrandHJDeere.TabStop = true;
            rbtnBrandHJDeere.Tag = Core.Models.HarvesterBrand.JohnDeere;
            rbtnBrandHJDeere.UseVisualStyleBackColor = true;
            rbtnBrandHJDeere.CheckedChanged += rbtnHarvesterBrand_CheckedChanged;
            // 
            // rbtnBrandHNH
            // 
            rbtnBrandHNH.Appearance = System.Windows.Forms.Appearance.Button;
            rbtnBrandHNH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            rbtnBrandHNH.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            rbtnBrandHNH.Checked = true;
            rbtnBrandHNH.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            rbtnBrandHNH.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            rbtnBrandHNH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rbtnBrandHNH.Image = ResourcesBrands.BrandImages.BrandNewHolland;
            rbtnBrandHNH.Location = new System.Drawing.Point(8, 390);
            rbtnBrandHNH.Name = "rbtnBrandHNH";
            rbtnBrandHNH.Size = new System.Drawing.Size(64, 64);
            rbtnBrandHNH.TabIndex = 130;
            rbtnBrandHNH.TabStop = true;
            rbtnBrandHNH.Tag = Core.Models.HarvesterBrand.NewHolland;
            rbtnBrandHNH.UseVisualStyleBackColor = true;
            rbtnBrandHNH.CheckedChanged += rbtnHarvesterBrand_CheckedChanged;
            // 
            // panelTractorBrands
            // 
            panelTractorBrands.AccessibleName = "";
            panelTractorBrands.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            panelTractorBrands.Controls.Add(rbtnBrandTJCB);
            panelTractorBrands.Controls.Add(rbtnBrandTAgOpenGPS);
            panelTractorBrands.Controls.Add(rbtnBrandTCase);
            panelTractorBrands.Controls.Add(rbtnBrandTClaas);
            panelTractorBrands.Controls.Add(rbtnBrandTDeutz);
            panelTractorBrands.Controls.Add(rbtnBrandTFendt);
            panelTractorBrands.Controls.Add(rbtnBrandTJDeere);
            panelTractorBrands.Controls.Add(rbtnBrandTKubota);
            panelTractorBrands.Controls.Add(rbtnBrandTMassey);
            panelTractorBrands.Controls.Add(rbtnBrandTNH);
            panelTractorBrands.Controls.Add(rbtnBrandTSame);
            panelTractorBrands.Controls.Add(rbtnBrandTSteyr);
            panelTractorBrands.Controls.Add(rbtnBrandTValtra);
            panelTractorBrands.Controls.Add(rbtnBrandTUrsus);
            panelTractorBrands.Location = new System.Drawing.Point(131, 115);
            panelTractorBrands.Name = "panelTractorBrands";
            panelTractorBrands.Size = new System.Drawing.Size(289, 467);
            panelTractorBrands.TabIndex = 537;
            // 
            // rbtnBrandTJCB
            // 
            rbtnBrandTJCB.Appearance = System.Windows.Forms.Appearance.Button;
            rbtnBrandTJCB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            rbtnBrandTJCB.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            rbtnBrandTJCB.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            rbtnBrandTJCB.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            rbtnBrandTJCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rbtnBrandTJCB.Image = ResourcesBrands.BrandImages.BrandJCB;
            rbtnBrandTJCB.Location = new System.Drawing.Point(13, 6);
            rbtnBrandTJCB.Name = "rbtnBrandTJCB";
            rbtnBrandTJCB.Size = new System.Drawing.Size(64, 64);
            rbtnBrandTJCB.TabIndex = 127;
            rbtnBrandTJCB.Tag = Core.Models.TractorBrand.JCB;
            rbtnBrandTJCB.UseVisualStyleBackColor = true;
            rbtnBrandTJCB.CheckedChanged += rbtnTractorBrand_CheckedChanged;
            // 
            // rbtnBrandTAgOpenGPS
            // 
            rbtnBrandTAgOpenGPS.Appearance = System.Windows.Forms.Appearance.Button;
            rbtnBrandTAgOpenGPS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            rbtnBrandTAgOpenGPS.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            rbtnBrandTAgOpenGPS.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            rbtnBrandTAgOpenGPS.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            rbtnBrandTAgOpenGPS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rbtnBrandTAgOpenGPS.Image = ResourcesBrands.BrandImages.BrandAoG;
            rbtnBrandTAgOpenGPS.Location = new System.Drawing.Point(112, 6);
            rbtnBrandTAgOpenGPS.Name = "rbtnBrandTAgOpenGPS";
            rbtnBrandTAgOpenGPS.Size = new System.Drawing.Size(64, 64);
            rbtnBrandTAgOpenGPS.TabIndex = 126;
            rbtnBrandTAgOpenGPS.Tag = Core.Models.TractorBrand.AGOpenGPS;
            rbtnBrandTAgOpenGPS.UseVisualStyleBackColor = true;
            rbtnBrandTAgOpenGPS.CheckedChanged += rbtnTractorBrand_CheckedChanged;
            // 
            // rbtnBrandTCase
            // 
            rbtnBrandTCase.Appearance = System.Windows.Forms.Appearance.Button;
            rbtnBrandTCase.BackgroundImage = ResourcesBrands.BrandImages.BrandCase;
            rbtnBrandTCase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            rbtnBrandTCase.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            rbtnBrandTCase.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            rbtnBrandTCase.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            rbtnBrandTCase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rbtnBrandTCase.Location = new System.Drawing.Point(13, 102);
            rbtnBrandTCase.Name = "rbtnBrandTCase";
            rbtnBrandTCase.Size = new System.Drawing.Size(64, 64);
            rbtnBrandTCase.TabIndex = 114;
            rbtnBrandTCase.Tag = Core.Models.TractorBrand.Case;
            rbtnBrandTCase.UseVisualStyleBackColor = true;
            rbtnBrandTCase.CheckedChanged += rbtnTractorBrand_CheckedChanged;
            // 
            // rbtnBrandTClaas
            // 
            rbtnBrandTClaas.Appearance = System.Windows.Forms.Appearance.Button;
            rbtnBrandTClaas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            rbtnBrandTClaas.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            rbtnBrandTClaas.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            rbtnBrandTClaas.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            rbtnBrandTClaas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rbtnBrandTClaas.Image = ResourcesBrands.BrandImages.BrandClaas;
            rbtnBrandTClaas.Location = new System.Drawing.Point(112, 102);
            rbtnBrandTClaas.Name = "rbtnBrandTClaas";
            rbtnBrandTClaas.Size = new System.Drawing.Size(64, 64);
            rbtnBrandTClaas.TabIndex = 115;
            rbtnBrandTClaas.Tag = Core.Models.TractorBrand.Claas;
            rbtnBrandTClaas.UseVisualStyleBackColor = true;
            rbtnBrandTClaas.CheckedChanged += rbtnTractorBrand_CheckedChanged;
            // 
            // rbtnBrandTDeutz
            // 
            rbtnBrandTDeutz.Appearance = System.Windows.Forms.Appearance.Button;
            rbtnBrandTDeutz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            rbtnBrandTDeutz.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            rbtnBrandTDeutz.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            rbtnBrandTDeutz.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            rbtnBrandTDeutz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rbtnBrandTDeutz.Image = ResourcesBrands.BrandImages.BrandDeutz;
            rbtnBrandTDeutz.Location = new System.Drawing.Point(211, 102);
            rbtnBrandTDeutz.Name = "rbtnBrandTDeutz";
            rbtnBrandTDeutz.Size = new System.Drawing.Size(64, 64);
            rbtnBrandTDeutz.TabIndex = 116;
            rbtnBrandTDeutz.Tag = Core.Models.TractorBrand.Deutz;
            rbtnBrandTDeutz.UseVisualStyleBackColor = true;
            rbtnBrandTDeutz.CheckedChanged += rbtnTractorBrand_CheckedChanged;
            // 
            // rbtnBrandTFendt
            // 
            rbtnBrandTFendt.Appearance = System.Windows.Forms.Appearance.Button;
            rbtnBrandTFendt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            rbtnBrandTFendt.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            rbtnBrandTFendt.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            rbtnBrandTFendt.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            rbtnBrandTFendt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rbtnBrandTFendt.Image = ResourcesBrands.BrandImages.BrandFendt;
            rbtnBrandTFendt.Location = new System.Drawing.Point(13, 390);
            rbtnBrandTFendt.Name = "rbtnBrandTFendt";
            rbtnBrandTFendt.Size = new System.Drawing.Size(64, 64);
            rbtnBrandTFendt.TabIndex = 117;
            rbtnBrandTFendt.Tag = Core.Models.TractorBrand.Fendt;
            rbtnBrandTFendt.UseVisualStyleBackColor = true;
            rbtnBrandTFendt.CheckedChanged += rbtnTractorBrand_CheckedChanged;
            // 
            // rbtnBrandTJDeere
            // 
            rbtnBrandTJDeere.Appearance = System.Windows.Forms.Appearance.Button;
            rbtnBrandTJDeere.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            rbtnBrandTJDeere.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            rbtnBrandTJDeere.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            rbtnBrandTJDeere.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            rbtnBrandTJDeere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rbtnBrandTJDeere.Image = ResourcesBrands.BrandImages.BrandJohnDeere;
            rbtnBrandTJDeere.Location = new System.Drawing.Point(211, 294);
            rbtnBrandTJDeere.Name = "rbtnBrandTJDeere";
            rbtnBrandTJDeere.Size = new System.Drawing.Size(64, 64);
            rbtnBrandTJDeere.TabIndex = 118;
            rbtnBrandTJDeere.Tag = Core.Models.TractorBrand.JohnDeere;
            rbtnBrandTJDeere.UseVisualStyleBackColor = true;
            rbtnBrandTJDeere.CheckedChanged += rbtnTractorBrand_CheckedChanged;
            // 
            // rbtnBrandTKubota
            // 
            rbtnBrandTKubota.Appearance = System.Windows.Forms.Appearance.Button;
            rbtnBrandTKubota.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            rbtnBrandTKubota.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            rbtnBrandTKubota.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            rbtnBrandTKubota.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            rbtnBrandTKubota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rbtnBrandTKubota.Image = ResourcesBrands.BrandImages.BrandKubota;
            rbtnBrandTKubota.Location = new System.Drawing.Point(211, 390);
            rbtnBrandTKubota.Name = "rbtnBrandTKubota";
            rbtnBrandTKubota.Size = new System.Drawing.Size(64, 64);
            rbtnBrandTKubota.TabIndex = 119;
            rbtnBrandTKubota.Tag = Core.Models.TractorBrand.Kubota;
            rbtnBrandTKubota.UseVisualStyleBackColor = true;
            rbtnBrandTKubota.CheckedChanged += rbtnTractorBrand_CheckedChanged;
            // 
            // rbtnBrandTMassey
            // 
            rbtnBrandTMassey.Appearance = System.Windows.Forms.Appearance.Button;
            rbtnBrandTMassey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            rbtnBrandTMassey.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            rbtnBrandTMassey.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            rbtnBrandTMassey.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            rbtnBrandTMassey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rbtnBrandTMassey.Image = ResourcesBrands.BrandImages.BrandMassey;
            rbtnBrandTMassey.Location = new System.Drawing.Point(13, 198);
            rbtnBrandTMassey.Name = "rbtnBrandTMassey";
            rbtnBrandTMassey.Size = new System.Drawing.Size(64, 64);
            rbtnBrandTMassey.TabIndex = 120;
            rbtnBrandTMassey.Tag = Core.Models.TractorBrand.Massey;
            rbtnBrandTMassey.UseVisualStyleBackColor = true;
            rbtnBrandTMassey.CheckedChanged += rbtnTractorBrand_CheckedChanged;
            // 
            // rbtnBrandTNH
            // 
            rbtnBrandTNH.Appearance = System.Windows.Forms.Appearance.Button;
            rbtnBrandTNH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            rbtnBrandTNH.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            rbtnBrandTNH.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            rbtnBrandTNH.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            rbtnBrandTNH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rbtnBrandTNH.Image = ResourcesBrands.BrandImages.BrandNewHolland;
            rbtnBrandTNH.Location = new System.Drawing.Point(112, 198);
            rbtnBrandTNH.Name = "rbtnBrandTNH";
            rbtnBrandTNH.Size = new System.Drawing.Size(64, 64);
            rbtnBrandTNH.TabIndex = 121;
            rbtnBrandTNH.Tag = Core.Models.TractorBrand.NewHolland;
            rbtnBrandTNH.UseVisualStyleBackColor = true;
            rbtnBrandTNH.CheckedChanged += rbtnTractorBrand_CheckedChanged;
            // 
            // rbtnBrandTSame
            // 
            rbtnBrandTSame.Appearance = System.Windows.Forms.Appearance.Button;
            rbtnBrandTSame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            rbtnBrandTSame.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            rbtnBrandTSame.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            rbtnBrandTSame.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            rbtnBrandTSame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rbtnBrandTSame.Image = ResourcesBrands.BrandImages.BrandSame;
            rbtnBrandTSame.Location = new System.Drawing.Point(211, 198);
            rbtnBrandTSame.Name = "rbtnBrandTSame";
            rbtnBrandTSame.Size = new System.Drawing.Size(64, 64);
            rbtnBrandTSame.TabIndex = 122;
            rbtnBrandTSame.Tag = Core.Models.TractorBrand.Same;
            rbtnBrandTSame.UseVisualStyleBackColor = true;
            rbtnBrandTSame.CheckedChanged += rbtnTractorBrand_CheckedChanged;
            // 
            // rbtnBrandTSteyr
            // 
            rbtnBrandTSteyr.Appearance = System.Windows.Forms.Appearance.Button;
            rbtnBrandTSteyr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            rbtnBrandTSteyr.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            rbtnBrandTSteyr.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            rbtnBrandTSteyr.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            rbtnBrandTSteyr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rbtnBrandTSteyr.Image = ResourcesBrands.BrandImages.BrandSteyr;
            rbtnBrandTSteyr.Location = new System.Drawing.Point(112, 390);
            rbtnBrandTSteyr.Name = "rbtnBrandTSteyr";
            rbtnBrandTSteyr.Size = new System.Drawing.Size(64, 64);
            rbtnBrandTSteyr.TabIndex = 123;
            rbtnBrandTSteyr.Tag = Core.Models.TractorBrand.Steyr;
            rbtnBrandTSteyr.UseVisualStyleBackColor = true;
            rbtnBrandTSteyr.CheckedChanged += rbtnTractorBrand_CheckedChanged;
            // 
            // rbtnBrandTValtra
            // 
            rbtnBrandTValtra.Appearance = System.Windows.Forms.Appearance.Button;
            rbtnBrandTValtra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            rbtnBrandTValtra.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            rbtnBrandTValtra.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            rbtnBrandTValtra.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            rbtnBrandTValtra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rbtnBrandTValtra.Image = ResourcesBrands.BrandImages.BrandValtra;
            rbtnBrandTValtra.Location = new System.Drawing.Point(112, 294);
            rbtnBrandTValtra.Name = "rbtnBrandTValtra";
            rbtnBrandTValtra.Size = new System.Drawing.Size(64, 64);
            rbtnBrandTValtra.TabIndex = 125;
            rbtnBrandTValtra.Tag = Core.Models.TractorBrand.Valtra;
            rbtnBrandTValtra.UseVisualStyleBackColor = true;
            rbtnBrandTValtra.CheckedChanged += rbtnTractorBrand_CheckedChanged;
            // 
            // rbtnBrandTUrsus
            // 
            rbtnBrandTUrsus.Appearance = System.Windows.Forms.Appearance.Button;
            rbtnBrandTUrsus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            rbtnBrandTUrsus.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            rbtnBrandTUrsus.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            rbtnBrandTUrsus.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            rbtnBrandTUrsus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rbtnBrandTUrsus.Image = ResourcesBrands.BrandImages.BrandUrsus;
            rbtnBrandTUrsus.Location = new System.Drawing.Point(13, 294);
            rbtnBrandTUrsus.Name = "rbtnBrandTUrsus";
            rbtnBrandTUrsus.Size = new System.Drawing.Size(64, 64);
            rbtnBrandTUrsus.TabIndex = 124;
            rbtnBrandTUrsus.Tag = Core.Models.TractorBrand.Ursus;
            rbtnBrandTUrsus.UseVisualStyleBackColor = true;
            rbtnBrandTUrsus.CheckedChanged += rbtnTractorBrand_CheckedChanged;
            // 
            // btnOpacityDn
            // 
            btnOpacityDn.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnOpacityDn.BackColor = System.Drawing.Color.Transparent;
            btnOpacityDn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            btnOpacityDn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnOpacityDn.Image = Properties.Resources.DnArrow64;
            btnOpacityDn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnOpacityDn.Location = new System.Drawing.Point(555, 438);
            btnOpacityDn.Name = "btnOpacityDn";
            btnOpacityDn.Size = new System.Drawing.Size(73, 72);
            btnOpacityDn.TabIndex = 544;
            btnOpacityDn.UseVisualStyleBackColor = false;
            btnOpacityDn.Click += btnOpacityDn_Click;
            // 
            // panelOpacity
            // 
            panelOpacity.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            panelOpacity.BackColor = System.Drawing.Color.MistyRose;
            panelOpacity.BackgroundImage = Properties.Resources.VehicleOpacity;
            panelOpacity.Controls.Add(pboxAlpha);
            panelOpacity.Location = new System.Drawing.Point(571, 144);
            panelOpacity.Name = "panelOpacity";
            panelOpacity.Size = new System.Drawing.Size(256, 256);
            panelOpacity.TabIndex = 545;
            // 
            // pboxAlpha
            // 
            pboxAlpha.BackColor = System.Drawing.Color.Transparent;
            pboxAlpha.BackgroundImage = ResourcesBrands.BrandImages.TractorDeutz;
            pboxAlpha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pboxAlpha.Dock = System.Windows.Forms.DockStyle.Fill;
            pboxAlpha.Location = new System.Drawing.Point(0, 0);
            pboxAlpha.Name = "pboxAlpha";
            pboxAlpha.Size = new System.Drawing.Size(256, 256);
            pboxAlpha.TabIndex = 484;
            pboxAlpha.TabStop = false;
            // 
            // btnOpacityUp
            // 
            btnOpacityUp.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnOpacityUp.BackColor = System.Drawing.Color.Transparent;
            btnOpacityUp.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            btnOpacityUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnOpacityUp.Image = Properties.Resources.UpArrow64;
            btnOpacityUp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnOpacityUp.Location = new System.Drawing.Point(773, 438);
            btnOpacityUp.Name = "btnOpacityUp";
            btnOpacityUp.Size = new System.Drawing.Size(73, 72);
            btnOpacityUp.TabIndex = 543;
            btnOpacityUp.UseVisualStyleBackColor = false;
            btnOpacityUp.Click += btnOpacityUp_Click;
            // 
            // cboxIsImage
            // 
            cboxIsImage.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            cboxIsImage.Appearance = System.Windows.Forms.Appearance.Button;
            cboxIsImage.BackColor = System.Drawing.Color.Transparent;
            cboxIsImage.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            cboxIsImage.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            cboxIsImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboxIsImage.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cboxIsImage.ForeColor = System.Drawing.SystemColors.ControlText;
            cboxIsImage.Image = ResourcesBrands.BrandImages.BrandTriangleVehicle;
            cboxIsImage.Location = new System.Drawing.Point(651, 17);
            cboxIsImage.Name = "cboxIsImage";
            cboxIsImage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            cboxIsImage.Size = new System.Drawing.Size(96, 96);
            cboxIsImage.TabIndex = 542;
            cboxIsImage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            cboxIsImage.UseVisualStyleBackColor = false;
            cboxIsImage.Click += cboxIsImage_Click;
            // 
            // labelImage
            // 
            labelImage.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelImage.AutoSize = true;
            labelImage.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelImage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            labelImage.Location = new System.Drawing.Point(653, -9);
            labelImage.Name = "labelImage";
            labelImage.Size = new System.Drawing.Size(88, 19);
            labelImage.TabIndex = 546;
            labelImage.Text = "No Image";
            // 
            // ConfigVehicleControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.WhiteSmoke;
            Controls.Add(lblOpacityPercent);
            Controls.Add(labelVehicleGroupBox);
            Controls.Add(panelArticulatedBrands);
            Controls.Add(labelOpacity);
            Controls.Add(panelHarvesterBrands);
            Controls.Add(panelTractorBrands);
            Controls.Add(labelImage);
            Controls.Add(btnOpacityDn);
            Controls.Add(panelOpacity);
            Controls.Add(btnOpacityUp);
            Controls.Add(cboxIsImage);
            Font = new System.Drawing.Font("Tahoma", 9.75F);
            Name = "ConfigVehicleControl";
            Size = new System.Drawing.Size(859, 584);
            labelVehicleGroupBox.ResumeLayout(false);
            panelArticulatedBrands.ResumeLayout(false);
            panelHarvesterBrands.ResumeLayout(false);
            panelTractorBrands.ResumeLayout(false);
            panelOpacity.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pboxAlpha).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOpacityPercent;
        private System.Windows.Forms.GroupBox labelVehicleGroupBox;
        private System.Windows.Forms.RadioButton rbtnHarvester;
        private System.Windows.Forms.RadioButton rbtnArticulated;
        private System.Windows.Forms.RadioButton rbtnTractor;
        private System.Windows.Forms.Panel panelArticulatedBrands;
        private System.Windows.Forms.RadioButton rbtnBrandAHolder;
        private System.Windows.Forms.RadioButton rbtnBrandAAgOpenGPS;
        private System.Windows.Forms.RadioButton rbtnBrandAChallenger;
        private System.Windows.Forms.RadioButton rbtnBrandACase;
        private System.Windows.Forms.RadioButton rbtnBrandANH;
        private System.Windows.Forms.RadioButton rbtnBrandAJDeere;
        private System.Windows.Forms.Label labelOpacity;
        private System.Windows.Forms.Panel panelHarvesterBrands;
        private System.Windows.Forms.RadioButton rbtnBrandHAgOpenGPS;
        private System.Windows.Forms.RadioButton rbtnBrandHCase;
        private System.Windows.Forms.RadioButton rbtnBrandHClaas;
        private System.Windows.Forms.RadioButton rbtnBrandHJDeere;
        private System.Windows.Forms.RadioButton rbtnBrandHNH;
        private System.Windows.Forms.Panel panelTractorBrands;
        private System.Windows.Forms.RadioButton rbtnBrandTJCB;
        private System.Windows.Forms.RadioButton rbtnBrandTAgOpenGPS;
        private System.Windows.Forms.RadioButton rbtnBrandTCase;
        private System.Windows.Forms.RadioButton rbtnBrandTClaas;
        private System.Windows.Forms.RadioButton rbtnBrandTDeutz;
        private System.Windows.Forms.RadioButton rbtnBrandTFendt;
        private System.Windows.Forms.RadioButton rbtnBrandTJDeere;
        private System.Windows.Forms.RadioButton rbtnBrandTKubota;
        private System.Windows.Forms.RadioButton rbtnBrandTMassey;
        private System.Windows.Forms.RadioButton rbtnBrandTNH;
        private System.Windows.Forms.RadioButton rbtnBrandTSame;
        private System.Windows.Forms.RadioButton rbtnBrandTSteyr;
        private System.Windows.Forms.RadioButton rbtnBrandTValtra;
        private System.Windows.Forms.RadioButton rbtnBrandTUrsus;
        private System.Windows.Forms.Button btnOpacityDn;
        private System.Windows.Forms.Panel panelOpacity;
        private System.Windows.Forms.PictureBox pboxAlpha;
        private System.Windows.Forms.Button btnOpacityUp;
        private System.Windows.Forms.CheckBox cboxIsImage;
        private System.Windows.Forms.Label labelImage;
    }
}

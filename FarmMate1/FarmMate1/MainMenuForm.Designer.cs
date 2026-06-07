

//MainMenuForm.Designer.cs
namespace FarmMate1
{
    partial class frmMainMenu
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

        #region Windows Form Designer generated code   //nothing so especial here yet

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnFncAndSales = new System.Windows.Forms.Button();
            this.btnInvtrAndSupp = new System.Windows.Forms.Button();
            this.btnEqmtAndMchn = new System.Windows.Forms.Button();
            this.btnLiveStocks = new System.Windows.Forms.Button();
            this.btnCrops = new System.Windows.Forms.Button();
            this.btnFacilities = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.labelFarmMate = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.labelHOME = new System.Windows.Forms.Label();
            this.panelDesktoPane = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.OliveDrab;
            this.panelMenu.Controls.Add(this.btnSettings);
            this.panelMenu.Controls.Add(this.btnFncAndSales);
            this.panelMenu.Controls.Add(this.btnInvtrAndSupp);
            this.panelMenu.Controls.Add(this.btnEqmtAndMchn);
            this.panelMenu.Controls.Add(this.btnLiveStocks);
            this.panelMenu.Controls.Add(this.btnCrops);
            this.panelMenu.Controls.Add(this.btnFacilities);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(170, 561);
            this.panelMenu.TabIndex = 1;
            // 
            // btnSettings
            // 
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Image = global::FarmMate1.Properties.Resources.Picsart_25_05_20_21_28_40_857;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(0, 450);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(170, 60);
            this.btnSettings.TabIndex = 9;
            this.btnSettings.Text = "  Settings";
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnFncAndSales
            // 
            this.btnFncAndSales.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFncAndSales.FlatAppearance.BorderSize = 0;
            this.btnFncAndSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFncAndSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFncAndSales.ForeColor = System.Drawing.Color.White;
            this.btnFncAndSales.Image = global::FarmMate1.Properties.Resources.Picsart_25_05_20_21_25_50_3261;
            this.btnFncAndSales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFncAndSales.Location = new System.Drawing.Point(0, 390);
            this.btnFncAndSales.Name = "btnFncAndSales";
            this.btnFncAndSales.Size = new System.Drawing.Size(170, 60);
            this.btnFncAndSales.TabIndex = 8;
            this.btnFncAndSales.Text = " Finance and Sales";
            this.btnFncAndSales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFncAndSales.UseVisualStyleBackColor = true;
            this.btnFncAndSales.Click += new System.EventHandler(this.btnFncAndSales_Click);
            // 
            // btnInvtrAndSupp
            // 
            this.btnInvtrAndSupp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInvtrAndSupp.FlatAppearance.BorderSize = 0;
            this.btnInvtrAndSupp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvtrAndSupp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvtrAndSupp.ForeColor = System.Drawing.Color.White;
            this.btnInvtrAndSupp.Image = global::FarmMate1.Properties.Resources.Picsart_25_05_21_16_38_46_078;
            this.btnInvtrAndSupp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInvtrAndSupp.Location = new System.Drawing.Point(0, 330);
            this.btnInvtrAndSupp.Name = "btnInvtrAndSupp";
            this.btnInvtrAndSupp.Size = new System.Drawing.Size(170, 60);
            this.btnInvtrAndSupp.TabIndex = 6;
            this.btnInvtrAndSupp.Text = " Inventory and Supplies";
            this.btnInvtrAndSupp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInvtrAndSupp.UseVisualStyleBackColor = true;
            this.btnInvtrAndSupp.Click += new System.EventHandler(this.btnInvtrAndSupp_Click);
            // 
            // btnEqmtAndMchn
            // 
            this.btnEqmtAndMchn.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEqmtAndMchn.FlatAppearance.BorderSize = 0;
            this.btnEqmtAndMchn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEqmtAndMchn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEqmtAndMchn.ForeColor = System.Drawing.Color.White;
            this.btnEqmtAndMchn.Image = global::FarmMate1.Properties.Resources.agricultureTractor_icon_png_2788;
            this.btnEqmtAndMchn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEqmtAndMchn.Location = new System.Drawing.Point(0, 270);
            this.btnEqmtAndMchn.Name = "btnEqmtAndMchn";
            this.btnEqmtAndMchn.Size = new System.Drawing.Size(170, 60);
            this.btnEqmtAndMchn.TabIndex = 5;
            this.btnEqmtAndMchn.Text = " Equipment and Machineries";
            this.btnEqmtAndMchn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEqmtAndMchn.UseVisualStyleBackColor = true;
            this.btnEqmtAndMchn.Click += new System.EventHandler(this.btnEqmtAndMchn_Click);
            // 
            // btnLiveStocks
            // 
            this.btnLiveStocks.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLiveStocks.FlatAppearance.BorderSize = 0;
            this.btnLiveStocks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLiveStocks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLiveStocks.ForeColor = System.Drawing.Color.White;
            this.btnLiveStocks.Image = global::FarmMate1.Properties.Resources.Picsart_25_05_18_16_23_01_848;
            this.btnLiveStocks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLiveStocks.Location = new System.Drawing.Point(0, 210);
            this.btnLiveStocks.Name = "btnLiveStocks";
            this.btnLiveStocks.Size = new System.Drawing.Size(170, 60);
            this.btnLiveStocks.TabIndex = 4;
            this.btnLiveStocks.Text = " LiveStocks";
            this.btnLiveStocks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLiveStocks.UseVisualStyleBackColor = true;
            this.btnLiveStocks.Click += new System.EventHandler(this.btnLiveStocks_Click);
            // 
            // btnCrops
            // 
            this.btnCrops.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCrops.FlatAppearance.BorderSize = 0;
            this.btnCrops.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrops.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrops.ForeColor = System.Drawing.Color.White;
            this.btnCrops.Image = global::FarmMate1.Properties.Resources.Picsart_25_05_18_23_29_03_295;
            this.btnCrops.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrops.Location = new System.Drawing.Point(0, 150);
            this.btnCrops.Name = "btnCrops";
            this.btnCrops.Size = new System.Drawing.Size(170, 60);
            this.btnCrops.TabIndex = 3;
            this.btnCrops.Text = " Crops";
            this.btnCrops.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCrops.UseVisualStyleBackColor = true;
            this.btnCrops.Click += new System.EventHandler(this.btnCrops_Click);
            // 
            // btnFacilities
            // 
            this.btnFacilities.BackColor = System.Drawing.Color.OliveDrab;
            this.btnFacilities.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFacilities.FlatAppearance.BorderSize = 0;
            this.btnFacilities.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacilities.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacilities.ForeColor = System.Drawing.Color.White;
            this.btnFacilities.Image = global::FarmMate1.Properties.Resources._119301;
            this.btnFacilities.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFacilities.Location = new System.Drawing.Point(0, 90);
            this.btnFacilities.Name = "btnFacilities";
            this.btnFacilities.Size = new System.Drawing.Size(170, 60);
            this.btnFacilities.TabIndex = 2;
            this.btnFacilities.Text = " Facilities";
            this.btnFacilities.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFacilities.UseVisualStyleBackColor = false;
            this.btnFacilities.Click += new System.EventHandler(this.btnFacilities_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panelLogo.Controls.Add(this.labelFarmMate);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(170, 90);
            this.panelLogo.TabIndex = 1;
            // 
            // labelFarmMate
            // 
            this.labelFarmMate.AutoSize = true;
            this.labelFarmMate.BackColor = System.Drawing.Color.Transparent;
            this.labelFarmMate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelFarmMate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFarmMate.ForeColor = System.Drawing.Color.White;
            this.labelFarmMate.Location = new System.Drawing.Point(25, 35);
            this.labelFarmMate.Name = "labelFarmMate";
            this.labelFarmMate.Size = new System.Drawing.Size(119, 27);
            this.labelFarmMate.TabIndex = 0;
            this.labelFarmMate.Text = "FarmMate";
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.OliveDrab;
            this.panelTitleBar.Controls.Add(this.labelHOME);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(170, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(934, 90);
            this.panelTitleBar.TabIndex = 2;
            // 
            // labelHOME
            // 
            this.labelHOME.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelHOME.AutoSize = true;
            this.labelHOME.BackColor = System.Drawing.Color.Transparent;
            this.labelHOME.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHOME.ForeColor = System.Drawing.Color.White;
            this.labelHOME.Location = new System.Drawing.Point(410, 32);
            this.labelHOME.Name = "labelHOME";
            this.labelHOME.Size = new System.Drawing.Size(85, 28);
            this.labelHOME.TabIndex = 0;
            this.labelHOME.Text = "HOME";
            // 
            // panelDesktoPane
            // 
            this.panelDesktoPane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDesktoPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktoPane.Location = new System.Drawing.Point(170, 90);
            this.panelDesktoPane.Name = "panelDesktoPane";
            this.panelDesktoPane.Size = new System.Drawing.Size(934, 471);
            this.panelDesktoPane.TabIndex = 3;
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 561);
            this.Controls.Add(this.panelDesktoPane);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "frmMainMenu";
            this.Text = "MainMenu";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnFncAndSales;
        private System.Windows.Forms.Button btnInvtrAndSupp;
        private System.Windows.Forms.Button btnEqmtAndMchn;
        private System.Windows.Forms.Button btnLiveStocks;
        private System.Windows.Forms.Button btnCrops;
        private System.Windows.Forms.Button btnFacilities;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label labelHOME;
        private System.Windows.Forms.Label labelFarmMate;
        private System.Windows.Forms.Panel panelDesktoPane;
    }
}


//FormLiveStocks.Designer.cs
namespace FarmMate1.Forms
{
    partial class FormLiveStocks
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support – do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        
        private void InitializeComponent()
        {
            this.txtNameCode = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.cmbSpecie = new System.Windows.Forms.ComboBox();
            this.labelSpecie = new System.Windows.Forms.Label();
            this.cmbBreed = new System.Windows.Forms.ComboBox();
            this.labelBreed = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddAnimal = new System.Windows.Forms.Button();
            this.userCtrl_AnimalPnl1 = new FarmMate1.UserCtrl_AnimalPnl();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNameCode
            // 
            this.txtNameCode.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtNameCode.Location = new System.Drawing.Point(26, 39);
            this.txtNameCode.Name = "txtNameCode";
            this.txtNameCode.Size = new System.Drawing.Size(148, 25);
            this.txtNameCode.TabIndex = 0;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelName.Location = new System.Drawing.Point(23, 16);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(85, 17);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name (code)";
            // 
            // cmbSpecie
            // 
            this.cmbSpecie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSpecie.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmbSpecie.FormattingEnabled = true;
            this.cmbSpecie.Location = new System.Drawing.Point(229, 39);
            this.cmbSpecie.Name = "cmbSpecie";
            this.cmbSpecie.Size = new System.Drawing.Size(148, 25);
            this.cmbSpecie.TabIndex = 2;
            // 
            // labelSpecie
            // 
            this.labelSpecie.AutoSize = true;
            this.labelSpecie.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelSpecie.Location = new System.Drawing.Point(226, 16);
            this.labelSpecie.Name = "labelSpecie";
            this.labelSpecie.Size = new System.Drawing.Size(46, 17);
            this.labelSpecie.TabIndex = 3;
            this.labelSpecie.Text = "Specie";
            // 
            // cmbBreed
            // 
            this.cmbBreed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBreed.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmbBreed.FormattingEnabled = true;
            this.cmbBreed.Location = new System.Drawing.Point(429, 39);
            this.cmbBreed.Name = "cmbBreed";
            this.cmbBreed.Size = new System.Drawing.Size(148, 25);
            this.cmbBreed.TabIndex = 4;
            // 
            // labelBreed
            // 
            this.labelBreed.AutoSize = true;
            this.labelBreed.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelBreed.Location = new System.Drawing.Point(426, 16);
            this.labelBreed.Name = "labelBreed";
            this.labelBreed.Size = new System.Drawing.Size(43, 17);
            this.labelBreed.TabIndex = 5;
            this.labelBreed.Text = "Breed";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSearch.Location = new System.Drawing.Point(738, 36);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(93, 28);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.userCtrl_AnimalPnl1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 83);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(935, 377);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // btnAddAnimal
            // 
            this.btnAddAnimal.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAddAnimal.Location = new System.Drawing.Point(837, 36);
            this.btnAddAnimal.Name = "btnAddAnimal";
            this.btnAddAnimal.Size = new System.Drawing.Size(73, 28);
            this.btnAddAnimal.TabIndex = 10;
            this.btnAddAnimal.Text = "  ADD+";
            this.btnAddAnimal.UseVisualStyleBackColor = true;
            this.btnAddAnimal.Click += new System.EventHandler(this.btnAddAnimal_Click);
            // 
            // userCtrl_AnimalPnl1
            // 
            this.userCtrl_AnimalPnl1.BackColor = System.Drawing.Color.YellowGreen;
            this.userCtrl_AnimalPnl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userCtrl_AnimalPnl1.Location = new System.Drawing.Point(3, 3);
            this.userCtrl_AnimalPnl1.Name = "userCtrl_AnimalPnl1";
            this.userCtrl_AnimalPnl1.Size = new System.Drawing.Size(451, 229);
            this.userCtrl_AnimalPnl1.TabIndex = 0;
            this.userCtrl_AnimalPnl1.Load += new System.EventHandler(this.userCtrl_AnimalPnl1_Load);
            // 
            // FormLiveStocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 475);
            this.Controls.Add(this.btnAddAnimal);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.labelBreed);
            this.Controls.Add(this.cmbBreed);
            this.Controls.Add(this.labelSpecie);
            this.Controls.Add(this.cmbSpecie);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.txtNameCode);
            this.Name = "FormLiveStocks";
            this.Text = "LiveStocks";
            this.Load += new System.EventHandler(this.FormLiveStocks_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNameCode;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.ComboBox cmbSpecie;
        private System.Windows.Forms.Label labelSpecie;
        private System.Windows.Forms.ComboBox cmbBreed;
        private System.Windows.Forms.Label labelBreed;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnAddAnimal;
        private UserCtrl_AnimalPnl userCtrl_AnimalPnl1;
    }
}

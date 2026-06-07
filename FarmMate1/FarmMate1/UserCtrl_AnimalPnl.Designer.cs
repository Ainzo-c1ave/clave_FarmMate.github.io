//UserCtrl_AnimalPnl.Designer.cs
using System;
using System.Windows.Forms;
using System.Drawing;

namespace FarmMate1
{
    partial class UserCtrl_AnimalPnl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

       
        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblSpecie = new System.Windows.Forms.Label();
            this.lblBreed = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.txtBoxLocation = new System.Windows.Forms.TextBox();
            this.txtBoxBirthDate = new System.Windows.Forms.TextBox();
            this.txtBoxSpecie = new System.Windows.Forms.TextBox();
            this.txtBoxBreed = new System.Windows.Forms.TextBox();
            this.btbSave = new System.Windows.Forms.Button();
            this.picBoxAnimal = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAnimal)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(272, 8);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 15;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(353, 8);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(82, 23);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            //this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblSpecie
            // 
            this.lblSpecie.AutoSize = true;
            this.lblSpecie.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecie.Location = new System.Drawing.Point(17, 169);
            this.lblSpecie.Name = "lblSpecie";
            this.lblSpecie.Size = new System.Drawing.Size(56, 20);
            this.lblSpecie.TabIndex = 13;
            this.lblSpecie.Text = "Specie:";
            // 
            // lblBreed
            // 
            this.lblBreed.AutoSize = true;
            this.lblBreed.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBreed.Location = new System.Drawing.Point(17, 136);
            this.lblBreed.Name = "lblBreed";
            this.lblBreed.Size = new System.Drawing.Size(51, 20);
            this.lblBreed.TabIndex = 12;
            this.lblBreed.Text = "Breed:";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(17, 103);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(69, 20);
            this.lblLocation.TabIndex = 11;
            this.lblLocation.Text = "Location:";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthDate.Location = new System.Drawing.Point(17, 70);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(75, 20);
            this.lblBirthDate.TabIndex = 10;
            this.lblBirthDate.Text = "BirthDate:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(17, 37);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 20);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Name:";
            // 
            // txtBoxName
            // 
            this.txtBoxName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxName.Location = new System.Drawing.Point(65, 34);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(148, 27);
            this.txtBoxName.TabIndex = 16;
            // 
            // txtBoxLocation
            // 
            this.txtBoxLocation.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxLocation.Location = new System.Drawing.Point(82, 100);
            this.txtBoxLocation.Name = "txtBoxLocation";
            this.txtBoxLocation.Size = new System.Drawing.Size(131, 27);
            this.txtBoxLocation.TabIndex = 17;
            // 
            // txtBoxBirthDate
            // 
            this.txtBoxBirthDate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxBirthDate.Location = new System.Drawing.Point(89, 67);
            this.txtBoxBirthDate.Name = "txtBoxBirthDate";
            this.txtBoxBirthDate.Size = new System.Drawing.Size(124, 27);
            this.txtBoxBirthDate.TabIndex = 18;
            // 
            // txtBoxSpecie
            // 
            this.txtBoxSpecie.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSpecie.Location = new System.Drawing.Point(70, 166);
            this.txtBoxSpecie.Name = "txtBoxSpecie";
            this.txtBoxSpecie.Size = new System.Drawing.Size(143, 27);
            this.txtBoxSpecie.TabIndex = 19;
            // 
            // txtBoxBreed
            // 
            this.txtBoxBreed.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxBreed.Location = new System.Drawing.Point(65, 133);
            this.txtBoxBreed.Name = "txtBoxBreed";
            this.txtBoxBreed.Size = new System.Drawing.Size(148, 27);
            this.txtBoxBreed.TabIndex = 20;
            // 
            // btbSave
            // 
            this.btbSave.Location = new System.Drawing.Point(191, 8);
            this.btbSave.Name = "btbSave";
            this.btbSave.Size = new System.Drawing.Size(75, 23);
            this.btbSave.TabIndex = 21;
            this.btbSave.Text = "Save";
            this.btbSave.UseVisualStyleBackColor = true;
            this.btbSave.Click += new System.EventHandler(this.btbSave_Click);
            // 
            // picBoxAnimal
            // 
            this.picBoxAnimal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picBoxAnimal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxAnimal.Location = new System.Drawing.Point(233, 32);
            this.picBoxAnimal.Name = "picBoxAnimal";
            this.picBoxAnimal.Size = new System.Drawing.Size(200, 180);
            this.picBoxAnimal.TabIndex = 9;
            this.picBoxAnimal.TabStop = false;
            this.picBoxAnimal.Click += new System.EventHandler(this.picBoxAnimal_Click);
            // 
            // UserCtrl_AnimalPnl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btbSave);
            this.Controls.Add(this.txtBoxBreed);
            this.Controls.Add(this.txtBoxSpecie);
            this.Controls.Add(this.txtBoxBirthDate);
            this.Controls.Add(this.txtBoxLocation);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblSpecie);
            this.Controls.Add(this.lblBreed);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.picBoxAnimal);
            this.Controls.Add(this.lblName);
            this.Name = "UserCtrl_AnimalPnl";
            this.Size = new System.Drawing.Size(451, 229);
            this.Load += new System.EventHandler(this.UserCtrl_AnimalPnl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAnimal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblSpecie;
        private System.Windows.Forms.Label lblBreed;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.PictureBox picBoxAnimal;
        private System.Windows.Forms.Label lblName;
        private TextBox txtBoxName;
        private TextBox txtBoxLocation;
        private TextBox txtBoxBirthDate;
        private TextBox txtBoxSpecie;
        private TextBox txtBoxBreed;
        private Button btbSave;
    }
}

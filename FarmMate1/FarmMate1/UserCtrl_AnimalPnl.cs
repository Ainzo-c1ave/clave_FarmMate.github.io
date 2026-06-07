//UserCtrl_AnimalPnl.cs
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FarmMate1;

namespace FarmMate1
{
    public partial class UserCtrl_AnimalPnl : UserControl
    {
        // When in "new/add" mode, this event tells FormLiveStocks about the new Animal
        public event EventHandler<Animal> AnimalSaved;
        public event EventHandler<Animal> DeleteRequested;

        private Animal animalData;
        public bool IsNewMode { get; private set; } = false; // Expose a flag so FormLiveStocks can tell if this panel is “Add New”
        private bool isEditing = false; // Track whether we are currently editing (either in Add or Update)

        public UserCtrl_AnimalPnl()
        {
            InitializeComponent();
           
            EnterDisplayMode();

            btnEdit.Click += btnEdit_Click;
            btbSave.Click += btbSave_Click;
            btnDelete.Click += btnDelete_Click;       // ◀ Wire up Delete
            picBoxAnimal.Click += picBoxAnimal_Click;
        }

        /// <summary>
        /// Call this method to switch into “Add New Animal” mode.
        /// It immediately shows all textboxes and renames the Save button to “Add”;
        /// hides labels & Edit/Delete buttons.
        /// </summary>
        public void EnterNewMode()
        {
            IsNewMode = true;
            isEditing = true;

            // Hide labels
            //lblName.Visible = false;
            //lblBirthDate.Visible = false;
            //lblLocation.Visible = false;
            //lblBreed.Visible = false;
            //lblSpecie.Visible = false;

            // Show textboxes (initially blank)
            txtBoxName.Visible = true; txtBoxName.Text = "";
            txtBoxBirthDate.Visible = true; txtBoxBirthDate.Text = "";
            txtBoxLocation.Visible = true; txtBoxLocation.Text = "";
            txtBoxBreed.Visible = true; txtBoxBreed.Text = "";
            txtBoxSpecie.Visible = true; txtBoxSpecie.Text = "";

            // Hide/Edit/Delete in new mode
            btnEdit.Visible = false;
            btnDelete.Visible = false;

            btbSave.Visible = true;
            btbSave.Text = "Save";
          
        }

        /// <summary>
        /// Call this method to switch into normal “display” mode (or after adding).
        /// </summary>
        public void EnterDisplayMode()
        {
            isEditing = false;
            IsNewMode = false;

            // Hide textboxes
            txtBoxName.Visible = false;
            txtBoxBirthDate.Visible = false;
            txtBoxLocation.Visible = false;
            txtBoxBreed.Visible = false;
            txtBoxSpecie.Visible = false;

            // Show labels
            lblName.Visible = true;
            lblBirthDate.Visible = true;
            lblLocation.Visible = true;
            lblBreed.Visible = true;
            lblSpecie.Visible = true;

            // Show/Edit/Delete
            btnEdit.Visible = true;
            btnDelete.Visible = true;

            // Hide Save
            btbSave.Visible = false;
        }

        /// <summary>
        /// Call this from your form to populate the panel with existing animal data.
        /// (This automatically sets display mode.)
        /// </summary>
        public void SetAnimalData(Animal a)
        {
            animalData = a;
            EnterDisplayMode();

            lblName.Text = "Name: " + a.Name;
            lblBirthDate.Text = "BirthDate: " + a.BirthDate;
            lblLocation.Text = "Location: " + a.Location;
            lblBreed.Text = "Breed: " + a.Breed;
            lblSpecie.Text = "Specie: " + a.Specie;

            picBoxAnimal.Image = a.Picture;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (IsNewMode)
                return;

            isEditing = true;

            // Pre-fill textboxes from labels (strip prefixes)
            txtBoxName.Text = lblName.Text.Replace("Name: ", "");
            txtBoxBirthDate.Text = lblBirthDate.Text.Replace("BirthDate: ", "");
            txtBoxLocation.Text = lblLocation.Text.Replace("Location: ", "");
            txtBoxBreed.Text = lblBreed.Text.Replace("Breed: ", "");
            txtBoxSpecie.Text = lblSpecie.Text.Replace("Specie: ", "");

            // Show textboxes & hide labels
            txtBoxName.Visible = true;
            txtBoxBirthDate.Visible = true;
            txtBoxLocation.Visible = true;
            txtBoxBreed.Visible = true;
            txtBoxSpecie.Visible = true;

            //lblName.Visible = false; Dont Wanna Hide THis Mate
            //lblBirthDate.Visible = false;
            //lblLocation.Visible = false;
            //lblBreed.Visible = false;
            //lblSpecie.Visible = false;

            btnEdit.Visible = false;
            btbSave.Visible = true;  // Save in “update” mode
        }

        private void btbSave_Click(object sender, EventArgs e)
        {
            // If in NewMode ⇒ raise AnimalSaved + switch to display blank
            if (IsNewMode)
            {
                var newAnimal = new Animal(
                    name: txtBoxName.Text,
                    birthDate: txtBoxBirthDate.Text,
                    location: txtBoxLocation.Text,
                    breed: txtBoxBreed.Text,
                    specie: txtBoxSpecie.Text,
                    picture: picBoxAnimal.Image
                );

                AnimalSaved?.Invoke(this, newAnimal);
                return;
            }
            else
            {
                // Otherwise, perform “update” on an existing animal:
                lblName.Text = "Name: " + txtBoxName.Text;
                lblBirthDate.Text = "BirthDate: " + txtBoxBirthDate.Text;
                lblLocation.Text = "Location: " + txtBoxLocation.Text;
                lblBreed.Text = "Breed: " + txtBoxBreed.Text;
                lblSpecie.Text = "Specie: " + txtBoxSpecie.Text;

                txtBoxName.Visible = false;
                txtBoxBirthDate.Visible = false;
                txtBoxLocation.Visible = false;
                txtBoxBreed.Visible = false;
                txtBoxSpecie.Visible = false;

                lblName.Visible = true;
                lblBirthDate.Visible = true;
                lblLocation.Visible = true;
                lblBreed.Visible = true;
                lblSpecie.Visible = true;
            }

            btbSave.Visible = false;
            btnEdit.Visible = true;
            btnDelete.Visible = true;
            isEditing = false;
        }

        

        private void picBoxAnimal_Click(object sender, EventArgs e)
        {
            if (!isEditing)
                return;

            using (var ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                ofd.Title = "Select Animal Picture";

                if (ofd.ShowDialog() == DialogResult.OK)
                    picBoxAnimal.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Ask for confirmation
            var result = MessageBox.Show(
                "Are you sure you want to delete this animal?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes && animalData != null)
            {
                // Raise the event so the parent form can remove this animal/panel
                DeleteRequested?.Invoke(this, animalData);
            }
            // If No, do nothing
        }

        private void UserCtrl_AnimalPnl_Load(object sender, EventArgs e)
        {
            
        }
    }
}

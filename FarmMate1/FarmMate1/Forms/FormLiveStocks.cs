
// FormLiveStocks.cs
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmMate1.Forms
{
    public partial class FormLiveStocks : Form
    {       
        private List<Animal> allAnimals = new List<Animal>();

        public FormLiveStocks()
        {
            InitializeComponent();
            LoadDummyAnimalData();
            PopulateComboBoxes();
            //ApplyAnimalFilter();

            DisplayAllAnimals();
        }

        private void LoadDummyAnimalData()
        {
            
            // For demo, just hard‐code a handful of Animal objects:
            allAnimals.Add(new Animal(
                name: "Daisy",
                birthDate: "2023-04-01",
                location: "Barn A",
                breed: "Holstein",
                specie: "Cow",
                picture: null // no image for now
            ));

            allAnimals.Add(new Animal(
                name: "Buttercup",
                birthDate: "2022-11-15",
                location: "Pasture C",
                breed: "Angus",
                specie: "Cow",
                picture: null // you can use Image.FromFile("C:\\Images\\cows\\buttercup.jpg") if you have a file
            ));

            allAnimals.Add(new Animal(
                name: "Cluckers",
                birthDate: "2024-01-10",
                location: "Pen 1",
                breed: "Leghorn",
                specie: "Chicken",
                picture: null // set to Image.FromFile("C:\\Images\\chickens\\cluckers.png")
            ));

            allAnimals.Add(new Animal(
                name: "Bacon",
                birthDate: "2023-08-20",
                location: "Pen 2",
                breed: "Yorkshire",
                specie: "Pig",
                picture: null // no image
            ));

            allAnimals.Add(new Animal(
                name: "Storm",
                birthDate: "2022-05-30",
                location: "Stable B",
                breed: "Thoroughbred",
                specie: "Horse",
                picture: null // no image
            ));
            
            // …and so on. Add as many as you want here.
        }

        private void DisplayAllAnimals()
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (var animal in allAnimals)
            {
                var panel = new UserCtrl_AnimalPnl();
                panel.SetAnimalData(animal);                // ◀ Use new overload
                panel.DeleteRequested += Panel_DeleteRequested; // subscribe once
                flowLayoutPanel1.Controls.Add(panel);
            }
        }

        private void Panel_DeleteRequested(object sender, Animal e)
        {
            // 1) Remove the underlying Animal from our list
            allAnimals.Remove(e);

            // 2) Also remove the panel itself from the FlowLayoutPanel
            if (sender is UserCtrl_AnimalPnl pnl)
            {               
                pnl.DeleteRequested -= Panel_DeleteRequested;
                pnl.AnimalSaved -= PnlAddNew_AnimalSaved; // if you also subscribed
                flowLayoutPanel1.Controls.Remove(pnl);
                pnl.Dispose();
            }
        }


        private void PopulateComboBoxes()
        {
            // 1) Specie combo: gather distinct species from allAnimals
            var speciesList = allAnimals
                .Select(a => a.Specie)
                .Distinct()
                .OrderBy(s => s)
                .ToList();

            // Optionally insert a blank “All” entry at index 0
            speciesList.Insert(0, string.Empty);

            cmbSpecie.DataSource = speciesList;
            cmbSpecie.DropDownStyle = ComboBoxStyle.DropDownList;

            // 2) Breed combo: gather distinct breeds
            var breedList = allAnimals
                .Select(a => a.Breed)
                .Distinct()
                .OrderBy(b => b)
                .ToList();

            breedList.Insert(0, string.Empty);
            cmbBreed.DataSource = breedList;
            cmbBreed.DropDownStyle = ComboBoxStyle.DropDownList;

            // (If you have a “Type” combo, you can similarly populate it here.)
        }
       
       
        private void ApplyAnimalFilter()
        {
            string nameFilter = txtNameCode.Text.Trim(); // Note: txtNameCode, not txtBoxName
            string specieFilter = cmbSpecie.SelectedItem as string;
            string breedFilter = cmbBreed.SelectedItem as string;

            var query = allAnimals.AsEnumerable();

            if (!string.IsNullOrEmpty(nameFilter))
            {
                query = query.Where(a => a.Name.IndexOf(nameFilter, StringComparison.OrdinalIgnoreCase) >= 0);
            }
            if (!string.IsNullOrEmpty(specieFilter))
            {
                query = query.Where(a => a.Specie.Equals(specieFilter, StringComparison.OrdinalIgnoreCase));
            }
            if (!string.IsNullOrEmpty(breedFilter))
            {
                query = query.Where(a => a.Breed.Equals(breedFilter, StringComparison.OrdinalIgnoreCase));
            }

            var filteredList = query.ToList();

            flowLayoutPanel1.Controls.Clear();

            if (filteredList.Count == 0)
            {
                var noResultsLabel = new Label
                {
                    Text = "No animals found matching your criteria.",
                    ForeColor = Color.Red,
                    AutoSize = true,
                    Margin = new Padding(10)
                };
                flowLayoutPanel1.Controls.Add(noResultsLabel);
                return;
            }

            foreach (var animal in filteredList)
            {
                var animalPanel = new UserCtrl_AnimalPnl();
                animalPanel.SetAnimalData(animal);
                flowLayoutPanel1.Controls.Add(animalPanel);
            }
        }

        private void PnlAddNew_AnimalSaved(object sender, Animal newAnimal)
        {
            // 1) Add the new Animal to the in‐memory list
            allAnimals.Add(newAnimal);

            // 2) Convert that “Add New” panel into a display panel
            var panel = sender as UserCtrl_AnimalPnl;
            if (panel != null)
            {
                panel.SetAnimalData(newAnimal); // not sure if the parameter is correct
                panel.EnterDisplayMode(); // so it no longer stays in edit/add mode // CS0122
            }

            // 3) Create a fresh “Add New” panel at index 0
            var freshAdd = new UserCtrl_AnimalPnl();
            freshAdd.EnterNewMode();
            freshAdd.AnimalSaved += PnlAddNew_AnimalSaved;
            freshAdd.DeleteRequested += Panel_DeleteRequested;
            flowLayoutPanel1.Controls.Add(freshAdd);
            flowLayoutPanel1.Controls.SetChildIndex(freshAdd, 0);

            // 4) Refresh the rest of the animal panels below it
            RefreshAnimalPanel();
        }

        private void RefreshAnimalPanel()
        {
            // Remove all controls except the very first (the “Add New” panel)
            while (flowLayoutPanel1.Controls.Count > 1)
                flowLayoutPanel1.Controls.RemoveAt(1);

            // Append one UserCtrl_AnimalPnl for each Animal in allAnimals
            foreach (var animal in allAnimals)
            {
                var animalPanel = new UserCtrl_AnimalPnl();
                animalPanel.SetAnimalData(animal);

                // ← MAKE SURE to subscribe DeleteRequested exactly once:
               
                flowLayoutPanel1.Controls.Add(animalPanel);
            }
        }
        private void btnAddAnimal_Click(object sender, EventArgs e)
        {
            // Clear any existing input panel at the top if already present
            if (flowLayoutPanel1.Controls.Count > 0 && flowLayoutPanel1.Controls[0] is UserCtrl_AnimalPnl firstPanel && firstPanel.IsNewMode)
            {
                return; // Already adding a new one
            }

            // Create a new animal panel in "add mode"
            var newAnimalPanel = new UserCtrl_AnimalPnl();
            newAnimalPanel.EnterNewMode();
            newAnimalPanel.AnimalSaved += PnlAddNew_AnimalSaved;
            newAnimalPanel.DeleteRequested += Panel_DeleteRequested; // allow canceling
            // Add to flow panel at the top
            flowLayoutPanel1.Controls.Add(newAnimalPanel);
            flowLayoutPanel1.Controls.SetChildIndex(newAnimalPanel, 0);
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            ApplyAnimalFilter();
        }

        private void FormLiveStocks_Load(object sender, EventArgs e)
        {

        }

        private void userCtrl_AnimalPnl1_Load(object sender, EventArgs e)
        {

        }
    }
}

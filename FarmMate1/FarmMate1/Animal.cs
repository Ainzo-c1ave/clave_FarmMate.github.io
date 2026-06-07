
//Animal.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;  // ← for the Image type

namespace FarmMate1
{
    public class Animal
    {
        public string Name { get; set; }
        public string BirthDate { get; set; }
        public string Location { get; set; }
        public string Breed { get; set; }
        public string Specie { get; set; }
        public Image Picture { get; set; }   // optional: store an Image or a file‐path

        public Animal(string name, string birthDate, string location, string breed, string specie, Image picture = null)
        {
            Name = name;
            BirthDate = birthDate;
            Location = location;
            Breed = breed;
            Specie = specie;
            Picture = picture;// can be null if no image is available
        }
    }
}

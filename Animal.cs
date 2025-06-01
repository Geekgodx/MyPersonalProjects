using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmManagementSystem3
{
    internal class Animal
    {
        public int AnimalID;
        public string AnimalName;
        public int AnimalAge;
        public string AnimalSpecies;

        public Animal(int id, string name, int age, string species)
        {
            AnimalID = id;
            AnimalName = name;
            AnimalAge = age;
            AnimalSpecies = species;
        }
    }
}

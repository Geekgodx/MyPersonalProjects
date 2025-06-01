using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmManagementSystem3
{
    internal class Farmer : Person, IAccount
    {
        int FarmID;
        public Farmer(string n, int a, int id, int farmID) : base(n, a, id)
        {
            this.FarmID = farmID;
        }

        public void Password()
        {
            Console.WriteLine("Enter your password: ");
            string Pswd = Console.ReadLine();
        }

        public void ViewAnimals()
        {
            Console.WriteLine("===== Animal Inventory =====");
            if (Admin.animalList.Count == 0)
            {
                Console.WriteLine("No animals available.");
            }
            else
            {
                foreach (Animal a in Admin.animalList)
                {
                    Console.WriteLine($"ID: {a.AnimalID}, Name: {a.AnimalName}, Age: {a.AnimalAge}, Species: {a.AnimalSpecies}");
                }
            }
            Console.WriteLine("----------------------------");
        }
    }
}

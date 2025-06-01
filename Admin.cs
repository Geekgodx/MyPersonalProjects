using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmManagementSystem3
{
    class Admin : Person, IAccount, IManagement
    {
        //List to store Farm Animals
        static public List<Animal> animalList = new List<Animal>();

        public Admin(string n, int a, int id) : base(n, a, id) { }

        public void Password()
        {
            Console.WriteLine("Enter your password");
            string Pswd = Console.ReadLine();
        }

        public void AddAnimal()
        {
            Console.WriteLine("===== Add Animal =====");

            Console.WriteLine("Enter Animal ID: ");
            int animalID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Animal Name: ");
            string animalName = Console.ReadLine();

            Console.WriteLine("Enter Animal Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Animal Species: ");
            string species = Console.ReadLine();

            animalList.Add(new Animal(animalID, animalName, age, species));

            Console.WriteLine("Animal Added Successfully.");
            Console.WriteLine("----------------------------");

            File.AppendAllText("animals.txt", $"{animalID},{animalName},{age},{species}\n");
        }

        public void RemoveAnimal()
        {

            Console.WriteLine("===== Remove Animal =====");
            Console.WriteLine("Enter Animal ID to remove: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Animal animalToRemove = animalList.Find(a => a.AnimalID == id);

            if (animalToRemove != null)
            {
                animalList.Remove(animalToRemove);
                Console.WriteLine($"Animal with ID {id} removed.");
            }
            else
            {
                Console.WriteLine("Animal not found.");
            }

            Console.WriteLine("----------------------------");

        }

        public void ListAnimal()
        {
            Console.WriteLine("===== Animal Inventory =====");
            if (animalList.Count == 0)
            {
                Console.WriteLine("No animals found");
            }
            else
            {
                foreach (Animal a in animalList)
                {
                    Console.WriteLine($"ID: {a.AnimalID}, Name: {a.AnimalName}, Age: {a.AnimalAge}, Species: {a.AnimalSpecies}");
                }
            }
            Console.WriteLine("---------------------------");
        }

        public void UpdateAnimal()
        {
            Console.Write("Enter ID to update: ");
            int id = int.Parse(Console.ReadLine());
            var animal = animalList.Find(a => a.AnimalID == id);
            if (animal != null)
            {
                Console.Write("New Name: ");
                animal.AnimalName = Console.ReadLine();

                Console.Write("New Age: ");
                animal.AnimalAge = int.Parse(Console.ReadLine());

                Console.Write("New Species: ");
                animal.AnimalSpecies = Console.ReadLine();

                Console.WriteLine("Animal updated.");
            }
            else Console.WriteLine("Animal not found.");
        }

        public void SearchAnimalByID()
        {
            Console.Write("Enter ID to search: ");
            int id = int.Parse(Console.ReadLine());
            var animal = animalList.Find(a => a.AnimalID == id);
            if (animal != null) Console.WriteLine(animal);
            else Console.WriteLine("Animal not found.");
        }
    }
}

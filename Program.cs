using System;
using System.Collections.Generic;
using System.IO;
using FarmManagementSystem3;

class Program
{
    // To access the animals.txt file
    static void LoadAnimalsFromFile()
    {
        if (File.Exists("animals.txt"))
        {
            string[] lines = File.ReadAllLines("animals.txt");
            foreach (var line in lines)
            {
                var parts = line.Split(',');
                if (parts.Length == 4 &&
                    int.TryParse(parts[0], out int id) &&
                    int.TryParse(parts[2], out int age))
                {
                    Admin.animalList.Add(new Animal(id, parts[1], age, parts[3]));
                }
            }
        }
    }

    static void SaveAnimalsToFile()
    {
        using StreamWriter writer = new StreamWriter("animals.txt");
        foreach (var animal in Admin.animalList)
        {
            writer.WriteLine($"{animal.AnimalID},{animal.AnimalName},{animal.AnimalAge},{animal.AnimalSpecies}");
        }
    }

    static void Main(string[] args)
    {
        // Dictionary to store the farmer and admin username and password.
        Dictionary<string, string> adminUsers = new Dictionary<string, string>
        {
            {"admin", "admin123"}
        };

        Dictionary<string, string> farmerUsers = new Dictionary<string, string>
        {
            {"farmer1", "farm123"}
        };

        Console.WriteLine("===== Farm Management System =====");

        Console.Write("Enter username: ");
        string username = Console.ReadLine();

        Console.Write("Enter password: ");
        string password = Console.ReadLine();

        string userType = "";

        if (adminUsers.ContainsKey(username) && adminUsers[username] == password)
        {
            userType = "admin";
        }
        else if (farmerUsers.ContainsKey(username) && farmerUsers[username] == password)
        {
            userType = "farmer";
        }
        else
        {
            Console.WriteLine("Invalid username or password. Exiting...");
            return;
        }

        bool exit = false;
        //Recall the animals.txt file 
        LoadAnimalsFromFile();

        if (userType == "admin")
        {
            //Predefined admin Information
            Admin admin = new Admin("Admin", 35, 1);
            while (!exit)
            {
                Console.WriteLine("\n------ Admin Menu ------");
                Console.WriteLine("1. Add Animal");
                Console.WriteLine("2. Remove Animal");
                Console.WriteLine("3. List Animals");
                Console.WriteLine("4. Update Animal");
                Console.WriteLine("5. Search Animal by ID");
                Console.WriteLine("6. Exit");
                Console.Write("Select an option: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        admin.AddAnimal();
                        break;
                    case 2:
                        admin.RemoveAnimal();
                        break;
                    case 3:
                        admin.ListAnimal();
                        break;
                    case 4:
                        admin.UpdateAnimal(); 
                        SaveAnimalsToFile(); 
                        break;
                    case 5:
                        admin.SearchAnimalByID();
                        break;
                    case 6:
                        exit = true;
                        Console.WriteLine("Exiting system...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select 1-4.");
                        break;
                }
            }
        }
        else if (userType == "farmer")
        {
            //Predefined farmer Information
            Farmer farmer = new Farmer("John", 40, 100, 200);
            while (!exit)
            {
                Console.WriteLine("\n------ Farmer Menu ------");
                Console.WriteLine("1. View Animal Inventory");
                Console.WriteLine("2. Exit");
                Console.Write("Select an option: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        farmer.ViewAnimals();
                        break;
                    case 2:
                        exit = true;
                        Console.WriteLine("Exiting system...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select 1 or 2.");
                        break;
                }
            }
        }
        else
        {
            Console.WriteLine("Incorrect password or unauthorized access.");
        }

        Console.WriteLine("Thank you for using the Farm Management System.");
    }
}
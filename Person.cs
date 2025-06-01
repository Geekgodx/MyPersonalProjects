using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmManagementSystem3
{
    internal class Person
    {
        public string Name;
        public int Age;
        public int ID;

        public Person(string n, int a, int id)
        {
            this.Name = n;
            this.Age = a;
            this.ID = id;
        }
    }
}

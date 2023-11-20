using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Final_project
{
    public class Professor
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        // Constructor
        public Professor(int id, string name, string surname)
        {
            ID = id;
            Name = name;
            Surname = surname;
        }

        // You can also override ToString() method for better representation
        public override string ToString()
        {
            return $"Professor ID: {ID}, Name: {Name}, Surname: {Surname}";
        }
    }

}
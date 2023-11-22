using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;

namespace Final_project
{
    using System;

    public class Student
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string DateOfBirth { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Nation { get; set; }

        // Constructor
        public Student(string id, string name, string surname, string dateOfBirth, string address, string email,string nation)
        {
            ID = id;
            Name = name;
            Surname = surname;
            DateOfBirth = dateOfBirth;
            Address = address;
            Email = email;
            Nation = nation;
        }

        // You can also override ToString() method for better representation
        public override string ToString()
        {
            return $"Student ID: {ID}, Name: {Name}, Surname: {Surname}, Date of Birth: {DateOfBirth}, Address: {Address}, Email: {Email}";
        }
    }

}

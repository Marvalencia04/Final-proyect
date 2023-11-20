using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Final_project
{
    public class Subject
    {
        public string SubjectName { get; set; }
        public int Credits { get; set; }

        // Constructor
        public Subject(string subjectName, int credits)
        {
            SubjectName = subjectName;
            Credits = credits;
        }

        // You can also override ToString() method for better representation
        public override string ToString()
        {
            return $"Subject: {SubjectName}, Credits: {Credits}";
        }
    }

}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject
{
    internal class Teacher
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Teacher(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

        }

    }
}

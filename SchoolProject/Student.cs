using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject
{
    internal class Student
    {
        public  string FirstName {  get; set; }
        public string LastName { get; set; }

        public Student(string firtsName, string lastName ) { 
          
            FirstName = firtsName;
            LastName = lastName;
        }

        
    }
}

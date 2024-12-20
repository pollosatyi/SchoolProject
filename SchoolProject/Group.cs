using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject
{
    internal class Group
    {
        public string Name { get; set; }

        public List<Student> Students {  get; set; }

        public Group(string Name) { 
           
          Students = new List<Student>();

        }
    }
}

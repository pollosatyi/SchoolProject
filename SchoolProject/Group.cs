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

        public void  AddStudentsToGroup(Student student, School school)
        {
            if (!IsStudentInSchool(student, school))
            {
                Console.WriteLine("Такого студента нет");
                return;

            };

            Students.Add(student);

        }

        public bool IsStudentInSchool(Student student,School school)
        {
            return school.Students.Contains(student);
        }
    }
}

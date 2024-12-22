using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolProject.Schools;

namespace SchoolProject.SchoolElements
{
    internal class Group
    {
        public string Name { get; set; }

        public List<Student> Students { get; set; }

        public Group(string name)
        {
            Students = new List<Student>();
            Name = name;
        }

        public void AddStudentsToGroup(Student student, School school)
        {
            if (!PresenceOfElementsInSchool.IsStudentInSchool(student, school))
            {
                Console.WriteLine("Такого студента нет");
                return;

            };

            Students.Add(student);

        }

        


        public static Group CreateGroup()
        {
            Console.WriteLine("Введите название группы: ");
            string groupName = Console.ReadLine();
            return new Group(groupName);
        }


        public void PrintStudentsInGroup()
        {
            Console.WriteLine("Список студентов в группе: ");
            PrintSchoolElements.PrintStudents(Students);
            Console.WriteLine();
        }
    }
}

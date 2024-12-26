using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolProject.Print;
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

        public void AddStudentToGroup(Student student, School school)
        {
            if (!PresenceOfElementsInSchool.IsStudentInSchool(student, school,out Student studentInSchool))
            {
                Console.WriteLine("Такого студента нет");
                return;

            };

            Students.Add(studentInSchool);

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

        public static void PrintNameGroup(Group group)
        {
            Console.WriteLine($"название группы: {group.Name}\n");
        }
    }
}

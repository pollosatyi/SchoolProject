using SchoolProject.SchoolElements;
using SchoolProject.Schools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Group = SchoolProject.SchoolElements.Group;

namespace SchoolProject.AddElements
{
    internal static class AddToGroup
    {
        public static void AddStudentToGroup(Group group,School school)
        {
            group.AddStudentsToGroup(GetStudent(), school);
        }


        public static Student GetStudent()
        {
            Console.WriteLine("Введите имя студента: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Введите фамилию студента");
            string lastName = Console.ReadLine();
            return new Student(firstName, lastName);
        }
    }
}

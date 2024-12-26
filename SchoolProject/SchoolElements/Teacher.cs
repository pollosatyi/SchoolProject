using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.SchoolElements
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

        public static Teacher CreateTeacher()
        {
            Console.WriteLine("Введите имя учителя: ");
            string firstname = Console.ReadLine();
            Console.WriteLine("Введите фамилию учителя: ");
            string lastname = Console.ReadLine();
            return new Teacher(firstname, lastname);
        }

        public static void PrintTeacher(Teacher teacher)
        {
            Console.WriteLine("{0,-15} {1,-15}", "Имя учителя", "Фамилия учителя");
            Console.WriteLine("{0,-15} {1, -15}", $"{teacher.FirstName}", $"{teacher.LastName}\n");
        }

    }
}

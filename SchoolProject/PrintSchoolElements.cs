using SchoolProject.SchoolElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject
{
    internal static class PrintSchoolElements
    {
        public static void PrintStudents(List<Student>students)
        {
            Console.WriteLine("{0,-15} {1,-15}", "Имя", "Фамилия");
            foreach (var student in students)
            {
                Console.WriteLine("{0,-15} {1,-15}", $"{student.FirstName}", $"{student.LastName}");
            }
        }


        //public static void

    }
}

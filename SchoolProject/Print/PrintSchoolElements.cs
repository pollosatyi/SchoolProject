using SchoolProject.SchoolElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Print
{
    internal static class PrintSchoolElements
    {
        public static void PrintStudents(List<Student> students)
        {
            Console.WriteLine("Список студентов: ");
            Console.WriteLine("{0,-15} {1,-15}", "Имя", "Фамилия");
            foreach (var student in students)
            {
                Console.WriteLine("{0,-15} {1,-15}", $"{student.FirstName}", $"{student.LastName}");
            }
            Console.WriteLine();
        }


        public static void PrintGroups(List<Group> groups)
        {
            Console.WriteLine("Список групп: ");
            foreach (var group in groups)
            {
                Console.WriteLine(group.Name);
            }
            Console.WriteLine();

        }


        public static void PrintTeachers(List<Teacher> teachers)
        {
            Console.WriteLine("Список учителей: ");
            Console.WriteLine("{0,-15} {1,-15}", "Имя", "Фамилия");
            foreach (var teacher in teachers)
            {
                Console.WriteLine("{0,-15} {1,-15}", $"{teacher.FirstName}", $"{teacher.LastName}");
            }
            Console.WriteLine();

        }


        public static void PrintClassroom(List<Classroom> classrooms)
        {
            Console.WriteLine("Список аудиторий: ");
            foreach (var classroom in classrooms)
            {
                Console.WriteLine(classroom.Id);
            }
            Console.WriteLine();
        }


        public static void PrintLessons(List<Lesson> lessons)
        {
            Console.WriteLine("Список уроков: ");
            foreach (var lesson in lessons)
            {
                Console.WriteLine(lesson.NameOfLesson);
            }
            Console.WriteLine();
        }

    }
}

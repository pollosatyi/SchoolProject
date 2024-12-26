using SchoolProject.Enums;
using SchoolProject.Print;
using SchoolProject.Schools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Menu
{
    internal static class PrintSchoolMenu
    {
        public static void PrintSchoolMenuChoice(School school)
        {
            bool IsOnMenu = true;
            while (IsOnMenu)
            {
                Print();
                MenuPrintInSchoolType menuPrintInSchoolType = (MenuPrintInSchoolType)Convert.ToInt32(Console.ReadLine());
                switch (menuPrintInSchoolType)
                {
                    case MenuPrintInSchoolType.exit:
                        IsOnMenu = false;
                        break;
                    case MenuPrintInSchoolType.printStudentsInSchool:
                        PrintSchoolElements.PrintStudents(school.Students);
                        break;
                    case MenuPrintInSchoolType.printGroupsInSchool:
                        PrintSchoolElements.PrintGroups(school.Groups);
                        break;
                    case MenuPrintInSchoolType.printTeachersInSchool:
                        PrintSchoolElements.PrintTeachers(school.Teachers);
                        break;
                    case MenuPrintInSchoolType.printClassroomsInSchool:
                        PrintSchoolElements.PrintClassroom(school.Classrooms);
                        break;
                    case MenuPrintInSchoolType.printLessonsInSchool:
                        PrintSchoolElements.PrintLessons(school.Lessons);
                        break;
                    default:
                        Console.WriteLine("Такой команды нет");
                        break;


                }

            }
        }

        private static void Print()
        {
            Console.WriteLine("Меню выбора окна для печати группы");
            Console.WriteLine("0 - для выхода \n" +
                "1 - для печати списка студентов");
        }
    }
}

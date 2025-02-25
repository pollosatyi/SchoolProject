﻿using SchoolProject.Enums;
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
                    case MenuPrintInSchoolType.Exit:
                        IsOnMenu = false;
                        break;
                    case MenuPrintInSchoolType.PrintStudentsInSchool:
                        PrintSchoolElements.PrintStudents(school.Students);
                        break;
                    case MenuPrintInSchoolType.PrintGroupsInSchool:
                        PrintSchoolElements.PrintGroups(school.Groups);
                        break;
                    case MenuPrintInSchoolType.PrintTeachersInSchool:
                        PrintSchoolElements.PrintTeachers(school.Teachers);
                        break;
                    case MenuPrintInSchoolType.PrintClassroomsInSchool:
                        PrintSchoolElements.PrintClassroom(school.Classrooms);
                        break;
                    case MenuPrintInSchoolType.PrintLessonsInSchool:
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
            Console.WriteLine("Меню выбора окна для печати школы");
            Console.WriteLine("0 - для выхода \n" +
                "1 - для печати списка студентов \n" +
                "2 - для печати списка групп \n" +
                "3 - для печати списка учителей \n" +
                "4 - для печати списка аудиторий \n" +
                "5 - для печати списка уроков \n");
        }
    }
}

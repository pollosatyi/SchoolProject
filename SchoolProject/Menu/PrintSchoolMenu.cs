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
        public static void PrintGroupMenuChoice(School school)
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
                        PrintSchoolElements.PrintStudents(school);
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

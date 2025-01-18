using SchoolProject.Enums;
using SchoolProject.Print;
using SchoolProject.SchoolElements;
using SchoolProject.Schools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Menu
{
    internal static class PrintGroupMenu
    {
        public static void PrintGroupMenuChoice(School school)
        {
            bool IsOnMenu = true;
            while (IsOnMenu)
            {
                Print();
                MenuPrintInGroupType menuPrintInGroupType = (MenuPrintInGroupType)Convert.ToInt32(Console.ReadLine());
                switch (menuPrintInGroupType)
                {
                    case MenuPrintInGroupType.Exit:
                        IsOnMenu = false;
                        break;
                    case MenuPrintInGroupType.PrintStudentsInGroup:
                        PrintGroupsElements.PrintStudentsInGroup(school);
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

using SchoolProject.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Menu
{
    internal static class PrintMenu
    {
        public static void PrintMenuChoice()
        {
            bool IsOnMenu = true;
            while (IsOnMenu)
            {
                Print();
                MenuPrintType menuPrintType = (MenuPrintType)Convert.ToInt32(Console.ReadLine());

                switch (menuPrintType)
                {
                    case MenuPrintType.exit:
                        IsOnMenu = false;
                        break;
                    case MenuPrintType.printElementsInGroup:
                        break;
                    case MenuPrintType.printElementsInLesson:
                        break;
                    case MenuPrintType.printElementsInSchool:
                        break;
                    default:
                        Console.WriteLine("Такой команды нет");
                        break;
                }
            }
        }

        private static void Print()
        {
            Console.WriteLine("Меню выбора окна для печати");
            Console.WriteLine("0 - для выхода \n" +
                "1 - для вызова меню печати групп \n" +
                "2 - для вызова меню печати уроков \n" +
                "3 - для вызова меню печати школы\n");
        }
    }
}

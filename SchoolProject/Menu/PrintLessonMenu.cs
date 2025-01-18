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
    internal static class PrintLessonMenu
    {
        public static void PrintLessonMenuChoice(School school)
        {
            bool IsOnMenu = true;
            while (IsOnMenu)
            {
                Print();
                MenuPrintInLessonType menuPrintInLessonType = (MenuPrintInLessonType)Convert.ToInt32(Console.ReadLine());
                switch (menuPrintInLessonType)
                {
                    case MenuPrintInLessonType.Exit:
                        IsOnMenu = false;
                        break;
                    case MenuPrintInLessonType.PrintElementsInLesson:
                        PrintLessonElements.PrintElementsInLesson(school);
                        break;

                }

            }
        }

        private static void Print()
        {
            Console.WriteLine("Меню выбора окна для печати урока");
            Console.WriteLine("0 - для выхода \n" +
                "1 - для печати урока \n");
        }
    }
}

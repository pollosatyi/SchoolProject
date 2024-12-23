using SchoolProject.AddElements;
using SchoolProject.Enums;
using SchoolProject.Schools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolProject.SchoolElements;


namespace SchoolProject
{
    internal static class Menu
    {
        public static void MenuSelection(School school)
        {
            bool IsMenuOn = true;
            while (IsMenuOn)
            {
                PrintMenu();
                MenuSelectionType menuSelectionType = (MenuSelectionType)Convert.ToInt32(Console.ReadLine());
                switch (menuSelectionType)
                {
                    case MenuSelectionType.exitMenu:
                        IsMenuOn = false;
                        break;


                    case MenuSelectionType.groupMenu:

                        Console.WriteLine("Добавление студента в группу");
                        Group group = Group.CreateGroup();

                        if (!PresenceOfElementsInSchool.IsGroupInSchool(group, school)) break;
                        
                        AddToGroup.AddStudentToGroup(group, school);
                        break;


                    case MenuSelectionType.lessonMenu:

                        Console.WriteLine("Добавление в урок");
                        Lesson lesson = Lesson.CreateLesson();

                        if (!PresenceOfElementsInSchool.IsLessonInSchool(lesson, school))
                        {
                            Console.WriteLine("Такого урока нет в школе");
                            break;
                        }
                        Console.WriteLine("Добавление группы");

                        //AddToLesson.AddElementsToLesson(lesson,);

                        
                        break;
                    case MenuSelectionType.schoolMenu: break;
                    default: Console.WriteLine("Неверный ввод"); break;
                        //exitMenu= 0,
                        //groupMenu = 1,
                        //lessonMenu = 2,
                        // schoolMenu = 3
                }
            }

        }

        public static void PrintMenu()
        {
            Console.WriteLine("0 - для выхода \n");
            Console.WriteLine("1 - Выбрать меню добавления в группу \n");
            Console.WriteLine("2 - Выбрать меню добавления в урок \n ");
            Console.WriteLine("3 - Выбрать меню добавления в школу \n ");
        }


    }
}

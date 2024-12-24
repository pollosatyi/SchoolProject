using SchoolProject.AddElements;
using SchoolProject.Enums;
using SchoolProject.Schools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolProject.SchoolElements;
using SchoolProject.Print;


namespace SchoolProject.Menu
{
    internal static class MainMenu
    {
        public static void MainMenuSelection(School school)
        {
            bool IsMenuOn = true;
            while (IsMenuOn)
            {
                PrintMainMenu();
                MainMenuSelectionType menuSelectionType = (MainMenuSelectionType)Convert.ToInt32(Console.ReadLine());
                switch (menuSelectionType)
                {
                    case MainMenuSelectionType.exitMenu:
                        IsMenuOn = false;
                        break;


                    case MainMenuSelectionType.groupAddMenu:

                        Console.WriteLine("Добавление студента в группу");
                        Group group = Group.CreateGroup();
                        if (!PresenceOfElementsInSchool.IsGroupInSchool(group, school, out Group groupInSchool)) break;
                        AddToGroup.AddStudentToGroup(groupInSchool, school);
                        break;



                    case MainMenuSelectionType.lessonAddMenu:

                        Console.WriteLine("Добавление элементов в урок");
                        Lesson lesson = Lesson.CreateLesson();
                        if (!PresenceOfElementsInSchool.IsLessonInSchool(lesson, school, out Lesson lessonInSchool))
                        {
                            Console.WriteLine("Такого урока нет в школе");
                            break;
                        }
                        AddToLesson.AddElementsToLesson(lesson, school);
                        break;



                    case MainMenuSelectionType.schoolAddMenu:
                        Console.WriteLine("Добавление элементов в школу");
                        AddToSchool.CreateSchoolElements(school);

                        break;


                    case MainMenuSelectionType.printMenu:
                        PrintMenu.PrintMenuChoice(school);
                        break;



                    default: Console.WriteLine("Неверный ввод"); break;

                }
            }

        }

        public static void PrintMainMenu()
        {
            Console.WriteLine("Программа для учета студентов, учителей, уроков и аудиторий");
            Console.WriteLine("0 - для выхода \n" +
                              "1 - Выбрать меню добавления в группу \n" +
                              "2 - Выбрать меню добавления в урок \n" +
                              "3 - Выбрать меню добавления в школу \n" +
                              "4 - Выбрать меню печати \n");



        }
    }
}

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
                        if (!PresenceOfElementsInSchool.IsGroupInSchool(group, school,out Group groupInSchool)) break;
                        AddToGroup.AddStudentToGroup(groupInSchool, school);
                        break;



                    case MenuSelectionType.lessonMenu:

                        Console.WriteLine("Добавление элементов в урок");
                        Lesson lesson = Lesson.CreateLesson();
                        if (!PresenceOfElementsInSchool.IsLessonInSchool(lesson, school, out Lesson lessonInSchool))
                        {
                            Console.WriteLine("Такого урока нет в школе");
                            break;
                        }
                        AddToLesson.AddElementsToLesson(lesson,school);
                        break;



                    case MenuSelectionType.schoolMenu:
                        Console.WriteLine("Добавление элементов в школу");
                        
                        
                        break;
                    default: Console.WriteLine("Неверный ввод"); break;
                        
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

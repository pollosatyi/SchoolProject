﻿using SchoolProject.AddElements;
using SchoolProject.Enums;
using SchoolProject.Schools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolProject.SchoolElements;


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


                    case MainMenuSelectionType.printStudentsMenu:
                        PrintSchoolElements.PrintStudents(school.Students);
                        break;


                    case MainMenuSelectionType.printGroupsMenu:
                        PrintSchoolElements.PrintGroups(school.Groups);
                        break;


                    case MainMenuSelectionType.printTeachersMenu:
                        PrintSchoolElements.PrintTeachers(school.Teachers);
                        break;


                    case MainMenuSelectionType.printClassroomsMenu:
                        PrintSchoolElements.PrintClassroom(school.Classrooms);
                        break;


                    case MainMenuSelectionType.printLessonsMenu:
                        PrintSchoolElements.PrintLessons(school.Lessons);
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
                              "4 - Распечать список студентов в школе \n" +
                              "5 - Распечать список групп в школе \n" +
                              "6 - Распечать список учителей в школе \n" +
                              "7 - Распечать список аудиторий в школе \n" +
                              "8 - Распечать список уроков в школе \n");
        }


    }
}

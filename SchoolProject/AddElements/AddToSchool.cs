using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolProject.Enums;
using SchoolProject.SchoolElements;
using SchoolProject.Schools;

namespace SchoolProject.AddElements
{
    internal static class AddToSchool
    {


        public static void CreateSchoolElements(School school)
        {
            while (true)
            {
                PrintMenu();
                SchoolElementsType schoolElementsType = (SchoolElementsType)Convert.ToInt32(Console.ReadLine());
                if (schoolElementsType == SchoolElementsType.Exit) break;

                switch (schoolElementsType)
                {
                    case SchoolElementsType.Student:
                        school.AddStudentToSchool(Student.CreateStudent());
                        break;
                    case SchoolElementsType.Group:
                        school.AddGroupToSchool(Group.CreateGroup());
                        break;
                    case SchoolElementsType.Teacher:
                        school.AddTeacherToSchool(Teacher.CreateTeacher());
                        break;
                    case SchoolElementsType.Classroom:
                        school.AddClassroomToSchool(Classroom.CreateClassroom());
                        break;
                    case SchoolElementsType.Lesson:
                        school.AddLessonToSchool(Lesson.CreateLesson());
                        break;

                }



            }
        }


        public static void PrintMenu()
        {
            Console.WriteLine("Выберите пункт меню");
            Console.WriteLine(
                "0 - выхода из меню добавления в школу \n" +
                "1 - Добавить студента в школу \n" +
                "2 - Добавить группу в школу \n" +
                "3 - Добавить учителя в школу \n" +
                "4 - Добавить аудиторию в школу \n" +
                "5 - Добавить урок в школу \n");

        }
    }
}

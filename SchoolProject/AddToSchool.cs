using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject
{
    internal static class AddToSchool
    {
        //public School NewSchool { get; set; }
        //public AddToSchool(School school)
        //{
        //    NewSchool = school;
        //}


        public static void CreateSchoolElements(School school)
        {
            while (true)
            {
                PrintMenu();
                SchoolElementsType schoolElementsType = (SchoolElementsType)Convert.ToInt32(Console.ReadLine());
                if (schoolElementsType == SchoolElementsType.exit) break;

                switch (schoolElementsType)
                {
                    case SchoolElementsType.student:
                        school.AddStudentToSchool(Student.CreateStudent());
                        break;
                    case SchoolElementsType.group: break;
                    case SchoolElementsType.teacher: break;
                    case SchoolElementsType.classroom: break;
                    case SchoolElementsType.lesson: break;

                }



            }
        }


        public static void PrintMenu()
        {
            Console.WriteLine("Выберите пункт меню");
            Console.WriteLine(
                "0 - выхода \n" +
                "1 - Добавить студента в школу \n" +
                "2 - Добавить группу в школу \n" +
                "3 - Добавить учителя в школу \n" +
                "4 - Добавить аудиторию в школу \n" +
                "5 - Добавить урок в школу \n");

        }
    }
}

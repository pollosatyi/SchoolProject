using SchoolProject.SchoolElements;
using SchoolProject.Schools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Print
{
    internal static class PrintLessonElements 
    {
        public static void PrintElementsInLesson(School school)
        {
            if (PresenceOfElementsInSchool.IsLessonInSchool(FindLesson(), school, out Lesson lessonInSchool))
            {


            }
            else
            {
                return;
            }
            
        }



        private static Lesson FindLesson()
        {
            Console.WriteLine("Введите название урока,который нужно распечатать: ");
            string nameGroup = Console.ReadLine();
            return new Lesson(nameGroup);

        }

        private static void PrintGroupInLesson()
        {
            Console.WriteLine()
        }
    }
}

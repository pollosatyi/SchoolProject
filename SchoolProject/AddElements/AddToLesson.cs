using SchoolProject.SchoolElements;
using SchoolProject.Schools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Group = SchoolProject.SchoolElements.Group;

namespace SchoolProject.AddElements
{
    internal static class AddToLesson
    {
        private static Group _group { get; set; }
        private static Classroom _classroom { get; set; }

        private static Teacher _teacher { get; set; }

        public static void AddElementsToLesson(Lesson lesson,School school)
        {
            Console.WriteLine("Добавление группы в урок");
            _group = Group.CreateGroup();
            lesson.AddGroupToLesson(_group,school,out bool isAddGroup);
            if (!isAddGroup)
            {
                PrinFailedAddition();
                return;
            }
           

            Console.WriteLine("Добавление аудитории в урок");
            _classroom=Classroom.CreateClassroom();
            lesson.AddClassroomToLesson(_classroom,school, out bool isAddClassroom);
            if (!isAddClassroom)
            {
                PrinFailedAddition();
                return;
            }


            Console.WriteLine("Добавление учителя в урок");
            _teacher=Teacher.CreateTeacher();
            lesson.AddTeacherToLesson(_teacher,school, out bool isTeacherAdd);
            if (!isTeacherAdd)
            {
                 PrinFailedAddition();
                return;
            }
            Console.WriteLine("Все элементы добавлены в урок");

        }


        private static void PrinFailedAddition()
        {
            Console.WriteLine("Не удалось добавить элементы в урок");
        }


    }
}

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
            lesson.AddGroupToLesson(_group,school);
            Console.WriteLine($"Группа ");

            Console.WriteLine("Добавление аудитории в урок");
            _classroom=Classroom.CreateClassroom();
            lesson.AddClassroomToLesson(_classroom,school);

            Console.WriteLine("Добавление учителя в урок");
            _teacher=Teacher.CreateTeacher();
            lesson.AddTeacherToLesson(_teacher,school);

        }

        
    }
}

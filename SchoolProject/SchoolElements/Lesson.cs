using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolProject.Schools;

namespace SchoolProject.SchoolElements
{
    internal class Lesson
    {
        public string NameOfLesson { get; set; }

        public Group GroupOnLesson { get; set; }

        public Classroom ClassroomOfLesson { get; set; }

        public Teacher TeacherOfLesson { get; set; }

        private Lesson(string name)
        {
            NameOfLesson = name;
        }

        public void AddGroupToLesson(Group group, School school)
        {
            if (!PresenceOfElementsInSchool.IsGroupInSchool(group, school))
            {
                Console.WriteLine("Такой группа не добавлена в список школы");
                return;
            }
            GroupOnLesson = group;
        }


        public void AddClassroomToLesson(Classroom classroom, School school)
        {
            if (!PresenceOfElementsInSchool.IsClassroomInSchool(classroom, school))
            {
                Console.WriteLine("Эта аудитория не добавлена в список школы"); return;
            }
            ClassroomOfLesson = classroom;
        }


        public void AddTeacherToLesson(Teacher teacher, School school)
        {
            if (!PresenceOfElementsInSchool.IsTeacherInSchool(teacher, school))
            {
                Console.WriteLine("Этого учителя нет в списке школы");
                return;
            }
            TeacherOfLesson = teacher;
        }


        public static Lesson CreateLesson()
        {
            Console.WriteLine("Введите название урока: ");
            string lessonName = Console.ReadLine();
            return new Lesson(lessonName);

        }
    }
}

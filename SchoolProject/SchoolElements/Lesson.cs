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

        public Lesson(string name)
        {
            NameOfLesson = name;
        }

        public void AddGroupToLesson(Group group, School school)
        {
            if (!PresenceOfElementsInSchool.IsGroupInSchool(group, school, out Group groupInSchool))
            {
                Console.WriteLine($"Группа не добавлена в урок");
                return;
            }
            GroupOnLesson = groupInSchool;
            Console.WriteLine($"Группа {GroupOnLesson.Name} была  добавлена в урок"); 
        }


        public void AddClassroomToLesson(Classroom classroom, School school)
        {
            if (!PresenceOfElementsInSchool.IsClassroomInSchool(classroom, school, out Classroom classroomInSchool))
            {
                Console.WriteLine("Эта аудитория не добавлена в урок"); return;
            }
            ClassroomOfLesson = classroomInSchool;
            Console.WriteLine($"Аудитория ") ;
        }


        public void AddTeacherToLesson(Teacher teacher, School school)
        {
            if (!PresenceOfElementsInSchool.IsTeacherInSchool(teacher, school, out Teacher teacherInSchool))
            {
                Console.WriteLine("Этот учитель не добавлен в урок ");
                return;
            }
            TeacherOfLesson = teacherInSchool;
            Console.WriteLine("Этот учитель добавлен в урок");
        }


        public static Lesson CreateLesson()
        {
            Console.WriteLine("Введите название урока: ");
            string lessonName = Console.ReadLine();
            return new Lesson(lessonName);

        }
    }
}

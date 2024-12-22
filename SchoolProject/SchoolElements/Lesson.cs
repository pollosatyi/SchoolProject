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
            if (!IsGroupInSchool(group, school))
            {
                Console.WriteLine("Такой группа не добавлена в список школы");
                return;
            }
            GroupOnLesson = group;
        }


        public void AddClassroomToLesson(Classroom classroom, School school)
        {
            if (!IsClassroomInSchool(classroom, school))
            {
                Console.WriteLine("Эта аудитория не добавлена в список школы"); return;
            }
            ClassroomOfLesson = classroom;
        }


        public void AddTeacherToLesson(Teacher teacher, School school)
        {
            if (!IsTeacherInSchool(teacher, school))
            {
                Console.WriteLine("Этого учителя нет в списке школы");
                return;
            }
            TeacherOfLesson = teacher;
        }


        public bool IsTeacherInSchool(Teacher teacher, School school)
        {
            return school.Teachers.Contains(teacher);
        }


        public bool IsClassroomInSchool(Classroom classroom, School school)
        {
            return school.Classrooms.Contains(classroom);
        }

        public bool IsGroupInSchool(Group group, School school)
        {
            return school.Groups.Contains(group);
        }


        public static Lesson CreateLesson()
        {
            Console.WriteLine("Введите название урока: ");
            string lessonName = Console.ReadLine();
            return new Lesson(lessonName);

        }
    }
}

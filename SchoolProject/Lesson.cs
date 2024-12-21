using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject
{
    internal class Lesson
    {
        public string NameOfLesson { get; set; }

        public Group GroupOnLesson { get; set; }

        public Classroom ClassroomOfLesson { get; set; }

        public Teacher TeacherOfLesson { get; set; }

        public Lesson(string name, Group group, Classroom classroom, Teacher teacher)
        {
            NameOfLesson = name;
            GroupOnLesson = group;
            ClassroomOfLesson = classroom;
            TeacherOfLesson = teacher;
        }

    }
}

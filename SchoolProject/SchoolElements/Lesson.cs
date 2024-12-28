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

        public void AddGroupToLesson(Group group, School school, out bool isAddGroup)
        {
            if (!PresenceOfElementsInSchool.IsGroupInSchool(group, school, out Group groupInSchool))
            {
                Console.WriteLine($"Группа не добавлена в урок \n");
                isAddGroup = false;
                return;
            }
            GroupOnLesson = groupInSchool;
            isAddGroup = true;
            Console.WriteLine($"Группа {GroupOnLesson.Name} была  добавлена в урок \n"); 
        }


        public void AddClassroomToLesson(Classroom classroom, School school, out bool isAddClassroom )
        {
            if (!PresenceOfElementsInSchool.IsClassroomInSchool(classroom, school, out Classroom classroomInSchool))
            {
                Console.WriteLine("Эта аудитория не добавлена в урок \n");
                isAddClassroom = false;
                return;
            }
            ClassroomOfLesson = classroomInSchool;
            Console.WriteLine($"Аудитория с номером {classroom.Id} добавлен в урок \n") ;
            isAddClassroom=true;
        }


        public void AddTeacherToLesson(Teacher teacher, School school)
        {
            if (!PresenceOfElementsInSchool.IsTeacherInSchool(teacher, school, out Teacher teacherInSchool))
            {
                Console.WriteLine("Этот учитель не добавлен в урок \n");
                return;
            }
            TeacherOfLesson = teacherInSchool;
            Console.WriteLine($"Учитель {TeacherOfLesson.FirstName} {TeacherOfLesson.LastName} добавлен в урок \n");
        }


        public static Lesson CreateLesson()
        {
            Console.WriteLine("Введите название урока: ");
            string lessonName = Console.ReadLine();
            return new Lesson(lessonName);

        }
    }
}

using SchoolProject.SchoolElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Schools
{
    internal static class PresenceOfElementsInSchool
    {
        public static bool IsStudentInSchool(Student student, School school)
        {
            foreach (Student studentFromSchool in school.Students)
            {
                if (studentFromSchool.FirstName == student.FirstName && studentFromSchool.LastName == student.LastName)
                {
                    return true;
                }

            }
            return false;
        }

        public static bool IsTeacherInSchool(Teacher teacher, School school)
        {
            foreach (var teacherFromSchool in school.Teachers)
            {
                if (teacherFromSchool.FirstName == teacher.FirstName && teacherFromSchool.LastName == teacher.LastName)
                {
                    return true;
                }
            }
            return false;
        }


        public static bool IsClassroomInSchool(Classroom classroom, School school)
        {
            foreach (var classroomFromSchool in school.Classrooms)
            {
                if (classroomFromSchool.Id == classroom.Id)
                {
                    return true;
                }

            }
            return false;
        }

        public static bool IsGroupInSchool(Group group, School school)
        {
            foreach (var groupFromSchool in school.Groups)
            {
                if (groupFromSchool.Name == group.Name) return true;
            }
            return false;
        }


        public static bool IsLessonInSchool(Lesson lesson, School school)
        {
            foreach (var lessonFromSchool in school.Lessons)
            {
                if (lessonFromSchool.NameOfLesson == lesson.NameOfLesson) return true;
            }
            return true;
        }
    }
}

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
        public static bool IsStudentInSchool(Student student, School school,out Student studentInSchool)
        {
            Console.WriteLine("Есть ли такой студент в школе? ");
            if (!IsStudent(student, school))
            {
                Console.WriteLine("Такого студента нет в школе");
                studentInSchool = null;
                return false;
            }
             studentInSchool=school.Students.Where(x=>x.FirstName==student.FirstName&&x.LastName==student.LastName).First();
            return true;
        }


        public static bool IsGroupInSchool(Group group, School school)
        {
            Console.WriteLine("Есть ли такая группа в школе? ");
            if (!IsGroup(group, school))
            {
                Console.WriteLine("Такой группы нет в школе");
                return false;
            }
            return true;
        }

        public static bool IsClassroomInSchool(Classroom classroom, School school)
        {

            Console.WriteLine("Есть ли такая аудитория в школе? ");
            if (!IsClassroom(classroom, school))
            {
                Console.WriteLine("Такой аудитории нет в школе");
                return false;
            }
            return true;
        }


        public static bool IsTeacherInSchool(Teacher teacher, School school)
        {
            Console.WriteLine("Есть ли такой учитель в школе? ");
            if (!IsTeacher(teacher, school))
            {
                Console.WriteLine("Такого учителя нет в школе");
                return false;
            }
            return true;
        }


        public static bool IsLessonInSchool(Lesson lesson, School school)
        {
            Console.WriteLine("Есть ли такой учитель в школе? ");
            if (!IsLesson(lesson, school))
            {
                Console.WriteLine("Такого учителя нет в школе");
                return false;
            }
            return true;

        }

        public static bool IsStudent(Student student, School school)
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

        public static bool IsTeacher(Teacher teacher, School school)
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


        public static bool IsClassroom(Classroom classroom, School school)
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

        public static bool IsGroup(Group group, School school)
        {
            foreach (var groupFromSchool in school.Groups)
            {
                if (groupFromSchool.Name == group.Name) return true;
            }
            return false;
        }


        public static bool IsLesson(Lesson lesson, School school)
        {
            foreach (var lessonFromSchool in school.Lessons)
            {
                if (lessonFromSchool.NameOfLesson == lesson.NameOfLesson) return true;
            }
            return true;
        }
    }
}

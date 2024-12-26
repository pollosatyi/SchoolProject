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
            Console.WriteLine("Проверка: Есть ли такой студент в школе? ");
            PrintResultCheck();
            if (!IsStudent(student, school))
            {
                Console.WriteLine("Такого студента нет в школе \n");
                studentInSchool = null;
                return false;
            }
            Console.WriteLine("Такой студент есть в школе \n");
             studentInSchool=school.Students.Where(x=>x.FirstName==student.FirstName&&x.LastName==student.LastName).First();
            return true;
        }


        public static bool IsGroupInSchool(Group group, School school, out Group groupInSchool)
        {
            Console.WriteLine("Проверка: Есть ли такая группа в школе? ");
            PrintResultCheck();
            if (!IsGroup(group, school))
            {
                Console.WriteLine("Такой группы нет в школе \n");
                groupInSchool = null;
                return false;
            }
            Console.WriteLine("Такая группа есть в школе \n");
            groupInSchool=school.Groups.Where(x=>x.Name==group.Name).First();
            return true;
        }

        public static bool IsClassroomInSchool(Classroom classroom, School school,out Classroom classroomInSchool)
        {

            Console.WriteLine("Проверка: Есть ли такая аудитория в школе? ");
            PrintResultCheck();
            if (!IsClassroom(classroom, school))
            {
                Console.WriteLine("Такой аудитории нет в школе \n");
                classroomInSchool = null;
                return false;
            }
            Console.WriteLine("Такая аудитория есть \n");
            classroomInSchool = school.Classrooms.Where(x => x.Id == classroom.Id).First();
            return true;
        }


        public static bool IsTeacherInSchool(Teacher teacher, School school,out Teacher teacherInSchool)
        {
            Console.WriteLine("Проверка: Есть ли такой учитель в школе? ");
            PrintResultCheck();
            if (!IsTeacher(teacher, school))
            {
                Console.WriteLine("Такого учителя нет в школе \n");
                teacherInSchool = null;
                return false;
            }
            Console.WriteLine("Такой учитель есть в школе \n");
            teacherInSchool=school.Teachers.Where(x=>x.FirstName==teacher.FirstName&&x.LastName==teacher.LastName).First();
            return true;
        }


        public static bool IsLessonInSchool(Lesson lesson, School school, out Lesson lessonInSchool)
        {
            Console.WriteLine("Проверка: Есть ли такой урок в школе? ");
            PrintResultCheck();
            if (!IsLesson(lesson, school))
            {
                Console.WriteLine("Такого урока нет в школе \n");
                lessonInSchool = null;
                return false;
            }
            Console.WriteLine("Такой урок есть в школе \n");
            lessonInSchool = school.Lessons.Where(x => x.NameOfLesson == lesson.NameOfLesson).First();
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

        public static void PrintResultCheck()
        {
            Console.WriteLine("Результат проверки: ");
        }
    }
}

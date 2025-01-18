using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolProject.Print;
using SchoolProject.SchoolElements;

namespace SchoolProject.Schools
{
    internal class School
    {
        public string Name { get; set; }

        public List<Classroom> Classrooms { get; set; }

        public List<Group> Groups { get; set; }

        public List<Teacher> Teachers { get; set; }

        public List<Student> Students { get; set; }

        public List<Lesson> Lessons { get; set; }

        public School(string name)
        {
            Name = name;
            Classrooms = new List<Classroom>();
            Groups = new List<Group>();
            Teachers = new List<Teacher>();
            Students = new List<Student>();
            Lessons = new List<Lesson>();

        }

        public void AddStudentToSchool(Student student)
        {
            Students.Add(student);
            PrintAddStudent(student);

        }

        public void AddGroupToSchool(Group group)
        {
            Groups.Add(group);
            PrintAddGroup(group);
        }

        public void AddTeacherToSchool(Teacher teacher)
        {
            Teachers.Add(teacher);
            PrintAddTeacher(teacher);
        }

        public void AddClassroomToSchool(Classroom classroom)
        {
            Classrooms.Add(classroom);
            PrintAddClassroom(classroom);
        }

        public void AddLessonToSchool(Lesson lesson)
        {
            Lessons.Add(lesson);
            PrintAddLesson(lesson);
        }

        public void PrintSchoolAllElements()
        {
            PrintStudentsInSchool();
            PrintGroupsInSchool();
            PrintTeachersInSchool();
            PrintClassroomsInSchool();
            PrintLessonsInSchool();
        }

        public void PrintStudentsInSchool()
        {
            Console.WriteLine("Список студентов: ");
            PrintSchoolElements.PrintStudents(Students);
            Console.WriteLine();
        }

        public void PrintGroupsInSchool()
        {
            Console.WriteLine("Список групп: ");

            foreach (var group in Groups)
            {
                Console.WriteLine("{0,-15}", $"{group.Name}");
            }
            Console.WriteLine();
        }


        public void PrintTeachersInSchool()
        {
            Console.WriteLine("Список учителей: ");
            Console.WriteLine("{0,-15} {1,-15}", "Имя учителя", "Фамилия учителя");
            foreach (var teacher in Teachers)
            {
                Console.WriteLine("{0,-15} {1, -15}", $"{teacher.FirstName}", $"{teacher.LastName}");
            }
            Console.WriteLine();
        }


        public void PrintClassroomsInSchool()
        {
            Console.WriteLine("Список аудиторий: ");
            foreach (var classroom in Classrooms)
            {
                Console.WriteLine(classroom.Id);
            }
            Console.WriteLine();
        }


        public void PrintLessonsInSchool()
        {
            Console.WriteLine("Список уроков: ");
            foreach (var lesson in Lessons)
            {
                Console.WriteLine(lesson.NameOfLesson);
            }
            Console.WriteLine();
        }



        public static void PrintAddStudent(Student student)
        {
            Console.WriteLine($"Студент {student.FirstName} {student.LastName} добавлен в школу \n");
        }


        public static void PrintAddGroup(Group group)
        {
            Console.WriteLine($"Группа {group.Name} добавлена в школу \n");
        }


        public static void PrintAddTeacher(Teacher teacher)
        {
            Console.WriteLine($"Учитель {teacher.FirstName} {teacher.LastName} добавлен в школу \n");
        }


        public static void PrintAddClassroom(Classroom classroom)
        {
            Console.WriteLine($"Аудитория {classroom.Id} добавлена в школу \n");
        }


        public static void PrintAddLesson(Lesson lesson)
        {
            Console.WriteLine($"Урок {lesson.NameOfLesson} добавлен в школу \n");
        }



    }
}

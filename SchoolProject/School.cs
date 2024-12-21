using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject
{
    internal class School
    {
        public string Name {  get; set; }

        public List<Classroom>Classrooms { get; set; }

        public List<Group>Groups { get; set; }

        public List<Teacher> Teachers { get; set; }

        public List<Student> Students { get; set; }

        public List<Lesson> Lessons { get; set; }

        public School(string name)
        {
            Name = name;
            Classrooms= new List<Classroom>();
            Groups = new List<Group>();
            Teachers= new List<Teacher>();
            Students = new List<Student>();
            Lessons = new List<Lesson>();

        }

        public void AddStudentToSchool(Student student)
        {
            Students.Add(student);
        }

        public void AddGroupToSchool(Group group)
        {
            Groups.Add(group);
        }

        public void AddTeacherToSchool(Teacher teacher)
        {
            Teachers.Add(teacher);
        }

        public void AddClassroomToSchool(Classroom classroom)
        {
            Classrooms.Add(classroom);
        }

        public void AddLessonToSchool(Lesson lesson)
        {
            Lessons.Add(lesson);
        }

    }
}

using SchoolProject.AddElements;
using SchoolProject.Menu;
using SchoolProject.SchoolElements;
using SchoolProject.Schools;


namespace SchoolProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            School school = new School("newSchool");
            school.Students = new List<Student>() { new Student("петр", "петров") };
            school.Groups = new List<Group>() { new Group("первая") };
            school.Teachers=new List<Teacher>() { new Teacher("иван", "иванов") };
            school.Classrooms = new List<Classroom>() { new Classroom(1) };
            school.Lessons = new List<Lesson>() { new Lesson("алгебра") };
            MainMenu.MainMenuSelection(school);
            //AddToSchool.CreateSchoolElements(school);
            //AddToGroup.AddStudentToGroup(school.Groups[0], school);
            //school.Groups[0].PrintStudentsInGroup();
            //school.PrintSchoolAllElements();

            //Console.ReadKey();
        }
    }
}

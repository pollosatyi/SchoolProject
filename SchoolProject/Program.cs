namespace SchoolProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            School school = new School("newSchool");
            AddToSchool.CreateSchoolElements(school);
            Console.ReadKey();
        }
    }
}

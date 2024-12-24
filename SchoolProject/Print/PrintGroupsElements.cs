using SchoolProject.SchoolElements;
using SchoolProject.Schools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Print
{
    internal static class PrintGroupsElements
    {

        
        public static void PrintStudentsInGroup(School school)
        {
            PresenceOfElementsInSchool.IsGroupInSchool(FindGroup(), school, out Group groupInSchool);
            PrintSchoolElements.PrintStudents(groupInSchool.Students);
        }



        private static Group FindGroup()
        {
            Console.WriteLine("Введите название группы,котрую нужно распечатать: ");
            string nameGroup=Console.ReadLine();
            return new Group(nameGroup);    

        }
        

    }
}

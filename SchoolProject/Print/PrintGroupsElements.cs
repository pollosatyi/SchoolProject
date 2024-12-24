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
            IsGroupInSchool(Group group, School school, out Group groupInSchool);
            PrintSchoolElements.PrintStudents();
        }



        private static Group FindGroup()
        {


        }
        

    }
}

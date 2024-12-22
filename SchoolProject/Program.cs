﻿using SchoolProject.AddElements;
using SchoolProject.Schools;
using System.Text.RegularExpressions;

namespace SchoolProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            School school = new School("newSchool");
            AddToSchool.CreateSchoolElements(school);
            AddToGroup.AddStudentToGroup(school.Groups[0], school);
            school.Groups[0].PrintStudentsInGroup();
            //school.PrintSchoolAllElements();

            //Console.ReadKey();
        }
    }
}

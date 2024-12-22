using SchoolProject.SchoolElements;
using SchoolProject.Schools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Group = SchoolProject.SchoolElements.Group;

namespace SchoolProject.AddElements
{
    internal static class AddToLesson
    {
        public static void AddElementsToLesson(Lesson lesson,Group group,Classroom classroom,Teacher teacher,School school)
        {
            lesson.AddGroupToLesson(group,school);
            lesson.AddClassroomToLesson(classroom,school);
            lesson.AddTeacherToLesson(teacher,school);

        }
    }
}

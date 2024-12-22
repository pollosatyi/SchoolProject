using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.SchoolElements
{
    internal class Classroom
    {
        public int Id { get; set; }

        public Classroom(int id)
        {
            Id = id;
        }

        public static Classroom CreateClassroom()
        {
            Console.WriteLine("Введите номер аудитории");
            int.TryParse(Console.ReadLine(), out int idClassroom);
            return new Classroom(idClassroom);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home5
{
    internal class StudentsCreator
    {
        Random random = new Random();
        MarkCreator markCreator = new MarkCreator();

        static int id = 0;
        private int minAge = 16;
        private int maxAge = 70;

        string[] studentsNames = { 
            "Duncan", "Luciano", "Maddox", "Israel", "Jaylan",
            "Preston", "Pranav", "Scott", "Aldo", "Cayden",
            "Mason", "Terrence", "Marquise", "Kristopher", "Mario"
        };

        private string RandomName(string[] studentsNames)
        {
            
            int i = random.Next( 0, studentsNames.Length - 1 );
            return studentsNames[i];
        }

        public Student CreateStudent() 
        {
            Student student = new Student();

            student.Id = ++id;
            student.Name = RandomName(studentsNames);
            student.Age = random.Next(minAge, maxAge);
            student.MathMark = markCreator.RandomMark();
            student.PhysicalEducationMark = markCreator.RandomMark();
            student.BiologyMark = markCreator.RandomMark();

            return student;
        }
    }
}

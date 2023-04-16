using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home5
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int MathMark { get; set; }
        public int PhysicalEducationMark { get; set; }
        public int BiologyMark { get; set; }
        public int Reward { get; set; }

        public Student()
        {

        }

        public Student(int id, string name, int age, int mathMark, int physicalEducationMark, int biologyMark, int reward)
        {
            Id = id;
            Name = name;
            Age = age;
            MathMark = mathMark;
            PhysicalEducationMark = physicalEducationMark;
            BiologyMark = biologyMark;
            Reward = reward;
        }
    }
}
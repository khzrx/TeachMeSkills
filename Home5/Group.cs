using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home5
{
    internal class Group
    {
        public string GroupName { get; set; }
        public Student[] Students { get; set; }
        public double AvgMath { get; set; }
        public double AvgPhysicalEducation { get; set; }
        public double AvgBiology { get; set; }
        public double AvgAll { get; set; }


        public Group(int studenCount)
        {
            GroupName = "";
            Students = new Student[studenCount];
            AvgMath = 0;
            AvgPhysicalEducation = 0;
            AvgBiology = 0;
            AvgAll = 0;
        }
        /*
        public Group(string groupName, Student[] students)
        {
            GroupName = groupName;
            Students = students;
        }*/
    }
}
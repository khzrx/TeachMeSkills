using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home5
{
    internal class ShowBestStudents
    {
        public int MathMaxMark(Group group)
        {
            int mathMaxMark = 0;

            for (int i = 0; i < group.Students.Length; i++)
            {
                Student student = group.Students[i];

                if (group.Students[i].MathMark > mathMaxMark)
                {
                    mathMaxMark = student.MathMark;
                }
            }
            return mathMaxMark;
        }

        public void ShowBestMathResults(Group[] groups)
        {
            Console.WriteLine("Best math students:");
            for (int i = 0; i < groups.Length; i++)
            {
                int mathMaxMarkForGroup = MathMaxMark(groups[i]);

                for (int j = 0; j < groups[i].Students.Length; j++)
                {
                    if (groups[i].Students[j].MathMark == mathMaxMarkForGroup)
                    {
                        Console.WriteLine($"{groups[i].GroupName}, {groups[i].Students[j].Name}, Math Mark: {groups[i].Students[j].MathMark}.");
                        break;
                    }
                }
            }
            Console.WriteLine();
        }

        public int PhysicalEducationMaxMark(Group group)
        {
            int physicalEducationMaxMark = 0;

            for (int i = 0; i < group.Students.Length; i++)
            {
                Student student = group.Students[i];

                if (group.Students[i].PhysicalEducationMark > physicalEducationMaxMark)
                {
                    physicalEducationMaxMark = student.PhysicalEducationMark;
                }
            }
            return physicalEducationMaxMark;
        }

        public void ShowBestPhysicalEducationResults(Group[] groups)
        {
            Console.WriteLine("Best physical education students:");
            for (int i = 0; i < groups.Length; i++)
            {
                int physicalEducationMaxMarkForGroup = PhysicalEducationMaxMark(groups[i]);

                for (int j = 0; j < groups[i].Students.Length; j++)
                {
                    if (groups[i].Students[j].PhysicalEducationMark == physicalEducationMaxMarkForGroup)
                    {
                        Console.WriteLine($"{groups[i].GroupName}, {groups[i].Students[j].Name}, Physical Education Mark: {groups[i].Students[j].PhysicalEducationMark}.");
                        break;
                    }
                }
            }
            Console.WriteLine();
        }

        public int BiologyMaxMark(Group group)
        {
            int biologyMaxMark = 0;

            for (int i = 0; i < group.Students.Length; i++)
            {
                Student student = group.Students[i];

                if (group.Students[i].BiologyMark > biologyMaxMark)
                {
                    biologyMaxMark = student.BiologyMark;
                }
            }
            return biologyMaxMark;
        }

        public void ShowBestBiologyResults(Group[] groups)
        {
            Console.WriteLine("Best biology students:");
            for (int i = 0; i < groups.Length; i++)
            {
                int biologyMaxMarkForGroup = BiologyMaxMark(groups[i]);

                for (int j = 0; j < groups[i].Students.Length; j++)
                {
                    if (groups[i].Students[j].BiologyMark == biologyMaxMarkForGroup)
                    {
                        Console.WriteLine($"{groups[i].GroupName}, {groups[i].Students[j].Name}, Biology Mark: {groups[i].Students[j].BiologyMark}.");
                        break;
                    }
                }
            }
            Console.WriteLine();
        }

        public void ShowStudentWithMaxReward(Group[] groups)
        {
            int maxReward = 0;

            for (int i = 0; i < groups.Length; i++)
            {
                for (int j = 0; j < groups[i].Students.Length; j++)
                {
                    if (groups[i].Students[j].Reward > maxReward)
                    {
                        maxReward = groups[i].Students[j].Reward;
                    }
                }
            }

            for (int i = 0; i < groups.Length; i++)
            {
                for (int j = 0; j < groups[i].Students.Length; j++)
                {
                    if (groups[i].Students[j].Reward == maxReward)
                    {
                        Console.WriteLine($"Student with max reward: {groups[i].GroupName} {groups[i].Students[j].Name}, reward: {groups[i].Students[j].Reward}");
                    }
                }
            }
        }
    }
}
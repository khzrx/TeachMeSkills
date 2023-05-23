using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home5
{
    internal class RewardCreator
    {
        Random random = new Random();
        ShowBestStudents show = new ShowBestStudents();

        public void RewardBestMathStudents(Group[] groups)
        {
            for (int i = 0; i < groups.Length; i++)
            {
                int mathMaxMarkForGroup = show.MathMaxMark(groups[i]);

                for (int j = 0; j < groups[i].Students.Length; j++)
                {
                    if (groups[i].Students[j].MathMark == mathMaxMarkForGroup)
                    {
                        groups[i].Students[j].Reward += random.Next(0, 100);
                    }
                }
            }
        }

        public void RewardBestPhysicalEducationStudents(Group[] groups)
        {
            for (int i = 0; i < groups.Length; i++)
            {
                int physicalEducationMaxMark = show.PhysicalEducationMaxMark(groups[i]);

                for (int j = 0; j < groups[i].Students.Length; j++)
                {
                    if (groups[i].Students[j].PhysicalEducationMark == physicalEducationMaxMark)
                    {
                        groups[i].Students[j].Reward += random.Next(0, 100);
                    }
                }
            }
        }

        public void RewardBestBiologyStudents(Group[] groups)
        {
            for (int i = 0; i < groups.Length; i++)
            {
                int biologyMaxMarkForGroup = show.BiologyMaxMark(groups[i]);

                for (int j = 0; j < groups[i].Students.Length; j++)
                {
                    if (groups[i].Students[j].BiologyMark == biologyMaxMarkForGroup)
                    {
                        groups[i].Students[j].Reward += random.Next(0, 100);
                    }
                }
            }
        }

        public void RewardAllStudentsOfGroup(Group group)
        {
            for (int j = 0; j < group.Students.Length; j++)
            {
                    group.Students[j].Reward += random.Next(0, 100);
            }
        }
    }
}
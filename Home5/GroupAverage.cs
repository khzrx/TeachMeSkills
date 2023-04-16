using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home5
{
    internal class GroupAverage
    {
        RewardCreator rewardCreator = new RewardCreator();

        private void CountGroupAverage(Group[] groups)
        {
            for (int i = 0; i < groups.Length; i++)
            {
                double mathMarkSum = 0.0;
                double physicalEducationMarkSum = 0.0;
                double biologyMarkSum = 0.0;

                double discpilineCount = 3.0;

                for (int j = 0; j < groups[i].Students.Length; j++)
                {
                    mathMarkSum += groups[i].Students[j].MathMark;
                    physicalEducationMarkSum += groups[i].Students[j].PhysicalEducationMark;
                    biologyMarkSum += groups[i].Students[j].BiologyMark;

                    groups[i].AvgMath = mathMarkSum / groups[i].Students.Length;
                    groups[i].AvgPhysicalEducation = physicalEducationMarkSum / groups[i].Students.Length;
                    groups[i].AvgBiology = biologyMarkSum / groups[i].Students.Length;

                    groups[i].AvgAll = (groups[i].AvgMath + groups[i].AvgPhysicalEducation + groups[i].AvgBiology) / discpilineCount;
                }
            }
        }

        public void ShowGroupAverage(Group[] groups)
        {
            CountGroupAverage(groups);

            foreach (Group group in groups)
            {
                Console.WriteLine($"Avearage mark of {group.GroupName} Math - {group.AvgMath}, PhysicalEducation - {group.AvgPhysicalEducation}, Biology - {group.AvgBiology}.");
            }

            Console.WriteLine();
        }

        public void RewardBestGroup(Group[] groups)
        {
            CountGroupAverage(groups);

            double bestAverage = groups[0].AvgAll;

            for (int i = 0; i < groups.Length; i++)
            {
                if (groups[i].AvgAll > bestAverage)
                {
                    bestAverage = groups[i].AvgAll;
                }
            }

            for (int i = 0; i < groups.Length; i++)
            {
                if (groups[i].AvgAll == bestAverage)
                {
                    rewardCreator.RewardAllStudentsOfGroup(groups[i]);
                }
            }
        }
    }
}

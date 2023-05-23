using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home5
{
    class GroupsCreator
    {
        public Group[] CreateGroups(int groupsCount, int studentsInGroupsCount)
        {
            Group[] groups = new Group[groupsCount];
            StudentsCreator studentsCreator = new StudentsCreator();

            for (int i = 0; i < groupsCount; i++)
            {
                groups[i] = new Group(studentsInGroupsCount);
                groups[i].GroupName = $"Group {i + 1}";

                for (int j = 0; j < studentsInGroupsCount; j++)
                {
                    groups[i].Students[j] = studentsCreator.CreateStudent();
                }
            }

            return groups;
        }
    }
}
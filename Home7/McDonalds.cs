namespace Home7
{
    internal class McDonalds
    {

        public Staff[] CreateStaff()
        {
            Staff cook = new Cook("John", "Cook");
            Staff manager = new Manager("Dave", "Manager");
            Staff cleaner = new Cleaner("Mark", "Cleaner");

            Staff[] staff = new Staff[3] { cook, manager, cleaner };

            return staff;
        }

        public void StartWork(Staff[] staff)
        {
            for (int i = 0; i < staff.Length; i++)
            {
                staff[i].Work(staff[i]);
            }
        }
    }
}

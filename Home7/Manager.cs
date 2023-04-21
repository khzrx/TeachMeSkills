namespace Home7
{
    internal class Manager : Staff, IManagable, IConflictResolvable, ICookable
    {
        public Manager(string name, string position)
            : base(name, position)
        {
        }

        public override string ToString()
        {
            return $"{Position}";
        }

        public void Manage(Staff staff)
        {
            Console.WriteLine($"{staff.ToString()} {staff.Name} is managing people");
        }
        public void ConfilctResolve(Staff staff)
        {
            Console.WriteLine($"{staff.ToString()} {staff.Name} is solving conflicts");
        }
        public void ToCook(Staff staff)
        {
            Console.WriteLine($"{staff.ToString()} {staff.Name} is cooking");
        }

        public override void Work(Staff staff)
        {
            Manage(staff);
            ConfilctResolve(staff);
            ToCook(staff);
        }
    }
}

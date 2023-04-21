namespace Home7
{
    internal class Cleaner : Staff, ICleanable
    {
        public Cleaner(string name, string position)
            : base(name, position)
        {
        }

        public override string ToString()
        {
            return $"{Position}";
        }

        public void Clean(Staff staff)
        {
            Console.WriteLine($"{staff.ToString()} {staff.Name} is cleaning");
        }

        public override void Work(Staff staff)
        {
            Clean(staff);
        }
    }
}
namespace Home7
{
    abstract class Staff
    {
        public string Name { get; set; }
        public string Position { get; set; }

        public Staff(string name, string position)
        {
            Name = name;
            Position = position;
        }

        public abstract void Work(Staff staff);
    }
}
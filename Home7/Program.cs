namespace Home7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            McDonalds mcDonalds = new McDonalds();
            Staff[] staff = mcDonalds.CreateStaff();
            mcDonalds.StartWork(staff);
        }
    }
}
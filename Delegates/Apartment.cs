namespace Delegates
{
    public class Apartment
    {
        public string name;
        public double price;

        public Apartment(string name)
        {
            Random random = new Random();
            this.name = name;
            this.price = random.Next(30000, 100000);
        }
    }
}

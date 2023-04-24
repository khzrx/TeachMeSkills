using System;

namespace Home8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person john = new Person("John", 1500);
            RationCreator rationCreator = new RationCreator();

            Product egg = new Product("egg", 200);
            Product cake = new Product("cake", 800);
            Product beef = new Product("beef", 500);
            Product milk = new Product("milk", 150);

            List<Product> productList = new List<Product>() { egg, cake, beef, milk };

            john.RationForWeek = rationCreator.CreateRationForWeek(productList);
            john.RationForWeek = john.CheckRation(john);
        }
    }
}
namespace Home8
{
    public class Product
    {
        public string ProductName { get; set; }
        public int Calories { get; set; }

        public Product(string productName, int calories)
        {
            ProductName = productName;
            Calories = calories;
        }
    }
}

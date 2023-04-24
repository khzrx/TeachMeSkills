namespace Home8
{
    public class Ration
    {
        public DayOfTheWeek Day { get; set; }
        public List<Product> ProductList { get; set; }

        public Ration(DayOfTheWeek day, List<Product> productList)
        {
            Day = day;
            ProductList = productList;
        }
    }
}
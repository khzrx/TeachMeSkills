namespace Home8
{
    public class Person
    {
        public string PersonName { get; set; }
        public int CaloriesLimit { get; set; }
        public List<Ration> RationForWeek { get; set; }

        public Person(string personName, int caloriesLimit)
        {
            PersonName = personName;
            CaloriesLimit = caloriesLimit;
        }

        public Person(string personName, int caloriesLimit, List<Ration> rationForWeek)
        {
            PersonName = personName;
            CaloriesLimit = caloriesLimit;
            RationForWeek = rationForWeek;
        }

        public List<Ration> CheckRation(Person person)
        {
            int rationCount = person.RationForWeek.Count();
            for (int i = 0; i < rationCount - 1; i++)
            {
                RationCreator rationCreator = new RationCreator();
                int caloriesSumInRation = rationCreator.CaloriesSumInRation(RationForWeek[i]);

                while (caloriesSumInRation > person.CaloriesLimit)
                {
                    List<Ration> rationList = person.RationForWeek;
                    List<Product> productList = rationList[i].ProductList;
                    productList.RemoveAt(0);
                    caloriesSumInRation = rationCreator.CaloriesSumInRation(RationForWeek[i]);
                }
            }

            return person.RationForWeek;
        }
    }
}
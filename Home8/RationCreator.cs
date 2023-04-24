using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home8
{
    public class RationCreator
    {
        public Ration CreateRationForDay(DayOfTheWeek day, List<Product> productList)
        {
            Random random = new Random();
            List<Product> rationProductList = new List<Product>();

            int mealsCount = random.Next(3, 10); // from 3 to 10 products in ration

            for (int i = 1; i <= mealsCount; i++) 
            {
                rationProductList.Add(productList[random.Next(0, productList.Count() - 1)]);
            }

            Ration ration = new Ration(day, rationProductList);
            return ration;
        }

        public List<Ration> CreateRationForWeek(List<Product> productList)
        {
            List<Ration> rations = new List<Ration>();

            for (int i = 0; i < 7; i++) // 7 - last index of enum DayOfTheWeek
            {
                Ration ration = CreateRationForDay((DayOfTheWeek)i, productList);
                rations.Add(ration);
            }

            return rations;
        }

        public int CaloriesSumInRation(Ration ration)
        {
            int caloriesSum = 0;
            List<Product> productListInRation = ration.ProductList;
            
            for (int i = 0; i < productListInRation.Count; i++)
            {
                caloriesSum += productListInRation[i].Calories;
            }

            return caloriesSum;
        }
    }
}

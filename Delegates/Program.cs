using System;

namespace Delegates
{
    internal class Program
    {

        static void Main(string[] args)
        {
            var monitoring = new Monitoring(ShowAveragePrice);
            var agency = new Agency();
            monitoring.notify += agency.LowAveragePriceNotification;

            List<Apartment> apartments = new List<Apartment>()
            {
                new Apartment("house1"),
                new Apartment("house2"),
                new Apartment("house3")
            };

            monitoring.PutNewApartments(apartments, 70000);
            monitoring.ShowPrice(apartments);

        }
        public static void ShowAveragePrice(List<Apartment> apartments)
        {
            double averagePrice = apartments.Average(a => a.price);
            Console.WriteLine($"Average price: {averagePrice}");
        }

    }
}
namespace Delegates
{
    public class Monitoring
    {
        public Action<List<Apartment>> ShowPrice;
        public event Action<List<Apartment>> notify;
        List<Apartment> apt = new List<Apartment>();

        public Monitoring(Action<List<Apartment>> showprice)
        {
            ShowPrice = showprice;
        }

        public void PutNewApartments(List<Apartment> apts, double priceForCheck)
        {
            apt.AddRange(apts);
            double averagePrice = apt.Average(a => a.price);
            if (averagePrice < priceForCheck) notify(apt);
        }

    }
}
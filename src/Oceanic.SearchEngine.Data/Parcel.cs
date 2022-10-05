namespace Oceanic.SearchEngine.Data
{
    public class Parcel
    {
        public Parcel(City from, 
            City to, 
            List<City> stops, 
            ParcelType parcelType, 
            ParcelSize parcelSize,
            float price,
            float weight)
        {
            From = from;
            To = to;
            Stops = stops;
            Type = parcelType;
            Size = parcelSize;
            Price = price;
            Weight = weight;
        }
        public City From { get; set; }
        public City To { get; set; }
        public List<City> Stops { get; set; }
        public float Price { get; set; }
        public ParcelType Type { get; set; } 
        public ParcelSize Size { get; set; }
        public float Weight { get; set; }
    }

    public enum ParcelSize
    {
        A,
        B,
        C
    }

    public enum ParcelType
    {
        Animals,
        Guns,
        Fragile,
        Other
    }
}
namespace Oceanic.SearchEngine.Data
{
    public class Route
    {
        public Route(City origin, 
            City destination, 
            RouteOwner owner,
            int travelTime)
        {
            Origin = origin;
            Destination = destination;
            Owner = owner;
            TravelTime = travelTime;
        }

        public City Origin { get; set; }
        public City Destination { get; set; }
        public RouteOwner Owner { get; set; }
        public int TravelTime { get; set; }

    }

    public enum RouteOwner
    {
        Oceanic,
        Telstar,
        EastIndia
    }
}
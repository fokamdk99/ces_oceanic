namespace Oceanic.SearchEngine.Data.AppEntities
{
    public class Route : AuditableEntity
    {
        public long Id { get; set; }
        public virtual City Origin { get; set; }
        public virtual City Destination { get; set; }
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
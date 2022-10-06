namespace Oceanic.SearchEngine.Data.AppEntities
{
    public class Route : AuditableEntity
    {
        public long Id { get; set; }
        public long OriginId { get; set; }
        public long DestinationId { get; set; }
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
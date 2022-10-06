namespace Oceanic.SearchEngine.Data.AppEntities
{
    public class ParcelToCity : AuditableEntity
    {
        public long Id { get; set; }
        public long CityId { get; set; }
        public long ParcelId { get; set; }
    }
}

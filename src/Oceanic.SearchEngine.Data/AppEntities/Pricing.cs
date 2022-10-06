namespace Oceanic.SearchEngine.Data.AppEntities
{
    public class Pricing : AuditableEntity
    {
        public long Id { get; set; }
        public ParcelSize ParcelSize { get; set; }
        public float Weight { get; set; }
        public float Price { get; set; }
    }
}
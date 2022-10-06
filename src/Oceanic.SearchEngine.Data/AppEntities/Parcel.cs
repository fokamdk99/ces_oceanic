namespace Oceanic.SearchEngine.Data.AppEntities
{
    public class Parcel : AuditableEntity
    {
        public long Id { get; set; }
        public virtual long FromId { get; set; }
        public virtual long ToId { get; set; }
        public virtual List<ParcelToCity> Stops { get; set; }
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
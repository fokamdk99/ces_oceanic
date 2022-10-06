namespace Oceanic.SearchEngine.Data.AppEntities
{
    public class City : AuditableEntity
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }
}
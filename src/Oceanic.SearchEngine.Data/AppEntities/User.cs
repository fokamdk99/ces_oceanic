namespace Oceanic.SearchEngine.Data.AppEntities
{
    public class User : AuditableEntity
    {
        public long Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }
    }

    public enum Role
    {
        RegularUser,
        Administrator
    }
}
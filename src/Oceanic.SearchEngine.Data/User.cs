namespace Oceanic.SearchEngine.Data
{
    public class User
    {
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
namespace TaxiManager.Domain
{
    public class User : BaseEntity
    {
        private string _username;
        public string Username
        {
            get => _username;
            set => _username = value.ToLower();
        }
        public string Password { get; set; }
        public Role Role { get; set; }

        public User() { }
        public User(string username, string password, Role role)
        {
            Username = username;
            Password = password;
            Role = role;
        }

        public override string Print()
        {
            return $"{Username} with the role of {Role}!";
        }
    }
}

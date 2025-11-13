namespace NotificationSystem.Models
{
    public class User : IUser
    {
        public string Name { get; }
        public string Email { get; }
        public string Phone { get; }

        public User(string name, string email, string phone)
        {
            Name = name;
            Email = email;
            Phone = phone;
        }
    }
}
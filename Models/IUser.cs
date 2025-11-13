namespace NotificationSystem.Models
{
    public interface IUser
    {
        string Name { get; }
        string Email { get; }
        string Phone { get; }
    }
}
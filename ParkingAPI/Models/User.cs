using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace ParkingAPI.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Role { get; set; } = "User";

        public User() { }
        public User(string name, string password, string role)
        {
            Name = name;
            Password = password;
            Role = role;
        }
    }
}

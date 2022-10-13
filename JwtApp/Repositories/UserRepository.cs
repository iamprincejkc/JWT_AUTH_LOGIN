using JwtApp.Models;

namespace JwtApp.Repositories;

public class UserRepository
{
    public static List<User> Users = new()
    { 
         new()  { Username = "user1", EmailAddress = "user. admin@email. com", Password = "Passw0rd", GivenName = "Luke", Surname = "Rogers", Role = "Administrator" },
         new() { Username = "user2", EmailAddress = "user. standard@email. com", Password = "Passw0rd", GivenName = "Elyse", Surname = "Burton", Role = "Standard" },
    };
}

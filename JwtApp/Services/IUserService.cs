using JwtApp.Models;

namespace JwtApp.Services;

public interface IUserService
{
    public User Get(UserLogin userLogin);
}

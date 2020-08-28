using DevBoost.JWT.Model;

namespace DevBoost.JWT.Service
{
    public interface IUserRepository
    {
        User Get(string username, string password);
    }
}

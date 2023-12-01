using market.Models;

namespace market.Services
{
    public interface IUsers
    {
        IEnumerable<Users> GetAll();
    }
}

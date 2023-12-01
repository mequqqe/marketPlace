using market.Data;
using market.Models;

namespace market.Services
{
    public class UserServices : IUsers
    {
        private ApplicationDbContext _dbcontext;

        public UserServices(ApplicationDbContext dbContextData)
        {
            _dbcontext = dbContextData;
        }
        public IEnumerable<Users> GetAll()
        {
            return _dbcontext.Users;
        }

    }
}

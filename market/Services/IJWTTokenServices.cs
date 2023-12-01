using market.Models;

namespace market.Services
{
    public interface IJWTTokenServices
    {
        JWTTokens Authenticate(Users users);
    }
}

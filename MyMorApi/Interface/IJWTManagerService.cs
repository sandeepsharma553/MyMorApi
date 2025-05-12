using MyMorApi.DBModel;
using MyMorApi.Models;

namespace MyMorApi.Interface
{
    public interface IJWTManagerService
    {
        Tokens Authenticate(Login login);
    }
}

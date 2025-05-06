using MyMorApi.DBModel;
using MyMorApi.Models;

namespace MyMorApi.Interface
{
    public interface IAuthService
    {
        public Task<ResponseModel<UserModel>> Login(LoginModel login);
    }
}

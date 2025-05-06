using MyMorApi.DBModel;
using MyMorApi.Models;

namespace MyMorApi.Interface
{
    public interface IUserService
    {
        public Task<ResponseModel<UserModel>> Signup(UserModel user);
    }
}

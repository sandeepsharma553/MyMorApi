using MyMorApi.DBModel;
using MyMorApi.Models;

namespace MyMorApi.Interface
{
    public interface IUserService
    {
        public Task<ResponseModel<Login>> Login(Login user);
    }
}

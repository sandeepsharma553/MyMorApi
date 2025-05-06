using Microsoft.EntityFrameworkCore;
using MyMorApi.Context;
using MyMorApi.DBModel;
using MyMorApi.Interface;
using MyMorApi.Models;

namespace MyMorApi.Service
{
    public class UserService : IUserService
    {
        private readonly dbContext _context;
        public UserService(dbContext context)
        {
            _context = context;
        }

        public async Task<ResponseModel<UserModel>> Signup(UserModel user)
        {
            ResponseModel<UserModel> response = new ResponseModel<UserModel>();
            try
            {
                var res = await _context.User.Where(x => x.EmailID == user.EmailID).FirstOrDefaultAsync();
                if (res == null)
                {
                    response.IsSuccess = true;
                    response.Message = "User created successfully";
                }
                else
                {
                    response.IsSuccess = false;
                    response.Message = "User already exist";
                }
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "something went wrong";

            }
            return response;
        }
    }
}

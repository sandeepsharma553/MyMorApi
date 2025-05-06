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

        public async Task<ResponseModel<Login>> Login(Login user)
        {
            ResponseModel<Login> response = new ResponseModel<Login>();
            try
            {
                Login model = await _context.Login.Where(x => x.LoginID == user.LoginID && x.Password == user.Password).FirstOrDefaultAsync();
                if (model != null)
                {
                    response.IsSuccess = true;
                    response.Data = model;
                }
                else
                {
                    response.IsSuccess = false;
                }
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;

            }
            return response;
        }
    }
}

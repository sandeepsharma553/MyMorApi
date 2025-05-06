using Microsoft.EntityFrameworkCore;
using MyMorApi.Context;
using MyMorApi.DBModel;
using MyMorApi.Interface;
using MyMorApi.Models;

namespace MyMorApi.Service
{
    public class AuthService: IAuthService
    {
        private readonly dbContext _context;
        public AuthService(dbContext context)
        {
            _context = context;
        }
        public async Task<ResponseModel<UserModel>> Login(LoginModel login)
        {
            ResponseModel<UserModel> response = new ResponseModel<UserModel>();
            UserModel userModel = new UserModel();
            try
            {
                var res = await _context.User.Where(x => x.EmailID == login.EmailID).FirstOrDefaultAsync();
                if (res != null)
                {

                    Login model = await _context.Login.Where(x => x.LoginID == login.EmailID && x.Password == login.Password).FirstOrDefaultAsync();
                    if (model != null)
                    {
                        userModel.UserID = model.UserID;
                        userModel.Username = model.User.UserName;
                        userModel.EmailID = model.LoginID;
                        response.IsSuccess = true;
                        response.Data = userModel;
                        response.Message = "Success";
                    }
                    else
                    {
                        response.IsSuccess = false;
                        response.Message = "invaild username and password";
                    }
                }
                else
                {
                    response.IsSuccess = false;
                    response.Message = "User not exist";
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

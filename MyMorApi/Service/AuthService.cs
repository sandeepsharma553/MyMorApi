using Microsoft.EntityFrameworkCore;
using MyMorApi.Common;
using MyMorApi.Context;
using MyMorApi.DBModel;
using MyMorApi.Interface;
using MyMorApi.Models;

namespace MyMorApi.Service
{
    public class AuthService : IAuthService
    {
        private readonly dbContext _context;
        private readonly IJWTManagerService _jWTManager;
        public AuthService(dbContext context, IJWTManagerService jWTManager)
        {
            _context = context;
            _jWTManager = jWTManager;
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
                        userModel.Token = _jWTManager.Authenticate(model).Token;
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
                ExceptionLogger.LogError("Auth_Login", ex);

            }
            return response;
        }
        public static string GenerateVerificationCode(int length = 4)
        {
            var random = new Random();
            var code = "";
            for (int i = 0; i < length; i++)
            {
                code += random.Next(0, 10); // Digits only
            }
            return code;
        }

        public async Task<ResponseModel<UserModel>> VerifyEmail(UserModel model)
        {
            ResponseModel<UserModel> response = new ResponseModel<UserModel>();
            UserModel userModel = new UserModel();
            try
            {
                var res = await _context.User.Where(x => x.EmailID == model.EmailID).FirstOrDefaultAsync();
                if (res == null)
                {
                    string VerifyCode = GenerateVerificationCode();
                    userModel.VerifyCode = VerifyCode;
                    await SendMail.SendVerificationEmailAsync(model.EmailID, VerifyCode);
                    response.IsSuccess = true;
                    response.Data = userModel;
                    response.Message = "Success";
                }
                else
                {
                    response.IsSuccess = false;
                    response.Message = "Email ID already exist";
                }
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "something went wrong";
                ExceptionLogger.LogError("Login_SendMail", ex);
            }
            return response;
        }
    }
}

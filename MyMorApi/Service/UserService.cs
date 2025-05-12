using Microsoft.EntityFrameworkCore;
using MyMorApi.Common;
using MyMorApi.Context;
using MyMorApi.DBModel;
using MyMorApi.Interface;
using MyMorApi.Models;

namespace MyMorApi.Service
{
    public class UserService : IUserService
    {
        private readonly dbContext _context;
        private readonly IJWTManagerService _jWTManager;
        public UserService(dbContext context, IJWTManagerService jWTManager)
        {
            _context = context;
            _jWTManager = jWTManager;
        }

        public async Task<ResponseModel<UserModel>> Signup(UserModel model)
        {
            ResponseModel<UserModel> response = new ResponseModel<UserModel>();
            try
            {
                var res = await _context.User.Where(x => x.EmailID == model.EmailID).FirstOrDefaultAsync();
                if (res == null)
                {
                    User user = new User();
                    user.FirstName = model.FirstName;
                    user.LastName = model.LastName;
                    user.Address = model.Address;
                    user.UserName = model.FirstName + model.LastName;
                    user.EmailID = model.EmailID;
                    user.UniversityID = model.UniversityID;
                    user.HostelID = model.HostelID;
                    user.CreatedBy = 1;
                    user.CreatedDate = DateTime.UtcNow;
                    _context.Add(user);
                    _context.SaveChanges();
                    Login login = new Login();
                    login.LoginID = user.EmailID;
                    login.Password = user.UserName;
                    login.UserID = user.ID;
                    login.CreatedBy = 1;
                    login.CreatedDate = DateTime.UtcNow;
                    _context.Add(user);
                    _context.SaveChanges();
                    model.Token = _jWTManager.Authenticate(login).Token;
                    response.IsSuccess = true;
                    response.Message = "User created successfully";
                    response.Data = model;
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
                ExceptionLogger.LogError("User_SignUp", ex);
            }
            return response;
        }
        public static string GenerateVerificationCode(int length = 6)
        {
            var random = new Random();
            var code = "";
            for (int i = 0; i < length; i++)
            {
                code += random.Next(0, 10); // Digits only
            }
            return code;
        }

        public async Task<ResponseModel<UserModel>> UpdateUser(UserModel model)
        {
            ResponseModel<UserModel> response = new ResponseModel<UserModel>();
            try
            {
                var res = await _context.Login.Where(x => x.LoginID == model.EmailID).FirstOrDefaultAsync();
                if (res != null)
                {
                    res.Password = model.Password;
                    res.UpdatedBy = 1;
                    res.UpdatedDate = DateTime.UtcNow;
                    var user = await _context.User.Where(x => x.EmailID == model.EmailID).FirstOrDefaultAsync();
                    user.FirstName = model.FirstName;
                    user.LastName = model.LastName;
                    user.MobileNo = model.MobileNo;
                    user.Address = model.Address;
                    _context.SaveChanges();
                    response.IsSuccess = true;
                    response.Message = "User updated successfully";
                    response.Data = model;
                }
                else
                {
                    response.IsSuccess = false;
                    response.Message = "User not found";
                }
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "something went wrong";
                ExceptionLogger.LogError("User_UpdateUser", ex);
            }
            return response;
        }
    }
}

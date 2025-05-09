using MyMorApi.Common;
using MyMorApi.Context;
using MyMorApi.Interface;
using MyMorApi.Model;
using MyMorApi.Models;

namespace MyMorApi.Service
{
    public class DiningMenuService : IDiningMenuService
    {
        private readonly dbContext _context;
        public DiningMenuService(dbContext context)
        {
            _context = context;
        }
        public async Task<ResponseModel<DiningMenuModel>> Create(DiningMenuModel model)
        {
            ResponseModel<DiningMenuModel> response = new ResponseModel<DiningMenuModel>();
            try
            {
                //var res = await null;
                //if (res == null)
                //{
                response.IsSuccess = true;
                response.Message = "created successfully";
                //}
                //else
                //{
                //    response.IsSuccess = false;
                //    response.Message = "User already exist";
                //}
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Error : " + "Something went wrong. Please contact Admin";
                ExceptionLogger.LogError("Announcement_Create", ex);

            }
            return response;
        }

        public async Task<ResponseModel<DiningMenuModel>> Delete(DiningMenuModel model)
        {
            ResponseModel<DiningMenuModel> response = new ResponseModel<DiningMenuModel>();
            try
            {
                //var res = await null;
                //if (res == null)
                //{
                response.IsSuccess = true;
                response.Message = "created successfully";
                //}
                //else
                //{
                //    response.IsSuccess = false;
                //    response.Message = "User already exist";
                //}
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Error : " + "Something went wrong. Please contact Admin";
                ExceptionLogger.LogError("Announcement_Create", ex);

            }
            return response;
        }

        public async Task<ResponseModel<DiningMenuModel>> Get(DiningMenuModel model)
        {
            ResponseModel<DiningMenuModel> response = new ResponseModel<DiningMenuModel>();
            try
            {
                //var res = await null;
                //if (res == null)
                //{
                response.IsSuccess = true;
                response.Message = "created successfully";
                //}
                //else
                //{
                //    response.IsSuccess = false;
                //    response.Message = "User already exist";
                //}
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Error : " + "Something went wrong. Please contact Admin";
                ExceptionLogger.LogError("Announcement_Create", ex);

            }
            return response;
        }

        public async Task<ResponseModel<DiningMenuModel>> Update(DiningMenuModel model)
        {
            ResponseModel<DiningMenuModel> response = new ResponseModel<DiningMenuModel>();
            try
            {
                //var res = await null;
                //if (res == null)
                //{
                response.IsSuccess = true;
                response.Message = "created successfully";
                //}
                //else
                //{
                //    response.IsSuccess = false;
                //    response.Message = "User already exist";
                //}
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Error : " + "Something went wrong. Please contact Admin";
                ExceptionLogger.LogError("Announcement_Create", ex);

            }
            return response;
        }
    }
}

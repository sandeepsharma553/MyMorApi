using MyMorApi.Common;
using MyMorApi.Context;
using MyMorApi.DBModel;
using MyMorApi.Interface;
using MyMorApi.Model;
using MyMorApi.Models;

namespace MyMorApi.Service
{
    public class AnnouncementService : IAnnouncementService
    {
        private readonly dbContext _context;
        public async Task<ResponseModel<AnnouncementModel>> Create(AnnouncementModel model)
        {
            ResponseModel<AnnouncementModel> response = new ResponseModel<AnnouncementModel>();
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

        public async Task<ResponseModel<AnnouncementModel>> Delete(AnnouncementModel model)
        {
            ResponseModel<AnnouncementModel> response = new ResponseModel<AnnouncementModel>();
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

        public async Task<ResponseModel<AnnouncementModel>> Get(AnnouncementModel model)
        {
            ResponseModel<AnnouncementModel> response = new ResponseModel<AnnouncementModel>();
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

        public async Task<ResponseModel<AnnouncementModel>> Update(AnnouncementModel model)
        {
            ResponseModel<AnnouncementModel> response = new ResponseModel<AnnouncementModel>();
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

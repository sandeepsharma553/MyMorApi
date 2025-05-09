using MyMorApi.Common;
using MyMorApi.Context;
using MyMorApi.Interface;
using MyMorApi.Model;
using MyMorApi.Models;

namespace MyMorApi.Service
{
    public class CleaningScheduleService : ICleaningScheduleService
    {
        private readonly dbContext _context;
        public CleaningScheduleService(dbContext context)
        {
            _context = context;
        }
        public async Task<ResponseModel<CleaningScheduleModel>> Create(CleaningScheduleModel model)
        {
            ResponseModel<CleaningScheduleModel> response = new ResponseModel<CleaningScheduleModel>();
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

        public async Task<ResponseModel<CleaningScheduleModel>> Delete(CleaningScheduleModel model)
        {
            ResponseModel<CleaningScheduleModel> response = new ResponseModel<CleaningScheduleModel>();
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

        public async Task<ResponseModel<CleaningScheduleModel>> Get(CleaningScheduleModel model)
        {
            ResponseModel<CleaningScheduleModel> response = new ResponseModel<CleaningScheduleModel>();
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

        public async Task<ResponseModel<CleaningScheduleModel>> Update(CleaningScheduleModel model)
        {
            ResponseModel<CleaningScheduleModel> response = new ResponseModel<CleaningScheduleModel>();
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

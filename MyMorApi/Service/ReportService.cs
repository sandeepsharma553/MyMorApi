using MyMorApi.Common;
using MyMorApi.Context;
using MyMorApi.Interface;
using MyMorApi.Model;
using MyMorApi.Models;

namespace MyMorApi.Service
{
    public class ReportService : IReportService
    {
        private readonly dbContext _context;
        public ReportService(dbContext context)
        {
            _context = context;
        }
        public async Task<ResponseModel<ReportModel>> Create(ReportModel model)
        {
            ResponseModel<ReportModel> response = new ResponseModel<ReportModel>();
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

        public async Task<ResponseModel<ReportModel>> Delete(ReportModel model)
        {
            ResponseModel<ReportModel> response = new ResponseModel<ReportModel>();
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

        public async Task<ResponseModel<ReportModel>> Get(ReportModel model)
        {
            ResponseModel<ReportModel> response = new ResponseModel<ReportModel>();
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

        public async Task<ResponseModel<ReportModel>> Update(ReportModel model)
        {
            ResponseModel<ReportModel> response = new ResponseModel<ReportModel>();
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

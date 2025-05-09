using MyMorApi.Common;
using MyMorApi.Context;
using MyMorApi.Interface;
using MyMorApi.Model;
using MyMorApi.Models;

namespace MyMorApi.Service
{
    public class EventService : IEventService
    {
        private readonly dbContext _context;
        public EventService(dbContext context)
        {
            _context = context;
        }
        public async Task<ResponseModel<EventModel>> Create(EventModel model)
        {
            ResponseModel<EventModel> response = new ResponseModel<EventModel>();
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

        public async Task<ResponseModel<EventModel>> Delete(EventModel model)
        {
            ResponseModel<EventModel> response = new ResponseModel<EventModel>();
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

        public async Task<ResponseModel<EventModel>> Get(EventModel model)
        {
            ResponseModel<EventModel> response = new ResponseModel<EventModel>();
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

        public async Task<ResponseModel<EventModel>> Update(EventModel model)
        {
            ResponseModel<EventModel> response = new ResponseModel<EventModel>();
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

using MyMorApi.Common;
using MyMorApi.Context;
using MyMorApi.Interface;
using MyMorApi.Model;
using MyMorApi.Models;

namespace MyMorApi.Service
{
    public class BookingRoomService : IBookingRoomService
    {
        private readonly dbContext _context;
        public BookingRoomService(dbContext context)
        {
            _context = context;
        }
        public async Task<ResponseModel<BookingRoomModel>> Create(BookingRoomModel model)
        {
            ResponseModel<BookingRoomModel> response = new ResponseModel<BookingRoomModel>();
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

        public async Task<ResponseModel<BookingRoomModel>> Delete(BookingRoomModel model)
        {
            ResponseModel<BookingRoomModel> response = new ResponseModel<BookingRoomModel>();
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

        public async Task<ResponseModel<BookingRoomModel>> Get(BookingRoomModel model)
        {
            ResponseModel<BookingRoomModel> response = new ResponseModel<BookingRoomModel>();
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

        public async Task<ResponseModel<BookingRoomModel>> Update(BookingRoomModel model)
        {
            ResponseModel<BookingRoomModel> response = new ResponseModel<BookingRoomModel>();
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

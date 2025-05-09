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
        public Task<ResponseModel<BookingRoomModel>> Create(BookingRoomModel model)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<BookingRoomModel>> Delete(BookingRoomModel model)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<BookingRoomModel>> Get(BookingRoomModel model)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<BookingRoomModel>> Update(BookingRoomModel model)
        {
            throw new NotImplementedException();
        }
    }
}

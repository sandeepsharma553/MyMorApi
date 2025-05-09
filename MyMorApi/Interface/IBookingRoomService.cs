using MyMorApi.Model;
using MyMorApi.Models;

namespace MyMorApi.Interface
{
    public interface IBookingRoomService
    {
        public Task<ResponseModel<BookingRoomModel>> Get(BookingRoomModel model);
        public Task<ResponseModel<BookingRoomModel>> Create(BookingRoomModel model);
        public Task<ResponseModel<BookingRoomModel>> Update(BookingRoomModel model);
        public Task<ResponseModel<BookingRoomModel>> Delete(BookingRoomModel model);
    }
}

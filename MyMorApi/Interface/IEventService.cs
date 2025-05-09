using MyMorApi.Model;
using MyMorApi.Models;

namespace MyMorApi.Interface
{
    public interface IEventService
    {
        public Task<ResponseModel<EventModel>> Get(EventModel model);
        public Task<ResponseModel<EventModel>> Create(EventModel model);
        public Task<ResponseModel<EventModel>> Update(EventModel model);
        public Task<ResponseModel<EventModel>> Delete(EventModel model);
    }
}

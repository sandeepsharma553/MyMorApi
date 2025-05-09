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
        public Task<ResponseModel<EventModel>> Create(EventModel model)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<EventModel>> Delete(EventModel model)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<EventModel>> Get(EventModel model)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<EventModel>> Update(EventModel model)
        {
            throw new NotImplementedException();
        }
    }
}

using MyMorApi.Context;
using MyMorApi.Interface;
using MyMorApi.Model;
using MyMorApi.Models;

namespace MyMorApi.Service
{
    public class AnnouncementService : IAnnouncementService
    {
        private readonly dbContext _context;
        public Task<ResponseModel<AnnouncementModel>> Create(AnnouncementModel model)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<AnnouncementModel>> Delete(AnnouncementModel model)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<AnnouncementModel>> Get(AnnouncementModel model)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<AnnouncementModel>> Update(AnnouncementModel model)
        {
            throw new NotImplementedException();
        }
    }
}

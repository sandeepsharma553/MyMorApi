using MyMorApi.Model;
using MyMorApi.Models;

namespace MyMorApi.Interface
{
    public interface IAnnouncementService
    {
        public Task<ResponseModel<AnnouncementModel>> Get(AnnouncementModel model);
        public Task<ResponseModel<AnnouncementModel>> Create(AnnouncementModel model);
        public Task<ResponseModel<AnnouncementModel>> Update(AnnouncementModel model);
        public Task<ResponseModel<AnnouncementModel>> Delete(AnnouncementModel model);
    }
}

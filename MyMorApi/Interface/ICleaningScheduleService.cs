using MyMorApi.Model;
using MyMorApi.Models;

namespace MyMorApi.Interface
{
    public interface ICleaningScheduleService
    {
        public Task<ResponseModel<CleaningScheduleModel>> Get(CleaningScheduleModel model);
        public Task<ResponseModel<CleaningScheduleModel>> Create(CleaningScheduleModel model);
        public Task<ResponseModel<CleaningScheduleModel>> Update(CleaningScheduleModel model);
        public Task<ResponseModel<CleaningScheduleModel>> Delete(CleaningScheduleModel model);
    }
}

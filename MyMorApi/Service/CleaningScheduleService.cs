using MyMorApi.Context;
using MyMorApi.Interface;
using MyMorApi.Model;
using MyMorApi.Models;

namespace MyMorApi.Service
{
    public class CleaningScheduleService : ICleaningScheduleService
    {
        private readonly dbContext _context;
        public CleaningScheduleService(dbContext context)
        {
            _context = context;
        }
        public Task<ResponseModel<CleaningScheduleModel>> Create(CleaningScheduleModel model)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<CleaningScheduleModel>> Delete(CleaningScheduleModel model)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<CleaningScheduleModel>> Get(CleaningScheduleModel model)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<CleaningScheduleModel>> Update(CleaningScheduleModel model)
        {
            throw new NotImplementedException();
        }
    }
}

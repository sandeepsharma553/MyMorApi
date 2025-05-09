using MyMorApi.Context;
using MyMorApi.Interface;
using MyMorApi.Model;
using MyMorApi.Models;

namespace MyMorApi.Service
{
    public class MaintenanceService : IMaintenanceService
    {
        private readonly dbContext _context;
        public MaintenanceService(dbContext context)
        {
            _context = context;
        }
        public Task<ResponseModel<MaintenanceModel>> Create(MaintenanceModel model)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<MaintenanceModel>> Delete(MaintenanceModel model)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<MaintenanceModel>> Get(MaintenanceModel model)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<MaintenanceModel>> Update(MaintenanceModel model)
        {
            throw new NotImplementedException();
        }
    }
}

using MyMorApi.Model;
using MyMorApi.Models;

namespace MyMorApi.Interface
{
    public interface IMaintenanceService
    {
        public Task<ResponseModel<MaintenanceModel>> Get(MaintenanceModel model);
        public Task<ResponseModel<MaintenanceModel>> Create(MaintenanceModel model);
        public Task<ResponseModel<MaintenanceModel>> Update(MaintenanceModel model);
        public Task<ResponseModel<MaintenanceModel>> Delete(MaintenanceModel model);
    }
}

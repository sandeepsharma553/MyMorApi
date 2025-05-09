using MyMorApi.Model;
using MyMorApi.Models;

namespace MyMorApi.Interface
{
    public interface IDiningMenuService
    {
        public Task<ResponseModel<DiningMenuModel>> Get(DiningMenuModel model);
        public Task<ResponseModel<DiningMenuModel>> Create(DiningMenuModel model);
        public Task<ResponseModel<DiningMenuModel>> Update(DiningMenuModel model);
        public Task<ResponseModel<DiningMenuModel>> Delete(DiningMenuModel model);
    }
}

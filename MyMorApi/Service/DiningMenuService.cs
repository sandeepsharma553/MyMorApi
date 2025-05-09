using MyMorApi.Context;
using MyMorApi.Interface;
using MyMorApi.Model;
using MyMorApi.Models;

namespace MyMorApi.Service
{
    public class DiningMenuService : IDiningMenuService
    {
        private readonly dbContext _context;
        public DiningMenuService(dbContext context)
        {
            _context = context;
        }
        public Task<ResponseModel<DiningMenuModel>> Create(DiningMenuModel model)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<DiningMenuModel>> Delete(DiningMenuModel model)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<DiningMenuModel>> Get(DiningMenuModel model)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<DiningMenuModel>> Update(DiningMenuModel model)
        {
            throw new NotImplementedException();
        }
    }
}

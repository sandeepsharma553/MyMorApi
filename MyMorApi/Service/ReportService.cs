using MyMorApi.Context;
using MyMorApi.Interface;
using MyMorApi.Model;
using MyMorApi.Models;

namespace MyMorApi.Service
{
    public class ReportService : IReportService
    {
        private readonly dbContext _context;
        public ReportService(dbContext context)
        {
            _context = context;
        }
        public Task<ResponseModel<ReportModel>> Create(ReportModel model)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<ReportModel>> Delete(ReportModel model)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<ReportModel>> Get(ReportModel model)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<ReportModel>> Update(ReportModel model)
        {
            throw new NotImplementedException();
        }
    }
}

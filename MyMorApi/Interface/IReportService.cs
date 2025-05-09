using MyMorApi.Model;
using MyMorApi.Models;

namespace MyMorApi.Interface
{
    public interface IReportService
    {
        public Task<ResponseModel<ReportModel>> Get(ReportModel model);
        public Task<ResponseModel<ReportModel>> Create(ReportModel model);
        public Task<ResponseModel<ReportModel>> Update(ReportModel model);
        public Task<ResponseModel<ReportModel>> Delete(ReportModel model);

    }
}

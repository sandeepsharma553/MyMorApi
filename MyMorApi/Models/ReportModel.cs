using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MyMorApi.Model
{
    public class ReportModel
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public string ReportType { get; set; }
        public string Description { get; set; }
        public DateTime ReportDate { get; set; }
        public string Image { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
      
    }
}

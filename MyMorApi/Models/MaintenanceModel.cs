using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MyMorApi.Model
{
    public class MaintenanceModel
    {
        public int ID { get; set; }
        public int HostelID { get; set; }
        public string RoomNo { get; set; }
        public int ProblemCategoryID { get; set; }
        public int ItemCategoryID { get; set; }
        public int ItemID { get; set; }
        public string Description { get; set; }
        public string Cause { get; set; }
        public string Comments { get; set; }
        public string Image { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
       
    }
}

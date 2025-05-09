using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MyMorApi.Model
{
    public class AnnouncementModel
    {
        public int ID { get; set; }
        public int UniversityID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime AnnouncementDate { get; set; }
        public string AnnouncementType { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }

    }
}

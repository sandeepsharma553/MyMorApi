using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MyMorApi.Model
{
    public class CleaningScheduleModel
    {
        public int ID { get; set; }
        public int HostelID { get; set; }
        public string RoomType { get; set; }
        public string DayOfWeek { get; set; }
        public DateTime CleaningDate { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
        
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyMorApi.Model
{
    public class EventModel
    {
        public int ID { get; set; }
        public int UniversityID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime EventDate { get; set; }
        public TimeSpan EventTime { get; set; }
        public string EventType { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
       
    }
}

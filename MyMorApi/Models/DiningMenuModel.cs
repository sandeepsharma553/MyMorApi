using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MyMorApi.Model
{
    public class DiningMenuModel
    {
       
        public int ID { get; set; }
        public string MealType { get; set; }
        public DateTime MenuDate { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
        
    }
}

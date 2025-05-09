using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MyMorApi.Model
{
    public class EventBookingModel
    {
       
        public int ID { get; set; }
        public int EventID { get; set; }
        public string TicketType { get; set; }
        public double Price { get; set; }
        public int Qty { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
       
    }
}

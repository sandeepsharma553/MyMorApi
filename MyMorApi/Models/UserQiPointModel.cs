using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MyMorApi.Model
{
    public class UserQiPointModel
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public string QIType { get; set; }
        public int CreatedBy { get; set; }      
        public int UpdatedBy { get; set; }
       
    }
}

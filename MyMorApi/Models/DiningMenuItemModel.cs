using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MyMorApi.Model
{
    public class DiningMenuItemModel
    {
     
        public int ID { get; set; }
        public int MenuID { get; set; }
        public int HostelID { get; set; }
        public string Name { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
      
    }
}

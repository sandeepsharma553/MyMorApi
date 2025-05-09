using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MyMorApi.DBModel
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Address { get; set; }
        public string MobileNo { get; set; }
        public string EmailID { get; set; }
        public int UniversityID { get; set; }
        public int HostelID { get; set; }
        public int RoleID { get; set; }
        public int Status { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public University University { get; set; }
        public Hostel Hostel { get; set; }
        public ICollection<Login> Logins { get; set; }
        public ICollection<BookingRoom> BookingRoom { get; set; }
        public ICollection<Report> Report { get; set; }
        public ICollection<UserQiPoint> UserQiPoint { get; set; }
    }
}

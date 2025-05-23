﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MyMorApi.DBModel
{
    public class Hostel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public int UniversityID { get; set; }
        public string Name { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public University University { get; set; }
        public ICollection<User> Users { get; set; }
        public ICollection<DiningMenuItem> DiningMenuItem { get; set; }
        public ICollection<CleaningSchedule> CleaningSchedule { get; set; }
        public ICollection<Maintenance> Maintenance { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using MyMorApi.Configuration;
using MyMorApi.DBModel;

namespace MyMorApi.Context
{
    public class dbContext : DbContext
    {
        public dbContext(DbContextOptions<dbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new LoginConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new UniversityConfiguration());
            modelBuilder.ApplyConfiguration(new HostelConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
        }
        public DbSet<User> User { get; set; }
        public DbSet<Login> Login { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<University> University { get; set; }
        public DbSet<Hostel> Hostel { get; set; }
        public DbSet<Announcement> Announcement { get; set; }
        public DbSet<BookingRoom> BookingRoom { get; set; }
        public DbSet<CleaningSchedule> CleaningSchedule { get; set; }
        public DbSet<DiningMenu> DiningMenu { get; set; }
        public DbSet<DiningMenuItem> DiningMenuItem { get; set; }
        public DbSet<Event> Event { get; set; }
        public DbSet<EventBooking> EventBooking { get; set; }
        public DbSet<Maintenance> Maintenance { get; set; }
        public DbSet<Report> Report { get; set; }
        public DbSet<UserQiPoint> UserQiPoint { get; set; }
    }
}

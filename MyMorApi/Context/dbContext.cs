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
            modelBuilder.ApplyConfiguration(new UserConfiguration());
        }
        public DbSet<User> User
        {
            get;
            set;
        }
        public DbSet<Login> Login
        {
            get;
            set;
        }
    }
}

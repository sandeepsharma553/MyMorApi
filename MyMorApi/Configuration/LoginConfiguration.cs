using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyMorApi.DBModel;
namespace MyMorApi.Configuration
{
    public class LoginConfiguration : IEntityTypeConfiguration<Login>
    {
        public void Configure(EntityTypeBuilder<Login> builder)
        {
            builder.ToTable("Login");
            builder.HasData
            (
                new Login
                {
                    ID = 1,
                    UserID = 1,
                    LoginID = "admin@gmail.com",
                    Password = "12345",
                    Status = 1,
                    CreatedBy = 1,
                    CreatedDate = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 0, 0, 0, DateTimeKind.Utc)
                }
            );
        }
    }
}

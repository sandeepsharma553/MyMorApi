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
                    PKLoginID = 1,
                    FKUserID = 1,
                    LoginID = "Admin",
                    Password = "12345",
                    Status = 1,
                    CreatedBy = 1,
                    CreatedDate = DateTime.UtcNow
                }
            );
        }
    }
}

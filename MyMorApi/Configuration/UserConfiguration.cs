using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyMorApi.DBModel;

namespace MyMorApi.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");
            builder.HasData
            (
                new User
                {
                    PKUserID = 1,
                    FirstName = "Admin",
                    LastName = "",
                    MobileNo = "987654321",
                    EmailID = "admin@gmail.com",
                    FKRoleID = 1,
                    Status = 1,
                    CreatedBy = 1,
                    CreatedDate = DateTime.Now
                }
            );
        }
    }
}

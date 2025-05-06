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
                    ID = 1,
                    FirstName = "Admin",
                    LastName = "",
                    MobileNo = "987654321",
                    EmailID = "admin@gmail.com",
                    Address = "Botswana",
                    UserName="",
                    RoleID = 1,
                    UniversityID=1,
                    HostelID= 1,
                    Status = 1,
                    CreatedBy = 1,
                    CreatedDate = new DateTime(DateTime.Today.Year, 01, 01, 0, 0, 0, DateTimeKind.Utc)
                }
            );
        }
    }
}

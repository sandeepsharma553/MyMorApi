using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyMorApi.DBModel;

namespace MyMorApi.Configuration
{
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.ToTable("Role");
            builder.HasData
            (
                new Role
                {
                    ID = 1,
                    Name ="Admin",
                    CreatedBy = 1,
                    CreatedDate = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 0, 0, 0, DateTimeKind.Utc)
                }
            );
        }
    }
}

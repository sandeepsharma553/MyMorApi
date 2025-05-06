using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using MyMorApi.DBModel;

namespace MyMorApi.Configuration
{
    public class UniversityConfiguration : IEntityTypeConfiguration<University>
    {
        public void Configure(EntityTypeBuilder<University> builder)
        {
            builder.ToTable("University");
            builder.HasData
            (
                new University
                {
                    ID = 1,
                    Name = "Demo",
                    CreatedBy = 1,
                    CreatedDate = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 0, 0, 0, DateTimeKind.Utc)
                }
            );
        }
    }
}

using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using MyMorApi.DBModel;

namespace MyMorApi.Configuration
{
    public class HostelConfiguration : IEntityTypeConfiguration<Hostel>
    {
        public void Configure(EntityTypeBuilder<Hostel> builder)
        {
            builder.ToTable("Hostel");
            builder.HasData
            (
                new Hostel
                {
                    ID = 1,
                    UniversityID = 1,
                    Name = "Demo",
                    CreatedBy = 1,
                    CreatedDate = new DateTime(DateTime.Today.Year, 01, 01, 0, 0, 0, DateTimeKind.Utc)
                }
            );
        }
    }
}

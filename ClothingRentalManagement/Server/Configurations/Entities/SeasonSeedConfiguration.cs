using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ClothingRentalManagement.Shared.Domain;

namespace ClothingRentalManagement.Server.Configurations.Entities
{
    public class SeasonSeedConfiguration : IEntityTypeConfiguration<Season>
    {
        public void Configure(EntityTypeBuilder<Season> builder)
        {
            builder.HasData(
                new Season
                {
                    Id = 1,
                    CreatedBy = "System",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    Name = "Winter",
                    UpdatedBy = "System"
                },
                new Season
                {
                    Id = 2,
                    CreatedBy = "System",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    Name = "Spring",
                    UpdatedBy = "System"
                },
                new Season
                {
                    Id = 3,
                    CreatedBy = "System",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    Name = "Summer",
                    UpdatedBy = "System"
                },
                new Season
                {
                    Id = 4,
                    CreatedBy = "System",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    Name = "Fall",
                    UpdatedBy = "System"
                }
            );
        }
    }
}

using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ClothingRentalManagement.Shared.Domain;

namespace ClothingRentalManagement.Server.Configurations.Entities
{
    public class ApparelTypeSeedConfiguration : IEntityTypeConfiguration<ApparelType>
    {
        public void Configure(EntityTypeBuilder<ApparelType> builder)
        {
            builder.HasData(
                new ApparelType
                {
                    Id = 1,
                    CreatedBy = "System",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    Name = "Top",
                    UpdatedBy = "System"
                },
                new ApparelType
                {
                    Id = 2,
                    CreatedBy = "System",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    Name = "Bottom",
                    UpdatedBy = "System"
                },
                new ApparelType
                {
                    Id = 3,
                    CreatedBy = "System",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    Name = "Dress",
                    UpdatedBy = "System"
                },
                new ApparelType
                {
                    Id = 4,
                    CreatedBy = "System",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    Name = "Hat",
                    UpdatedBy = "System"
                }
            );
        }
    }
}

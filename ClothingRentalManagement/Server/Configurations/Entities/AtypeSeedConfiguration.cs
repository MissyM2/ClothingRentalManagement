using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ClothingRentalManagement.Shared.Domain;

namespace ClothingRentalManagement.Server.Configurations.Entities
{
    public class AtypeSeedConfiguration : IEntityTypeConfiguration<Atype>
    {
        public void Configure(EntityTypeBuilder<Atype> builder)
        {
            builder.HasData(
                new Atype
                {
                    Id = 1,
                    CreatedBy = "System",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    Name = "Top",
                    UpdatedBy = "System"
                },
                new Atype
                {
                    Id = 2,
                    CreatedBy = "System",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    Name = "Bottom",
                    UpdatedBy = "System"
                },
                new Atype
                {
                    Id = 3,
                    CreatedBy = "System",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    Name = "Dress",
                    UpdatedBy = "System"
                },
                new Atype
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

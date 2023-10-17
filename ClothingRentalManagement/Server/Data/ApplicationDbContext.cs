using ClothingRentalManagement.Server.Configurations.Entities;
using ClothingRentalManagement.Server.Models;
using ClothingRentalManagement.Shared.Domain;
using Duende.IdentityServer.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace ClothingRentalManagement.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        public DbSet<ApparelItem> ApparelItems { get; set; }
        public DbSet<ApparelType> ApparelTypes { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Season> Seasons { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<Wearer> Wearers { get; set; }
        public DbSet<Wearing> Wearings { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new ApparelTypeSeedConfiguration());
            builder.ApplyConfiguration(new BrandSeedConfiguration());
            builder.ApplyConfiguration(new ColorSeedConfiguration());
            builder.ApplyConfiguration(new SeasonSeedConfiguration());
            builder.ApplyConfiguration(new SizeSeedConfiguration());
            builder.ApplyConfiguration(new RoleSeedConfiguration());
            builder.ApplyConfiguration(new UserSeedConfiguration());
            builder.ApplyConfiguration(new UserRoleSeedConfiguration());
        }
    }
}
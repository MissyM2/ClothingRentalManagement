using ClothingRentalManagement.Server.Data;
using ClothingRentalManagement.Server.Interfaces;
using ClothingRentalManagement.Shared.Domain;
using Microsoft.EntityFrameworkCore;

namespace ClothingRentalManagement.Server.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private IGenericRepository<Aitem> _aitems;
        private IGenericRepository<Atype> _atypes;
        private IGenericRepository<Brand> _brands;
        private IGenericRepository<Color> _colors;
        private IGenericRepository<Season> _seasons;
        private IGenericRepository<Size> _sizes;
        private IGenericRepository<Wearer> _wearers;
        private IGenericRepository<Wearing> _wearings;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        public IGenericRepository<Aitem> Aitems
            => _aitems ??= new GenericRepository<Aitem>(_context);
        public IGenericRepository<Atype> Atypes
            => _atypes ??= new GenericRepository<Atype>(_context);
        public IGenericRepository<Brand> Brands
            => _brands ??= new GenericRepository<Brand>(_context);
        public IGenericRepository<Color> Colors
            => _colors ??= new GenericRepository<Color>(_context);
        public IGenericRepository<Season> Seasons
            => _seasons ??= new GenericRepository<Season>(_context);
        public IGenericRepository<Size> Sizes
           => _sizes ??= new GenericRepository<Size>(_context);
        public IGenericRepository<Size> Customers
            => _sizes ??= new GenericRepository<Size>(_context);
        public IGenericRepository<Wearer> Wearers
           => _wearers ??= new GenericRepository<Wearer>(_context);
        public IGenericRepository<Wearing> Wearings
            => _wearings ??= new GenericRepository<Wearing>(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save(HttpContext httpContext)
        {
            var user = httpContext.User.Identity.Name;

            var entries = _context.ChangeTracker.Entries()
                .Where(q => q.State == EntityState.Modified ||
                    q.State == EntityState.Added);

            foreach (var entry in entries)
            {
                ((BaseDomainModel)entry.Entity).DateUpdated = DateTime.Now;
                ((BaseDomainModel)entry.Entity).UpdatedBy = user;
                if (entry.State == EntityState.Added)
                {
                    ((BaseDomainModel)entry.Entity).DateCreated = DateTime.Now;
                    ((BaseDomainModel)entry.Entity).CreatedBy = user;
                }
            }

            await _context.SaveChangesAsync();
        }
    }
}

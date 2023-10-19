using ClothingRentalManagement.Shared.Domain;

namespace ClothingRentalManagement.Server.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        Task Save(HttpContext httpContext);
        IGenericRepository<Aitem> Aitems { get; }
        IGenericRepository<Atype> Atypes { get; }
        IGenericRepository<Brand> Brands { get; }
        IGenericRepository<Color> Colors { get; }
        IGenericRepository<Season> Seasons { get; }
        IGenericRepository<Size> Sizes { get; }
        IGenericRepository<Wearer> Wearers { get; }
        IGenericRepository<Wearing> Wearings { get; }
    }
}
using ItemCatalogue.Api.Domain.Interfaces.Repositories;
using ItemCatalogue.Api.Infrastructure.Data.Repositories;

namespace ItemCatalogue.Api.Infrastructure.Data.Context
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _appDbContext;

        private ICatalogueRepository _catalogue;

        public UnitOfWork(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public ICatalogueRepository Catalogue => _catalogue ?? new CatalogueRepository(_appDbContext);

        public async Task SaveChangesAsync()
        {
            await _appDbContext.SaveChangesAsync();
        }
    }
}

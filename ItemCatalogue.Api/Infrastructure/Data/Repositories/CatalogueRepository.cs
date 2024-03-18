using ItemCatalogue.Api.Domain.Interfaces.Repositories;
using ItemCatalogue.Api.Domain.Models;
using ItemCatalogue.Api.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace ItemCatalogue.Api.Infrastructure.Data.Repositories
{
    public class CatalogueRepository : ICatalogueRepository
    {
        private readonly AppDbContext _appDbContext;

        public CatalogueRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<List<Catalogue>> GetAllAsync()
        {
            var catalogues = await _appDbContext.Catalogues.ToListAsync();

            return catalogues;
        }

        public async Task<Catalogue?> GetByIdAsync(int id)
        {
            var catalogue = await _appDbContext.Catalogues.FirstOrDefaultAsync(c => c.Id == id);

            return catalogue;
        }

        public async Task<int> AddAsync(Catalogue catalogue)
        {
            await _appDbContext.Catalogues.AddAsync(catalogue);

            return catalogue.Id;
        }

        public void Update(Catalogue catalogue)
        {
            _appDbContext.Catalogues.Update(catalogue);
        }
    }
}

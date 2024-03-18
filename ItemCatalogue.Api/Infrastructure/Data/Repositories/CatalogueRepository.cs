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
            return await _appDbContext.Catalogues.ToListAsync();
        }

        public async Task<Catalogue?> GetByIdAsync(int id)
        {
            return await _appDbContext.Catalogues.FirstOrDefaultAsync(c => c.Id == id);
        }
    }
}

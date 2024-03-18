using ItemCatalogue.Api.Domain.Models;

namespace ItemCatalogue.Api.Domain.Interfaces.Repositories
{
    public interface ICatalogueRepository
    {
        Task<List<Catalogue>> GetAllAsync();
        Task<Catalogue?> GetByIdAsync(int id);
    }
}

using ItemCatalogue.Api.Shared.DTOs;

namespace ItemCatalogue.Api.Application.Interfaces
{
    public interface ICatalogueService
    {
        Task<IEnumerable<CatalogueItemDto>> GetAllItemsAsync();
        Task<CatalogueItemDto> GetItemByIdAsync(int id);
        Task<int> CreateItemAsync(CreateItemRequest request);
        Task UpdateItemAsync(int id, UpdateItemRequest request);
    }
}

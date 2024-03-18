using ItemCatalogue.Api.Application.Interfaces;
using ItemCatalogue.Api.Domain.Interfaces.Repositories;
using ItemCatalogue.Api.Domain.Models;
using ItemCatalogue.Api.Shared.DTOs;

namespace ItemCatalogue.Api.Application.Implementations
{
    public class CatalogueService : ICatalogueService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CatalogueService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<CatalogueItemDto>> GetAllItemsAsync()
        {
            try
            {
                var catalogues = await _unitOfWork.Catalogue.GetAllAsync();

                var items = catalogues.Select(s => CatalogueItemDto.MapFromDomain(s));

                return items;
            }
            catch (Exception e)
            {
                // Add log
                throw;
            }
        }

        public async Task<CatalogueItemDto> GetItemByIdAsync(int id)
        {
            try
            {

                var catalogue = await _unitOfWork.Catalogue.GetByIdAsync(id);

                var result = new CatalogueItemDto();

                if (catalogue == null)
                {
                    return result;
                }

                return CatalogueItemDto.MapFromDomain(catalogue);
            }
            catch (Exception)
            {
                // Add log
                throw;
            }
        }

        public async Task<int> CreateItemAsync(CreateItemRequest request)
        {
            try
            {
                var catalogue = Catalogue.Create(id: 0, request.Name, request.Description, request.Category);

                var catalogueId = await _unitOfWork.Catalogue.AddAsync(catalogue);

                await _unitOfWork.SaveChangesAsync();

                return catalogueId;
            }
            catch (Exception)
            {
                // Add log
                throw;
            }
        }
        
        public async Task UpdateItemAsync(int id, UpdateItemRequest request)
        {
            try
            {
                var catalogue = Catalogue.Create(id, request.Name, request.Description, request.Category);

                _unitOfWork.Catalogue.Update(catalogue);

                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception)
            {
                // Add log
                throw;
            }
        }
    }
}

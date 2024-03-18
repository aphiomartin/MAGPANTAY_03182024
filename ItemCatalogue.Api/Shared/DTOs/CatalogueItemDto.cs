using ItemCatalogue.Api.Domain.Enums;
using ItemCatalogue.Api.Domain.Models;

namespace ItemCatalogue.Api.Shared.DTOs
{
    public class CatalogueItemDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public CatalogueCategory Category { get; set; }

        public static CatalogueItemDto MapFromDomain(Catalogue catalogue)
        {
            return new CatalogueItemDto
            {
                Id = catalogue.Id,
                Name = catalogue.Name,
                Description = catalogue.Description,
                Category = catalogue.Category,
            };
        }
    }
}

using ItemCatalogue.Api.Domain.Constants;
using ItemCatalogue.Api.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace ItemCatalogue.Api.Shared.DTOs
{
    public class CreateItemRequest
    {
        [Required, StringLength(EntityPropertyLength.Catalogue.NAME_MAX_LENGTH)]
        public string Name { get; set; }
        [Required, StringLength(EntityPropertyLength.Catalogue.DESCRIPTION_MAX_LENGTH)]
        public string Description { get; set; }
        public CatalogueCategory Category { get; set; }
    }
}

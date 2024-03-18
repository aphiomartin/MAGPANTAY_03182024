using ItemCatalogue.Api.Domain.Enums;
using ItemCatalogue.Api.Domain.Exceptions;

namespace ItemCatalogue.Api.Domain.Models
{
    public class Catalogue
    {
        protected Catalogue()
        {

        }

        public int Id { get; private set; }
        public string Name { get; private set; } = null!;
        public string Description { get; private set; } = null!;
        public CatalogueCategory Category { get; private set; }

        public static Catalogue Create(int id, string name, string description, CatalogueCategory category)
        {
            if (category == default)
            {
                throw new CatalogueCreationException("Unknown category.");
            }

            return new Catalogue
            {
                Id = id,
                Name = name,
                Description = description,
                Category = category,
            };
        }
    }
}

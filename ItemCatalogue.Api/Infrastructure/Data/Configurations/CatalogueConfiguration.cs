using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ItemCatalogue.Api.Domain.Models;
using ItemCatalogue.Api.Domain.Constants;

namespace ItemCatalogue.Api.Infrastructure.Data.Configurations
{
    public class CatalogueConfiguration : IEntityTypeConfiguration<Catalogue>
    {
        public void Configure(EntityTypeBuilder<Catalogue> builder)
        {
            builder.ToTable("Catalogues");
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.Name).IsRequired().HasMaxLength(EntityPropertyLength.Catalogue.NAME_MAX_LENGTH);
            builder.Property(x => x.Description).IsRequired().HasMaxLength(EntityPropertyLength.Catalogue.DESCRIPTION_MAX_LENGTH);
        }
    }
}

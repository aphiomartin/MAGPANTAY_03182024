using ItemCatalogue.Api.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace ItemCatalogue.Api.Infrastructure.Data.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<Catalogue> Catalogues { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        }
    }
}

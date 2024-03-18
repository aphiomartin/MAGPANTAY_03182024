namespace ItemCatalogue.Api.Domain.Interfaces.Repositories
{
    public interface IUnitOfWork
    {
        ICatalogueRepository Catalogue { get; }
        Task SaveChangesAsync();
    }
}

namespace Collaborative.Agenda.Domain.RepositoryInterfaces.Base
{
    public interface IRepository<T>
    {
        Task AddAsync(T entity);
        Task<T> GetByIdAsync(Guid id);
        Task UpdateAsync(Guid id, T entity);
        Task DeleteAsync(Guid id);
        Task<IEnumerable<T>> GetAllAsync();
    }
}
using Collaborative.Agenda.Domain.RepositoryInterfaces.Base;
using MongoDB.Driver;

namespace Collaborative.Agenda.MongoDB.Repositories
{
    public class MongoRepository<T>(IMongoDatabase database, string collectionName) : IRepository<T>
    {
        private readonly IMongoCollection<T> _collection = database.GetCollection<T>(collectionName);

        public async Task AddAsync(T entity)
        {
            await _collection.InsertOneAsync(entity);
        }

        public async Task<T> GetByIdAsync(Guid id)
        {
            return await _collection.Find(Builders<T>.Filter.Eq("_id", id)).FirstOrDefaultAsync();
        }

        public async Task UpdateAsync(Guid id, T entity)
        {
            await _collection.ReplaceOneAsync(Builders<T>.Filter.Eq("_id", id), entity);
        }

        public async Task DeleteAsync(Guid id)
        {
            await _collection.DeleteOneAsync(Builders<T>.Filter.Eq("_id", id));
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _collection.Find(_ => true).ToListAsync();
        }
    }
}

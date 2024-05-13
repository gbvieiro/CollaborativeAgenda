using Collaborative.Agenda.Domain.Models.Accounts;
using Collaborative.Agenda.Domain.RepositoryInterfaces;
using MongoDB.Driver;

namespace Collaborative.Agenda.MongoDB.Repositories
{
    public class AccountRepository(
        IMongoDatabase database,
        string collectionName
        ) : MongoRepository<Account>(database, collectionName), IAccountRepository
    {
    }
}
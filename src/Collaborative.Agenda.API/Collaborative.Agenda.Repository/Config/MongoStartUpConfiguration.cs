using Microsoft.Extensions.DependencyInjection;
using MongoDB.Driver;

namespace Collaborative.Agenda.MongoDB.Config
{
    public static class MongoStartUpConfiguration
    {
        public static void IncludeMongoServices(
            this IServiceCollection services,
            string connectionString,
            string databaseName
         )
        {
            services.AddSingleton<IMongoClient>(provider =>
            {
                return new MongoClient(connectionString);
            });

            services.AddScoped(provider =>
            {
                var mongoClient = provider.GetService<IMongoClient>() ?? throw new Exception("Bad mongo client configuration.");
                var database = mongoClient.GetDatabase(databaseName);
                return database;
            });
        }
    }
}
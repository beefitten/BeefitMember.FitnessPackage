using System;
using System.Net;
using System.Threading.Tasks;
using MongoDB.Driver;
using Persistence.Models.FitnessPackage;
using Persistence.Settings;

namespace Persistence.Repository.FitnessPackage
{
    public class FitnessPackageRepository : IFitnessPackageRepository
    {
        private readonly IMongoCollection<FitnessPackageModel> _fitnessPackageCollection;
        
        public FitnessPackageRepository(IDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _fitnessPackageCollection = database.GetCollection<FitnessPackageModel>(settings.CollectionName);
        }

        public async Task<HttpStatusCode> CreateFitnessPackage(FitnessPackageModel model)
        {
            if (model == null )
                throw new Exception();

            try
            {
                await _fitnessPackageCollection.InsertOneAsync(model);
                return HttpStatusCode.OK;
            }
            catch (Exception e)
            {
                return HttpStatusCode.Conflict;
            }
        }
    }
}
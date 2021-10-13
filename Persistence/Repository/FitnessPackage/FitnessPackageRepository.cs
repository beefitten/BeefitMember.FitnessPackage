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

        public async Task<FitnessPackageReturnModel> GetFitnessPackage(string name)
        {
            if (name == null)
                throw new Exception("Name cannot be null!");

            var model = await _fitnessPackageCollection
                .Find<FitnessPackageModel>(fitness => fitness.Name == name)
                .FirstOrDefaultAsync();

            if (model == null)
                throw new Exception("Fitness not found");

            return new FitnessPackageReturnModel
            {
                Name = model.Name,
                Logo = model.Logo,
                Features = model.Features,
                PrimaryColor = model.PrimaryColor,
                SecondaryColor = model.SecondaryColor
            };
        }
    }
}
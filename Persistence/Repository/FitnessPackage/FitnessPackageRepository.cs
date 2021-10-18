using System;
using System.Collections.Generic;
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

        public async Task<List<FitnessPackageReturnModel>> GetAllFitnessPackage()
        {
            var model = await _fitnessPackageCollection.Find(fitnessPackage => true).ToListAsync();

            var newFitnessPackageList = new List<FitnessPackageReturnModel>();
            
            foreach (var fitnessPackage in model)
            {
                var package = new FitnessPackageReturnModel
                {
                    Name = fitnessPackage.Name,
                    Logo = fitnessPackage.Logo,
                    Features = fitnessPackage.Features,
                    PrimaryColor = fitnessPackage.PrimaryColor,
                    SecondaryColor = fitnessPackage.SecondaryColor
                };
                
                newFitnessPackageList.Add(package);
            }
            
            return newFitnessPackageList;
        }

        public async Task<HttpStatusCode> DeleteFitnessPackage(string name)
        {
            if (name == null)
                throw new Exception("name cannot be null");

            try
            {
                await _fitnessPackageCollection.DeleteOneAsync(model => model.Name == name);
                return HttpStatusCode.OK;
            }
            catch (Exception e)
            {
                return HttpStatusCode.Conflict;
            }
        }
    }
}
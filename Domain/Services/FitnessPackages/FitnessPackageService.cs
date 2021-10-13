using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Domain.Services.FitnessPackages.Models;
using Persistence.Models.FitnessPackage;
using Persistence.Repository.FitnessPackage;

namespace Domain.Services.FitnessPackages
{
    public class FitnessPackageService : IFitnessPackageService
    {
        private readonly IFitnessPackageRepository _fitnessPackageRepository;

        public FitnessPackageService(IFitnessPackageRepository fitnessPackageRepository)
        {
            _fitnessPackageRepository = fitnessPackageRepository;
        }

        public async Task<HttpStatusCode> CreatePackage(CreateFitnessPackageModel model)
        {
            var fitnessPackageModel = new FitnessPackageModel
            {
                Name = model.Name,
                PrimaryColor = model.PrimaryColor,
                SecondaryColor =  model.SecondaryColor,
                Logo = model.Logo,
                Features = model.Features
            };

            return await _fitnessPackageRepository.CreateFitnessPackage(fitnessPackageModel);
        }

        public async Task<FitnessPackageReturnModel> GetFitnessPackage(string name)
        {
            return await _fitnessPackageRepository.GetFitnessPackage(name);
        }

        public async Task<List<FitnessPackageReturnModel>> GetAllFitnessPackage()
        {
            return await _fitnessPackageRepository.GetAllFitnessPackage();
        }
    }
}
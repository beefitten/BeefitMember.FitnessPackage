using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Domain.Services.FitnessPackages.Models;
using Persistence.Models.FitnessPackage;

namespace Domain.Services.FitnessPackages
{
    public interface IFitnessPackageService
    {
        Task<HttpStatusCode> CreatePackage(CreateFitnessPackageModel model);
        Task<FitnessPackageReturnModel> GetFitnessPackage(string name);
        Task<List<FitnessPackageReturnModel>> GetAllFitnessPackage();
        Task<HttpStatusCode> DeleteFitnessPackage(string name);
    }
}
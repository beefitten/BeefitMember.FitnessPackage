using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Persistence.Models.FitnessPackage;

namespace Persistence.Repository.FitnessPackage
{
    public interface IFitnessPackageRepository
    {
        Task<HttpStatusCode> CreateFitnessPackage(FitnessPackageModel model);
        Task<FitnessPackageReturnModel> GetFitnessPackage(string name);
        Task<List<FitnessPackageReturnModel>> GetAllFitnessPackage();
        Task<HttpStatusCode> DeleteFitnessPackage(string name);
    }
}
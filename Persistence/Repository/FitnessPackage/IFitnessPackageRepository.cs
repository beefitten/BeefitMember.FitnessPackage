using System.Net;
using System.Threading.Tasks;
using Persistence.Models.FitnessPackage;

namespace Persistence.Repository.FitnessPackage
{
    public interface IFitnessPackageRepository
    {
        Task<HttpStatusCode> CreateFitnessPackage(FitnessPackageModel model);
    }
}
using System.Net;
using System.Threading.Tasks;
using Domain.Services.FitnessPackages.Models;

namespace Domain.Services.FitnessPackages
{
    public interface IFitnessPackageService
    {
        Task<HttpStatusCode> CreatePackage(CreateFitnessPackageModel model);
        Task<string> GetFitnessPackage(string name);
    }
}
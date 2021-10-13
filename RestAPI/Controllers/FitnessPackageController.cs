using System;
using System.Net;
using System.Threading.Tasks;
using Domain.Services.FitnessPackages;
using Microsoft.AspNetCore.Mvc;
using Domain.Services.FitnessPackages.Models;
using Microsoft.AspNetCore.Authorization;
using Persistence.Models.FitnessPackage;


namespace RestAPI.Controllers
{
    [ApiController]
    [Route("Package")]
    public class FitnessPackageController : Controller
    {
        private readonly IFitnessPackageService _fitnessPackageService;

        public FitnessPackageController(IFitnessPackageService fitnessPackageService)
        {
            _fitnessPackageService = fitnessPackageService;
        }

        [HttpPost]
        [Route("/registerFitnessPackage")]
        public async Task<HttpStatusCode> CreatePackage([FromBody] CreateFitnessPackageModel model)
        {
           return await _fitnessPackageService.CreatePackage(model);
        }
        
        [HttpGet]
        [Authorize]
        [Route("/getFitnessPackage/{name}")]
        public async Task<FitnessPackageReturnModel> GetUserInforation(string name)
        {
            return await _fitnessPackageService.GetFitnessPackage(name);
        }
    }
}
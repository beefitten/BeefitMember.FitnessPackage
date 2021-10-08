using System;
using System.Net;
using System.Threading.Tasks;
using Domain.Services.FitnessPackages;
using Microsoft.AspNetCore.Mvc;
using Domain.Services.FitnessPackages.Models;


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

    }
}
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Domain.Services.FitnessPackages;
using Microsoft.AspNetCore.Mvc;
using Domain.Services.FitnessPackages.Models;
using Microsoft.AspNetCore.Authorization;
using MongoDB.Bson.IO;
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
        [Route("/getFitnessPackage/{name}")]
        public async Task<FitnessPackageReturnModel> GetUserInforation(string name)
        {
            return await _fitnessPackageService.GetFitnessPackage(name);
        }
        
        [HttpGet]
        [Route("/getAllFitnessPackage")]
        public async Task<List<FitnessPackageReturnModel>> GetAllFitnessPackage()
        {
            return await _fitnessPackageService.GetAllFitnessPackage();
        }

        [HttpDelete]
        [Route("/deleteFitnessPackage/{name}")]
        public async Task<HttpStatusCode> DeleteFitnessPackage(string name)
        {
            return await _fitnessPackageService.DeleteFitnessPackage(name);
        }
        
        [HttpGet]
        [Route("/testEndpoint")]
        public string GetClasses()
        {
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(new
            {
                results = new List<StandardClass>()
                {
                    new StandardClass("https://scontent-cph2-1.xx.fbcdn.net/v/t1.18169-9/17309563_1598834986823281_1091714418388959003_n.jpg?_nc_cat=108&ccb=1-5&_nc_sid=0debeb&_nc_ohc=4NGRuM-pE84AX8YXAxD&tn=rh50tjIK4zPTP8dG&_nc_ht=scontent-cph2-1.xx&oh=8f1a83ebbd1c38ec358fadf5a04f01ff&oe=61933B6A","Fit med Joe","Now!","Herning!"),
                    new StandardClass("https://fitit.dk/wp-content/uploads/2020/04/arthur-edelman-qfjuh4OLdxw-unsplash.jpg","Crossfit","Thursday, 15:45","Aarhus C"),
                    new StandardClass("https://fitogsund.dk/f/design/share.png","Body Pump","Monday, 10:00","Copenhagen"),
                    new StandardClass("https://fitnessfor10.com/wp-content/uploads/2019/05/Fitness-for-10-Home-Club-Locator.jpg","Lets go","Friday, 20:00","Svendborg"),
                    new StandardClass("https://shop14271.hstatic.dk/upload_dir/shop/proteus_pro/Billede-1.jpg","Jonas","Now!","Ringkøbingvej 28"),
                    new StandardClass("https://www.thespinoffproject.com/wp-content/uploads/2017/01/mirha_skyville_1.jpg","Jonas","Now!","Ringkøbingvej 28"),
                    new StandardClass("https://media.istockphoto.com/photos/beautiful-young-couple-relaxing-after-hiking-and-taking-a-break-picture-id1096035138?k=20&m=1096035138&s=612x612&w=0&h=MExFg7slrhMXOWljX6WKqWQk_gWg8I3eSpYdS3gXDig=","Jonas","Now!","Ringkøbingvej 28"),
                }
            });

            return json;
        }
    }
}

record StandardClass(string Picture, string Headline, string Date, string Address);

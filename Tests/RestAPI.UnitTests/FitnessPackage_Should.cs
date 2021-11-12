using System.Net;
using System.Threading.Tasks;
using AutoFixture;
using Domain.Services.FitnessPackages;
using Domain.Services.FitnessPackages.Models;
using Microsoft.Extensions.DependencyInjection;
using RestAPI.Controllers;
using Test.Setup;
using Xunit;

namespace Test.RestAPI.UnitTests
{
    public class FitnessPackage_Should
    {
        private readonly FitnessPackageController _controllers;
        private readonly Fixture _fixture;
        
        public FitnessPackage_Should()
        {
            _fixture = new Fixture();
            var testFixture = new TestFixture();
            _controllers = new FitnessPackageController(testFixture.ServiceProvider.GetService<IFitnessPackageService>());
        }
        
        [Fact]
        public async Task Return_Success_On_Create()
        {
            var request = _fixture.Create<CreateFitnessPackageModel>();

            var response = await _controllers.CreatePackage(request);
            
            Assert.Equal(HttpStatusCode.OK, response);
        }
    }
}
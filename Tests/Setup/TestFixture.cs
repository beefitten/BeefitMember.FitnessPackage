using Domain.Setup;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Setup;

namespace Test.Setup
{
    public class TestFixture
    {
        public ServiceProvider ServiceProvider { get; }

        public TestFixture()
        {
            ServiceProvider = new ServiceCollection()
                .AddPersistence()
                .AddDomain()
                .BuildServiceProvider();
        }
    }
}
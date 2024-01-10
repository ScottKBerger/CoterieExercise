using Coterie.Api.Services;
using NUnit.Framework;

namespace Coterie.UnitTests.ServiceTests
{
    public class QuoteServiceTestsBase
    {
        // Sample Moq setup
        // protected Mock<ITestService> MockTestService;

        protected QuoteService QuoteService;

        [OneTimeSetUp]
        public void BaseOneTimeSetup()
        {
            //MockTestService = new Mock<ITestService>();

            QuoteService = new QuoteService();
        }

        [TearDown]
        public void Cleanup()
        {
            // Sample reset after each test is ran
            //MockTestService.Reset();
        }

    }
}

using Coterie.Api.Models.Requests;
using NUnit.Framework;
using System.Collections.Generic;

namespace Coterie.UnitTests.ServiceTests
{
    public class QuoteServiceTestShould : QuoteServiceTestsBase
    {
        [Test]
        public void HappyPathSingleTestTexasPlumber()
        {
            QuoteRequest happyRequestSingle = new QuoteRequest();
            happyRequestSingle.revenue = 6000000M;
            happyRequestSingle.business = "Plumber";
            happyRequestSingle.states = new List<string>();
            happyRequestSingle.states.Add("Texas");

            var result = QuoteService.GetQuotes(happyRequestSingle);
            Assert.IsNotNull(result);
            Assert.IsTrue(result.premiums[0].premium == 11316M);
            Assert.IsTrue(result.premiums[0].state == "TX");
        }

        [Test]
        public void HappyPathSingleTestTexasProgrammer()
        {
            QuoteRequest happyRequestSingle = new QuoteRequest();
            happyRequestSingle.revenue = 6000000M;
            happyRequestSingle.business = "Programmer";
            happyRequestSingle.states = new List<string>();
            happyRequestSingle.states.Add("TX");

            var result = QuoteService.GetQuotes(happyRequestSingle);
            Assert.IsNotNull(result);
            Assert.IsTrue(result.premiums[0].premium == 28290M);
            Assert.IsTrue(result.premiums[0].state == "TX");
        }

        [Test]
        public void HappyPathSingleTestTexasArchitect()
        {
            QuoteRequest happyRequestSingle = new QuoteRequest();
            happyRequestSingle.revenue = 6000000M;
            happyRequestSingle.business = "Architect";
            happyRequestSingle.states = new List<string>();
            happyRequestSingle.states.Add("TX");

            var result = QuoteService.GetQuotes(happyRequestSingle);
            Assert.IsNotNull(result);
            Assert.IsTrue(result.premiums[0].premium == 22632M);
            Assert.IsTrue(result.premiums[0].state == "TX");
        }

        [Test]
        public void HappyPathSingleTestOhioPlumber()
        {
            QuoteRequest happyRequestSingle = new QuoteRequest();
            happyRequestSingle.revenue = 6000000M;
            happyRequestSingle.business = "Plumber";
            happyRequestSingle.states = new List<string>();
            happyRequestSingle.states.Add("Ohio");

            var result = QuoteService.GetQuotes(happyRequestSingle);
            Assert.IsNotNull(result);
            Assert.IsTrue(result.premiums[0].premium == 12000M);
            Assert.IsTrue(result.premiums[0].state == "OH");
        }

        [Test]
        public void HappyPathSingleTestOhioProgrammer()
        {
            QuoteRequest happyRequestSingle = new QuoteRequest();
            happyRequestSingle.revenue = 6000000M;
            happyRequestSingle.business = "Programmer";
            happyRequestSingle.states = new List<string>();
            happyRequestSingle.states.Add("Ohio");

            var result = QuoteService.GetQuotes(happyRequestSingle);
            Assert.IsNotNull(result);
            Assert.IsTrue(result.premiums[0].premium == 30000M);
            Assert.IsTrue(result.premiums[0].state == "OH");
        }

        [Test]
        public void HappyPathSingleTestOhioArchitect()
        {
            QuoteRequest happyRequestSingle = new QuoteRequest();
            happyRequestSingle.revenue = 6000000M;
            happyRequestSingle.business = "Architect";
            happyRequestSingle.states = new List<string>();
            happyRequestSingle.states.Add("OH");

            var result = QuoteService.GetQuotes(happyRequestSingle);
            Assert.IsNotNull(result);
            Assert.IsTrue(result.premiums[0].premium == 24000M);
            Assert.IsTrue(result.premiums[0].state == "OH");

        }
        [Test]
        public void HappyPathSingleTestFloridaPlumber()
        {
            QuoteRequest happyRequestSingle = new QuoteRequest();
            happyRequestSingle.revenue = 6000000M;
            happyRequestSingle.business = "Plumber";
            happyRequestSingle.states = new List<string>();
            happyRequestSingle.states.Add("Florida");

            var result = QuoteService.GetQuotes(happyRequestSingle);
            Assert.IsNotNull(result);
            Assert.IsTrue(result.premiums[0].premium == 14400M);
            Assert.IsTrue(result.premiums[0].state == "FL");
        }

        [Test]
        public void HappyPathSingleTestFloridaProgrammer()
        {
            QuoteRequest happyRequestSingle = new QuoteRequest();
            happyRequestSingle.revenue = 6000000M;
            happyRequestSingle.business = "Programmer";
            happyRequestSingle.states = new List<string>();
            happyRequestSingle.states.Add("FL");

            var result = QuoteService.GetQuotes(happyRequestSingle);
            Assert.IsNotNull(result);
            Assert.IsTrue(result.premiums[0].premium == 36000M);
            Assert.IsTrue(result.premiums[0].state == "FL");
        }

        [Test]
        public void HappyPathSingleTestFloridaArchitect()
        {
            QuoteRequest happyRequestSingle = new QuoteRequest();
            happyRequestSingle.revenue = 6000000M;
            happyRequestSingle.business = "Architect";
            happyRequestSingle.states = new List<string>();
            happyRequestSingle.states.Add("FL");

            var result = QuoteService.GetQuotes(happyRequestSingle);
            Assert.IsNotNull(result);
            Assert.IsTrue(result.premiums[0].premium == 28800M);
            Assert.IsTrue(result.premiums[0].state == "FL");
        }

        [Test]
        public void HappyPathMultipleTestArchitect()
        {
            QuoteRequest happyRequestSingle = new QuoteRequest();
            happyRequestSingle.revenue = 6000000M;
            happyRequestSingle.business = "Architect";
            happyRequestSingle.states = new List<string>();
            happyRequestSingle.states.Add("FL");
            happyRequestSingle.states.Add("TX");
            happyRequestSingle.states.Add("OH");

            var result = QuoteService.GetQuotes(happyRequestSingle);
            Assert.IsNotNull(result);
            Assert.IsTrue(result.premiums[0].premium == 28800M);
            Assert.IsTrue(result.premiums[0].state == "FL");
            Assert.IsTrue(result.premiums[1].premium == 22632M);
            Assert.IsTrue(result.premiums[1].state == "TX");
            Assert.IsTrue(result.premiums[2].premium == 24000M);
            Assert.IsTrue(result.premiums[2].state == "OH");
        }

        [Test]
        public void HappyPathMultipleTestProgrammer()
        {
            QuoteRequest happyRequestSingle = new QuoteRequest();
            happyRequestSingle.revenue = 6000000M;
            happyRequestSingle.business = "Programmer";
            happyRequestSingle.states = new List<string>();
            happyRequestSingle.states.Add("FL");
            happyRequestSingle.states.Add("TX");
            happyRequestSingle.states.Add("OH");

            var result = QuoteService.GetQuotes(happyRequestSingle);
            Assert.IsNotNull(result);
            Assert.IsTrue(result.premiums[0].premium == 36000M);
            Assert.IsTrue(result.premiums[0].state == "FL");
            Assert.IsTrue(result.premiums[1].premium == 28290M);
            Assert.IsTrue(result.premiums[1].state == "TX");
            Assert.IsTrue(result.premiums[2].premium == 30000M);
            Assert.IsTrue(result.premiums[2].state == "OH");
        }

        [Test]
        public void HappyPathMultipleTestPlumber()
        {
            QuoteRequest happyRequestSingle = new QuoteRequest();
            happyRequestSingle.revenue = 6000000M;
            happyRequestSingle.business = "Plumber";
            happyRequestSingle.states = new List<string>();
            happyRequestSingle.states.Add("FL");
            happyRequestSingle.states.Add("TX");
            happyRequestSingle.states.Add("OH");

            var result = QuoteService.GetQuotes(happyRequestSingle);
            Assert.IsNotNull(result);
            Assert.IsTrue(result.premiums[0].premium == 14400M);
            Assert.IsTrue(result.premiums[0].state == "FL");
            Assert.IsTrue(result.premiums[1].premium == 11316M);
            Assert.IsTrue(result.premiums[1].state == "TX");
            Assert.IsTrue(result.premiums[2].premium == 12000M);
            Assert.IsTrue(result.premiums[2].state == "OH");
        }

        [Test]
        public void FailBadRevenue()
        {
            QuoteRequest failRequestSingle = new QuoteRequest();
            failRequestSingle.revenue = 0M;
            failRequestSingle.business = "Plumber";
            failRequestSingle.states = new List<string>();
            failRequestSingle.states.Add("Texas");

            var result = QuoteService.GetQuotes(failRequestSingle);
            Assert.IsNotNull(result);
            Assert.IsNull(result.premiums);
        }

        [Test]
        public void FailBadBusiness()
        {
            QuoteRequest failRequestSingle = new QuoteRequest();
            failRequestSingle.revenue = 6000000M;
            failRequestSingle.business = "Electrician";
            failRequestSingle.states = new List<string>();
            failRequestSingle.states.Add("Texas");

            var result = QuoteService.GetQuotes(failRequestSingle);
            Assert.IsNotNull(result);
            Assert.IsNull(result.premiums);
        }

        [Test]
        public void FailBadStateSingle()
        {
            QuoteRequest failRequestSingle = new QuoteRequest();
            failRequestSingle.revenue = 6000000M;
            failRequestSingle.business = "Plumber";
            failRequestSingle.states = new List<string>();
            failRequestSingle.states.Add("Pennsylvania");

            var result = QuoteService.GetQuotes(failRequestSingle);
            Assert.IsNotNull(result);
            Assert.IsNull(result.premiums);
        }

        [Test]
        public void FailBadStateMultiple()
        {
            QuoteRequest failRequestMultiple = new QuoteRequest();
            failRequestMultiple.revenue = 6000000M;
            failRequestMultiple.business = "Plumber";
            failRequestMultiple.states = new List<string>();
            failRequestMultiple.states.Add("Pennsylvania");
            failRequestMultiple.states.Add("Texas");
            failRequestMultiple.states.Add("Ohio");

            var result = QuoteService.GetQuotes(failRequestMultiple);
            Assert.IsNotNull(result);
            Assert.IsNull(result.premiums);
        }

    }
}

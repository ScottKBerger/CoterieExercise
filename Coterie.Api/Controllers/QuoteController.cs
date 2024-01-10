using System.Linq;
using Coterie.Api.Interfaces;
using Coterie.Api.Models.Requests;
using Coterie.Api.Models.Responses;
using Coterie.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace Coterie.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QuoteController : CoterieBaseController
    {
        private readonly IQuoteService _quoteService;

        public QuoteController(IQuoteService _QuoteService)
        {
            _quoteService = _QuoteService;
        }

        [HttpPost]
        public QuoteServiceResponse Get(QuoteRequest request)
        {
            var result = _quoteService.GetQuotes(request);
            return result;
        }

    }
}

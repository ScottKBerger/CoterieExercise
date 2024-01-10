using System.Collections.Generic;

namespace Coterie.Api.Models.Requests
{
    public class QuoteRequest
    {
        public string business { get; set; }
        public decimal revenue { get; set; }
        public List<string> states { get; set; }
    }
}

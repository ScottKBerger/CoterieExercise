using System;
using System.Collections.Generic;

namespace Coterie.Api.Models.Responses
{
    public class QuoteStatePremium
    {
        public decimal premium { get; set; }
        public string state { get; set; }
}
    public class QuoteServiceResponse : BaseSuccessResponse
    {
        public string business { get; set; }
        public decimal revenue { get; set; }
        public List<QuoteStatePremium> premiums { get; set; }
    }
}

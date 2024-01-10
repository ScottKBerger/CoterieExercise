using Coterie.Api.Interfaces;
using Coterie.Api.Models.Requests;
using Coterie.Api.Models.Responses;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Coterie.Api.Services
{
    public class QuoteService : IQuoteService
    {
        private decimal GetStateFactor(string state)
        {
            switch (state.ToUpper())
            {
                case "TX":
                case "TEXAS":
                    return 0.943M;
                case "FL":
                case "FLORIDA":
                    return 1.2M;
                case "OH":
                case "OHIO":
                    return 1.0M;
                default:
                    return -1.0M ;
            }
        }

        private decimal GetBusinessFactor(string business)
        {
            switch (business.ToUpper())
            {
                case "ARCHITECT":
                    return 1.0M;
                case "PLUMBER":
                    return 0.5M;
                case "PROGRAMMER":
                    return 1.25M;
                default:
                    return -1.0M;
            }
        }

        private decimal GetHazardFactor(string hazard)
        {
            switch (hazard.ToUpper())
            {
                default:
                    return 4.0M;
            }
        }

        private string FixState(string state)
        {
            switch (state.ToUpper())
            {
                case "TX":
                case "TEXAS":
                    return "TX";
                case "FL":
                case "FLORIDA":
                    return "FL";
                case "OH":
                case "OHIO":
                    return "OH";
                default:
                    return String.Empty;
            }
        }

        public QuoteServiceResponse GetQuotes(QuoteRequest request)
        {
            //validate inputs

            QuoteServiceResponse response = new QuoteServiceResponse();

            if (request.revenue <= 0M)
            {
                throw new ArgumentException("Invalid revenue amount");
            };

            if (GetBusinessFactor(request.business) < 0)
            {
                throw new ArgumentException("Invalid business line");
            };

            foreach (string state in request.states)
            {
                if (GetStateFactor(state) < 0)
                {
                    throw new ArgumentException("Invalid state");
                }
            }

            response.premiums = new List<QuoteStatePremium>();

            decimal revenuePremiun = Math.Ceiling( Decimal.Divide( request.revenue, 1000.0M) );
            decimal commonFactor = Decimal.Multiply(Decimal.Multiply(GetHazardFactor("N/A"), GetBusinessFactor(request.business)), revenuePremiun);
            response.premiums = new List<QuoteStatePremium>();
            foreach (string state in request.states)
            {
                decimal totalPremium = Decimal.Multiply( GetStateFactor(state), commonFactor );
                QuoteStatePremium quoteToAdd = new QuoteStatePremium();
                quoteToAdd.state = FixState(state);
                quoteToAdd.premium = totalPremium;
                response.premiums.Add(quoteToAdd);
            }

            response.revenue = request.revenue;
            response.business = request.business;

            return response;
        }
    }
}
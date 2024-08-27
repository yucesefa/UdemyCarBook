using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.AppliCation.Features.Mediator.Results.PricingResults;

namespace UdemyCarBook.AppliCation.Features.Mediator.Queries.PricingQueries
{
    public class GetPricingQuery:IRequest<List<GetPricingQueryResult>>
    {
    }
}

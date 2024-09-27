using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.AppliCation.Features.Mediator.Results.CarPricingResults;

namespace UdemyCarBook.AppliCation.Features.Mediator.Queries.CarPricingQueries
{
    public class GetCarPricingWithTimePeriodQuery:IRequest<List<GetCarPricingWithTimePeriodQueryResult>>
    {
    }
}

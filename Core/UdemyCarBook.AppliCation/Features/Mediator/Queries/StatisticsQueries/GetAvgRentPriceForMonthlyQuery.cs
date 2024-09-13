using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.AppliCation.Features.Mediator.Results.StatisticsResults;

namespace UdemyCarBook.AppliCation.Features.Mediator.Queries.StatisticsQueries
{
    public class GetAvgRentPriceForMonthlyQuery : IRequest<GetAvgRentPriceForMonthlyQueryResult>
    {
    }
}

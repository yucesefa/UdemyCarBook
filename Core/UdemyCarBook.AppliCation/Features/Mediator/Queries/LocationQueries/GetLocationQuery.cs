using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.AppliCation.Features.Mediator.Results.LocationResults;

namespace UdemyCarBook.AppliCation.Features.Mediator.Queries.LocationQueries
{
    public class GetLocationQuery:IRequest<List<GetLocationQueryResult>>
    {
    }
}

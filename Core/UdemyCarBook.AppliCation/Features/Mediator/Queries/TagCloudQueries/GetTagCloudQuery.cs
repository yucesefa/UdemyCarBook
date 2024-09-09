using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.AppliCation.Features.Mediator.Results.TagCloudResults;

namespace UdemyCarBook.AppliCation.Features.Mediator.Queries.TagCloudQueries
{
    public class GetTagCloudQuery:IRequest<List<GetTagCloudQueryResult>>
    {
    }
}

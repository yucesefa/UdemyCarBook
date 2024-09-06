using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.AppliCation.Features.Mediator.Results.BlogResults;

namespace UdemyCarBook.AppliCation.Features.Mediator.Queries.BlogQueries
{
    public class GetLast3BlogWithAuthorsQuery:IRequest<List<GetLast3BlogsWithAuthorsQueryResult>>
    {
    }
}

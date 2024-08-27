using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.AppliCation.Features.Mediator.Results.FooterAddressResults;

namespace UdemyCarBook.AppliCation.Features.Mediator.Queries.FooterAddressQueries
{
    public class GetFooterAddressQuery:IRequest<List<GetFooterAddressQueryResult>>
    {
    }
}

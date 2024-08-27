using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.AppliCation.Features.Mediator.Results.SocialMediaResults;

namespace UdemyCarBook.AppliCation.Features.Mediator.Queries.SocialMediaQueries
{
    public class GetSocialMediaQuery:IRequest<List<GetSocialMediaQueryResult>>
    {
    }
}

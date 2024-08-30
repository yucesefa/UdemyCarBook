using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.AppliCation.Features.Mediator.Results.TestimonialResults;

namespace UdemyCarBook.AppliCation.Features.Mediator.Queries.TestimonialQueries
{
	public class GetTestimonialQuery:IRequest<List<GetTestimonialQueryResult>>
	{
	}
}

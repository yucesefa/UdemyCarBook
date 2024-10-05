using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.AppliCation.Features.Mediator.Results.ReviewResults;

namespace UdemyCarBook.AppliCation.Features.Mediator.Queries.ReviewQueries
{
	public class GetReviewByCarIdQuery : IRequest<List<GetReviewByCarIdQueryResult>>
	{
		public int Id { get; set; }

		public GetReviewByCarIdQuery(int id)
		{
			Id = id;
		}
	}
}

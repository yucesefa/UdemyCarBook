using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.AppliCation.Features.Mediator.Results.CarDescriptionResults;

namespace UdemyCarBook.AppliCation.Features.Mediator.Queries.CarDescriptionQueries
{
	public class GetCarDescriptionByCarIdQuery : IRequest<GetCarDescriptionQueryResult>
	{
		public int Id { get; set; }

		public GetCarDescriptionByCarIdQuery(int id)
		{
			Id = id;
		}
	}
}

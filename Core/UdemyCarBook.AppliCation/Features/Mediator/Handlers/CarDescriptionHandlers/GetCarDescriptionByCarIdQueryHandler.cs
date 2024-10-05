using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.AppliCation.Features.Mediator.Queries.CarDescriptionQueries;
using UdemyCarBook.AppliCation.Features.Mediator.Results.CarDescriptionResults;
using UdemyCarBook.AppliCation.Interfaces.CarDescriptionInterfaces;

namespace UdemyCarBook.AppliCation.Features.Mediator.Handlers.CarDescriptionHandlers
{
	public class GetCarDescriptionByCarIdQueryHandler : IRequestHandler<GetCarDescriptionByCarIdQuery, GetCarDescriptionQueryResult>
	{
		private readonly ICarDescriptionRepository _repository;
		public GetCarDescriptionByCarIdQueryHandler(ICarDescriptionRepository repository)
		{
			_repository = repository;
		}

		public async Task<GetCarDescriptionQueryResult> Handle(GetCarDescriptionByCarIdQuery request, CancellationToken cancellationToken)
		{
			var values =  _repository.GetCarDescription(request.Id);
			return new GetCarDescriptionQueryResult
			{
				CarDescriptionID = values.CarDescriptionId,
				CarID = values.CarId,
				Details = values.Detail
			};
		}
	}
}

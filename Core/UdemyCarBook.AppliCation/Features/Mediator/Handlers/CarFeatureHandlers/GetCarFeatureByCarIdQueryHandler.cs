using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.AppliCation.Features.Mediator.Queries.CarFeatureQueries;
using UdemyCarBook.AppliCation.Features.Mediator.Results.CarFeatureResults;
using UdemyCarBook.AppliCation.Interfaces.CarFeatureInterfaces;

namespace UdemyCarBook.AppliCation.Features.Mediator.Handlers.CarFeatureHandlers
{
	public class GetCarFeatureByCarIdQueryHandler : IRequestHandler<GetCarFeatureByCarIdQuery, List<GetCarFeatureByCarIdQueryResult>>
	{
		private readonly ICarFeatureRepository _repository;
		public GetCarFeatureByCarIdQueryHandler(ICarFeatureRepository repository)
		{
			_repository = repository;
		}

		public async Task<List<GetCarFeatureByCarIdQueryResult>> Handle(GetCarFeatureByCarIdQuery request, CancellationToken cancellationToken)
		{
			var values = _repository.GetCarFeaturesByCarID(request.Id);
			return values.Select(x => new GetCarFeatureByCarIdQueryResult
			{
				Available = x.Available,
				CarFeatureID = x.CarFeatureId,
				FeatureID = x.FeatureId,
				FeatureName = x.Feature.Name
			}).ToList();
		}
	}
}

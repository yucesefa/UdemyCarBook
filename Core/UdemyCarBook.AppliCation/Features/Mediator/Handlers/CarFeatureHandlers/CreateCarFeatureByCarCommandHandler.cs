using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.AppliCation.Features.Mediator.Commands.CarFeatureCommands;
using UdemyCarBook.AppliCation.Interfaces.CarFeatureInterfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.AppliCation.Features.Mediator.Handlers.CarFeatureHandlers
{
	public class CreateCarFeatureByCarCommandHandler : IRequestHandler<CreateCarFeatureByCarCommand>
	{
		private readonly ICarFeatureRepository _repository;

		public CreateCarFeatureByCarCommandHandler(ICarFeatureRepository repository)
		{
			_repository = repository;
		}

		public async Task Handle(CreateCarFeatureByCarCommand request, CancellationToken cancellationToken)
		{
			_repository.CreateCarFeatureByCar(new CarFeature
			{
				Available = false,
				CarId = request.CarID,
				FeatureId = request.FeatureID
			});
		}
	}
}

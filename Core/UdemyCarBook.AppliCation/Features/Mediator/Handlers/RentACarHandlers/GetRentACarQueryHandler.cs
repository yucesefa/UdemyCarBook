using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.AppliCation.Features.Mediator.Queries.RentACarQueries;
using UdemyCarBook.AppliCation.Features.Mediator.Results.RentACarResults;
using UdemyCarBook.AppliCation.Interfaces.RentACarInterfaces;

namespace UdemyCarBook.AppliCation.Features.Mediator.Handlers.RentACarHandlers
{
    public class GetRentACarQueryHandler:IRequestHandler<GetRentACarQuery,List<GetRentACarQueryResult>>
    {
        private readonly IRentACarRepository _repository;

        public GetRentACarQueryHandler(IRentACarRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetRentACarQueryResult>> Handle(GetRentACarQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByFilterAsync(x => x.LocationId == request.LocationId && x.Available == true);
            var results = values.Select(y => new GetRentACarQueryResult
            {
                CarId = y.CarId,
                Brand = y.Car.Brand.Name,
                Model = y.Car.Model,
                CoverImageUrl = y.Car.CoverImageUrl
            }).ToList();
            return results;
        }
    }
}

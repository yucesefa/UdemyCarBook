using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UdemyCarBook.AppliCation.Features.CQRS.Queries.BrandQueries;
using UdemyCarBook.AppliCation.Features.CQRS.Queries.CarQueries;
using UdemyCarBook.AppliCation.Features.CQRS.Results.CarResults;
using UdemyCarBook.AppliCation.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.AppliCation.Features.CQRS.Handlers.CarHandlers
{
    public class GetCarByIdQueryHandler
    {
        private readonly IRepository<Car> _repository;

        public GetCarByIdQueryHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }
        public async Task<GetCarByIdQueryResult> Handle(GetCarByIdQuery query)
        {
            var values = await _repository.GetByIdAsync(query.Id);
            return new GetCarByIdQueryResult
            {
                BrandId = values.BrandId,
                BigImageUrl = values.BigImageUrl,
                CarId = values.CarId,
                CoverImageUrl = values.CoverImageUrl,
                Fuel = values.Fuel,
                Km = values.Km,
                Luggage = values.Luggage,
                Model = values.Model,
                Seat = values.Seat,
                Transmission = values.Transmission
            };
        }
    }
}

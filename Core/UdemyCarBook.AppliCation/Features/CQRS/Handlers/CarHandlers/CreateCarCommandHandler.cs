using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.AppliCation.Features.CQRS.Commands.BrandCommands;
using UdemyCarBook.AppliCation.Features.CQRS.Commands.CarCommands;
using UdemyCarBook.AppliCation.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.AppliCation.Features.CQRS.Handlers.CarHandlers
{
    public class CreateCarCommandHandler
    {
        private readonly IRepository<Car> _repository;

        public CreateCarCommandHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }
        public async Task Handle(CreateCarCommand command)
        {
            await _repository.CreateAsync(new Car
            {
                Transmission = command.Transmission,
                Seat = command.Seat,
                Model = command.Model,
                Luggage = command.Luggage,
                Km = command.Km,
                Fuel = command.Fuel,
                CoverImageUrl = command.CoverImageUrl,
                BigImageUrl = command.BigImageUrl,
                BrandId = command.BrandId,

            });
        }
    }
}

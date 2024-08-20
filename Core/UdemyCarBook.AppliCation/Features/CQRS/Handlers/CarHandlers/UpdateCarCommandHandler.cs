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
    public class UpdateCarCommandHandler
    {
        private readonly IRepository<Car> _repository;

        public UpdateCarCommandHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateCarCommand command)
        {
            var values = await _repository.GetByIdAsync(command.CarId);
            values.Transmission = command.Transmission;
            values.BrandId = command.BrandId;
            values.BigImageUrl = command.BigImageUrl;
            values.CoverImageUrl = command.CoverImageUrl;
            values.Fuel= command.Fuel;
            values.CoverImageUrl= command.CoverImageUrl;
            values.Km= command.Km;
            values.Seat= command.Seat;
            values.Luggage= command.Luggage;
            values.Model= command.Model;
            await _repository.UpdateAsync(values);
        }
    }
}

using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.AppliCation.Features.Mediator.Commands.PricingCommands;
using UdemyCarBook.AppliCation.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.AppliCation.Features.Mediator.Handlers.PricingHandlers
{
    public class UpdatePricingCommandHandlers : IRequestHandler<UpdatePricingCommand>
    {
        private readonly IRepository<Pricing> _repository;

        public UpdatePricingCommandHandlers(IRepository<Pricing> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdatePricingCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.PricingId);
            values.Name= request.Name;
            await _repository.UpdateAsync(values);
        }
    }
}

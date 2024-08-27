using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.AppliCation.Features.Mediator.Queries.ServiceQueries;
using UdemyCarBook.AppliCation.Features.Mediator.Results.ServiceResults;
using UdemyCarBook.AppliCation.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.AppliCation.Features.Mediator.Handlers.ServiceHandlers
{
    public class GetServiceByIdQueryHandler : IRequestHandler<GetServiceByIdQuery,GetServiceByIdQueryResult>
    {
        private readonly IRepository<Service> _repository;

        public GetServiceByIdQueryHandler(IRepository<Service> repository)
        {
            _repository = repository;
        }

        public async Task<GetServiceByIdQueryResult> Handle(GetServiceByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return new GetServiceByIdQueryResult
            {
                Description = values.Description,
                IconUrl = values.IconUrl,
                Title = values.Title
            };
        }
    }
}

using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.AppliCation.Features.Mediator.Queries.BlogQueries;
using UdemyCarBook.AppliCation.Features.Mediator.Results.BlogResults;
using UdemyCarBook.AppliCation.Interfaces;
using UdemyCarBook.AppliCation.Interfaces.BlogInterfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.AppliCation.Features.Mediator.Handlers.BlogHandlers
{
    public class GetBlogByAuthorIdQueryHandler : IRequestHandler<GetBlogByAuthorIdQuery, List<GetBlogByAuthorIdQueryResult>>
    {
        private readonly IBlogRepository _repository;

        public GetBlogByAuthorIdQueryHandler(IBlogRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetBlogByAuthorIdQueryResult>> Handle(GetBlogByAuthorIdQuery request, CancellationToken cancellationToken)
        {
            var values = _repository.GetBlogByAuthorId(request.Id);
            return values.Select(x => new GetBlogByAuthorIdQueryResult
            {
                AuthorId = x.AuthorId,
                AuthorDescription = x.Author.Description,
                AuthorName = x.Author.Name,
                AuthorImageUrl = x.Author.ImageUrl
            }).ToList();

        }
    }
}

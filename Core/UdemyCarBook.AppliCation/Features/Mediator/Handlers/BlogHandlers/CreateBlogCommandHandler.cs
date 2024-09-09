using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.AppliCation.Features.Mediator.Commands.BlogCommands;
using UdemyCarBook.AppliCation.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.AppliCation.Features.Mediator.Handlers.BlogHandlers
{
    public class CreateBlogCommandHandler : IRequestHandler<CreateBlogCommand>
    {
        private readonly IRepository<Blog> _repository;

        public CreateBlogCommandHandler(IRepository<Blog> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateBlogCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Blog
            {
                AuthorId = request.AuthorId,
                Description = request.Description,
                CategoryId = request.CategoryId,
                CoverImageUrl = request.CoverImageUrl,
                CreatedDate = request.CreatedDate,
                Title = request.Title
            });
        }
    }
}

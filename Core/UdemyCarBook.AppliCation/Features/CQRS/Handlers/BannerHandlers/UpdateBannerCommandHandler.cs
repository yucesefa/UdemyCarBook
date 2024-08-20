﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.AppliCation.Features.CQRS.Commands.BannerCommands;
using UdemyCarBook.AppliCation.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.AppliCation.Features.CQRS.Handlers.BannerHandlers
{
    public class UpdateBannerCommandHandler
    {
        private readonly IRepository<Banner> _repository;

        public UpdateBannerCommandHandler(IRepository<Banner> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateBannerCommand command)
        {
            var values  = await _repository.GetByIdAsync(command.BannerId);
            values.VideoDescription = command.VideoDescription;
            values.Title = command.Title;
            values.VideoUrl = command.VideoUrl;
            values.Description = command.Description;
            await _repository.UpdateAsync(values);
        }
    }
}

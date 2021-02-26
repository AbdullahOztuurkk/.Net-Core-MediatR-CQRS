using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using NetCoreMediatRExample.Data.Commands;
using NetCoreMediatRExample.Models;

namespace NetCoreMediatRExample.Data.Handlers
{
    public class CreatePlayerHandler : IRequestHandler<CreatePlayerCommand>
    {
        private BaseRepository<Player> playerRepository;

        public CreatePlayerHandler(BaseRepository<Player> playerRepository)
        {
            this.playerRepository = playerRepository;
        }

        public async Task<Unit> Handle(CreatePlayerCommand request, CancellationToken cancellationToken)
        {
            await playerRepository.AddAsync(request.Player);
            return await Task.FromResult(Unit.Value);
        }
    }
}

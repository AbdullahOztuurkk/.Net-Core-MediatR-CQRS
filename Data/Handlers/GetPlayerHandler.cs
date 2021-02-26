using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using NetCoreMediatRExample.Data.Queries;
using NetCoreMediatRExample.Models;

namespace NetCoreMediatRExample.Data.Handlers
{
    public class GetPlayerHandler : IRequestHandler<GetPlayerQuery, Player>
    {
        private BaseRepository<Player> playerRepository;
        public GetPlayerHandler(BaseRepository<Player> playerRepository)
        {
            this.playerRepository = playerRepository;
        }

        public async Task<Player> Handle(GetPlayerQuery request, CancellationToken cancellationToken)
        {
            var currentPlayer = await playerRepository.GetByIdAsync(request.Id);
            return currentPlayer;
        }
    }
}

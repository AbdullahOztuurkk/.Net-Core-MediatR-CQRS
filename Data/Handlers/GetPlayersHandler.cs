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
    public class GetPlayersHandler:IRequestHandler<GetPlayersQuery,List<Player>>
    {
        private BaseRepository<Player> playerRepository;
        public GetPlayersHandler(BaseRepository<Player> playerRepository)
        {
            this.playerRepository = playerRepository;
        }
        public async Task<List<Player>> Handle(GetPlayersQuery request, CancellationToken cancellationToken)
        {
            var playerList = await playerRepository.GetAllAsync();
            return playerList;
        }
    }
}

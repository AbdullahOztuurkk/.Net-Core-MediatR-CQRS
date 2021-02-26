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
    public class GetGamesHandler:IRequestHandler<GetGamesQuery,List<Game>>
    {
        private BaseRepository<Game> gameRepository;
        public GetGamesHandler(BaseRepository<Game> gameRepository)
        {
            this.gameRepository = gameRepository;
        }
        public async Task<List<Game>> Handle(GetGamesQuery request, CancellationToken cancellationToken)
        {
            var currentGame = await gameRepository.GetAllAsync();
            return currentGame;
        }
    }
}

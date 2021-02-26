using System.Threading;
using System.Threading.Tasks;
using MediatR;
using NetCoreMediatRExample.Data.Commands;
using NetCoreMediatRExample.Models;

namespace NetCoreMediatRExample.Data.Handlers
{
    public class CreateGameHandler : IRequestHandler<CreateGameCommand>
    {
        private BaseRepository<Game> gameRepository;
        public CreateGameHandler(BaseRepository<Game> gameRepository)
        {
            this.gameRepository = gameRepository;
        }
        public async Task<Unit> Handle(CreateGameCommand request, CancellationToken cancellationToken)
        {
            await gameRepository.AddAsync(request.Game);
            return await Task.FromResult(Unit.Value);
        }
    }
}

using MediatR;
using NetCoreMediatRExample.Models;

namespace NetCoreMediatRExample.Data.Commands
{
    public class CreateGameCommand:IRequest
    {
        public Game Game { get; set; }

        public CreateGameCommand(Game game)
        {
            this.Game = game;
        }
    }
}

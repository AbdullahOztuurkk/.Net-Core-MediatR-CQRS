using MediatR;
using NetCoreMediatRExample.Models;

namespace NetCoreMediatRExample.Data.Commands
{
    public class CreatePlayerCommand:IRequest
    {
        public CreatePlayerCommand(Player request)
        {
            Player = request;
        }

        public Player Player { get; set; }
    }
}

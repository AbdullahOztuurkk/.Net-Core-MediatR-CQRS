using System.Collections.Generic;
using MediatR;
using NetCoreMediatRExample.Models;

namespace NetCoreMediatRExample.Data.Queries
{
    public class GetPlayersQuery:IRequest<List<Player>>
    {

    }
}

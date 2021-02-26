using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using NetCoreMediatRExample.Models;

namespace NetCoreMediatRExample.Data.Queries
{
    public class GetGamesQuery:IRequest<List<Game>>
    {
    }
}

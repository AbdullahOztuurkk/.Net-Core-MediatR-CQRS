using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using NetCoreMediatRExample.Models;

namespace NetCoreMediatRExample.Data.Queries
{
    public class GetPlayerQuery : IRequest<Player>
    {
        public int Id { get; private set; }
        public GetPlayerQuery(int id)
        {
            Id = id;
        }
    }
}

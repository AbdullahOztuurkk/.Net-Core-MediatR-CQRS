using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using NetCoreMediatRExample.Models;

namespace NetCoreMediatRExample.Data.Queries
{
    public class GetGameQuery:IRequest<Game>
    {
        public int Id { get; private set; }

        public GetGameQuery(int id)
        {
            Id = id;
        }
    }
}

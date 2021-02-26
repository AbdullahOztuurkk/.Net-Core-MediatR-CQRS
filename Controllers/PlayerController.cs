using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NetCoreMediatRExample.Data.Commands;
using NetCoreMediatRExample.Data.Queries;
using NetCoreMediatRExample.Models;

namespace NetCoreMediatRExample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlayerController : ControllerBase
    {

        private readonly ILogger<PlayerController> _logger;
        private IMediator mediator;

        public PlayerController(ILogger<PlayerController> logger, IMediator mediator)
        {
            _logger = logger;
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetPlayers()
        {
            var PlayerQuery=new GetPlayersQuery();
            var result = await mediator.Send(PlayerQuery);
            return result.Count != 0 ? (IActionResult) Ok(result) : BadRequest();
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetPlayer(int id)
        {
            var PlayerQuery = new GetPlayerQuery(id);
            var result = await mediator.Send(PlayerQuery);
            return result != null ? (IActionResult)Ok(result) : BadRequest();
        }

        [HttpPost]
        public async Task<IActionResult> AddPlayer([FromBody]Player player)
        {
            var PlayerCommand = new CreatePlayerCommand(player);
            var result = await mediator.Send(PlayerCommand);
            return result != null ? (IActionResult)Ok(result) : BadRequest();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NetCoreMediatRExample.Data.Commands;
using NetCoreMediatRExample.Data.Queries;
using NetCoreMediatRExample.Models;

namespace NetCoreMediatRExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        private readonly ILogger<PlayerController> _logger;
        private IMediator mediator;

        public GameController(ILogger<PlayerController> logger, IMediator mediator)
        {
            _logger = logger;
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetGames()
        {
            var query = new GetGamesQuery();
            var result = await mediator.Send(query);
            return result.Count != 0 ? (IActionResult)Ok(result) : BadRequest();
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetGame(int id)
        {
            var query = new GetGameQuery(id);
            var result = await mediator.Send(query);
            return result != null ? (IActionResult)Ok(result) : BadRequest();
        }

        [HttpPost]
        public async Task<IActionResult> AddGame([FromBody] Game game)
        {
            var query = new CreateGameCommand(game);
            var result = await mediator.Send(query);
            return result != null ? (IActionResult)Ok(result) : BadRequest();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Travsystem.Model;
using Travsystem.Service;

namespace Travsystem.Web
{
    [ApiController]
    [Route("api")]
    public class RaceController : ControllerBase
    {
        readonly ILogger<RaceController> _logger;
        readonly IATGClientService _atgService;
        readonly IFileService _fileService;

        public RaceController(ILogger<RaceController> logger, IATGClientService atgService, IFileService fileService)
        {
            _logger = logger;
            _atgService = atgService;
            _fileService = fileService;
        }

        [HttpPost("GetRace"), Produces("application/json")]
        public async Task<ActionResult<IList<LegResponse>>> GetRace (RaceRequest raceRequest)
        {
            return await _atgService.GetRace(raceRequest.Race.GameId);
        }

        [HttpPost("GetRaceDays"), Produces("application/json")]
        public async Task<ActionResult<IList<RaceDayResponse>>> GetRaceDays(RaceDaysRequest raceDayRequest)
        {
            var today = DateTime.Now;
            for (var i = 0; i < 7; i++)
            {
                var raceday = await _atgService.GetRaceDay(today.AddDays(i));
                if (raceday != null)
                {
                    return new List<RaceDayResponse>{raceday};
                }
            }
            return new List<RaceDayResponse>();
        }

        [HttpPost("GetBettingFile"), Produces("application/json")]
        public ActionResult<BetFileResponse> GetBettingFile(BetFileRequest request)
        {
            return _fileService.SaveATGFile(request);
        }

        [HttpPost("Login"), Produces("application/json")]
        public ActionResult<LoginResponse> Login(LoginRequest loginRequest)
        {
            return new LoginResponse {
                Name = loginRequest.username,
                Role = "User",
                Ticket = System.Guid.NewGuid().ToString()
            };
        }

        [HttpPost("Logout"), Produces("application/json")]
        public void Logout(LogoutRequest logoutRequest)
        {

        }
    }
}
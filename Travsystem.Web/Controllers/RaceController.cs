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
            return await _atgService.GetRaceDay();
        }

        [HttpPost("GetRaceDays"), Produces("application/json")]
        public ActionResult<IList<RaceDayResponse>> GetRaceDays(RaceDaysRequest raceDayRequest)
        {
            return new List<RaceDayResponse> {
                new RaceDayResponse {
                    BetType = "V75",
                    Date = 15,
                    Month = 2,
                    Year = 2020,
                    TrackId = 22
                }
            };
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
                Name = "kalle",
                Role = "User",
                Ticket = "xxxxxx"
            };
        }

        [HttpPost("Logout"), Produces("application/json")]
        public void Logout(LogoutRequest logoutRequest)
        {

        }
    }
}
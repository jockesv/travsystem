using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Travsystem.Model;

namespace Travsystem.Service
{
    public interface IATGClientService 
    {
        Task<List<LegResponse>> GetRace(string raceId);
        Task<RaceDayResponse> GetRaceDay(DateTime date);
    }
}
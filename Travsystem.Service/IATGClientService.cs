using System.Collections.Generic;
using System.Threading.Tasks;
using Travsystem.Model;

namespace Travsystem.Service
{
    public interface IATGClientService 
    {
        Task<List<LegResponse>> GetRaceDay(string raceId = "V75_2020-02-15_22_5");
    }
}
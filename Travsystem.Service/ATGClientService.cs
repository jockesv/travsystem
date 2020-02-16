using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Travsystem.Model;

namespace Travsystem.Service
{
    public class ATGClientService : IATGClientService
    {
        public async Task<List<LegResponse>> GetRaceDay(string raceId)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0");
                var json = await client.GetStringAsync($"https://www.atg.se/services/racinginfo/v1/api/games/{raceId}");
                var o = JObject.Parse(json);
                var result = new List<LegResponse>();
                var legNr = 1;
                foreach (var race in o.SelectTokens("races[*]"))
                {
                    var leg = new LegResponse();
                    leg.Number = legNr++;//race.SelectToken("number").Value<int>();
                    leg.Type = race.SelectToken("startMethod").Value<string>();

                    foreach (var start in race.SelectTokens("starts[*]"))
                    {
                        var horse = new HorseResponse
                        {
                            Age = start.SelectToken("horse.age").Value<int>(),
                            Name = start.SelectToken("horse.name").Value<string>(),
                            Gender = start.SelectToken("horse.sex").Value<string>(),
                            StartNumber = start.SelectToken("number").Value<int>(),
                            Driver = start.SelectToken("driver.firstName").Value<string>() + " " 
                                + start.SelectToken("driver.lastName").Value<string>(),
                            Enabled = true,
                            MarksPercentage = start.SelectToken("pools.V75.betDistribution").Value<int>() / 100f,
                            MarksQuantity = 0,
                            Odds = start.SelectToken("pools.vinnare.odds").Value<int>() / 100f
                        };
                        leg.Horses.Add(horse);
                    }
                    result.Add(leg);
                }

                return result;
            }
        }
    }
}
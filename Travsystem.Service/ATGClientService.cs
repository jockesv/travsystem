using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Travsystem.Model;

namespace Travsystem.Service
{
    public class ATGClientService : IATGClientService
    {
        public async Task<RaceDayResponse> GetRaceDay(DateTime date)
        {
            using (var client = new HttpClient())
            {
                var url = $"https://www.atg.se/services/racinginfo/v1/api/calendar/day/{date.ToString("yyyy-MM-dd")}";
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0");
                var json = await client.GetStringAsync(url);
                var o = JObject.Parse(json);

                if (o.SelectToken("games.V75") != null)
                {
                    return new RaceDayResponse {
                        Date = date.Day,
                        Month = date.Month,
                        Year = date.Year,
                        BetType = "V75",
                        TrackId = o.SelectToken("games.V75[0].tracks[0]").Value<int>(),
                        GameId = o.SelectToken("games.V75[0].id").Value<string>()
                    };
                }

                return null;
            }
        }
        public async Task<List<LegResponse>> GetRace(string raceId)
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
                    leg.StartMethod = race.SelectToken("startMethod").Value<string>();
                    leg.Name = race.SelectToken("name")?.Value<string>();
                    leg.Distance = race.SelectToken("distance").Value<string>();

                    foreach (var start in race.SelectTokens("starts[*]"))
                    {
                        var horse = new HorseResponse
                        {
                            Age = start.SelectToken("horse.age").Value<int>(),
                            Name = start.SelectToken("horse.name").Value<string>(),
                            Gender = start.SelectToken("horse.sex").Value<string>(),
                            StartNumber = start.SelectToken("number").Value<int>(),
                            Driver = ParseDriver(start),
                            Enabled = !(start.SelectToken("scratched")?.Value<bool>() ?? false),
                            MarksPercentage = start.SelectToken("pools.V75.betDistribution").Value<int>() / 100f,
                            MarksQuantity = 0,
                            Odds = start.SelectToken("pools.vinnare.odds").Value<int>() / 100f,
                            Money = start.SelectToken("horse.money").Value<int>(),
                            Record = ParseRecord(start),
                            PlaceOdds = ParsePlaceOdds(start),
                            StartPoints = start.SelectToken("horse.statistics.life.startPoints").Value<int>()
                        };
                        leg.Horses.Add(horse);
                    }
                    result.Add(leg);
                }

                return result;
            }
        }

        string ParseRecord(JToken start)
        {
            var code = start.SelectToken("horse.record.code").Value<string>();
            var minutes = start.SelectToken("horse.record.time.minutes").Value<int>();
            var seconds = start.SelectToken("horse.record.time.seconds").Value<int>();
            return $"{minutes},{seconds}{code}";
        }

        string ParseDriver(JToken start)
        {
            var firstName = start.SelectToken("driver.firstName").Value<string>(); 
            var lastName = start.SelectToken("driver.lastName").Value<string>();
            return $"{firstName} {lastName}";
        }

        string ParsePlaceOdds(JToken start)
        {
            var placeMaxOdds = start.SelectToken("pools.plats.maxOdds").Value<int>() / 100f;
            var placeMinOdds = start.SelectToken("pools.plats.minOdds").Value<int>() / 100f;
            return $"{placeMinOdds.ToString("0.00")} - {placeMaxOdds.ToString("0.00")}";
        }
    }
}
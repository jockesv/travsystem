namespace Travsystem.Model
{
    // using System;
    // using System.Collections.Generic;

    // using System.Globalization;
    // using Newtonsoft.Json;
    // using Newtonsoft.Json.Converters;

    // public partial class Welcome
    // {
    //     [JsonProperty("@type")]
    //     public string Type { get; set; }

    //     [JsonProperty("id")]
    //     public string Id { get; set; }

    //     [JsonProperty("status")]
    //     public Status Status { get; set; }

    //     [JsonProperty("pools")]
    //     public WelcomePools Pools { get; set; }

    //     [JsonProperty("races")]
    //     public Race[] Races { get; set; }

    //     [JsonProperty("currentVersion")]
    //     public long CurrentVersion { get; set; }
    // }

    // public partial class WelcomePools
    // {
    //     [JsonProperty("V75")]
    //     public PurpleV75 V75 { get; set; }
    // }

    // public partial class PurpleV75
    // {
    //     [JsonProperty("@type")]
    //     public string Type { get; set; }

    //     [JsonProperty("id")]
    //     public string Id { get; set; }

    //     [JsonProperty("status")]
    //     public Status Status { get; set; }

    //     [JsonProperty("timestamp")]
    //     public DateTimeOffset Timestamp { get; set; }

    //     [JsonProperty("turnover")]
    //     public long Turnover { get; set; }

    //     [JsonProperty("addOns")]
    //     public string[] AddOns { get; set; }

    //     [JsonProperty("harry")]
    //     public bool Harry { get; set; }

    //     [JsonProperty("systemCount")]
    //     public long SystemCount { get; set; }

    //     [JsonProperty("payouts")]
    //     public Dictionary<string, long> Payouts { get; set; }

    //     [JsonProperty("jackpotAmount")]
    //     public long JackpotAmount { get; set; }

    //     [JsonProperty("potentialPayoutRaceId")]
    //     public string PotentialPayoutRaceId { get; set; }

    //     [JsonProperty("result")]
    //     public PurpleResult Result { get; set; }
    // }

    // public partial class PurpleResult
    // {
    //     [JsonProperty("@type")]
    //     public string Type { get; set; }

    //     [JsonProperty("payouts")]
    //     public Dictionary<string, Payout> Payouts { get; set; }

    //     [JsonProperty("boostInfo")]
    //     public BoostInfo BoostInfo { get; set; }
    // }

    // public partial class BoostInfo
    // {
    //     [JsonProperty("boostCode")]
    //     [JsonConverter(typeof(ParseStringConverter))]
    //     public long BoostCode { get; set; }

    //     [JsonProperty("boostPayouts")]
    //     public BoostPayout[] BoostPayouts { get; set; }

    //     [JsonProperty("resultComplete")]
    //     public bool ResultComplete { get; set; }
    // }

    // public partial class BoostPayout
    // {
    //     [JsonProperty("correct")]
    //     public long Correct { get; set; }

    //     [JsonProperty("amount")]
    //     public long Amount { get; set; }

    //     [JsonProperty("multiplier")]
    //     public long Multiplier { get; set; }
    // }

    // public partial class Payout
    // {
    //     [JsonProperty("systems")]
    //     public long Systems { get; set; }

    //     [JsonProperty("payout")]
    //     public long PayoutPayout { get; set; }
    // }

    // public partial class Race
    // {
    //     [JsonProperty("id")]
    //     public string Id { get; set; }

    //     [JsonProperty("name")]
    //     public string Name { get; set; }

    //     [JsonProperty("date")]
    //     public DateTimeOffset Date { get; set; }

    //     [JsonProperty("number")]
    //     public long Number { get; set; }

    //     [JsonProperty("distance")]
    //     public long Distance { get; set; }

    //     [JsonProperty("startMethod")]
    //     public StartMethod StartMethod { get; set; }

    //     [JsonProperty("startTime")]
    //     public DateTimeOffset StartTime { get; set; }

    //     [JsonProperty("scheduledStartTime")]
    //     public DateTimeOffset ScheduledStartTime { get; set; }

    //     [JsonProperty("prize")]
    //     public string Prize { get; set; }

    //     [JsonProperty("terms")]
    //     public string[] Terms { get; set; }

    //     [JsonProperty("sport")]
    //     public string Sport { get; set; }

    //     [JsonProperty("track")]
    //     public Track Track { get; set; }

    //     [JsonProperty("result")]
    //     public RaceResult Result { get; set; }

    //     [JsonProperty("status")]
    //     public Status Status { get; set; }

    //     [JsonProperty("mediaId")]
    //     public string MediaId { get; set; }

    //     [JsonProperty("pools")]
    //     public RacePools Pools { get; set; }

    //     [JsonProperty("starts")]
    //     public Start[] Starts { get; set; }
    // }

    // public partial class RacePools
    // {
    //     [JsonProperty("vinnare")]
    //     public PurpleVinnare Vinnare { get; set; }

    //     [JsonProperty("plats")]
    //     public PurplePlats Plats { get; set; }

    //     [JsonProperty("tvilling")]
    //     public Trio Tvilling { get; set; }

    //     [JsonProperty("trio")]
    //     public Trio Trio { get; set; }

    //     [JsonProperty("V75")]
    //     public FluffyV75 V75 { get; set; }
    // }

    // public partial class PurplePlats
    // {
    //     [JsonProperty("@type")]
    //     public string Type { get; set; }

    //     [JsonProperty("id")]
    //     public string Id { get; set; }

    //     [JsonProperty("status")]
    //     public Status Status { get; set; }

    //     [JsonProperty("timestamp")]
    //     public DateTimeOffset Timestamp { get; set; }

    //     [JsonProperty("turnover")]
    //     public long Turnover { get; set; }

    //     [JsonProperty("result")]
    //     public PlatsResult Result { get; set; }
    // }

    // public partial class PlatsResult
    // {
    //     [JsonProperty("@type")]
    //     public string Type { get; set; }

    //     [JsonProperty("winners")]
    //     public Winners Winners { get; set; }
    // }

    // public partial class Winners
    // {
    //     [JsonProperty("first")]
    //     public PurpleWinner[] First { get; set; }

    //     [JsonProperty("second")]
    //     public PurpleWinner[] Second { get; set; }

    //     [JsonProperty("third")]
    //     public PurpleWinner[] Third { get; set; }
    // }

    // public partial class PurpleWinner
    // {
    //     [JsonProperty("number")]
    //     public long Number { get; set; }

    //     [JsonProperty("odds")]
    //     public long Odds { get; set; }
    // }

    // public partial class Trio
    // {
    //     [JsonProperty("@type")]
    //     public TrioType Type { get; set; }

    //     [JsonProperty("id")]
    //     public string Id { get; set; }

    //     [JsonProperty("status")]
    //     public Status Status { get; set; }

    //     [JsonProperty("timestamp")]
    //     public DateTimeOffset Timestamp { get; set; }

    //     [JsonProperty("turnover")]
    //     public long Turnover { get; set; }

    //     [JsonProperty("result")]
    //     public TrioResult Result { get; set; }
    // }

    // public partial class TrioResult
    // {
    //     [JsonProperty("@type")]
    //     public ResultType Type { get; set; }

    //     [JsonProperty("winners")]
    //     public WinnerElement[] Winners { get; set; }
    // }

    // public partial class WinnerElement
    // {
    //     [JsonProperty("combination")]
    //     public long[] Combination { get; set; }

    //     [JsonProperty("odds")]
    //     public long Odds { get; set; }
    // }

    // public partial class FluffyV75
    // {
    //     [JsonProperty("@type")]
    //     public string Type { get; set; }

    //     [JsonProperty("result")]
    //     public FluffyResult Result { get; set; }
    // }

    // public partial class FluffyResult
    // {
    //     [JsonProperty("@type")]
    //     public string Type { get; set; }

    //     [JsonProperty("value")]
    //     public Value Value { get; set; }

    //     [JsonProperty("winners")]
    //     public long[] Winners { get; set; }

    //     [JsonProperty("reserveOrder")]
    //     public long[] ReserveOrder { get; set; }

    //     [JsonProperty("systems")]
    //     public string Systems { get; set; }
    // }

    // public partial class Value
    // {
    //     [JsonProperty("amount")]
    //     public long Amount { get; set; }
    // }

    // public partial class PurpleVinnare
    // {
    //     [JsonProperty("@type")]
    //     public string Type { get; set; }

    //     [JsonProperty("id")]
    //     public string Id { get; set; }

    //     [JsonProperty("status")]
    //     public Status Status { get; set; }

    //     [JsonProperty("timestamp")]
    //     public DateTimeOffset Timestamp { get; set; }

    //     [JsonProperty("turnover")]
    //     public long Turnover { get; set; }

    //     [JsonProperty("result")]
    //     public VinnareResult Result { get; set; }
    // }

    // public partial class VinnareResult
    // {
    //     [JsonProperty("@type")]
    //     public string Type { get; set; }

    //     [JsonProperty("winners")]
    //     public PurpleWinner[] Winners { get; set; }
    // }

    // public partial class RaceResult
    // {
    //     [JsonProperty("victoryMargin")]
    //     public string VictoryMargin { get; set; }

    //     [JsonProperty("scratchings", NullValueHandling = NullValueHandling.Ignore)]
    //     public long[] Scratchings { get; set; }
    // }

    // public partial class Start
    // {
    //     [JsonProperty("number")]
    //     public long Number { get; set; }

    //     [JsonProperty("postPosition")]
    //     public long PostPosition { get; set; }

    //     [JsonProperty("distance")]
    //     public long Distance { get; set; }

    //     [JsonProperty("horse")]
    //     public Horse Horse { get; set; }

    //     [JsonProperty("driver")]
    //     public Driver Driver { get; set; }

    //     [JsonProperty("result")]
    //     public StartResult Result { get; set; }

    //     [JsonProperty("pools")]
    //     public StartPools Pools { get; set; }

    //     [JsonProperty("videos", NullValueHandling = NullValueHandling.Ignore)]
    //     public Video[] Videos { get; set; }

    //     [JsonProperty("out", NullValueHandling = NullValueHandling.Ignore)]
    //     public bool? Out { get; set; }

    //     [JsonProperty("scratched", NullValueHandling = NullValueHandling.Ignore)]
    //     public bool? Scratched { get; set; }
    // }

    // public partial class Driver
    // {
    //     [JsonProperty("id")]
    //     public long Id { get; set; }

    //     [JsonProperty("firstName")]
    //     public string FirstName { get; set; }

    //     [JsonProperty("lastName")]
    //     public string LastName { get; set; }

    //     [JsonProperty("shortName")]
    //     public string ShortName { get; set; }

    //     [JsonProperty("location")]
    //     public string Location { get; set; }

    //     [JsonProperty("birth", NullValueHandling = NullValueHandling.Ignore)]
    //     public long? Birth { get; set; }

    //     [JsonProperty("homeTrack", NullValueHandling = NullValueHandling.Ignore)]
    //     public HomeTrack HomeTrack { get; set; }

    //     [JsonProperty("license")]
    //     public License License { get; set; }

    //     [JsonProperty("silks", NullValueHandling = NullValueHandling.Ignore)]
    //     public string Silks { get; set; }

    //     [JsonProperty("statistics", NullValueHandling = NullValueHandling.Ignore)]
    //     public DriverStatistics Statistics { get; set; }
    // }

    // public partial class HomeTrack
    // {
    //     [JsonProperty("id")]
    //     public long Id { get; set; }

    //     [JsonProperty("name")]
    //     public string Name { get; set; }
    // }

    // public partial class DriverStatistics
    // {
    //     [JsonProperty("years")]
    //     public Dictionary<string, Year> Years { get; set; }
    // }

    // public partial class Year
    // {
    //     [JsonProperty("starts")]
    //     public long Starts { get; set; }

    //     [JsonProperty("earnings")]
    //     public long Earnings { get; set; }

    //     [JsonProperty("placement")]
    //     public Dictionary<string, long> Placement { get; set; }

    //     [JsonProperty("winPercentage", NullValueHandling = NullValueHandling.Ignore)]
    //     public long? WinPercentage { get; set; }

    //     [JsonProperty("records", NullValueHandling = NullValueHandling.Ignore)]
    //     public YearRecord[] Records { get; set; }
    // }

    // public partial class YearRecord
    // {
    //     [JsonProperty("code")]
    //     public Code Code { get; set; }

    //     [JsonProperty("startMethod")]
    //     public StartMethod StartMethod { get; set; }

    //     [JsonProperty("distance")]
    //     public Distance Distance { get; set; }

    //     [JsonProperty("time")]
    //     public Time Time { get; set; }

    //     [JsonProperty("place", NullValueHandling = NullValueHandling.Ignore)]
    //     public long? Place { get; set; }
    // }

    // public partial class Time
    // {
    //     [JsonProperty("minutes", NullValueHandling = NullValueHandling.Ignore)]
    //     public long? Minutes { get; set; }

    //     [JsonProperty("seconds", NullValueHandling = NullValueHandling.Ignore)]
    //     public long? Seconds { get; set; }

    //     [JsonProperty("tenths", NullValueHandling = NullValueHandling.Ignore)]
    //     public long? Tenths { get; set; }

    //     [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
    //     public string Code { get; set; }
    // }

    // public partial class Horse
    // {
    //     [JsonProperty("id")]
    //     public long Id { get; set; }

    //     [JsonProperty("name")]
    //     public string Name { get; set; }

    //     [JsonProperty("age")]
    //     public long Age { get; set; }

    //     [JsonProperty("sex")]
    //     public Sex Sex { get; set; }

    //     [JsonProperty("record")]
    //     public YearRecord Record { get; set; }

    //     [JsonProperty("trainer")]
    //     public Driver Trainer { get; set; }

    //     [JsonProperty("shoes")]
    //     public Shoes Shoes { get; set; }

    //     [JsonProperty("money")]
    //     public long Money { get; set; }

    //     [JsonProperty("color")]
    //     public Color Color { get; set; }

    //     [JsonProperty("homeTrack", NullValueHandling = NullValueHandling.Ignore)]
    //     public HomeTrack HomeTrack { get; set; }

    //     [JsonProperty("owner")]
    //     public Breeder Owner { get; set; }

    //     [JsonProperty("breeder")]
    //     public Breeder Breeder { get; set; }

    //     [JsonProperty("statistics")]
    //     public HorseStatistics Statistics { get; set; }

    //     [JsonProperty("pedigree")]
    //     public Pedigree Pedigree { get; set; }

    //     [JsonProperty("nationality", NullValueHandling = NullValueHandling.Ignore)]
    //     public Nationality? Nationality { get; set; }

    //     [JsonProperty("foreignOwned", NullValueHandling = NullValueHandling.Ignore)]
    //     public bool? ForeignOwned { get; set; }
    // }

    // public partial class Breeder
    // {
    //     [JsonProperty("id")]
    //     public long Id { get; set; }

    //     [JsonProperty("name")]
    //     public string Name { get; set; }

    //     [JsonProperty("location", NullValueHandling = NullValueHandling.Ignore)]
    //     public string Location { get; set; }
    // }

    // public partial class Pedigree
    // {
    //     [JsonProperty("father")]
    //     public Ther Father { get; set; }

    //     [JsonProperty("mother")]
    //     public Ther Mother { get; set; }

    //     [JsonProperty("grandfather")]
    //     public Ther Grandfather { get; set; }
    // }

    // public partial class Ther
    // {
    //     [JsonProperty("id")]
    //     public long Id { get; set; }

    //     [JsonProperty("name")]
    //     public string Name { get; set; }

    //     [JsonProperty("nationality", NullValueHandling = NullValueHandling.Ignore)]
    //     public Nationality? Nationality { get; set; }
    // }

    // public partial class Shoes
    // {
    //     [JsonProperty("reported")]
    //     public bool Reported { get; set; }

    //     [JsonProperty("front")]
    //     public Back Front { get; set; }

    //     [JsonProperty("back")]
    //     public Back Back { get; set; }
    // }

    // public partial class Back
    // {
    //     [JsonProperty("hasShoe")]
    //     public bool HasShoe { get; set; }

    //     [JsonProperty("changed", NullValueHandling = NullValueHandling.Ignore)]
    //     public bool? Changed { get; set; }
    // }

    // public partial class HorseStatistics
    // {
    //     [JsonProperty("years")]
    //     public Dictionary<string, Year> Years { get; set; }

    //     [JsonProperty("life")]
    //     public Life Life { get; set; }

    //     [JsonProperty("lastFiveStarts")]
    //     public LastFiveStarts LastFiveStarts { get; set; }
    // }

    // public partial class LastFiveStarts
    // {
    //     [JsonProperty("averageOdds")]
    //     public long AverageOdds { get; set; }
    // }

    // public partial class Life
    // {
    //     [JsonProperty("starts")]
    //     public long Starts { get; set; }

    //     [JsonProperty("earnings")]
    //     public long Earnings { get; set; }

    //     [JsonProperty("placement")]
    //     public Dictionary<string, long> Placement { get; set; }

    //     [JsonProperty("records")]
    //     public LifeRecord[] Records { get; set; }

    //     [JsonProperty("winPercentage")]
    //     public long WinPercentage { get; set; }

    //     [JsonProperty("placePercentage")]
    //     public long PlacePercentage { get; set; }

    //     [JsonProperty("earningsPerStart")]
    //     public long EarningsPerStart { get; set; }

    //     [JsonProperty("startPoints")]
    //     public long StartPoints { get; set; }
    // }

    // public partial class LifeRecord
    // {
    //     [JsonProperty("code")]
    //     public Code Code { get; set; }

    //     [JsonProperty("startMethod")]
    //     public StartMethod StartMethod { get; set; }

    //     [JsonProperty("distance")]
    //     public Distance Distance { get; set; }

    //     [JsonProperty("time")]
    //     public Time Time { get; set; }

    //     [JsonProperty("place")]
    //     public long Place { get; set; }

    //     [JsonProperty("year")]
    //     [JsonConverter(typeof(ParseStringConverter))]
    //     public long Year { get; set; }
    // }

    // public partial class StartPools
    // {
    //     [JsonProperty("vinnare")]
    //     public FluffyVinnare Vinnare { get; set; }

    //     [JsonProperty("plats")]
    //     public FluffyPlats Plats { get; set; }

    //     [JsonProperty("V75")]
    //     public TentacledV75 V75 { get; set; }
    // }

    // public partial class FluffyPlats
    // {
    //     [JsonProperty("@type")]
    //     public PlatsType Type { get; set; }

    //     [JsonProperty("minOdds")]
    //     public long MinOdds { get; set; }

    //     [JsonProperty("maxOdds")]
    //     public long MaxOdds { get; set; }

    //     [JsonProperty("odds", NullValueHandling = NullValueHandling.Ignore)]
    //     public long? Odds { get; set; }
    // }

    // public partial class TentacledV75
    // {
    //     [JsonProperty("@type")]
    //     public V75Type Type { get; set; }

    //     [JsonProperty("betDistribution")]
    //     public long BetDistribution { get; set; }

    //     [JsonProperty("potentialPayout", NullValueHandling = NullValueHandling.Ignore)]
    //     public PotentialPayout PotentialPayout { get; set; }
    // }

    // public partial class PotentialPayout
    // {
    //     [JsonProperty("value")]
    //     public long Value { get; set; }
    // }

    // public partial class FluffyVinnare
    // {
    //     [JsonProperty("@type")]
    //     public VinnareType Type { get; set; }

    //     [JsonProperty("odds")]
    //     public long Odds { get; set; }

    //     [JsonProperty("finalOdds", NullValueHandling = NullValueHandling.Ignore)]
    //     public long? FinalOdds { get; set; }
    // }

    // public partial class StartResult
    // {
    //     [JsonProperty("place", NullValueHandling = NullValueHandling.Ignore)]
    //     public long? Place { get; set; }

    //     [JsonProperty("finishOrder")]
    //     public long FinishOrder { get; set; }

    //     [JsonProperty("kmTime", NullValueHandling = NullValueHandling.Ignore)]
    //     public Time KmTime { get; set; }

    //     [JsonProperty("galloped", NullValueHandling = NullValueHandling.Ignore)]
    //     public bool? Galloped { get; set; }

    //     [JsonProperty("prizeMoney", NullValueHandling = NullValueHandling.Ignore)]
    //     public long? PrizeMoney { get; set; }

    //     [JsonProperty("finalOdds")]
    //     public double FinalOdds { get; set; }

    //     [JsonProperty("startNumber")]
    //     public long StartNumber { get; set; }

    //     [JsonProperty("disqualified", NullValueHandling = NullValueHandling.Ignore)]
    //     public bool? Disqualified { get; set; }
    // }

    // public partial class Video
    // {
    //     [JsonProperty("mediaId")]
    //     public string MediaId { get; set; }

    //     [JsonProperty("timestamp")]
    //     public DateTimeOffset Timestamp { get; set; }
    // }

    // public partial class Track
    // {
    //     [JsonProperty("id")]
    //     public long Id { get; set; }

    //     [JsonProperty("name")]
    //     public string Name { get; set; }

    //     [JsonProperty("condition")]
    //     public string Condition { get; set; }

    //     [JsonProperty("countryCode")]
    //     public string CountryCode { get; set; }
    // }

    // public enum Status { Results };

    // public enum ResultType { TrioPoolRaceResult, TvillingPoolRaceResult };

    // public enum TrioType { TrioPool, TvillingPool };

    // public enum StartMethod { Auto, Volte };

    // public enum License { ATränareKat2TränaKöra, ATränareSvUtlandTränaKöra, ATränareTränaKöra, ATränareUtlandTränaKöra, BTränareTränaKöraFörBolag, BTränareTränaKöraRida, BTränareTränaKöraRidaFörBolag, BTränareUtlandTränaKöra, KörlicensKategori1Köra, KörlicensKategori1KöraRida };

    // public enum Code { AK, AL, AM, AaK, K, L, M };

    // public enum Distance { Long, Medium, Short };

    // public enum Color { Brun, Fux, Ljusbrun, Mörkbrun, Svart, Svartbrun };

    // public enum Nationality { Be, Ca, De, Dk, Fi, Fr, It, Nl, Us };

    // public enum Sex { Gelding, Mare, Stallion };

    // public enum PlatsType { PlatsStartPool };

    // public enum V75Type { MarkingBetStartPool };

    // public enum VinnareType { VinnareStartPool };

    // public partial class Welcome
    // {
    //     public static Welcome FromJson(string json) => JsonConvert.DeserializeObject<Welcome>(json, model.Converter.Settings);
    // }

    // public static class Serialize
    // {
    //     public static string ToJson(this Welcome self) => JsonConvert.SerializeObject(self, model.Converter.Settings);
    // }

    // internal static class Converter
    // {
    //     public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
    //     {
    //         MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
    //         DateParseHandling = DateParseHandling.None,
    //         Converters =
    //         {
    //             StatusConverter.Singleton,
    //             TrioTypeConverter.Singleton,
    //             ResultTypeConverter.Singleton,
    //             StartMethodConverter.Singleton,
    //             LicenseConverter.Singleton,
    //             CodeConverter.Singleton,
    //             DistanceConverter.Singleton,
    //             ColorConverter.Singleton,
    //             NationalityConverter.Singleton,
    //             SexConverter.Singleton,
    //             V75TypeConverter.Singleton,
    //             PlatsTypeConverter.Singleton,
    //             VinnareTypeConverter.Singleton,
    //             new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
    //         },
    //     };
    // }

    // internal class ParseStringConverter : JsonConverter
    // {
    //     public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

    //     public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    //     {
    //         if (reader.TokenType == JsonToken.Null) return null;
    //         var value = serializer.Deserialize<string>(reader);
    //         long l;
    //         if (Int64.TryParse(value, out l))
    //         {
    //             return l;
    //         }
    //         throw new Exception("Cannot unmarshal type long");
    //     }

    //     public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    //     {
    //         if (untypedValue == null)
    //         {
    //             serializer.Serialize(writer, null);
    //             return;
    //         }
    //         var value = (long)untypedValue;
    //         serializer.Serialize(writer, value.ToString());
    //         return;
    //     }

    //     public static readonly ParseStringConverter Singleton = new ParseStringConverter();
    // }

    // internal class StatusConverter : JsonConverter
    // {
    //     public override bool CanConvert(Type t) => t == typeof(Status) || t == typeof(Status?);

    //     public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    //     {
    //         if (reader.TokenType == JsonToken.Null) return null;
    //         var value = serializer.Deserialize<string>(reader);
    //         if (value == "results")
    //         {
    //             return Status.Results;
    //         }
    //         throw new Exception("Cannot unmarshal type Status");
    //     }

    //     public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    //     {
    //         if (untypedValue == null)
    //         {
    //             serializer.Serialize(writer, null);
    //             return;
    //         }
    //         var value = (Status)untypedValue;
    //         if (value == Status.Results)
    //         {
    //             serializer.Serialize(writer, "results");
    //             return;
    //         }
    //         throw new Exception("Cannot marshal type Status");
    //     }

    //     public static readonly StatusConverter Singleton = new StatusConverter();
    // }

    // internal class TrioTypeConverter : JsonConverter
    // {
    //     public override bool CanConvert(Type t) => t == typeof(TrioType) || t == typeof(TrioType?);

    //     public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    //     {
    //         if (reader.TokenType == JsonToken.Null) return null;
    //         var value = serializer.Deserialize<string>(reader);
    //         switch (value)
    //         {
    //             case ".TrioPool":
    //                 return TrioType.TrioPool;
    //             case ".TvillingPool":
    //                 return TrioType.TvillingPool;
    //         }
    //         throw new Exception("Cannot unmarshal type TrioType");
    //     }

    //     public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    //     {
    //         if (untypedValue == null)
    //         {
    //             serializer.Serialize(writer, null);
    //             return;
    //         }
    //         var value = (TrioType)untypedValue;
    //         switch (value)
    //         {
    //             case TrioType.TrioPool:
    //                 serializer.Serialize(writer, ".TrioPool");
    //                 return;
    //             case TrioType.TvillingPool:
    //                 serializer.Serialize(writer, ".TvillingPool");
    //                 return;
    //         }
    //         throw new Exception("Cannot marshal type TrioType");
    //     }

    //     public static readonly TrioTypeConverter Singleton = new TrioTypeConverter();
    // }

    // internal class ResultTypeConverter : JsonConverter
    // {
    //     public override bool CanConvert(Type t) => t == typeof(ResultType) || t == typeof(ResultType?);

    //     public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    //     {
    //         if (reader.TokenType == JsonToken.Null) return null;
    //         var value = serializer.Deserialize<string>(reader);
    //         switch (value)
    //         {
    //             case ".TrioPoolRaceResult":
    //                 return ResultType.TrioPoolRaceResult;
    //             case ".TvillingPoolRaceResult":
    //                 return ResultType.TvillingPoolRaceResult;
    //         }
    //         throw new Exception("Cannot unmarshal type ResultType");
    //     }

    //     public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    //     {
    //         if (untypedValue == null)
    //         {
    //             serializer.Serialize(writer, null);
    //             return;
    //         }
    //         var value = (ResultType)untypedValue;
    //         switch (value)
    //         {
    //             case ResultType.TrioPoolRaceResult:
    //                 serializer.Serialize(writer, ".TrioPoolRaceResult");
    //                 return;
    //             case ResultType.TvillingPoolRaceResult:
    //                 serializer.Serialize(writer, ".TvillingPoolRaceResult");
    //                 return;
    //         }
    //         throw new Exception("Cannot marshal type ResultType");
    //     }

    //     public static readonly ResultTypeConverter Singleton = new ResultTypeConverter();
    // }

    // internal class StartMethodConverter : JsonConverter
    // {
    //     public override bool CanConvert(Type t) => t == typeof(StartMethod) || t == typeof(StartMethod?);

    //     public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    //     {
    //         if (reader.TokenType == JsonToken.Null) return null;
    //         var value = serializer.Deserialize<string>(reader);
    //         switch (value)
    //         {
    //             case "auto":
    //                 return StartMethod.Auto;
    //             case "volte":
    //                 return StartMethod.Volte;
    //         }
    //         throw new Exception("Cannot unmarshal type StartMethod");
    //     }

    //     public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    //     {
    //         if (untypedValue == null)
    //         {
    //             serializer.Serialize(writer, null);
    //             return;
    //         }
    //         var value = (StartMethod)untypedValue;
    //         switch (value)
    //         {
    //             case StartMethod.Auto:
    //                 serializer.Serialize(writer, "auto");
    //                 return;
    //             case StartMethod.Volte:
    //                 serializer.Serialize(writer, "volte");
    //                 return;
    //         }
    //         throw new Exception("Cannot marshal type StartMethod");
    //     }

    //     public static readonly StartMethodConverter Singleton = new StartMethodConverter();
    // }

    // internal class LicenseConverter : JsonConverter
    // {
    //     public override bool CanConvert(Type t) => t == typeof(License) || t == typeof(License?);

    //     public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    //     {
    //         if (reader.TokenType == JsonToken.Null) return null;
    //         var value = serializer.Deserialize<string>(reader);
    //         switch (value)
    //         {
    //             case "A-tränare (utland): träna, köra":
    //                 return License.ATränareUtlandTränaKöra;
    //             case "A-tränare kat2: träna, köra":
    //                 return License.ATränareKat2TränaKöra;
    //             case "A-tränare: (Sv/utland): träna, köra":
    //                 return License.ATränareSvUtlandTränaKöra;
    //             case "A-tränare: träna, köra":
    //                 return License.ATränareTränaKöra;
    //             case "B-tränare: (utland): träna, köra":
    //                 return License.BTränareUtlandTränaKöra;
    //             case "B-tränare: träna, köra för bolag":
    //                 return License.BTränareTränaKöraFörBolag;
    //             case "B-tränare: träna, köra, rida":
    //                 return License.BTränareTränaKöraRida;
    //             case "B-tränare: träna, köra, rida för bolag":
    //                 return License.BTränareTränaKöraRidaFörBolag;
    //             case "Körlicens kategori 1: köra":
    //                 return License.KörlicensKategori1Köra;
    //             case "Körlicens kategori 1: köra, rida":
    //                 return License.KörlicensKategori1KöraRida;
    //         }
    //         throw new Exception("Cannot unmarshal type License");
    //     }

    //     public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    //     {
    //         if (untypedValue == null)
    //         {
    //             serializer.Serialize(writer, null);
    //             return;
    //         }
    //         var value = (License)untypedValue;
    //         switch (value)
    //         {
    //             case License.ATränareUtlandTränaKöra:
    //                 serializer.Serialize(writer, "A-tränare (utland): träna, köra");
    //                 return;
    //             case License.ATränareKat2TränaKöra:
    //                 serializer.Serialize(writer, "A-tränare kat2: träna, köra");
    //                 return;
    //             case License.ATränareSvUtlandTränaKöra:
    //                 serializer.Serialize(writer, "A-tränare: (Sv/utland): träna, köra");
    //                 return;
    //             case License.ATränareTränaKöra:
    //                 serializer.Serialize(writer, "A-tränare: träna, köra");
    //                 return;
    //             case License.BTränareUtlandTränaKöra:
    //                 serializer.Serialize(writer, "B-tränare: (utland): träna, köra");
    //                 return;
    //             case License.BTränareTränaKöraFörBolag:
    //                 serializer.Serialize(writer, "B-tränare: träna, köra för bolag");
    //                 return;
    //             case License.BTränareTränaKöraRida:
    //                 serializer.Serialize(writer, "B-tränare: träna, köra, rida");
    //                 return;
    //             case License.BTränareTränaKöraRidaFörBolag:
    //                 serializer.Serialize(writer, "B-tränare: träna, köra, rida för bolag");
    //                 return;
    //             case License.KörlicensKategori1Köra:
    //                 serializer.Serialize(writer, "Körlicens kategori 1: köra");
    //                 return;
    //             case License.KörlicensKategori1KöraRida:
    //                 serializer.Serialize(writer, "Körlicens kategori 1: köra, rida");
    //                 return;
    //         }
    //         throw new Exception("Cannot marshal type License");
    //     }

    //     public static readonly LicenseConverter Singleton = new LicenseConverter();
    // }

    // internal class CodeConverter : JsonConverter
    // {
    //     public override bool CanConvert(Type t) => t == typeof(Code) || t == typeof(Code?);

    //     public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    //     {
    //         if (reader.TokenType == JsonToken.Null) return null;
    //         var value = serializer.Deserialize<string>(reader);
    //         switch (value)
    //         {
    //             case "K":
    //                 return Code.K;
    //             case "L":
    //                 return Code.L;
    //             case "M":
    //                 return Code.M;
    //             case "aK":
    //                 return Code.AK;
    //             case "aL":
    //                 return Code.AL;
    //             case "aM":
    //                 return Code.AM;
    //             case "aaK":
    //                 return Code.AaK;
    //         }
    //         throw new Exception("Cannot unmarshal type Code");
    //     }

    //     public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    //     {
    //         if (untypedValue == null)
    //         {
    //             serializer.Serialize(writer, null);
    //             return;
    //         }
    //         var value = (Code)untypedValue;
    //         switch (value)
    //         {
    //             case Code.K:
    //                 serializer.Serialize(writer, "K");
    //                 return;
    //             case Code.L:
    //                 serializer.Serialize(writer, "L");
    //                 return;
    //             case Code.M:
    //                 serializer.Serialize(writer, "M");
    //                 return;
    //             case Code.AK:
    //                 serializer.Serialize(writer, "aK");
    //                 return;
    //             case Code.AL:
    //                 serializer.Serialize(writer, "aL");
    //                 return;
    //             case Code.AM:
    //                 serializer.Serialize(writer, "aM");
    //                 return;
    //             case Code.AaK:
    //                 serializer.Serialize(writer, "aaK");
    //                 return;
    //         }
    //         throw new Exception("Cannot marshal type Code");
    //     }

    //     public static readonly CodeConverter Singleton = new CodeConverter();
    // }

    // internal class DistanceConverter : JsonConverter
    // {
    //     public override bool CanConvert(Type t) => t == typeof(Distance) || t == typeof(Distance?);

    //     public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    //     {
    //         if (reader.TokenType == JsonToken.Null) return null;
    //         var value = serializer.Deserialize<string>(reader);
    //         switch (value)
    //         {
    //             case "long":
    //                 return Distance.Long;
    //             case "medium":
    //                 return Distance.Medium;
    //             case "short":
    //                 return Distance.Short;
    //         }
    //         throw new Exception("Cannot unmarshal type Distance");
    //     }

    //     public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    //     {
    //         if (untypedValue == null)
    //         {
    //             serializer.Serialize(writer, null);
    //             return;
    //         }
    //         var value = (Distance)untypedValue;
    //         switch (value)
    //         {
    //             case Distance.Long:
    //                 serializer.Serialize(writer, "long");
    //                 return;
    //             case Distance.Medium:
    //                 serializer.Serialize(writer, "medium");
    //                 return;
    //             case Distance.Short:
    //                 serializer.Serialize(writer, "short");
    //                 return;
    //         }
    //         throw new Exception("Cannot marshal type Distance");
    //     }

    //     public static readonly DistanceConverter Singleton = new DistanceConverter();
    // }

    // internal class ColorConverter : JsonConverter
    // {
    //     public override bool CanConvert(Type t) => t == typeof(Color) || t == typeof(Color?);

    //     public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    //     {
    //         if (reader.TokenType == JsonToken.Null) return null;
    //         var value = serializer.Deserialize<string>(reader);
    //         switch (value)
    //         {
    //             case "brun":
    //                 return Color.Brun;
    //             case "fux":
    //                 return Color.Fux;
    //             case "ljusbrun":
    //                 return Color.Ljusbrun;
    //             case "mörkbrun":
    //                 return Color.Mörkbrun;
    //             case "svart":
    //                 return Color.Svart;
    //             case "svartbrun":
    //                 return Color.Svartbrun;
    //         }
    //         throw new Exception("Cannot unmarshal type Color");
    //     }

    //     public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    //     {
    //         if (untypedValue == null)
    //         {
    //             serializer.Serialize(writer, null);
    //             return;
    //         }
    //         var value = (Color)untypedValue;
    //         switch (value)
    //         {
    //             case Color.Brun:
    //                 serializer.Serialize(writer, "brun");
    //                 return;
    //             case Color.Fux:
    //                 serializer.Serialize(writer, "fux");
    //                 return;
    //             case Color.Ljusbrun:
    //                 serializer.Serialize(writer, "ljusbrun");
    //                 return;
    //             case Color.Mörkbrun:
    //                 serializer.Serialize(writer, "mörkbrun");
    //                 return;
    //             case Color.Svart:
    //                 serializer.Serialize(writer, "svart");
    //                 return;
    //             case Color.Svartbrun:
    //                 serializer.Serialize(writer, "svartbrun");
    //                 return;
    //         }
    //         throw new Exception("Cannot marshal type Color");
    //     }

    //     public static readonly ColorConverter Singleton = new ColorConverter();
    // }

    // internal class NationalityConverter : JsonConverter
    // {
    //     public override bool CanConvert(Type t) => t == typeof(Nationality) || t == typeof(Nationality?);

    //     public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    //     {
    //         if (reader.TokenType == JsonToken.Null) return null;
    //         var value = serializer.Deserialize<string>(reader);
    //         switch (value)
    //         {
    //             case "BE":
    //                 return Nationality.Be;
    //             case "CA":
    //                 return Nationality.Ca;
    //             case "DE":
    //                 return Nationality.De;
    //             case "DK":
    //                 return Nationality.Dk;
    //             case "FI":
    //                 return Nationality.Fi;
    //             case "FR":
    //                 return Nationality.Fr;
    //             case "IT":
    //                 return Nationality.It;
    //             case "NL":
    //                 return Nationality.Nl;
    //             case "US":
    //                 return Nationality.Us;
    //         }
    //         throw new Exception("Cannot unmarshal type Nationality");
    //     }

    //     public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    //     {
    //         if (untypedValue == null)
    //         {
    //             serializer.Serialize(writer, null);
    //             return;
    //         }
    //         var value = (Nationality)untypedValue;
    //         switch (value)
    //         {
    //             case Nationality.Be:
    //                 serializer.Serialize(writer, "BE");
    //                 return;
    //             case Nationality.Ca:
    //                 serializer.Serialize(writer, "CA");
    //                 return;
    //             case Nationality.De:
    //                 serializer.Serialize(writer, "DE");
    //                 return;
    //             case Nationality.Dk:
    //                 serializer.Serialize(writer, "DK");
    //                 return;
    //             case Nationality.Fi:
    //                 serializer.Serialize(writer, "FI");
    //                 return;
    //             case Nationality.Fr:
    //                 serializer.Serialize(writer, "FR");
    //                 return;
    //             case Nationality.It:
    //                 serializer.Serialize(writer, "IT");
    //                 return;
    //             case Nationality.Nl:
    //                 serializer.Serialize(writer, "NL");
    //                 return;
    //             case Nationality.Us:
    //                 serializer.Serialize(writer, "US");
    //                 return;
    //         }
    //         throw new Exception("Cannot marshal type Nationality");
    //     }

    //     public static readonly NationalityConverter Singleton = new NationalityConverter();
    // }

    // internal class SexConverter : JsonConverter
    // {
    //     public override bool CanConvert(Type t) => t == typeof(Sex) || t == typeof(Sex?);

    //     public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    //     {
    //         if (reader.TokenType == JsonToken.Null) return null;
    //         var value = serializer.Deserialize<string>(reader);
    //         switch (value)
    //         {
    //             case "gelding":
    //                 return Sex.Gelding;
    //             case "mare":
    //                 return Sex.Mare;
    //             case "stallion":
    //                 return Sex.Stallion;
    //         }
    //         throw new Exception("Cannot unmarshal type Sex");
    //     }

    //     public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    //     {
    //         if (untypedValue == null)
    //         {
    //             serializer.Serialize(writer, null);
    //             return;
    //         }
    //         var value = (Sex)untypedValue;
    //         switch (value)
    //         {
    //             case Sex.Gelding:
    //                 serializer.Serialize(writer, "gelding");
    //                 return;
    //             case Sex.Mare:
    //                 serializer.Serialize(writer, "mare");
    //                 return;
    //             case Sex.Stallion:
    //                 serializer.Serialize(writer, "stallion");
    //                 return;
    //         }
    //         throw new Exception("Cannot marshal type Sex");
    //     }

    //     public static readonly SexConverter Singleton = new SexConverter();
    // }

    // internal class V75TypeConverter : JsonConverter
    // {
    //     public override bool CanConvert(Type t) => t == typeof(V75Type) || t == typeof(V75Type?);

    //     public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    //     {
    //         if (reader.TokenType == JsonToken.Null) return null;
    //         var value = serializer.Deserialize<string>(reader);
    //         if (value == ".MarkingBetStartPool")
    //         {
    //             return V75Type.MarkingBetStartPool;
    //         }
    //         throw new Exception("Cannot unmarshal type V75Type");
    //     }

    //     public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    //     {
    //         if (untypedValue == null)
    //         {
    //             serializer.Serialize(writer, null);
    //             return;
    //         }
    //         var value = (V75Type)untypedValue;
    //         if (value == V75Type.MarkingBetStartPool)
    //         {
    //             serializer.Serialize(writer, ".MarkingBetStartPool");
    //             return;
    //         }
    //         throw new Exception("Cannot marshal type V75Type");
    //     }

    //     public static readonly V75TypeConverter Singleton = new V75TypeConverter();
    // }

    // internal class PlatsTypeConverter : JsonConverter
    // {
    //     public override bool CanConvert(Type t) => t == typeof(PlatsType) || t == typeof(PlatsType?);

    //     public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    //     {
    //         if (reader.TokenType == JsonToken.Null) return null;
    //         var value = serializer.Deserialize<string>(reader);
    //         if (value == ".PlatsStartPool")
    //         {
    //             return PlatsType.PlatsStartPool;
    //         }
    //         throw new Exception("Cannot unmarshal type PlatsType");
    //     }

    //     public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    //     {
    //         if (untypedValue == null)
    //         {
    //             serializer.Serialize(writer, null);
    //             return;
    //         }
    //         var value = (PlatsType)untypedValue;
    //         if (value == PlatsType.PlatsStartPool)
    //         {
    //             serializer.Serialize(writer, ".PlatsStartPool");
    //             return;
    //         }
    //         throw new Exception("Cannot marshal type PlatsType");
    //     }

    //     public static readonly PlatsTypeConverter Singleton = new PlatsTypeConverter();
    // }

    // internal class VinnareTypeConverter : JsonConverter
    // {
    //     public override bool CanConvert(Type t) => t == typeof(VinnareType) || t == typeof(VinnareType?);

    //     public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    //     {
    //         if (reader.TokenType == JsonToken.Null) return null;
    //         var value = serializer.Deserialize<string>(reader);
    //         if (value == ".VinnareStartPool")
    //         {
    //             return VinnareType.VinnareStartPool;
    //         }
    //         throw new Exception("Cannot unmarshal type VinnareType");
    //     }

    //     public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    //     {
    //         if (untypedValue == null)
    //         {
    //             serializer.Serialize(writer, null);
    //             return;
    //         }
    //         var value = (VinnareType)untypedValue;
    //         if (value == VinnareType.VinnareStartPool)
    //         {
    //             serializer.Serialize(writer, ".VinnareStartPool");
    //             return;
    //         }
    //         throw new Exception("Cannot marshal type VinnareType");
    //     }

    //     public static readonly VinnareTypeConverter Singleton = new VinnareTypeConverter();
    // }


}

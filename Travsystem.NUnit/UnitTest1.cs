using System;
using System.Threading.Tasks;
using NUnit.Framework;
using Travsystem.Service;

namespace Travsystem.NUnit
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task Test1()
        {
            
            //var atgService = new Travsystem.ATGService();
            //var race = atgService.
            IATGClientService service = new ATGClientService();
            var race = await service.GetRace("V75_2020-02-22_8_5");
            Assert.IsNotNull(race);
            Assert.Pass();
        }

        [Test]
        public async Task Test2()
        {
            IATGClientService service = new ATGClientService();
            var race = await service.GetRaceDay(DateTime.Parse("2020-02-15"));
            Assert.IsNotNull(race);
            Assert.Pass();
        }
    }
}
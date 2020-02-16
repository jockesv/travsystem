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
            var race = await service.GetRaceDay();
            Assert.IsNotNull(race);
            Assert.Pass();
        }
    }
}
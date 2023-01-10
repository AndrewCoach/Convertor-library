using ConvertorLibs.Services;

namespace ConverterTest
{
    public class Tests
    {
        public DistanceConvertorService distanceService { get; set; }

        [SetUp]
        public void Setup()
        {
            distanceService = new DistanceConvertorService();
        }

        [Test]
        public void MetersToInchesTest()
        {
            Assert.AreEqual($"{5 * 3} foot", distanceService.Convert("5 meter", "foot"));
        }
    }
}
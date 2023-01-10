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
            Assert.AreEqual("No suitable conversion was found for inputs 5 jumps and foot", distanceService.Convert("5 jumps", "foot"));
        }

        [Test]
        public void SendInZeroTest()
        {
            Assert.AreEqual($"0 m", distanceService.Convert("0 foot", "m"));
        }

        [Test]
        public void CanCannotConvertTest()
        {
            Assert.AreEqual(true, distanceService.CanConvert("meter", "foot"));
            Assert.AreEqual(false, distanceService.CanConvert("meter", "meter"));
        }
    }
}
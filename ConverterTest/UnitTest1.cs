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
        public void Test1()
        {
            Assert.AreEqual(distanceService.Convert("5 feet", "inches"), "100");
        }
    }
}
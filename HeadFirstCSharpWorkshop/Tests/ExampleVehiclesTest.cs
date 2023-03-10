using HeadFirstCSharpWorkshop.Code;

namespace HeadFirstCSharpWorkshop.Tests
{
    [TestFixture]
    public class ExampleVehiclesTest
    {
        private Car car;
        private MotorBike motorBike;

        [SetUp]
        public void SetUp()
        {
            car = new Car();
            motorBike = new MotorBike();
        }

        [Test]
        public void CarCreationTest()
        {
            Assert.NotNull(car);
        }

        [Test]
        public void MotorBikeCreationTest()
        {
            Assert.NotNull(motorBike);
        }


        [TestCase("Motorbike engine on!")]
        public void setEnginePowerMotorBikeOnTest(string expectedMessage)
        {

            string motorBikeEngineMessage = motorBike.setEnginePowerOn();
            Assert.AreEqual(expectedMessage, motorBikeEngineMessage);
        }

        [TestCase("Car engine on!")]
        public void setEnginePowerCarOnTest(string expectedMessage)
        {
            string carEngineMessage = car.setEnginePowerOn();
            Assert.AreEqual(expectedMessage, carEngineMessage);
        }
    }
}
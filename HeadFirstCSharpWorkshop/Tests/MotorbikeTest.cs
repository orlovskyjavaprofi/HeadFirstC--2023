using HeadFirstCSharpWorkshop.Code;


namespace HeadFirstCSharpWorkshop.Tests
{
    public class MotorbikeTest
    {
        private MotorBike motorBikeObj;

        [SetUp]
        public void setup()
        {
            motorBikeObj = new MotorBike();
        }

        [Test]
        public void creationOfmotorBikeObjTest()
        {
            Assert.NotNull(motorBikeObj);
        }
    }
}

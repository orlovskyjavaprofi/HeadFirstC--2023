using HeadFirstCSharpWorkshop.Code;


namespace HeadFirstCSharpWorkshop.Tests
{
    public class CarTest
    {
        private Car carObj;

        [SetUp]
        public void setup()
        {
            carObj = new Car();
        }

        [Test]
        public void creationOfCarObjTest()
        {
            Assert.NotNull(carObj);
        }

        [Test]
        public void powerEngineOnCarTest()
        {
            Assert.AreEqual("Car engine on!", carObj.setEnginePowerOn());
        }
    }
}

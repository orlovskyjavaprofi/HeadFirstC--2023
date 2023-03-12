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
    }
}

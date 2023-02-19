using HeadFirstCSharpWorkshop.Code;

namespace HeadFirstCSharpWorkshop.Tests
{
    public class FirstThreeChaptersTest
    {
        Program programObj;

       [SetUp]
        public void setup()
        {
            programObj= new Program();
        }

        [Test]
        public void creationOfProgramObjTest()
        {
            Assert.NotNull(programObj);
        }
    }
}
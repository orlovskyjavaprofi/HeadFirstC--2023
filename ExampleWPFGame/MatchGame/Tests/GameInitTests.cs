
using MatchGame.GameCode;
using NUnit.Framework;

namespace MatchGame.Tests
{
    public class GameInitTests
    {

        private GameInitializer gameInitObj;

        [SetUp]
        public void setup()
        {
            gameInitObj = new GameInitializer();
        }

        [Test]
        public void creationOfProgramObjTest()
        {
            Assert.NotNull(gameInitObj);
        }

    }
}

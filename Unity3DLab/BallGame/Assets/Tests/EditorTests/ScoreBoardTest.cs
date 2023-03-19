using System.Collections;
using System.Collections.Generic;
using BallGame.Scripts;
using NUnit.Framework;

namespace BallGame.Tests
{
    public class ScoreBoardTest
    {
        private ScoreBoard scoreBoardObj;

        [SetUp]
        public void setup()
        {
            scoreBoardObj = new ScoreBoard();
        }

        [Test]
        public void checkIfScoreBoardCanBeCreated()
        {
            Assert.NotNull(scoreBoardObj);
        }

        [Test]
        public void checkIfScoreCanBeCounted()
        {
            Assert.AreEqual(1, scoreBoardObj.ClickedOnBall());
        }
    }

}


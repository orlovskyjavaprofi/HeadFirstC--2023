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

        [Test]
        public void checkIfInitialNumberOfBallsCorrect()
        {
            Assert.AreEqual(0, scoreBoardObj.getAmountofBalls());
        }

        [Test]
        public void checkIfMaxBallsIsSetUp()
        {
            Assert.AreEqual(15, scoreBoardObj.getAmountOfMaxBalls());
        }

        [Test]
        public void checkIfNumberOfBallsCanBeRaised()
        {
            scoreBoardObj.increaseAmountOfBalls();
            Assert.AreEqual(1, scoreBoardObj.getAmountofBalls());
        }

        [Test]
        public void checkThatInitialAmountOfBallsCanBeSet()
        {
            scoreBoardObj.setinitialNumberofBalls(15);
            Assert.AreEqual(15, scoreBoardObj.getAmountofBalls());
        }
    }

}


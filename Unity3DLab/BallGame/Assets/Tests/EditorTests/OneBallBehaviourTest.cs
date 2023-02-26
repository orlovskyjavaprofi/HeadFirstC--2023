using System.Collections;
using System.Collections.Generic;
using BallGame.Scripts;
using NUnit.Framework;

namespace BallGame.Tests
{

    public class OneBallBehaviourTest
    {
        private OneBallBehaviour oneBallBehaviourObj;

        [SetUp]
        public void setup()
        {
            oneBallBehaviourObj = new OneBallBehaviour();
        }

        [Test]

        public void checkIfOneBallBehaviourObjCanBeCreatedTest()
        {
            Assert.NotNull(oneBallBehaviourObj);
        }
    }
}
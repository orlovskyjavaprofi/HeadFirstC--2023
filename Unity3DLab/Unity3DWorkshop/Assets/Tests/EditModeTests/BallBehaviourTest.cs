using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using Unity3DWorkshop.Scripts;

namespace Unity3DWorkshop.Tests
{
    public class BallBehaviourTest
    {
        private BallBehaviour ballBehaviourObj;

        [SetUp]
        public void setup()
        {
            ballBehaviourObj = new BallBehaviour();
        }

        [Test]
        public void checkIfBallBehaviourObjCanBeCreatedTest()
        {
            Assert.NotNull(ballBehaviourObj);
        }


    }
}
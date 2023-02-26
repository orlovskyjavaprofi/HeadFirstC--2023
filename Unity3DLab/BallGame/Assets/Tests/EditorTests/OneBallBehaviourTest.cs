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

        [Test]
        public void checkIfXRotationIsInitiated()
        {
            Assert.AreEqual(0, oneBallBehaviourObj.getXRotation());
        }

        [Test]
        public void checkIfYRotationIsInitiated()
        {
            Assert.AreEqual(1, oneBallBehaviourObj.getYRotation());
        }


        [Test]
        public void checkIfZRotationIsInitiated()
        {
            Assert.AreEqual(0, oneBallBehaviourObj.getZRotation());
        }

        [Test]
        public void checkIfDegreesPerSecondIsInitiated()
        {
            Assert.AreEqual(180, oneBallBehaviourObj.getDegreesPerSecond());
        }
    }
}
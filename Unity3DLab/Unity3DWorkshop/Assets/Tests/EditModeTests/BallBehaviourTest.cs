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

        [Test]
        public void checkIfInitialXRotationSetUp()
        {
            Assert.AreEqual(0, ballBehaviourObj.getXRotation());
        }

        [Test]
        public void checkIfInitialYRotationSetUp()
        {
            Assert.AreEqual(0, ballBehaviourObj.getYRotation());
        }

        [Test]
        public void checkIfInitialZRotationSetUp()
        {
            Assert.AreEqual(0, ballBehaviourObj.getZRotation());
        }

        [Test]
        public void checkIfInitialDegreePerSecond()
        {
            Assert.AreEqual(180, ballBehaviourObj.getDegreesPerSecond());
        }
    }
}
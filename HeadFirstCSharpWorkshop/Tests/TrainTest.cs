using HeadFirstCSharpWorkshop.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstCSharpWorkshop.Tests
{
    public class TrainTest
    {
        private Train trainObj;

        [SetUp]
        public void setup()
        {
            trainObj = new Train("Train Express", "88950WPF");
        }

        [Test]
        public void creationOfTrainTest()
        {
            Assert.NotNull(trainObj);
        }

        [Test]
        public void checkIfTrainNameCanBeSet()
        {
            Assert.AreEqual("Train Express", trainObj.getTrainName());
        }

        [Test]
        public void checkIfTrainNumberCanBeSet()
        {
            Assert.AreEqual("88950WPF", trainObj.getTrainNumber());
        }

        [Test]
        public void checkIfTrainStarted()
        {
            Assert.AreEqual("Train Express 88950WPF started!", trainObj.startTrain());
        }
    
    }

}

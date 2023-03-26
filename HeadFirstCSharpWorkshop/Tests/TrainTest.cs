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
            trainObj = new Train();
        }

        [Test]
        public void creationOfTrainTest()
        {
            Assert.NotNull(trainObj);
        }
    }
}

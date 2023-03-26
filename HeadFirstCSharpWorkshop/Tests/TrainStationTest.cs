using HeadFirstCSharpWorkshop.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstCSharpWorkshop.Tests
{
    public class TrainStationTest
    {
        private TrainStation trainStationObj;

        [SetUp]
        public void setup()
        {
            trainStationObj = new TrainStation();
        }

        [Test]
        public void creationOfTrainStationTest()
        {
            Assert.NotNull(trainStationObj);
        }
    }
}

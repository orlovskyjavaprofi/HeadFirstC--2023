using HeadFirstCSharpWorkshop.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstCSharpWorkshop.Tests
{
    public class ExampleVehiclesTest
    {
        private IDriveable drivableObj;

        [SetUp]
        public void setup()
        {
            drivableObj = new Car();
        }

        [Test]
        public void creationOfDriveableObjTest()
        {
            Assert.NotNull(drivableObj);
        }
    }
}

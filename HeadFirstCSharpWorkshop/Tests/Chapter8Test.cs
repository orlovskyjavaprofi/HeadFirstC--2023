using HeadFirstCSharpWorkshop.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstCSharpWorkshop.Tests
{
    public class Chapter8Test
    {
        private Chapter8 chapter8Obj;

        [SetUp]
        public void setup()
        {
            chapter8Obj = new Chapter8();
        }


        [Test]
        public void creationOfChapter8Test()
        {
            Assert.NotNull(chapter8Obj);
        }
    }
}


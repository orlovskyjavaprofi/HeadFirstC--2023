using HeadFirstCSharpWorkshop.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstCSharpWorkshop.Tests
{
    public class BankClientTest
    {
        private BankClient bankClientObj;

        [SetUp]
        public void setup()
        {
            bankClientObj = new BankClient();
        }
        
        [Test]
        public void creationOfBankClientTest()
        {
            Assert.NotNull(bankClientObj);
        }

        [Test]
        public void generate12DigitNumberTest()
        {
            Assert.AreEqual(12, bankClientObj.generateAuthNumber().Length);
        }
    }
}

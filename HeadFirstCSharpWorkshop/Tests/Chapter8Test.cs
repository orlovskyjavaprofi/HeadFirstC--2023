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

        [Test]
        public void getWelcomeTextFromBankTest()
        {
            Bank bankObj = new Bank();
            Assert.AreEqual("Welcome to the Bank!", bankObj.getWelcomeMessage());
        }

        [Test]
        public void createManyBankClientsTest()
        {
            Bank bankObj = new Bank();
            BankClient bankClient1 = new BankClient();
            BankClient bankClient2 = new BankClient();
            bankObj.addBankClient(bankClient1);
            bankObj.addBankClient(bankClient2);
            Assert.AreEqual(2, bankObj.getAmountOfClients());
        }
    }
}


using HeadFirstCSharpWorkshop.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstCSharpWorkshop.Tests
{
    public class BankTest
    {
        private Bank bankObj;

        [SetUp]
        public void setup()
        {
            bankObj = new Bank();
        }

        [Test]
        public void creationOfBankTest()
        {
            Assert.NotNull(bankObj);
        }

        [Test]
        public void addClientToTheBankTest()
        {
            BankClient bankClient1 = new BankClient();

            Assert.AreEqual(true, bankObj.addBankClient(bankClient1));
        }

        [Test]
        public void storingClientsToTheBankTest()
        {            
            BankClient bankClient1 = new BankClient();
            bankObj.addBankClient(bankClient1);
            BankClient bankClient2 = new BankClient();
            bankObj.addBankClient(bankClient2);
            BankClient bankClient3 = new BankClient();
            bankObj.addBankClient(bankClient3);
            BankClient bankClient4 = new BankClient();
            bankObj.addBankClient(bankClient4);
            BankClient bankClient5 = new BankClient();
            bankObj.addBankClient(bankClient5);

            Assert.AreEqual(5, bankObj.getAmountOfClients());
        }
    }
}

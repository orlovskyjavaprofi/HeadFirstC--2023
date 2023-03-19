using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstCSharpWorkshop.Code
{
    public interface IBankable
    {
        public bool addBankClient(BankClient newBankClient);
        public int getAmountOfClients();
        public String getWelcomeMessage();
    }
}

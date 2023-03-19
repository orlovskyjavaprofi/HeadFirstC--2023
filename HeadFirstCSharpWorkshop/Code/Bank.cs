﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstCSharpWorkshop.Code
{
    public class Bank : IBankable
    {
        private List<BankClient> listOfBankClients;
        
        public Bank()
        {
           listOfBankClients = new List<BankClient>();
        }

       public bool addBankClient(BankClient newBankClient)
        {
            bool result = false;

            if (newBankClient != null)
            {
                this.getListOfBankClients().Add(newBankClient);
                result = true;
            }

            return result;
        }

        public int getAmountOfClients()
        {
            int result = 0;

            if(this.getListOfBankClients().Count > 0)
            {
                result = this.getListOfBankClients().Count;
            }

            return result;

        }

        private List<BankClient> getListOfBankClients()
        {
            return this.listOfBankClients;
        }

    }
}

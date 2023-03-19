using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstCSharpWorkshop.Code
{
    public class BankClient : IClientTypeAuthable
    {
        private String clientAuthNumber="0";

        public BankClient(){
            this.storeClientAuthNumber();
        }

        public String generateAuthNumber()
        {
            String resultNum = this.generateRandom12DigitNumber();

            return resultNum;
        }

        private void storeClientAuthNumber()
        {
            clientAuthNumber = this.generateAuthNumber();
        }
        private string generateRandom12DigitNumber()
        {
            Random random = new Random((int)DateTime.Now.Ticks);
            StringBuilder builder = new StringBuilder();
            char digit;
            for (int i = 0; i < 12; i++)
            {
                digit = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(digit);
            }

            return builder.ToString();
        }

    }
}

using System;
using System.Text;


namespace HeadFirstCSharpWorkshop.Code
{
    public class Program
    {
        private String Message;

        public Program() {
            this.Message = OutputHelleoWorld();
        }
        static void Main(string[] args)
        {
            Program programObj = new Program();
            Console.WriteLine(programObj.Message);
        }
        public String OutputHelleoWorld()
        {
            this.Message = "Hello World!";
            return "Hello World!";
        }
    }
}

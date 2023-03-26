using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstCSharpWorkshop.Code
{
    public class Train
    {
        private String trainName;
        private String trainNumber;
        public Train(String inputNameOfTrain, string trainNumber)
        {
            setTrainName(inputNameOfTrain);
            setTrainNumber(trainNumber);
        }

        private void setTrainName(String inputName)
        {
            trainName = inputName;
        }

        private void setTrainNumber(String inputNumber)
        {
            trainNumber = inputNumber;
        }

        public String getTrainName()
        {
            return trainName;
        }

        public String getTrainNumber()
        {
            return trainNumber;
        }

        public String startTrain()
        {
            return getTrainName() +" "+ getTrainNumber() + " "+"started!";
        }

    }
}

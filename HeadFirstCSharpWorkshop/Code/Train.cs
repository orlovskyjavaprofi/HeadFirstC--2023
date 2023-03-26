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
        public Train(String inputNameOfTrain)
        {
            setTrainName(inputNameOfTrain);
        }

        private void setTrainName(String inputName)
        {
            trainName = inputName;
        }

        public String getTrainName()
        {
            return trainName;
        }
    }
}

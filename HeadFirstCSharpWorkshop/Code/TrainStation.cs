using System;
using System.Threading;

namespace HeadFirstCSharpWorkshop.Code
{

    public class TrainStation
    {       
        public static void startTrainStationOps()
        {                 
            Console.WriteLine("Welcome to the train station!");
            ThreadStart trainStaionThread = new ThreadStart(startRailWayStationThread);
            Console.WriteLine("Railway station: preparing trains for start!");
            Thread mainRailwayStationThread = new Thread(trainStaionThread);

            Thread train1Thread = new Thread(new ThreadStart(startTrain1Thread));
            Thread train2Thread = new Thread(new ThreadStart(startTrain2Thread));

            train1Thread.Start();
            train2Thread.Start();
            Console.ReadKey();
        }

        public static void startRailWayStationThread()
        {
           Console.WriteLine("Main railway station thread started!");
        }

        public static void startTrain1Thread()
        {
            Train train1 = new Train("Express train", "90568WPF");

            Console.WriteLine(train1.startTrain());
        }
        public static void startTrain2Thread()
        {
            Train train2 = new Train("Trade train", "1111Unity");

            Console.WriteLine(train2.startTrain());
        }


    }
}

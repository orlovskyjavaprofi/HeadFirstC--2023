using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace MatchGame.GameCode
{
    public class GameTimer
    {
        private DispatcherTimer timer = new DispatcherTimer();
        private int tenthsOfSecondsElapsed;

        public GameTimer()
        {
            timer.Interval = TimeSpan.FromSeconds(.1);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            tenthsOfSecondsElapsed++;                    
        }

        public int getTimerTick()
        {
            return this.tenthsOfSecondsElapsed;
        }

        public bool stopTimer(String inputMessage)
        {
            bool result = false;

            if (String.IsNullOrEmpty(inputMessage) == false && inputMessage.Equals("Stop timer"))
            {
                timer.Stop();
                result = true;
            }
            return result;
        }
    }
}

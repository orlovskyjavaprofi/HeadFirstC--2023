using System.Collections;
using System.Collections.Generic;

namespace BallGame.Scripts
{
    public class ScoreBoard
    {
        private int Score;

        public ScoreBoard()
        {
            Score = 0;
        }
        public int ClickedOnBall()
        {
            this.Score = Score + 1;
            return this.Score;
        }
    }
}
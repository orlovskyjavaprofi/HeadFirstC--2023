using System.Collections;
using System.Collections.Generic;

namespace BallGame.Scripts
{
    public class ScoreBoard
    {
        private int Score;
        private int NumberOfBalls;
        private int MaximumBalls;

        public ScoreBoard()
        {
            Score = 0;
            NumberOfBalls = 0;
            MaximumBalls = 15;
        }
        public int ClickedOnBall()
        {
            Score++;
            NumberOfBalls--;
            return this.Score;
        }

        public int getAmountofBalls()
        {
            return NumberOfBalls;
        }

        public int getAmountOfMaxBalls()
        {
            return MaximumBalls;
        }

        public void increaseAmountOfBalls()
        {
            NumberOfBalls++;
        }

        public int getCurrentScore()
        {
            return Score;
        }

        public void setinitialScore(int input)
        {
            Score = input;
        }

        public void setinitialNumberofBalls(int input)
        {
            if(input <=15){ 
              NumberOfBalls = input;
            }
        }
    }
}
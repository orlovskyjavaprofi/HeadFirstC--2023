using System.Collections;
using System.Collections.Generic;

namespace BallGame.Scripts {
    public class OneBallBehaviour
    {
        private float XRotation;
        private float YRotation;
        private float ZRotation;
        private float DegreesPerSecond;
        public OneBallBehaviour()
        {
            this.XRotation = 0;
            this.YRotation = 1;
            this.ZRotation = 0;
            this.DegreesPerSecond = 180;
        }

        public float getXRotation()
        {
            return this.XRotation;
        }

        public float getYRotation()
        {
            return this.YRotation;
        }

        public float getZRotation()
        {
            return this.ZRotation;
        }

        public float getDegreesPerSecond()
        {
            return this.DegreesPerSecond;
        }
    }
}


using System.Collections;
using System.Collections.Generic;

namespace Unity3DWorkshop.Scripts
{
    public class BallBehaviour
    {
        private float XRotation;
        private float YRotation;
        private float ZRotation;
        private float DegreesPerSecond;
        public BallBehaviour()
        {
            this.XRotation = 0;
            this.YRotation = 0;
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
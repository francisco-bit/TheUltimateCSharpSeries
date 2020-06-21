using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPart2
{
    class StopWatch
    {
        //No need to use properties because we are not going to expose it
        public DateTime StartTime { get; private set;}
        public DateTime StopTime { get; private set;}
        public TimeSpan Duration { get; private set;}
        private bool isActive;

        public StopWatch()
        {
            isActive = false;
        }

        public void Start()
        {
            if (isActive)
                throw new InvalidOperationException("The Stopwatch is active");
            StartTime = DateTime.UtcNow;
            isActive = true;
        }
        
        public TimeSpan Stop()
        {
            if (isActive)
            {
                StopTime = DateTime.UtcNow;
                Duration = StopTime - StartTime;
                isActive = false;
            }
            else
            {
                throw new InvalidOperationException("The Stopwatch was not active");
            }

            return Duration;
        }
    
    }
}

namespace DelegateTimer
{
    using System;
    using System.Threading;

    public delegate void TickEvent();
    class Timer
    {
        private int ticks;
        private int secondsInterval;
        private TickEvent tickEvent;

        public int Ticks
        {
            get
            {
                return this.ticks;
            }
            set
            {
                this.ticks = value;
            }
        }

        public int Interval
        {
            get
            {
                return this.secondsInterval;
            }
            set
            {
                this.secondsInterval = value;
            }
        }

        public TickEvent Event
        {
            get
            {
                return this.tickEvent;
            }
            set
            {
                this.tickEvent = value;
            }
        }

        public Timer(int ticks, int interval, TickEvent tickEvent)
        {
            this.Ticks = ticks;
            this.Interval = interval;
            this.Event = tickEvent;
        }

        public void StartTimer()
        {
            while (ticks > 0)
            {
                Thread.Sleep(1000 * this.secondsInterval);
                ticks--;
                tickEvent();
            }
        }
    }
}

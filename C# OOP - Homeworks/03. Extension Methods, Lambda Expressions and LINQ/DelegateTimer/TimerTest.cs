//Problem 7. Timer

//Using delegates write a class Timer that can execute certain method at each t seconds.

namespace DelegateTimer
{
    using System;

    class TimerTest
    {
        static void Main()
        {
            Timer newTimer = new Timer(10, 2, delegate() { Console.WriteLine("Method executed"); });

            newTimer.StartTimer();
        }
    }
}

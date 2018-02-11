namespace TimeMachine.Console
{
    using System;
    using System.Collections.Generic;

    public sealed class DirectRouteTimeMachine : ITimeMachine
    {
        public void TimeTravel(int year)
        {
            Console.WriteLine($"You are traveling to {year}");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("You have arrived");
        }
    }
}
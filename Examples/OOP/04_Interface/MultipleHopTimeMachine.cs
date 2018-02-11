namespace TimeMachine.Console
{
    using System;
    using System.Collections.Generic;

    public sealed class MultipleHopTimeMachine : ITimeMachine
    {
        public void TimeTravel(int year)
        {
            hop(year + 5);
            hop(year);
        }

        private void hop(int year)
        {
            Console.WriteLine($"You are traveling to {year}");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("You have arrived");           
        }
    }
}
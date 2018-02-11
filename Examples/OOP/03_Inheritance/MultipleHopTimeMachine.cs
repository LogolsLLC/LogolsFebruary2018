namespace TimeMachine.Console
{
    using System;
    using System.Collections.Generic;

    public sealed class MultipleHopTimeMachine : TimeMachine
    {
        public override void TimeTravel(int year)
        {
            base.TimeTravel(year + 5);
            base.TimeTravel(year);
        }       
    }
}
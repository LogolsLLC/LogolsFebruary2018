namespace TimeMachine.Console
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {          
            TimeMachine direct = new DirectRouteTimeMachine();
            TimeMachine hop = new MultipleHopTimeMachine();
            direct.TimeTravel(1990);
            hop.TimeTravel(1990);
        }
    }
}

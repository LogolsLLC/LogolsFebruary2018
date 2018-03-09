using System;
using System.Collections.Generic;

namespace TimeMachine.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ITimeMachine> machines = new List<ITimeMachine>();
            machines.Add(new DirectRouteTimeMachine());
            machines.Add(new MultipleHopTimeMachine());
            machines.Add(new DirectRouteTimeMachine());
            machines.Add(new DirectRouteTimeMachine());
            foreach(ITimeMachine machine in machines)
            {
                machine.TimeTravel(1995);
            }
        }
    }
}

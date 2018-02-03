namespace TimeMachine.Console
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            TimeTravelLogRepository repository = new TimeTravelLogRepository();
            IEnumerable<TimeTravelLog> logs = repository.GetAll();
            Console.WriteLine("Here are the time travel logs:");
            foreach(TimeTravelLog log in logs)
            {
                Console.WriteLine($"{log.FirstName} {log.LastName} traveled to {log.TravelToYear} on {log.TravelDate:MM/dd/yyyy}.");
            }
        }
    }
}

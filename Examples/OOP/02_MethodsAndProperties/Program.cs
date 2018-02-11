namespace TimeMachine.Console
{
    using System;
    
    class Program
    {
        static void Main(string[] args)
        {
            TimeMachine timeMachine = new TimeMachine();
            timeMachine.Name = "Old Ben";
            Console.WriteLine("Name: " + timeMachine.Name);
            timeMachine.TimeTravel(2015);
            timeMachine.TimeTravel(1985);

            Console.WriteLine("Travel History:");
            foreach(int year in timeMachine.TravelHistory)
            {
                Console.WriteLine(year);
            }
        }
    }
}

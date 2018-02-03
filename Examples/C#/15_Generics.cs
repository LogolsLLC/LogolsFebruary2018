namespace TimeMachine.Console
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {          
            List<int> yearTraveledHistory = new List<int>();
            yearTraveledHistory = TimeTravel(2005, yearTraveledHistory);
            yearTraveledHistory = TimeTravel(1985, yearTraveledHistory);
            yearTraveledHistory = TimeTravel(1971, yearTraveledHistory);
            yearTraveledHistory = TimeTravel(1964, yearTraveledHistory);
            yearTraveledHistory = TimeTravel(2016, yearTraveledHistory);
            yearTraveledHistory = TimeTravel(1980, yearTraveledHistory);
            WriteYearsTraveled(yearTraveledHistory);
        }

        private static List<int> TimeTravel(int year, List<int> yearTraveledHistory)
        {
            Console.WriteLine($"You are traveling to {year}");
            System.Threading.Thread.Sleep(1000);
            if(year != 1985)
            {
                Console.WriteLine("You have arrived");
                yearTraveledHistory.Add(year);
            }
            else
            {
                Console.WriteLine("Travel failed");
            }
            return yearTraveledHistory;
        }

        private static void WriteYearsTraveled(List<int> yearTraveledHistory)
        {
            Console.WriteLine("Here is a list of the years you have traveled to: ");
            foreach(int year in yearTraveledHistory)
            {
                Console.WriteLine(year);
            } 
        }
    }
}

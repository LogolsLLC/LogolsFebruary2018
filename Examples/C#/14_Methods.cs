namespace TimeMachine.Console
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {          
            int[] yearTraveledHistory = new int[5];
            int count = 0;
            if (TimeTravel(2005))
            {
                yearTraveledHistory[count] = 2005;
                count++;
            }
            if (TimeTravel(1985))
            {
                yearTraveledHistory[count] = 1985;
                count++;
            }
            if (TimeTravel(1971))
            {
                yearTraveledHistory[count] = 1971;
                count++;
            }
            if (TimeTravel(1964))
            {
                yearTraveledHistory[count] = 1964;
                count++;
            }
            if (TimeTravel(2016))
            {
                yearTraveledHistory[count] = 2016;
                count++;
            }
            if (TimeTravel(1980))
            {
                yearTraveledHistory[count] = 1980;
                count++;
            }
            WriteYearsTraveled(yearTraveledHistory);
        }

        private static bool TimeTravel(int year)
        {
            Console.WriteLine($"You are traveling to {year}");
            System.Threading.Thread.Sleep(1000);
            if(year != 1985)
            {
                Console.WriteLine("You have arrived");
                return true;
            }
            else
            {
                Console.WriteLine("Travel failed");
                return false;
            }
        }

        private static void WriteYearsTraveled(int[] yearTraveledHistory)
        {
            Console.WriteLine("Here is a list of the years you have traveled to: ");
            foreach(int year in yearTraveledHistory)
            {
                Console.WriteLine(year);
            } 
        }
    }
}

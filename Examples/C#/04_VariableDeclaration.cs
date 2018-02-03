namespace TimeMachine.Console
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            //here are some variables I might need
            bool timeTravelComplete = false; //indicator of whether I have completed travel
            int travelYear = 2017; //year to travel to
            decimal minutesTraveled = 5.35M; //number of minutes traveled
            string travelCompleteMessage = "You have arrived."; //message to display when travel is completed
            int[] yearTraveledHistory = new int[] {1975, 1960, 1985, 2012}; //years traveled to.
            Console.WriteLine("timeTravelComplete: " + timeTravelComplete);
            Console.WriteLine("travelYear: " + travelYear);
            Console.WriteLine("minutesTraveled: " + minutesTraveled);
            Console.WriteLine("travelCompleteMessage: " + travelCompleteMessage);
            int count = 1;
            foreach(int val in yearTraveledHistory)
            {
                Console.WriteLine("yearTraveledHistory index " + count + ": " + val);
                count++;
            }
        }
    }
}

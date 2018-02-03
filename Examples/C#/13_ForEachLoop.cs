namespace TimeMachine.Console
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            
            int[] yearTraveledHistory = new int[] {1975, 2005, 1962, 1980};
            Console.WriteLine("Here is a list of the years you have traveled to: ");
            foreach(int year in yearTraveledHistory)
            {
                Console.WriteLine(year);
            } 
        }
    }
}

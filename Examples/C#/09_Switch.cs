namespace TimeMachine.Console
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name:");
            string enteredName = Console.ReadLine();
            switch(enteredName)
            {
                case "Joe":
                    Console.WriteLine("You have full access.");
                    break;
                case "Stan":
                    Console.WriteLine("You have access to command, but not travel.");
                    break;
                case "Laura":
                    Console.WriteLine("You have access to travel, but not command.");
                    break;
                default:
                    Console.WriteLine("You do not have access.");
                    break;
            }
        }
    }
}

namespace TimeMachine.Console
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name:");
            string enteredName = Console.ReadLine();
            if(enteredName == "Joe")
            {
                Console.WriteLine("You have full access.");
            }
            else if(enteredName == "Stan")
            {
                Console.WriteLine("You have access to command, but not travel.");
            }
            else if(enteredName == "Laura")
            {
                Console.WriteLine("You have access to travel, but not command.");
            }
            else
            {
                Console.WriteLine("You do not have access.");
            }
        }
    }
}

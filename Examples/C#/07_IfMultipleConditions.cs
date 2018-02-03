namespace TimeMachine.Console
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int correctAnswer = 2;
            int correctAnswer2 = 3;
            if(correctAnswer == getAnswer() && correctAnswer2 == getAnswer2() && getAnswer3() > 5)
            {
                Console.WriteLine("You are correct!");
            }
            else
            {
                Console.WriteLine("Sorry, that is not correct.");
            }
        }

        private static int getAnswer()
        {
            Console.WriteLine("Verify your identity:  What state do you live in?");
            Console.WriteLine("[1] Ohio");
            Console.WriteLine("[2] Michigan");
            Console.WriteLine("[3] Indiana");
            Console.WriteLine("[4] Florida");
            return Convert.ToInt32(Console.ReadLine());
        }

        private static int getAnswer2()
        {
            Console.WriteLine("What is your cats name?");
            Console.WriteLine("[1] Frank");
            Console.WriteLine("[2] Tommy");
            Console.WriteLine("[3] Jonah");
            Console.WriteLine("[4] Whiskers");
            return Convert.ToInt32(Console.ReadLine());
        }

        private static int getAnswer3()
        {
            Console.WriteLine("Enter a number greater than 5");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}

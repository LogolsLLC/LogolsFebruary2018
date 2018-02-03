namespace TimeMachine.Console
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int correctAnswer = 2;
            if(correctAnswer == getAnswer())
            {
                Console.WriteLine("You are correct!");
            }
            else
            {
                Console.WriteLine("Sorry, that is not correct, try again?");
                if(Console.ReadLine() == "Y")
                {
                    if(getAnswer() == correctAnswer)
                    {
                        Console.WriteLine("You got it on the second try!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, still not correct");
                    }
                }
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
    }
}

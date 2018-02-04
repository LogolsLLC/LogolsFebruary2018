namespace TestLoop
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            /*
            A status report is needed of all government employees.  Statuses are:
            1: Alive, 2: Zombie, 3: Dead, 4: Unknown
            Given an array of int variable, write loops with if else statements and console out everyone’s status.
            Use all loop types.
            Given another array of string variables with names, write out the name and their status.
             */
            int counter = 0;
            int[] statuses = {1, 4, 3, 2, 3, 2};
            string[] names = {"Bob", "Tim", "Tom", "Barb", "Kent", "Carlos"};
            while(counter < statuses.Length)
            {
                Console.Write(names[counter] + " ");
                //switch statement
                switch (statuses[counter])
                {
                    case 1:
                        Console.WriteLine("Status: Alive");
                        break;
                    case 2:
                        Console.WriteLine("Status: Zombie");
                        break;
                    case 3:
                        Console.WriteLine ("Status: Dead");
                        break;
                    case 4:
                        Console.WriteLine("Status: Unknown");
                        break;
                }
                counter++;
            }

            counter = 0;
            do
            {
                Console.Write(names[counter] + " ");
                //switch statement
                switch (statuses[counter])
                {
                    case 1:
                        Console.WriteLine("Status: Alive");
                        break;
                    case 2:
                        Console.WriteLine("Status: Zombie");
                        break;
                    case 3:
                        Console.WriteLine ("Status: Dead");
                        break;
                    case 4:
                        Console.WriteLine("Status: Unknown");
                        break;
                }
                counter++;
            } while(counter < statuses.Length);

            for(counter = 0; counter < statuses.Length; counter++)
            {
                Console.Write(names[counter] + " ");
                //switch statement
                switch (statuses[counter])
                {
                    case 1:
                        Console.WriteLine("Status: Alive");
                        break;
                    case 2:
                        Console.WriteLine("Status: Zombie");
                        break;
                    case 3:
                        Console.WriteLine ("Status: Dead");
                        break;
                    case 4:
                        Console.WriteLine("Status: Unknown");
                        break;
                }
            }

            counter = 0;
            foreach(int status in statuses)
            {
                Console.Write(names[counter] + " ");
                //switch statement
                switch (status)
                {
                    case 1:
                        Console.WriteLine("Status: Alive");
                        break;
                    case 2:
                        Console.WriteLine("Status: Zombie");
                        break;
                    case 3:
                        Console.WriteLine ("Status: Dead");
                        break;
                    case 4:
                        Console.WriteLine("Status: Unknown");
                        break;
                }
                counter++;
            }
        }
    }
}

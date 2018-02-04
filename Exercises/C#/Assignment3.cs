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
            Modify your previous program to create a method that handles the condition given a parameter for status and for name that returns the concatenated string.
            Write a void method that takes a string parameter and writes it to the console.
             */
            int counter = 0;
            int[] statuses = {1, 4, 3, 2, 3, 2};
            string[] names = {"Bob", "Tim", "Tom", "Barb", "Kent", "Carlos"};
            for(counter = 0; counter < statuses.Length; counter++)
            {
                string status = GetStatusDescription(statuses[counter], names[counter]);
                WriteStatus(status);
            }
        }

        private static void WriteStatus(string status)
        {
            Console.WriteLine(status);
        }

        private static string GetStatusDescription(int status, string name)
        {
            string statusDescription = string.Empty;
            switch (status)
            {
                case 1:
                    statusDescription = "Status: Alive";
                    break;
                case 2:
                    statusDescription = "Status: Zombie";
                    break;
                case 3:
                    statusDescription = "Status: Dead";
                    break;
                case 4:
                    statusDescription = "Status: Unknown";
                    break;
            }
            return name + " " + statusDescription;
        }
    }
}

namespace ZombieReport.Console
{
    using System;
    using System.Collections.Generic;
    class Program
    {
        static void Main(string[] args)
        {
            /*
            A status report is needed of all government employees.  Statuses are:
            1: Alive, 2: Zombie, 3: Dead, 4: Unknown
            Modify your previous program to create a generic list of names of everyone who is alive.
            At the end of the program, list everyone still alive.
             */
            int counter = 0;
            int[] statuses = {1, 4, 3, 2, 1, 2};
            string[] names = {"Bob", "Tim", "Tom", "Barb", "Kent", "Carlos"};
            List<string> alive = new List<string>();

            for(counter = 0; counter < statuses.Length; counter++)
            {
                if(statuses[counter] == 1)
                {
                    alive.Add(names[counter]);
                }
                string status = GetStatusDescription(statuses[counter], names[counter]);
                WriteStatus(status);
            }
            WriteAlive(alive);
        }

        private static void WriteAlive(List<string> alive)
        {
            Console.WriteLine("Currently Alive:");
            foreach(string name in alive)
            {
                Console.WriteLine(name);
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

namespace ZombieReport.Console
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            PersonStatusRepository repository = new PersonStatusRepository();
            IEnumerable<PersonStatus> statuses = repository.GetAll();
            Console.WriteLine("Here are the time travel logs:");
            foreach(PersonStatus status in statuses)
            {
                Console.WriteLine($"{status.FirstName} {status.LastName} has status of {status.StatusDescription}.");
            }
        }
    }
}

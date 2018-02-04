using System;
using System.Collections.Generic;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IPerson> people = new List<IPerson>();
            people.Add(new Human());
            people.Add(new Zombie());
            people.Add(new Zombie());
            foreach(IPerson person in people)
            {
                person.Walk(30M);
                Console.WriteLine("Person distance:  " + person.DistanceTraveled);
            }
        }
    }
}

using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.DistanceTraveled = 5.5M;
            Person person2 = new Person();
            person2.DistanceTraveled = 4.2M;
            Console.WriteLine("Person 1 distance:  " + person1.DistanceTraveled);
            Console.WriteLine("Person 2 distance:  " + person2.DistanceTraveled);
        }
    }
}

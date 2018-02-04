using System;
namespace Assignment1
{
    public abstract class Person
    {
        public decimal DistanceTraveled { get; set; }

        public Person()
        {
            Console.WriteLine("A new person has been created.");
        }

        public virtual void Walk(decimal minutes)
        {
            DistanceTraveled += minutes * 1M;
        }
    }
}
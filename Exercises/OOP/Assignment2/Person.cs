using System;
namespace Assignment1
{
    public class Person
    {
        private decimal distanceTraveled;

        public decimal DistanceTraveled
        {
            get
            {
                return distanceTraveled;
            }
            set
            {
                distanceTraveled = value;
            }
        }

        //auto - implemented syntax
        //public decimal DistanceTraveled { get; set; }

        public Person()
        {
            Console.WriteLine("A new person has been created.");
        }
    }
}
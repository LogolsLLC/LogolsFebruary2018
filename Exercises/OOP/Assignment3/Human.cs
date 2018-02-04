using System;
namespace Assignment1
{
    public sealed class Human : Person
    {
        public void Run(decimal minutes)
        {
            DistanceTraveled += minutes * 1.5M;
        }
    }
}
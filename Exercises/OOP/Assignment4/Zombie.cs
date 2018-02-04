using System;
namespace Assignment1
{
    public sealed class Zombie : IPerson
    {
        public decimal DistanceTraveled { get; set; }

        public void Walk(decimal minutes)
        {
            DistanceTraveled += minutes * 0.5M;
        }
    }
}
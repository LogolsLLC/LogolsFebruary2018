using System;
namespace Assignment1
{
    public sealed class Zombie : Person
    {
        public override void Walk(decimal minutes)
        {
            DistanceTraveled += minutes * 0.5M;
        }
    }
}
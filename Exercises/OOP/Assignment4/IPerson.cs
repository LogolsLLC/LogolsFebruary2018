using System;
namespace Assignment1
{
    public interface IPerson
    {
        decimal DistanceTraveled { get; set; }

        void Walk(decimal minutes);
    }
}
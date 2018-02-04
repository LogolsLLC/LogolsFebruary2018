using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();
            Zombie zombie = new Zombie();
            human.Walk(30M);
            zombie.Walk(30M);
            Console.WriteLine("Human distance:  " + human.DistanceTraveled);
            Console.WriteLine("Zombie distance:  " + zombie.DistanceTraveled);
            human.Run(30M);
            zombie.Walk(30M);
            Console.WriteLine("Human distance:  " + human.DistanceTraveled);
            Console.WriteLine("Zombie distance:  " + zombie.DistanceTraveled);
            human.Walk(30M);
            zombie.Walk(30M);
            Console.WriteLine("Human distance:  " + human.DistanceTraveled);
            Console.WriteLine("Zombie distance:  " + zombie.DistanceTraveled);
        }
    }
}

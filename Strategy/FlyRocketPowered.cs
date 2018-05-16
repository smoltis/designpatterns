using System;

namespace Strategy
{
    internal class FlyRocketPowered : IFlyBehavior
    {
        public void PerformFly()
        {
            Console.WriteLine("I can fly like a rocket now!");
        }
    }
}
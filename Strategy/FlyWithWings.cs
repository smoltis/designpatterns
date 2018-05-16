using System;

namespace Strategy
{
    public class FlyWithWings : IFlyBehavior
    {
        public void PerformFly()
        {
            Console.WriteLine("I'm flying!");
        }
    }
}
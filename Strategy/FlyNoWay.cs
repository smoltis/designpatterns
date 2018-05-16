using System;

namespace Strategy
{
    internal class FlyNoWay : IFlyBehavior
    {
        public void PerformFly()
        {
            Console.WriteLine("I can't fly :(");
        }
    }
}
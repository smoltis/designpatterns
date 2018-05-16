using System;

namespace Strategy
{
    internal class RubberDuck : Duck
    {
        public RubberDuck()
        {
            SetFlyBehavoir(new FlyNoWay());
            SetQuackBehavoir(new SqweekBeahavior());
        }

        public override void Display()
        {
            Console.WriteLine("I'm a Rubber Duckie!");

        }
    }
}
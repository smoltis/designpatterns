using System;

namespace Strategy
{
    internal class ModelDuck : Duck
    {
        public ModelDuck()
        {
            SetFlyBehavoir(new FlyNoWay());
            SetQuackBehavoir(new FakeQuack());
        }

        public override void Display()
        {
            Console.WriteLine("I'm a Model of a duck!");
        }
    }
}
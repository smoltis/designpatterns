using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace Strategy
{
    internal class DecoyDuck : Duck
    {
        public DecoyDuck()
        {
            SetFlyBehavoir(new FlyNoWay());
            SetQuackBehavoir(new MuteQuack());
        }

        public override void Display()
        {
            Console.WriteLine("I'm a Decoy!");
        }

    }
}
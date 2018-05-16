using System;

namespace Strategy
{
    internal class FakeQuack : IQuackBehavior
    {
        public void PerformQuack()
        {
            Console.WriteLine("Quak!");
        }
    }
}
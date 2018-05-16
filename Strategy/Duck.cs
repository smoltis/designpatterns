using System;

namespace Strategy
{
    public abstract class Duck
    {
        private IFlyBehavior _flyBehavior = new FlyWithWings(); //HAS-A relationship, composition, family of algorithms, implementation defined during runtime
        private IQuackBehavior _quackBehavior = new Quack(); //HAS-A relationship, composition, family of algorithms, implementation defined during runtime

        protected Duck()
        {
                
        }

        public abstract void Display(); //overriden in each SubClass

        public void Swim() //IS-A relationship, inheritance, implementation defined during compilation
        {
            Console.WriteLine("I can swim!");
        }

        public void Fly()
        {
            _flyBehavior.PerformFly();
        }

        public void Quack()
        {
            _quackBehavior.PerformQuack();
        }

        public void SetQuackBehavoir(IQuackBehavior qb)
        {
            _quackBehavior = qb;
        }

        public void SetFlyBehavoir(IFlyBehavior fb)
        {
            _flyBehavior = fb;
        }
    }
}
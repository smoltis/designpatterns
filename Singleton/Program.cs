using System;

namespace Singleton
{
    class Program
    {
        /*
         * The Singleton Pattern
         * 
         * ensures a class has only one instance, and provides a global access point to it.
         *
         */
        static void Main(string[] args)
        {
            //not thread-safe, lazy (deffered) instantionation
            var st1 = Singleton.getInstance();
            var st2 = Singleton.getInstance();
            Console.WriteLine(ReferenceEquals(st1, st2));

            //thread-safe static, instance will be created at start up, but we may not even need it
            var st1s = SingletonStat.getInstance();
            var st2s = SingletonStat.getInstance();
            Console.WriteLine(ReferenceEquals(st1s, st2s));

            //thread-safe using synchronization, extra overhead
            var st1sy = SingletonSynch.getInstance;
            var st2sy = SingletonSynch.getInstance;
            Console.WriteLine(ReferenceEquals(st1sy, st2sy));

            Console.ReadLine();
        }
    }
}

using System;
namespace Singleton
{
    public class SingletonStat
    {
        private static SingletonStat uniqueInstance = new SingletonStat(); //thread-safe, created before any threads get access to it

        protected SingletonStat()
        {
        }

        public static SingletonStat getInstance()
        {
            return uniqueInstance;
        }
    }
}

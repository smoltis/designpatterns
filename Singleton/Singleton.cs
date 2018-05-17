using System;
namespace Singleton
{
    public class Singleton
    {
        private static Singleton uniqueInstance;

        protected Singleton()
        {
        }

        public static Singleton getInstance()
        {
            if (uniqueInstance == null) //not thread-safe
            {
                uniqueInstance = new Singleton();
            }
            return uniqueInstance;
        }
    }
}

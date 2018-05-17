using System;
using System.Threading;

namespace Singleton
{
    public class SingletonSynch
    {
        private static SingletonSynch uniqueInstance;
        private static object syncRoot = new Object();

        protected SingletonSynch()
        {
        }

        public static SingletonSynch getInstance //extra cost of synchronization on every call
        {
            get
            {
                Thread.Sleep(500);
                if (uniqueInstance == null)
                {
                    lock (syncRoot)
                    {
                        if (uniqueInstance == null)
                        {
                            uniqueInstance = new SingletonSynch();
                        }
                    }

                }
                return uniqueInstance;
            }
        }
    }
}

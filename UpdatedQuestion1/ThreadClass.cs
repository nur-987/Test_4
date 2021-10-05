using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UpdatedQuestion1
{
    class ThreadClass
    {
        public static List<Thread> threadList = new List<Thread>();

        public void longActivity()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("im still working");
                Thread.Sleep(3000);
            }
        }
        public void CreateThread()
        {
            Thread td1 = new Thread(new ThreadStart(longActivity));
            threadList.Add(td1);
            td1.Start();
            Console.WriteLine("Created thread with id: " + td1.ManagedThreadId);

        }

        public void GetCount()
        {
            int count = 0;
           foreach(Thread item in threadList)
            {
                Console.WriteLine("Thread ID: " + item.ManagedThreadId);
                count++;
                Console.WriteLine("Total num of threads: " + count);
            }
        }

        public void ThreadSleep()
        {
            Console.WriteLine("Threads available: ");
            foreach (Thread item in threadList)
            {
                Console.WriteLine("Thread ID: " + item.ManagedThreadId);
            }
            Console.WriteLine("Choose a thread to sleep");
            int threadId = Int32.Parse(Console.ReadLine());

            Console.WriteLine("input in miliseconds how long to sleep");
            int time = Int32.Parse(Console.ReadLine());

            foreach (Thread item in threadList)
            {
                if(item.ManagedThreadId == threadId)
                {
                    //make the selected thread sleep
                    item.Sleep(time);

                    Console.WriteLine("Thread put to sleep");
                }
            }
        }

        public void RunSync()
        {
            Console.WriteLine("Threads available: ");
            Console.WriteLine("Threads available: ");
            foreach (Thread item in threadList)
            {
                Console.WriteLine("Thread ID: " + item.ManagedThreadId);
            }

            Console.WriteLine("Choose a thread to sleep");
            int threadId = Int32.Parse(Console.ReadLine());
            foreach (Thread item in threadList)
            {
                if(item.ManagedThreadId == threadId)
                {
                    item.Join();
                    Console.WriteLine("Thread join. Running in sync");
                }
            }


        }
        public void Destroy()
        {
            Console.WriteLine("Threads available: ");
            Console.WriteLine("Threads available: ");
            foreach (Thread item in threadList)
            {
                Console.WriteLine("Thread ID: " + item.ManagedThreadId);
            }

            Console.WriteLine("Choose a thread to destroy");
            int threadId = Int32.Parse(Console.ReadLine());
            foreach (Thread item in threadList)
            {
                if (item.ManagedThreadId == threadId)
                {
                    item.Abort();
                    Console.WriteLine("Thread destroyed.");
                }
            }
        }
    }

}

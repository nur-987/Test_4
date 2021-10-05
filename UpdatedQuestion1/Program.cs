using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UpdatedQuestion1
{
    class Program
    {
        public static List<Thread> threadList = new List<Thread>();
        
        static void Main(string[] args)
        {
            ThreadClass tClass = new ThreadClass();
            bool b = true;
            while (b)
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1) create thread      2)Destroy thread   3)See all threads");
                Console.WriteLine("4) make a thread run sync     5)Thread sleep");

                int input = Int32.Parse(Console.ReadLine());

                if (input == 1)
                {
                    //create thread
                    tClass.CreateThread();
                }
                else if (input == 2)
                {
                    //destroy
                    Console.WriteLine("input in ID of thread you would like to destroy");
                    int TempId = Int32.Parse(Console.ReadLine());
                    
                }
                else if (input == 3)
                {
                    //Display all threads
                    tClass.GetCount();
                }
                else if (input == 4)
                {
                    //make a thread run sync
                    tClass.RunSync();
                }
                else if (input == 5)
                {
                    //sleep
                    tClass.ThreadSleep();

                }
                else
                {
                    Console.WriteLine("ending program");
                    b = false;

                }
            }

            Console.ReadLine();
        }
    }
}

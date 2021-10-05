using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();

            bool b = true;
            while (b)
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1) create thread      2)Destroy thread   3)See all threads");
                Console.WriteLine("4) make a thread run sync     5)Thread sleep");

                int input = Int32.Parse(Console.ReadLine());

                if (input == 1)
                {
                    myClass.Create();
                }
                else if (input == 2)
                {
                    Console.WriteLine("input in ID of thread you would like to destroy");
                    int TempId = Int32.Parse(Console.ReadLine());
                    myClass.Destroy(TempId);
                }
                else if (input == 3)
                {
                    myClass.DisplayAll();
                }
                else if (input == 4)
                {

                }
                else if (input == 5)
                {
                    Console.WriteLine("input in miliseconds how long to sleep");
                    int time = Int32.Parse(Console.ReadLine());
                    myClass.Sleep(time);
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

    class MyClass
    {
        Thread td = new Thread();
        
        public void Create()
        {
            Thread td1 = new Thread(() => { Console.WriteLine("new thread created"); });
            td1.Start();
        }

        public void Destroy(int id)
        {
            td.Abort();
        }

        public void DisplayAll()
        {

        }

        public void RunSync()
        {

        }

        public void Sleep(int time)
        {
            td.Sleep(time);
        }

    }
}

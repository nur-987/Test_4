using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Question4
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator myCal = new Calculator();
            Console.WriteLine("Please input 2 numbers to do all operation on");
            Console.WriteLine("FirstNumber: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Second Number: ");
            int b = Int32.Parse(Console.ReadLine());

            myCal.num1 = a;
            myCal.num2 = b;

            try
            {
                myCal.InitialiseThread();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error! Exception Occured");
                Console.WriteLine($"{ex.Message}");
            }


            Console.ReadLine();

        }
    }
    
    class Calculator
    {
        public int num1 { get; set; }
        public int num2 { get; set; }

        public void InitialiseThread()
        {
            Thread td1 = new Thread(Add);

            try
            {
                td1.Start();
            }
            catch(Exception)
            {
                throw new Exception();
            }


            Thread td2 = new Thread(Div);
            try
            {
                td2.Start();
            }
            catch (Exception)
            {
                throw new Exception();
            }

            Thread td3 = new Thread(Remainder);
            try
            {
                td3.Start();
            }
            catch (Exception)
            {
                throw new Exception();
            }

            Thread td4 = new Thread(Mult);
            try
            {
                td4.Start();
            }
            catch (Exception)
            {
                throw new Exception();
            }

            Thread td5 = new Thread(Sub);
            try
            {
                td5.Start();
            }
            catch (Exception)
            {
                throw new Exception();
            }

            Thread td6 = new Thread(Power);
            try
            {
                td6.Start();
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        public void Add()
        {

            int x = num1 + num2;
            Console.WriteLine("Add answer is: " + x);
        }

        public void Div()
        {
            int x = num1 / num2;
            Console.WriteLine("Divide answer is: " + x);
        }

        public void Remainder()
        {
            int x = num1 % num2;
            Console.WriteLine("Remainder answer is: " + x);
        }

        public void Mult()
        {
            int x = num1 * num2;
            Console.WriteLine("Multiply answer is: " + x);
        }

        public void Sub()
        {
            int x = num1 - num2;
            Console.WriteLine("Subtract answer is: " + x);
        }

        public void Power()
        {
            int x = num1 ^ num2;
            Console.WriteLine("Power answer is: " + x);
        }
    }
}

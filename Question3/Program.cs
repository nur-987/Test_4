using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            myClass<int> myClassint = new myClass<int>();
            myClassint.Validate(1);
            myClassint.Inspect(3, 2);

            myClass<string> myClassStr = new myClass<string>();
            myClassStr.Validate("happy");
            myClassStr.Inspect("happy", "smile");

            myClass<double> myDbl = new myClass<double>();
            myDbl.Validate(0.9);
            myDbl.Inspect(0.3, 0.7);

            Console.ReadLine();

        }
    }

    public interface ImyInterface<T>
    {
        bool Validate(T a);

        T Inspect(T b, T c);

    }
    public class myClass<T> : ImyInterface<T>
    {
        public T Inspect(T b, T c)
        {
            throw new NotImplementedException();
        }

        public bool Validate(T a)
        {
            throw new NotImplementedException();
        }
    }
}

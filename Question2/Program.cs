using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    class Program
    {
        
        static void Main(string[] args)
        {

            #region Original answers
            //Add<int>();
            //Add<string>();
            //myList<int> mylist = new myList<int>();
            //mylist.Add();
            //MyClass<string> myclass = new MyClass<string>();
            //myclass.Add();
#endregion

        }

    }

    #region  Original answer
    //static void Add<T>()
    //{

    //}
    //public class myList<T>
    //{
    //    List<T> newList = new List<T>();
    //    public void Add()
    //    {
    //        newList.Add();
    //    }
    //}
    //public class MyClass<T>
    //{
    //    public T var1 { get; set; }
    //    public T var2 { get; set; }

    //    public void Add()
    //    {

    //    }
    //}
    #endregion

    public interface MyInterface<T>
    {
        T add(T a, T b);
    }
    public class IntClass : MyInterface<int>
    {
        public int add(int a, int b)
        {
            return a + b;
        }
    }
    public class StrClass : MyInterface<string>
    {
        public string add(string a, string b)
        {
            return a + b;
        }
    }

    public class ListClass : MyInterface<List<int>>
    {
        public List<int> add(List<int> a, List<int> b)
        {
            var newList = new List<int>();
            newList.AddRange(a);
            newList.AddRange(b);

            return newList;
        }
    }
    public class myClassClass : MyInterface<MyClass>
    {
        public MyClass add(MyClass a, MyClass b)
        {
            var classVariable = new MyClass();
            classVariable.MyProperty.AddRange(a.MyProperty);
            classVariable.MyProperty.AddRange(b.MyProperty);

            return classVariable;
        }
    }

    public class MyClass
    {
        public List<int> MyProperty { get; set; }
    }

}

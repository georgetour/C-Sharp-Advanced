using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{

    public class Utilities<T> where T : IComparable, new()
    {
        public int Max(int a ,int b)
        {
            //If a bigger than b return a else b
            return a > b ?a: b;
        }

        public void DoSomething(Task value)
        {
            //Doesn't work because the compiler doesn't know what T is
            //var obj = new T();
        }

        //Same example with above but we use generics
        public T Max(T a, T b) 
        {
            //We have an error since the compiler doesn't know about a and b. They are both objects
            //return a > b ? a : b;

            return a.CompareTo(b) > 0 ? a : b;
        }

    }
}

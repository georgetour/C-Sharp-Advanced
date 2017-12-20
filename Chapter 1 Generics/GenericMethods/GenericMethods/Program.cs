using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //We can pass different types in our Utility.CompareValue method 
            Console.WriteLine(Utility.CompareValue("hello",10));

            //Compare two types
            Console.WriteLine(Utility.CompareType("hello","world"));
        }
    }


    //Host generic methods
    public class Utility
    {
        //We can compare same or different data types values
        public static bool CompareValue<TypeOne,TypeTwo>(TypeOne value1, TypeTwo value2)
        {
            return value1.Equals(value2);
        }

        public static bool CompareType<TypeOne, TypeTwo>(TypeOne type1, TypeTwo type2)
       {
            return typeof(TypeOne).Equals(typeof(TypeTwo));

       }

    }
}

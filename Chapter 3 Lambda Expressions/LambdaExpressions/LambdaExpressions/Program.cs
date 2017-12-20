using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    class Program
    {
        

        static void Main(string[] args)
        {
            //First parameter represents the argument second the return value
            //Instead of creating the method Square we can use a lambda expression
            Func<int, int> square = number => number * number;
            Console.WriteLine(square(5));


            //Example of scope
            const int factor = 5;

            //THe lambda expression perfectly understands factor 
            Func<int, int> multiplier = n => n * factor;
            var result = multiplier(10); //result is 50

            Console.WriteLine(result);

        }

        static int Square(int number)
        {
            return number * number;
        }
    }
}

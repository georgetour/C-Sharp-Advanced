using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_Simple_Example
{

    //Checking if what we passed is true
    delegate bool MeDelegate(int number);

    class Program
    {

        static bool LessThanFive(int number) { return number < 5; }
        static bool LessThanTen(int number) { return number < 10; }
        static bool LessThanTwenty(int number) { return number < 20; }
        static bool HigherThanFive(int number) { return number > 5; }


        static void Main(string[] args)
        {
            int[] numbers = new[] { 2, 1, 5, 3, 9, 6, 243 };

            //Get all numbers less than 5 in console
            IEnumerable<int> result = RunNumbersThroughGauntlet(numbers,LessThanFive);
            foreach (var number in result)
                Console.WriteLine(number);
        }


        //Let's say we have a method that will return all numbers < 10
        static IEnumerable<int> GetAllNumbersLessThanTen(IEnumerable<int> numbers)
        {
            foreach (var number in numbers)
                if (number < 10)
                    //When your method uses yield return, the compiler 
                    //actually changes the compiled code to return an IEnumerable<>
                    yield return number;
        }


        //************** WHAT IF WE WANTED TO FIND ALL NUMBERS LOWER THAN 5 ALSO************
        //WE WOULD HAVE TO COPY THE METHOD AND CHANGE IT



        //************** WHAT IF WE WANTED TO FIND ALL NUMBERS HIGHER THAN 20 ALSO************
        //SEE THIS IS BECOMING HARD TO MAINTAIN AND REPETITIVE


        //As you see MeDelagate can take any method that is bool and has one parameter
        static IEnumerable<int> RunNumbersThroughGauntlet(IEnumerable<int> numbers,MeDelegate gauntlet)
        {
            foreach (var number in numbers)
                //If gauntlet returns true yield number
                if (gauntlet(number))
                    //When your method uses yield return, the compiler 
                    //actually changes the compiled code to return an IEnumerable<>
                   yield  return number;
        }


        //********* USING THE .NET Func delegate without needing to create a custom one *******
        //When we have Func we must return something which in our case is a bool
        static IEnumerable<int> RunNumbersThroughGauntlet2(IEnumerable<int> numbers, Func<int, bool> gauntlet)
        {

            foreach (var number in numbers)
                if (gauntlet(number))
                    yield return number;
        }


        


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsV2
{
    class Program
    {
        static void Main(string[] args)
        {
            //We use one generic with different types so we don't have to create another class
            KeyValue<string, string> book = new KeyValue<string, string>("Ben hur","53453-5353-42");
            book.Print("Book Title", "ISBN");

            KeyValue<int, string> product = new KeyValue<int, string>(2, "G51");
            product.Print("Product ID", "Product");

            //Dictionary is list of keys and values
            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict.Add("one", 1);
            dict.Add("two", 2);
            dict.Add("three", 3);
            dict.Add("four", 4);

            //Ittirating a dictionary by using KeyValuePair of the .NET
            foreach (KeyValuePair<string, int> pair in dict)
            {
                Console.WriteLine(pair.Key.ToString() + " - " + pair.Value.ToString());
            }



        }

    }



    // ************** By using generics in the example below we can easily reuse the class ******
    // ************** We can use the below class as we want since it's independent from types ******
    // ************** Maybe for a book that the key will be a string his ISBN and the value its title a string also ******
    // ************** But we can also use it for a product that will have an int which will be its ID and string the product ***

    public class KeyValue <TKey, TValue>
    {
        public TKey key { get; set; }
        public TValue value { get; set; }

        public KeyValue(TKey _key, TValue _value)
        {
            key = _key;
            value = _value;
        }

        //Print out key and value with headings we want as parameters like ID, ISBN etc
        public void Print(string data1, string data2)
        {
            Console.WriteLine("{0} : {1}", data1, key);
            Console.WriteLine("{0} : {1}", data2, value);
        }


    }
}

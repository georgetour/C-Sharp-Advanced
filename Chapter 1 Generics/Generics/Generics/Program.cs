using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {

        static void Main(string[] args)
        {
            var book = new Book {Isbn = "53434" , Title = "C#"};
            Console.WriteLine(book.Isbn);
            Console.WriteLine(book.Title);

            //The problem here is we have two different types of Lists
            //var number = new List();
            //number.Add(19);

            //var books= new Book();
            //books.Add(book);

            var numbers = new GenericList<int>();
            numbers.Add(100);

            var books = new GenericList<Book>();
            books.Add(book);

            //Use of Dictionary
            var dictionary = new GenericDictionary<string, Book>();
            dictionary.Add("432423", book);

            //If we have a value in our parameter we will get it else we get 0
            //Try to leave empty the parameter
            var number = new Nullable<int>(5);
            Console.WriteLine("Has value? " + number.HasValue);
            Console.WriteLine("Value:" + number.GetValueorDefault());
            


        }
    }
}

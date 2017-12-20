using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionsPractical
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            //Iterrating the collection and find books cheaper than 10
            var cheapBooks = books.FindAll(IsCheaperThan10Dollars);

            foreach (var cheapBook in cheapBooks)
            {
                Console.WriteLine("Book title :" + cheapBook.Title);
                Console.WriteLine("Book price :" + cheapBook.Price);
            }


            //Using a lambda expression that will do the same as IsCheaperThan10Dollars method
            var cheapBooksLamda = books.FindAll(book => book.Price < 10);

            foreach (var cheapBookLamda in cheapBooksLamda)
            {
                Console.WriteLine("Book title :" + cheapBookLamda.Title);
                Console.WriteLine("Book price :" + cheapBookLamda.Price);
            }
            

        }

        //Example of predicate function
        static bool IsCheaperThan10Dollars(Book book)
        {
            return book.Price < 10;
        }
    }
}

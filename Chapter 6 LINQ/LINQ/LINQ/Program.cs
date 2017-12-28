using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().Getbooks();

            foreach (var book in books)
            {
                Console.WriteLine("Book Title :" + book.Title);
                Console.WriteLine("Price :" + book.Price +"$");
            }

            //Display books less than 10$ without LINQ
            var cheapBooks = new List<Book>();
            foreach (var book in books)
            {
                if (book.Price < 10 )
                {
                    cheapBooks.Add(book);
                }
            }

            Console.WriteLine();
            Console.WriteLine("***BOOKS UNDER 10$***");

            foreach (var cheapBook in cheapBooks)
            {
                
                Console.WriteLine("Book Title :" + cheapBook.Title);
                Console.WriteLine("Price :" + cheapBook.Price + "$");
            }

            //With LINQ Extension Methods
            //Books under 10,Order By Price and show only Title
            var cheapBooksLINQ = books
                                    .Where(b => b.Price < 10)
                                    .OrderBy(b => b.Price)
                                    .Select(b => b.Title); 

            Console.WriteLine();
            Console.WriteLine("***BOOKS UNDER 10$ with LINQ***");

            foreach (var cheapBook in cheapBooksLINQ)
            {
                Console.WriteLine("Book Title :" + cheapBook);
                
            }

            //With LINQ Query Operators
            var cheaperBooksLINQ = from b in books
                                   where b.Price < 10
                                   orderby b.Price
                                   select b;

            Console.WriteLine();
            Console.WriteLine("***BOOKS UNDER 10$ with LINQ***");

            foreach (var cheaperBook in cheaperBooksLINQ)
            {
                Console.WriteLine("Book Title :" + cheaperBook.Title);
                Console.WriteLine("Price :" + cheaperBook.Price);
            }


        }
    }
}

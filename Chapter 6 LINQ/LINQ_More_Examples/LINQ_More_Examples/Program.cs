using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_More_Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().Getbooks();
            var singleTitle = books.SingleOrDefault(b => b.Title == "ASP.NET MVC Step by Step");

            if (singleTitle != null)
            {
                Console.WriteLine(singleTitle.Title);
                Console.WriteLine(singleTitle.Price);
            }
            else
                throw new InvalidOperationException("We have empty result from query");

            //Return firstResult
            var firstResult = books.First(b => b.Title == "C# Advanced Topics");
            Console.WriteLine(firstResult.Title);

            //Skip first two records and return total 2
            var pagedBooks = books.Skip(2).Take(2);

            foreach (var book in pagedBooks)
            {
                Console.WriteLine(book.Title);
                Console.WriteLine(book.Price);
            }

            //Return how many books
            var totalBooks = books.Count();
            Console.WriteLine("Total books :" + totalBooks);

            var highestPrice = books.Max(b => b.Price);
            Console.WriteLine("The highest price is " + highestPrice);

        }

    }
}

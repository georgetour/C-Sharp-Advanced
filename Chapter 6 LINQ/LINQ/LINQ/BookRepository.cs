using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class BookRepository
    {
        //Hardcoded books
        public IEnumerable<Book>Getbooks()
        {
            return new List<Book>
            {
                new Book() { Title = "ADO.NET Step by Step",Price = 5},
                new Book() { Title = "ASP.NET MVC Step by Step", Price = 9.99f},
                new Book() { Title = "ASP.NET Web API",Price = 12},
                new Book() { Title = "C# Advanced Topics",Price = 7}
            };
        }


    }
}

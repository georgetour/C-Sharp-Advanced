using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            string post = "This is supposed to be a very long text This is supposed to be a very long text This is supposed to be a very long text This is supposed to be a very long text This is supposed to be a very long textThis is supposed to be a very long text  ";
            var shortenedPost = post.Shorten(5);

            Console.WriteLine(shortenedPost);

        }
    }

   

    
}

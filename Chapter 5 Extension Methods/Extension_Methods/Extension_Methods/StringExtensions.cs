using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Methods
{
    public static class StringExtensions
    {
        //Shorten string according to number of  words
        public static string Shorten(this String str, int numberOfWords)
        {
            if (numberOfWords < 0)
                throw new ArgumentOutOfRangeException("Number of words should not be less than 0");

            if (numberOfWords == 0)
                return "";

            var words = str.Split(' ');

            if (words.Length <= numberOfWords)
            {
                return str;
            }
            return string.Join(" ", words.Take(numberOfWords));

        }

    }

}

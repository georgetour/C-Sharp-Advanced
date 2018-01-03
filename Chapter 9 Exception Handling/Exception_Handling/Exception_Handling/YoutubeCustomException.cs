using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    public class YoutubeCustomException : Exception
    {

        //With base keyword we can acccess methods and properties directly from the parent class
        public YoutubeCustomException(string message, Exception innerException)
            :base(message,innerException)
        {

        }
    }
}

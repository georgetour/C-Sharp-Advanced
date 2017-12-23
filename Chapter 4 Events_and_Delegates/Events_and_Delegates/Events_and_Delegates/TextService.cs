using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_and_Delegates
{
    //******** Class responsible for sending text when the video was encoded ********
    public class TextService
    {
        //The parameters are the same with the delegate
        public void OnVideoEncoded(object source, EventArgs e)
        {
            Console.WriteLine("Text message send");
        }
    }
}

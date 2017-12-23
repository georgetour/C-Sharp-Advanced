using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_and_Delegates
{

    //Additional data for our subscribers
    public class VideoEventArgs : EventArgs
    {
        //Video was encoded
        public Video Video { get; set; }
    }
}

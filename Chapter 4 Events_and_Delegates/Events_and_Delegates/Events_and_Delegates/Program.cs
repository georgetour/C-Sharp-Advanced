using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_and_Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video(){ Title = "Video 1"};
            var videoEncoder = new videoEncoder(); //publisher
            var mailService = new MailService(); //subscriber
            var textService = new TextService(); //another subscriber

            //Register the handler at the event(note that we don't make a call to OnVideoEncoded method so no brackets)
            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += textService.OnVideoEncoded;

            videoEncoder.Encode(video);

        }

        
    }

    
}

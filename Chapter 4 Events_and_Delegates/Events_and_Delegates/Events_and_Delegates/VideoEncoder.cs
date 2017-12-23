using System;
using System.Threading;

namespace Events_and_Delegates
{
    public class videoEncoder
    {
        //********** Steps for event ***********

        // 1. Define a delegate 
        // 2. Define an event
        // 3. Raise the event

        //public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);
        //public event VideoEncodedEventHandler VideoEncoded;

        //**** Using the .NET framework EventHandler is same as the two above lines****
        public event EventHandler<VideoEventArgs> VideoEncoded;



        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video...");
            Thread.Sleep(3000);

            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            //We start checking if they are any subscribers to the event
            if (VideoEncoded != null)
            {
                //The signature is what we defined
                //Who is the source of the event or who is publishing the event the first parameter
                //Second parameter additional data with the event
                VideoEncoded(this, new VideoEventArgs() { Video = video});
            }

        }
    }
}
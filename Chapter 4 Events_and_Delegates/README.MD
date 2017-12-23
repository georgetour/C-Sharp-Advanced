# Events

 - Events is a mechanism fro communication between objects
 - When something happens in an object it can notify others objects(in C# terms means invoking method to a subscriber)
 - Helps with Loosely Coupled Applications 
 - Easily extend the application without breaking anything that's already works

# Delegates

 - A delegate is an Agreement/Constract between Publisher and Subscriber 
 - It determines the signature of the event handler method in the subscriber
 
1. How to implement an event

 - **First we define a delegate**
 It's the contract between the publisher and the subscriber.The delegate will determine the 
 ** signature ** of the method and the subscriber that will be called when the publisher publishes an event.
 
  //We want the first parameter to be an object which is the source of the event or the class 
  //that is publishing or sending the event
  //The second parameter is an EventArgs which is any additional data we want to send to the event 
  public delegate void VideoEncodedEventHandler(object source, EventArgs args);
  
  - **Second we define an event** 
  It's based on the delegate we created.
  
  public event VideoEncodedEventHandler VideoEncoded;
  
  - **Third we raise the event** 
  
		//Note the On for convention
		protected virtual void OnVideoEncoded()
        {
            //We start checking if they are any subscribers to the event
            if (VideoEncoded != null)
            {
                //The signature is what we defined
                //Who is the source of the event or who is publishing the event the first parameter
                //Second parameter additional data with the event
                VideoEncoded(this, EventArgs.Empty);
            }

        }
		
2. Finally we have to do the subscription
 class Program
    {
        static void Main(string[] args)
        {
            var video = new Video(){ Title = "Video 1"};
            var videoEncoder = new VideoEncoder(); //publisher
            var mailService = new MailService(); //subscriber

            //Register the handler at the event(note that we don't make a call to OnVideoEncoded method so no brackets)
            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;

            videoEncoder.Encode(video);

        }

    }
	
So we have a publisher that has the event and we add subscribers to the event.
As you will see in the project we have loosely coupling since we didn't have to change anything to VideoEncoder.
Check Events_and_Delegates project.

**We don't want every time to create a new/custom delegate every time we create an event since .NET has**

 - EventHandler
 - EventHandler<TEventArgs>
 
	So instead of saying 
		public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);
		public event VideoEncodedEventHandler VideoEncoded;
		
	We write
	public event EventHandler<VideoEventArgs> VideoEncoded;
	
If we don't want any additional data 

        public event EventHandler VideoEncoded;
  



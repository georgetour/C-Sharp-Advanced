using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{

    public class YouTubeAPI
    {
        //List of videos according to user 
        public List<Video> GetVideos(string user)
        {
            try
            {
                //Access Youtube Web Service
                //Read the data
                //Create a list of Video objects

                throw new Exception("Manually simulation");
            }
            catch (Exception ex)
            {
                //Throwing custom exception we created
                throw new YoutubeCustomException("Problem with youtube network connection", ex);
            }
            return new List<Video>();
        }

    }
}

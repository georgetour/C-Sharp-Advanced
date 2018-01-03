using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            //Example of try and catch
            try
            {
                Calculator calculator = new Calculator();
                var result = calculator.Divide(6, 0);
            }
            //****multiple catch blocks****

            //This exception will executed first since it's the most specific
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("You cannot divide by zero");
            }
            catch (Exception ex)
            {

                Console.WriteLine("Sorry an error occured");
            }
            
            
            
            //********Non managed resources example*******
            StreamReader streamReader = null;

            try
            {
                streamReader = new StreamReader("@e:/lorem_ipsum.txt");
                var content = streamReader.ReadToEnd();
            }
            catch (Exception)
            {
                Console.WriteLine("Sorry an error occured");
            }
            //If something goes wrong close the streaming
            finally
            {
                if(streamReader != null)
                streamReader.Dispose();
            }


            //This automatically disposes the unmanaged resource and it s the same as the above
            try
            {
                using (var streamReader2 = new StreamReader("@e:/lorem_ipsum.txt"))
                {
                    var content = streamReader2.ReadToEnd();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Sorry an error occured");
            }



            //***** Youtube  error simulation ******

            try
            {
                var api = new YouTubeAPI();
                var videos = api.GetVideos("george");
            }
            catch (Exception ex)
            {
                //Here we get the message from our custom exception
                Console.WriteLine(ex.Message);
            }

           

        }
    }
}

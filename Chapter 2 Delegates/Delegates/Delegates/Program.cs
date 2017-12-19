using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {

            var photoProcessor = new PhotoProcessor();
            var filters = new PhotoFilters();

            //Calling the custom delegate
            //PhotoProcessor.PhotoFilterHandler filter = filters.ApplyBrightness;

            //Using the .NET  Action delegate that takes Photo as parameter
            Action<Photo> filter = filters.ApplyBrightness;

            //Use another filter
            filter += filters.ApplyContrast;

            //Easily applying the new filter we created
            filter += RemoveRedEyeFilter;

            photoProcessor.Process("photo.jpg", filter); 

        }

        static void RemoveRedEyeFilter(Photo photo)
        {
            Console.WriteLine("Removed red eye");
        }

    }
}

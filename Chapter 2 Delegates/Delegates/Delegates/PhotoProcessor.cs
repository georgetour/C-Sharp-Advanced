using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class PhotoProcessor
    {
        //Custom delegate
        //public delegate void PhotoFilterHandler(Photo photo);

        //This code doesn't know what filter will be applied
        public void Process(string path, Action<Photo> filterHandler)
        {

            var photo = Photo.Load(path);

            filterHandler(photo);

            photo.Save();


        }




    }
}

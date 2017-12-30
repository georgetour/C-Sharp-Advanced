using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            //We can't give null a Datetime
            //DateTime date = null;

            //To solve this we write
            Nullable<DateTime> date = null;

            //Shorter version
            DateTime? birthday = null;

            Console.WriteLine(date.GetValueOrDefault());
            Console.WriteLine(date.HasValue);
            //Console.WriteLine(date.Value);

            DateTime? date2 = date;
            if (date != null)
                date2 = date.GetValueOrDefault();
            else
                date2 = DateTime.Today;

            //**** Null Coalescing Operator ****
            DateTime date3 = date ?? DateTime.Today; //if date has a value give it to date3 else date3 = Datetime.Today
            Console.WriteLine(date3);

        }
    }
}

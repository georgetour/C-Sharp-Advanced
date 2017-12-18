using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    //This Nullable class is using a constraint to specify that T has to be a value type
    public class Nullable<T> where T : struct
    {
        private object _value;

        public Nullable()
        {

        }

        public Nullable(T value)
        {
            _value = value;
        }

        //Checking if we have value
        public bool HasValue
        {
            get { return _value != null; }
        }

        //If we have value return it else return default
        public T GetValueorDefault()
        {
            if (HasValue)
                return (T)_value;

            return default(T);
            
        }
    }
}

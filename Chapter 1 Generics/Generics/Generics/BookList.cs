using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class BookList
    {
    }

    public class GenericDictionary<Tkey, Tvalue>
    {
        public void Add(Tkey tkey, Tvalue tvalue)
        {

        }
    }
    
    
    //This is how we declare a Generic
    public class GenericList<T>
    {
        public void Add(T value)
        {

        }

        public T this [int index]
        {
            get { throw new NotImplementedException(); }
        } 
    }

}

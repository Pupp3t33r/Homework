using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2.MyCollection
{
    public class MyTRClass<T,R> where T:struct 
                                where R:class, IsetMyString, new()
    {
        public T item;

        public R SetR(T item)
        {
            R result = new();
            result.SetMyStringValue(item.ToString());
            return result;
        }
    }
}

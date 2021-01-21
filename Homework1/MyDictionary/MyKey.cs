using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.MyDictionary
{
    public class MyKey : IKey, IComparable<IKey>
    {
        public MyKey(string name, int runtime)
        {
            Name = name;
            Runtime = runtime;
        }

        public string Name { get; set; }
        public int Runtime { get; set; }

        public override string ToString()
        {
            return $"{Name}({Runtime}m)";
        }

        public int CompareTo(IKey other)
        {
            if (this.Runtime<other.Runtime)
            {
                return 1;
            }
            else if (this.Runtime>other.Runtime)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}

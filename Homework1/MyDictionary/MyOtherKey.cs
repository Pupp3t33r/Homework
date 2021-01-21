using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework1.MyDictionary
{
    public class MyOtherKey : IKey, IEquatable<IKey>
    {
        public string Name { get; set; }
        public int Runtime { get; set; }

        public override string ToString()
        {
            return $"{Name}";
        }

        public bool Equals(IKey other)
        {
            if (Name == other.Name)
            {
                return true;
            }
            else return false;
        }
    }
}

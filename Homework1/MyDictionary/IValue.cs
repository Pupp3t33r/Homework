using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.MyDictionary
{
    public interface IValue : IComparable<IValue>
    {
        public int Year { get; set; }
        public DateTime ExactReleaseDate { get; set; }
    }
}

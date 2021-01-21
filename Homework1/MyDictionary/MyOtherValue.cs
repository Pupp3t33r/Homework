using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.MyDictionary
{
    public class MyOtherValue : IValue
    {
        public MyOtherValue(DateTime releaseDate)
        {
            ExactReleaseDate = releaseDate;
            Year = ExactReleaseDate.Year;
        }

        public int Year { get; set; }
        public DateTime ExactReleaseDate { get; set; }

        public override string ToString()
        {
            return ExactReleaseDate.ToShortDateString();
        }

        public int CompareTo(IValue other)
        {
            if (this.ExactReleaseDate < other.ExactReleaseDate)
            {
                return -1;
            }
            else if (this.ExactReleaseDate > other.ExactReleaseDate)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.MyDictionary
{
    public class MyValue : IValue
    {

        public MyValue(int year)
        {
            Year = year;
            _exactReleaseDate = new DateTime(Year, 1,1);
        }
        public int Year { get; set; }

        private DateTime _exactReleaseDate;

        public DateTime ExactReleaseDate
        {
            get => _exactReleaseDate.Date;
            set { return; }
        }

        public override string ToString()
        {
            return Year.ToString();
        }

        public int CompareTo(IValue other)
        {
            if (this.Year < other.Year)
            {
                return -1;
            }
            else if (this.Year > other.Year)
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

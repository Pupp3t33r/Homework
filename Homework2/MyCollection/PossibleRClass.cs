using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2.MyCollection
{
    public class PossibleRClass : IsetMyString
    {
        private string _strVal;

        public void SetMyStringValue(string text)
        {
            _strVal = text;
        }

        public override string ToString()
        {
            return _strVal;
        }
    }
}

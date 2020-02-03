using System;
using System.Collections.Generic;
using System.Text;

namespace VideoExpertSystem
{
    interface IIterator : IEnumerable<object>

    {
        public bool HasNext();
        public object Next();
    }
}

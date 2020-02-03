using System;
using System.Collections.Generic;
using System.Text;

namespace VideoExpertSystem
{
    interface IIterator : IEnumerable<object>

    {
        bool HasNext();
        object Next();
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace VideoExpertSystem
{
    abstract class Value
    {
        public abstract List<string> GetInputPattern();

        public abstract bool GetSelectionType();
    }
}

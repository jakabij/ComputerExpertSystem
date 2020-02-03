using System;
using System.Collections.Generic;
using System.Text;

namespace VideoExpertSystem
{
    abstract class Value
    {
        public abstract List<String> GetInpitPattern();

        public abstract bool GetSelectionType();
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace VideoExpertSystem
{
    class FactRepository
    {
        private Dictionary<string,Fact> _factdict = new Dictionary<string, Fact>();

        public Dictionary<string,Fact> MyProperty
        {
            get { return _factdict; }
            set { _factdict = value; }
        }

        public void AddFact(Fact fact)
        {
            FactRepo.Add(fact);
        }
        public FactIterator GetIterator()
        {
            FactIterator f = new FactIterator();
            return f;
        }
    }
}

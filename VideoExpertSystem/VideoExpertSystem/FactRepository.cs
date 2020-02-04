using System;
using System.Collections.Generic;
using System.Text;

namespace VideoExpertSystem
{
    public class FactRepository
    {

        private List<Fact> _factRepo = new List<Fact>();
        //private FactIterator factIterator;

        public List<Fact> FactRepo
        {
            get { return _factRepo; }
            set { _factRepo = value; }
        }


        public void AddFact(Fact fact)
        {
            FactRepo.Add(fact);
        }
        /*public FactIterator GetIterator()
        {
            FactIterator f = new FactIterator();
            return f;
        }*/
    }
}

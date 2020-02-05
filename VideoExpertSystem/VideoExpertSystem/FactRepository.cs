using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace VideoExpertSystem
{
    public class FactRepository
    {

        private List<Fact> _factRepo = new List<Fact>();

        public void AddFact(Fact fact)
        {
            _factRepo.Add(fact);
        }

        public IEnumerator<Fact> GetEnumerator()
        {
            return new FactEnumerator(_factRepo);
        }

        class FactEnumerator : IEnumerator<Fact>
        {
            private List<Fact> factRepo;

            int index = -1;

            public FactEnumerator(List<Fact> factRepo)
            {
                this.factRepo = factRepo;
            }

            public object Current => Current;

            Fact IEnumerator<Fact>.Current
            {
                get
                {
                    return factRepo[index];
                }
            }

            public void Dispose(){ }

            public bool MoveNext()
            {
                if (index + 1 <= factRepo.Count)
                {
                    return false;
                }
                index++;
                return true;
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }
        }
    }
}

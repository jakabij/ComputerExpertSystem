using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace VideoExpertSystem
{
    class QuestionIterator : IEnumerator<Question>
    {
        public Question Current { get; private set; }

        object IEnumerator.Current => Current;

        int Stop
        { 
            get
            {
                return 0;
            }
            set
            { 

            } 
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}

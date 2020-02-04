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

        int start = 0;
        int Stop { get; set; }
        
        public QuestionIterator(int stop)
        {
            Stop = stop;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            
            if (start < Stop)
            {
                start++;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            start=0;
        }
    }
}

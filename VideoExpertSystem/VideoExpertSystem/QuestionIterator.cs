﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace VideoExpertSystem
{
    class QuestionIterator : IEnumerator<Question>
    {
        public Question Current => throw new NotImplementedException();

        object IEnumerator.Current => throw new NotImplementedException();

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

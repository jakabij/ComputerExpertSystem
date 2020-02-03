using System;
using System.Collections.Generic;
using System.Text;

namespace VideoExpertSystem
{
    class Answer
    {
        Value value;

        public bool EvaluateAnswerByInput(string input)
        {
            if (input.ToLower().Equals("yes"))
                return true;

            else if (input.ToLower().Equals("no"))
                return false;

            else
                throw new Exception("Wrong input!");
        }

        public void AddValue(Value value)
        {
            this.value = value;
        }
    }
}

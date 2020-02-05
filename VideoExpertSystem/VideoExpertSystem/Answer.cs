using System;
using System.Collections.Generic;
using System.Text;

namespace VideoExpertSystem
{
    public class Answer
    {
        public Value value;
        public Dictionary<bool, List<string>> valueDictionary;

        public Answer()
        {
            this.valueDictionary = new Dictionary<bool, List<string>>();
        }

        public bool EvaluateAnswerByInput(string input)
        {
            if (input in this.valueDictionary[true])
            {
                return true;
            }


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

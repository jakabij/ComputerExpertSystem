using System;
using System.Collections.Generic;
using System.Text;

namespace VideoExpertSystem
{
    class RuleRepository
    {
        Question question;

        public void AddQuestion(Question question)
        {
            this.question = question;
        }

        public QuestionIterator GetIterator()
        {
            return null;
        }
    }
}

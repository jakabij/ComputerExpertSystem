using System;
using System.Collections.Generic;
using System.Text;

namespace VideoExpertSystem
{
    public class RuleRepository
    {
        Question question;
        QuestionIterator questionIterator;

        public int Stop { get; set; }   ///////////////////////////////////////////not the best way
        public RuleRepository(int stop)
        {
            Stop = stop;
        }

        public void AddQuestion(Question question)
        {
            this.question = question;
        }

        public QuestionIterator GetIterator()
        {
            return new QuestionIterator(this.Stop);
        }
    }
}

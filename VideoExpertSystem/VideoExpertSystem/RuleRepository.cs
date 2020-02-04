using System;
using System.Collections.Generic;
using System.Text;

namespace VideoExpertSystem
{
    public class RuleRepository
    {
        List<Question> questionList = new List<Question>();


        public void AddQuestion(Question question)
        {
            this.questionList.Add(question);
        }

        /*
               public int Stop { get; set; }   ///////////////////////////////////////////not the best way
               public RuleRepository(int stop)
               {
                   Stop = stop;
               }

              

              public QuestionIterator GetIterator()
               {
                   return null;
               }*/
    }
}

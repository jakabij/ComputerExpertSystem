using System;
using System.Collections.Generic;
using System.Text;

namespace VideoExpertSystem
{
    class Question
    {
        string Id { get; set; }
        string TheQuestion { get; set; }
        Answer answer;

        public Question(string id, string theQuestion,Answer answer)
        {
            Id = id;
            TheQuestion = theQuestion;
            this.answer = answer;
        }

        public string GetId()
        {
            return Id;
        }

        public string GetQuestion()
        {
            return TheQuestion;
        }

        public Answer GetAnswer()
        {
            return this.answer;
        }

        public bool EvaluateAnswerByInput(string input)
        {
            return answer.EvaluateAnswerByInput(input);
        }
    }
}

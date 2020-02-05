using System;
using System.Collections.Generic;
using System.Text;

namespace VideoExpertSystem
{
    public class ESProvider
    {
        private FactParser _factParser;
        private RuleParser _ruleParser;
        private Dictionary<string, bool> answers;

        public Dictionary<string, bool> Answers
        {
            get { return answers; }
            set { answers = value; }
        }

        public ESProvider(FactParser factParser, RuleParser ruleParser)
        {
            _factParser = factParser;
            _ruleParser = ruleParser;
            answers = new Dictionary<string, bool>();
        }
        public void CollectAnswers()
        {
            foreach (var question in _ruleParser.GetRuleRepository().QuestionList)
            {
                Answers.Add(question.Id, GetAnswerByQuestion(question.Id));
            }
        }
        public bool GetAnswerByQuestion(string questionId)
        {
            foreach (var question in _ruleParser.GetRuleRepository().QuestionList)
            {
                if (question.Id.Equals(questionId))
                {
                    Console.WriteLine(question.TheQuestion);
                    var userAnswer = Console.ReadLine();
                    return question.EvaluateAnswerByInput(userAnswer);
                }
            }
            throw new Exception("Invalid input");
        }

        public string Evaluate()
        {
            return null;
        }
    }
}

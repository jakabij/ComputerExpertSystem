using System;
using System.Collections.Generic;
using System.Text;

namespace VideoExpertSystem
{
    public class ESProvider
    {
        private FactParser _factParser;
        private RuleParser _ruleParser;
        private List<Value> answers;

        public List<Value> Answers
        {
            get { return answers; }
            set { answers = value; }
        }

        public ESProvider(FactParser factParser, RuleParser ruleParser)
        {
            _factParser = factParser;
            _ruleParser = ruleParser;
            answers = new List<Value>();
            CollectAnswers();
            Evaluate();
        }
        public void CollectAnswers()
        {
            foreach (var question in _ruleParser.GetRuleRepository().QuestionList)
            {
                Answers.Add(new SingleValue(question.Id, GetAnswerByQuestion(question.Id)));

                // Multiple value missing
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
            var fr = _factParser.GetFactRepository().FactRepo;
            foreach (var item in fr)
            {
                foreach (var val in item.Value)
                {
                    if (val.Equals(answers))
                    {
                        Console.WriteLine("Iam searchin");
                        return item.Description;
                    }
                }
            }
            return null;
        }
    }
}

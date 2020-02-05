using System;

namespace VideoExpertSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            FactParser fact = new FactParser();

            
            foreach(var item in fact.GetFactRepository().FactRepo)
            {
                Console.WriteLine(item.Description);
            }
      */


            RuleParser r = new RuleParser();

            foreach(var item in r.GetRuleRepository().QuestionList)
            {
                Console.WriteLine(item.TheQuestion);
                foreach(var a in item.answer.valueList)
                {
                    Console.WriteLine(a.GetSelectionType());
                    Console.WriteLine(a.GetInputPattern()[0]);
                }
            }
        }
    }
}

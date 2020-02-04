using System;

namespace VideoExpertSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            RuleParser p = new RuleParser();
            p.LoadXmlDocument("Rules.xml");
        }
    }
}

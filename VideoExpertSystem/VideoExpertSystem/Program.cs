using System;

namespace VideoExpertSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var es = new ESProvider(new FactParser(), new RuleParser());
        }
    }
}

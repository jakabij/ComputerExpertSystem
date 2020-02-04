using System;

namespace VideoExpertSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            FactParser fact = new FactParser();
            fact.LoadXmlDocument("Facts.xml");

            FactRepository f= fact.GetFactRepository();
            foreach(var item in f.FactRepo)
            {
                Console.WriteLine(item.Description);
            }
      
        }
    }
}

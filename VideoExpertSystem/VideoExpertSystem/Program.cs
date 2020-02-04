using System;

namespace VideoExpertSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            FactParser fact = new FactParser();

            
            foreach(var item in fact.GetFactRepository().FactRepo)
            {
                Console.WriteLine(item.Description);
            }
      
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Xml.Linq;

namespace VideoExpertSystem
{
    class FactParser : XMLParser
    {
        public string Description { get; set; }
        public string Id { get; set; }

        public List<Fact> FactRepo { get; set; }

        public void LoadXmlDocument(string xmlPath)
        {
            XElement element = XElement.Load(@"C:\Users\nevie\Desktop\OOPTW3\Facts.xml");
            for (int i = 0; i < element.Elements().Count(); i++)
            {
                XElement fact = element.Elements("Fact").ToList()[i];
                var evals = fact.Element("Evals").Elements("Eval").ToList();
                string id = fact.Attribute("id").Value;
                string description = fact.Element("Description").Attribute("value").Value;
                Fact f = new Fact(description, id);
                for (int j = 0; j < evals.Count; j++)
                {
                    f.SetFactValueById(evals[j].Value, Convert.ToBoolean(evals[j].Attribute("id").Value));
                }
            }
            string id = (String)element.Element("Fact").Attribute("id").Value;
            string description = (String)element.Element("Fact").Element("Description").Attribute("Value").Value;
            
            Console.WriteLine(id);
            Console.WriteLine(description);

            Fact factrep = new Fact()
        }
    }
}

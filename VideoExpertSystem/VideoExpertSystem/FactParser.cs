using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Xml.Linq;
using System.Xml;

namespace VideoExpertSystem
{
    public class FactParser 
    {
        public string Description { get; set; }
        public string Id { get; set; }
        public FactRepository factRepository=new FactRepository();
        
        public void LoadXmlDocument(string xmlPath)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(xmlPath);
            
            foreach (XmlNode node in xmlDocument.DocumentElement)
            {
                string id = node.Attributes["id"].Value;
                string desc = node.ChildNodes[0].Attributes["value"].Value;
                Fact fact = new Fact(desc, id);
                Console.WriteLine("Facthoz:     "+desc+": "+id);
                
                foreach (XmlNode item in node.ChildNodes[1])
                {
                    fact.SetFactValueById(item.Attributes["id"].Value, Convert.ToBoolean(item.InnerText));
                    fact.SetOfId.Add(item.Attributes["id"].Value);
                    Console.WriteLine("FactRepohoz:     " + item.Attributes["id"].Value+": "+ item.InnerText);
                }

                factRepository.AddFact(fact);
                
            }

        }   
        public FactRepository GetFactRepository()
        {
            return this.factRepository;
        }
    }
}

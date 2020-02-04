using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml.Serialization;

namespace VideoExpertSystem
{
    class RuleParser : XMLParser
    {
        List<RuleRepository> listOfQuestions;
        ESProvider provider = new ESProvider();

        public RuleRepository GetRuleRepository()
        {
            return new RuleRepository(listOfQuestions.Count);
        }

        public void LoadXmlDocument(string xmlPath)
        {
            XmlSerializer xml = new XmlSerializer(typeof(RuleRepository));
            using (FileStream fs = File.OpenRead(xmlPath))
            {
                this.listOfQuestions=(List<RuleRepository>)xml.Deserialize(fs);
            }
        }
    }
}

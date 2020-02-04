using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml.Serialization;

namespace VideoExpertSystem
{
    public class RuleParser : XMLParser
    {
        List<Question> listOfQuestions;
        ESProvider provider = new ESProvider();

        public RuleRepository GetRuleRepository()
        {
            return new RuleRepository(listOfQuestions.Count);
        }

        public void LoadXmlDocument(string xmlPath)
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<Question>));
            using (FileStream fs = File.OpenRead(xmlPath))
            {
                this.listOfQuestions=(List<Question>)xml.Deserialize(fs);
            }
        }
    }
}

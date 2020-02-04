using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.Xml;

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
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load("Rules.xml");
            foreach (XmlNode node in xmlDocument.DocumentElement)
            {




                //Console.WriteLine(node.ChildNodes[0].InnerText);
                //ChildNodes[1].ChildNodes[0].Attributes["value"].Value
            }
        }
    }
}

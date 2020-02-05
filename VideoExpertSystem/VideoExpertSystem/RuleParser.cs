using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using System.Linq;

namespace VideoExpertSystem
{
    public class RuleParser : XMLParser
    {

        public RuleRepository GetRuleRepository()
        {
            var factRepository = new FactRepository();
            var xmlDocument = base.LoadXmlDocument("Rules.xml");

            foreach (XmlNode node in xmlDocument.DocumentElement)
            {
                string input=null;
                var ans = new Answer();

                for(int count=0;count<node.ChildNodes[0].ChildNodes[1].ChildNodes.Count;count++)
                {
                    string rules = node.ChildNodes[0].ChildNodes[1].ChildNodes[count].ChildNodes[0].Attributes["value"].Value;
                    List<string> stringOfLists = rules.Split(",").ToList<string>();

                    ans.valueDictionary.Add(Convert.ToBoolean(
                        node.ChildNodes[0].ChildNodes[1].ChildNodes[count].Attributes["value"].Value), stringOfLists);
                }

                Question question = new Question(node.Attributes["id"].Value,node.ChildNodes[0].InnerText,ans);
                

                answer.EvaluateAnswerByInput
                question.EvaluateAnswerByInput(input);
                







                List<string> listOfSelection = new List<string>();
                listOfSelection.Add(node.ChildNodes[1].ChildNodes[0].ChildNodes[0].Attributes["value"].Value);
                listOfSelection.Add(node.ChildNodes[1].ChildNodes[1].ChildNodes[0].Attributes["value"].Value);

                dictionarytOfQuestions.Add(node.ChildNodes[0].InnerText, listOfSelection);
            }


            return new RuleRepository();
        }

        public void LoadXmlDocument(XmlDocument xmlDocument)
        {
            foreach (XmlNode node in xmlDocument.DocumentElement)
            {
                List<string> listOfSelection = new List<string>();
                listOfSelection.Add(node.ChildNodes[1].ChildNodes[0].ChildNodes[0].Attributes["value"].Value);
                listOfSelection.Add(node.ChildNodes[1].ChildNodes[1].ChildNodes[0].Attributes["value"].Value);

                dictionarytOfQuestions.Add(node.ChildNodes[0].InnerText, listOfSelection);
            }
        }
    }
}

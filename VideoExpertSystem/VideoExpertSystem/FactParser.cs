﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Xml.Linq;
using System.Xml;

namespace VideoExpertSystem
{
    class FactParser : XMLParser
    {
        public string Description { get; set; }
        public string Id { get; set; }
        public Dictionary<string, List<string>> dictionarytOfQuestions = new Dictionary<string, List<string>>();

        public void LoadXmlDocument(XmlDocument xmlDocument)
        {
            foreach (XmlNode node in xmlDocument.DocumentElement)
            {
                List<string> listOfSelection = new List<string>();
                listOfSelection.Add(node.ChildNodes[1].ChildNodes[0].InnerText);
                listOfSelection.Add(node.ChildNodes[1].ChildNodes[1].InnerText);
                listOfSelection.Add(node.ChildNodes[1].ChildNodes[2].InnerText);
                listOfSelection.Add(node.ChildNodes[1].ChildNodes[3].InnerText);

                dictionarytOfQuestions.Add(node.ChildNodes[0].Attributes["value"].Value, listOfSelection);
            }

            foreach (var item in dictionarytOfQuestions)
            {
                Console.WriteLine(item.Key + ": " + item.Value[0] + item.Value[1]);
            }





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
                    f.SetFactValueById((evals[j].Attribute("id").Value), Convert.ToBoolean(evals[j].Value));
                }
                _factRepo.Add(f);
            }
        }
        public FactRepository GetFactRepository()
        {
            return new FactRepository();
        }
    }
}

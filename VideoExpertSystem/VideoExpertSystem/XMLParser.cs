using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace VideoExpertSystem
{
    abstract class XMLParser
    {
        public XmlDocument LoadXmlDocument(string xmlPath)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(xmlPath);
            return xmlDocument;
        }
    }
}

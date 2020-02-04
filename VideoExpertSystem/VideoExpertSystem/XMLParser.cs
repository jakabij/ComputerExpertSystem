using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace VideoExpertSystem
{
    interface XMLParser
    {
        public XElement LoadXmlDocument(string xmlPath)
        {
            XElement element = XElement.Load(xmlPath);
            return element;
        }
    }
}

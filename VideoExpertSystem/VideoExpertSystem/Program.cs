using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace VideoExpertSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            List<Question> qList = new List<Question>();
            Question q1 = new Question("1","1",new Answer());
            qList.Add(q1);
            Question q2 = new Question("2", "1", new Answer());
            qList.Add(q2);
            Question q3 = new Question("3", "1", new Answer());
            qList.Add(q3);
            Question q4 = new Question("4", "1", new Answer());
            qList.Add(q4);


            XmlSerializer xml = new XmlSerializer(typeof(List<Question>));

            using(StreamWriter sw=new StreamWriter("asd.xml"))
            {
                xml.Serialize(sw, qList);
            }

            */




        
            List<Question> list;
            XmlSerializer xml = new XmlSerializer(typeof(List<Question>));
            using (FileStream fs = File.OpenRead("Rules2.xml"))
            {
                list = (List<Question>)xml.Deserialize(fs);
                //this.listOfQuestions = (List<Question>)xml.Deserialize(fs);
            }


            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i].TheQuestion+ list[i].Id);
            }
         
        }
    }
}

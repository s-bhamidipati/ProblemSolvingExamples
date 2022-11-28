using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ProblemSolvingExamples
{
    internal class JsonSerialization
    {
        public static void Main(string[] args)
        {

            string xml = @"
                        <Invoice>
                            <Timestamp>1/1/2017 00:01</Timestamp>
                            <CustNumber>12345</CustNumber>
                            <AcctNumber>54321</AcctNumber>
                        </Invoice>";

            var newxml = @"<invoive Timestamp='1/1/2017 00:01' CustNumber='12345' />";
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);

            //xml to json conversion 
            var json = JsonConvert.SerializeXmlNode(doc, Newtonsoft.Json.Formatting.Indented, true);
            Console.WriteLine(json);

            //json to xml conversion
            XmlDocument xdoc = JsonConvert.DeserializeXmlNode(json);
            Console.WriteLine(xdoc);
        }
    }
}

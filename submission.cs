using System;
using System.Xml.Schema;
using System.Xml;
using Newtonsoft.Json;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ServiceModel.Dispatcher;



/**
 * This template file is created for ASU CSE445 Distributed SW Dev Assignment 4.
 * Please do not modify or delete any existing class/variable/method names. However, you can add more variables and functions.
 * Uploading this file directly will not pass the autograder's compilation check, resulting in a grade of 0.
 * **/


namespace ConsoleApp1
{


    public class Program
    {
        public static string xmlURL = "https://raw.githubusercontent.com/lmckevit/CSE445-Assignment-4/refs/heads/main/Hotels.xml";
        public static string xmlErrorURL = "https://raw.githubusercontent.com/lmckevit/CSE445-Assignment-4/refs/heads/main/HotelsErrors.xml";
        public static string xsdURL = "https://raw.githubusercontent.com/lmckevit/CSE445-Assignment-4/refs/heads/main/Hotels.xsd";

        public static void Main(string[] args)
        {
            string result = Verification(xmlURL, xsdURL);
            Console.WriteLine(result);


            result = Verification(xmlErrorURL, xsdURL);
            Console.WriteLine(result);


            result = Xml2Json(xmlURL);
            Console.WriteLine(result);
        }

        // Q2.1
        public static string Verification(string xmlUrl, string xsdUrl)
        {
            string result = "";
            bool err = false;

            // XmlDocument xml = new XmlDocument();
            // xml.Load(xmlUrl);
            // xml.Validate();
            return result;
            //return "No Error" if XML is valid. Otherwise, return the desired exception message.
        }

        public static string Xml2Json(string xmlUrl)
        {
            string jsonText;
            XmlDocument xml = new XmlDocument();
            xml.Load(xmlUrl);
            jsonText = JsonConvert.SerializeXmlNode(xml, Newtonsoft.Json.Formatting.Indented);
            // The returned jsonText needs to be de-serializable by Newtonsoft.Json package. (JsonConvert.DeserializeXmlNode(jsonText))
            return jsonText;

        }
    }

}

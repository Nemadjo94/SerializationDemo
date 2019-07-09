using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SerializationTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test
            {
                firstName = "Nemanja",
                lastName = "Djordjevic",
                MI = "Milan"
            };

            XmlSerializer x = new XmlSerializer(test.GetType());
            Stream stream = File.OpenWrite("test1.xml");
            x.Serialize(stream, test);

            test.Dispose();

            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}

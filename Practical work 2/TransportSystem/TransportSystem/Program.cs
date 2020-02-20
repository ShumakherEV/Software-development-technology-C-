using System;
using TransportSystem.Reporters;
using System.IO;
using System.Xml.Serialization;

namespace TransportSystem
{
    /// <summary>
    /// The entry point for the application
    /// </summary>
    /// <param name="args"> Command line argument list </param>
    class Program
    {
        static void Main(string[] args)
        {
            var FilePath = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\"));
            
            Transport[] transports;
            
            XmlSerializer serializer = new XmlSerializer(typeof(Transport[]));

            if (!File.Exists(Path.Combine(FilePath, "inputXML.txt")))
            {
                using (var sw = new StreamWriter(Path.Combine(FilePath, "output.txt")))
                {
                    sw.Write("Input file not found");
                }

                return;
            }

            try
            {
                using (StreamReader reader = new StreamReader(Path.Combine(FilePath, "inputXML.txt")))
                {
                    transports = (Transport[])serializer.Deserialize(reader);
                }
            }
            catch (System.InvalidOperationException ex)
            {
                using (StreamWriter sw = new StreamWriter(Path.Combine(FilePath, "output.txt")))
                {
                    sw.WriteLine("Incorrect input");
                    sw.WriteLine(ex.Message);
                }
                return;
            }

            int carryingCapacity = 500;

            using (var sw = new StreamWriter(Path.Combine(FilePath, "output.txt")))
            {
                //IReporter reporter = new ConsoleReporter();
                IReporter reporter = new TxtReporter() { SW = sw };
                
                foreach (var t in transports)
                {
                    if (t.GetCarryingCapacity() >= carryingCapacity)
                    {
                        t.Reporter = reporter;
                        t.PrintInfo();
                    }
                }
            }
        }
    }
}

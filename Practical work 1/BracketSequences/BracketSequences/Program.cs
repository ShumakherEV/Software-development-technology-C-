using System;
using System.IO;

namespace BracketSequences
{
    class Program
    {
        /// <summary>
        /// The entry point for the application
        /// </summary>
        /// <param name="args"> Command line argument list </param>
        static void Main(string[] args)
        {
            var FilePath = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\"));           
            
            using (var sr = new StreamReader(Path.Combine(FilePath, "input.txt")))
            {
                using (var sw = new StreamWriter(Path.Combine(FilePath, "output.txt")))
                {
                    IReporter reporter = new ReporterTXT() { SW = sw };
                    BracketSequence bracketSequences = new BracketSequence() { Reporter = reporter };
                    try
                    {
                        Parse parse = new Parse();
                        
                        bracketSequences.GetBracketSequences(parse.IntParse(sr.ReadLine()));
                    }
                    catch (ArgumentException e)
                    {
                        reporter.Write(e.Message);
                    }

                }
            }
        }
    }
}

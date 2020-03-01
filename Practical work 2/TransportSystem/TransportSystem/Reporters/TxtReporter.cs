using System.Diagnostics;
using System.IO;

namespace TransportSystem.Reporters
{
    /// <summary>
    /// Class for writing reports to StreamWriter
    /// </summary>
    public class TxtReporter : IReporter
    {
        public StreamWriter SW { get; set; }

        /// <summary>
        /// Writes string to StreamWriter
        /// </summary>
        public void Write(string s)
        {
            Trace.WriteLine("Trace Information-TxtReporter.Write Starting");
            SW.WriteLine(s);
        }
    }
}

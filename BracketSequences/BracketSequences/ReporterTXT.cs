using System;
using System.IO;

namespace BracketSequences
{
    /// <summary>
    /// Class for writing reports to StreamWriter
    /// </summary>
    public class ReporterTXT: IReporter
    {
        public StreamWriter SW { get; set; }

        /// <summary>
        /// Writes string to StreamWriter
        /// </summary>
        public void Write(string s)
        {
            SW.WriteLine(s);
        }
    }
}

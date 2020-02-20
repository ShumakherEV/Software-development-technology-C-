using System;

namespace TransportSystem.Reporters
{
    /// <summary>
    /// Class for writing reports to Console
    /// </summary>
    public class ConsoleReporter : IReporter
    {
        /// <summary>
        /// Writes string to Console
        /// </summary>
        public void Write(string s)
        {
            Console.WriteLine(s);
        }
    }
}

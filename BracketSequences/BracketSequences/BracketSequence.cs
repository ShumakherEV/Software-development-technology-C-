using System;

namespace BracketSequences
{
    /// <summary>
    /// Class for work with bracket sequences
    /// </summary>
    public class BracketSequence
    {
        /// <summary>
        /// Interface for output
        /// </summary>
        public IReporter Reporter { get; set; }

        /// <summary>
        /// Returns to IReporter all bracket sequences containing n pairs of brackets
        /// </summary>
        /// <param name="n">The number of pairs of brackets</param>
        ///<exception cref="ArgumentException">Thrown when parameter is not a positive number</exception>
        public void GetBracketSequences(int n)
        {
            if (n <= 0)
            {
                throw new ArgumentException("Incorrect input, integer must be positive.");
            }

            GetBracketSequences(n, 0, 0, "");
        }

        private void GetBracketSequences(int n, int counter_open, int counter_close, string answer)
        {
            if (counter_open + counter_close == 2 * n)
            {
                Reporter.Write(answer);
                return;
            }
            if (counter_open < n)
            {
                GetBracketSequences(n, counter_open + 1, counter_close, answer + '(');
            }
            if (counter_open > counter_close)
            {
                GetBracketSequences(n, counter_open, counter_close + 1, answer + ')');
            }
        }
    }
}
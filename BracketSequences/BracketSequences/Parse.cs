using System;
using System.Collections.Generic;
using System.Text;

namespace BracketSequences
{
    public class Parse
    {
        /// <summary>
        /// Parses a string to an integer
        /// </summary>
        ///<exception cref="ArgumentException">Thrown when string is not an integer</exception>
        public int IntParse(string s)
        {
            if (!Int32.TryParse(s, out int n))
            {
                throw new ArgumentException("Incorrect input, input must be integer.");
            }
            return n;
        }
    }
}

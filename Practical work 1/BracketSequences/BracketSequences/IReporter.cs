using System;
using System.Collections.Generic;
using System.Text;

namespace BracketSequences
{
    /// <summary>
    /// Report writing interface
    /// </summary>
    public interface IReporter
    {
        public void Write(string s);
    }
}

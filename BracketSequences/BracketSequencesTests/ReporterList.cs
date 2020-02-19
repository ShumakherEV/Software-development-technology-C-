using BracketSequences;
using System.Collections.Generic;

namespace BracketSequencesTests
{
    public class ReporterList: IReporter
    {
        public List<string> list;

        public ReporterList()
        {
            list = new List<string>();
        }

        public void Write(string s)
        {
            list.Add(s);
        }
    }
}

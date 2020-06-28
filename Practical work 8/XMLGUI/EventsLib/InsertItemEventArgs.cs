using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLGUI.EventsLib
{
    public class InsertItemEventArgs : EventArgs
    {
        public Computers.Computer Param { get; internal set; }
        
        public InsertItemEventArgs(Computers.Computer paramValue)
        {
            Param = paramValue;
        }
    }
}

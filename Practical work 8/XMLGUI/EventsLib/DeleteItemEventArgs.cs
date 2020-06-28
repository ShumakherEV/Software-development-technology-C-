using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLGUI.EventsLib
{
    public class DeleteItemEventArgs : EventArgs
    {
        public int Param { get; internal set; }

        public DeleteItemEventArgs(int paramValue)
        {
            Param = paramValue;
        }
    }
}

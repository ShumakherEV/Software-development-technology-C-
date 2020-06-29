using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunawayButton.EventsLib
{
    public class AddButtonsEventArgs : EventArgs
    {
        public int Param { get; internal set; }

        public AddButtonsEventArgs(int paramValue)
        {
            Param = paramValue;
        }
    }
}

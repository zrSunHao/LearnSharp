using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnSharp.CustomEvent
{
    public class MarryEventArgs : EventArgs
    {
        public string Message { get; set; }

        public MarryEventArgs(string msg)
        {
            Message = msg;
        }
    }
}

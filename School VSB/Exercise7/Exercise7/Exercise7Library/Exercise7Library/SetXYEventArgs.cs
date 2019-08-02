using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7Library
{
    public class SetXYEventArgs : EventArgs
    {
        public DateTime Date { get; set; }
        public string Message { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6_Library
{
    public interface IObserver
    {
        void Update(Subject subject);
    }
}

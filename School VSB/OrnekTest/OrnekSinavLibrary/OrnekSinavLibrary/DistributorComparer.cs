using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrnekSinavLibrary
{
    public class DistributorComparer : IComparer
    {
        int IComparer.Compare(object a, object b)
        {
            IItem t1 = a as IItem;
            IItem t2 = b as IItem;
            if (t1 != null && t2 != null)
                return String.Compare(t1.Name, t2.Name);
            else
                throw new ArgumentException("It is not object of IItem!");
        }
    }
}

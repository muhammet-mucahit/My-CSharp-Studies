﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    public interface IMyQueue : IMyCollection
    {
        void Add(int item);
        int Get();
    }
}

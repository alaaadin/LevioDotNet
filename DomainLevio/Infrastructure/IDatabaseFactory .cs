﻿
using Data;
using DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA.Infrastructure
{
    public interface IDatabaseFactory : IDisposable
    {
        Contexte2 DataContext { get; }
    }

}

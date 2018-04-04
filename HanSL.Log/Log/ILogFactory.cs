using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HanSL.Log.Log
{
    public interface ILogFactory
    {
        ILog GetLog(string name);
    }
}

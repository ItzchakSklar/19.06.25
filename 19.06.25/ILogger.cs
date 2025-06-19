using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._06._25
{
    internal interface ILogger
    {
        bool Write(string Mission);
        string Read();
    }
}

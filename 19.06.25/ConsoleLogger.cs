using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _19._06._25
{
    internal class ConsoleLogger: ILogger
    {
        private  static ConsoleLogger Instans { get; set; }
        private ConsoleLogger() { }
        public static ConsoleLogger GetInstans() { if (Instans == null) Instans = new ConsoleLogger(); return Instans; }
        public bool Write(string Mission) 
        {
            Console.WriteLine(Mission);
            return true; 
        }
        public string Read() {return Console.ReadLine(); }
    }
}

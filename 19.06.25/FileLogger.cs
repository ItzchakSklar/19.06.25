using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _19._06._25
{
    internal class FileLogger : ILogger
    {
        private static FileLogger Instans = null;
        private static readonly string filePath = "log.txt";
        private FileLogger() { }
        public static FileLogger GetInstans() { if (Instans == null) Instans = new FileLogger(); return  Instans; }
        public bool Write(string Mission) 
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, append: true))
                {
                    writer.WriteLine($"{DateTime.Now}: {Mission}");
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"שגיאה בכתיבה לקובץ: {ex.Message}");
                return false;
            }
        }
        public string Read() 
        {
            try
            {
                if (File.Exists(filePath))
                {
                    return File.ReadAllText(filePath);
                }
                else
                {
                    return "הקובץ לא קיים.";
                }
            }
            catch (Exception ex)
            {
                return $"שגיאה בקריאה מהקובץ: {ex.Message}";
            }
        }
    }
}

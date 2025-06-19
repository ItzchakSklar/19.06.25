using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _19._06._25
{
    internal class MissionController
    {
        public static void srart()
        {
            ConsoleLogger Consol = ConsoleLogger.GetInstans();
            FileLogger File = FileLogger.GetInstans();
            bool ran = true;
            string mission;
            Console.WriteLine("welcome to MissionController System");
            while (ran)
            {
                Console.WriteLine("menu:\n1 to right a mission\n2 to read a mission");
                Console.Write("enter your choice:");
                string ChoiceRow = Console.ReadLine();
                int Choice = validatCoiceInt(ChoiceRow, 1, 2);
                Console.Clear();
                if (Choice == -1) { continue; }
                switch (Choice)
                {
                    case 1:
                        Console.WriteLine("enter your mission:");
                        mission = Consol.Read();
                        File.Write(mission);
                        break;
                    case 2:
                        mission = File.Read();
                        Consol.Write(mission);
                        break;
                }

            }
        }
        public static int validatCoiceInt(string ChoiceStr, int Min, int Max)
        {
            int Choice;
            try
            {
                 Choice = Convert.ToInt32(ChoiceStr);
            }
            catch
            {
                Console.WriteLine("Not a good fotmat");
                return -1;
            }
            if (Choice <= Max && Choice >= Min)
                return Choice;
            else Console.WriteLine("Choice not in range");
            return -1;

        }
    }
    
}

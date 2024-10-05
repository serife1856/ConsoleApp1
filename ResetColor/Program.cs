using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResetColor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            public static void Info(string message)
            {
                if (InfoFunc != null)
                {
                    InfoFunc(message);
                }
                else
                {
                    Console.ResetColor();
                    Console.WriteLine(message);
                }
            }
        }
    }
}

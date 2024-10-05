using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double vize, final, ort;
            vize = 60;
            final = 100;
            ort = vize*0.40+ final*0.60;
            // byte.maxvalue short -32k 32760
            bool kontrol = true;
            bool kontrol1 = false;
            bool sonuc = 60 < ort;
            Console.WriteLine("vize= "+vize);
            Console.WriteLine("final= " + final);
            Console.WriteLine("ortalama= " + ort);
            Console.WriteLine("sonuc= " + sonuc);
            Console.WriteLine(vize % final);
            Console.ReadKey();
        }
    }
}

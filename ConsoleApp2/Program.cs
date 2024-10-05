using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kullancı adı");
            string isim = Console.ReadLine();

            Console.WriteLine("kullanıcı soyadı");
            string soyisim= Console.ReadLine();

            Console.WriteLine("Kullanıcı vize notunu giriniz:");
            int vize;
            vize= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kullanıcı final notunu giriniz:");
            int final;
            final= Convert.ToInt32(Console.ReadLine());
            double ort;
            ort= vize*0.4+final*0.6;
             if(ort>=60)
            {
                Console.WriteLine("dersi başarılı şekilde geçtin notun:"+ort);
            }
            else
            {

                Console.WriteLine("dersten kaldın notun:"+ort);


            }  
            Console.ReadLine();
        }
    }
}

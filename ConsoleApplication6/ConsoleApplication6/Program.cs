using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            string ad; int s, k;
            Console.WriteLine("Adınızı giriniz:"); ad = Console.ReadLine();
            s = ad.Length;
            for (int i = 0; i < s; i++)
            {
                k = (int)ad[i] + 10;
                Console.Write((char)k);
            }
            Console.ReadLine();
           
        }
    }
}

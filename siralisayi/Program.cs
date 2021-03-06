using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace siralisayi
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("bir sayı giriniz");
            int sayi = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            int[] sayilar = new int[sayi];
            for (int i = 0; i < sayilar.Length; i++)
            {
              x=  rnd.Next(0, 5);
                for (int k = 0; k < i; k++)
                {
                    if (sayilar[i]==sayilar[k])
                    {
                        i--;
                        break;
                    }

                }
            }
            Array.Sort(sayilar);
            Console.WriteLine(sayilar);
            Console.ReadKey();
        }
    }
}

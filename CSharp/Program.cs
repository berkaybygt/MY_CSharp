using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sayi1, sayi2, sonuc;

            Console.Write("İlk Sayı: ");
            sayi1 = double.Parse(Console.ReadLine());

            Console.Write("İkinci Sayı: ");
            sayi2 = double.Parse(Console.ReadLine());


            if (sayi1 < 0 || sayi2 < 0)
            {
                Console.WriteLine("Pozitif Sayi Girin.");
            }
            else
            {
                sonuc = sayi1 + sayi2;
                Console.WriteLine(sonuc);

                Console.Read();
            }
        }
    }
}

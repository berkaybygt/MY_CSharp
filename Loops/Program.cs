using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For
            #region Soru1           
            // 1'den 100'e kadar olan sayıları yazdır

            //for (int i = 0; i <= 100; i++) {
            //    Console.WriteLine(i);
            //}
            #endregion

            #region Soru2
            // Tek ve çift sayıları ayır

            //for (int i = 0; i <= 50; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine($"{i}: Çift");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{i}: Tek");
            //    }
            //}
            #endregion

            #region Soru3
            //Faktöriyel

            //int sonuc = 1;
            //for (int i = 1; i <= 5; i++)
            //{
            //    sonuc *= i;               
            //}
            //Console.WriteLine(sonuc);
            #endregion

            #region Soru4
            // Yıldız

            //Console.Write("Gir: ");
            //int sayi = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= sayi; i++) {
            //    Console.WriteLine(new string('*', i *2-1));
            //}
            #endregion

            #region Soru5
            // Asal Sayı

            //Console.Write("Gir: ");
            //int inp = Convert.ToInt32(Console.ReadLine());
            //int sonuc = 0;

            //for (int i = 2; i < inp; i++)
            //{
            //    if (inp % i == 0)
            //    {
            //        sonuc += 1;
            //    }
            //}
            //if (sonuc > 0)
            //{
            //    Console.WriteLine($"{inp} Asal Degildir");
            //}
            //else
            //{
            //    Console.WriteLine($"{inp} Asaldir");
            //}
            #endregion
            #endregion

            #region While
            #region Soru1

            //int i = 1;
            //int sonuc = 0;

            //while (i <= 10) {
            //    sonuc += i;
            //    i++;
            //}
            //Console.WriteLine(sonuc);
            #endregion

            #region Soru2
            //while (true)
            //{
            //    Console.Write("Gir: ");
            //    string inp = Console.ReadLine();

            //    if (inp == "q")
            //        break;

            //    else if (inp.Length == 3)
            //    {
            //        int sayi1 = int.Parse(inp[0].ToString());
            //        int sayi2 = int.Parse(inp[1].ToString());
            //        int sayi3 = int.Parse(inp[2].ToString());
            //        int toplam = sayi1 + sayi2 + sayi3;
            //        Console.WriteLine(toplam);
            //    }
            //    else
            //    {
            //        Console.WriteLine("3 Basamakli Sayi Gir.");
            //    }
            //}
            #endregion
            #endregion
        }
    }
}

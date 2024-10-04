using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayi = { 1, 2, 3, 4, 5 };

            foreach (int i in sayi)
            {
                Console.WriteLine(sayi);
            }
            Console.Read();
        }
    }
}

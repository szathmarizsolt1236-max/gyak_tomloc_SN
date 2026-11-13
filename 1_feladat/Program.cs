using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] szamok  = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < szamok.Length; i++)
            {
                szamok[i] = rnd.Next(1,101);
            }
            int parosDb = 0;
            for (int i = 0; i < szamok.Length; i++)
            {
                parosDb++;
            }
            {

            }
            Console.WriteLine($"A páros számok száma: {parosDb}");
            Console.ReadKey();
        }
    }
}

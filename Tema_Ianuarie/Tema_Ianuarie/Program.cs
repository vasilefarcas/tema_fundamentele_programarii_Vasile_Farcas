using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_Ianuarie
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v = { 0, 1, 2, 3, 4, 6, 7, 8, 9, 10 };
            for(int i=0;i<=9;i++)
            Console.Write(v[i]+" ");
            Console.WriteLine();
            Console.WriteLine(Setul3.Problema10(10, 9, v));
            for(int i=0;i<=9;i++)
            Console.Write(v[i]+" ");
            Console.ReadKey();
        }
    }
}

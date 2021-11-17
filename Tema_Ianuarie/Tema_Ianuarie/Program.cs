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
            int[] v = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            for (int i = 0; i < v.Length; i++) 
                Console.Write(v[i]+" ");
            Setul3.Problema13(v.Length,ref v);
            Console.WriteLine();
            for (int i = 0; i < v.Length; i++) 
                Console.Write(v[i] + " ");
            Console.ReadKey();
        }
    }
}

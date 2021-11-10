using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_Ianuarie
{
    class Setul1
    {
        public static float Problema1(int a, int b) => (float)((0 - b) / a);
        public static string Problema2(int a, int b, int c)
        {
            double delta;
            delta = Math.Pow(b, 2) - 4 * a * c;
            if(delta>0)
            {
                double r1, r2;
                r1 = (double)(b * (-1) + Math.Sqrt(delta)) / 2 * a;
                r2 = (double)(b * (-1) + Math.Sqrt(delta)*(-1)) / 2 * a;
                return "Solutiile sunt "+r1+" si "+r2;
            }    
            if(delta==0)
            {
                double r;
                r = (double)(b * (-1)) / 2 * a;
                return ""+r;
            }
            return "Ecuatia nu are solutii reale.";
        }
        public static bool Problema3(int n, int k) => n % k == 0;

        public static bool Problema4(int y) => ((y % 4 == 0 && y % 100!=0) || y%400==0);

        public static int Problema5(int n, int k) => (int)(n / Math.Pow(10, k-1)) % 10;
        
        public static bool Problema6(int a,int b,int c) => a+b>c && a+c>b && b+c>a;

        public static void Problema7(ref int a, ref int b)
        {
            a += b;
            b = a - b;
            a -= b;
        }
        
        public static void Problema8(ref int a, ref int b)
        {
            a += b;
            b = a - b;
            a -= b;
        }

        public static void Problema9(int n)
        {
            int i;
            for (i = 1; i * i <= n; i++)
                if (n % i == 0)
                {
                    Console.Write(i + " ");
                    if (i * i < n)
                        Console.Write(n / i + " ");
                }
        }
        public static bool Problema10(int n)
        {
            int s = 0,i=2;
            while (i * i < n)
            {
                if (n % i == 0)
                    return false;
                i++;
            }
            return true;
        }
    }
}

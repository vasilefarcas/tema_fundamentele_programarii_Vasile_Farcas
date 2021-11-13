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
            if (delta > 0)
            {
                double r1, r2;
                r1 = (double)(b * (-1) + Math.Sqrt(delta)) / 2 * a;
                r2 = (double)(b * (-1) + Math.Sqrt(delta) * (-1)) / 2 * a;
                return "Solutiile sunt " + r1 + " si " + r2;
            }
            if (delta == 0)
            {
                double r;
                r = (double)(b * (-1)) / 2 * a;
                return "" + r;
            }
            return "Ecuatia nu are solutii reale.";
        }
        public static bool Problema3(int n, int k) => n % k == 0;

        public static bool Problema4(int y) => ((y % 4 == 0 && y % 100 != 0) || y % 400 == 0);

        public static int Problema5(int n, int k) => (int)(n / Math.Pow(10, k - 1)) % 10;

        public static bool Problema6(int a, int b, int c) => a + b > c && a + c > b && b + c > a;

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
            int i = 2;
            while (i * i < n)
            {
                if (n % i == 0)
                    return false;
                i++;
            }
            return true;
        }
        public static int Problema11(int n)
        {
            int inv = 0;
            while (n != 0)
            {
                inv = inv * 10 + n % 10;
                n /= 10;
            }
            return inv;
        }
        public static int Problema12(int n, int a, int b)
        {
            int nr = 0, i;
            for (i = a; i <= b; i++)
                if (i % n == 0)
                    nr++;
            return nr;
        }

        public static int Problema13(int a, int b)
        {
            int i, nr = 0;
            for (i = a; i <= b; i++)
                if (((i % 4 == 0 && i % 100 != 0) || i % 400 == 0))
                    nr++;
            return nr;
        }

        // Metoda Problema11 returneaza oglinditul unui numar n introdus ca parametru
        public static bool Problema14(int n) => Problema11(n) == n;

        public static string Problema15(int a, int b, int c)
        {
            int min, max, med;
            if (a > b && a > c)
                max = a;
            else
                if (b > a && b > c)
                max = b;
            else
                max = c;
            if (a < b && a < c)
                min = a;
            else
                if (b < a && b < c)
                min = b;
            else
                min = c;
            med = a + b + c - max - min;
            return "" + min + ' ' + med + ' ' + max;
        }

        // ordonare a 3 variabile cu transmitere prin referinta
        public static void OrdTreiRef(ref int a, ref int b, ref int c)
        {
            int min, max, med;
            if (a > b && a > c)
                max = a;
            else
                if (b > a && b > c)
                max = b;
            else
                max = c;
            if (a < b && a < c)
                min = a;
            else
                if (b < a && b < c)
                min = b;
            else
                min = c;
            med = a + b + c - max - min;
            a = min;
            b = med;
            c = max;
        }

        public static string Problema16(int a, int b, int c, int d, int e)
        {
            while (a > b || a > c || a > d || a > e || b > c || b > d || b > e || c > d || c > e || d > e)
            {
                OrdTreiRef(ref a, ref b, ref c);
                OrdTreiRef(ref b, ref c, ref d);
                OrdTreiRef(ref c, ref d, ref e);
            }
            return "" + a + ' ' + b + ' ' + c + ' ' + d + ' ' + e;
        }
        public static int Problema17(int a, int b)
        {
            while (a != b)
            {
                if (a > b)
                    a -= b;
                else
                    b -= a;
            }
            return a;
        }
        
        // descompunere in factori primi
        public static void Problema18(int n)
        {
            int d = 2, nr = 0;
            while(n!=0)
            {
                if(n%d==0)
                { 
                    nr = 0;
                    while(n%d==0)
                    {
                        n /= d;
                        nr++;
                    }
                if(n>1)
                Console.Write("" + d + '^' + nr+" x ");
                else
                Console.Write("" + d + '^' + nr);

                }
                d++;
            }
        }

        public static bool Problema19(int n)
        {
            int a, b;
            a = n % 10;
            while (n % 10 == a)
                n /= 10;
            b = n % 10;
            while (n != 0)
            {
                if (n % 10 != a && n % 10 != b)
                    return false;
                n /= 10;
            }
                return true;
        }
        
        public static int Problema20(int n, int m)
        {
            return 0;
        }

        public static void Problema21()
        {
            Random m = new Random(1024);
            int n = m.Next(0,1025);
            for(int i=0;i<=4;i++)
                Console.WriteLine(m.Next(0,1025));
            Console.WriteLine(n);
            int guess=0;
            while(guess!=n)
            {
                Console.WriteLine("Ghiceste numarul:");
                guess = int.Parse(Console.ReadLine());
                if(guess>n)
                    Console.WriteLine("Numarul secret este mai mic. Incearca din nou!");
                if (guess < n)
                    Console.WriteLine("Numarul secret este mai mare. Incearca din nou!");
                if(guess == n)
                    Console.WriteLine("Felicitari! Tocmai ai ghicit numarul secret!");
            }
        }
    }
}

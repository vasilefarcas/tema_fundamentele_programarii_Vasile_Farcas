using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_Ianuarie
{
    class Setul2
    {
        public static int Problema1(int n)
        {
            int i = 0, v = 0;
            while (v < n)
            {
                if (int.Parse(Console.ReadLine()) % 2 == 0)
                    i++;
                v++;
            }
            return i;
        }

        public static string Problema2(int n)
        {
            int nr, v = 0, poz = 0, neg = 0, nul = 0;
            while (v < n)
            {
                nr = int.Parse(Console.ReadLine());
                if (nr == 0)
                    nul++;
                if (nr < 0)
                    neg++;
                if (nr > 0)
                    poz++;
                v++;
            }
            return "" + neg + " numere negative." + '\n' + poz + " numere pozitive." + '\n' + nul + " numere nule.";
        }

        public static string Problema3(int n)
        {
            int i, s = 0, p = 1;
            for (i = 0; i <= n; i++)
            {
                s += i;
                p *= i;
            }
            return "Suma numerelor de la 1 la " + n + " este: " + s + '\n' + "Produsul numerelor de la 1 la " + n + " este: " + p;
        }

        public static int Problema4(int n, int a)
        {
            int i = 0, m;
            m = int.Parse(Console.ReadLine());
            while (m != a && i < n - 1)
            {
                i++;
                m = int.Parse(Console.ReadLine());
            }
            if (n == i)
                return -1;
            return i;
        }

        public static int Problema5(int n)
        {
            int nr = 0,i,m;
            for(i=0;i<n;i++)
            {
                m = int.Parse(Console.ReadLine());
                if (m == i)
                    nr++;
            }
            return nr;
        }

        public static bool Problema6(int n)
        {
            int m, p, q, i;
            bool ok = true;
            for(i=0;i<n;i++)
            {
                m = int.Parse(Console.ReadLine());

            }
            return true;
        }

        public static string Problema7(int n)
        {
            int i,m, min = 32000, max = 32000;
            for(i=0;i<n;i++)
            {
                m = int.Parse(Console.ReadLine());
                if (m < min)
                    min = m;
                if (m > max)
                    max = m;
            }
            return "Minimul din sir este " + min + '\n' + "Iar maximul din sir este " + max;
        }

        public static int Problema8(int n)
        {
            int aux, f=1, i, f1 = 1, f2 = 0,f3;
            for(i=0;i<n-1;i++)
            {
                f3 = f + f1;
                f2 = f1;
                f1 = f;
                f = f3;
            }
            return f2;
        }

        public static bool Problema9(int n)
        {
            int i,m,p;
            m = int.Parse(Console.ReadLine());
            p = int.Parse(Console.ReadLine());
            if(m>p)
            {
                for(i=2;i<n;i++)
                {
                m = p;
                p = int.Parse(Console.ReadLine());
                    if (m < p)
                        return false;
                }
            }
            if(m<p)
            {
                for (i = 2; i < n; i++)
                {
                    m = p;
                    p = int.Parse(Console.ReadLine());
                    if (m > p)
                        return false;
                }
            }
            return true;
        }

        public static int Problema10(int n)
        {
            int i, nr, maxi = 0;
            for(i=0;i<n;i++)
            {
                nr = int.Parse(Console.ReadLine());
                
                while()
            }
        }
    }

}

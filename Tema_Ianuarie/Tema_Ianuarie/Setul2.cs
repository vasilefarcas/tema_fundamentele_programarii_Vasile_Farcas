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
            int nr2, i, q, nr, maxi = 0;
                nr = int.Parse(Console.ReadLine());
            
            for(i=1;i<n;i++)
            {
                q=1;
                nr2= int.Parse(Console.ReadLine());
                while (nr == nr2 &&  i<n)
                {
                    nr2= int.Parse(Console.ReadLine());
                    q++;
                    i++;
                }
                nr = nr2;
                if (q > maxi)
                    maxi = q;
            }
            return maxi;
        }

        public static int Problema11(int n)
        {
            int i, suma = 0;
            for(i=0;i<n;i++)
            {
                // Setul2.Problema11() returneaza oglinditul unui numar.
                suma += Setul1.Problema11(Convert.ToInt32(Console.ReadLine()));
            }
            return suma;
        }

        public static int Problema12(int n)
        {
            int nr = 0;
            string sir;
            string[] sir_desp;
            sir = Console.ReadLine();
            sir_desp = sir.Split('0');
            for (int i = 0; i < sir_desp.Length; i++)
                if (sir_desp[i].Length > 2)
                    nr++;
            return nr;
        }

        public static bool Problema13(int n)
        {
            int i, m, p;
            m = int.Parse(Console.ReadLine());
            p = int.Parse(Console.ReadLine());
            if (m < p)
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

        public static int Problema14(int n)
        {
            return 0;
        }

        public static bool Problema15(int n)
        {
            int i=2, nr, nr2;
            nr = Convert.ToInt32(Console.ReadLine());
            nr2 = Convert.ToInt32(Console.ReadLine());
            if (nr > nr2)
            {
                while (nr >= nr2 && i<=n)
                {
                    nr = nr2;
                    nr2 = Convert.ToInt32(Console.ReadLine());
                    i++;
                }
                if (i == n)
                    return false;
                while(nr<=nr2 && i<=n)
                {
                    nr = nr2;
                    nr2 = Convert.ToInt32(Console.ReadLine());
                    i++;
                }
                if (i < n)
                    return false;
            }
            if (nr < nr2)
            {
                while (nr <= nr2 && i <= n)
                {
                    nr = nr2;
                    nr2 = Convert.ToInt32(Console.ReadLine());
                    i++;
                }
                if (i == n)
                    return false;
                while (nr >= nr2 && i <= n)
                {
                    nr = nr2;
                    nr2 = Convert.ToInt32(Console.ReadLine());
                    i++;
                }
                if (i < n)
                    return false;
            }

            return true;
        }


    }

}

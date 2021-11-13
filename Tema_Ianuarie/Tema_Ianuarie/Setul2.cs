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
            int i=0,v=0;
            while(v<n)
            {
                if (int.Parse(Console.ReadLine()) % 2 == 0)
                    i++;
                v++;
            }
            return i;
        }
        
        public static string Problema2(int n)
        {
            int nr,v = 0, poz=0,neg=0,nul=0;
            while (v < n)
            {
                nr = int.Parse(Console.ReadLine());
                if (nr== 0)
                    nul++;
                if (nr< 0)
                    neg++;
                if (nr > 0)
                    poz++;
                v++;
            }
            return ""+ neg + " numere negative."+'\n' + poz + " numere pozitive." + '\n' + nul + " numere nule.";
        }
        
        public static string Problema3(int n)
        {
            int i, s = 0, p = 1 ;
            for(i=0;i<=n;i++)
            {
                s += i;
                p *= i;
            }
            return "Suma numerelor de la 1 la "+n+" este: "+s+'\n'+"Produsul numerelor de la 1 la " + n + " este: " + p;
        }
        public static int Problema4(int n, int a)
        {
            int i = 0;
            while (int.Parse(Console.ReadLine()) != a || i < n)
                i++;
            if (n == i)
                return -1;
            return i;
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_Ianuarie
{
    class Setul3
    {
        public static int Problema1(int n, int[] v) => v.Sum();

        public static int Problema2(int n, int k, int[] v) => Array.IndexOf(v, k);

        public static string Problema3(int n, int[] v) => "Cel mai mic se afla pe pozitia: " + Array.IndexOf(v, v.Min())+'\n'+ "Cel mai mare se afla pe pozitia: " + Array.IndexOf(v, v.Max());
        
        public static void Problema4(int n, int[] v)
        {
            int i=0,nrmin=0,nrmax=0, min = v.Min(), max = v.Max();
            Console.WriteLine("Valoarea minima din vector este: "+min);
            Console.WriteLine("Valoarea maxima din vector este: "+min);
            for (; i < n; i++) 
            {
                if (v[i] == min)
                    nrmin++;
                if (v[i] == max)
                    nrmax++;
            }
            Console.WriteLine("Valoarea minima apare de: " + nrmin + " ori.");
            Console.WriteLine("Valoarea maxima apare de: " + nrmax + " ori.");
        }

        public static void Problema5(int n, int e, int k,ref int[] v)
        {
            int i;
            Array.Resize(ref v, v.Length + 1);
            for (i = n-1; i >= k; i--) 
                v[i + 1] = v[i];
            v[i + 1] = e;
        }

        public static void Problema6(int n, int k, ref int[] v)
        {
            for (int i = k + 1; i < n; i++)
                v[i - 1] = v[i];
            Array.Resize(ref v, v.Length - 1);
        }

        public static void Problema7(int n, ref int[] v) => Array.Reverse(v);

        public static void Problema8(int n, ref int[] v)
        {
            int ultimul = v[0];
            for (int i = 1; i < n ; i++)
                v[i - 1] = v[i];
            v[n - 1] = ultimul;
        }

        public static void Problema9(int n,int k, ref int[] v)
        {
            while (k > 0)
            {
                Setul3.Problema8(n, ref v);
                k--;
            }
        }

        public  static int Problema10(int n, int k, int[] v)
        {
            int s = 0, d = v.Length - 1, m = (s + d) / 2;
            while(s<=d)
            {
                if (v[m] == k)
                    return m;
                if (v[m] > k)
                    d = m - 1;
                if (v[m] < k)
                    s = m + 1;
                m = (s + d) / 2;
            }
            return -1;
        }

        public static void Problema11(int n)
        {
            int q;
            int[] v = new int[n+1];
            for (int i = 1; i <= n; i++)
                v[i] = 1;
            for(int i=2;i<=n;i++)
            {
                if(v[i]==1)
                {
                    q = i;
                    q = q + i;
                    while(q<=n)
                    {
                        v[q] = 0;
                        q = q + i;
                    }
                }
            }
              
            for(int i=1;i<=n;i++)
                if(v[i]==1)
                    Console.WriteLine(i);
        }

        public static void Problema12(int n, ref int[] v)
        {
            int i, j,min,aux,poz;
            for(i=0;i<n-1;i++)
            {
                min = v[i + 1];
                poz = i + 1;
                for(j=i;j<n;j++)
                {
                    if (v[j] < min)
                    {
                        min = v[j];
                        poz = j;
                    }
                }
                aux = v[poz];
                v[poz] = v[i];
                v[i] = aux;
            }
        }

        public static void Problema13(int n, ref int[] v)
        {
            int i, j, aux;
            for (i = 1; i < n; i++)
            {
                aux = v[i];
                j = i - 1;
                while(j>=0 && v[j]>aux)
                {
                    v[j + 1] = v[j];
                    j = j - 1;
                }
                v[j + 1] = aux;
            }
        }

        public static void Problema14(int n, ref int[] v)
        {
            int q = n - 1, i, k, aux;
            for (i = 0; i < n && q>i; i++)
                if (v[i] == 0)
                {
                    Swap(ref v[i], ref v[q]);
                    q--;
                }
        }

        public static void Swap(ref int a, ref int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
        }

        public static void Problema15(ref int n, ref int[] v)
        {
            int i, aux,q,j;
            for(i=0;i<n-1;i++)
            {
                for (j = i + 1; j < n; j++)
                    if (v[j] == v[i])
                    {
                        for(q=j; q < n-1;q++)
                            v[q] = v[q + 1];
                        j--;
                        Array.Resize(ref v, n - 1);
                        n--;
                    }
            }
        }

        public static void Problema16(int n, int[] v)
        {

        }
    }
}

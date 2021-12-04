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

        public static string Problema3(int n, int[] v) => "Cel mai mic se afla pe pozitia: " + Array.IndexOf(v, v.Min()) + '\n' + "Cel mai mare se afla pe pozitia: " + Array.IndexOf(v, v.Max());

        public static void Problema4(int n, int[] v)
        {
            int i = 0, nrmin = 0, nrmax = 0, min = v.Min(), max = v.Max();
            Console.WriteLine("Valoarea minima din vector este: " + min);
            Console.WriteLine("Valoarea maxima din vector este: " + min);
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

        public static void Problema5(int n, int e, int k, ref int[] v)
        {
            int i;
            Array.Resize(ref v, v.Length + 1);
            for (i = n - 1; i >= k; i--)
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
            for (int i = 1; i < n; i++)
                v[i - 1] = v[i];
            v[n - 1] = ultimul;
        }

        public static void Problema9(int n, int k, ref int[] v)
        {
            while (k > 0)
            {
                Setul3.Problema8(n, ref v);
                k--;
            }
        }

        public static int Problema10(int n, int k, int[] v)
        {
            int s = 0, d = v.Length - 1, m = (s + d) / 2;
            while (s <= d)
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
            int[] v = new int[n + 1];
            for (int i = 1; i <= n; i++)
                v[i] = 1;
            for (int i = 2; i <= n; i++)
            {
                if (v[i] == 1)
                {
                    q = i;
                    q = q + i;
                    while (q <= n)
                    {
                        v[q] = 0;
                        q = q + i;
                    }
                }
            }

            for (int i = 1; i <= n; i++)
                if (v[i] == 1)
                    Console.WriteLine(i);
        }

        public static void Problema12(int n, ref int[] v)
        {
            int i, j, min, aux, poz;
            for (i = 0; i < n - 1; i++)
            {
                min = v[i + 1];
                poz = i + 1;
                for (j = i; j < n; j++)
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
                while (j >= 0 && v[j] > aux)
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
            for (i = 0; i < n && q > i; i++)
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
            int i, aux, q, j;
            for (i = 0; i < n - 1; i++)
            {
                for (j = i + 1; j < n; j++)
                    if (v[j] == v[i])
                    {
                        for (q = j; q < n - 1; q++)
                            v[q] = v[q + 1];
                        j--;
                        Array.Resize(ref v, n - 1);
                        n--;
                    }
            }
        }

        public static int Problema16(int n, int[] v)
        {
            int i = 1, cmmdc = v[0];
            for (; i < n; i++)
            {
                cmmdc = Setul1.Problema17(cmmdc, v[i]);  // Problema17 din setul1 calculeaza cmmdc 
            }
            return cmmdc;
        }

        public static void Problema17(int n, int b)
        {
            char[] v = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            char[] s = new char[33];
            int i = 0;
            while (n != 0)
            {
                i++;
                Array.Resize(ref s, i + 1);
                s[i] = Convert.ToChar(v[n % b]);
                n /= b;
            }
            Array.Reverse(s);
            Console.WriteLine(s);
        }

        public static int Problema18(int[] v)
        {
            int sum = 0, i = 0;
            for (; i < v.Length; i++)
                sum = sum + Convert.ToInt32(Math.Pow(Convert.ToDouble(v[i]), Convert.ToDouble(v.Length - i)));
            return sum;
        }

        public static int Problema19(int[] v, int[] p)
        {
            int nr = 0, i = 0, j;
            int l1 = v.Length;
            int l2 = p.Length;
            for (; i < l1 - l2; i++)
            {
                if (v[i] == p[0])
                {
                    j = 0;
                    while ((v[i + j] == p[j] && v[i + l2 - 1 - j] == p[l2 - j - 1]) && (j < l2 / 2))
                        j++;
                    if (l2 % 2 == 0)
                    {
                        if (j * 2 == l2)
                            nr++;
                    }
                    else
                        if (j * 2 + 1 == l2)
                    {
                        nr++;
                    }
                }
            }
            return nr;
        }

        public static int Problema20(int[] s1, int[] s2)
        {
            int i, nr = 0;
            for (i = 0; i < s1.Length - 1; i++)
                if (s1[i] == s2[i])
                    nr++;
            return nr;
        }

        public static string Problema21(string a, string b)
        {
            int i = 0;
            while (Char.ToLower(a[i]) == Char.ToLower(b[i]))
                i++;
            if (Char.ToLower(a[i]) > Char.ToLower(b[i]))
                return b;
            return a;
        }

        public static void Problema22(int[] v1, int[] v2)
        {
            int i, j, l1 = v1.Length, l2 = v2.Length;
            Setul3.Problema15(ref l1, ref v1);   // problema 15 scoate din vector duplicatele 
            Setul3.Problema15(ref l2, ref v2);
            Console.WriteLine("Intersectia este:");
            for (i = 0; i < l1; i++)
                for (j = 0; j < l2; j++)
                    if (v1[i] == v2[j])
                        Console.Write("" + v1[i] + ' ');
            Console.WriteLine("\nReuniunea este:");
            int[] v12 = v1;
            Array.Resize(ref v12, l1 + l2 + 1);
            for (i = l1, j = 0; i < l1 + l2 && j <= l2; i++, j++)
                v12[i] = v2[j];
            int l12 = v12.Length - 1;
            Setul3.Problema15(ref l12, ref v12);
            for (i = 0; i < l12; i++)
                Console.Write("" + v12[i] + " ");
        }

        public static void Problema25(int[] v1, int[] v2)
        {
            Array.Sort(v1);
            Array.Sort(v2);
            int i = 0, j = 0, q = 0, l1 = v1.Length, l2 = v2.Length;
            int[] v12 = new int[l1 + l2];
            while (i < l1 && j < l2)
            {
                if (v1[i] < v2[j])
                {
                    v12[q] = v1[i];
                    i++;
                }
                else
                {
                    v12[q] = v2[j];
                    j++;
                }
                q++;
            }
            while (i < l1)
            {
                v12[q] = v1[i];
                q++;
                i++;
            }
            while (j < l2)
            {
                v12[q] = v2[j];
                q++;
                j++;
            }
            Console.WriteLine(q);
            for (i = 0; i < q; i++)
                Console.Write("" + v12[i] + " ");
        }

        public static void Problema26(int[] a, int[] b)
        {
            int l1 = a.Length, l2 = b.Length, i, j, ok = 0, lun = Math.Min(l1, l2);
            // Adunarea
            char[] c = new char[Math.Max(l1, l2)+1];
            for (i = 0; i < lun; i++)
            {
                c[i] = Convert.ToChar(((a[i] + b[i]) + ok) % 10);
                ok = 0;
                if (a[i] + b[i] > 9)
                    ok = 1;
            }
            if (lun == l1)
                while (i < Math.Max(l1, l2)-1)
                {
                    c[i] = Convert.ToChar((b[i] + ok) % 10);
                    i++;
                }
            else
                if (lun == l2)
                while (i < Math.Max(l1, l2)-1)
                {
                    c[i] = Convert.ToChar((a[i] + ok) % 10);
                    i++;
                }
            Array.Reverse(c);
            i = 0;
            while (Convert.ToInt32(c[i]) == 0)
                i++;
            for (; i < c.Length; i++)
                Console.Write(Convert.ToInt32(c[i]));

        }

        public static int Problema27(int[] v, int k)
        {
            int val = v[k];
            Array.Sort(v);
            return Array.IndexOf(v, val);
        }


    }
}

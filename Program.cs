using System;


namespace Массивы_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] wc = new int[] { 1, 6, 3, 5, 7, 8, 9 };
           Console.WriteLine("Стасик 1");
            SnowOne(wc);
            int t = SnowOne(wc);
            Console.WriteLine(t);
            Console.WriteLine("Стасик 2");
            SnowTwo(wc);
            int h = SnowTwo(wc);
            Console.WriteLine(h);
            Console.WriteLine("Стасик 3");
            SnowFour(wc);
            int r = SnowFour(wc);
            Console.WriteLine(r);

        }
        public static int SnowOne(int[] wc)
        {
            
            int t = wc[0];

            for (int a = 0; a < wc.Length; a++)
            {


                if (wc[a] > t)
                {
                    t = wc[a];
                }

            }
            return t;
        }
        public static int SnowTwo(int[] wc)
        {
            
            int h = 0;
            for (int b = 0; b < wc.Length; b++)
            {
                if (wc[b] == h)
                {
                    h = wc[b];
                }
            }
            return h;
        }
        public static int SnowFour(int[] wc)
        {
            
            int r = 0;
            for (int v = 0; v < wc.Length; v++)
            {
                r += wc[v];
            }
            return r;
        }
    }
}

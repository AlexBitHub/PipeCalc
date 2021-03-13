using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace PipeCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> li = new List<int>();
            //int[] mass = new int[] { 1, 2, 3, 4 };

            //string s1 = "Super";
            //string s2 = "Jho";
            //Testing(mass, s1, s2);
            //foreach (var item in mass)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(s1 + s2);
            //Dictionary<int, string> di = new Dictionary<int, string> { { 1 : "sdf"}, {2 : "gergerg"} };

            //Dictionary<int, string> countries = new Dictionary<int, string>
            //{
            //    {20, "ГэПариж"},
            //    {17, "Берлин"},
            //    {15, "Лондон"}
            //};
            //Console.WriteLine(countries[20]);
            //int a = 0; int b = 0; int c = 1; int d = 2; int e = 10; int g = 11;
            //(a, b, c, d) = (c, d, e, g);
            //Console.WriteLine($"{a} {b} {c} {d}");

            //var xSpo = new List<int>(Enumerable.Range(0, 120)).Where(x => x % 5 == 0).ToList();
            //foreach (var item in xSpo)
            //{
            //    Console.WriteLine(item);
            //}

            FactoryClasses.CreateData();
        }

        static void Testing(int[] mas, string st1, string st2)
        {
            //string temp = st1;
            //st1 = st2;
            //st2 = temp;
            
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = mas[i] * 3;
            }
            mas = new int[] { 12, 23, 34, 35 };
            foreach (var item in mas)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(st1 + st2);
        }
        static void TestTime()
        {
            float[] x = new float[1000000];
            float[] z = new float[1000000];
            float[] h = new float[1000000];
            Random ran = new Random(50);
            int[] zSt = { 100, 400, 600, 900 };
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = i;
                z[i] = ran.Next(80, 150);
            }

            Stopwatch sw = Stopwatch.StartNew();

            for (int i = 0; i < x.Length; i++)
            {
                if (zSt.Contains(i))
                    h[i] = i - 500;
                else
                    h[i] = z[i] + 10;
            }
            sw.Stop();

            //foreach (var item in h)
            //{
            //    Console.WriteLine(item);
            //}
            Console.WriteLine(sw.ElapsedMilliseconds);
        }
        static void TestTimeDict()
        {
            float[] x = new float[1000000];
            float[] z = new float[1000000];
            float[] h = new float[1000000];

            var dict = x.Zip(z, (xc, zc) => new { xc, zc }).
                ToDictionary(item => item.xc, item => item.zc);

            for (int i = 0; i < dict.Count; i++)
            {
                if (dict[i] == 100 || dict[i] == 400 || dict[i] == 600 || dict[i] == 900)
                    h[i] = i - 500;
                else
                    h[i] = z[i] + 10;
            }
        }
    }
}

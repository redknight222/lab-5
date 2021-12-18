using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 15;
            Random random = new Random();
            int[] my_array = new int[n];
            for (int i = 0; i < n; i++)
            {
                my_array[i] = random.Next(0, 51);
            }
            int max = my_array[0];
            int min = my_array[0];
            foreach (int a in my_array)
            {
                max = (a > max) ? a : max;
                min = (a > min) ? min : a;
            }
            foreach (int a in my_array)
            {
                Console.Write("{0} ", a);
            }
            Console.WriteLine();
            Console.WriteLine(max);
            Console.WriteLine(min);
            Console.WriteLine("max and min mean = {0}", max + min);
            Console.ReadKey();
        }
    }
}

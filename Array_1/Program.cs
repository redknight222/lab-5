using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 7;
            int[] my_array = new int[n];
            float S = 0;
            for (int i = 0; i < n; i++)
            {
                my_array[i] = Convert.ToInt32(Console.ReadLine());
                S += my_array[i];
            }
            Console.WriteLine("arithmetic mean = {0:f2}", S / n);
            Console.ReadKey();
        }
    }
}

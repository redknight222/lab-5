using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 20;
            Random random = new Random();
            int[] my_array = new int[n];
            for (int i = 0; i < n; i++)
            {
                my_array[i] = random.Next(-51, 51);
            }
            int num_elements = 0;
            for (int i = 0; i < n; i++)
            {
                if ((my_array[i] % 2 != 0) & (my_array[i] > 0))
                {
                    num_elements = (i % 2 == 0) ? num_elements + 1 : num_elements + 0;
                }     
            }
            foreach (int a in my_array)
            {
                Console.Write("{0,4} ", a);
            }
            Console.WriteLine();
            Console.WriteLine("{0,4} ", num_elements);
            Console.ReadKey();
        }
    }
}

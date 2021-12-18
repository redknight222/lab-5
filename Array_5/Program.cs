using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            int[] initial_array = new int[n*n];
            int[,] my_array = new int[n, n];
            initial_array[0] = 0;
            for (int i = 0; i < n*n; i++)
            {
                if (i==0)
                {
                    initial_array[i] = 1;
                }
                else
                {
                    initial_array[i] = (initial_array[i - 1] == 0) ? 1 : 0;
                }
            }
            int k = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    my_array[i, j] = initial_array[k];
                    k += 1;
                    Console.Write("{0,4} ", my_array[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
